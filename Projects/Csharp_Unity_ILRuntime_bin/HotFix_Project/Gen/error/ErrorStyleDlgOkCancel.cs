
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

public sealed partial class ErrorStyleDlgOkCancel :  error.ErrorStyle 
{
    public ErrorStyleDlgOkCancel(ByteBuf _buf)  : base(_buf) 
    {
        Btn1Name = _buf.ReadString();
        Btn2Name = _buf.ReadString();
    }

    public ErrorStyleDlgOkCancel(string btn1_name, string btn2_name )  : base() 
    {
        this.Btn1Name = btn1_name;
        this.Btn2Name = btn2_name;
    }

    public static ErrorStyleDlgOkCancel DeserializeErrorStyleDlgOkCancel(ByteBuf _buf)
    {
        return new error.ErrorStyleDlgOkCancel(_buf);
    }

    public readonly string Btn1Name;
    public readonly string Btn2Name;

    public const int ID = 971221414;
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
        + "Btn1Name:" + Btn1Name + ","
        + "Btn2Name:" + Btn2Name + ","
        + "}";
    }
    }

}

