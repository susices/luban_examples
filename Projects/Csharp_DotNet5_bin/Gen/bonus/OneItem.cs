
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

public sealed partial class OneItem :  bonus.Bonus 
{
    public OneItem(ByteBuf _buf)  : base(_buf) 
    {
        ItemId = _buf.ReadInt();
    }

    public static OneItem DeserializeOneItem(ByteBuf _buf)
    {
        return new bonus.OneItem(_buf);
    }

    public int ItemId {get; private set;}
    public item.Item ItemId_Ref;

    public const int ID = -1649658966;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "}";
    }
    }

}
