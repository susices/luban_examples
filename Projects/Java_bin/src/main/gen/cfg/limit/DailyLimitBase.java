
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.limit;

import bright.serialization.*;



public abstract class DailyLimitBase extends  cfg.limit.LimitBase 
{
    public DailyLimitBase(ByteBuf _buf)
    { 
        super(_buf);
    }

    public DailyLimitBase()
    {
        super();
    }

    public static DailyLimitBase deserializeDailyLimitBase(ByteBuf _buf)
    {
        switch (_buf.readInt())
        {
            case cfg.limit.DailyLimit.ID: return new cfg.limit.DailyLimit(_buf);
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
        super.resolve(_tables);
    }

    @Override
    public String toString()
    {
        return "{ "
        + "}";
    }
}

