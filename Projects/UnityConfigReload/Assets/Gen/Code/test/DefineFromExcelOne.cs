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

public sealed partial class DefineFromExcelOne :  Bright.Config.BeanBase 
{
    public DefineFromExcelOne(ByteBuf _buf) 
    {
        UnlockEquip = _buf.ReadInt();
        UnlockHero = _buf.ReadInt();
        DefaultAvatar = _buf.ReadString();
        DefaultItem = _buf.ReadString();
        PostInit();
    }

    public static DefineFromExcelOne DeserializeDefineFromExcelOne(ByteBuf _buf)
    {
        return new test.DefineFromExcelOne(_buf);
    }

    /// <summary>
    /// 装备解锁等级
    /// </summary>
    public int UnlockEquip { get; private set; }
    /// <summary>
    /// 英雄解锁等级
    /// </summary>
    public int UnlockHero { get; private set; }
    public string DefaultAvatar { get; private set; }
    public string DefaultItem { get; private set; }

    public const int __ID__ = 528039504;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(DefineFromExcelOne reloadData)
    {
        typeof(DefineFromExcelOne).GetProperty("UnlockEquip").SetValue(this, reloadData.UnlockEquip);
        typeof(DefineFromExcelOne).GetProperty("UnlockHero").SetValue(this, reloadData.UnlockHero);
        typeof(DefineFromExcelOne).GetProperty("DefaultAvatar").SetValue(this, reloadData.DefaultAvatar);
        typeof(DefineFromExcelOne).GetProperty("DefaultItem").SetValue(this, reloadData.DefaultItem);
    }

    public override string ToString()
    {
        return "{ "
        + "UnlockEquip:" + UnlockEquip + ","
        + "UnlockHero:" + UnlockHero + ","
        + "DefaultAvatar:" + DefaultAvatar + ","
        + "DefaultItem:" + DefaultItem + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
