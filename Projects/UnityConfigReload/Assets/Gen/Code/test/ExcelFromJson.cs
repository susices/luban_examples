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

public sealed partial class ExcelFromJson :  Bright.Config.BeanBase 
{
    public ExcelFromJson(ByteBuf _buf) 
    {
        X4 = _buf.ReadInt();
        X1 = _buf.ReadBool();
        X5 = _buf.ReadLong();
        X6 = _buf.ReadFloat();
        S1 = _buf.ReadString();
        S2_l10n_key = _buf.ReadString(); S2 = _buf.ReadString();
        V2 = _buf.ReadUnityVector2();
        V3 = _buf.ReadUnityVector3();
        V4 = _buf.ReadUnityVector4();
        T1 = _buf.ReadInt();
        X12 = test.DemoType1.DeserializeDemoType1(_buf);
        X13 = (test.DemoEnum)_buf.ReadInt();
        X14 = test.DemoDynamic.DeserializeDemoDynamic(_buf);
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K1 = new int[n];for(var i = 0 ; i < n ; i++) { int _e;_e = _buf.ReadInt(); K1[i] = _e;}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K8 = new System.Collections.Generic.Dictionary<int, int>(n * 3 / 2);for(var i = 0 ; i < n ; i++) { int _k;  _k = _buf.ReadInt(); int _v;  _v = _buf.ReadInt();     K8.Add(_k, _v);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K9 = new System.Collections.Generic.List<test.DemoE2>(n);for(var i = 0 ; i < n ; i++) { test.DemoE2 _e;  _e = test.DemoE2.DeserializeDemoE2(_buf); K9.Add(_e);}}
        {int n = System.Math.Min(_buf.ReadSize(), _buf.Size);K15 = new test.DemoDynamic[n];for(var i = 0 ; i < n ; i++) { test.DemoDynamic _e;_e = test.DemoDynamic.DeserializeDemoDynamic(_buf); K15[i] = _e;}}
        PostInit();
    }

    public static ExcelFromJson DeserializeExcelFromJson(ByteBuf _buf)
    {
        return new test.ExcelFromJson(_buf);
    }

    public int X4 { get; protected set; }
    public bool X1 { get; protected set; }
    public long X5 { get; protected set; }
    public float X6 { get; protected set; }
    public string S1 { get; protected set; }
    public string S2 { get; protected set; }
    //field.gen_text_key
    public string S2_l10n_key { get; protected set; }
    public UnityEngine.Vector2 V2 { get; protected set; }
    public UnityEngine.Vector3 V3 { get; protected set; }
    public UnityEngine.Vector4 V4 { get; protected set; }
    public int T1 { get; protected set; }
    public long T1_Millis => T1 * 1000L;
    public test.DemoType1 X12 { get; protected set; }
    public test.DemoEnum X13 { get; protected set; }
    public test.DemoDynamic X14 { get; protected set; }
    public int[] K1 { get; protected set; }
    public System.Collections.Generic.Dictionary<int, int> K8 { get; protected set; }
    public System.Collections.Generic.List<test.DemoE2> K9 { get; protected set; }
    public test.DemoDynamic[] K15 { get; protected set; }

