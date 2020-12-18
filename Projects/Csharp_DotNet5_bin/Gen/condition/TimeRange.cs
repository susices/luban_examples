
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.condition
{
   
public sealed partial class TimeRange :  condition.Condition 
{
    public TimeRange(ByteBuf _buf)  : base(_buf) 
    {
        DateTimeRange = common.DateTimeRange.DeserializeDateTimeRange(_buf);
    }

    public TimeRange(common.DateTimeRange date_time_range )  : base() 
    {
        this.DateTimeRange = date_time_range;
    }

    public static TimeRange DeserializeTimeRange(ByteBuf _buf)
    {
    
        return new condition.TimeRange(_buf);
    
    }

     public readonly common.DateTimeRange DateTimeRange;


    public const int ID = 1069033789;
    public override int GetTypeId() => ID;


    public override void Resolve(Dictionary<string, object> _tables)
    {
base.Resolve(_tables);
            DateTimeRange?.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "DateTimeRange:" + DateTimeRange + ","
        + "}";
    }
    }

}

