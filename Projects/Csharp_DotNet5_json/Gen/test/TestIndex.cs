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



namespace cfg.test
{

public sealed partial class TestIndex :  Bright.Config.BeanBase 
{
    public TestIndex(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        { var _json0 = _json.GetProperty("eles"); Eles = new System.Collections.Generic.List<test.DemoType1>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { test.DemoType1 __v;  __v =  test.DemoType1.DeserializeDemoType1(__e);  Eles.Add(__v); }   }
        PostInit();
    }

    public TestIndex(int id, System.Collections.Generic.List<test.DemoType1> eles ) 
    {
        this.Id = id;
        this.Eles = eles;
        PostInit();
    }

    public static TestIndex DeserializeTestIndex(JsonElement _json)
    {
        return new test.TestIndex(_json);
    }

    public int Id { get; private set; }
    public System.Collections.Generic.List<test.DemoType1> Eles { get; private set; }

    public const int __ID__ = 1941154020;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Eles) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Eles) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Eles:" + Bright.Common.StringUtil.CollectionToString(Eles) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
