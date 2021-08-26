
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.test
{

public sealed class TbTestString
{
    private readonly Dictionary<int, test.TestString> _dataMap;
    private readonly List<test.TestString> _dataList;
    
    public TbTestString(JsonElement _json)
    {
        _dataMap = new Dictionary<int, test.TestString>();
        _dataList = new List<test.TestString>();
        
        foreach(JsonElement _row in _json.EnumerateArray())
        {
            var _v = test.TestString.DeserializeTestString(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, test.TestString> DataMap => _dataMap;
    public List<test.TestString> DataList => _dataList;

    public test.TestString GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestString Get(int key) => _dataMap[key];
    public test.TestString this[int key] => _dataMap[key];

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