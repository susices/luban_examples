
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

public sealed partial class MultiRowType3 :  Bright.Config.BeanBase 
{
    public MultiRowType3(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Items = new System.Collections.Generic.List<test.MultiRowType1>(n);for(var i = 0 ; i < n ; i++) { test.MultiRowType1 _e;  _e = test.MultiRowType1.DeserializeMultiRowType1(_buf); Items.Add(_e);}}
    }

    public static MultiRowType3 DeserializeMultiRowType3(ByteBuf _buf)
    {
        return new test.MultiRowType3(_buf);
    }

    public int Id {get; private set;}
    public System.Collections.Generic.List<test.MultiRowType1> Items {get; private set;}

    public const int ID = 540474972;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in Items) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in Items) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Items:" + Bright.Common.StringUtil.CollectionToString(Items) + ","
        + "}";
    }
    }

}
