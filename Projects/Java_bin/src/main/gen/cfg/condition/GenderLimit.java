
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.condition;

import bright.serialization.*;



/**
 * 
 */
public final class GenderLimit extends  cfg.condition.BoolRoleCondition 
{
    public GenderLimit(ByteBuf _buf)
    { 
        super(_buf);
        gender = cfg.role.EGenderType.valueOf(_buf.readInt());
    }

    public GenderLimit(cfg.role.EGenderType gender )
    {
        super();
        this.gender = gender;
    }

    public static GenderLimit deserializeGenderLimit(ByteBuf _buf)
    {
        return new GenderLimit(_buf);
    }

    /**
     * 
     */
    public final cfg.role.EGenderType gender;

    public static final int ID = 103675143;

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
        + "gender:" + gender + ","
        + "}";
    }
}

