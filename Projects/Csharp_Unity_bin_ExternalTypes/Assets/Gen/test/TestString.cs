
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

public sealed class TestString :  Bright.Config.BeanBase 
{
    public TestString(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        S1 = _buf.ReadString();
        Cs1 = test.CompactString.DeserializeCompactString(_buf);
        Cs2 = test.CompactString.DeserializeCompactString(_buf);
    }

    public static TestString DeserializeTestString(ByteBuf _buf)
    {
        return new test.TestString(_buf);
    }

    public int Id { get; private set; }
    public string S1 { get; private set; }
    public test.CompactString Cs1 { get; private set; }
    public test.CompactString Cs2 { get; private set; }

    public const int __ID__ = 338485823;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Cs1?.Resolve(_tables);
        Cs2?.Resolve(_tables);
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Cs1?.TranslateText(translator);
        Cs2?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "S1:" + S1 + ","
        + "Cs1:" + Cs1 + ","
        + "Cs2:" + Cs2 + ","
        + "}";
    }
    }

}
