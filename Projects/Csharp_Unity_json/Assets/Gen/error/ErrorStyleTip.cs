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

public sealed class ErrorStyleTip :  error.ErrorStyle 
{
    public ErrorStyleTip(JSONNode _json)  : base(_json) 
    {
    }

    public ErrorStyleTip()  : base() 
    {
    }

    public static ErrorStyleTip DeserializeErrorStyleTip(JSONNode _json)
    {
        return new error.ErrorStyleTip(_json);
    }


    public const int __ID__ = 1915239884;
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
        + "}";
    }
    }
}
