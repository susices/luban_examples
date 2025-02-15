
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

public sealed partial class EnumField :  Bright.Config.BeanBase 
{
    public EnumField(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Value = _buf.ReadInt();
    }

    public EnumField(string name, int value ) 
    {
        this.Name = name;
        this.Value = value;
    }

    public static EnumField DeserializeEnumField(ByteBuf _buf)
    {
        return new blueprint.EnumField(_buf);
    }

    public readonly string Name;
    public readonly int Value;

    public const int ID = 1830049470;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Value:" + Value + ","
        + "}";
    }
    }

}

