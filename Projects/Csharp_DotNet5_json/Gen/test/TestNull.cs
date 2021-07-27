
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{

/// <summary>
/// 
/// </summary>
public sealed partial class TestNull :  Bright.Config.BeanBase 
{
    public TestNull(JsonElement _buf) 
    {
        Id = _buf.GetProperty("id").GetInt32();
        { var _j = _buf.GetProperty("x1"); if (_j.ValueKind != JsonValueKind.Null) { X1 = _j.GetInt32(); } else { X1 = null; } }
        { var _j = _buf.GetProperty("x2"); if (_j.ValueKind != JsonValueKind.Null) { X2 = (test.DemoEnum)_j.GetInt32(); } else { X2 = null; } }
        { var _j = _buf.GetProperty("x3"); if (_j.ValueKind != JsonValueKind.Null) { X3 =  test.DemoType1.DeserializeDemoType1(_j); } else { X3 = null; } }
        { var _j = _buf.GetProperty("x4"); if (_j.ValueKind != JsonValueKind.Null) { X4 =  test.DemoDynamic.DeserializeDemoDynamic(_j); } else { X4 = null; } }
        { var _j = _buf.GetProperty("s1"); if (_j.ValueKind != JsonValueKind.Null) { S1 = _j.GetString(); } else { S1 = null; } }
        { var _j = _buf.GetProperty("s2"); if (_j.ValueKind != JsonValueKind.Null) { S2 = _j.GetString(); } else { S2 = null; } }
    }

    public TestNull(int id, int? x1, test.DemoEnum? x2, test.DemoType1 x3, test.DemoDynamic x4, string s1, string s2 ) 
    {
        this.Id = id;
        this.X1 = x1;
        this.X2 = x2;
        this.X3 = x3;
        this.X4 = x4;
        this.S1 = s1;
        this.S2 = s2;
    }

    public static TestNull DeserializeTestNull(JsonElement _buf)
    {
        return new test.TestNull(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 
    /// </summary>
    public readonly int? X1;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoEnum? X2;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoType1 X3;
    /// <summary>
    /// 
    /// </summary>
    public readonly test.DemoDynamic X4;
    /// <summary>
    /// 
    /// </summary>
    public readonly string S1;
    /// <summary>
    /// 
    /// </summary>
    public readonly string S2;

    public const int ID = 339868469;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X3?.Resolve(_tables);
        X4?.Resolve(_tables);
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
        + "X4:" + X4 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "}";
    }
    }
}

