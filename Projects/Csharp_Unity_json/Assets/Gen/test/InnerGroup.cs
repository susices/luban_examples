
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

public sealed partial class InnerGroup :  Bright.Config.BeanBase 
{
    public InnerGroup(JSONNode _json) 
    {
        { if(!_json["y1"].IsNumber) { throw new SerializationException(); }  Y1 = _json["y1"]; }
        { if(!_json["y2"].IsNumber) { throw new SerializationException(); }  Y2 = _json["y2"]; }
        { if(!_json["y3"].IsNumber) { throw new SerializationException(); }  Y3 = _json["y3"]; }
        { if(!_json["y4"].IsNumber) { throw new SerializationException(); }  Y4 = _json["y4"]; }
    }

    public InnerGroup(int y1, int y2, int y3, int y4 ) 
    {
        this.Y1 = y1;
        this.Y2 = y2;
        this.Y3 = y3;
        this.Y4 = y4;
    }

    public static InnerGroup DeserializeInnerGroup(JSONNode _json)
    {
        return new test.InnerGroup(_json);
    }

    public readonly int Y1;
    public readonly int Y2;
    public readonly int Y3;
    public readonly int Y4;

    public const int ID = -587873083;
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
        + "Y3:" + Y3 + ","
        + "Y4:" + Y4 + ","
        + "}";
    }
    }
}

