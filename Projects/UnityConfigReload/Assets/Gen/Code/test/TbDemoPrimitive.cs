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
   
public partial class TbDemoPrimitive
{
    private Dictionary<int, test.DemoPrimitiveTypesTable> _dataMap;
    private List<test.DemoPrimitiveTypesTable> _dataList;
    
    public TbDemoPrimitive(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.DemoPrimitiveTypesTable>();
        _dataList = new List<test.DemoPrimitiveTypesTable>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.DemoPrimitiveTypesTable _v;
            _v = test.DemoPrimitiveTypesTable.DeserializeDemoPrimitiveTypesTable(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.X4, _v);
        }
        PostInit();
    }

    public Dictionary<int, test.DemoPrimitiveTypesTable> DataMap => _dataMap;
    public List<test.DemoPrimitiveTypesTable> DataList => _dataList;

    public test.DemoPrimitiveTypesTable GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.DemoPrimitiveTypesTable Get(int key) => _dataMap[key];
    public test.DemoPrimitiveTypesTable this[int key] => _dataMap[key];

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
        var reloadMap = new TbDemoPrimitive(_buf);
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