
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import com.google.gson.JsonElement;


public final class TbDemoGroup_S {
    private final java.util.HashMap<Integer, cfg.test.DemoGroup> _dataMap;
    private final java.util.ArrayList<cfg.test.DemoGroup> _dataList;
    
    public TbDemoGroup_S(JsonElement __json__) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.DemoGroup>();
        _dataList = new java.util.ArrayList<cfg.test.DemoGroup>();
        
        for(var _e_ : __json__.getAsJsonArray()) {
            cfg.test.DemoGroup _v;
            _v = new cfg.test.DemoGroup(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.DemoGroup> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.DemoGroup> getDataList() { return _dataList; }

    public cfg.test.DemoGroup get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.DemoGroup v : _dataList) {
            v.resolve(_tables);
        }
    }

}