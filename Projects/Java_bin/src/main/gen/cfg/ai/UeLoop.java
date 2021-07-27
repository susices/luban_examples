
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import bright.serialization.*;



/**
 * 
 */
public final class UeLoop extends  cfg.ai.Decorator 
{
    public UeLoop(ByteBuf _buf)
    { 
        super(_buf);
        numLoops = _buf.readInt();
        infiniteLoop = _buf.readBool();
        infiniteLoopTimeoutTime = _buf.readFloat();
    }

    public UeLoop(int id, String node_name, cfg.ai.EFlowAbortMode flow_abort_mode, int num_loops, boolean infinite_loop, float infinite_loop_timeout_time )
    {
        super(id, node_name, flow_abort_mode);
        this.numLoops = num_loops;
        this.infiniteLoop = infinite_loop;
        this.infiniteLoopTimeoutTime = infinite_loop_timeout_time;
    }

    public static UeLoop deserializeUeLoop(ByteBuf _buf)
    {
        return new UeLoop(_buf);
    }

    /**
     * 
     */
    public final int numLoops;
    /**
     * 
     */
    public final boolean infiniteLoop;
    /**
     * 
     */
    public final float infiniteLoopTimeoutTime;

    public static final int ID = -513308166;

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
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "flowAbortMode:" + flowAbortMode + ","
        + "numLoops:" + numLoops + ","
        + "infiniteLoop:" + infiniteLoop + ","
        + "infiniteLoopTimeoutTime:" + infiniteLoopTimeoutTime + ","
        + "}";
    }
}

