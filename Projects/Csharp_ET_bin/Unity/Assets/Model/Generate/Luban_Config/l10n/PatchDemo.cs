
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.l10n
{

public sealed partial class PatchDemo :  Bright.Config.BeanBase 
{
    public PatchDemo(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Value = _buf.ReadInt();
    }

    public PatchDemo(int id, int value ) 
    {
        this.Id = id;
        this.Value = value;
    }

    public static PatchDemo DeserializePatchDemo(ByteBuf _buf)
    {
        return new l10n.PatchDemo(_buf);
    }

    public readonly int Id;
    public readonly int Value;

    public const int ID = -1707294656;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Value:" + Value + ","
        + "}";
    }
    }

}

