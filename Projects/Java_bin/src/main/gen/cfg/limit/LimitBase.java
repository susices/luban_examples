
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.limit;

import bright.serialization.*;



public abstract class LimitBase extends  bright.serialization.AbstractBean 
{
    public LimitBase(ByteBuf _buf)
    { 
    }

    public LimitBase()
    {
    }

    public static LimitBase deserializeLimitBase(ByteBuf _buf)
    {
        switch (_buf.readInt())
        {
            case cfg.limit.DailyLimit.ID: return new cfg.limit.DailyLimit(_buf);
            case cfg.limit.MultiDayLimit.ID: return new cfg.limit.MultiDayLimit(_buf);
            case cfg.limit.WeeklyLimit.ID: return new cfg.limit.WeeklyLimit(_buf);
            case cfg.limit.MonthlyLimit.ID: return new cfg.limit.MonthlyLimit(_buf);
            case cfg.limit.CoolDown.ID: return new cfg.limit.CoolDown(_buf);
            case cfg.limit.GroupCoolDown.ID: return new cfg.limit.GroupCoolDown(_buf);
            default: throw new SerializationException();
        }
    }



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
    }

    @Override
    public String toString()
    {
        return "{ "
        + "}";
    }
}

