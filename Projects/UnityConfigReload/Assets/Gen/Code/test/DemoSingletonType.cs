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



namespace cfg.test
{

public sealed partial class DemoSingletonType :  Bright.Config.BeanBase 
{
    public DemoSingletonType(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name_l10n_key = _buf.ReadString(); Name = _buf.ReadString();
        Date = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        PostInit();
    }

    public static DemoSingletonType DeserializeDemoSingletonType(ByteBuf _buf)
    {
        return new test.DemoSingletonType(_buf);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    //field.gen_text_key
    public string Name_l10n_key { get; private set; }
    public test.DemoDynamic Date { get; private set; }

    public const int __ID__ = 539196998;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        Date?.Resolve(_tables);
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Name = translator(Name_l10n_key, Name);
        Date?.TranslateText(translator);
    }

    public void Reload(DemoSingletonType reloadData)
    {
        Id = reloadData.Id;
        Name = reloadData.Name;
        Date = reloadData.Date;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Date:" + Date + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
