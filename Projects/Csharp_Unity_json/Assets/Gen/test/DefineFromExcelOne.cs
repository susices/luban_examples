
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



namespace cfg.test
{

/// <summary>
/// 
/// </summary>
public sealed partial class DefineFromExcelOne :  Bright.Config.BeanBase 
{
    public DefineFromExcelOne(JSONNode _json) 
    {
        { if(!_json["unlock_equip"].IsNumber) { throw new SerializationException(); }  UnlockEquip = _json["unlock_equip"]; }
        { if(!_json["unlock_hero"].IsNumber) { throw new SerializationException(); }  UnlockHero = _json["unlock_hero"]; }
        { if(!_json["default_avatar"].IsString) { throw new SerializationException(); }  DefaultAvatar = _json["default_avatar"]; }
        { if(!_json["default_item"].IsString) { throw new SerializationException(); }  DefaultItem = _json["default_item"]; }
    }

    public DefineFromExcelOne(int unlock_equip, int unlock_hero, string default_avatar, string default_item ) 
    {
        this.UnlockEquip = unlock_equip;
        this.UnlockHero = unlock_hero;
        this.DefaultAvatar = default_avatar;
        this.DefaultItem = default_item;
    }

    public static DefineFromExcelOne DeserializeDefineFromExcelOne(JSONNode _json)
    {
        return new test.DefineFromExcelOne(_json);
    }

    /// <summary>
    /// 装备解锁等级_描述
    /// </summary>
    public readonly int UnlockEquip;
    /// <summary>
    /// 英雄解锁等级
    /// </summary>
    public readonly int UnlockHero;
    /// <summary>
    /// 默认头像
    /// </summary>
    public readonly string DefaultAvatar;
    /// <summary>
    /// 
    /// </summary>
    public readonly string DefaultItem;

    public const int ID = 528039504;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "UnlockEquip:" + UnlockEquip + ","
        + "UnlockHero:" + UnlockHero + ","
        + "DefaultAvatar:" + DefaultAvatar + ","
        + "DefaultItem:" + DefaultItem + ","
        + "}";
    }
    }
}

