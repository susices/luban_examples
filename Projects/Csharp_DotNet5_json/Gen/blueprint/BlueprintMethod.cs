
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



namespace cfg.blueprint
{

/// <summary>
/// 
/// </summary>
public sealed partial class BlueprintMethod :  blueprint.Method 
{
    public BlueprintMethod(JsonElement _buf)  : base(_buf) 
    {
    }

    public BlueprintMethod(string name, string desc, bool is_static, string return_type, System.Collections.Generic.List<blueprint.ParamInfo> parameters )  : base(name,desc,is_static,return_type,parameters) 
    {
    }

    public static BlueprintMethod DeserializeBlueprintMethod(JsonElement _buf)
    {
        return new blueprint.BlueprintMethod(_buf);
    }


    public const int ID = -696408103;
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
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "IsStatic:" + IsStatic + ","
        + "ReturnType:" + ReturnType + ","
        + "Parameters:" + Bright.Common.StringUtil.CollectionToString(Parameters) + ","
        + "}";
    }
    }
}

