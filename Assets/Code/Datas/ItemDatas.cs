//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ItemDatas.proto
namespace ItemDatas
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemDatastable")]
  public partial class ItemDatastable : global::ProtoBuf.IExtensible
  {
    public ItemDatastable() {}
    
    private string _tname = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tname
    {
      get { return _tname; }
      set { _tname = value; }
    }
    private readonly global::System.Collections.Generic.List<ItemDatas> _tlist = new global::System.Collections.Generic.List<ItemDatas>();
    [global::ProtoBuf.ProtoMember(2, Name=@"tlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ItemDatas> tlist
    {
      get { return _tlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ItemDatas")]
  public partial class ItemDatas : global::ProtoBuf.IExtensible
  {
    public ItemDatas() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _MainType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MainType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int MainType
    {
      get { return _MainType; }
      set { _MainType = value; }
    }
    private int _SubType = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"SubType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SubType
    {
      get { return _SubType; }
      set { _SubType = value; }
    }
    private int _EquipIdx = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"EquipIdx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int EquipIdx
    {
      get { return _EquipIdx; }
      set { _EquipIdx = value; }
    }
    private int _UnitId = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"UnitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int UnitId
    {
      get { return _UnitId; }
      set { _UnitId = value; }
    }
    private string _Icon = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Icon
    {
      get { return _Icon; }
      set { _Icon = value; }
    }
    private string _Desc = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Desc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Desc
    {
      get { return _Desc; }
      set { _Desc = value; }
    }
    private int _Quality = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Quality", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Quality
    {
      get { return _Quality; }
      set { _Quality = value; }
    }
    private int _HP = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"HP", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int HP
    {
      get { return _HP; }
      set { _HP = value; }
    }
    private int _MP = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MP", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int MP
    {
      get { return _MP; }
      set { _MP = value; }
    }
    private int _Damage = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Damage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Damage
    {
      get { return _Damage; }
      set { _Damage = value; }
    }
    private int _Def = default(int);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Def", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Def
    {
      get { return _Def; }
      set { _Def = value; }
    }
    private int _Speed = default(int);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Speed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Speed
    {
      get { return _Speed; }
      set { _Speed = value; }
    }
    private int _CritDamage = default(int);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CritDamage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int CritDamage
    {
      get { return _CritDamage; }
      set { _CritDamage = value; }
    }
    private int _Crit = default(int);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Crit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Crit
    {
      get { return _Crit; }
      set { _Crit = value; }
    }
    private int _Coin = default(int);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Coin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Coin
    {
      get { return _Coin; }
      set { _Coin = value; }
    }
    private int _Stack = default(int);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"Stack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Stack
    {
      get { return _Stack; }
      set { _Stack = value; }
    }
    private int _Size = default(int);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Size
    {
      get { return _Size; }
      set { _Size = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}