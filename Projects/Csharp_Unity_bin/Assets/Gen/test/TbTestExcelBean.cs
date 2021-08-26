
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
   
public sealed class TbTestExcelBean
{
    private readonly Dictionary<int, test.TestExcelBean1> _dataMap;
    private readonly List<test.TestExcelBean1> _dataList;
    
    public TbTestExcelBean(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, test.TestExcelBean1>();
        _dataList = new List<test.TestExcelBean1>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            test.TestExcelBean1 _v;
            _v = test.TestExcelBean1.DeserializeTestExcelBean1(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.X1, _v);
        }
    }

    public Dictionary<int, test.TestExcelBean1> DataMap => _dataMap;
    public List<test.TestExcelBean1> DataList => _dataList;

    public test.TestExcelBean1 GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public test.TestExcelBean1 Get(int key) => _dataMap[key];
    public test.TestExcelBean1 this[int key] => _dataMap[key];

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