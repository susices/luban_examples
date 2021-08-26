
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

public sealed class Interface :  blueprint.Clazz 
{
    public Interface(JsonElement _json)  : base(_json) 
    {
    }

    public Interface(string name, string desc, System.Collections.Generic.List<blueprint.Clazz> parents, System.Collections.Generic.List<blueprint.Method> methods )  : base(name,desc,parents,methods) 
    {
    }

    public static Interface DeserializeInterface(JsonElement _json)
    {
        return new blueprint.Interface(_json);
    }


    public const int ID = 2114170750;
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
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "}";
    }
    }
}