    public const int __ID__ = -1485706483;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        X12?.Resolve(_tables);
        X14?.Resolve(_tables);
        foreach(var _e in K9) { _e?.Resolve(_tables); }
        foreach(var _e in K15) { _e?.Resolve(_tables); }
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        S2 = translator(S2_l10n_key, S2);
        X12?.TranslateText(translator);
        X14?.TranslateText(translator);
        foreach(var _e in K9) { _e?.TranslateText(translator); }
        foreach(var _e in K15) { _e?.TranslateText(translator); }
    }

    public void Reload(ExcelFromJson reloadData)
    {
        X4 = reloadData.X4;
        X1 = reloadData.X1;
        X5 = reloadData.X5;
        X6 = reloadData.X6;
        S1 = reloadData.S1;
        S2 = reloadData.S2;
        V2 = reloadData.V2;
        V3 = reloadData.V3;
        V4 = reloadData.V4;
        T1 = reloadData.T1;
        if(X12==null)
        {
            X12 = reloadData.X12;
        }else
        {
            if(X12.GetTypeId() == reloadData.X12.GetTypeId())
            {
                X12.Reload(reloadData.X12);
            }else
            {
                typeof(ExcelFromJson).GetProperty("X12").SetValue(this,reloadData.X12);
            }
        }
        X13 = reloadData.X13;
        if(X14==null)
        {
            X14 = reloadData.X14;
        }else
        {
            if(X14.GetTypeId() == reloadData.X14.GetTypeId())
            {
                switch (reloadData.X14.GetTypeId())
                {
                    case test.DemoD2.__ID__:
                        (X14 as test.DemoD2).Reload(reloadData.X14 as test.DemoD2);
                        break;
                    case test.DemoE1.__ID__:
                        (X14 as test.DemoE1).Reload(reloadData.X14 as test.DemoE1);
                        break;
                    case test.login.RoleInfo.__ID__:
                        (X14 as test.login.RoleInfo).Reload(reloadData.X14 as test.login.RoleInfo);
                        break;
                    case test.DemoD5.__ID__:
                        (X14 as test.DemoD5).Reload(reloadData.X14 as test.DemoD5);
                        break;
                }
            }else
            {
                typeof(ExcelFromJson).GetProperty("X14").SetValue(this,reloadData.X14);
            }
        }
        if(K1==null)
        {
            K1 = reloadData.K1;
        }else
        {
                for(int i = 0; i<reloadData.K1.Length; i++)
                {
                    if(i<K1.Length)
                    {
                        K1[i] = reloadData.K1[i];
                    }
                }
        }
        if(K8==null)
        {
            K8 = reloadData.K8;
        }else
        {
            foreach (var rawDataKey in K8.Keys.ToList())
            {
                if(!reloadData.K8.ContainsKey(rawDataKey))
                {
                    K8.Remove(rawDataKey);
                }
            }
            foreach (var reload in reloadData.K8)
            {
                if(K8.ContainsKey(reload.Key))
                {
                    K8[reload.Key] = reload.Value;
                }else
                {
                    K8.Add(reload.Key,reload.Value);
                }
            }
        }
        if(K9==null)
        {
            K9 = reloadData.K9;
        }else
        {
            K9.Capacity = reloadData.K9.Count;
            for (int i = 0; i < reloadData.K9.Count; i++)
            {
                if(K9[i]!=null)
                {
                    K9[i].Reload(reloadData.K9[i]);
                }else
                {
                    K9[i] = reloadData.K9[i];
                }
            }
        }
        if(K15==null)
        {
            K15 = reloadData.K15;
        }else
        {
            if(K15.Length!=reloadData.K15.Length)
            {
                var newArray = new test.DemoDynamic[reloadData.K15.Length];
                for(int i = 0; i<newArray.Length; i++)
                {
                    if(i<K15.Length)
                    {
                        newArray[i] = K15[i];
                    }
                }
                typeof(ExcelFromJson).GetProperty("K15").SetValue(this, newArray);
            }
                // array is_dynamic
                for(int i = 0; i<reloadData.K15.Length; i++)
                {
                    if(K15[i]!=null && K15[i].GetTypeId() == reloadData.K15[i].GetTypeId())
                    {
                        switch (reloadData.K15[i].GetTypeId())
                        {
                            case test.DemoD2.__ID__:
                                (K15[i] as test.DemoD2).Reload(reloadData.K15[i] as test.DemoD2);
                                break;
                            case test.DemoE1.__ID__:
                                (K15[i] as test.DemoE1).Reload(reloadData.K15[i] as test.DemoE1);
                                break;
                            case test.login.RoleInfo.__ID__:
                                (K15[i] as test.login.RoleInfo).Reload(reloadData.K15[i] as test.login.RoleInfo);
                                break;
                            case test.DemoD5.__ID__:
                                (K15[i] as test.DemoD5).Reload(reloadData.K15[i] as test.DemoD5);
                                break;
                        }
                    }else
                    {
                        K15[i] = reloadData.K15[i];
                    }
                }
        }
    }

    public override string ToString()
    {
        return "{ "
        + "X4:" + X4 + ","
        + "X1:" + X1 + ","
        + "X5:" + X5 + ","
        + "X6:" + X6 + ","
        + "S1:" + S1 + ","
        + "S2:" + S2 + ","
        + "V2:" + V2 + ","
        + "V3:" + V3 + ","
        + "V4:" + V4 + ","
        + "T1:" + T1 + ","
        + "X12:" + X12 + ","
        + "X13:" + X13 + ","
        + "X14:" + X14 + ","
        + "K1:" + Bright.Common.StringUtil.CollectionToString(K1) + ","
        + "K8:" + Bright.Common.StringUtil.CollectionToString(K8) + ","
        + "K9:" + Bright.Common.StringUtil.CollectionToString(K9) + ","
        + "K15:" + Bright.Common.StringUtil.CollectionToString(K15) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
