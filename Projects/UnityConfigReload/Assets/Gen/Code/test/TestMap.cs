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

public sealed partial class TestMap :  Bright.Config.BeanBase 
{
    public TestMap(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X1 = new System.Collections.Generic.Dictionary<int, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { int _k;  _k = _buf.ReadInt(); int _v;  _v = _buf.ReadInt();     X1.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X2 = new System.Collections.Generic.Dictionary<long, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { long _k;  _k = _buf.ReadLong(); int _v;  _v = _buf.ReadInt();     X2.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X3 = new System.Collections.Generic.Dictionary<string, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { string _k;  _k = _buf.ReadString(); int _v;  _v = _buf.ReadInt();     X3.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);X4 = new System.Collections.Generic.Dictionary<test.DemoEnum, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { test.DemoEnum _k;  _k = (test.DemoEnum)_buf.ReadInt(); int _v;  _v = _buf.ReadInt();     X4.Add(_k, _v);}}
        PostInit();
    }

    public static TestMap DeserializeTestMap(ByteBuf _buf)
    {
        return new test.TestMap(_buf);
    }

    public int Id { get; private set; }
    //field.gen_ref
    public test.TestIndex Id_Ref { get; private set; }
    public System.Collections.Generic.Dictionary<int, int> X1 { get; private set; }
    public System.Collections.Generic.Dictionary<long, int> X2 { get; private set; }
    public System.Collections.Generic.Dictionary<string, int> X3 { get; private set; }
    public System.Collections.Generic.Dictionary<test.DemoEnum, int> X4 { get; private set; }

    public const int __ID__ = -543227410;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.Id_Ref = (_tables["test.TbTestIndex"] as test.TbTestIndex).GetOrDefault(Id);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(TestMap reloadData)
    {
        typeof(TestMap).GetProperty("Id").SetValue(this, reloadData.Id);
        typeof(TestMap).GetProperty("X1").SetValue(this, reloadData.X1);
        typeof(TestMap).GetProperty("X2").SetValue(this, reloadData.X2);
        typeof(TestMap).GetProperty("X3").SetValue(this, reloadData.X3);
        typeof(TestMap).GetProperty("X4").SetValue(this, reloadData.X4);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + Bright.Common.StringUtil.CollectionToString(X1) + ","
        + "X2:" + Bright.Common.StringUtil.CollectionToString(X2) + ","
        + "X3:" + Bright.Common.StringUtil.CollectionToString(X3) + ","
        + "X4:" + Bright.Common.StringUtil.CollectionToString(X4) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
