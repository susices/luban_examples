
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class DemoGroup :  Bright.Config.BeanBase 
{
    public DemoGroup(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1 = _buf.ReadInt();
        X2 = _buf.ReadInt();
        X3 = _buf.ReadInt();
        X4 = _buf.ReadInt();
        X5 = test.InnerGroup.DeserializeInnerGroup(_buf);
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

    public static DemoGroup DeserializeDemoGroup(ByteBuf _buf)
    {
        return new test.DemoGroup(_buf);
    }

    public readonly int Id;
    public readonly int X1;
    public readonly int X2;
    public readonly int X3;
    public readonly int X4;
    public readonly test.InnerGroup X5;

    public const int ID = -379263008;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X5?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

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

