
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;


public final class TbTestIndex {
    private final java.util.HashMap<Integer, cfg.test.TestIndex> _dataMap;
    private final java.util.ArrayList<cfg.test.TestIndex> _dataList;
    
    public TbTestIndex(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestIndex>();
        _dataList = new java.util.ArrayList<cfg.test.TestIndex>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.TestIndex _v;
            _v = new cfg.test.TestIndex(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestIndex> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestIndex> getDataList() { return _dataList; }

    public cfg.test.TestIndex get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.TestIndex v : _dataList) {
            v.resolve(_tables);
        }
    }

}