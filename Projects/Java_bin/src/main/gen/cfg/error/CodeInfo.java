
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.error;

import bright.serialization.*;



public final class CodeInfo {
    public CodeInfo(ByteBuf _buf) { 
        code = cfg.error.EErrorCode.valueOf(_buf.readInt());
        key = _buf.readString();
    }

    public CodeInfo(cfg.error.EErrorCode code, String key ) {
        this.code = code;
        this.key = key;
    }


    public final cfg.error.EErrorCode code;
    public final String key;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "code:" + code + ","
        + "key:" + key + ","
        + "}";
    }
}
