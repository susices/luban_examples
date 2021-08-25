
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



/**
 * 道具
 */
public final class Item {
    public Item(JsonObject __json__) { 
        id = __json__.get("id").getAsInt();
        name = __json__.get("name").getAsString();
        majorType = cfg.item.EMajorType.valueOf(__json__.get("major_type").getAsInt());
        minorType = cfg.item.EMinorType.valueOf(__json__.get("minor_type").getAsInt());
        maxPileNum = __json__.get("max_pile_num").getAsInt();
        quality = cfg.item.EItemQuality.valueOf(__json__.get("quality").getAsInt());
        icon = __json__.get("icon").getAsString();
        iconBackgroud = __json__.get("icon_backgroud").getAsString();
        iconMask = __json__.get("icon_mask").getAsString();
        desc = __json__.get("desc").getAsString();
        showOrder = __json__.get("show_order").getAsInt();
        quantifier = __json__.get("quantifier").getAsString();
        showInBag = __json__.get("show_in_bag").getAsBoolean();
        minShowLevel = __json__.get("min_show_level").getAsInt();
        batchUsable = __json__.get("batch_usable").getAsBoolean();
        progressTimeWhenUse = __json__.get("progress_time_when_use").getAsFloat();
        showHintWhenUse = __json__.get("show_hint_when_use").getAsBoolean();
        droppable = __json__.get("droppable").getAsBoolean();
        { if (__json__.has("price") && !__json__.get("price").isJsonNull()) { price = __json__.get("price").getAsInt(); } else { price = null; } }
        useType = cfg.item.EUseType.valueOf(__json__.get("use_type").getAsInt());
        { if (__json__.has("level_up_id") && !__json__.get("level_up_id").isJsonNull()) { levelUpId = __json__.get("level_up_id").getAsInt(); } else { levelUpId = null; } }
    }

    public Item(int id, String name, cfg.item.EMajorType major_type, cfg.item.EMinorType minor_type, int max_pile_num, cfg.item.EItemQuality quality, String icon, String icon_backgroud, String icon_mask, String desc, int show_order, String quantifier, boolean show_in_bag, int min_show_level, boolean batch_usable, float progress_time_when_use, boolean show_hint_when_use, boolean droppable, Integer price, cfg.item.EUseType use_type, Integer level_up_id ) {
        this.id = id;
        this.name = name;
        this.majorType = major_type;
        this.minorType = minor_type;
        this.maxPileNum = max_pile_num;
        this.quality = quality;
        this.icon = icon;
        this.iconBackgroud = icon_backgroud;
        this.iconMask = icon_mask;
        this.desc = desc;
        this.showOrder = show_order;
        this.quantifier = quantifier;
        this.showInBag = show_in_bag;
        this.minShowLevel = min_show_level;
        this.batchUsable = batch_usable;
        this.progressTimeWhenUse = progress_time_when_use;
        this.showHintWhenUse = show_hint_when_use;
        this.droppable = droppable;
        this.price = price;
        this.useType = use_type;
        this.levelUpId = level_up_id;
    }

    public static Item deserializeItem(JsonObject __json__) {
        return new Item(__json__);
    }

    /**
     * 道具id
     */
    public final int id;
    public final String name;
    public final cfg.item.EMajorType majorType;
    public final cfg.item.EMinorType minorType;
    public final int maxPileNum;
    public final cfg.item.EItemQuality quality;
    public final String icon;
    public final String iconBackgroud;
    public final String iconMask;
    public final String desc;
    public final int showOrder;
    public final String quantifier;
    public final boolean showInBag;
    public final int minShowLevel;
    public final boolean batchUsable;
    public final float progressTimeWhenUse;
    public final boolean showHintWhenUse;
    public final boolean droppable;
    public final Integer price;
    public final cfg.item.EUseType useType;
    public final Integer levelUpId;


    public void resolve(java.util.HashMap<String, Object> _tables) {
    }

    @Override
    public String toString() {
        return "{ "
        + "id:" + id + ","
        + "name:" + name + ","
        + "majorType:" + majorType + ","
        + "minorType:" + minorType + ","
        + "maxPileNum:" + maxPileNum + ","
        + "quality:" + quality + ","
        + "icon:" + icon + ","
        + "iconBackgroud:" + iconBackgroud + ","
        + "iconMask:" + iconMask + ","
        + "desc:" + desc + ","
        + "showOrder:" + showOrder + ","
        + "quantifier:" + quantifier + ","
        + "showInBag:" + showInBag + ","
        + "minShowLevel:" + minShowLevel + ","
        + "batchUsable:" + batchUsable + ","
        + "progressTimeWhenUse:" + progressTimeWhenUse + ","
        + "showHintWhenUse:" + showHintWhenUse + ","
        + "droppable:" + droppable + ","
        + "price:" + price + ","
        + "useType:" + useType + ","
        + "levelUpId:" + levelUpId + ","
        + "}";
    }
}
