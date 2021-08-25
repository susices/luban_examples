
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.ai;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class MoveToTarget extends cfg.ai.Task {
    public MoveToTarget(JsonObject __json__) { 
        super(__json__);
        targetActorKey = __json__.get("target_actor_key").getAsString();
        acceptableRadius = __json__.get("acceptable_radius").getAsFloat();
    }

    public MoveToTarget(int id, String node_name, java.util.ArrayList<cfg.ai.Decorator> decorators, java.util.ArrayList<cfg.ai.Service> services, boolean ignore_restart_self, String target_actor_key, float acceptable_radius ) {
        super(id, node_name, decorators, services, ignore_restart_self);
        this.targetActorKey = target_actor_key;
        this.acceptableRadius = acceptable_radius;
    }

    public static MoveToTarget deserializeMoveToTarget(JsonObject __json__) {
        return new MoveToTarget(__json__);
    }

    public final String targetActorKey;
    public final float acceptableRadius;

    public static final int ID = 514987779;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "nodeName:" + nodeName + ","
        + "decorators:" + decorators + ","
        + "services:" + services + ","
        + "ignoreRestartSelf:" + ignoreRestartSelf + ","
        + "targetActorKey:" + targetActorKey + ","
        + "acceptableRadius:" + acceptableRadius + ","
        + "}";
    }
}
