
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

/// <summary>
/// 
/// </summary>
public sealed partial class DefineFromExcel :  Bright.Config.BeanBase 
{
    public DefineFromExcel(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        X1 = _buf.ReadBool();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X8 = _buf.ReadInt();
        X10 = _buf.ReadString();
        X13 = (test.ETestQuality)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        V2 = _buf.ReadVector2();
        T1 = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K1[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { int _k;  _k = _buf.ReadInt(); int _v;  _v = _buf.ReadInt();     K8.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n);for(var i = 0 ; i < n ; i++) { test.DemoE2 _e;  _e = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e);}}
    }

    public static DefineFromExcel DeserializeDefineFromExcel(ByteBuf _buf)
    {
        return new test.DefineFromExcel(_buf);
    }

    /// <summary>
    /// id的描述
    /// </summary>
    public int Id {get; private set;}
    /// <summary>
    /// 字段的描述
    /// </summary>
    public bool X1 {get; private set;}
    public long X5 {get; private set;}
    public float X6 {get; private set;}
    public int X8 {get; private set;}
    public test.DemoPrimitiveTypesTable X8_Ref;
    public string X10 {get; private set;}
    public test.ETestQuality X13 {get; private set;}
    public test.DemoDynamic X14 {get; private set;}
    public System.Numerics.Vector2 V2 {get; private set;}
    public int T1 {get; private set;}
    public int[] K1 {get; private set;}
    public System.Collections.Generic.Dictionary<int, int> K8 {get; private set;}
    public System.Collections.Generic.List<test.DemoE2> K9 {get; private set;}

    public const int ID = 2100429878;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.X8_Ref = (_tables["test.TbDemoPrimitive"] as test.TbDemoPrimitive).GetOrDefault(X8);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        X14?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X8:" + X8 + ","
        + "X10:" + X10 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "V2:" + V2 + ","
        + "T1:" + T1 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "}";
    }
    }

}
