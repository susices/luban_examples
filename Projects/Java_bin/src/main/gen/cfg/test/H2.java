
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
public final class H2 extends  bright.serialization.AbstractBean 
{
    public H2(ByteBuf _buf)
    { 
        z2 = _buf.readInt();
        z3 = _buf.readInt();
    }

    public H2(int z2, int z3 )
    {
        this.z2 = z2;
        this.z3 = z3;
    }

    public static H2 deserializeH2(ByteBuf _buf)
    {
        return new H2(_buf);
    }

    /**
     * 
     */
    public final int z2;
    /**
     * 
     */
    public final int z3;

    public static final int ID = -1422503994;

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
        + "z2:" + z2 + ","
        + "z3:" + z3 + ","
        + "}";
    }
}

