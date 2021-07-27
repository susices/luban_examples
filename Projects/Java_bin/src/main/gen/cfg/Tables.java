
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;

import bright.serialization.*;

public final class Tables
{
    public  static interface  IByteBufLoader {
        ByteBuf load(String file) throws java.io.IOException;
    }

    /**
     * 
     */
    public final cfg.ai.TbBlackboard TbBlackboard;
    /**
     * 
     */
    public final cfg.ai.TbBehaviorTree TbBehaviorTree;
    /**
     * 
     */
    public final cfg.blueprint.TbClazz TbClazz;
    /**
     * 
     */
    public final cfg.bonus.TbDrop TbDrop;
    /**
     * 
     */
    public final cfg.common.TbGlobalConfig TbGlobalConfig;
    /**
     * 
     */
    public final cfg.common.TbDummy TbDummy;
    /**
     * 
     */
    public final cfg.error.TbErrorInfo TbErrorInfo;
    /**
     * 
     */
    public final cfg.error.TbCodeInfo TbCodeInfo;
    /**
     * 道具表
     */
    public final cfg.item.TbItem TbItem;
    /**
     * 
     */
    public final cfg.item.TbItemFunc TbItemFunc;
    /**
     * 
     */
    public final cfg.item.TbItemExtra TbItemExtra;
    /**
     * 
     */
    public final cfg.l10n.TbL10NDemo TbL10NDemo;
    /**
     * 
     */
    public final cfg.l10n.TbPatchDemo TbPatchDemo;
    /**
     * 
     */
    public final cfg.mail.TbSystemMail TbSystemMail;
    /**
     * 
     */
    public final cfg.mail.TbGlobalMail TbGlobalMail;
    /**
     * 
     */
    public final cfg.role.TbRoleLevelExpAttr TbRoleLevelExpAttr;
    /**
     * 
     */
    public final cfg.role.TbRoleLevelBonusCoefficient TbRoleLevelBonusCoefficient;
    /**
     * 
     */
    public final cfg.tag.TbTestTag TbTestTag;
    /**
     * 
     */
    public final cfg.test.TbFullTypes TbFullTypes;
    /**
     * 
     */
    public final cfg.test.TbSingleton TbSingleton;
    /**
     * 
     */
    public final cfg.test.TbDataFromJson TbDataFromJson;
    /**
     * 
     */
    public final cfg.test.TbDataFromXml TbDataFromXml;
    /**
     * 
     */
    public final cfg.test.TbDataFromLua TbDataFromLua;
    /**
     * 
     */
    public final cfg.test.TbMultiRowRecord TbMultiRowRecord;
    /**
     * 
     */
    public final cfg.test.TbMultiRowTitle TbMultiRowTitle;
    /**
     * 
     */
    public final cfg.test.TbTestNull TbTestNull;
    /**
     * 
     */
    public final cfg.test.TbDemoPrimitive TbDemoPrimitive;
    /**
     * 
     */
    public final cfg.test.TbTestString TbTestString;
    /**
     * 
     */
    public final cfg.test.TbDemoGroup TbDemoGroup;
    /**
     * 
     */
    public final cfg.test.TbDemoGroup_C TbDemoGroup_C;
    /**
     * 
     */
    public final cfg.test.TbDemoGroup_S TbDemoGroup_S;
    /**
     * 
     */
    public final cfg.test.TbDemoGroup_E TbDemoGroup_E;
    /**
     * 
     */
    public final cfg.test.TbTestGlobal TbTestGlobal;

