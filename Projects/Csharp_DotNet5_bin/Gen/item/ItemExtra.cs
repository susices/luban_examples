
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{
   
public abstract partial class ItemExtra :  Bright.Config.BeanBase 
{
    public ItemExtra(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
    }

    public ItemExtra(int id ) 
    {
        this.Id = id;
    }

    public static ItemExtra DeserializeItemExtra(ByteBuf _buf)
    {
    
        switch (_buf.ReadInt())
        {
            case 0 : return null;
            case item.TreasureBox.ID: return new item.TreasureBox(_buf);
            case item.InteractionItem.ID: return new item.InteractionItem(_buf);
            case item.Clothes.ID: return new item.Clothes(_buf);
            case item.DesignDrawing.ID: return new item.DesignDrawing(_buf);
            case item.Dymmy.ID: return new item.Dymmy(_buf);
            default: throw new SerializationException();
        }
    
    }

     public readonly int Id;



    public virtual void Resolve(Dictionary<string, object> _tables)
    {

        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "}";
    }
    }

}

