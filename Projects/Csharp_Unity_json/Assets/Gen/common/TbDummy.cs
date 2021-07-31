
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace cfg.common
{

/// <summary>
/// 
/// </summary>
public sealed partial class TbDummy
{
    private readonly Dictionary<int, common.Dummy> _dataMap;
    private readonly List<common.Dummy> _dataList;
    
    public TbDummy(JSONNode _json)
    {
        _dataMap = new Dictionary<int, common.Dummy>();
        _dataList = new List<common.Dummy>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = common.Dummy.DeserializeDummy(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, common.Dummy> DataMap => _dataMap;
    public List<common.Dummy> DataList => _dataList;

    public common.Dummy GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public common.Dummy Get(int key) => _dataMap[key];
    public common.Dummy this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
