//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.test
{
   
public partial class TbItem2
{
    private Dictionary<int, test.ItemBase> _dataMap;
    private List<test.ItemBase> _dataList;
    
    public TbItem2(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.ItemBase>();
        _dataList = new List<test.ItemBase>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.ItemBase _v;
            _v = test.ItemBase.DeserializeItemBase(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.ItemBase> DataMap => _dataMap;
    public List<test.ItemBase> DataList => _dataList;

    public T GetOrDefaultAs<T>(int key) where T : test.ItemBase => _dataMap.TryGetValue(key, out var v) ? (T)v : null;
    public T GetAs<T>(int key) where T : test.ItemBase => (T)_dataMap[key];
    public test.ItemBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.ItemBase Get(int key) => _dataMap[key];
    public test.ItemBase this[int key] => _dataMap[key];

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
        var reloadMap = new TbItem2(_buf);
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