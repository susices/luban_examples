
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



namespace cfg.role
{

/// <summary>
/// 
/// </summary>
public sealed partial class BonusInfo :  Bright.Config.BeanBase 
{
    public BonusInfo(JSONNode _json) 
    {
        { if(!_json["type"].IsNumber) { throw new SerializationException(); }  Type = (item.ECurrencyType)_json["type"].AsInt; }
        { if(!_json["coefficient"].IsNumber) { throw new SerializationException(); }  Coefficient = _json["coefficient"]; }
    }

    public BonusInfo(item.ECurrencyType type, float coefficient ) 
    {
        this.Type = type;
        this.Coefficient = coefficient;
    }

    public static BonusInfo DeserializeBonusInfo(JSONNode _json)
    {
        return new role.BonusInfo(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly item.ECurrencyType Type;
    /// <summary>
    /// 
    /// </summary>
    public readonly float Coefficient;

    public const int ID = -1354421803;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Type:" + Type + ","
        + "Coefficient:" + Coefficient + ","
        + "}";
    }
    }
}

