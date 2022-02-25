//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



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
        PostInit();
    }

    public static TreasureBox DeserializeTreasureBox(ByteBuf _buf)
    {
        return new item.TreasureBox(_buf);
    }

    public int? KeyItemId { get; private set; }
    public condition.MinLevel OpenLevel { get; private set; }
    public bool UseOnObtain { get; private set; }
    public System.Collections.Generic.List<int> DropIds { get; private set; }
    //field.gen_ref
    public System.Collections.Generic.List<bonus.DropInfo> DropIds_Ref { get; private set; }
    public System.Collections.Generic.List<item.ChooseOneBonus> ChooseList { get; private set; }

    public const int __ID__ = 1494222369;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OpenLevel?.Resolve(_tables);
        { bonus.TbDrop __table = (bonus.TbDrop)_tables["bonus.TbDrop"]; this.DropIds_Ref = new System.Collections.Generic.List<bonus.DropInfo>(); foreach(var __e in DropIds) { this.DropIds_Ref.Add(__table.GetOrDefault(__e)); } }
        foreach(var _e in ChooseList) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        OpenLevel?.TranslateText(translator);
        foreach(var _e in ChooseList) { _e?.TranslateText(translator); }
    }

    public void Reload(TreasureBox reloadData)
    {
        KeyItemId = reloadData.KeyItemId;
        OpenLevel = reloadData.OpenLevel;
        UseOnObtain = reloadData.UseOnObtain;
        if(DropIds.Count<reloadData.DropIds.Count)
        {
            DropIds.AddRange(new List<int>(reloadData.DropIds.Count-DropIds.Count));
        }else if(DropIds.Count>reloadData.DropIds.Count)
        {
            DropIds.RemoveRange(reloadData.DropIds.Count, DropIds.Count-reloadData.DropIds.Count);
        }
        for (int i = 0; i < reloadData.DropIds.Count; i++)
        {
            DropIds[i] = reloadData.DropIds[i];
        }
        if(ChooseList.Count<reloadData.ChooseList.Count)
        {
            ChooseList.AddRange(new List<item.ChooseOneBonus>(reloadData.ChooseList.Count-ChooseList.Count));
        }else if(ChooseList.Count>reloadData.ChooseList.Count)
        {
            ChooseList.RemoveRange(reloadData.ChooseList.Count, ChooseList.Count-reloadData.ChooseList.Count);
        }
        for (int i = 0; i < reloadData.ChooseList.Count; i++)
        {
            ChooseList[i] = reloadData.ChooseList[i];
        }
    }

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
    
    partial void PostInit();
    partial void PostResolve();
}

}
