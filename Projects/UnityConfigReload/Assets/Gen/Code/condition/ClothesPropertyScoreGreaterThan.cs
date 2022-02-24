//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{

public sealed partial class ClothesPropertyScoreGreaterThan :  condition.BoolRoleCondition 
{
    public ClothesPropertyScoreGreaterThan(ByteBuf _buf)  : base(_buf) 
    {
        Prop = (item.EClothesPropertyType)_buf.ReadInt();
        Value = _buf.ReadInt();
        PostInit();
    }

    public static ClothesPropertyScoreGreaterThan DeserializeClothesPropertyScoreGreaterThan(ByteBuf _buf)
    {
        return new condition.ClothesPropertyScoreGreaterThan(_buf);
    }

    public item.EClothesPropertyType Prop { get; private set; }
    public int Value { get; private set; }

    public const int __ID__ = 696630835;
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

    public void Reload(ClothesPropertyScoreGreaterThan reloadData)
    {
        typeof(ClothesPropertyScoreGreaterThan).GetProperty("Prop").SetValue(this, reloadData.Prop);
        typeof(ClothesPropertyScoreGreaterThan).GetProperty("Value").SetValue(this, reloadData.Value);
    }

    public override string ToString()
    {
        return "{ "
        + "Prop:" + Prop + ","
        + "Value:" + Value + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
