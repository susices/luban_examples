
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



namespace cfg.item
{

/// <summary>
/// 
/// </summary>
public sealed partial class ItemFunction :  Bright.Config.BeanBase 
{
    public ItemFunction(JsonElement _buf) 
    {
        MinorType = (item.EMinorType)_buf.GetProperty("minor_type").GetInt32();
        FuncType = (item.EItemFunctionType)_buf.GetProperty("func_type").GetInt32();
        Method = _buf.GetProperty("method").GetString();
        CloseBagUi = _buf.GetProperty("close_bag_ui").GetBoolean();
    }

    public ItemFunction(item.EMinorType minor_type, item.EItemFunctionType func_type, string method, bool close_bag_ui ) 
    {
        this.MinorType = minor_type;
        this.FuncType = func_type;
        this.Method = method;
        this.CloseBagUi = close_bag_ui;
    }

    public static ItemFunction DeserializeItemFunction(JsonElement _buf)
    {
        return new item.ItemFunction(_buf);
    }

    /// <summary>
    /// 
    /// </summary>
    public readonly item.EMinorType MinorType;
    /// <summary>
    /// 
    /// </summary>
    public readonly item.EItemFunctionType FuncType;
    /// <summary>
    /// 
    /// </summary>
    public readonly string Method;
    /// <summary>
    /// 
    /// </summary>
    public readonly bool CloseBagUi;

    public const int ID = 1205824294;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "MinorType:" + MinorType + ","
        + "FuncType:" + FuncType + ","
        + "Method:" + Method + ","
        + "CloseBagUi:" + CloseBagUi + ","
        + "}";
    }
    }
}

