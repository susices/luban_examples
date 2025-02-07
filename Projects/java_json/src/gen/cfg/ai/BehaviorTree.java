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



public final class BehaviorTree {
    public BehaviorTree(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        name = __json__.get("name").getAsString();
        desc = __json__.get("desc").getAsString();
        blackboardId = __json__.get("blackboard_id").getAsString();
        root = cfg.ai.ComposeNode.deserializeComposeNode(__json__.get("root").getAsJsonObject());
    }

    public BehaviorTree(int id, String name, String desc, String blackboard_id, cfg.ai.ComposeNode root ) {
        this.id = id;
        this.name = name;
        this.desc = desc;
        this.blackboardId = blackboard_id;
        this.root = root;
    }

    public static BehaviorTree deserializeBehaviorTree(JsonObject __json__) {
        return new BehaviorTree(__json__);
    }

    public final int id;
    public final String name;
    public final String desc;
    public final String blackboardId;
    public cfg.ai.Blackboard blackboardId_Ref;
    public final cfg.ai.ComposeNode root;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        this.blackboardId_Ref = ((cfg.ai.TbBlackboard)_tables.get("ai.TbBlackboard")).get(blackboardId);
        if (root != null) {root.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "blackboardId:" + blackboardId + ","
        + "root:" + root + ","
        + "}";
    }
}
