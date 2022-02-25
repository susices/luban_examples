//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using System.Linq;



namespace cfg.ai
{

public abstract partial class Service :  ai.Node 
{
    public Service(ByteBuf _buf)  : base(_buf) 
    {
        PostInit();
    }

    public static Service DeserializeService(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case ai.UeSetDefaultFocus.__ID__: return new ai.UeSetDefaultFocus(_buf);
            case ai.ExecuteTimeStatistic.__ID__: return new ai.ExecuteTimeStatistic(_buf);
            case ai.ChooseTarget.__ID__: return new ai.ChooseTarget(_buf);
            case ai.KeepFaceTarget.__ID__: return new ai.KeepFaceTarget(_buf);
            case ai.GetOwnerPlayer.__ID__: return new ai.GetOwnerPlayer(_buf);
            case ai.UpdateDailyBehaviorProps.__ID__: return new ai.UpdateDailyBehaviorProps(_buf);
            default: throw new SerializationException();
        }
    }



    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public void Reload(Service reloadData)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "NodeName:" + NodeName + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
