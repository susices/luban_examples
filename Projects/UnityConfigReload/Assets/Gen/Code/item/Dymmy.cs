//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed partial class Dymmy :  item.ItemExtra 
{
    public Dymmy(ByteBuf _buf)  : base(_buf) 
    {
        Cost = cost.Cost.DeserializeCost(_buf);
        PostInit();
    }

    public static Dymmy DeserializeDymmy(ByteBuf _buf)
    {
        return new item.Dymmy(_buf);
    }

    public cost.Cost Cost { get; private set; }

    public const int __ID__ = 896889705;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        Cost?.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        Cost?.TranslateText(translator);
    }

    public void Reload(Dymmy reloadData)
    {
        typeof(Dymmy).GetProperty("Cost").SetValue(this, reloadData.Cost);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Cost:" + Cost + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
