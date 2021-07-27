
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



namespace cfg.error
{

/// <summary>
/// 
/// </summary>
public sealed partial class TbErrorInfo
{
    private readonly Dictionary<string, error.ErrorInfo> _dataMap;
    private readonly List<error.ErrorInfo> _dataList;
    
    public TbErrorInfo(JsonElement _buf)
    {
        _dataMap = new Dictionary<string, error.ErrorInfo>();
        _dataList = new List<error.ErrorInfo>();
        
        foreach(JsonElement _row in _buf.EnumerateArray())
        {
            var _v = error.ErrorInfo.DeserializeErrorInfo(_row);
            _dataList.Add(_v);
            _dataMap.Add(_v.Code, _v);
        }
    }

    public Dictionary<string, error.ErrorInfo> DataMap => _dataMap;
    public List<error.ErrorInfo> DataList => _dataList;

    public error.ErrorInfo GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public error.ErrorInfo Get(string key) => _dataMap[key];
    public error.ErrorInfo this[string key] => _dataMap[key];

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
