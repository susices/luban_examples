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

public sealed partial class MultiRowType1 :  Bright.Config.BeanBase 
{
    public MultiRowType1(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X = _buf.ReadInt();
        PostInit();
    }

    public static MultiRowType1 DeserializeMultiRowType1(ByteBuf _buf)
    {
        return new test.MultiRowType1(_buf);
    }

    public int Id { get; private set; }
    public int X { get; private set; }

    public const int __ID__ = 540474970;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(MultiRowType1 reloadData)
    {
        //Luban.Job.Common.Types.TInt
        Id = reloadData.Id;
        //Luban.Job.Common.Types.TInt
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
