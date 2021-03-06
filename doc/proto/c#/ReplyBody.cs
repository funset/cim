// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReplyBody.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ReplyBody.proto</summary>
public static partial class ReplyBodyReflection {

  #region Descriptor
  /// <summary>File descriptor for ReplyBody.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ReplyBodyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9SZXBseUJvZHkucHJvdG8ikwEKBU1vZGVsEgsKA2tleRgBIAEoCRIMCgRj",
          "b2RlGAIgASgJEg8KB21lc3NhZ2UYAyABKAkSEQoJdGltZXN0YW1wGAQgASgD",
          "Eh4KBGRhdGEYBSADKAsyEC5Nb2RlbC5EYXRhRW50cnkaKwoJRGF0YUVudHJ5",
          "EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAFiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Model), global::Model.Parser, new[]{ "Key", "Code", "Message", "Timestamp", "Data" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Model : pb::IMessage<Model> {
  private static readonly pb::MessageParser<Model> _parser = new pb::MessageParser<Model>(() => new Model());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Model> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ReplyBodyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Model() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Model(Model other) : this() {
    key_ = other.key_;
    code_ = other.code_;
    message_ = other.message_;
    timestamp_ = other.timestamp_;
    data_ = other.data_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Model Clone() {
    return new Model(this);
  }

  /// <summary>Field number for the "key" field.</summary>
  public const int KeyFieldNumber = 1;
  private string key_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Key {
    get { return key_; }
    set {
      key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "code" field.</summary>
  public const int CodeFieldNumber = 2;
  private string code_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Code {
    get { return code_; }
    set {
      code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 3;
  private string message_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "timestamp" field.</summary>
  public const int TimestampFieldNumber = 4;
  private long timestamp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Timestamp {
    get { return timestamp_; }
    set {
      timestamp_ = value;
    }
  }

  /// <summary>Field number for the "data" field.</summary>
  public const int DataFieldNumber = 5;
  private static readonly pbc::MapField<string, string>.Codec _map_data_codec
      = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 42);
  private readonly pbc::MapField<string, string> data_ = new pbc::MapField<string, string>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<string, string> Data {
    get { return data_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Model);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Model other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Key != other.Key) return false;
    if (Code != other.Code) return false;
    if (Message != other.Message) return false;
    if (Timestamp != other.Timestamp) return false;
    if (!Data.Equals(other.Data)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Key.Length != 0) hash ^= Key.GetHashCode();
    if (Code.Length != 0) hash ^= Code.GetHashCode();
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (Timestamp != 0L) hash ^= Timestamp.GetHashCode();
    hash ^= Data.GetHashCode();
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
    if (Key.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Key);
    }
    if (Code.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(Code);
    }
    if (Message.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Message);
    }
    if (Timestamp != 0L) {
      output.WriteRawTag(32);
      output.WriteInt64(Timestamp);
    }
    data_.WriteTo(output, _map_data_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Key.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
    }
    if (Code.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
    }
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
    }
    if (Timestamp != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Timestamp);
    }
    size += data_.CalculateSize(_map_data_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Model other) {
    if (other == null) {
      return;
    }
    if (other.Key.Length != 0) {
      Key = other.Key;
    }
    if (other.Code.Length != 0) {
      Code = other.Code;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    if (other.Timestamp != 0L) {
      Timestamp = other.Timestamp;
    }
    data_.Add(other.data_);
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
          Key = input.ReadString();
          break;
        }
        case 18: {
          Code = input.ReadString();
          break;
        }
        case 26: {
          Message = input.ReadString();
          break;
        }
        case 32: {
          Timestamp = input.ReadInt64();
          break;
        }
        case 42: {
          data_.AddEntriesFrom(input, _map_data_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
