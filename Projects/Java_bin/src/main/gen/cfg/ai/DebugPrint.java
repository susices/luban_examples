
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import bright.serialization.*;



public final class DebugPrint extends  cfg.ai.Task 
{
    public DebugPrint(ByteBuf _buf)
    { 
        super(_buf);
        text = _buf.readString();
    }

    public DebugPrint(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services, boolean ignore_restart_self, String text )
    {
        super(id, node_name, decorators, services, ignore_restart_self);
        this.text = text;
    }

    public static DebugPrint deserializeDebugPrint(ByteBuf _buf)
    {
        return new DebugPrint(_buf);
    }

    public final String text;

    public static final int ID = 1357409728;

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
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "ignoreRestartSelf:" + ignoreRestartSelf + ","
        + "text:" + text + ","
        + "}";
    }
}

