
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.blueprint
{

public sealed partial class Interface :  blueprint.Clazz 
{
    public Interface(ByteBuf _buf)  : base(_buf) 
    {
    }

    public static Interface DeserializeInterface(ByteBuf _buf)
    {
        return new blueprint.Interface(_buf);
    }


    public const int ID = 2114170750;
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
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "}";
    }
    }

}
