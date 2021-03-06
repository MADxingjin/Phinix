// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Packets/LoginPacket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UserManagement {

  /// <summary>Holder for reflection information generated from Packets/LoginPacket.proto</summary>
  public static partial class LoginPacketReflection {

    #region Descriptor
    /// <summary>File descriptor for Packets/LoginPacket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LoginPacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQYWNrZXRzL0xvZ2luUGFja2V0LnByb3RvEg5Vc2VyTWFuYWdlbWVudCJs",
            "CgtMb2dpblBhY2tldBIRCglTZXNzaW9uSWQYASABKAkSHAoUVXNlU2VydmVy",
            "RGlzcGxheU5hbWUYAiABKAgSEwoLRGlzcGxheU5hbWUYAyABKAkSFwoPQWNj",
            "ZXB0aW5nVHJhZGVzGAQgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UserManagement.LoginPacket), global::UserManagement.LoginPacket.Parser, new[]{ "SessionId", "UseServerDisplayName", "DisplayName", "AcceptingTrades" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LoginPacket : pb::IMessage<LoginPacket> {
    private static readonly pb::MessageParser<LoginPacket> _parser = new pb::MessageParser<LoginPacket>(() => new LoginPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UserManagement.LoginPacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginPacket(LoginPacket other) : this() {
      sessionId_ = other.sessionId_;
      useServerDisplayName_ = other.useServerDisplayName_;
      displayName_ = other.displayName_;
      acceptingTrades_ = other.acceptingTrades_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginPacket Clone() {
      return new LoginPacket(this);
    }

    /// <summary>Field number for the "SessionId" field.</summary>
    public const int SessionIdFieldNumber = 1;
    private string sessionId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SessionId {
      get { return sessionId_; }
      set {
        sessionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "UseServerDisplayName" field.</summary>
    public const int UseServerDisplayNameFieldNumber = 2;
    private bool useServerDisplayName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool UseServerDisplayName {
      get { return useServerDisplayName_; }
      set {
        useServerDisplayName_ = value;
      }
    }

    /// <summary>Field number for the "DisplayName" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private string displayName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "AcceptingTrades" field.</summary>
    public const int AcceptingTradesFieldNumber = 4;
    private bool acceptingTrades_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AcceptingTrades {
      get { return acceptingTrades_; }
      set {
        acceptingTrades_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SessionId != other.SessionId) return false;
      if (UseServerDisplayName != other.UseServerDisplayName) return false;
      if (DisplayName != other.DisplayName) return false;
      if (AcceptingTrades != other.AcceptingTrades) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SessionId.Length != 0) hash ^= SessionId.GetHashCode();
      if (UseServerDisplayName != false) hash ^= UseServerDisplayName.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (AcceptingTrades != false) hash ^= AcceptingTrades.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SessionId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SessionId);
      }
      if (UseServerDisplayName != false) {
        output.WriteRawTag(16);
        output.WriteBool(UseServerDisplayName);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (AcceptingTrades != false) {
        output.WriteRawTag(32);
        output.WriteBool(AcceptingTrades);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SessionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SessionId);
      }
      if (UseServerDisplayName != false) {
        size += 1 + 1;
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (AcceptingTrades != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginPacket other) {
      if (other == null) {
        return;
      }
      if (other.SessionId.Length != 0) {
        SessionId = other.SessionId;
      }
      if (other.UseServerDisplayName != false) {
        UseServerDisplayName = other.UseServerDisplayName;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.AcceptingTrades != false) {
        AcceptingTrades = other.AcceptingTrades;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            SessionId = input.ReadString();
            break;
          }
          case 16: {
            UseServerDisplayName = input.ReadBool();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 32: {
            AcceptingTrades = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
