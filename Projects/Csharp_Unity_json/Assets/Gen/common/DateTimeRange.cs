
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



namespace cfg.common
{

public sealed partial class DateTimeRange :  Bright.Config.BeanBase 
{
    public DateTimeRange(JSONNode _json) 
    {
        { var _j = _json["start_time"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  StartTime = _j; } } else { StartTime = null; } }
        { var _j = _json["end_time"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  EndTime = _j; } } else { EndTime = null; } }
    }

    public DateTimeRange(int? start_time, int? end_time ) 
    {
        this.StartTime = start_time;
        this.EndTime = end_time;
    }

    public static DateTimeRange DeserializeDateTimeRange(JSONNode _json)
    {
        return new common.DateTimeRange(_json);
    }

    public int? StartTime { get; private set; }
    public int? EndTime { get; private set; }

    public const int ID = 1642200959;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "StartTime:" + StartTime + ","
        + "EndTime:" + EndTime + ","
        + "}";
    }
    }
}
