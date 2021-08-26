
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

public sealed class WeightBonus :  bonus.Bonus 
{
    public WeightBonus(JsonElement _json)  : base(_json) 
    {
        { var _json0 = _json.GetProperty("bonuses"); int _n = _json0.GetArrayLength(); Bonuses = new bonus.WeightBonusInfo[_n]; int _index=0; foreach(JsonElement __e in _json0.EnumerateArray()) { bonus.WeightBonusInfo __v;  __v =  bonus.WeightBonusInfo.DeserializeWeightBonusInfo(__e);  Bonuses[_index++] = __v; }   }
    }

    public WeightBonus(bonus.WeightBonusInfo[] bonuses )  : base() 
    {
        this.Bonuses = bonuses;
    }

    public static WeightBonus DeserializeWeightBonus(JsonElement _json)
    {
        return new bonus.WeightBonus(_json);
    }

    public bonus.WeightBonusInfo[] Bonuses {get; private set; }

    public const int ID = -362807016;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Bonuses) { _e?.Resolve(_tables); }
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Bonuses) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Bonuses:" + Bright.Common.StringUtil.CollectionToString(Bonuses) + ","
        + "}";
    }
    }
}
