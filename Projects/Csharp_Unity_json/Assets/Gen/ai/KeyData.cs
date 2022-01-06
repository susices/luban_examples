//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.ai
{

public abstract class KeyData :  Bright.Config.BeanBase 
{
    public KeyData(JSONNode _json) 
    {
    }

    public KeyData() 
    {
    }

    public static KeyData DeserializeKeyData(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "FloatKeyData": return new ai.FloatKeyData(_json);
            case "IntKeyData": return new ai.IntKeyData(_json);
            case "StringKeyData": return new ai.StringKeyData(_json);
            case "BlackboardKeyData": return new ai.BlackboardKeyData(_json);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }
}
