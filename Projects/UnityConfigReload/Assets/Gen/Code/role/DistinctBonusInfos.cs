//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.role
{

public sealed partial class DistinctBonusInfos :  Bright.Config.BeanBase 
{
    public DistinctBonusInfos(ByteBuf _buf) 
    {
        EffectiveLevel = _buf.ReadInt();
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);BonusInfo = new System.Collections.Generic.List<role.BonusInfo>(n);for(var i = 0 ; i < n ; i++) { role.BonusInfo _e;  _e = role.BonusInfo.DeserializeBonusInfo(_buf); BonusInfo.Add(_e);}}
        PostInit();
    }

    public static DistinctBonusInfos DeserializeDistinctBonusInfos(ByteBuf _buf)
    {
        return new role.DistinctBonusInfos(_buf);
    }

    public int EffectiveLevel { get; private set; }
    public System.Collections.Generic.List<role.BonusInfo> BonusInfo { get; private set; }

    public const int __ID__ = -854361766;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var _e in BonusInfo) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var _e in BonusInfo) { _e?.TranslateText(translator); }
    }

    public void Reload(DistinctBonusInfos reloadData)
    {
        //Luban.Job.Common.Types.TInt
        EffectiveLevel = reloadData.EffectiveLevel;
        //Luban.Job.Common.Types.TList
        BonusInfo = reloadData.BonusInfo;
    }

    public override string ToString()
    {
        return "{ "
        + "EffectiveLevel:" + EffectiveLevel + ","
        + "BonusInfo:" + Bright.Common.StringUtil.CollectionToString(BonusInfo) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
