
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

public sealed partial class BlackboardKeyData :  ai.KeyData 
{
    public BlackboardKeyData(ByteBuf _buf)  : base(_buf) 
    {
        Value = _buf.ReadString();
    }

    public BlackboardKeyData(string value )  : base() 
    {
        this.Value = value;
    }

    public static BlackboardKeyData DeserializeBlackboardKeyData(ByteBuf _buf)
    {
        return new ai.BlackboardKeyData(_buf);
    }

    public readonly string Value;

    public const int ID = 1517269500;
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
        + "Value:" + Value + ","
        + "}";
    }
    }

}

