
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

public abstract partial class DemoD3 :  test.DemoDynamic 
{
    public DemoD3(JSONNode _json)  : base(_json) 
    {
        { if(!_json["x3"].IsNumber) { throw new SerializationException(); }  X3 = _json["x3"]; }
    }

    public DemoD3(int x1, int x3 )  : base(x1) 
    {
        this.X3 = x3;
    }

    public static DemoD3 DeserializeDemoD3(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "DemoE1": return new test.DemoE1(_json);
            default: throw new SerializationException();
        }
    }

    public readonly int X3;


    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X3:" + X3 + ","
        + "}";
    }
    }
}

