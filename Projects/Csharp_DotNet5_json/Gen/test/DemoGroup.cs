
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{

public sealed class DemoGroup :  Bright.Config.BeanBase 
{
    public DemoGroup(JsonElement _json) 
    {
        Id = _json.GetProperty("id").GetInt32();
        X1 = _json.GetProperty("x1").GetInt32();
        X2 = _json.GetProperty("x2").GetInt32();
        X3 = _json.GetProperty("x3").GetInt32();
        X4 = _json.GetProperty("x4").GetInt32();
        X5 =  test.InnerGroup.DeserializeInnerGroup(_json.GetProperty("x5"));
    }

    public DemoGroup(int id, int x1, int x2, int x3, int x4, test.InnerGroup x5 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.X5 = x5;
    }

    public static DemoGroup DeserializeDemoGroup(JsonElement _json)
    {
        return new test.DemoGroup(_json);
    }

    public int Id {get; private set; }
    public int X1 {get; private set; }
    public int X2 {get; private set; }
    public int X3 {get; private set; }
    public int X4 {get; private set; }
    public test.InnerGroup X5 {get; private set; }

    public const int ID = -379263008;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X5?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X5?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "X5:" + X5 + ","
        + "}";
    }
    }
}
