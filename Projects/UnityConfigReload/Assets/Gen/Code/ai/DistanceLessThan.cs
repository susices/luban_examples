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

public sealed partial class DistanceLessThan :  ai.Decorator 
{
    public DistanceLessThan(ByteBuf _buf)  : base(_buf) 
    {
        Actor1Key = _buf.ReadString();
        Actor2Key = _buf.ReadString();
        Distance = _buf.ReadFloat();
        ReverseResult = _buf.ReadBool();
        PostInit();
    }

    public static DistanceLessThan DeserializeDistanceLessThan(ByteBuf _buf)
    {
        return new ai.DistanceLessThan(_buf);
    }

    public string Actor1Key { get; private set; }
    public string Actor2Key { get; private set; }
    public float Distance { get; private set; }
    public bool ReverseResult { get; private set; }

    public const int __ID__ = -1207170283;
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

    public void Reload(DistanceLessThan reloadData)
    {
        typeof(DistanceLessThan).GetProperty("Actor1Key").SetValue(this, reloadData.Actor1Key);
        typeof(DistanceLessThan).GetProperty("Actor2Key").SetValue(this, reloadData.Actor2Key);
        typeof(DistanceLessThan).GetProperty("Distance").SetValue(this, reloadData.Distance);
        typeof(DistanceLessThan).GetProperty("ReverseResult").SetValue(this, reloadData.ReverseResult);
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
    
    partial void PostInit();
    partial void PostResolve();
}

}
