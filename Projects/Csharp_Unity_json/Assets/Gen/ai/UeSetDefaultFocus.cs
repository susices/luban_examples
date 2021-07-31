
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.ai
{

/// <summary>
/// 
/// </summary>
public sealed partial class UeSetDefaultFocus :  ai.Service 
{
    public UeSetDefaultFocus(JSONNode _json)  : base(_json) 
    {
        { if(!_json["keyboard_key"].IsString) { throw new SerializationException(); }  KeyboardKey = _json["keyboard_key"]; }
    }

    public UeSetDefaultFocus(int id, string node_name, string keyboard_key )  : base(id,node_name) 
    {
        this.KeyboardKey = keyboard_key;
    }

    public static UeSetDefaultFocus DeserializeUeSetDefaultFocus(JSONNode _json)
    {
        return new ai.UeSetDefaultFocus(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly string KeyboardKey;

    public const int ID = 1812449155;
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
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "KeyboardKey:" + KeyboardKey + ","
        + "}";
    }
    }
}

