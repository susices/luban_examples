
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.item;

import bright.serialization.*;



/**
 * 
 */
public final class Dymmy extends  cfg.item.ItemExtra 
{
    public Dymmy(ByteBuf _buf)
    { 
        super(_buf);
        cost = cfg.cost.Cost.deserializeCost(_buf);
    }

    public Dymmy(int id, cfg.cost.Cost cost )
    {
        super(id);
        this.cost = cost;
    }

    public static Dymmy deserializeDymmy(ByteBuf _buf)
    {
        return new Dymmy(_buf);
    }

    /**
     * 
     */
    public final cfg.cost.Cost cost;

    public static final int ID = 896889705;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void serialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    @Override
    public void deserialize(ByteBuf os)
    {
        throw new UnsupportedOperationException();
    }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        super.resolve(_tables);
            if (cost != null) {cost.resolve(_tables);}
    }

    @Override
    public String toString()
    {
        return "{ "
        + "id:" + id + ","
        + "cost:" + cost + ","
        + "}";
    }
}

