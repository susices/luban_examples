
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.ai
{

public sealed partial class ExecuteTimeStatistic :  ai.Service 
{
    public ExecuteTimeStatistic(ByteBuf _buf)  : base(_buf) 
    {
    }

    public static ExecuteTimeStatistic DeserializeExecuteTimeStatistic(ByteBuf _buf)
    {
        return new ai.ExecuteTimeStatistic(_buf);
    }


    public const int ID = 990693812;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "}";
    }
    }

}
