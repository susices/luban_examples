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

public sealed partial class TestScriptableObject :  Bright.Config.BeanBase 
{
    public TestScriptableObject(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Desc = _buf.ReadString();
        Rate = _buf.ReadFloat();
        Num = _buf.ReadInt();
        V2 = _buf.ReadVector2();
        V3 = _buf.ReadVector3();
        V4 = _buf.ReadVector4();
        PostInit();
    }

    public static TestScriptableObject DeserializeTestScriptableObject(ByteBuf _buf)
    {
        return new test.TestScriptableObject(_buf);
    }

    public int Id { get; private set; }
    public string Desc { get; private set; }
    public float Rate { get; private set; }
    public int Num { get; private set; }
    public System.Numerics.Vector2 V2 { get; private set; }
    public System.Numerics.Vector3 V3 { get; private set; }
    public System.Numerics.Vector4 V4 { get; private set; }

    public const int __ID__ = -1896814350;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Desc:" + Desc + ","
        + "Rate:" + Rate + ","
        + "Num:" + Num + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
