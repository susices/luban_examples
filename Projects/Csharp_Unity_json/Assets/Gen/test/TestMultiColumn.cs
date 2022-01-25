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

public sealed partial class TestMultiColumn :  Bright.Config.BeanBase 
{
    public TestMultiColumn(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["a"].IsObject) { throw new SerializationException(); }  A = test.Foo.DeserializeFoo(_json["a"]); }
        { if(!_json["b"].IsObject) { throw new SerializationException(); }  B = test.Foo.DeserializeFoo(_json["b"]); }
        { if(!_json["c"].IsObject) { throw new SerializationException(); }  C = test.Foo.DeserializeFoo(_json["c"]); }
        PostInit();
    }

    public TestMultiColumn(int id, test.Foo a, test.Foo b, test.Foo c ) 
    {
        this.Id = id;
        this.A = a;
        this.B = b;
        this.C = c;
        PostInit();
    }

    public static TestMultiColumn DeserializeTestMultiColumn(JSONNode _json)
    {
        return new test.TestMultiColumn(_json);
    }

    public int Id { get; private set; }
    public test.Foo A { get; private set; }
    public test.Foo B { get; private set; }
    public test.Foo C { get; private set; }

    public const int __ID__ = -294473599;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        A?.Resolve(_tables);
        B?.Resolve(_tables);
        C?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        A?.TranslateText(translator);
        B?.TranslateText(translator);
        C?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "A:" + A + ","
        + "B:" + B + ","
        + "C:" + C + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
