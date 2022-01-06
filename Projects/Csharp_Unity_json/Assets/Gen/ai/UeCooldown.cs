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

public sealed class UeCooldown :  ai.Decorator 
{
    public UeCooldown(JSONNode _json)  : base(_json) 
    {
        { if(!_json["cooldown_time"].IsNumber) { throw new SerializationException(); }  CooldownTime = _json["cooldown_time"]; }
    }

    public UeCooldown(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, float cooldown_time )  : base(id,node_name,flow_abort_mode) 
    {
        this.CooldownTime = cooldown_time;
    }

    public static UeCooldown DeserializeUeCooldown(JSONNode _json)
    {
        return new ai.UeCooldown(_json);
    }

    public float CooldownTime { get; private set; }

    public const int __ID__ = -951439423;
    public override int GetTypeId() => __ID__;

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
        + "CooldownTime:" + CooldownTime + ","
        + "}";
    }
    }
}
