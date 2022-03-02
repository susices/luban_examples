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



namespace editor.cfg.cost
{

public sealed partial class CostItems :  cost.Cost 
{
    public CostItems()
    {
            ItemList = System.Array.Empty<cost.CostItem>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["item_list"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n = _fieldJson.Count; ItemList = new cost.CostItem[_n]; int _index=0; foreach(SimpleJSON.JSONNode __e in _fieldJson.Children) { cost.CostItem __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = cost.CostItem.LoadJsonCostItem(__e);  ItemList[_index++] = __v; }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "cost.CostItems";
        {

            if (ItemList == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in ItemList) { { var __bjson = new JSONObject();  cost.CostItem.SaveJsonCostItem(_e, __bjson); __cjson["null"] = __bjson; } } _json["item_list"] = __cjson; }
        }
    }

    public static CostItems LoadJsonCostItems(SimpleJSON.JSONNode _json)
    {
        CostItems obj = new cost.CostItems();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonCostItems(CostItems _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public cost.CostItem[] ItemList { get; set; }

}
}
