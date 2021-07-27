
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
public final class BlackboardKey extends  bright.serialization.AbstractBean 
{
    public BlackboardKey(ByteBuf _buf)
    { 
        name = _buf.readString();
        desc = _buf.readString();
        isStatic = _buf.readBool();
        type = cfg.ai.EKeyType.valueOf(_buf.readInt());
        typeClassName = _buf.readString();
    }

    public BlackboardKey(String name, String desc, boolean is_static, cfg.ai.EKeyType type, String type_class_name )
    {
        this.name = name;
        this.desc = desc;
        this.isStatic = is_static;
        this.type = type;
        this.typeClassName = type_class_name;
    }

    public static BlackboardKey deserializeBlackboardKey(ByteBuf _buf)
    {
        return new BlackboardKey(_buf);
    }

    /**
     * 
     */
    public final String name;
    /**
     * 
     */
    public final String desc;
    /**
     * 
     */
    public final boolean isStatic;
    /**
     * 
     */
    public final cfg.ai.EKeyType type;
    /**
     * 
     */
    public final String typeClassName;

    public static final int ID = -511559886;

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
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "isStatic:" + isStatic + ","
        + "type:" + type + ","
        + "typeClassName:" + typeClassName + ","
        + "}";
    }
}

