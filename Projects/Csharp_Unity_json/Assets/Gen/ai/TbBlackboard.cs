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



namespace cfg.ai
{

public sealed class TbBlackboard
{
    private readonly Dictionary<string, ai.Blackboard> _dataMap;
    private readonly List<ai.Blackboard> _dataList;
    
    public TbBlackboard(JSONNode _json)
    {
        _dataMap = new Dictionary<string, ai.Blackboard>();
        _dataList = new List<ai.Blackboard>();
        
        foreach(JSONNode _row in _json.Children)
        {
            var _v = ai.Blackboard.DeserializeBlackboard(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Name, _v);
        }
    }

    public Dictionary<string, ai.Blackboard> DataMap => _dataMap;
    public List<ai.Blackboard> DataList => _dataList;

    public ai.Blackboard GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ai.Blackboard Get(string key) => _dataMap[key];
    public ai.Blackboard this[string key] => _dataMap[key];

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