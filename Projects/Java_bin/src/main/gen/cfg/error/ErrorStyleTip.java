
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.error;

import bright.serialization.*;



/**
 * 
 */
public final class ErrorStyleTip extends  cfg.error.ErrorStyle 
{
    public ErrorStyleTip(ByteBuf _buf)
    { 
        super(_buf);
    }

    public ErrorStyleTip()
    {
        super();
    }

    public static ErrorStyleTip deserializeErrorStyleTip(ByteBuf _buf)
    {
        return new ErrorStyleTip(_buf);
    }


    public static final int ID = 1915239884;

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

