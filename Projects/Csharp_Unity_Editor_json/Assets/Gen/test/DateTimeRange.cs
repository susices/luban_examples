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

public sealed partial class DateTimeRange :  Bright.Config.EditorBeanBase 
{
    public DateTimeRange()
    {
            StartTime = "1970-01-01 00:00:00";
            EndTime = "1970-01-01 00:00:00";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["start_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  StartTime = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["end_time"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  EndTime = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "test.DateTimeRange";
        {
            _json["start_time"] = new JSONString(StartTime);
        }
        {
            _json["end_time"] = new JSONString(EndTime);
        }
    }

    public static DateTimeRange LoadJsonDateTimeRange(SimpleJSON.JSONNode _json)
    {
        DateTimeRange obj = new test.DateTimeRange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonDateTimeRange(DateTimeRange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

}
}
