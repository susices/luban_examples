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



namespace cfg.test
{

public sealed class H2 :  Bright.Config.BeanBase 
{
    public H2(JSONNode _json) 
    {
        { if(!_json["z2"].IsNumber) { throw new SerializationException(); }  Z2 = _json["z2"]; }
        { if(!_json["z3"].IsNumber) { throw new SerializationException(); }  Z3 = _json["z3"]; }
    }

    public H2(int z2, int z3 ) 
    {
        this.Z2 = z2;
        this.Z3 = z3;
    }

    public static H2 DeserializeH2(JSONNode _json)
    {
        return new test.H2(_json);
    }

    public int Z2 { get; private set; }
    public int Z3 { get; private set; }

    public const int __ID__ = -1422503994;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Z2:" + Z2 + ","
        + "Z3:" + Z3 + ","
        + "}";
    }
    }
}
