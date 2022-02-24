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

public sealed partial class MoveToLocation :  ai.Task 
{
    public MoveToLocation(ByteBuf _buf)  : base(_buf) 
    {
        Location = _buf.ReadVector3();
        AcceptableRadius = _buf.ReadFloat();
        PostInit();
    }

    public static MoveToLocation DeserializeMoveToLocation(ByteBuf _buf)
    {
        return new ai.MoveToLocation(_buf);
    }

    public System.Numerics.Vector3 Location { get; private set; }
    public float AcceptableRadius { get; private set; }

    public const int __ID__ = -969953113;
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

    public void Reload(MoveToLocation reloadData)
    {
        typeof(MoveToLocation).GetProperty("Location").SetValue(this, reloadData.Location);
        typeof(MoveToLocation).GetProperty("AcceptableRadius").SetValue(this, reloadData.AcceptableRadius);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "Decorators:" + Bright.Common.StringUtil.CollectionToString(Decorators) + ","
        + "Services:" + Bright.Common.StringUtil.CollectionToString(Services) + ","
        + "IgnoreRestartSelf:" + IgnoreRestartSelf + ","
        + "Location:" + Location + ","
        + "AcceptableRadius:" + AcceptableRadius + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
