
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed partial class UeCooldown :  ai.Decorator 
{
    public UeCooldown(ByteBuf _buf)  : base(_buf) 
    {
        CooldownTime = _buf.ReadFloat();
    }

    public UeCooldown(int id, string node_name, ai.EFlowAbortMode flow_abort_mode, float cooldown_time )  : base(id,node_name,flow_abort_mode) 
    {
        this.CooldownTime = cooldown_time;
    }

    public static UeCooldown DeserializeUeCooldown(ByteBuf _buf)
    {
        return new ai.UeCooldown(_buf);
    }

    public readonly float CooldownTime;

    public const int ID = -951439423;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

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

