
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



namespace cfg.condition
{

/// <summary>
/// 
/// </summary>
public sealed partial class MinLevel :  condition.BoolRoleCondition 
{
    public MinLevel(JsonElement _buf)  : base(_buf) 
    {
        Level = _buf.GetProperty("level").GetInt32();
    }

    public MinLevel(int level )  : base() 
    {
        this.Level = level;
    }

    public static MinLevel DeserializeMinLevel(JsonElement _buf)
    {
        return new condition.MinLevel(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int Level;

    public const int ID = -1075273755;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Level:" + Level + ","
        + "}";
    }
    }
}

