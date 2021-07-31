
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

/// <summary>
/// 
/// </summary>
public sealed partial class DefineFromExcel :  Bright.Config.BeanBase 
{
    public DefineFromExcel(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["x1"].IsBoolean) { throw new SerializationException(); }  X1 = _json["x1"]; }
        { if(!_json["x5"].IsNumber) { throw new SerializationException(); }  X5 = _json["x5"]; }
        { if(!_json["x6"].IsNumber) { throw new SerializationException(); }  X6 = _json["x6"]; }
        { if(!_json["x8"].IsNumber) { throw new SerializationException(); }  X8 = _json["x8"]; }
        { if(!_json["x10"].IsString) { throw new SerializationException(); }  X10 = _json["x10"]; }
        { if(!_json["x13"].IsNumber) { throw new SerializationException(); }  X13 = (test.DemoEnum)_json["x13"].AsInt; }
        { if(!_json["x14"].IsObject) { throw new SerializationException(); }  X14 = test.DemoDynamic.DeserializeDemoDynamic(_json["x14"]); }
        { var _json2 = _json["v2"]; if(!_json2.IsObject) { throw new SerializationException(); }  float __x; { if(!_json2["x"].IsNumber) { throw new SerializationException(); }  __x = _json2["x"]; } float __y; { if(!_json2["y"].IsNumber) { throw new SerializationException(); }  __y = _json2["y"]; } V2 = new System.Numerics.Vector2(__x, __y); }
        { if(!_json["t1"].IsNumber) { throw new SerializationException(); }  T1 = _json["t1"]; }
        { var _json1 = _json["k1"]; if(!_json1.IsArray) { throw new SerializationException(); } int _n = _json1.Count; K1 = new int[_n]; int _index=0; foreach(JSONNode __e in _json1.Children) { int __v;  { if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e; }  K1[_index++] = __v; }   }
        { var _json1 = _json["k8"]; if(!_json1.IsArray) { throw new SerializationException(); } K8 = new System.Collections.Generic.Dictionary<int, int>(_json1.Count); foreach(JSONNode __e in _json1.Children) { int __k;  { if(!__e[0].IsNumber) { throw new SerializationException(); }  __k = __e[0]; } int __v;  { if(!__e[1].IsNumber) { throw new SerializationException(); }  __v = __e[1]; }  K8.Add(__k, __v); }   }
        { var _json1 = _json["k9"]; if(!_json1.IsArray) { throw new SerializationException(); } K9 = new System.Collections.Generic.List<test.DemoE2>(_json1.Count); foreach(JSONNode __e in _json1.Children) { test.DemoE2 __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = test.DemoE2.DeserializeDemoE2(__e); }  K9.Add(__v); }   }
    }

    public DefineFromExcel(int id, bool x1, long x5, float x6, int x8, string x10, test.DemoEnum x13, test.DemoDynamic x14, System.Numerics.Vector2 v2, int t1, int[] k1, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9 ) 
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
    }

    public static DefineFromExcel DeserializeDefineFromExcel(JSONNode _json)
    {
        return new test.DefineFromExcel(_json);
    }

    /// <summary>
    /// id的描述
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 字段的描述
    /// </summary>
    public readonly bool X1;
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
    public readonly int X8;
    public test.DemoPrimitiveTypesTable X8_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly string X10;
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
    public readonly System.Numerics.Vector2 V2;
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
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<test.DemoE2> K9;

    public const int ID = 2100429878;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.X8_Ref = (_tables["test.TbDemoPrimitive"] as test.TbDemoPrimitive).GetOrDefault(X8);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

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
    }
}

