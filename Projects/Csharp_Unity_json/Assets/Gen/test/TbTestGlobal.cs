
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



namespace cfg.test
{

/// <summary>
/// 
/// </summary>
public sealed partial class TbTestGlobal
{

     private readonly test.TestGlobal _data;

    public TbTestGlobal(JSONNode _json)
    {
        if(!_json.IsArray)
        {
            throw new SerializationException();
        }
        if (_json.Count != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = test.TestGlobal.DeserializeTestGlobal(_json[0]);
    }

    /// <summary>
    /// 
    /// </summary>
     public int UnlockEquip => _data.UnlockEquip;
    /// <summary>
    /// 
    /// </summary>
     public int UnlockHero => _data.UnlockHero;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
