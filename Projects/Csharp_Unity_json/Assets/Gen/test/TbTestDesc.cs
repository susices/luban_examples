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



namespace cfg.test
{

public sealed class TbTestDesc
{
    private readonly Dictionary<int, test.TestDesc> _dataMap;
    private readonly List<test.TestDesc> _dataList;
    
    public TbTestDesc(JSONNode _json)
    {
        _dataMap = new Dictionary<int, test.TestDesc>();
        _dataList = new List<test.TestDesc>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = test.TestDesc.DeserializeTestDesc(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, test.TestDesc> DataMap => _dataMap;
    public List<test.TestDesc> DataList => _dataList;

    public test.TestDesc GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestDesc Get(int key) => _dataMap[key];
    public test.TestDesc this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
}

}