
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed partial class TreasureBox :  item.ItemExtra 
{
    public TreasureBox(ByteBuf _buf)  : base(_buf) 
    {
        if(_buf.ReadBool()){ KeyItemId = _buf.ReadInt(); } else { KeyItemId = null; }
        OpenLevel = condition.MinLevel.DeserializeMinLevel(_buf);
        UseOnObtain = _buf.ReadBool();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);DropIds = new System.Collections.Generic.List<int>(n);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); DropIds.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ChooseList = new System.Collections.Generic.List<item.ChooseOneBonus>(n);for(var i = 0 ; i < n ; i++) { item.ChooseOneBonus _e;  _e = item.ChooseOneBonus.DeserializeChooseOneBonus(_buf); ChooseList.Add(_e);}}
    }

    public TreasureBox(int id, int? key_item_id, condition.MinLevel open_level, bool use_on_obtain, System.Collections.Generic.List<int> drop_ids, System.Collections.Generic.List<item.ChooseOneBonus> choose_list )  : base(id) 
    {
        this.KeyItemId = key_item_id;
        this.OpenLevel = open_level;
        this.UseOnObtain = use_on_obtain;
        this.DropIds = drop_ids;
        this.ChooseList = choose_list;
    }

    public static TreasureBox DeserializeTreasureBox(ByteBuf _buf)
    {
        return new item.TreasureBox(_buf);
    }

    public readonly int? KeyItemId;
    public readonly condition.MinLevel OpenLevel;
    public readonly bool UseOnObtain;
    public readonly System.Collections.Generic.List<int> DropIds;
    public readonly System.Collections.Generic.List<item.ChooseOneBonus> ChooseList;

    public const int ID = 1494222369;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OpenLevel?.Resolve(_tables);
        foreach(var _e in ChooseList) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "KeyItemId:" + KeyItemId + ","
        + "OpenLevel:" + OpenLevel + ","
        + "UseOnObtain:" + UseOnObtain + ","
        + "DropIds:" + Bright.Common.StringUtil.CollectionToString(DropIds) + ","
        + "ChooseList:" + Bright.Common.StringUtil.CollectionToString(ChooseList) + ","
        + "}";
    }
    }

}

