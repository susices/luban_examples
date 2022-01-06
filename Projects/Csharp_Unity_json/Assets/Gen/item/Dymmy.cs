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

public sealed class Dymmy :  item.ItemExtra 
{
    public Dymmy(JSONNode _json)  : base(_json) 
    {
        { if(!_json["cost"].IsObject) { throw new SerializationException(); }  Cost = cost.Cost.DeserializeCost(_json["cost"]); }
    }

    public Dymmy(int id, cost.Cost cost )  : base(id) 
    {
        this.Cost = cost;
    }

    public static Dymmy DeserializeDymmy(JSONNode _json)
    {
        return new item.Dymmy(_json);
    }

    public cost.Cost Cost { get; private set; }

    public const int __ID__ = 896889705;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        Cost?.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        Cost?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Cost:" + Cost + ","
        + "}";
    }
    }
}
