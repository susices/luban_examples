//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.bonus
{

public sealed partial class WeightBonusInfo :  Bright.Config.BeanBase 
{
    public WeightBonusInfo(ByteBuf _buf) 
    {
        Bonus = bonus.Bonus.DeserializeBonus(_buf);
        Weight = _buf.ReadInt();
        PostInit();
    }

    public static WeightBonusInfo DeserializeWeightBonusInfo(ByteBuf _buf)
    {
        return new bonus.WeightBonusInfo(_buf);
    }

    public bonus.Bonus Bonus { get; private set; }
    public int Weight { get; private set; }

    public const int __ID__ = -907244058;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Bonus?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Bonus?.TranslateText(translator);
    }

    public void Reload(WeightBonusInfo reloadData)
    {
        Bonus = reloadData.Bonus;
        Weight = reloadData.Weight;
    }

    public override string ToString()
    {
        return "{ "
        + "Bonus:" + Bonus + ","
        + "Weight:" + Weight + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
