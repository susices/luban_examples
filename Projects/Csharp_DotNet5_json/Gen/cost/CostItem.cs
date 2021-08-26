
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.cost
{

public sealed class CostItem :  cost.Cost 
{
    public CostItem(JsonElement _json)  : base(_json) 
    {
        ItemId = _json.GetProperty("item_id").GetInt32();
        Amount = _json.GetProperty("amount").GetInt32();
    }

    public CostItem(int item_id, int amount )  : base() 
    {
        this.ItemId = item_id;
        this.Amount = amount;
    }

    public static CostItem DeserializeCostItem(JsonElement _json)
    {
        return new cost.CostItem(_json);
    }

    public int ItemId {get; private set; }
    public item.Item ItemId_Ref {get; private set;}
    public int Amount {get; private set; }

    public const int ID = -1249440351;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "Amount:" + Amount + ","
        + "}";
    }
    }
}
