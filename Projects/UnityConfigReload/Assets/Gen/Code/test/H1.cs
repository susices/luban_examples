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

public sealed partial class H1 :  Bright.Config.BeanBase 
{
    public H1(ByteBuf _buf) 
    {
        Y2 = test.H2.DeserializeH2(_buf);
        Y3 = _buf.ReadInt();
        PostInit();
    }

    public static H1 DeserializeH1(ByteBuf _buf)
    {
        return new test.H1(_buf);
    }

    public test.H2 Y2 { get; private set; }
    public int Y3 { get; private set; }

    public const int __ID__ = -1422503995;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Y2?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Y2?.TranslateText(translator);
    }

    public void Reload(H1 reloadData)
    {
        //Luban.Job.Common.Types.TBean
        Y2 = reloadData.Y2;
        //Luban.Job.Common.Types.TInt
        Y3 = reloadData.Y3;
    }

    public override string ToString()
    {
        return "{ "
        + "Y2:" + Y2 + ","
        + "Y3:" + Y3 + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
