
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

public sealed class ChooseTarget :  ai.Service 
{
    public ChooseTarget(ByteBuf _buf)  : base(_buf) 
    {
        ResultTargetKey = _buf.ReadString();
    }

    public static ChooseTarget DeserializeChooseTarget(ByteBuf _buf)
    {
        return new ai.ChooseTarget(_buf);
    }

    public string ResultTargetKey { get; private set; }

    public const int __ID__ = 1601247918;
    public override int GetTypeId() => __ID__;

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
        + "ResultTargetKey:" + ResultTargetKey + ","
        + "}";
    }
    }

}
