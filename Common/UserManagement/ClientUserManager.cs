﻿using System;
using Connections;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Utils;

namespace UserManagement
{
    /// <inheritdoc />
    /// <summary>
    /// Client-side variant of <c>UserManager</c>.
    /// Used to store states of other users for easy lookup with other modules.
    /// </summary>
    public class ClientUserManager : UserManager
    {
        /// <inheritdoc />
        public override event EventHandler<LogEventArgs> OnLogEntry;
        /// <inheritdoc />
        public override void RaiseLogEntry(LogEventArgs e) => OnLogEntry?.Invoke(this, e);

        /// <summary>
        /// Raised on a successful login attempt.
        /// </summary>
        public event EventHandler<LoginEventArgs> OnLoginSuccess;
        /// <summary>
        /// Raised on a failed login attempt.
        /// </summary>
        public event EventHandler<LoginEventArgs> OnLoginFailure;

        /// <summary>
        /// Whether the client is logged in to the server.
        /// </summary>
        public bool LoggedIn { get; private set; }
        
        /// <summary>
        /// UUID used by other users to identify the user.
        /// </summary>
        public string Uuid { get; private set; }

        /// <summary>
        /// <c>NetClient</c> to send packets through and bind events to.
        /// </summary>
        private NetClient netClient;

        /// <summary>
        /// Display name of the user.
        /// </summary>
        private string displayName;

        /// <summary>
        /// Whether the server should update it's copy of the user's display name with the one provided on login.
        /// </summary>
        private bool useServerDisplayName;

        /// <summary>
        /// Session identifier to use when sending packets to the server.
        /// Set through <c>SendLoginPacket</c>.
        /// </summary>
        private string sessionId;
        
        /// <summary>
        /// Stores each user in an easily-serialisable format.
        /// </summary>
        protected override UserStore userStore { get; set; }
        /// <summary>
        /// Lock for user store operations.
        /// </summary>
        protected override object userStoreLock => new object();

        public ClientUserManager(NetClient netClient, string displayName, bool useServerDisplayName = false)
        {
            this.netClient = netClient;
            this.displayName = displayName;
            this.useServerDisplayName = useServerDisplayName;
            
            this.userStore = new UserStore();
            
            netClient.RegisterPacketHandler(MODULE_NAME, packetHandler);
        }

        /// <summary>
        /// Attempts to log in to the server.
        /// <c>SessionId</c> should be the session ID for an existing, valid, authenticated session.
        /// </summary>
        /// <param name="sessionId">Existing session ID</param>
        public void SendLogin(string sessionId)
        {
            // Cache the session ID for later
            this.sessionId = sessionId;
            
            // Create and pack a new LoginPacket
            LoginPacket packet = new LoginPacket
            {
                SessionId = sessionId,
                DisplayName = displayName,
                UseServerDisplayName = useServerDisplayName
            };
            Any packedPacket = Any.Pack(packet, "Phinix");
            
            // Send it on its way
            netClient.Send(MODULE_NAME, packedPacket.ToByteArray());
        }
        
        /// <summary>
        /// Handles incoming packets.
        /// </summary>
        /// <param name="module">Destination module</param>
        /// <param name="connectionId">Original connection ID</param>
        /// <param name="data">Data payload</param>
        private void packetHandler(string module, string connectionId, byte[] data)
        {
            // Validate the packet and discard it if it fails
            if (!ProtobufPacketHelper.ValidatePacket("UserManagement", MODULE_NAME, module, data, out Any message,out TypeUrl typeUrl)) return;

            // Determine what to do with this packet type
            switch (typeUrl.Type)
            {
                case "LoginResponsePacket":
                    // TODO: LoginResponsePacket handling
                    RaiseLogEntry(new LogEventArgs("Got a LoginResponsePacket", LogLevel.DEBUG));
                    break;
                default:
                    RaiseLogEntry(new LogEventArgs("Got an unknown packet type (" + typeUrl.Type + "), discarding...", LogLevel.DEBUG));
                    break;
            }
        }

        /// <summary>
        /// Handles incoming <c>LoginResponsePacket</c>s.
        /// </summary>
        /// <param name="connectionId">Original connection ID</param>
        /// <param name="packet">Incoming <c>LoginResponsePacket</c></param>
        private void loginResponsePacketHandler(string connectionId, LoginResponsePacket packet)
        {
            if (packet.Success)
            {
                // Set module states
                LoggedIn = true;
                Uuid = packet.Uuid;
                
                // Raise login success event
                OnLoginSuccess?.Invoke(this, new LoginEventArgs());
            }
            else
            {
                // Set module states
                LoggedIn = false;
                Uuid = null;
                
                // Raise login failure event
                OnLoginFailure?.Invoke(this, new LoginEventArgs(packet.FailureReason, packet.FailureMessage));
            }
        }
    }
}
