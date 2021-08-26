
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



namespace cfg.blueprint
{

public sealed class Field :  Bright.Config.BeanBase 
{
    public Field(JsonElement _json) 
    {
        Name = _json.GetProperty("name").GetString();
        Type = _json.GetProperty("type").GetString();
        Desc = _json.GetProperty("desc").GetString();
    }

    public Field(string name, string type, string desc ) 
    {
        this.Name = name;
        this.Type = type;
        this.Desc = desc;
    }

    public static Field DeserializeField(JsonElement _json)
    {
        return new blueprint.Field(_json);
    }

    public string Name {get; private set; }
    public string Type {get; private set; }
    public string Desc {get; private set; }

    public const int ID = 1694158271;
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
        + "Name:" + Name + ","
        + "Type:" + Type + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    }
}
