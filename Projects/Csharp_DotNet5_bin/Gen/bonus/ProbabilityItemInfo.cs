
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

/// <summary>
/// 
/// </summary>
public sealed partial class ProbabilityItemInfo :  Bright.Config.BeanBase 
{
    public ProbabilityItemInfo(ByteBuf _buf) 
    {
        ItemId = _buf.ReadInt();
        Num = _buf.ReadInt();
        Probability = _buf.ReadFloat();
    }

    public ProbabilityItemInfo(int item_id, int num, float probability ) 
    {
        this.ItemId = item_id;
        this.Num = num;
        this.Probability = probability;
    }

    public static ProbabilityItemInfo DeserializeProbabilityItemInfo(ByteBuf _buf)
    {
        return new bonus.ProbabilityItemInfo(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly int ItemId;
    public item.Item ItemId_Ref;
    /// <summary>
    /// 
    /// </summary>
    public readonly int Num;
    /// <summary>
    /// 
    /// </summary>
    public readonly float Probability;

    public const int ID = 1547874631;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "Num:" + Num + ","
        + "Probability:" + Probability + ","
        + "}";
    }
    }

}

