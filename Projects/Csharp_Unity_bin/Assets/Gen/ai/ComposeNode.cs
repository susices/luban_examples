
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

public abstract partial class ComposeNode :  ai.FlowNode 
{
    public ComposeNode(ByteBuf _buf)  : base(_buf) 
    {
    }

    public ComposeNode(int id, string node_name, System.Collections.Generic.List<ai.Decorator> decorators, System.Collections.Generic.List<ai.Service> services )  : base(id,node_name,decorators,services) 
    {
    }

    public static ComposeNode DeserializeComposeNode(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.Sequence.ID: return new ai.Sequence(_buf);
            case ai.Selector.ID: return new ai.Selector(_buf);
            case ai.SimpleParallel.ID: return new ai.SimpleParallel(_buf);
            default: throw new SerializationException();
        }
    }



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
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "}";
    }
    }

}

