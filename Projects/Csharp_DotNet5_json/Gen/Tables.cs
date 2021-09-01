
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Text.Json;

namespace cfg
{
   
public sealed partial class Tables
{
    public ai.TbBlackboard TbBlackboard {get; }
    public ai.TbBehaviorTree TbBehaviorTree {get; }
    public blueprint.TbClazz TbClazz {get; }
    public bonus.TbDrop TbDrop {get; }
    public common.TbGlobalConfig TbGlobalConfig {get; }
    public common.TbDummy TbDummy {get; }
    public error.TbErrorInfo TbErrorInfo {get; }
    public error.TbCodeInfo TbCodeInfo {get; }
    /// <summary>
    /// 道具表
    /// </summary>
    public item.TbItem TbItem {get; }
    public item.TbItemFunc TbItemFunc {get; }
    public item.TbItemExtra TbItemExtra {get; }
    public l10n.TbL10NDemo TbL10NDemo {get; }
    public l10n.TbPatchDemo TbPatchDemo {get; }
    public mail.TbSystemMail TbSystemMail {get; }
    public mail.TbGlobalMail TbGlobalMail {get; }
    public role.TbRoleLevelExpAttr TbRoleLevelExpAttr {get; }
    public role.TbRoleLevelBonusCoefficient TbRoleLevelBonusCoefficient {get; }
    public tag.TbTestTag TbTestTag {get; }
    public test.TbFullTypes TbFullTypes {get; }
    public test.TbSingleton TbSingleton {get; }
    public test.TbDataFromMisc TbDataFromMisc {get; }
    public test.TbMultiRowRecord TbMultiRowRecord {get; }
    public test.TbMultiRowTitle TbMultiRowTitle {get; }
    public test.TbTestNull TbTestNull {get; }
    public test.TbDemoPrimitive TbDemoPrimitive {get; }
    public test.TbTestString TbTestString {get; }
    public test.TbDemoGroup TbDemoGroup {get; }
    public test.TbDemoGroup_C TbDemoGroup_C {get; }
    public test.TbDemoGroup_S TbDemoGroup_S {get; }
    public test.TbDemoGroup_E TbDemoGroup_E {get; }
    public test.TbTestGlobal TbTestGlobal {get; }
    public test.TbDetectCsvEncoding TbDetectCsvEncoding {get; }
    public test.TbDefineFromExcel TbDefineFromExcel {get; }
    public test.TbDefineFromExcelOne TbDefineFromExcelOne {get; }
    public test.TbTestJson2 TbTestJson2 {get; }
    public test.TbTestIndex TbTestIndex {get; }
    public test.TbTestMap TbTestMap {get; }
    public test.TbDemoGroupDefineFromExcel TbDemoGroupDefineFromExcel {get; }
    public test.TbDefineFromExcel2 TbDefineFromExcel2 {get; }
    public test.TbTestExcelBean TbTestExcelBean {get; }

