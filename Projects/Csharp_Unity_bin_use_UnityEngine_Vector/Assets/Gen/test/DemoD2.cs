
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

public sealed partial class DemoD2 :  test.DemoDynamic 
{
    public DemoD2(ByteBuf _buf)  : base(_buf) 
    {
        X2 = _buf.ReadInt();
    }

    public static DemoD2 DeserializeDemoD2(ByteBuf _buf)
    {
        return new test.DemoD2(_buf);
    }

    public int X2 {get; private set;}

    public const int ID = -2138341747;
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
        + "X2:" + X2 + ","
        + "}";
    }
    }

}
