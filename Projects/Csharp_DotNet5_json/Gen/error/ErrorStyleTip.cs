
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



namespace cfg.error
{

/// <summary>
/// 
/// </summary>
public sealed partial class ErrorStyleTip :  error.ErrorStyle 
{
    public ErrorStyleTip(JsonElement _buf)  : base(_buf) 
    {
    }

    public ErrorStyleTip()  : base() 
    {
    }

    public static ErrorStyleTip DeserializeErrorStyleTip(JsonElement _buf)
    {
        return new error.ErrorStyleTip(_buf);
    }


    public const int ID = 1915239884;
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
        + "}";
    }
    }
}

