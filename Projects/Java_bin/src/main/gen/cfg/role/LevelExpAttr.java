
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.role;

import bright.serialization.*;



public final class LevelExpAttr {
    public LevelExpAttr(ByteBuf _buf) { 
        level = _buf.readInt();
        needExp = _buf.readLong();
        {int n = Math.min(_buf.readSize(), _buf.size());clothesAttrs = new java.util.ArrayList<Integer>(n);for(var i = 0 ; i < n ; i++) { Integer _e;  _e = _buf.readInt(); clothesAttrs.add(_e);}}
    }

    public LevelExpAttr(int level, long need_exp, java.util.ArrayList<Integer> clothes_attrs ) {
        this.level = level;
        this.needExp = need_exp;
        this.clothesAttrs = clothes_attrs;
    }


    public final int level;
    public final long needExp;
    public final java.util.ArrayList<Integer> clothesAttrs;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "level:" + level + ","
        + "needExp:" + needExp + ","
        + "clothesAttrs:" + clothesAttrs + ","
        + "}";
    }
}
