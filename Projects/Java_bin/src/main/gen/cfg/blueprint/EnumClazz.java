
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.blueprint;

import bright.serialization.*;



/**
 * 
 */
public final class EnumClazz extends  cfg.blueprint.Clazz 
{
    public EnumClazz(ByteBuf _buf)
    { 
        super(_buf);
        {int n = Math.min(_buf.readSize(), _buf.size());enums = new java.util.ArrayList<cfg.blueprint.EnumField>(n);for(var i = 0 ; i < n ; i++) { cfg.blueprint.EnumField _e;  _e = cfg.blueprint.EnumField.deserializeEnumField(_buf); enums.add(_e);}}
    }

    public EnumClazz(String name, String desc, java.util.ArrayList<cfg.blueprint.Clazz> parents, java.util.ArrayList<cfg.blueprint.Method> methods, java.util.ArrayList<cfg.blueprint.EnumField> enums )
    {
        super(name, desc, parents, methods);
        this.enums = enums;
    }

    public static EnumClazz deserializeEnumClazz(ByteBuf _buf)
    {
        return new EnumClazz(_buf);
    }

    /**
     * 
     */
    public final java.util.ArrayList<cfg.blueprint.EnumField> enums;

    public static final int ID = 1827364892;

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
            for(cfg.blueprint.EnumField _e : enums) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString()
    {
        return "{ "
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "parents:" + parents + ","
        + "methods:" + methods + ","
        + "enums:" + enums + ","
        + "}";
    }
}

