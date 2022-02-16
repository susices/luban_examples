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



namespace editor.cfg.ai
{

public sealed partial class MoveToLocation :  ai.Task 
{
    public MoveToLocation()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["location"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); } float __x; if(!_fieldJson["x"].IsNumber) { throw new SerializationException(); }  __x = _fieldJson["x"]; float __y; if(!_fieldJson["y"].IsNumber) { throw new SerializationException(); }  __y = _fieldJson["y"]; float __z; if(!_fieldJson["z"].IsNumber) { throw new SerializationException(); }  __z = _fieldJson["z"];  Location = new UnityEngine.Vector3(__x, __y,__z);
            }
        }
        
        { 
            var _fieldJson = _json["acceptable_radius"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  AcceptableRadius = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            { var __vjson = new JSONObject(); __vjson["x"] = Location.X;  __vjson["y"] = Location.Y; __vjson["z"] = Location.Z; _json["location"] = __vjson; }
        }
        {
            _json["acceptable_radius"] = new JSONNumber(AcceptableRadius);
        }
    }

    public static MoveToLocation LoadJsonMoveToLocation(SimpleJSON.JSONNode _json)
    {
        MoveToLocation obj = new ai.MoveToLocation();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonMoveToLocation(MoveToLocation _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public UnityEngine.Vector3 Location { get; set; }

    public float AcceptableRadius { get; set; }

}
}
