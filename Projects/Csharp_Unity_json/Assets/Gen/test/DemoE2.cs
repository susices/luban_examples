
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
public sealed partial class DemoE2 :  Bright.Config.BeanBase 
{
    public DemoE2(JSONNode _json) 
    {
        { var _j = _json["y1"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  Y1 = _j; } } else { Y1 = null; } }
        { if(!_json["y2"].IsBoolean) { throw new SerializationException(); }  Y2 = _json["y2"]; }
    }

    public DemoE2(int? y1, bool y2 ) 
    {
        this.Y1 = y1;
        this.Y2 = y2;
    }

    public static DemoE2 DeserializeDemoE2(JSONNode _json)
    {
        return new test.DemoE2(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int? Y1;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool Y2;

    public const int ID = -2138341716;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Y1:" + Y1 + ","
        + "Y2:" + Y2 + ","
        + "}";
    }
    }
}

