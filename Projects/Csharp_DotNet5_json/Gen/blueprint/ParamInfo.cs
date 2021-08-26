
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

public sealed class ParamInfo :  Bright.Config.BeanBase 
{
    public ParamInfo(JsonElement _json) 
    {
        Name = _json.GetProperty("name").GetString();
        Type = _json.GetProperty("type").GetString();
        IsRef = _json.GetProperty("is_ref").GetBoolean();
    }

    public ParamInfo(string name, string type, bool is_ref ) 
    {
        this.Name = name;
        this.Type = type;
        this.IsRef = is_ref;
    }

    public static ParamInfo DeserializeParamInfo(JsonElement _json)
    {
        return new blueprint.ParamInfo(_json);
    }

    public string Name {get; private set; }
    public string Type {get; private set; }
    public bool IsRef {get; private set; }

    public const int ID = -729799392;
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
        + "IsRef:" + IsRef + ","
        + "}";
    }
    }
}
