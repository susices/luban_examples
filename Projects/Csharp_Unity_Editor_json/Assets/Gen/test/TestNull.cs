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



namespace editor.cfg.test
{

public sealed partial class TestNull :  Bright.Config.EditorBeanBase 
{
    public TestNull()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  X1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { X2 = (test.DemoEnum?)System.Enum.Parse(typeof(test.DemoEnum?), _fieldJson); } else if(_fieldJson.IsNumber) { X2 = (test.DemoEnum?)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  X3 = test.DemoType1.LoadJsonDemoType1(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  X4 = test.DemoDynamic.LoadJsonDemoDynamic(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["s1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  S1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["s2"];
            if (_fieldJson != null)
            {
                S2 = Bright.Config.EditorText.LoadJson(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["id"] = new JSONNumber(Id);
        }

        if (X1 != null)
        {
            _json["x1"] = new JSONNumber(X1.Value);
        }

        if (X2 != null)
        {
            _json["x2"] = new JSONNumber((int)X2);
        }

        if (X3 != null)
        {
            { var __bjson = new JSONObject();  test.DemoType1.SaveJsonDemoType1(X3, __bjson); _json["x3"] = __bjson; }
        }

        if (X4 != null)
        {
            { var __bjson = new JSONObject();  test.DemoDynamic.SaveJsonDemoDynamic(X4, __bjson); _json["x4"] = __bjson; }
        }

        if (S1 != null)
        {
            _json["s1"] = new JSONString(S1);
        }

        if (S2 != null)
        {
            _json["s2"] = Bright.Config.EditorText.SaveJson(S2);
        }
    }

    public static TestNull LoadJsonTestNull(SimpleJSON.JSONNode _json)
    {
        TestNull obj = new test.TestNull();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestNull(TestNull _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public int? X1 { get; set; }

    public test.DemoEnum? X2 { get; set; }

    public test.DemoType1 X3 { get; set; }

    public test.DemoDynamic X4 { get; set; }

    public string S1 { get; set; }

    public Bright.Config.EditorText S2 { get; set; }

}
}
