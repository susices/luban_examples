
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
   
public sealed partial class TbDefineFromExcelOne
{

     private readonly test.DefineFromExcelOne _data;

    public TbDefineFromExcelOne(ByteBuf _buf)
    {
        int n = _buf.ReadSize();
        if (n != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = test.DefineFromExcelOne.DeserializeDefineFromExcelOne(_buf);
    }


    /// <summary>
    /// 装备解锁等级_描述
    /// </summary>
     public int UnlockEquip => _data.UnlockEquip;
    /// <summary>
    /// 英雄解锁等级
    /// </summary>
     public int UnlockHero => _data.UnlockHero;
    /// <summary>
    /// 默认头像
    /// </summary>
     public string DefaultAvatar => _data.DefaultAvatar;
     public string DefaultItem => _data.DefaultItem;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
