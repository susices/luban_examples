
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.role;

import bright.serialization.*;


/**
 * 
 */
public final class TbRoleLevelExpAttr
{
    private final java.util.HashMap<Integer, cfg.role.LevelExpAttr> _dataMap;
    private final java.util.ArrayList<cfg.role.LevelExpAttr> _dataList;
    
    public TbRoleLevelExpAttr(ByteBuf _buf)
    {
        _dataMap = new java.util.HashMap<Integer, cfg.role.LevelExpAttr>();
        _dataList = new java.util.ArrayList<cfg.role.LevelExpAttr>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n)
        {
            cfg.role.LevelExpAttr _v;
            _v = cfg.role.LevelExpAttr.deserializeLevelExpAttr(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.level, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.role.LevelExpAttr> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.role.LevelExpAttr> getDataList() { return _dataList; }

    public cfg.role.LevelExpAttr get(int key) { return _dataMap.get(key); }

    public void resolve(java.util.HashMap<String, Object> _tables)
    {
        for(cfg.role.LevelExpAttr v : _dataList)
        {
            v.resolve(_tables);
        }
    }

}
