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

public sealed partial class NotIndexList :  Bright.Config.BeanBase 
{
    public NotIndexList(ByteBuf _buf) 
    {
        X = _buf.ReadInt();
        Y = _buf.ReadInt();
        PostInit();
    }

    public static NotIndexList DeserializeNotIndexList(ByteBuf _buf)
    {
        return new test.NotIndexList(_buf);
    }

    public int X { get; private set; }
    public int Y { get; private set; }

    public const int __ID__ = -50446599;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(NotIndexList reloadData)
    {
        typeof(NotIndexList).GetProperty("X").SetValue(this, reloadData.X);
        typeof(NotIndexList).GetProperty("Y").SetValue(this, reloadData.Y);
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
