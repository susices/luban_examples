//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.role;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class LevelExpAttr {
    public LevelExpAttr(JsonObject __json__) { 
        level = __json__.get("level").getAsInt();
        needExp = __json__.get("need_exp").getAsLong();
        { com.google.gson.JsonArray _json0_ = __json__.get("clothes_attrs").getAsJsonArray(); clothesAttrs = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  clothesAttrs.add(__v); }   }
    }

    public LevelExpAttr(int level, long need_exp, java.util.ArrayList<Integer> clothes_attrs ) {
        this.level = level;
        this.needExp = need_exp;
        this.clothesAttrs = clothes_attrs;
    }

    public static LevelExpAttr deserializeLevelExpAttr(JsonObject __json__) {
        return new LevelExpAttr(__json__);
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
