
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.bonus
{

public sealed partial class DropBonus :  bonus.Bonus 
{
    public DropBonus(ByteBuf _buf)  : base(_buf) 
    {
        Id = _buf.ReadInt();
    }

    public static DropBonus DeserializeDropBonus(ByteBuf _buf)
    {
        return new bonus.DropBonus(_buf);
    }

    public int Id {get; private set;}
    public bonus.DropInfo Id_Ref;

    public const int ID = 1959868225;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.Id_Ref = (_tables["bonus.TbDrop"] as bonus.TbDrop).GetOrDefault(Id);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "}";
    }
    }

}
