// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Stores/ChatMessageStore.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Chat {

  /// <summary>Holder for reflection information generated from Stores/ChatMessageStore.proto</summary>
  public static partial class ChatMessageStoreReflection {

    #region Descriptor
    /// <summary>File descriptor for Stores/ChatMessageStore.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatMessageStoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1TdG9yZXMvQ2hhdE1lc3NhZ2VTdG9yZS5wcm90bxIEQ2hhdBofZ29vZ2xl",
            "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byJ5ChBDaGF0TWVzc2FnZVN0b3Jl",
            "EhEKCU1lc3NhZ2VJZBgBIAEoCRItCglUaW1lc3RhbXAYAiABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wEhIKClNlbmRlclV1aWQYAyABKAkSDwoH",
            "TWVzc2FnZRgEIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Chat.ChatMessageStore), global::Chat.ChatMessageStore.Parser, new[]{ "MessageId", "Timestamp", "SenderUuid", "Message" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChatMessageStore : pb::IMessage<ChatMessageStore> {
    private static readonly pb::MessageParser<ChatMessageStore> _parser = new pb::MessageParser<ChatMessageStore>(() => new ChatMessageStore());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatMessageStore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Chat.ChatMessageStoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatMessageStore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatMessageStore(ChatMessageStore other) : this() {
      messageId_ = other.messageId_;
      Timestamp = other.timestamp_ != null ? other.Timestamp.Clone() : null;
      senderUuid_ = other.senderUuid_;
      message_ = other.message_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatMessageStore Clone() {
      return new ChatMessageStore(this);
    }

    /// <summary>Field number for the "MessageId" field.</summary>
    public const int MessageIdFieldNumber = 1;
    private string messageId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MessageId {
      get { return messageId_; }
      set {
        messageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Timestamp" field.</summary>
    public const int TimestampFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "SenderUuid" field.</summary>
    public const int SenderUuidFieldNumber = 3;
    private string senderUuid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SenderUuid {
      get { return senderUuid_; }
      set {
        senderUuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Message" field.</summary>
    public const int MessageFieldNumber = 4;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatMessageStore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatMessageStore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MessageId != other.MessageId) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (SenderUuid != other.SenderUuid) return false;
      if (Message != other.Message) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MessageId.Length != 0) hash ^= MessageId.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (SenderUuid.Length != 0) hash ^= SenderUuid.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MessageId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MessageId);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Timestamp);
      }
      if (SenderUuid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SenderUuid);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Message);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MessageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MessageId);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (SenderUuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SenderUuid);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatMessageStore other) {
      if (other == null) {
        return;
      }
      if (other.MessageId.Length != 0) {
        MessageId = other.MessageId;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          timestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      if (other.SenderUuid.Length != 0) {
        SenderUuid = other.SenderUuid;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            MessageId = input.ReadString();
            break;
          }
          case 18: {
            if (timestamp_ == null) {
              timestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(timestamp_);
            break;
          }
          case 26: {
            SenderUuid = input.ReadString();
            break;
          }
          case 34: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code