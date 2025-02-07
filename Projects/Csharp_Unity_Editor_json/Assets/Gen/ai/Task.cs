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



namespace editor.cfg.ai
{

public abstract partial class Task :  ai.FlowNode 
{
    public Task()
    {
    }


    public static Task LoadJsonTask(SimpleJSON.JSONNode _json)
    {
        string type = _json["$type"];
        Task obj;
        switch (type)
        {
            case "ai.UeWait":   
            case "UeWait":obj = new ai.UeWait(); break;
            case "ai.UeWaitBlackboardTime":   
            case "UeWaitBlackboardTime":obj = new ai.UeWaitBlackboardTime(); break;
            case "ai.MoveToTarget":   
            case "MoveToTarget":obj = new ai.MoveToTarget(); break;
            case "ai.ChooseSkill":   
            case "ChooseSkill":obj = new ai.ChooseSkill(); break;
            case "ai.MoveToRandomLocation":   
            case "MoveToRandomLocation":obj = new ai.MoveToRandomLocation(); break;
            case "ai.MoveToLocation":   
            case "MoveToLocation":obj = new ai.MoveToLocation(); break;
            case "ai.DebugPrint":   
            case "DebugPrint":obj = new ai.DebugPrint(); break;
            default: throw new SerializationException();
        }
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTask(Task _obj, SimpleJSON.JSONNode _json)
    {
        _json["$type"] = _obj.GetType().Name;
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public bool IgnoreRestartSelf { get; set; }

}
}
