
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

public sealed partial class WeightItems :  bonus.Bonus 
{
    public WeightItems(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ItemList = new bonus.WeightItemInfo[n];for(var i = 0 ; i < n ; i++) { bonus.WeightItemInfo _e;_e = bonus.WeightItemInfo.DeserializeWeightItemInfo(_buf); ItemList[i] = _e;}}
    }

    public WeightItems(bonus.WeightItemInfo[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static WeightItems DeserializeWeightItems(ByteBuf _buf)
    {
        return new bonus.WeightItems(_buf);
    }

    public readonly bonus.WeightItemInfo[] ItemList;

    public const int ID = -356202311;
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

