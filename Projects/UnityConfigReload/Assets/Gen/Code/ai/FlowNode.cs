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

public abstract partial class FlowNode :  ai.Node 
{
    public FlowNode(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Decorators = new System.Collections.Generic.List<ai.Decorator>(n);for(var i = 0 ; i < n ; i++) { ai.Decorator _e;  _e = ai.Decorator.DeserializeDecorator(_buf); Decorators.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Services = new System.Collections.Generic.List<ai.Service>(n);for(var i = 0 ; i < n ; i++) { ai.Service _e;  _e = ai.Service.DeserializeService(_buf); Services.Add(_e);}}
        PostInit();
    }

    public static FlowNode DeserializeFlowNode(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.Sequence.__ID__: return new ai.Sequence(_buf);
            case ai.Selector.__ID__: return new ai.Selector(_buf);
            case ai.SimpleParallel.__ID__: return new ai.SimpleParallel(_buf);
            case ai.UeWait.__ID__: return new ai.UeWait(_buf);
            case ai.UeWaitBlackboardTime.__ID__: return new ai.UeWaitBlackboardTime(_buf);
            case ai.MoveToTarget.__ID__: return new ai.MoveToTarget(_buf);
            case ai.ChooseSkill.__ID__: return new ai.ChooseSkill(_buf);
            case ai.MoveToRandomLocation.__ID__: return new ai.MoveToRandomLocation(_buf);
            case ai.MoveToLocation.__ID__: return new ai.MoveToLocation(_buf);
            case ai.DebugPrint.__ID__: return new ai.DebugPrint(_buf);
            default: throw new SerializationException();
        }
    }

    public System.Collections.Generic.List<ai.Decorator> Decorators { get; private set; }
    public System.Collections.Generic.List<ai.Service> Services { get; private set; }


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Decorators) { _e?.Resolve(_tables); }
        foreach(var _e in Services) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Decorators) { _e?.TranslateText(translator); }
        foreach(var _e in Services) { _e?.TranslateText(translator); }
    }

    public void Reload(FlowNode reloadData)
    {
        typeof(FlowNode).GetProperty("Decorators").SetValue(this, reloadData.Decorators);
        typeof(FlowNode).GetProperty("Services").SetValue(this, reloadData.Services);
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
