
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;



public abstract class DemoD3 extends cfg.test.DemoDynamic {
    public DemoD3(ByteBuf _buf) { 
        super(_buf);
        x3 = _buf.readInt();
    }

    public DemoD3(int x1, int x3 ) {
        super(x1);
        this.x3 = x3;
    }

    public static DemoD3 deserializeDemoD3(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.test.DemoE1.ID: return new cfg.test.DemoE1(_buf);
            default: throw new SerializationException();
        }
    }

    public final int x3;


    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "x1:" + x1 + ","
        + "x3:" + x3 + ","
        + "}";
    }
}
