//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.bonus
{

public sealed partial class ShowItemInfo :  Bright.Config.BeanBase 
{
    public ShowItemInfo(ByteBuf _buf) 
    {
        ItemId = _buf.ReadInt();
        ItemNum = _buf.ReadLong();
        PostInit();
    }

    public static ShowItemInfo DeserializeShowItemInfo(ByteBuf _buf)
    {
        return new bonus.ShowItemInfo(_buf);
    }

    public int ItemId { get; private set; }
    //field.gen_ref
    public item.Item ItemId_Ref { get; private set; }
    public long ItemNum { get; private set; }

    public const int __ID__ = -1496363507;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        this.ItemId_Ref = (_tables["item.TbItem"] as item.TbItem).GetOrDefault(ItemId);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(ShowItemInfo reloadData)
    {
        ItemId = reloadData.ItemId;
        ItemNum = reloadData.ItemNum;
    }

    public override string ToString()
    {
        return "{ "
        + "ItemId:" + ItemId + ","
        + "ItemNum:" + ItemNum + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
