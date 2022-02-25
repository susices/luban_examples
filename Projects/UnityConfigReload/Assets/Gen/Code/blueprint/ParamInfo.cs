//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.blueprint
{

public sealed partial class ParamInfo :  Bright.Config.BeanBase 
{
    public ParamInfo(ByteBuf _buf) 
    {
        Name = _buf.ReadString();
        Type = _buf.ReadString();
        IsRef = _buf.ReadBool();
        PostInit();
    }

    public static ParamInfo DeserializeParamInfo(ByteBuf _buf)
    {
        return new blueprint.ParamInfo(_buf);
    }

    public string Name { get; private set; }
    public string Type { get; private set; }
    public bool IsRef { get; private set; }

    public const int __ID__ = -729799392;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(ParamInfo reloadData)
    {
        //Luban.Job.Common.Types.TString
        Name = reloadData.Name;
        //Luban.Job.Common.Types.TString
        Type = reloadData.Type;
        //Luban.Job.Common.Types.TBool
        IsRef = reloadData.IsRef;
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Type:" + Type + ","
        + "IsRef:" + IsRef + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
