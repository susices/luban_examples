
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg.test;

import bright.serialization.*;


public final class TbTestExcelBean {
    private final java.util.HashMap<Integer, cfg.test.TestExcelBean1> _dataMap;
    private final java.util.ArrayList<cfg.test.TestExcelBean1> _dataList;
    
    public TbTestExcelBean(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestExcelBean1>();
        _dataList = new java.util.ArrayList<cfg.test.TestExcelBean1>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.TestExcelBean1 _v;
            _v = new cfg.test.TestExcelBean1(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.x1, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestExcelBean1> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestExcelBean1> getDataList() { return _dataList; }

    public cfg.test.TestExcelBean1 get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables) {
        for(cfg.test.TestExcelBean1 v : _dataList) {
            v.resolve(_tables);
        }
    }

}