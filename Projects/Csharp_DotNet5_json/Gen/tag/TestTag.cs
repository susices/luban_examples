
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



namespace cfg.tag
{

public sealed class TestTag :  Bright.Config.BeanBase 
{
    public TestTag(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        Value = _json.GetProperty("value").GetString();
    }

    public TestTag(int id, string value ) 
    {
        this.Id = id;
        this.Value = value;
    }

    public static TestTag DeserializeTestTag(JsonElement _json)
    {
        return new tag.TestTag(_json);
    }

    public int Id {get; private set; }
    public string Value {get; private set; }

    public const int ID = 1742933812;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Value:" + Value + ","
        + "}";
    }
    }
}
