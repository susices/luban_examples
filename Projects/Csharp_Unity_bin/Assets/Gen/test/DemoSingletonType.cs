
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

public sealed partial class DemoSingletonType :  Bright.Config.BeanBase 
{
    public DemoSingletonType(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        Date = test.DemoDynamic.DeserializeDemoDynamic(_buf);
    }

    public DemoSingletonType(int id, string name, test.DemoDynamic date ) 
    {
        this.Id = id;
        this.Name = name;
        this.Date = date;
    }

    public static DemoSingletonType DeserializeDemoSingletonType(ByteBuf _buf)
    {
        return new test.DemoSingletonType(_buf);
    }

    public readonly int Id;
    public readonly string Name;
    public readonly test.DemoDynamic Date;

    public const int ID = 539196998;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Date?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Date:" + Date + ","
        + "}";
    }
    }

}

