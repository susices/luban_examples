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
        PostInit();
    }

    public static ComposeNode DeserializeComposeNode(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.Sequence.__ID__: return new ai.Sequence(_buf);
            case ai.Selector.__ID__: return new ai.Selector(_buf);
            case ai.SimpleParallel.__ID__: return new ai.SimpleParallel(_buf);
            default: throw new SerializationException();
        }
    }



    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(ComposeNode reloadData)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
