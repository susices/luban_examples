
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.error
{

public sealed class ErrorStyleMsgbox :  error.ErrorStyle 
{
    public ErrorStyleMsgbox(ByteBuf _buf)  : base(_buf) 
    {
        BtnName = _buf.ReadString();
        Operation = (error.EOperation)_buf.ReadInt();
    }

    public static ErrorStyleMsgbox DeserializeErrorStyleMsgbox(ByteBuf _buf)
    {
        return new error.ErrorStyleMsgbox(_buf);
    }

    public string BtnName { get; private set; }
    public error.EOperation Operation { get; private set; }

    public const int ID = -1920482343;
    public override int GetTypeId() => ID;

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
        + "BtnName:" + BtnName + ","
        + "Operation:" + Operation + ","
        + "}";
    }
    }

}
