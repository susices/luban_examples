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
   
public partial class TbFullTypes
{
    private Dictionary<int, test.DemoType2> _dataMap;
    private List<test.DemoType2> _dataList;
    
    public TbFullTypes(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.DemoType2>();
        _dataList = new List<test.DemoType2>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.DemoType2 _v;
            _v = test.DemoType2.DeserializeDemoType2(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.X4, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.DemoType2> DataMap => _dataMap;
    public List<test.DemoType2> DataList => _dataList;

    public test.DemoType2 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DemoType2 Get(int key) => _dataMap[key];
    public test.DemoType2 this[int key] => _dataMap[key];

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
        var reloadMap = new TbFullTypes(_buf);
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