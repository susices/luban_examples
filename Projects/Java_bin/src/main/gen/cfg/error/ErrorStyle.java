
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.error;

import bright.serialization.*;



public abstract class ErrorStyle {
    public ErrorStyle(ByteBuf _buf) { 
    }

    public ErrorStyle() {
    }

    public static ErrorStyle deserializeErrorStyle(ByteBuf _buf) {
        switch (_buf.readInt()) {
            case cfg.error.ErrorStyleTip.__ID__: return new cfg.error.ErrorStyleTip(_buf);
            case cfg.error.ErrorStyleMsgbox.__ID__: return new cfg.error.ErrorStyleMsgbox(_buf);
            case cfg.error.ErrorStyleDlgOk.__ID__: return new cfg.error.ErrorStyleDlgOk(_buf);
            case cfg.error.ErrorStyleDlgOkCancel.__ID__: return new cfg.error.ErrorStyleDlgOkCancel(_buf);
            default: throw new SerializationException();
        }
    }


    public abstract int getTypeId();

    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "}";
    }
}
