
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

public sealed partial class DemoE1 :  test.DemoD3 
{
    public DemoE1(JSONNode _json)  : base(_json) 
    {
        { if(!_json["x4"].IsNumber) { throw new SerializationException(); }  X4 = _json["x4"]; }
    }

    public DemoE1(int x1, int x3, int x4 )  : base(x1,x3) 
    {
        this.X4 = x4;
    }

    public static DemoE1 DeserializeDemoE1(JSONNode _json)
    {
        return new test.DemoE1(_json);
    }

    public int X4 { get; private set; }

    public const int ID = -2138341717;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "}";
    }
    }
}
