
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.error;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class ErrorInfo {
    public ErrorInfo(JsonObject __json__) { 
        code = __json__.get("code").getAsString();
        desc = __json__.get("desc").getAsString();
        style = cfg.error.ErrorStyle.deserializeErrorStyle(__json__.get("style").getAsJsonObject());
    }

    public ErrorInfo(String code, String desc, cfg.error.ErrorStyle style ) {
        this.code = code;
        this.desc = desc;
        this.style = style;
    }

    public static ErrorInfo deserializeErrorInfo(JsonObject __json__) {
        return new ErrorInfo(__json__);
    }

    public final String code;
    public final String desc;
    public final cfg.error.ErrorStyle style;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (style != null) {style.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "code:" + code + ","
        + "desc:" + desc + ","
        + "style:" + style + ","
        + "}";
    }
}
