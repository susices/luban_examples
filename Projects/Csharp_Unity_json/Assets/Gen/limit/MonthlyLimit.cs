
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



namespace cfg.limit
{

public sealed partial class MonthlyLimit :  limit.LimitBase 
{
    public MonthlyLimit(JSONNode _json)  : base(_json) 
    {
        { if(!_json["num"].IsNumber) { throw new SerializationException(); }  Num = _json["num"]; }
    }

    public MonthlyLimit(int num )  : base() 
    {
        this.Num = num;
    }

    public static MonthlyLimit DeserializeMonthlyLimit(JSONNode _json)
    {
        return new limit.MonthlyLimit(_json);
    }

    public readonly int Num;

    public const int ID = 2063279905;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Num:" + Num + ","
        + "}";
    }
    }
}

