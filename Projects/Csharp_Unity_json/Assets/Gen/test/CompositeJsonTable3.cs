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

public sealed partial class CompositeJsonTable3 :  Bright.Config.BeanBase 
{
    public CompositeJsonTable3(JSONNode _json) 
    {
        { if(!_json["a"].IsNumber) { throw new SerializationException(); }  A = _json["a"]; }
        { if(!_json["b"].IsNumber) { throw new SerializationException(); }  B = _json["b"]; }
        PostInit();
    }

    public CompositeJsonTable3(int a, int b ) 
    {
        this.A = a;
        this.B = b;
        PostInit();
    }

    public static CompositeJsonTable3 DeserializeCompositeJsonTable3(JSONNode _json)
    {
        return new test.CompositeJsonTable3(_json);
    }

    public int A { get; private set; }
    public int B { get; private set; }

    public const int __ID__ = 1566207896;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "A:" + A + ","
        + "B:" + B + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
