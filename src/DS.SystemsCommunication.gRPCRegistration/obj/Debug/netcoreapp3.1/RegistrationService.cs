// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegistrationService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DS.SystemsCommunication.gRPCRegistration.Protos {

  /// <summary>Holder for reflection information generated from RegistrationService.proto</summary>
  public static partial class RegistrationServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for RegistrationService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegistrationServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSZWdpc3RyYXRpb25TZXJ2aWNlLnByb3RvGgtFbnVtcy5wcm90bxofZ29v",
            "Z2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKSAQoTUmVnaXN0cmF0aW9u",
            "UmVxdWVzdBIWCg5SZWdpc3RyYXRpb25JZBgBIAEoAxIMCgROYW1lGAIgASgJ",
            "Eg0KBUVtYWlsGAMgASgJEhAKCE1vYmlsZU5vGAQgASgJEjQKEFJlZ2lzdHJh",
            "dGlvbkRhdGUYBSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wIlEK",
            "ElJlZ2lzdHJhdGlvblJlc3VsdBIWCg5SZWdpc3RyYXRpb25JZBgBIAEoAxIj",
            "CgZTdGF0dXMYAiABKA4yEy5SZWdpc3RyYXRpb25TdGF0dXMiPgoXUmVnaXN0",
            "cmF0aW9uVG90YWxSZXN1bHQSIwoGU3RhdHVzGAEgASgOMhMuUmVnaXN0cmF0",
            "aW9uU3RhdHVzIkkKGlJlZ2lzdHJhdGlvbnNQYWNrZXRSZXF1ZXN0EisKDVJl",
            "Z2lzdHJhdGlvbnMYASADKAsyFC5SZWdpc3RyYXRpb25SZXF1ZXN0MuMCChNS",
            "ZWdpc3RyYXRpb25TZXJ2aWNlEkYKGVJlZ2lzdGVyU2luZ2xlQXBwbGljYXRp",
            "b24SFC5SZWdpc3RyYXRpb25SZXF1ZXN0GhMuUmVnaXN0cmF0aW9uUmVzdWx0",
            "ElQKIFJlZ2lzdGVyQXBwbGljYXRpb25zQ2xpZW50U3RyZWFtEhQuUmVnaXN0",
            "cmF0aW9uUmVxdWVzdBoYLlJlZ2lzdHJhdGlvblRvdGFsUmVzdWx0KAESVgog",
            "UmVnaXN0ZXJBcHBsaWNhdGlvbnNTZXJ2ZXJTdHJlYW0SGy5SZWdpc3RyYXRp",
            "b25zUGFja2V0UmVxdWVzdBoTLlJlZ2lzdHJhdGlvblJlc3VsdDABElYKJVJl",
            "Z2lzdGVyQXBwbGljYXRpb25zQmlkaXJhY3Rpb25TdHJlYW0SFC5SZWdpc3Ry",
            "YXRpb25SZXF1ZXN0GhMuUmVnaXN0cmF0aW9uUmVzdWx0KAEwAUIyqgIvRFMu",
            "U3lzdGVtc0NvbW11bmljYXRpb24uZ1JQQ1JlZ2lzdHJhdGlvbi5Qcm90b3Ni",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DS.SystemsCommunication.gRPCRegistration.Protos.EnumsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest.Parser, new[]{ "RegistrationId", "Name", "Email", "MobileNo", "RegistrationDate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationResult.Parser, new[]{ "RegistrationId", "Status" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationTotalResult.Parser, new[]{ "Status" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest), global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationsPacketRequest.Parser, new[]{ "Registrations" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RegistrationRequest : pb::IMessage<RegistrationRequest> {
    private static readonly pb::MessageParser<RegistrationRequest> _parser = new pb::MessageParser<RegistrationRequest>(() => new RegistrationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistrationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationRequest(RegistrationRequest other) : this() {
      registrationId_ = other.registrationId_;
      name_ = other.name_;
      email_ = other.email_;
      mobileNo_ = other.mobileNo_;
      registrationDate_ = other.registrationDate_ != null ? other.registrationDate_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationRequest Clone() {
      return new RegistrationRequest(this);
    }

    /// <summary>Field number for the "RegistrationId" field.</summary>
    public const int RegistrationIdFieldNumber = 1;
    private long registrationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RegistrationId {
      get { return registrationId_; }
      set {
        registrationId_ = value;
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Email" field.</summary>
    public const int EmailFieldNumber = 3;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "MobileNo" field.</summary>
    public const int MobileNoFieldNumber = 4;
    private string mobileNo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MobileNo {
      get { return mobileNo_; }
      set {
        mobileNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "RegistrationDate" field.</summary>
    public const int RegistrationDateFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp registrationDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp RegistrationDate {
      get { return registrationDate_; }
      set {
        registrationDate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegistrationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistrationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegistrationId != other.RegistrationId) return false;
      if (Name != other.Name) return false;
      if (Email != other.Email) return false;
      if (MobileNo != other.MobileNo) return false;
      if (!object.Equals(RegistrationDate, other.RegistrationDate)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RegistrationId != 0L) hash ^= RegistrationId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (MobileNo.Length != 0) hash ^= MobileNo.GetHashCode();
      if (registrationDate_ != null) hash ^= RegistrationDate.GetHashCode();
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
      if (RegistrationId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RegistrationId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Email);
      }
      if (MobileNo.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(MobileNo);
      }
      if (registrationDate_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RegistrationDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RegistrationId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RegistrationId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (MobileNo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MobileNo);
      }
      if (registrationDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegistrationDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegistrationRequest other) {
      if (other == null) {
        return;
      }
      if (other.RegistrationId != 0L) {
        RegistrationId = other.RegistrationId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.MobileNo.Length != 0) {
        MobileNo = other.MobileNo;
      }
      if (other.registrationDate_ != null) {
        if (registrationDate_ == null) {
          RegistrationDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        RegistrationDate.MergeFrom(other.RegistrationDate);
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
          case 8: {
            RegistrationId = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 34: {
            MobileNo = input.ReadString();
            break;
          }
          case 42: {
            if (registrationDate_ == null) {
              RegistrationDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(RegistrationDate);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RegistrationResult : pb::IMessage<RegistrationResult> {
    private static readonly pb::MessageParser<RegistrationResult> _parser = new pb::MessageParser<RegistrationResult>(() => new RegistrationResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistrationResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationResult(RegistrationResult other) : this() {
      registrationId_ = other.registrationId_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationResult Clone() {
      return new RegistrationResult(this);
    }

    /// <summary>Field number for the "RegistrationId" field.</summary>
    public const int RegistrationIdFieldNumber = 1;
    private long registrationId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RegistrationId {
      get { return registrationId_; }
      set {
        registrationId_ = value;
      }
    }

    /// <summary>Field number for the "Status" field.</summary>
    public const int StatusFieldNumber = 2;
    private global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegistrationResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistrationResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegistrationId != other.RegistrationId) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RegistrationId != 0L) hash ^= RegistrationId.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (RegistrationId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RegistrationId);
      }
      if (Status != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RegistrationId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RegistrationId);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegistrationResult other) {
      if (other == null) {
        return;
      }
      if (other.RegistrationId != 0L) {
        RegistrationId = other.RegistrationId;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
          case 8: {
            RegistrationId = input.ReadInt64();
            break;
          }
          case 16: {
            Status = (global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RegistrationTotalResult : pb::IMessage<RegistrationTotalResult> {
    private static readonly pb::MessageParser<RegistrationTotalResult> _parser = new pb::MessageParser<RegistrationTotalResult>(() => new RegistrationTotalResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistrationTotalResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationTotalResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationTotalResult(RegistrationTotalResult other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationTotalResult Clone() {
      return new RegistrationTotalResult(this);
    }

    /// <summary>Field number for the "Status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegistrationTotalResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistrationTotalResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegistrationTotalResult other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
          case 8: {
            Status = (global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RegistrationsPacketRequest : pb::IMessage<RegistrationsPacketRequest> {
    private static readonly pb::MessageParser<RegistrationsPacketRequest> _parser = new pb::MessageParser<RegistrationsPacketRequest>(() => new RegistrationsPacketRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistrationsPacketRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationsPacketRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationsPacketRequest(RegistrationsPacketRequest other) : this() {
      registrations_ = other.registrations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistrationsPacketRequest Clone() {
      return new RegistrationsPacketRequest(this);
    }

    /// <summary>Field number for the "Registrations" field.</summary>
    public const int RegistrationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest> _repeated_registrations_codec
        = pb::FieldCodec.ForMessage(10, global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest.Parser);
    private readonly pbc::RepeatedField<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest> registrations_ = new pbc::RepeatedField<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::DS.SystemsCommunication.gRPCRegistration.Protos.RegistrationRequest> Registrations {
      get { return registrations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegistrationsPacketRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistrationsPacketRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!registrations_.Equals(other.registrations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= registrations_.GetHashCode();
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
      registrations_.WriteTo(output, _repeated_registrations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += registrations_.CalculateSize(_repeated_registrations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegistrationsPacketRequest other) {
      if (other == null) {
        return;
      }
      registrations_.Add(other.registrations_);
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
            registrations_.AddEntriesFrom(input, _repeated_registrations_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code