
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public sealed partial class Items :  bonus.Bonus 
{
    public Items(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ItemList = new bonus.Item[n];for(var i = 0 ; i < n ; i++) { bonus.Item _e;_e = bonus.Item.DeserializeItem(_buf); ItemList[i] = _e;}}
    }

    public Items(bonus.Item[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static Items DeserializeItems(ByteBuf _buf)
    {
        return new bonus.Items(_buf);
    }

    public readonly bonus.Item[] ItemList;

    public const int ID = 819736849;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in ItemList) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemList:" + Bright.Common.StringUtil.CollectionToString(ItemList) + ","
        + "}";
    }
    }

}

