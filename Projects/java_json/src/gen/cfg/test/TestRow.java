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



public final class TestRow {
    public TestRow(JsonObject __json__) { 
        x = __json__.get("x").getAsInt();
        y = __json__.get("y").getAsBoolean();
        z = __json__.get("z").getAsString();
        a = new cfg.test.Test3(__json__.get("a").getAsJsonObject());
        { com.google.gson.JsonArray _json0_ = __json__.get("b").getAsJsonArray(); b = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  b.add(__v); }   }
    }

    public TestRow(int x, boolean y, String z, cfg.test.Test3 a, java.util.ArrayList<Integer> b ) {
        this.x = x;
        this.y = y;
        this.z = z;
        this.a = a;
        this.b = b;
    }

    public static TestRow deserializeTestRow(JsonObject __json__) {
        return new TestRow(__json__);
    }

    public final int x;
    public final boolean y;
    public final String z;
    public final cfg.test.Test3 a;
    public final java.util.ArrayList<Integer> b;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (a != null) {a.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "x:" + x + ","
        + "y:" + y + ","
        + "z:" + z + ","
        + "a:" + a + ","
        + "b:" + b + ","
        + "}";
    }
}
