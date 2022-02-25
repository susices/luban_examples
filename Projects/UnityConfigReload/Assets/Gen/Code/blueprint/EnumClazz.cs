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



namespace cfg.blueprint
{

public sealed partial class EnumClazz :  blueprint.Clazz 
{
    public EnumClazz(ByteBuf _buf)  : base(_buf) 
    {
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);Enums = new System.Collections.Generic.List<blueprint.EnumField>(n);for(var i = 0 ; i < n ; i++) { blueprint.EnumField _e;  _e = blueprint.EnumField.DeserializeEnumField(_buf); Enums.Add(_e);}}
        PostInit();
    }

    public static EnumClazz DeserializeEnumClazz(ByteBuf _buf)
    {
        return new blueprint.EnumClazz(_buf);
    }

    public System.Collections.Generic.List<blueprint.EnumField> Enums { get; private set; }

    public const int __ID__ = 1827364892;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        foreach(var _e in Enums) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
        foreach(var _e in Enums) { _e?.TranslateText(translator); }
    }

    public void Reload(EnumClazz reloadData)
    {
        if(Enums.Count<reloadData.Enums.Count)
        {
            Enums.AddRange(new List<blueprint.EnumField>(reloadData.Enums.Count-Enums.Count));
        }else if(Enums.Count>reloadData.Enums.Count)
        {
            Enums.RemoveRange(reloadData.Enums.Count, Enums.Count-reloadData.Enums.Count);
        }
        for (int i = 0; i < reloadData.Enums.Count; i++)
        {
            Enums[i] = reloadData.Enums[i];
        }
    }

    public override string ToString()
    {
        return "{ "
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Parents:" + Bright.Common.StringUtil.CollectionToString(Parents) + ","
        + "Methods:" + Bright.Common.StringUtil.CollectionToString(Methods) + ","
        + "Enums:" + Bright.Common.StringUtil.CollectionToString(Enums) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
