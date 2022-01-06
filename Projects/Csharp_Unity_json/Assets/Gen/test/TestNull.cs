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

public sealed class TestNull :  Bright.Config.BeanBase 
{
    public TestNull(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
        { var _j = _json["x1"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  X1 = _j; } } else { X1 = null; } }
        { var _j = _json["x2"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  X2 = (test.DemoEnum)_j.AsInt; } } else { X2 = null; } }
        { var _j = _json["x3"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsObject) { throw new SerializationException(); }  X3 = test.DemoType1.DeserializeDemoType1(_j); } } else { X3 = null; } }
        { var _j = _json["x4"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsObject) { throw new SerializationException(); }  X4 = test.DemoDynamic.DeserializeDemoDynamic(_j); } } else { X4 = null; } }
        { var _j = _json["s1"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsString) { throw new SerializationException(); }  S1 = _j; } } else { S1 = null; } }
        { var _j = _json["s2"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j["key"].IsString) { throw new SerializationException(); }  S2_l10n_key = _j["key"]; if(!_j["text"].IsString) { throw new SerializationException(); }  S2 = _j["text"]; } } else { S2 = null; } }
    }

    public TestNull(int id, int? x1, test.DemoEnum? x2, test.DemoType1 x3, test.DemoDynamic x4, string s1, string s2 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.S1 = s1;
        this.S2 = s2;
    }

    public static TestNull DeserializeTestNull(JSONNode _json)
    {
        return new test.TestNull(_json);
    }

    public int Id { get; private set; }
    public int? X1 { get; private set; }
    public test.DemoEnum? X2 { get; private set; }
    public test.DemoType1 X3 { get; private set; }
    public test.DemoDynamic X4 { get; private set; }
    public string S1 { get; private set; }
    public string S2 { get; private set; }
    public string S2_l10n_key { get; }

    public const int __ID__ = 339868469;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X3?.Resolve(_tables);
        X4?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X3?.TranslateText(translator);
        X4?.TranslateText(translator);
        S2 = translator(S2_l10n_key, S2);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "}";
    }
    }
}
