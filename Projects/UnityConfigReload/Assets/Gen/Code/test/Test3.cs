//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.test
{

public sealed partial class Test3 :  Bright.Config.BeanBase 
{
    public Test3(ByteBuf _buf) 
    {
        X = _buf.ReadInt();
        Y = _buf.ReadInt();
        PostInit();
    }

    public static Test3 DeserializeTest3(ByteBuf _buf)
    {
        return new test.Test3(_buf);
    }

    public int X { get; private set; }
    public int Y { get; private set; }

    public const int __ID__ = 638540133;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(Test3 reloadData)
    {
        X = reloadData.X;
        Y = reloadData.Y;
    }

    public override string ToString()
    {
        return "{ "
        + "X:" + X + ","
        + "Y:" + Y + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
