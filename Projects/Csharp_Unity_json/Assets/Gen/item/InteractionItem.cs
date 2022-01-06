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

public sealed class InteractionItem :  item.ItemExtra 
{
    public InteractionItem(JSONNode _json)  : base(_json) 
    {
        { var _j = _json["attack_num"]; if (_j.Tag != JSONNodeType.None && _j.Tag != JSONNodeType.NullValue) { { if(!_j.IsNumber) { throw new SerializationException(); }  AttackNum = _j; } } else { AttackNum = null; } }
        { if(!_json["holding_static_mesh"].IsString) { throw new SerializationException(); }  HoldingStaticMesh = _json["holding_static_mesh"]; }
        { if(!_json["holding_static_mesh_mat"].IsString) { throw new SerializationException(); }  HoldingStaticMeshMat = _json["holding_static_mesh_mat"]; }
    }

    public InteractionItem(int id, int? attack_num, string holding_static_mesh, string holding_static_mesh_mat )  : base(id) 
    {
        this.AttackNum = attack_num;
        this.HoldingStaticMesh = holding_static_mesh;
        this.HoldingStaticMeshMat = holding_static_mesh_mat;
    }

    public static InteractionItem DeserializeInteractionItem(JSONNode _json)
    {
        return new item.InteractionItem(_json);
    }

    public int? AttackNum { get; private set; }
    public string HoldingStaticMesh { get; private set; }
    public string HoldingStaticMeshMat { get; private set; }

    public const int __ID__ = 640937802;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "AttackNum:" + AttackNum + ","
        + "HoldingStaticMesh:" + HoldingStaticMesh + ","
        + "HoldingStaticMeshMat:" + HoldingStaticMeshMat + ","
        + "}";
    }
    }
}
