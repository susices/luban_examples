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

public abstract partial class Decorator :  ai.Node 
{
    public Decorator(ByteBuf _buf)  : base(_buf) 
    {
        FlowAbortMode = (ai.EFlowAbortMode)_buf.ReadInt();
        PostInit();
    }

    public static Decorator DeserializeDecorator(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.UeLoop.__ID__: return new ai.UeLoop(_buf);
            case ai.UeCooldown.__ID__: return new ai.UeCooldown(_buf);
            case ai.UeTimeLimit.__ID__: return new ai.UeTimeLimit(_buf);
            case ai.UeBlackboard.__ID__: return new ai.UeBlackboard(_buf);
            case ai.UeForceSuccess.__ID__: return new ai.UeForceSuccess(_buf);
            case ai.IsAtLocation.__ID__: return new ai.IsAtLocation(_buf);
            case ai.DistanceLessThan.__ID__: return new ai.DistanceLessThan(_buf);
            default: throw new SerializationException();
        }
    }

    public ai.EFlowAbortMode FlowAbortMode { get; private set; }


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(Decorator reloadData)
    {
        //Luban.Job.Common.Types.TEnum
        FlowAbortMode = reloadData.FlowAbortMode;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "FlowAbortMode:" + FlowAbortMode + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
