
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



public final class BonusInfo {
    public BonusInfo(JsonObject __json__) { 
        type = cfg.item.ECurrencyType.valueOf(__json__.get("type").getAsInt());
        coefficient = __json__.get("coefficient").getAsFloat();
    }

    public BonusInfo(cfg.item.ECurrencyType type, float coefficient ) {
        this.type = type;
        this.coefficient = coefficient;
    }

    public static BonusInfo deserializeBonusInfo(JsonObject __json__) {
        return new BonusInfo(__json__);
    }

    public final cfg.item.ECurrencyType type;
    public final float coefficient;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "type:" + type + ","
        + "coefficient:" + coefficient + ","
        + "}";
    }
}
