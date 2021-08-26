
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



namespace cfg.ai
{

public sealed class BlackboardKeyData :  ai.KeyData 
{
    public BlackboardKeyData(JsonElement _json)  : base(_json) 
    {
        Value = _json.GetProperty("value").GetString();
    }

    public BlackboardKeyData(string value )  : base() 
    {
        this.Value = value;
    }

    public static BlackboardKeyData DeserializeBlackboardKeyData(JsonElement _json)
    {
        return new ai.BlackboardKeyData(_json);
    }

    public string Value {get; private set; }

    public const int ID = 1517269500;
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
        + "Value:" + Value + ","
        + "}";
    }
    }
}
