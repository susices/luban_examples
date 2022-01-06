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

public sealed class TestSep :  Bright.Config.BeanBase 
{
    public TestSep(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { if(!_json["x1"]["key"].IsString) { throw new SerializationException(); }  X1_l10n_key = _json["x1"]["key"]; if(!_json["x1"]["text"].IsString) { throw new SerializationException(); }  X1 = _json["x1"]["text"]; }
        { if(!_json["x2"].IsObject) { throw new SerializationException(); }  X2 = test.SepBean1.DeserializeSepBean1(_json["x2"]); }
        { if(!_json["x3"].IsObject) { throw new SerializationException(); }  X3 = test.SepVector.DeserializeSepVector(_json["x3"]); }
        { var _json1 = _json["x4"]; if(!_json1.IsArray) { throw new SerializationException(); } X4 = new System.Collections.Generic.List<test.SepVector>(_json1.Count); foreach(JSONNode __e in _json1.Children) { test.SepVector __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = test.SepVector.DeserializeSepVector(__e); }  X4.Add(__v); }   }
        { var _json1 = _json["x5"]; if(!_json1.IsArray) { throw new SerializationException(); } X5 = new System.Collections.Generic.List<test.SepBean1>(_json1.Count); foreach(JSONNode __e in _json1.Children) { test.SepBean1 __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = test.SepBean1.DeserializeSepBean1(__e); }  X5.Add(__v); }   }
        { var _json1 = _json["x6"]; if(!_json1.IsArray) { throw new SerializationException(); } X6 = new System.Collections.Generic.List<test.SepBean1>(_json1.Count); foreach(JSONNode __e in _json1.Children) { test.SepBean1 __v;  { if(!__e.IsObject) { throw new SerializationException(); }  __v = test.SepBean1.DeserializeSepBean1(__e); }  X6.Add(__v); }   }
    }

    public TestSep(int id, string x1, test.SepBean1 x2, test.SepVector x3, System.Collections.Generic.List<test.SepVector> x4, System.Collections.Generic.List<test.SepBean1> x5, System.Collections.Generic.List<test.SepBean1> x6 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.X5 = x5;
        this.X6 = x6;
    }

    public static TestSep DeserializeTestSep(JSONNode _json)
    {
        return new test.TestSep(_json);
    }

    public int Id { get; private set; }
    public string X1 { get; private set; }
    public string X1_l10n_key { get; }
    public test.SepBean1 X2 { get; private set; }
    /// <summary>
    /// SepVector已经定义了sep=,属性
    /// </summary>
    public test.SepVector X3 { get; private set; }
    /// <summary>
    /// 用;来分割数据，然后顺序读入SepVector
    /// </summary>
    public System.Collections.Generic.List<test.SepVector> X4 { get; private set; }
    /// <summary>
    /// 用,分割数据，然后顺序读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X5 { get; private set; }
    /// <summary>
    /// 用;分割数据，然后再将每个数据用,分割，读入
    /// </summary>
    public System.Collections.Generic.List<test.SepBean1> X6 { get; private set; }

    public const int __ID__ = -543221520;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X2?.Resolve(_tables);
        X3?.Resolve(_tables);
        foreach(var _e in X4) { _e?.Resolve(_tables); }
        foreach(var _e in X5) { _e?.Resolve(_tables); }
        foreach(var _e in X6) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X1 = translator(X1_l10n_key, X1);
        X2?.TranslateText(translator);
        X3?.TranslateText(translator);
        foreach(var _e in X4) { _e?.TranslateText(translator); }
        foreach(var _e in X5) { _e?.TranslateText(translator); }
        foreach(var _e in X6) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + Bright.Common.StringUtil.CollectionToString(X4) + ","
        + "X5:" + Bright.Common.StringUtil.CollectionToString(X5) + ","
        + "X6:" + Bright.Common.StringUtil.CollectionToString(X6) + ","
        + "}";
    }
    }
}
