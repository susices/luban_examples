
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.blueprint;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class Interface extends cfg.blueprint.Clazz {
    public Interface(JsonObject __json__) { 
        super(__json__);
    }

    public Interface(String name, String desc, java.util.ArrayList<cfg.blueprint.Clazz> parents, java.util.ArrayList<cfg.blueprint.Method> methods ) {
        super(name, desc, parents, methods);
    }

    public static Interface deserializeInterface(JsonObject __json__) {
        return new Interface(__json__);
    }


    public static final int ID = 2114170750;

    @Override
    public int getTypeId() { return ID; }

    @Override
    public void resolve(java.util.HashMap<String, Object> _tables) {
        super.resolve(_tables);
    }

    @Override
    public String toString() {
        return "{ "
        + "name:" + name + ","
        + "desc:" + desc + ","
        + "parents:" + parents + ","
        + "methods:" + methods + ","
        + "}";
    }
}
