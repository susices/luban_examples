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

public sealed partial class CompositeJsonTable1 :  Bright.Config.BeanBase 
{
    public CompositeJsonTable1(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X = _buf.ReadString();
        PostInit();
    }

    public static CompositeJsonTable1 DeserializeCompositeJsonTable1(ByteBuf _buf)
    {
        return new test.CompositeJsonTable1(_buf);
    }

    public int Id { get; private set; }
    public string X { get; private set; }

    public const int __ID__ = 1566207894;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(CompositeJsonTable1 reloadData)
    {
        Id = reloadData.Id;
        X = reloadData.X;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X:" + X + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
