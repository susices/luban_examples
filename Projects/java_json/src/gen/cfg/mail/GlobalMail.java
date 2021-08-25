
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.mail;

import com.google.gson.JsonElement;
import com.google.gson.JsonObject;



public final class GlobalMail {
    public GlobalMail(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        title = __json__.get("title").getAsString();
        sender = __json__.get("sender").getAsString();
        content = __json__.get("content").getAsString();
        { var _json0_ = __json__.get("award").getAsJsonArray(); award = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  award.add(__v); }   }
        allServer = __json__.get("all_server").getAsBoolean();
        { var _json0_ = __json__.get("server_list").getAsJsonArray(); serverList = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement __e : _json0_) { int __v;  __v = __e.getAsInt();  serverList.add(__v); }   }
        platform = __json__.get("platform").getAsString();
        channel = __json__.get("channel").getAsString();
        minMaxLevel = new cfg.condition.MinMaxLevel(__json__.get("min_max_level").getAsJsonObject());
        registerTime = new cfg.condition.TimeRange(__json__.get("register_time").getAsJsonObject());
        mailTime = new cfg.condition.TimeRange(__json__.get("mail_time").getAsJsonObject());
    }

    public GlobalMail(int id, String title, String sender, String content, java.util.ArrayList<Integer> award, boolean all_server, java.util.ArrayList<Integer> server_list, String platform, String channel, cfg.condition.MinMaxLevel min_max_level, cfg.condition.TimeRange register_time, cfg.condition.TimeRange mail_time ) {
        this.id = id;
        this.title = title;
        this.sender = sender;
        this.content = content;
        this.award = award;
        this.allServer = all_server;
        this.serverList = server_list;
        this.platform = platform;
        this.channel = channel;
        this.minMaxLevel = min_max_level;
        this.registerTime = register_time;
        this.mailTime = mail_time;
    }

    public static GlobalMail deserializeGlobalMail(JsonObject __json__) {
        return new GlobalMail(__json__);
    }

    public final int id;
    public final String title;
    public final String sender;
    public final String content;
    public final java.util.ArrayList<Integer> award;
    public final boolean allServer;
    public final java.util.ArrayList<Integer> serverList;
    public final String platform;
    public final String channel;
    public final cfg.condition.MinMaxLevel minMaxLevel;
    public final cfg.condition.TimeRange registerTime;
    public final cfg.condition.TimeRange mailTime;


    public void resolve(java.util.HashMap<String, Object> _tables) {
        if (minMaxLevel != null) {minMaxLevel.resolve(_tables);}
        if (registerTime != null) {registerTime.resolve(_tables);}
        if (mailTime != null) {mailTime.resolve(_tables);}
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "title:" + title + ","
        + "sender:" + sender + ","
        + "content:" + content + ","
        + "award:" + award + ","
        + "allServer:" + allServer + ","
        + "serverList:" + serverList + ","
        + "platform:" + platform + ","
        + "channel:" + channel + ","
        + "minMaxLevel:" + minMaxLevel + ","
        + "registerTime:" + registerTime + ","
        + "mailTime:" + mailTime + ","
        + "}";
    }
}
