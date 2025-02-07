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

public sealed partial class IsAtLocation :  ai.Decorator 
{
    public IsAtLocation(JSONNode _json)  : base(_json) 
    {
        { if(!_json["acceptable_radius"].IsNumber) { throw new SerializationException(); }  AcceptableRadius = _json["acceptable_radius"]; }
        { if(!_json["keyboard_key"].IsString) { throw new SerializationException(); }  KeyboardKey = _json["keyboard_key"]; }
        { if(!_json["inverse_condition"].IsBoolean) { throw new SerializationException(); }  InverseCondition = _json["inverse_condition"]; }
        PostInit();
    }

    public IsAtLocation(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, float acceptable_radius, string keyboard_key, bool inverse_condition )  : base(id,node_name,flow_abort_mode) 
    {
        this.AcceptableRadius = acceptable_radius;
        this.KeyboardKey = keyboard_key;
        this.InverseCondition = inverse_condition;
        PostInit();
    }

    public static IsAtLocation DeserializeIsAtLocation(JSONNode _json)
    {
        return new ai.IsAtLocation(_json);
    }

    public float AcceptableRadius { get; private set; }
    public string KeyboardKey { get; private set; }
    public bool InverseCondition { get; private set; }

    public const int __ID__ = 1255972344;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
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
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "KeyboardKey:" + KeyboardKey + ","
        + "InverseCondition:" + InverseCondition + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
