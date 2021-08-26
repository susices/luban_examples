
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



namespace cfg.role
{

public sealed class LevelBonus :  Bright.Config.BeanBase 
{
    public LevelBonus(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        { var _json0 = _json.GetProperty("distinct_bonus_infos"); DistinctBonusInfos = new System.Collections.Generic.List<role.DistinctBonusInfos>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { role.DistinctBonusInfos __v;  __v =  role.DistinctBonusInfos.DeserializeDistinctBonusInfos(__e);  DistinctBonusInfos.Add(__v); }   }
    }

    public LevelBonus(int id, System.Collections.Generic.List<role.DistinctBonusInfos> distinct_bonus_infos ) 
    {
        this.Id = id;
        this.DistinctBonusInfos = distinct_bonus_infos;
    }

    public static LevelBonus DeserializeLevelBonus(JsonElement _json)
    {
        return new role.LevelBonus(_json);
    }

    public int Id {get; private set; }
    public System.Collections.Generic.List<role.DistinctBonusInfos> DistinctBonusInfos {get; private set; }

    public const int ID = -572269677;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in DistinctBonusInfos) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in DistinctBonusInfos) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "DistinctBonusInfos:" + Bright.Common.StringUtil.CollectionToString(DistinctBonusInfos) + ","
        + "}";
    }
    }
}
