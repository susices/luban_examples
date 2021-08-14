
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



namespace cfg.bonus
{

public sealed partial class Items :  bonus.Bonus 
{
    public Items(JSONNode _json)  : base(_json) 
    {
        { var _json1 = _json["item_list"]; if(!_json1.IsArray) { throw new SerializationException(); } int _n = _json1.Count; ItemList = new bonus.Item[_n]; int _index=0; foreach(JSONNode __e in _json1.Children) { bonus.Item __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = bonus.Item.DeserializeItem(__e); }  ItemList[_index++] = __v; }   }
    }

    public Items(bonus.Item[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static Items DeserializeItems(JSONNode _json)
    {
        return new bonus.Items(_json);
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

