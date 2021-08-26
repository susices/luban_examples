
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

public sealed class UeSetDefaultFocus :  ai.Service 
{
    public UeSetDefaultFocus(JsonElement _json)  : base(_json) 
    {
        KeyboardKey = _json.GetProperty("keyboard_key").GetString();
    }

    public UeSetDefaultFocus(int id, string node_name, string keyboard_key )  : base(id,node_name) 
    {
        this.KeyboardKey = keyboard_key;
    }

    public static UeSetDefaultFocus DeserializeUeSetDefaultFocus(JsonElement _json)
    {
        return new ai.UeSetDefaultFocus(_json);
    }

    public string KeyboardKey {get; private set; }

    public const int ID = 1812449155;
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
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "KeyboardKey:" + KeyboardKey + ","
        + "}";
    }
    }
}
