
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.limit;

import bright.serialization.*;



public final class WeeklyLimit extends  cfg.limit.LimitBase 
{
    public WeeklyLimit(ByteBuf _buf)
    { 
        super(_buf);
        num = _buf.readInt();
    }

    public WeeklyLimit(int num )
    {
        super();
        this.num = num;
    }

    public static WeeklyLimit deserializeWeeklyLimit(ByteBuf _buf)
    {
        return new WeeklyLimit(_buf);
    }

    public final int num;

    public static final int ID = -252187161;

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
    }

    @Override
    public String toString()
    {
        return "{ "
        + "num:" + num + ","
        + "}";
    }
}

