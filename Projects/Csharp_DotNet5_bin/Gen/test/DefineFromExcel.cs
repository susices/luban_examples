
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
        X2 = _buf.ReadByte();
        X3 = _buf.ReadShort();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X7 = _buf.ReadDouble();
        X8 = _buf.ReadInt();
        X10 = _buf.ReadString();
        X13 = (test.DemoEnum)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        S1 = _buf.ReadString();
        V2 = _buf.ReadVector2();
        V3 = _buf.ReadVector3();
        V4 = _buf.ReadVector4();
        T1 = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K1[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K2 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K2[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K3 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K3[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K4 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K4[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K5 = new System.Collections.Generic.HashSet<int>(/*n * 3 / 2*/);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); K5.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K6 = new System.Collections.Generic.HashSet<int>(/*n * 3 / 2*/);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); K6.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K7 = new System.Collections.Generic.HashSet<int>(/*n * 3 / 2*/);for(var i = 0 ; i < n ; i++) { int _e;  _e = _buf.ReadInt(); K7.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { int _k;  _k = _buf.ReadInt(); int _v;  _v = _buf.ReadInt();     K8.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n);for(var i = 0 ; i < n ; i++) { test.DemoE2 _e;  _e = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e);}}
    }

    public DefineFromExcel(int id, bool x1, byte x2, short x3, long x5, float x6, double x7, int x8, string x10, test.DemoEnum x13, test.DemoDynamic x14, string s1, System.Numerics.Vector2 v2, System.Numerics.Vector3 v3, System.Numerics.Vector4 v4, int t1, int[] k1, int[] k2, int[] k3, int[] k4, System.Collections.Generic.HashSet<int> k5, System.Collections.Generic.HashSet<int> k6, System.Collections.Generic.HashSet<int> k7, System.Collections.Generic.Dictionary<int, int> k8, System.Collections.Generic.List<test.DemoE2> k9 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X5 = x5;
        this.X6 = x6;
        this.X7 = x7;
        this.X8 = x8;
        this.X10 = x10;
        this.X13 = x13;
        this.X14 = x14;
        this.S1 = s1;
        this.V2 = v2;
        this.V3 = v3;
        this.V4 = v4;
        this.T1 = t1;
        this.K1 = k1;
        this.K2 = k2;
        this.K3 = k3;
        this.K4 = k4;
        this.K5 = k5;
        this.K6 = k6;
        this.K7 = k7;
        this.K8 = k8;
        this.K9 = k9;
    }

    public static DefineFromExcel DeserializeDefineFromExcel(ByteBuf _buf)
    {
        return new test.DefineFromExcel(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 无所谓
    /// </summary>
    public readonly bool X1;
    /// <summary>
    /// 这样子
    /// </summary>
    public readonly byte X2;
    /// <summary>
    /// 
    /// </summary>
    public readonly short X3;
    /// <summary>
    /// 
    /// </summary>
    public readonly long X5;
    /// <summary>
    /// 
    /// </summary>
    public readonly float X6;
    /// <summary>
    /// 
    /// </summary>
    public readonly double X7;
    /// <summary>
    /// 
    /// </summary>
    public readonly int X8;
    public test.DemoPrimitiveTypesTable X8_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly string X10;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoEnum X13;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoDynamic X14;
    /// <summary>
    /// 
    /// </summary>
    public readonly string S1;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector2 V2;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector3 V3;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Numerics.Vector4 V4;
    /// <summary>
    /// 
    /// </summary>
    public readonly int T1;
    /// <summary>
    /// 
    /// </summary>
    public readonly int[] K1;
    /// <summary>
    /// 
    /// </summary>
    public readonly int[] K2;
    /// <summary>
    /// 
    /// </summary>
    public readonly int[] K3;
    /// <summary>
    /// 
    /// </summary>
    public readonly int[] K4;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<int> K5;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<int> K6;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<int> K7;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.Dictionary<int, int> K8;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<test.DemoE2> K9;

    public const int ID = 2100429878;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.X8_Ref = (_tables["test.TbDemoPrimitive"] as test.TbDemoPrimitive).GetOrDefault(X8);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X7:" + X7 + ","
        + "X8:" + X8 + ","
        + "X10:" + X10 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "S1:" + S1 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K2:" + Bright.Common.StringUtil.CollectionToString(K2) + ","
        + "K3:" + Bright.Common.StringUtil.CollectionToString(K3) + ","
        + "K4:" + Bright.Common.StringUtil.CollectionToString(K4) + ","
        + "K5:" + Bright.Common.StringUtil.CollectionToString(K5) + ","
        + "K6:" + Bright.Common.StringUtil.CollectionToString(K6) + ","
        + "K7:" + Bright.Common.StringUtil.CollectionToString(K7) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "}";
    }
    }

}

