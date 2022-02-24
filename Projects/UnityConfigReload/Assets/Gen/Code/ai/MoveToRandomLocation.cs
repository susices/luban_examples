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

public sealed partial class MoveToRandomLocation :  ai.Task 
{
    public MoveToRandomLocation(ByteBuf _buf)  : base(_buf) 
    {
        OriginPositionKey = _buf.ReadString();
        Radius = _buf.ReadFloat();
        PostInit();
    }

    public static MoveToRandomLocation DeserializeMoveToRandomLocation(ByteBuf _buf)
    {
        return new ai.MoveToRandomLocation(_buf);
    }

    public string OriginPositionKey { get; private set; }
    public float Radius { get; private set; }

    public const int __ID__ = -2140042998;
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

    public void Reload(MoveToRandomLocation reloadData)
    {
        typeof(MoveToRandomLocation).GetProperty("OriginPositionKey").SetValue(this, reloadData.OriginPositionKey);
        typeof(MoveToRandomLocation).GetProperty("Radius").SetValue(this, reloadData.Radius);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "OriginPositionKey:" + OriginPositionKey + ","
        + "Radius:" + Radius + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
