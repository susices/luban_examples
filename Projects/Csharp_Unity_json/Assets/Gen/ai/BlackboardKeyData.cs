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

public sealed partial class BlackboardKeyData :  ai.KeyData 
{
    public BlackboardKeyData(JSONNode _json)  : base(_json) 
    {
        { if(!_json["value"].IsString) { throw new SerializationException(); }  Value = _json["value"]; }
        PostInit();
    }

    public BlackboardKeyData(string value )  : base() 
    {
        this.Value = value;
        PostInit();
    }

    public static BlackboardKeyData DeserializeBlackboardKeyData(JSONNode _json)
    {
        return new ai.BlackboardKeyData(_json);
    }

    public string Value { get; private set; }

    public const int __ID__ = 1517269500;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
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
    
    partial void PostInit();
    partial void PostResolve();
}
}
