
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import bright.serialization.*;



public final class FloatKeyData extends cfg.ai.KeyData {
    public FloatKeyData(ByteBuf _buf) { 
        super(_buf);
        value = _buf.readFloat();
    }

    public FloatKeyData(float value ) {
        super();
        this.value = value;
    }


    public final float value;

    public static final int ID = -719747885;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "value:" + value + ","
        + "}";
    }
}
