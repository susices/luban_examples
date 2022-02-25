//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace cfg.test
{
   
public partial class TbTestBeRef
{
    private Dictionary<int, test.TestBeRef> _dataMap;
    private List<test.TestBeRef> _dataList;
    
    public TbTestBeRef(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.TestBeRef>();
        _dataList = new List<test.TestBeRef>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.TestBeRef _v;
            _v = test.TestBeRef.DeserializeTestBeRef(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.TestBeRef> DataMap => _dataMap;
    public List<test.TestBeRef> DataList => _dataList;

    public test.TestBeRef GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestBeRef Get(int key) => _dataMap[key];
    public test.TestBeRef this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }

    public void Reload(ByteBuf _buf)
    {
        var reloadMap = new TbTestBeRef(_buf);
        foreach (var rowDataKey in this._dataMap.Keys.ToList())
        {
            if(!reloadMap._dataMap.ContainsKey(rowDataKey))
            {
                this._dataList.Remove(this._dataMap[rowDataKey]);
                this._dataMap.Remove(rowDataKey);
            }
        }

        foreach (var reloadData in reloadMap._dataMap)
        {
            if (this._dataMap.ContainsKey(reloadData.Key))
            {
                this._dataMap[reloadData.Key].Reload(reloadData.Value);
            }
            else
            {
                this._dataMap.Add(reloadData.Key,reloadData.Value);
                this._dataList.Add(reloadData.Value);
            }
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}