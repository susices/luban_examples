
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.blueprint;

import bright.serialization.*;



public final class BlueprintMethod extends  cfg.blueprint.Method 
{
    public BlueprintMethod(ByteBuf _buf)
    { 
        super(_buf);
    }

    public BlueprintMethod(String name, String desc, boolean is_static, String return_type, java.util.ArrayList<cfg.blueprint.ParamInfo> parameters )
    {
        super(name, desc, is_static, return_type, parameters);
    }

    public static BlueprintMethod deserializeBlueprintMethod(ByteBuf _buf)
    {
        return new BlueprintMethod(_buf);
    }


    public static final int ID = -696408103;

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
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "isStatic:" + isStatic + ","
        + "returnType:" + returnType + ","
        + "parameters:" + parameters + ","
        + "}";
    }
}

