
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;


namespace cfg
{
   
public sealed class Tables
{
    public ai.TbBlackboard TbBlackboard {get; }
    public ai.TbBehaviorTree TbBehaviorTree {get; }
    public blueprint.TbClazz TbClazz {get; }
    public bonus.TbDrop TbDrop {get; }
    public common.TbGlobalConfig TbGlobalConfig {get; }
    public common.TbDummy TbDummy {get; }
    public error.TbErrorInfo TbErrorInfo {get; }
    public error.TbCodeInfo TbCodeInfo {get; }
    public item.TbItem TbItem {get; }
    public item.TbItemFunc TbItemFunc {get; }
    public item.TbItemExtra TbItemExtra {get; }
    public mail.TbSystemMail TbSystemMail {get; }
    public mail.TbGlobalMail TbGlobalMail {get; }
    public role.TbRoleLevelExpAttr TbRoleLevelExpAttr {get; }
    public role.TbRoleLevelBonusCoefficient TbRoleLevelBonusCoefficient {get; }

    public Tables(System.Func<string, ByteBuf> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbBlackboard = new ai.TbBlackboard(loader("ai.TbBlackboard.bin")); 
        tables.Add("ai.TbBlackboard", TbBlackboard);
        TbBehaviorTree = new ai.TbBehaviorTree(loader("ai.TbBehaviorTree.bin")); 
        tables.Add("ai.TbBehaviorTree", TbBehaviorTree);
        TbClazz = new blueprint.TbClazz(loader("blueprint.TbClazz.bin")); 
        tables.Add("blueprint.TbClazz", TbClazz);
        TbDrop = new bonus.TbDrop(loader("bonus.TbDrop.bin")); 
        tables.Add("bonus.TbDrop", TbDrop);
        TbGlobalConfig = new common.TbGlobalConfig(loader("common.TbGlobalConfig.bin")); 
        tables.Add("common.TbGlobalConfig", TbGlobalConfig);
        TbDummy = new common.TbDummy(loader("common.TbDummy.bin")); 
        tables.Add("common.TbDummy", TbDummy);
        TbErrorInfo = new error.TbErrorInfo(loader("error.TbErrorInfo.bin")); 
        tables.Add("error.TbErrorInfo", TbErrorInfo);
        TbCodeInfo = new error.TbCodeInfo(loader("error.TbCodeInfo.bin")); 
        tables.Add("error.TbCodeInfo", TbCodeInfo);
        TbItem = new item.TbItem(loader("item.TbItem.bin")); 
        tables.Add("item.TbItem", TbItem);
        TbItemFunc = new item.TbItemFunc(loader("item.TbItemFunc.bin")); 
        tables.Add("item.TbItemFunc", TbItemFunc);
        TbItemExtra = new item.TbItemExtra(loader("item.TbItemExtra.bin")); 
        tables.Add("item.TbItemExtra", TbItemExtra);
        TbSystemMail = new mail.TbSystemMail(loader("mail.TbSystemMail.bin")); 
        tables.Add("mail.TbSystemMail", TbSystemMail);
        TbGlobalMail = new mail.TbGlobalMail(loader("mail.TbGlobalMail.bin")); 
        tables.Add("mail.TbGlobalMail", TbGlobalMail);
        TbRoleLevelExpAttr = new role.TbRoleLevelExpAttr(loader("role.TbRoleLevelExpAttr.bin")); 
        tables.Add("role.TbRoleLevelExpAttr", TbRoleLevelExpAttr);
        TbRoleLevelBonusCoefficient = new role.TbRoleLevelBonusCoefficient(loader("role.TbRoleLevelBonusCoefficient.bin")); 
        tables.Add("role.TbRoleLevelBonusCoefficient", TbRoleLevelBonusCoefficient);
        TbBlackboard.Resolve(tables);
        TbBehaviorTree.Resolve(tables);
        TbClazz.Resolve(tables);
        TbDrop.Resolve(tables);
        TbGlobalConfig.Resolve(tables);
        TbDummy.Resolve(tables);
        TbErrorInfo.Resolve(tables);
        TbCodeInfo.Resolve(tables);
        TbItem.Resolve(tables);
        TbItemFunc.Resolve(tables);
        TbItemExtra.Resolve(tables);
        TbSystemMail.Resolve(tables);
        TbGlobalMail.Resolve(tables);
        TbRoleLevelExpAttr.Resolve(tables);
        TbRoleLevelBonusCoefficient.Resolve(tables);
    }
}

}

