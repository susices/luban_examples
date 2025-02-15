
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class DateTimeRange :  Bright.Config.BeanBase 
{
    public DateTimeRange(ByteBuf _buf) 
    {
        StartTime = _buf.ReadInt();
        EndTime = _buf.ReadInt();
    }

    public DateTimeRange(int start_time, int end_time ) 
    {
        this.StartTime = start_time;
        this.EndTime = end_time;
    }

    public static DateTimeRange DeserializeDateTimeRange(ByteBuf _buf)
    {
        return new test.DateTimeRange(_buf);
    }

    public readonly int StartTime;
    public readonly int EndTime;

    public const int ID = 495315430;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "StartTime:" + StartTime + ","
        + "EndTime:" + EndTime + ","
        + "}";
    }
    }

}