    public Tables(IByteBufLoader loader) throws java.io.IOException {
        var tables = new java.util.HashMap<String, Object>();
        TbBlackboard = new cfg.ai.TbBlackboard(loader.load("ai.TbBlackboard")); 
        tables.put("ai.TbBlackboard", TbBlackboard);
        TbBehaviorTree = new cfg.ai.TbBehaviorTree(loader.load("ai.TbBehaviorTree")); 
        tables.put("ai.TbBehaviorTree", TbBehaviorTree);
        TbClazz = new cfg.blueprint.TbClazz(loader.load("blueprint.TbClazz")); 
        tables.put("blueprint.TbClazz", TbClazz);
        TbDrop = new cfg.bonus.TbDrop(loader.load("bonus.TbDrop")); 
        tables.put("bonus.TbDrop", TbDrop);
        TbGlobalConfig = new cfg.common.TbGlobalConfig(loader.load("common.TbGlobalConfig")); 
        tables.put("common.TbGlobalConfig", TbGlobalConfig);
        TbDummy = new cfg.common.TbDummy(loader.load("common.TbDummy")); 
        tables.put("common.TbDummy", TbDummy);
        TbErrorInfo = new cfg.error.TbErrorInfo(loader.load("error.TbErrorInfo")); 
        tables.put("error.TbErrorInfo", TbErrorInfo);
        TbCodeInfo = new cfg.error.TbCodeInfo(loader.load("error.TbCodeInfo")); 
        tables.put("error.TbCodeInfo", TbCodeInfo);
        TbItem = new cfg.item.TbItem(loader.load("item.TbItem")); 
        tables.put("item.TbItem", TbItem);
        TbItemFunc = new cfg.item.TbItemFunc(loader.load("item.TbItemFunc")); 
        tables.put("item.TbItemFunc", TbItemFunc);
        TbItemExtra = new cfg.item.TbItemExtra(loader.load("item.TbItemExtra")); 
        tables.put("item.TbItemExtra", TbItemExtra);
        TbL10NDemo = new cfg.l10n.TbL10NDemo(loader.load("l10n.TbL10NDemo")); 
        tables.put("l10n.TbL10NDemo", TbL10NDemo);
        TbPatchDemo = new cfg.l10n.TbPatchDemo(loader.load("l10n.TbPatchDemo")); 
        tables.put("l10n.TbPatchDemo", TbPatchDemo);
        TbSystemMail = new cfg.mail.TbSystemMail(loader.load("mail.TbSystemMail")); 
        tables.put("mail.TbSystemMail", TbSystemMail);
        TbGlobalMail = new cfg.mail.TbGlobalMail(loader.load("mail.TbGlobalMail")); 
        tables.put("mail.TbGlobalMail", TbGlobalMail);
        TbRoleLevelExpAttr = new cfg.role.TbRoleLevelExpAttr(loader.load("role.TbRoleLevelExpAttr")); 
        tables.put("role.TbRoleLevelExpAttr", TbRoleLevelExpAttr);
        TbRoleLevelBonusCoefficient = new cfg.role.TbRoleLevelBonusCoefficient(loader.load("role.TbRoleLevelBonusCoefficient")); 
        tables.put("role.TbRoleLevelBonusCoefficient", TbRoleLevelBonusCoefficient);
        TbTestTag = new cfg.tag.TbTestTag(loader.load("tag.TbTestTag")); 
        tables.put("tag.TbTestTag", TbTestTag);
        TbFullTypes = new cfg.test.TbFullTypes(loader.load("test.TbFullTypes")); 
        tables.put("test.TbFullTypes", TbFullTypes);
        TbSingleton = new cfg.test.TbSingleton(loader.load("test.TbSingleton")); 
        tables.put("test.TbSingleton", TbSingleton);
        TbDataFromJson = new cfg.test.TbDataFromJson(loader.load("test.TbDataFromJson")); 
        tables.put("test.TbDataFromJson", TbDataFromJson);
        TbDataFromXml = new cfg.test.TbDataFromXml(loader.load("test.TbDataFromXml")); 
        tables.put("test.TbDataFromXml", TbDataFromXml);
        TbDataFromLua = new cfg.test.TbDataFromLua(loader.load("test.TbDataFromLua")); 
        tables.put("test.TbDataFromLua", TbDataFromLua);
        TbMultiRowRecord = new cfg.test.TbMultiRowRecord(loader.load("test.TbMultiRowRecord")); 
        tables.put("test.TbMultiRowRecord", TbMultiRowRecord);
        TbMultiRowTitle = new cfg.test.TbMultiRowTitle(loader.load("test.TbMultiRowTitle")); 
        tables.put("test.TbMultiRowTitle", TbMultiRowTitle);
        TbTestNull = new cfg.test.TbTestNull(loader.load("test.TbTestNull")); 
        tables.put("test.TbTestNull", TbTestNull);
        TbDemoPrimitive = new cfg.test.TbDemoPrimitive(loader.load("test.TbDemoPrimitive")); 
        tables.put("test.TbDemoPrimitive", TbDemoPrimitive);
        TbTestString = new cfg.test.TbTestString(loader.load("test.TbTestString")); 
        tables.put("test.TbTestString", TbTestString);
        TbDemoGroup = new cfg.test.TbDemoGroup(loader.load("test.TbDemoGroup")); 
        tables.put("test.TbDemoGroup", TbDemoGroup);
        TbDemoGroup_C = new cfg.test.TbDemoGroup_C(loader.load("test.TbDemoGroup_C")); 
        tables.put("test.TbDemoGroup_C", TbDemoGroup_C);
        TbDemoGroup_S = new cfg.test.TbDemoGroup_S(loader.load("test.TbDemoGroup_S")); 
        tables.put("test.TbDemoGroup_S", TbDemoGroup_S);
        TbDemoGroup_E = new cfg.test.TbDemoGroup_E(loader.load("test.TbDemoGroup_E")); 
        tables.put("test.TbDemoGroup_E", TbDemoGroup_E);
        TbTestGlobal = new cfg.test.TbTestGlobal(loader.load("test.TbTestGlobal")); 
        tables.put("test.TbTestGlobal", TbTestGlobal);

        TbBlackboard.resolve(tables); 
        TbBehaviorTree.resolve(tables); 
        TbClazz.resolve(tables); 
        TbDrop.resolve(tables); 
        TbGlobalConfig.resolve(tables); 
        TbDummy.resolve(tables); 
        TbErrorInfo.resolve(tables); 
        TbCodeInfo.resolve(tables); 
        TbItem.resolve(tables); 
        TbItemFunc.resolve(tables); 
        TbItemExtra.resolve(tables); 
        TbL10NDemo.resolve(tables); 
        TbPatchDemo.resolve(tables); 
        TbSystemMail.resolve(tables); 
        TbGlobalMail.resolve(tables); 
        TbRoleLevelExpAttr.resolve(tables); 
        TbRoleLevelBonusCoefficient.resolve(tables); 
        TbTestTag.resolve(tables); 
        TbFullTypes.resolve(tables); 
        TbSingleton.resolve(tables); 
        TbDataFromJson.resolve(tables); 
        TbDataFromXml.resolve(tables); 
        TbDataFromLua.resolve(tables); 
        TbMultiRowRecord.resolve(tables); 
        TbMultiRowTitle.resolve(tables); 
        TbTestNull.resolve(tables); 
        TbDemoPrimitive.resolve(tables); 
        TbTestString.resolve(tables); 
        TbDemoGroup.resolve(tables); 
        TbDemoGroup_C.resolve(tables); 
        TbDemoGroup_S.resolve(tables); 
        TbDemoGroup_E.resolve(tables); 
        TbTestGlobal.resolve(tables); 
    }
}

