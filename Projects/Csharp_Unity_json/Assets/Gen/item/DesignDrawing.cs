
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



namespace cfg.item
{

/// <summary>
/// 
/// </summary>
public sealed partial class DesignDrawing :  item.ItemExtra 
{
    public DesignDrawing(JSONNode _json)  : base(_json) 
    {
        { var _json1 = _json["learn_component_id"]; if(!_json1.IsArray) { throw new SerializationException(); } LearnComponentId = new System.Collections.Generic.List<int>(_json1.Count); foreach(JSONNode __e in _json1.Children) { int __v;  { if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e; }  LearnComponentId.Add(__v); }   }
    }

    public DesignDrawing(int id, System.Collections.Generic.List<int> learn_component_id )  : base(id) 
    {
        this.LearnComponentId = learn_component_id;
    }

    public static DesignDrawing DeserializeDesignDrawing(JSONNode _json)
    {
        return new item.DesignDrawing(_json);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly System.Collections.Generic.List<int> LearnComponentId;

    public const int ID = -1679179579;
    public override int GetTypeId() => ID;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "LearnComponentId:" + Bright.Common.StringUtil.CollectionToString(LearnComponentId) + ","
        + "}";
    }
    }
}

