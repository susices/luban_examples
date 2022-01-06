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



namespace cfg.ai
{

public abstract class Service :  ai.Node 
{
    public Service(JSONNode _json)  : base(_json) 
    {
    }

    public Service(int id, string node_name )  : base(id,node_name) 
    {
    }

    public static Service DeserializeService(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "UeSetDefaultFocus": return new ai.UeSetDefaultFocus(_json);
            case "ExecuteTimeStatistic": return new ai.ExecuteTimeStatistic(_json);
            case "ChooseTarget": return new ai.ChooseTarget(_json);
            case "KeepFaceTarget": return new ai.KeepFaceTarget(_json);
            case "GetOwnerPlayer": return new ai.GetOwnerPlayer(_json);
            case "UpdateDailyBehaviorProps": return new ai.UpdateDailyBehaviorProps(_json);
            default: throw new SerializationException();
        }
    }



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
        + "NodeName:" + NodeName + ","
        + "}";
    }
    }
}
