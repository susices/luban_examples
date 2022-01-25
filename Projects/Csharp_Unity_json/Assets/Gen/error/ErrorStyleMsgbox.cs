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



namespace cfg.error
{

public sealed partial class ErrorStyleMsgbox :  error.ErrorStyle 
{
    public ErrorStyleMsgbox(JSONNode _json)  : base(_json) 
    {
        { if(!_json["btn_name"].IsString) { throw new SerializationException(); }  BtnName = _json["btn_name"]; }
        { if(!_json["operation"].IsNumber) { throw new SerializationException(); }  Operation = (error.EOperation)_json["operation"].AsInt; }
        PostInit();
    }

    public ErrorStyleMsgbox(string btn_name, error.EOperation operation )  : base() 
    {
        this.BtnName = btn_name;
        this.Operation = operation;
        PostInit();
    }

    public static ErrorStyleMsgbox DeserializeErrorStyleMsgbox(JSONNode _json)
    {
        return new error.ErrorStyleMsgbox(_json);
    }

    public string BtnName { get; private set; }
    public error.EOperation Operation { get; private set; }

    public const int __ID__ = -1920482343;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "BtnName:" + BtnName + ","
        + "Operation:" + Operation + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}
}
