//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test2
{

/// <summary>
/// 矩形
/// </summary>
public sealed partial class Rectangle :  test.Shape 
{
    public Rectangle(ByteBuf _buf)  : base(_buf) 
    {
        Width = _buf.ReadFloat();
        Height = _buf.ReadFloat();
        PostInit();
    }

    public static Rectangle DeserializeRectangle(ByteBuf _buf)
    {
        return new test2.Rectangle(_buf);
    }

    /// <summary>
    /// 宽度
    /// </summary>
    public float Width { get; private set; }
    /// <summary>
    /// 高度
    /// </summary>
    public float Height { get; private set; }

    public const int __ID__ = 694982337;
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

    public void Reload(Rectangle reloadData)
    {
        typeof(Rectangle).GetProperty("Width").SetValue(this, reloadData.Width);
        typeof(Rectangle).GetProperty("Height").SetValue(this, reloadData.Height);
    }

    public override string ToString()
    {
        return "{ "
        + "Width:" + Width + ","
        + "Height:" + Height + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
