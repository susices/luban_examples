//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.bonus
{

public sealed partial class CoefficientItem :  bonus.Bonus 
{
    public CoefficientItem(JsonElement _json)  : base(_json) 
    {
        BonusId = _json.GetProperty("bonus_id").GetInt32();
        BonusList =  bonus.Items.DeserializeItems(_json.GetProperty("bonus_list"));
        PostInit();
    }

    public CoefficientItem(int bonus_id, bonus.Items bonus_list )  : base() 
    {
        this.BonusId = bonus_id;
        this.BonusList = bonus_list;
        PostInit();
    }

    public static CoefficientItem DeserializeCoefficientItem(JsonElement _json)
    {
        return new bonus.CoefficientItem(_json);
    }

    public int BonusId { get; private set; }
    public bonus.Items BonusList { get; private set; }

    public const int __ID__ = -229470727;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        BonusList?.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        BonusList?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "BonusId:" + BonusId + ","
        + "BonusList:" + BonusList + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
