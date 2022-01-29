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



public final class InteractionItem extends cfg.item.ItemExtra {
    public InteractionItem(JsonObject __json__) { 
        super(__json__);
        { if (__json__.has("attack_num") && !__json__.get("attack_num").isJsonNull()) { attackNum = __json__.get("attack_num").getAsInt(); } else { attackNum = null; } }
        holdingStaticMesh = __json__.get("holding_static_mesh").getAsString();
        holdingStaticMeshMat = __json__.get("holding_static_mesh_mat").getAsString();
    }

    public InteractionItem(int id, Integer attack_num, String holding_static_mesh, String holding_static_mesh_mat ) {
        super(id);
        this.attackNum = attack_num;
        this.holdingStaticMesh = holding_static_mesh;
        this.holdingStaticMeshMat = holding_static_mesh_mat;
    }

    public static InteractionItem deserializeInteractionItem(JsonObject __json__) {
        return new InteractionItem(__json__);
    }

    public final Integer attackNum;
    public final String holdingStaticMesh;
    public final String holdingStaticMeshMat;

    public static final int __ID__ = 640937802;

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
        + "attackNum:" + attackNum + ","
        + "holdingStaticMesh:" + holdingStaticMesh + ","
        + "holdingStaticMeshMat:" + holdingStaticMeshMat + ","
        + "}";
    }
}
