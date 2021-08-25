
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



public final class IsAtLocation extends cfg.ai.Decorator {
    public IsAtLocation(JsonObject __json__) { 
        super(__json__);
        acceptableRadius = __json__.get("acceptable_radius").getAsFloat();
        keyboardKey = __json__.get("keyboard_key").getAsString();
        inverseCondition = __json__.get("inverse_condition").getAsBoolean();
    }

    public IsAtLocation(int id, String node_name, cfg.ai.EFlowAbortMode flow_abort_mode, float acceptable_radius, String keyboard_key, boolean inverse_condition ) {
        super(id, node_name, flow_abort_mode);
        this.acceptableRadius = acceptable_radius;
        this.keyboardKey = keyboard_key;
        this.inverseCondition = inverse_condition;
    }

    public static IsAtLocation deserializeIsAtLocation(JsonObject __json__) {
        return new IsAtLocation(__json__);
    }

    public final float acceptableRadius;
    public final String keyboardKey;
    public final boolean inverseCondition;

    public static final int ID = 1255972344;

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
        + "flowAbortMode:" + flowAbortMode + ","
        + "acceptableRadius:" + acceptableRadius + ","
        + "keyboardKey:" + keyboardKey + ","
        + "inverseCondition:" + inverseCondition + ","
        + "}";
    }
}
