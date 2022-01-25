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

public sealed partial class DefineFromExcel2 :  Bright.Config.BeanBase 
{
    public DefineFromExcel2(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        X1 = _json.GetProperty("x1").GetBoolean();
        X5 = _json.GetProperty("x5").GetInt64();
        X6 = _json.GetProperty("x6").GetSingle();
        X8 = _json.GetProperty("x8").GetInt32();
        X10 = _json.GetProperty("x10").GetString();
        X13 = (test.ETestQuality)_json.GetProperty("x13").GetInt32();
        X14 =  test.DemoDynamic.DeserializeDemoDynamic(_json.GetProperty("x14"));
        { var _json0 = _json.GetProperty("v2"); float __x; __x = _json0.GetProperty("x").GetSingle(); float __y; __y = _json0.GetProperty("y").GetSingle(); V2 = new System.Numerics.Vector2(__x, __y); }
        T1 = _json.GetProperty("t1").GetInt32();
        { var _json0 = _json.GetProperty("k1"); int _n = _json0.GetArrayLength(); K1 = new int[_n]; int _index=0; foreach(JsonElement __e in _json0.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K1[_index++] = __v; }   }
        { var _json0 = _json.GetProperty("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { int __k;  __k = __e[0].GetInt32(); int __v;  __v = __e[1].GetInt32();  K8.Add(__k, __v); }   }
        { var _json0 = _json.GetProperty("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>(_json0.GetArrayLength()); foreach(JsonElement __e in _json0.EnumerateArray()) { test.DemoE2 __v;  __v =  test.DemoE2.DeserializeDemoE2(__e);  K9.Add(__v); }   }
        PostInit();
    }

    public DefineFromExcel2(int id, bool x1, long x5, float x6, int x8, string x10, test.ETestQuality x13, test.DemoDynamic x14, System.Numerics.Vector2 v2, int t1, int[] k1, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X5 = x5;
        this.X6 = x6;
        this.X8 = x8;
        this.X10 = x10;
        this.X13 = x13;
        this.X14 = x14;
        this.V2 = v2;
        this.T1 = t1;
        this.K1 = k1;
        this.K8 = k8;
        this.K9 = k9;
        PostInit();
    }

    public static DefineFromExcel2 DeserializeDefineFromExcel2(JsonElement _json)
    {
        return new test.DefineFromExcel2(_json);
    }

    /// <summary>
    /// 这是id
    /// </summary>
    public int Id { get; private set; }
    /// <summary>
    /// 字段x1
    /// </summary>
    public bool X1 { get; private set; }
    public long X5 { get; private set; }
    public float X6 { get; private set; }
    public int X8 { get; private set; }
    public string X10 { get; private set; }
    public test.ETestQuality X13 { get; private set; }
    public test.DemoDynamic X14 { get; private set; }
    public System.Numerics.Vector2 V2 { get; private set; }
    public int T1 { get; private set; }
    public long T1_Millis => T1 * 1000L;
    public int[] K1 { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> K8 { get; private set; }
    public System.Collections.Generic.List<test.DemoE2> K9 { get; private set; }

    public const int __ID__ = 688816828;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X14?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X8:" + X8 + ","
        + "X10:" + X10 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "V2:" + V2 + ","
        + "T1:" + T1 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
