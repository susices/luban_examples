
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.mail
{
   
public sealed class TbSystemMail
{
    private readonly Dictionary<int, mail.SystemMail> _dataMap;
    private readonly List<mail.SystemMail> _dataList;
    
    public TbSystemMail(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, mail.SystemMail>();
        _dataList = new List<mail.SystemMail>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            mail.SystemMail _v;
            _v = mail.SystemMail.DeserializeSystemMail(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public Dictionary<int, mail.SystemMail> DataMap => _dataMap;
    public List<mail.SystemMail> DataList => _dataList;

    public mail.SystemMail GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public mail.SystemMail Get(int key) => _dataMap[key];
    public mail.SystemMail this[int key] => _dataMap[key];

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