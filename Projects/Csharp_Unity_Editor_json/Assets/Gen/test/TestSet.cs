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

public sealed partial class TestSet :  Bright.Config.EditorBeanBase 
{
    public TestSet()
    {
            X0 = "";
            X1 = new System.Collections.Generic.List<int>();
            X2 = new System.Collections.Generic.List<long>();
            X3 = new System.Collections.Generic.List<string>();
            X4 = new System.Collections.Generic.List<test.DemoEnum>();
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
            var _fieldJson = _json["x0"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  X0 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X1 = new System.Collections.Generic.List<int>(); foreach(JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  X1.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X2 = new System.Collections.Generic.List<long>(); foreach(JSONNode __e in _fieldJson.Children) { long __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  X2.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x3"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X3 = new System.Collections.Generic.List<string>(); foreach(JSONNode __e in _fieldJson.Children) { string __v;  if(!__e.IsString) { throw new SerializationException(); }  __v = __e;  X3.Add(__v); }  
            }
        }
        
        { 
            var _fieldJson = _json["x4"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } X4 = new System.Collections.Generic.List<test.DemoEnum>(); foreach(JSONNode __e in _fieldJson.Children) { test.DemoEnum __v;  if(__e.IsString) { __v = (test.DemoEnum)System.Enum.Parse(typeof(test.DemoEnum), __e); } else if(__e.IsNumber) { __v = (test.DemoEnum)(int)__e; } else { throw new SerializationException(); }    X4.Add(__v); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (X0 == null) { throw new System.ArgumentNullException(); }
            _json["x0"] = new JSONString(X0);
        }
        {

            if (X1 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X1) { __cjson["null"] = new JSONNumber(_e); } _json["x1"] = __cjson; }
        }
        {

            if (X2 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X2) { __cjson["null"] = new JSONNumber(_e); } _json["x2"] = __cjson; }
        }
        {

            if (X3 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X3) { __cjson["null"] = new JSONString(_e); } _json["x3"] = __cjson; }
        }
        {

            if (X4 == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in X4) { __cjson["null"] = new JSONNumber((int)_e); } _json["x4"] = __cjson; }
        }
    }

    public static TestSet LoadJsonTestSet(SimpleJSON.JSONNode _json)
    {
        TestSet obj = new test.TestSet();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestSet(TestSet _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public string X0 { get; set; }

    public System.Collections.Generic.List<int> X1 { get; set; }

    public System.Collections.Generic.List<long> X2 { get; set; }

    public System.Collections.Generic.List<string> X3 { get; set; }

    public System.Collections.Generic.List<test.DemoEnum> X4 { get; set; }

}
}
