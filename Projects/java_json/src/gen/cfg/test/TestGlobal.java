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



public final class TestGlobal {
    public TestGlobal(JsonObject __json__) { 
        unlockEquip = __json__.get("unlock_equip").getAsInt();
        unlockHero = __json__.get("unlock_hero").getAsInt();
    }

    public TestGlobal(int unlock_equip, int unlock_hero ) {
        this.unlockEquip = unlock_equip;
        this.unlockHero = unlock_hero;
    }

    public static TestGlobal deserializeTestGlobal(JsonObject __json__) {
        return new TestGlobal(__json__);
    }

    public final int unlockEquip;
    public final int unlockHero;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "unlockEquip:" + unlockEquip + ","
        + "unlockHero:" + unlockHero + ","
        + "}";
    }
}
