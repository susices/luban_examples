
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

public sealed partial class MinLevel :  condition.BoolRoleCondition 
{
    public MinLevel(ByteBuf _buf)  : base(_buf) 
    {
        Level = _buf.ReadInt();
    }

    public static MinLevel DeserializeMinLevel(ByteBuf _buf)
    {
        return new condition.MinLevel(_buf);
    }

    public int Level {get; private set;}

    public const int ID = -1075273755;
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
        + "Level:" + Level + ","
        + "}";
    }
    }

}
