
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.cost
{
   
public sealed partial class CostItems :  cost.Cost 
{
    public CostItems(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);ItemList = new cost.CostItem[n];for(var i = 0 ; i < n ; i++) { cost.CostItem _e;_e = cost.CostItem.DeserializeCostItem(_buf); ItemList[i] = _e;}}
    }

    public CostItems(cost.CostItem[] item_list )  : base() 
    {
        this.ItemList = item_list;
    }

    public static CostItems DeserializeCostItems(ByteBuf _buf)
    {
    
        return new cost.CostItems(_buf);
    
    }

     public readonly cost.CostItem[] ItemList;


    public const int ID = -77945102;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            foreach(var _e in ItemList) { _e?.Resolve(_tables); }
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "ItemList:" + ItemList + ","
        + "}";
    }
    }

}

