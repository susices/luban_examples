
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{

public sealed class DistanceLessThan :  ai.Decorator 
{
    public DistanceLessThan(JsonElement _json)  : base(_json) 
    {
        Actor1Key = _json.GetProperty("actor1_key").GetString();
        Actor2Key = _json.GetProperty("actor2_key").GetString();
        Distance = _json.GetProperty("distance").GetSingle();
        ReverseResult = _json.GetProperty("reverse_result").GetBoolean();
    }

    public DistanceLessThan(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, string actor1_key, string actor2_key, float distance, bool reverse_result )  : base(id,node_name,flow_abort_mode) 
    {
        this.Actor1Key = actor1_key;
        this.Actor2Key = actor2_key;
        this.Distance = distance;
        this.ReverseResult = reverse_result;
    }

    public static DistanceLessThan DeserializeDistanceLessThan(JsonElement _json)
    {
        return new ai.DistanceLessThan(_json);
    }

    public string Actor1Key {get; private set; }
    public string Actor2Key {get; private set; }
    public float Distance {get; private set; }
    public bool ReverseResult {get; private set; }

    public const int ID = -1207170283;
    public override int GetTypeId() => ID;

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
        + "Actor1Key:" + Actor1Key + ","
        + "Actor2Key:" + Actor2Key + ","
        + "Distance:" + Distance + ","
        + "ReverseResult:" + ReverseResult + ","
        + "}";
    }
    }
}