    public Tables(System.Func<string, JsonElement> loader)
    {
        var tables = new System.Collections.Generic.Dictionary<string, object>();
        TbBlackboard = new ai.TbBlackboard(loader("ai_tbblackboard")); 
        tables.Add("ai.TbBlackboard", TbBlackboard);
        TbBehaviorTree = new ai.TbBehaviorTree(loader("ai_tbbehaviortree")); 
        tables.Add("ai.TbBehaviorTree", TbBehaviorTree);
        TbClazz = new blueprint.TbClazz(loader("blueprint_tbclazz")); 
        tables.Add("blueprint.TbClazz", TbClazz);
        TbDrop = new bonus.TbDrop(loader("bonus_tbdrop")); 
        tables.Add("bonus.TbDrop", TbDrop);
        TbGlobalConfig = new common.TbGlobalConfig(loader("common_tbglobalconfig")); 
        tables.Add("common.TbGlobalConfig", TbGlobalConfig);
        TbDummy = new common.TbDummy(loader("common_tbdummy")); 
        tables.Add("common.TbDummy", TbDummy);
        TbErrorInfo = new error.TbErrorInfo(loader("error_tberrorinfo")); 
        tables.Add("error.TbErrorInfo", TbErrorInfo);
        TbCodeInfo = new error.TbCodeInfo(loader("error_tbcodeinfo")); 
        tables.Add("error.TbCodeInfo", TbCodeInfo);
        TbItem = new item.TbItem(loader("item_tbitem")); 
        tables.Add("item.TbItem", TbItem);
        TbItemFunc = new item.TbItemFunc(loader("item_tbitemfunc")); 
        tables.Add("item.TbItemFunc", TbItemFunc);
        TbItemExtra = new item.TbItemExtra(loader("item_tbitemextra")); 
        tables.Add("item.TbItemExtra", TbItemExtra);
        TbL10NDemo = new l10n.TbL10NDemo(loader("l10n_tbl10ndemo")); 
        tables.Add("l10n.TbL10NDemo", TbL10NDemo);
        TbPatchDemo = new l10n.TbPatchDemo(loader("l10n_tbpatchdemo")); 
        tables.Add("l10n.TbPatchDemo", TbPatchDemo);
        TbSystemMail = new mail.TbSystemMail(loader("mail_tbsystemmail")); 
        tables.Add("mail.TbSystemMail", TbSystemMail);
        TbGlobalMail = new mail.TbGlobalMail(loader("mail_tbglobalmail")); 
        tables.Add("mail.TbGlobalMail", TbGlobalMail);
        TbRoleLevelExpAttr = new role.TbRoleLevelExpAttr(loader("role_tbrolelevelexpattr")); 
        tables.Add("role.TbRoleLevelExpAttr", TbRoleLevelExpAttr);
        TbRoleLevelBonusCoefficient = new role.TbRoleLevelBonusCoefficient(loader("role_tbrolelevelbonuscoefficient")); 
        tables.Add("role.TbRoleLevelBonusCoefficient", TbRoleLevelBonusCoefficient);
        TbTestTag = new tag.TbTestTag(loader("tag_tbtesttag")); 
        tables.Add("tag.TbTestTag", TbTestTag);
        TbFullTypes = new test.TbFullTypes(loader("test_tbfulltypes")); 
        tables.Add("test.TbFullTypes", TbFullTypes);
        TbSingleton = new test.TbSingleton(loader("test_tbsingleton")); 
        tables.Add("test.TbSingleton", TbSingleton);
        TbDataFromMisc = new test.TbDataFromMisc(loader("test_tbdatafrommisc")); 
        tables.Add("test.TbDataFromMisc", TbDataFromMisc);
        TbMultiRowRecord = new test.TbMultiRowRecord(loader("test_tbmultirowrecord")); 
        tables.Add("test.TbMultiRowRecord", TbMultiRowRecord);
        TbMultiRowTitle = new test.TbMultiRowTitle(loader("test_tbmultirowtitle")); 
        tables.Add("test.TbMultiRowTitle", TbMultiRowTitle);
        TbTestNull = new test.TbTestNull(loader("test_tbtestnull")); 
        tables.Add("test.TbTestNull", TbTestNull);
        TbDemoPrimitive = new test.TbDemoPrimitive(loader("test_tbdemoprimitive")); 
        tables.Add("test.TbDemoPrimitive", TbDemoPrimitive);
        TbTestString = new test.TbTestString(loader("test_tbteststring")); 
        tables.Add("test.TbTestString", TbTestString);
        TbDemoGroup = new test.TbDemoGroup(loader("test_tbdemogroup")); 
        tables.Add("test.TbDemoGroup", TbDemoGroup);
        TbDemoGroup_C = new test.TbDemoGroup_C(loader("test_tbdemogroup_c")); 
        tables.Add("test.TbDemoGroup_C", TbDemoGroup_C);
        TbDemoGroup_S = new test.TbDemoGroup_S(loader("test_tbdemogroup_s")); 
        tables.Add("test.TbDemoGroup_S", TbDemoGroup_S);
        TbDemoGroup_E = new test.TbDemoGroup_E(loader("test_tbdemogroup_e")); 
        tables.Add("test.TbDemoGroup_E", TbDemoGroup_E);
        TbTestGlobal = new test.TbTestGlobal(loader("test_tbtestglobal")); 
        tables.Add("test.TbTestGlobal", TbTestGlobal);
        TbDetectCsvEncoding = new test.TbDetectCsvEncoding(loader("test_tbdetectcsvencoding")); 
        tables.Add("test.TbDetectCsvEncoding", TbDetectCsvEncoding);
        TbDefineFromExcel = new test.TbDefineFromExcel(loader("test_tbdefinefromexcel")); 
        tables.Add("test.TbDefineFromExcel", TbDefineFromExcel);
        TbDefineFromExcelOne = new test.TbDefineFromExcelOne(loader("test_tbdefinefromexcelone")); 
        tables.Add("test.TbDefineFromExcelOne", TbDefineFromExcelOne);
        TbTestJson2 = new test.TbTestJson2(loader("test_tbtestjson2")); 
        tables.Add("test.TbTestJson2", TbTestJson2);
        TbTestIndex = new test.TbTestIndex(loader("test_tbtestindex")); 
        tables.Add("test.TbTestIndex", TbTestIndex);
        TbTestMap = new test.TbTestMap(loader("test_tbtestmap")); 
        tables.Add("test.TbTestMap", TbTestMap);
        TbDemoGroupDefineFromExcel = new test.TbDemoGroupDefineFromExcel(loader("test_tbdemogroupdefinefromexcel")); 
        tables.Add("test.TbDemoGroupDefineFromExcel", TbDemoGroupDefineFromExcel);
        TbDefineFromExcel2 = new test.TbDefineFromExcel2(loader("test_tbdefinefromexcel2")); 
        tables.Add("test.TbDefineFromExcel2", TbDefineFromExcel2);
        TbTestExcelBean = new test.TbTestExcelBean(loader("test_tbtestexcelbean")); 
        tables.Add("test.TbTestExcelBean", TbTestExcelBean);

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
        TbL10NDemo.Resolve(tables); 
        TbPatchDemo.Resolve(tables); 
        TbSystemMail.Resolve(tables); 
        TbGlobalMail.Resolve(tables); 
        TbRoleLevelExpAttr.Resolve(tables); 
        TbRoleLevelBonusCoefficient.Resolve(tables); 
        TbTestTag.Resolve(tables); 
        TbFullTypes.Resolve(tables); 
        TbSingleton.Resolve(tables); 
        TbDataFromMisc.Resolve(tables); 
        TbMultiRowRecord.Resolve(tables); 
        TbMultiRowTitle.Resolve(tables); 
        TbTestNull.Resolve(tables); 
        TbDemoPrimitive.Resolve(tables); 
        TbTestString.Resolve(tables); 
        TbDemoGroup.Resolve(tables); 
        TbDemoGroup_C.Resolve(tables); 
        TbDemoGroup_S.Resolve(tables); 
        TbDemoGroup_E.Resolve(tables); 
        TbTestGlobal.Resolve(tables); 
        TbDetectCsvEncoding.Resolve(tables); 
        TbDefineFromExcel.Resolve(tables); 
        TbDefineFromExcelOne.Resolve(tables); 
        TbTestJson2.Resolve(tables); 
        TbTestIndex.Resolve(tables); 
        TbTestMap.Resolve(tables); 
        TbDemoGroupDefineFromExcel.Resolve(tables); 
        TbDefineFromExcel2.Resolve(tables); 
        TbTestExcelBean.Resolve(tables); 
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        TbBlackboard.TranslateText(translator); 
        TbBehaviorTree.TranslateText(translator); 
        TbClazz.TranslateText(translator); 
        TbDrop.TranslateText(translator); 
        TbGlobalConfig.TranslateText(translator); 
        TbDummy.TranslateText(translator); 
        TbErrorInfo.TranslateText(translator); 
        TbCodeInfo.TranslateText(translator); 
        TbItem.TranslateText(translator); 
        TbItemFunc.TranslateText(translator); 
        TbItemExtra.TranslateText(translator); 
        TbL10NDemo.TranslateText(translator); 
        TbPatchDemo.TranslateText(translator); 
        TbSystemMail.TranslateText(translator); 
        TbGlobalMail.TranslateText(translator); 
        TbRoleLevelExpAttr.TranslateText(translator); 
        TbRoleLevelBonusCoefficient.TranslateText(translator); 
        TbTestTag.TranslateText(translator); 
        TbFullTypes.TranslateText(translator); 
        TbSingleton.TranslateText(translator); 
        TbDataFromMisc.TranslateText(translator); 
        TbMultiRowRecord.TranslateText(translator); 
        TbMultiRowTitle.TranslateText(translator); 
        TbTestNull.TranslateText(translator); 
        TbDemoPrimitive.TranslateText(translator); 
        TbTestString.TranslateText(translator); 
        TbDemoGroup.TranslateText(translator); 
        TbDemoGroup_C.TranslateText(translator); 
        TbDemoGroup_S.TranslateText(translator); 
        TbDemoGroup_E.TranslateText(translator); 
        TbTestGlobal.TranslateText(translator); 
        TbDetectCsvEncoding.TranslateText(translator); 
        TbDefineFromExcel.TranslateText(translator); 
        TbDefineFromExcelOne.TranslateText(translator); 
        TbTestJson2.TranslateText(translator); 
        TbTestIndex.TranslateText(translator); 
        TbTestMap.TranslateText(translator); 
        TbDemoGroupDefineFromExcel.TranslateText(translator); 
        TbDefineFromExcel2.TranslateText(translator); 
        TbTestExcelBean.TranslateText(translator); 
    }
}

}
