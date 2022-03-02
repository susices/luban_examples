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

public sealed partial class TestString :  Bright.Config.EditorBeanBase 
{
    public TestString()
    {
            S1 = "";
            Cs1 = new test.CompactString();
            Cs2 = new test.CompactString();
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
            var _fieldJson = _json["s1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  S1 = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["cs1"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  Cs1 = test.CompactString.LoadJsonCompactString(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["cs2"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  Cs2 = test.CompactString.LoadJsonCompactString(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "test.TestString";
        {
            _json["id"] = new JSONNumber(Id);
        }
        {

            if (S1 == null) { throw new System.ArgumentNullException(); }
            _json["s1"] = new JSONString(S1);
        }
        {

            if (Cs1 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.CompactString.SaveJsonCompactString(Cs1, __bjson); _json["cs1"] = __bjson; }
        }
        {

            if (Cs2 == null) { throw new System.ArgumentNullException(); }
            { var __bjson = new JSONObject();  test.CompactString.SaveJsonCompactString(Cs2, __bjson); _json["cs2"] = __bjson; }
        }
    }

    public static TestString LoadJsonTestString(SimpleJSON.JSONNode _json)
    {
        TestString obj = new test.TestString();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonTestString(TestString _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int Id { get; set; }

    public string S1 { get; set; }

    public test.CompactString Cs1 { get; set; }

    public test.CompactString Cs2 { get; set; }

}
}
