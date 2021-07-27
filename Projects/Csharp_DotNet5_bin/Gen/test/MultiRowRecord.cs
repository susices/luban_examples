
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
public sealed partial class MultiRowRecord :  Bright.Config.BeanBase 
{
    public MultiRowRecord(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);OneRows = new System.Collections.Generic.List<test.MultiRowType1>(n);for(var i = 0 ; i < n ; i++) { test.MultiRowType1 _e;  _e = test.MultiRowType1.DeserializeMultiRowType1(_buf); OneRows.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows1 = new System.Collections.Generic.List<test.MultiRowType1>(n);for(var i = 0 ; i < n ; i++) { test.MultiRowType1 _e;  _e = test.MultiRowType1.DeserializeMultiRowType1(_buf); MultiRows1.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows2 = new test.MultiRowType1[n];for(var i = 0 ; i < n ; i++) { test.MultiRowType1 _e;_e = test.MultiRowType1.DeserializeMultiRowType1(_buf); MultiRows2[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows3 = new System.Collections.Generic.HashSet<test.MultiRowType2>(/*n * 3 / 2*/);for(var i = 0 ; i < n ; i++) { test.MultiRowType2 _e;  _e = test.MultiRowType2.DeserializeMultiRowType2(_buf); MultiRows3.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);MultiRows4 = new System.Collections.Generic.Dictionary<int, test.MultiRowType2>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { int _k;  _k = _buf.ReadInt(); test.MultiRowType2 _v;  _v = test.MultiRowType2.DeserializeMultiRowType2(_buf);     MultiRows4.Add(_k, _v);}}
    }

    public MultiRowRecord(int id, string name, System.Collections.Generic.List<test.MultiRowType1> one_rows, System.Collections.Generic.List<test.MultiRowType1> multi_rows1, test.MultiRowType1[] multi_rows2, System.Collections.Generic.HashSet<test.MultiRowType2> multi_rows3, System.Collections.Generic.Dictionary<int, test.MultiRowType2> multi_rows4 ) 
    {
        this.Id = id;
        this.Name = name;
        this.OneRows = one_rows;
        this.MultiRows1 = multi_rows1;
        this.MultiRows2 = multi_rows2;
        this.MultiRows3 = multi_rows3;
        this.MultiRows4 = multi_rows4;
    }

    public static MultiRowRecord DeserializeMultiRowRecord(ByteBuf _buf)
    {
        return new test.MultiRowRecord(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<test.MultiRowType1> OneRows;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<test.MultiRowType1> MultiRows1;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.MultiRowType1[] MultiRows2;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.HashSet<test.MultiRowType2> MultiRows3;
    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.Dictionary<int, test.MultiRowType2> MultiRows4;

    public const int ID = -501249394;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in OneRows) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows1) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows2) { _e?.Resolve(_tables); }
        foreach(var _e in MultiRows4.Values) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "OneRows:" + Bright.Common.StringUtil.CollectionToString(OneRows) + ","
        + "MultiRows1:" + Bright.Common.StringUtil.CollectionToString(MultiRows1) + ","
        + "MultiRows2:" + Bright.Common.StringUtil.CollectionToString(MultiRows2) + ","
        + "MultiRows3:" + Bright.Common.StringUtil.CollectionToString(MultiRows3) + ","
        + "MultiRows4:" + Bright.Common.StringUtil.CollectionToString(MultiRows4) + ","
        + "}";
    }
    }

}

