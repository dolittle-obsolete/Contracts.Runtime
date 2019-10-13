// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataTypes/vector2.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dolittle.TimeSeries.DataTypes.Protobuf {

  /// <summary>Holder for reflection information generated from DataTypes/vector2.proto</summary>
  public static partial class Vector2Reflection {

    #region Descriptor
    /// <summary>File descriptor for DataTypes/vector2.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Vector2Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdEYXRhVHlwZXMvdmVjdG9yMi5wcm90bxIdZG9saXR0bGUudGltZXNlcmll",
            "cy5kYXRhdHlwZXMaG0RhdGFUeXBlcy9tZWFzdXJlbWVudC5wcm90byJ3CgdW",
            "ZWN0b3IyEjUKAXgYASABKAsyKi5kb2xpdHRsZS50aW1lc2VyaWVzLmRhdGF0",
            "eXBlcy5NZWFzdXJlbWVudBI1CgF5GAIgASgLMiouZG9saXR0bGUudGltZXNl",
            "cmllcy5kYXRhdHlwZXMuTWVhc3VyZW1lbnRCKaoCJkRvbGl0dGxlLlRpbWVT",
            "ZXJpZXMuRGF0YVR5cGVzLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Dolittle.TimeSeries.DataTypes.Protobuf.MeasurementReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dolittle.TimeSeries.DataTypes.Protobuf.Vector2), global::Dolittle.TimeSeries.DataTypes.Protobuf.Vector2.Parser, new[]{ "X", "Y" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Vector2 : pb::IMessage<Vector2> {
    private static readonly pb::MessageParser<Vector2> _parser = new pb::MessageParser<Vector2>(() => new Vector2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vector2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dolittle.TimeSeries.DataTypes.Protobuf.Vector2Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector2(Vector2 other) : this() {
      x_ = other.x_ != null ? other.x_.Clone() : null;
      y_ = other.y_ != null ? other.y_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector2 Clone() {
      return new Vector2(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vector2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vector2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(X, other.X)) return false;
      if (!object.Equals(Y, other.Y)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (x_ != null) hash ^= X.GetHashCode();
      if (y_ != null) hash ^= Y.GetHashCode();
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
      if (x_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(X);
      }
      if (y_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Y);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (x_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(X);
      }
      if (y_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Y);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vector2 other) {
      if (other == null) {
        return;
      }
      if (other.x_ != null) {
        if (x_ == null) {
          X = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
        }
        X.MergeFrom(other.X);
      }
      if (other.y_ != null) {
        if (y_ == null) {
          Y = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
        }
        Y.MergeFrom(other.Y);
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
            if (x_ == null) {
              X = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
            }
            input.ReadMessage(X);
            break;
          }
          case 18: {
            if (y_ == null) {
              Y = new global::Dolittle.TimeSeries.DataTypes.Protobuf.Measurement();
            }
            input.ReadMessage(Y);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code