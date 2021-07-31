
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



namespace cfg.item
{

/// <summary>
/// 
/// </summary>
public sealed partial class ChooseOneBonus :  Bright.Config.BeanBase 
{
    public ChooseOneBonus(JSONNode _json) 
    {
        { if(!_json["drop_id"].IsNumber) { throw new SerializationException(); }  DropId = _json["drop_id"]; }
        { if(!_json["is_unique"].IsBoolean) { throw new SerializationException(); }  IsUnique = _json["is_unique"]; }
    }

    public ChooseOneBonus(int drop_id, bool is_unique ) 
    {
        this.DropId = drop_id;
        this.IsUnique = is_unique;
    }

    public static ChooseOneBonus DeserializeChooseOneBonus(JSONNode _json)
    {
        return new item.ChooseOneBonus(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int DropId;
    public bonus.DropInfo DropId_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool IsUnique;

    public const int ID = 228058347;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.DropId_Ref = (_tables["bonus.TbDrop"] as bonus.TbDrop).GetOrDefault(DropId);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "DropId:" + DropId + ","
        + "IsUnique:" + IsUnique + ","
        + "}";
    }
    }
}

