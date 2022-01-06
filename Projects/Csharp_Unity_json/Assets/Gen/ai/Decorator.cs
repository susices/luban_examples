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



namespace cfg.ai
{

public abstract class Decorator :  ai.Node 
{
    public Decorator(JSONNode _json)  : base(_json) 
    {
        { if(!_json["flow_abort_mode"].IsNumber) { throw new SerializationException(); }  FlowAbortMode = (ai.EFlowAbortMode)_json["flow_abort_mode"].AsInt; }
    }

    public Decorator(int id, string node_name, ai.EFlowAbortMode flow_abort_mode )  : base(id,node_name) 
    {
        this.FlowAbortMode = flow_abort_mode;
    }

    public static Decorator DeserializeDecorator(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "UeLoop": return new ai.UeLoop(_json);
            case "UeCooldown": return new ai.UeCooldown(_json);
            case "UeTimeLimit": return new ai.UeTimeLimit(_json);
            case "UeBlackboard": return new ai.UeBlackboard(_json);
            case "UeForceSuccess": return new ai.UeForceSuccess(_json);
            case "IsAtLocation": return new ai.IsAtLocation(_json);
            case "DistanceLessThan": return new ai.DistanceLessThan(_json);
            default: throw new SerializationException();
        }
    }

    public ai.EFlowAbortMode FlowAbortMode { get; private set; }


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "}";
    }
    }
}
