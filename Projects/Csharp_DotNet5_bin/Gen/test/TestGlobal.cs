
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;
using System.Collections.Generic;



namespace cfg.test
{

public sealed partial class TestGlobal :  Bright.Config.BeanBase 
{
    public TestGlobal(ByteBuf _buf) 
    {
        UnlockEquip = _buf.ReadInt();
        UnlockHero = _buf.ReadInt();
    }

    public TestGlobal(int unlock_equip, int unlock_hero ) 
    {
        this.UnlockEquip = unlock_equip;
        this.UnlockHero = unlock_hero;
    }

    public static TestGlobal DeserializeTestGlobal(ByteBuf _buf)
    {
        return new test.TestGlobal(_buf);
    }

    public readonly int UnlockEquip;
    public readonly int UnlockHero;

    public const int ID = -12548655;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        OnResolveFinish(_tables);
    }

    partial void OnResolveFinish(Dictionary<string, object> _tables);

    public override string ToString()
    {
        return "{ "
        + "UnlockEquip:" + UnlockEquip + ","
        + "UnlockHero:" + UnlockHero + ","
        + "}";
    }
    }

}

