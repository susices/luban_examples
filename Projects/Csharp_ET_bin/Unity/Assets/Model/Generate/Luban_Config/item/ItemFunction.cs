
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.item
{

public sealed partial class ItemFunction :  Bright.Config.BeanBase 
{
    public ItemFunction(ByteBuf _buf) 
    {
        MinorType = (item.EMinorType)_buf.ReadInt();
        FuncType = (item.EItemFunctionType)_buf.ReadInt();
        Method = _buf.ReadString();
        CloseBagUi = _buf.ReadBool();
    }

    public ItemFunction(item.EMinorType minor_type, item.EItemFunctionType func_type, string method, bool close_bag_ui ) 
    {
        this.MinorType = minor_type;
        this.FuncType = func_type;
        this.Method = method;
        this.CloseBagUi = close_bag_ui;
    }

    public static ItemFunction DeserializeItemFunction(ByteBuf _buf)
    {
        return new item.ItemFunction(_buf);
    }

    public readonly item.EMinorType MinorType;
    public readonly item.EItemFunctionType FuncType;
    public readonly string Method;
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

