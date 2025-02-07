
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

public sealed partial class Selector :  ai.ComposeNode 
{
    public Selector(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Children = new System.Collections.Generic.List<ai.FlowNode>(n);for(var i = 0 ; i < n ; i++) { ai.FlowNode _e;  _e = ai.FlowNode.DeserializeFlowNode(_buf); Children.Add(_e);}}
    }

    public Selector(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services, System.Collections.Generic.List<ai.FlowNode> children )  : base(id,node_name,decorators,services) 
    {
        this.Children = children;
    }

    public static Selector DeserializeSelector(ByteBuf _buf)
    {
        return new ai.Selector(_buf);
    }

    public readonly System.Collections.Generic.List<ai.FlowNode> Children;

    public const int ID = -1946981627;
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

