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

public sealed partial class TestBeRef :  Bright.Config.BeanBase 
{
    public TestBeRef(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Count = _buf.ReadInt();
        PostInit();
    }

    public static TestBeRef DeserializeTestBeRef(ByteBuf _buf)
    {
        return new test.TestBeRef(_buf);
    }

    public int Id { get; private set; }
    public int Count { get; private set; }

    public const int __ID__ = 1934403938;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(TestBeRef reloadData)
    {
        //Luban.Job.Common.Types.TInt
        Id = reloadData.Id;
        //Luban.Job.Common.Types.TInt
        Count = reloadData.Count;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Count:" + Count + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
