
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

/// <summary>
/// 
/// </summary>
public sealed partial class DemoType2 :  Bright.Config.BeanBase 
{
    public DemoType2(JsonElement _buf) 
    {
        X4 = _buf.GetProperty("x4").GetInt32();
        X1 = _buf.GetProperty("x1").GetBoolean();
        X2 = _buf.GetProperty("x2").GetByte();
        X3 = _buf.GetProperty("x3").GetInt16();
        X5 = _buf.GetProperty("x5").GetInt64();
        X6 = _buf.GetProperty("x6").GetSingle();
        X7 = _buf.GetProperty("x7").GetDouble();
        X80 = _buf.GetProperty("x8_0").GetInt16();
        X8 = _buf.GetProperty("x8").GetInt32();
        X9 = _buf.GetProperty("x9").GetInt64();
        X10 = _buf.GetProperty("x10").GetString();
        X12 =  test.DemoType1.DeserializeDemoType1(_buf.GetProperty("x12"));
        X13 = (test.DemoEnum)_buf.GetProperty("x13").GetInt32();
        X14 =  test.DemoDynamic.DeserializeDemoDynamic(_buf.GetProperty("x14"));
        S1 = _buf.GetProperty("s1").GetString();
        { var _json = _buf.GetProperty("v2"); float __x; __x = _json.GetProperty("x").GetSingle(); float __y; __y = _json.GetProperty("y").GetSingle(); V2 = new System.Numerics.Vector2(__x, __y); }
        { var _json = _buf.GetProperty("v3"); float __x; __x = _json.GetProperty("x").GetSingle(); float __y; __y = _json.GetProperty("y").GetSingle(); float __z; __z = _json.GetProperty("z").GetSingle();  V3 = new System.Numerics.Vector3(__x, __y,__z); }
        { var _json = _buf.GetProperty("v4"); float __x; __x = _json.GetProperty("x").GetSingle(); float __y; __y = _json.GetProperty("y").GetSingle(); float __z; __z = _json.GetProperty("z").GetSingle();  float __w; __w = _json.GetProperty("w").GetSingle(); V4 = new System.Numerics.Vector4(__x, __y, __z, __w); }
        T1 = _buf.GetProperty("t1").GetInt32();
        { var _json = _buf.GetProperty("k1"); int _n = _json.GetArrayLength(); K1 = new int[_n]; int _index=0; foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K1[_index++] = __v; }   }
        { var _json = _buf.GetProperty("k2"); K2 = new System.Collections.Generic.List<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K2.Add(__v); }   }
        { var _json = _buf.GetProperty("k3"); K3 = new System.Collections.Generic.List<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K3.Add(__v); }   }
        { var _json = _buf.GetProperty("k4"); K4 = new System.Collections.Generic.List<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K4.Add(__v); }   }
        { var _json = _buf.GetProperty("k5"); K5 = new System.Collections.Generic.HashSet<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K5.Add(__v); }   }
        { var _json = _buf.GetProperty("k6"); K6 = new System.Collections.Generic.HashSet<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K6.Add(__v); }   }
        { var _json = _buf.GetProperty("k7"); K7 = new System.Collections.Generic.HashSet<int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __v;  __v = __e.GetInt32();  K7.Add(__v); }   }
        { var _json = _buf.GetProperty("k8"); K8 = new System.Collections.Generic.Dictionary<int, int>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { int __k;  __k = __e[0].GetInt32(); int __v;  __v = __e[1].GetInt32();  K8.Add(__k, __v); }   }
        { var _json = _buf.GetProperty("k9"); K9 = new System.Collections.Generic.List<test.DemoE2>(_json.GetArrayLength()); foreach(JsonElement __e in _json.EnumerateArray()) { test.DemoE2 __v;  __v =  test.DemoE2.DeserializeDemoE2(__e);  K9.Add(__v); }   }
        foreach(var _v in K9) { K9_Index.Add(_v.Y1, _v); }
        { var _json = _buf.GetProperty("k15"); int _n = _json.GetArrayLength(); K15 = new test.DemoDynamic[_n]; int _index=0; foreach(JsonElement __e in _json.EnumerateArray()) { test.DemoDynamic __v;  __v =  test.DemoDynamic.DeserializeDemoDynamic(__e);  K15[_index++] = __v; }   }
    }

    public DemoType2(int x4, bool x1, byte x2, short x3, long x5, float x6, double x7, short x8_0, int x8, long x9, string x10, test.DemoType1 x12, test.DemoEnum x13, test.DemoDynamic x14, string s1, System.Numerics.Vector2 v2, System.Numerics.Vector3 v3, System.Numerics.Vector4 v4, int t1, int[] k1, System.Collections.Generic.List<int> k2, System.Collections.Generic.List<int> k3, System.Collections.Generic.List<int> k4, System.Collections.Generic.HashSet<int> k5, System.Collections.Generic.HashSet<int> k6, System.Collections.Generic.HashSet<int> k7, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9, test.DemoDynamic[] k15 ) 
    {
        this.X4 = x4;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X5 = x5;
        this.X6 = x6;
        this.X7 = x7;
        this.X80 = x8_0;
        this.X8 = x8;
        this.X9 = x9;
        this.X10 = x10;
        this.X12 = x12;
        this.X13 = x13;
        this.X14 = x14;
        this.S1 = s1;
        this.V2 = v2;
        this.V3 = v3;
        this.V4 = v4;
        this.T1 = t1;
        this.K1 = k1;
        this.K2 = k2;
        this.K3 = k3;
        this.K4 = k4;
        this.K5 = k5;
        this.K6 = k6;
        this.K7 = k7;
        this.K8 = k8;
        this.K9 = k9;
        foreach(var _v in K9) { K9_Index.Add(_v.Y1, _v); }
        this.K15 = k15;
    }

    public static DemoType2 DeserializeDemoType2(JsonElement _buf)
    {
        return new test.DemoType2(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int X4;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool X1;
    /// <summary>
    /// 
    /// </summary>
    public readonly byte X2;
    /// <summary>
    /// 
    /// </summary>
    public readonly short X3;
    public test.DemoType2 X3_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly long X5;
    /// <summary>
    /// 
    /// </summary>
    public readonly float X6;
    /// <summary>
    /// 
    /// </summary>
    public readonly double X7;
    /// <summary>
    /// 
    /// </summary>
    public readonly short X80;
    /// <summary>
    /// 
    /// </summary>
    public readonly int X8;
    /// <summary>
    /// 
    /// </summary>
    public readonly long X9;
    /// <summary>
    /// 
    /// </summary>
    public readonly string X10;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoType1 X12;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoEnum X13;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoDynamic X14;
    /// <summary>
    /// 
    /// </summary>
    public readonly string S1;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector2 V2;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector3 V3;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector4 V4;
    /// <summary>
    /// 
    /// </summary>
    public readonly int T1;
    /// <summary>
    /// 
    /// </summary>
    public readonly int[] K1;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<int> K2;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<int> K3;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<int> K4;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<int> K5;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<int> K6;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<int> K7;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<test.DemoE2> K9;
    public readonly Dictionary<int?, test.DemoE2> K9_Index = new Dictionary<int?, test.DemoE2>();
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoDynamic[] K15;

    public const int ID = -367048295;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.X3_Ref = (_tables["test.TbFullTypes"] as test.TbFullTypes).GetOrDefault(X3);
        X12?.Resolve(_tables);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        foreach(var _e in K15) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "X4:" + X4 + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X7:" + X7 + ","
        + "X80:" + X80 + ","
        + "X8:" + X8 + ","
        + "X9:" + X9 + ","
        + "X10:" + X10 + ","
        + "X12:" + X12 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "S1:" + S1 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K2:" + Bright.Common.StringUtil.CollectionToString(K2) + ","
        + "K3:" + Bright.Common.StringUtil.CollectionToString(K3) + ","
        + "K4:" + Bright.Common.StringUtil.CollectionToString(K4) + ","
        + "K5:" + Bright.Common.StringUtil.CollectionToString(K5) + ","
        + "K6:" + Bright.Common.StringUtil.CollectionToString(K6) + ","
        + "K7:" + Bright.Common.StringUtil.CollectionToString(K7) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "K15:" + Bright.Common.StringUtil.CollectionToString(K15) + ","
        + "}";
    }
    }
}

