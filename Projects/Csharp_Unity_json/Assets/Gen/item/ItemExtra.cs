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



namespace cfg.item
{

public abstract class ItemExtra :  Bright.Config.BeanBase 
{
    public ItemExtra(JSONNode _json) 
    {
        { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
    }

    public ItemExtra(int id ) 
    {
        this.Id = id;
    }

    public static ItemExtra DeserializeItemExtra(JSONNode _json)
    {
        string type = _json["__type__"];
        switch (type)
        {
            case "TreasureBox": return new item.TreasureBox(_json);
            case "InteractionItem": return new item.InteractionItem(_json);
            case "Clothes": return new item.Clothes(_json);
            case "DesignDrawing": return new item.DesignDrawing(_json);
            case "Dymmy": return new item.Dymmy(_json);
            default: throw new SerializationException();
        }
    }

    public int Id { get; private set; }


    public virtual void Resolve(Dictionary<string, object> _tables)
    {
    }

    public virtual void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "}";
    }
    }
}
