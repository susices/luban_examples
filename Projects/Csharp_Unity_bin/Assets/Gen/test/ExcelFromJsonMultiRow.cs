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

public sealed partial class ExcelFromJsonMultiRow :  Bright.Config.BeanBase 
{
    public ExcelFromJsonMultiRow(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Items = new System.Collections.Generic.List<test.TestRow>(n);for(var i = 0 ; i < n ; i++) { test.TestRow _e;  _e = test.TestRow.DeserializeTestRow(_buf); Items.Add(_e);}}
        PostInit();
    }

    public static ExcelFromJsonMultiRow DeserializeExcelFromJsonMultiRow(ByteBuf _buf)
    {
        return new test.ExcelFromJsonMultiRow(_buf);
    }

    public int Id { get; private set; }
    public int X { get; private set; }
    public System.Collections.Generic.List<test.TestRow> Items { get; private set; }

    public const int __ID__ = 715335694;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Items) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Items) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X:" + X + ","
        + "Items:" + Bright.Common.StringUtil.CollectionToString(Items) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
