
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import bright.serialization.*;



public final class IsSet extends  cfg.ai.KeyQueryOperator 
{
    public IsSet(ByteBuf _buf)
    { 
        super(_buf);
    }

    public IsSet()
    {
        super();
    }

    public static IsSet deserializeIsSet(ByteBuf _buf)
    {
        return new IsSet(_buf);
    }


    public static final int ID = 1635350898;

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
        + "}";
    }
}

