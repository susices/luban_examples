
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.l10n;

import com.google.gson.JsonElement;


public final class TbPatchDemo {
    private final java.util.HashMap<Integer, cfg.l10n.PatchDemo> _dataMap;
    private final java.util.ArrayList<cfg.l10n.PatchDemo> _dataList;
    
    public TbPatchDemo(JsonElement __json__) {
        _dataMap = new java.util.HashMap<Integer, cfg.l10n.PatchDemo>();
        _dataList = new java.util.ArrayList<cfg.l10n.PatchDemo>();
        
        for(var _e_ : __json__.getAsJsonArray()) {
            cfg.l10n.PatchDemo _v;
            _v = new cfg.l10n.PatchDemo(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.l10n.PatchDemo> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.l10n.PatchDemo> getDataList() { return _dataList; }

    public cfg.l10n.PatchDemo get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.l10n.PatchDemo v : _dataList) {
            v.resolve(_tables);
        }
    }

}