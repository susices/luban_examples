//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.item;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class Clothes extends cfg.item.ItemExtra {
    public Clothes(JsonObject __json__) { 
        super(__json__);
        attack = __json__.get("attack").getAsInt();
        hp = __json__.get("hp").getAsLong();
        energyLimit = __json__.get("energy_limit").getAsInt();
        energyResume = __json__.get("energy_resume").getAsInt();
    }

    public Clothes(int id, int attack, long hp, int energy_limit, int energy_resume ) {
        super(id);
        this.attack = attack;
        this.hp = hp;
        this.energyLimit = energy_limit;
        this.energyResume = energy_resume;
    }

    public static Clothes deserializeClothes(JsonObject __json__) {
        return new Clothes(__json__);
    }

    public final int attack;
    public final long hp;
    public final int energyLimit;
    public final int energyResume;

    public static final int __ID__ = 1659907149;

    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "attack:" + attack + ","
        + "hp:" + hp + ","
        + "energyLimit:" + energyLimit + ","
        + "energyResume:" + energyResume + ","
        + "}";
    }
}
