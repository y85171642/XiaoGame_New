//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: NewTurnBroadcast.proto
// Note: requires additional types generated from: Enums.proto
namespace message
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChessRow")]
  public partial class ChessRow : global::ProtoBuf.IExtensible
  {
    public ChessRow() {}
    
    private readonly global::System.Collections.Generic.List<message.Enums.ChessType> _types = new global::System.Collections.Generic.List<message.Enums.ChessType>();
    [global::ProtoBuf.ProtoMember(1, Name=@"types", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<message.Enums.ChessType> types
    {
      get { return _types; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BoardSync")]
  public partial class BoardSync : global::ProtoBuf.IExtensible
  {
    public BoardSync() {}
    
    private readonly global::System.Collections.Generic.List<message.ChessRow> _rows = new global::System.Collections.Generic.List<message.ChessRow>();
    [global::ProtoBuf.ProtoMember(1, Name=@"rows", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<message.ChessRow> rows
    {
      get { return _rows; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NewTurnBroadcast")]
  public partial class NewTurnBroadcast : global::ProtoBuf.IExtensible
  {
    public NewTurnBroadcast() {}
    
    private message.Enums.Camp _camp = message.Enums.Camp.NoneCamp;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(message.Enums.Camp.NoneCamp)]
    public message.Enums.Camp camp
    {
      get { return _camp; }
      set { _camp = value; }
    }
    private message.BoardSync _boardSync = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"boardSync", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public message.BoardSync boardSync
    {
      get { return _boardSync; }
      set { _boardSync = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}