
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import bright.serialization.*;



/**
 * 
 */
public final class DateTimeRange extends  bright.serialization.AbstractBean 
{
    public DateTimeRange(ByteBuf _buf)
    { 
        startTime = _buf.readInt();
        endTime = _buf.readInt();
    }

    public DateTimeRange(int start_time, int end_time )
    {
        this.startTime = start_time;
        this.endTime = end_time;
    }

    public static DateTimeRange deserializeDateTimeRange(ByteBuf _buf)
    {
        return new DateTimeRange(_buf);
    }

    /**
     * 
     */
    public final int startTime;
    /**
     * 
     */
    public final int endTime;

    public static final int ID = 495315430;

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
    }

    @Override
    public String toString()
    {
        return "{ "
        + "startTime:" + startTime + ","
        + "endTime:" + endTime + ","
        + "}";
    }
}

