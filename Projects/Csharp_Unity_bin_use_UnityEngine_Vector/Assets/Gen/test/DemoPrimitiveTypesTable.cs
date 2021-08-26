
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

public sealed partial class DemoPrimitiveTypesTable :  Bright.Config.BeanBase 
{
    public DemoPrimitiveTypesTable(ByteBuf _buf) 
    {
        X1 = _buf.ReadBool();
        X2 = _buf.ReadByte();
        X3 = _buf.ReadShort();
        X4 = _buf.ReadInt();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        X7 = _buf.ReadDouble();
        S1 = _buf.ReadString();
        S2_l10n_key = _buf.ReadString(); S2 = _buf.ReadString();
        V2 = _buf.ReadUnityVector2();
        V3 = _buf.ReadUnityVector3();
        V4 = _buf.ReadUnityVector4();
        T1 = _buf.ReadInt();
    }

    public static DemoPrimitiveTypesTable DeserializeDemoPrimitiveTypesTable(ByteBuf _buf)
    {
        return new test.DemoPrimitiveTypesTable(_buf);
    }

    public bool X1 {get; private set;}
    public byte X2 {get; private set;}
    public short X3 {get; private set;}
    public int X4 {get; private set;}
    public long X5 {get; private set;}
    public float X6 {get; private set;}
    public double X7 {get; private set;}
    public string S1 {get; private set;}
    public string S2 {get; private set;}
    public string S2_l10n_key {get;}
    public UnityEngine.Vector2 V2 {get; private set;}
    public UnityEngine.Vector3 V3 {get; private set;}
    public UnityEngine.Vector4 V4 {get; private set;}
    public int T1 {get; private set;}

    public const int ID = -370934083;
    public override int GetTypeId() => ID;

    public  void Resolve(Dictionary<string, object> _tables)
    {
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        S2 = translator(S2_l10n_key, S2);
    }

    public override string ToString()
    {
        return "{ "
        + "X1:" + X1 + ","
        + "X2:" + X2 + ","
        + "X3:" + X3 + ","
        + "X4:" + X4 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "X7:" + X7 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "}";
    }
    }

}
