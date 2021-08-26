
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

public sealed class WeightBonusInfo :  Bright.Config.BeanBase 
{
    public WeightBonusInfo(JsonElement _json) 
    {
        Bonus =  bonus.Bonus.DeserializeBonus(_json.GetProperty("bonus"));
        Weight = _json.GetProperty("weight").GetInt32();
    }

    public WeightBonusInfo(bonus.Bonus bonus, int weight ) 
    {
        this.Bonus = bonus;
        this.Weight = weight;
    }

    public static WeightBonusInfo DeserializeWeightBonusInfo(JsonElement _json)
    {
        return new bonus.WeightBonusInfo(_json);
    }

    public bonus.Bonus Bonus {get; private set; }
    public int Weight {get; private set; }

    public const int ID = -907244058;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Bonus?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Bonus?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Bonus:" + Bonus + ","
        + "Weight:" + Weight + ","
        + "}";
    }
    }
}
