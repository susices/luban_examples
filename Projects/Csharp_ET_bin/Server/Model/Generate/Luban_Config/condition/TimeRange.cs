
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

public sealed class TimeRange :  condition.Condition 
{
    public TimeRange(ByteBuf _buf)  : base(_buf) 
    {
        DateTimeRange = common.DateTimeRange.DeserializeDateTimeRange(_buf);
    }

    public static TimeRange DeserializeTimeRange(ByteBuf _buf)
    {
        return new condition.TimeRange(_buf);
    }

    public common.DateTimeRange DateTimeRange { get; private set; }

    public const int __ID__ = 1069033789;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        DateTimeRange?.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        DateTimeRange?.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "DateTimeRange:" + DateTimeRange + ","
        + "}";
    }
    }

}
