
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class MultiRowType3 {
    public MultiRowType3(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        { var _json0_ = __json__.get("items").getAsJsonArray(); items = new java.util.ArrayList<cfg.test.MultiRowType1>(_json0_.size()); for(JsonElement __e : _json0_) { cfg.test.MultiRowType1 __v;  __v = new cfg.test.MultiRowType1(__e.getAsJsonObject());  items.add(__v); }   }
    }

    public MultiRowType3(int id, java.util.ArrayList<cfg.test.MultiRowType1> items ) {
        this.id = id;
        this.items = items;
    }

    public static MultiRowType3 deserializeMultiRowType3(JsonObject __json__) {
        return new MultiRowType3(__json__);
    }

    public final int id;
    public final java.util.ArrayList<cfg.test.MultiRowType1> items;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.MultiRowType1 _e : items) { if (_e != null) _e.resolve(_tables); }
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "items:" + items + ","
        + "}";
    }
}
