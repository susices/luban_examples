
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
public sealed partial class TbSingleton
{

     private readonly test.DemoSingletonType _data;

    public TbSingleton(JSONNode _json)
    {
        if(!_json.IsArray)
        {
            throw new SerializationException();
        }
        if (_json.Count != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = test.DemoSingletonType.DeserializeDemoSingletonType(_json[0]);
    }

    /// <summary>
    /// 
    /// </summary>
     public int Id => _data.Id;
    /// <summary>
    /// 
    /// </summary>
     public string Name => _data.Name;
    /// <summary>
    /// 
    /// </summary>
     public test.DemoDynamic Date => _data.Date;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
