
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



namespace cfg.condition
{

public sealed class MinMaxLevel :  condition.BoolRoleCondition 
{
    public MinMaxLevel(JsonElement _json)  : base(_json) 
    {
        Min = _json.GetProperty("min").GetInt32();
        Max = _json.GetProperty("max").GetInt32();
    }

    public MinMaxLevel(int min, int max )  : base() 
    {
        this.Min = min;
        this.Max = max;
    }

    public static MinMaxLevel DeserializeMinMaxLevel(JsonElement _json)
    {
        return new condition.MinMaxLevel(_json);
    }

    public int Min {get; private set; }
    public int Max {get; private set; }

    public const int ID = 907499647;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Min:" + Min + ","
        + "Max:" + Max + ","
        + "}";
    }
    }
}
