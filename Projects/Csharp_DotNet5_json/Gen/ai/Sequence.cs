
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

/// <summary>
/// 
/// </summary>
public sealed partial class Sequence :  ai.ComposeNode 
{
    public Sequence(JsonElement _buf)  : base(_buf) 
    {
        { var _json = _buf.GetProperty("children"); Children = new System.Collections.Generic.List<ai.FlowNode>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { ai.FlowNode __v;  __v =  ai.FlowNode.DeserializeFlowNode(__e);  Children.Add(__v); }   }
    }

    public Sequence(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, System.Collections.Generic.List<ai.FlowNode> children )  : base(id,node_name,decorators,services) 
    {
        this.Children = children;
    }

    public static Sequence DeserializeSequence(JsonElement _buf)
    {
        return new ai.Sequence(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<ai.FlowNode> Children;

    public const int ID = -1789006105;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Children) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "Children:" + Bright.Common.StringUtil.CollectionToString(Children) + ","
        + "}";
    }
    }
}

