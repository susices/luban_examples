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

public sealed partial class CompactString :  Bright.Config.BeanBase 
{
    public CompactString(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        S2 = _buf.ReadString();
        S3 = _buf.ReadString();
        PostInit();
    }

    public static CompactString DeserializeCompactString(ByteBuf _buf)
    {
        return new test.CompactString(_buf);
    }

    public int Id { get; private set; }
    public string S2 { get; private set; }
    public string S3 { get; private set; }

    public const int __ID__ = 1968089240;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(CompactString reloadData)
    {
        Id = reloadData.Id;
        S2 = reloadData.S2;
        S3 = reloadData.S3;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "S2:" + S2 + ","
        + "S3:" + S3 + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
