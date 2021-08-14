
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.cost
{

public sealed partial class CostItems :  cost.Cost 
{
    public CostItems(JSONNode _json)  : base(_json) 
    {
        { var _json1 = _json["item_list"]; if(!_json1.IsArray) { throw new SerializationException(); } int _n = _json1.Count; ItemList = new cost.CostItem[_n]; int _index=0; foreach(JSONNode __e in _json1.Children) { cost.CostItem __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = cost.CostItem.DeserializeCostItem(__e); }  ItemList[_index++] = __v; }   }
    }

    public CostItems(cost.CostItem[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static CostItems DeserializeCostItems(JSONNode _json)
    {
        return new cost.CostItems(_json);
    }

    public readonly cost.CostItem[] ItemList;

    public const int ID = -77945102;
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

