
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

public sealed class DemoE2 :  Bright.Config.BeanBase 
{
    public DemoE2(ByteBuf _buf) 
    {
        if(_buf.ReadBool()){ Y1 = _buf.ReadInt(); } else { Y1 = null; }
        Y2 = _buf.ReadBool();
    }

    public static DemoE2 DeserializeDemoE2(ByteBuf _buf)
    {
        return new test.DemoE2(_buf);
    }

    public int? Y1 { get; private set; }
    public bool Y2 { get; private set; }

    public const int __ID__ = -2138341716;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Y1:" + Y1 + ","
        + "Y2:" + Y2 + ","
        + "}";
    }
    }

}
