
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;
using System.Text.Json;



namespace cfg.ai
{

/// <summary>
/// 
/// </summary>
public abstract partial class KeyQueryOperator :  Bright.Config.BeanBase 
{
    public KeyQueryOperator(JsonElement _buf) 
    {
    }

    public KeyQueryOperator() 
    {
    }

    public static KeyQueryOperator DeserializeKeyQueryOperator(JsonElement _buf)
    {
        switch (_buf.GetProperty("__type__").GetString())
        {
            case "IsSet": return new ai.IsSet(_buf);
            case "IsNotSet": return new ai.IsNotSet(_buf);
            case "BinaryOperator": return new ai.BinaryOperator(_buf);
            default: throw new SerializationException();
        }
    }



    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "}";
    }
    }
}

