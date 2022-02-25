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

public abstract partial class ItemBase :  Bright.Config.BeanBase 
{
    public ItemBase(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        Desc = _buf.ReadString();
        PostInit();
    }

    public static ItemBase DeserializeItemBase(ByteBuf _buf)
    {
        switch (_buf.ReadInt())
        {
            case test.Item.__ID__: return new test.Item(_buf);
            case test.Equipment.__ID__: return new test.Equipment(_buf);
            case test.Decorator.__ID__: return new test.Decorator(_buf);
            default: throw new SerializationException();
        }
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Desc { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public void Reload(ItemBase reloadData)
    {
        Id = reloadData.Id;
        Name = reloadData.Name;
        Desc = reloadData.Desc;
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
