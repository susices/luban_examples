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



namespace editor.cfg.condition
{

public abstract partial class BoolRoleCondition :  condition.RoleCondition 
{
    public BoolRoleCondition()
    {
    }


    public static BoolRoleCondition LoadJsonBoolRoleCondition(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        BoolRoleCondition obj;
        switch (type)
        {
            case "condition.GenderLimit":   
            case "GenderLimit":obj = new condition.GenderLimit(); break;
            case "condition.MinLevel":   
            case "MinLevel":obj = new condition.MinLevel(); break;
            case "condition.MaxLevel":   
            case "MaxLevel":obj = new condition.MaxLevel(); break;
            case "condition.MinMaxLevel":   
            case "MinMaxLevel":obj = new condition.MinMaxLevel(); break;
            case "condition.ClothesPropertyScoreGreaterThan":   
            case "ClothesPropertyScoreGreaterThan":obj = new condition.ClothesPropertyScoreGreaterThan(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBoolRoleCondition(BoolRoleCondition _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

}
}
