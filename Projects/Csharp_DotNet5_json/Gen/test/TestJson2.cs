
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

public sealed class TestJson2 :  Bright.Config.BeanBase 
{
    public TestJson2(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        { var _json0 = _json.GetProperty("m1"); M1 = new System.Collections.Generic.Dictionary<int, int>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { int __k;  __k = __e[0].GetInt32(); int __v;  __v = __e[1].GetInt32();  M1.Add(__k, __v); }   }
        { var _json0 = _json.GetProperty("m2"); M2 = new System.Collections.Generic.Dictionary<long, int>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { long __k;  __k = __e[0].GetInt64(); int __v;  __v = __e[1].GetInt32();  M2.Add(__k, __v); }   }
        { var _json0 = _json.GetProperty("m3"); M3 = new System.Collections.Generic.Dictionary<string, int>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { string __k;  __k = __e[0].GetString(); int __v;  __v = __e[1].GetInt32();  M3.Add(__k, __v); }   }
        { var _json0 = _json.GetProperty("m4"); M4 = new System.Collections.Generic.Dictionary<string, test.DemoType1>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { string __k;  __k = __e[0].GetString(); test.DemoType1 __v;  __v =  test.DemoType1.DeserializeDemoType1(__e[1]);  M4.Add(__k, __v); }   }
    }

    public TestJson2(int id, System.Collections.Generic.Dictionary<int, int> m1, System.Collections.Generic.Dictionary<long, int> m2, System.Collections.Generic.Dictionary<string, int> m3, System.Collections.Generic.Dictionary<string, test.DemoType1> m4 ) 
    {
        this.Id = id;
        this.M1 = m1;
        this.M2 = m2;
        this.M3 = m3;
        this.M4 = m4;
    }

    public static TestJson2 DeserializeTestJson2(JsonElement _json)
    {
        return new test.TestJson2(_json);
    }

    public int Id {get; private set; }
    public System.Collections.Generic.Dictionary<int, int> M1 {get; private set; }
    public System.Collections.Generic.Dictionary<long, int> M2 {get; private set; }
    public System.Collections.Generic.Dictionary<string, int> M3 {get; private set; }
    public System.Collections.Generic.Dictionary<string, test.DemoType1> M4 {get; private set; }

    public const int ID = 1942237276;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in M4.Values) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in M4.Values) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "M1:" + Bright.Common.StringUtil.CollectionToString(M1) + ","
        + "M2:" + Bright.Common.StringUtil.CollectionToString(M2) + ","
        + "M3:" + Bright.Common.StringUtil.CollectionToString(M3) + ","
        + "M4:" + Bright.Common.StringUtil.CollectionToString(M4) + ","
        + "}";
    }
    }
}
