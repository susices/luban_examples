
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

public sealed class CompositeJsonTable2 :  Bright.Config.BeanBase 
{
    public CompositeJsonTable2(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Y = _buf.ReadInt();
    }

    public static CompositeJsonTable2 DeserializeCompositeJsonTable2(ByteBuf _buf)
    {
        return new test.CompositeJsonTable2(_buf);
    }

    public int Id { get; private set; }
    public int Y { get; private set; }

    public const int __ID__ = 1566207895;
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
        + "Id:" + Id + ","
        + "Y:" + Y + ","
        + "}";
    }
    }

}
