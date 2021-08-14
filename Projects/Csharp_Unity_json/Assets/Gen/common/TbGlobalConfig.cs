
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



namespace cfg.common
{

public sealed partial class TbGlobalConfig
{

     private readonly common.GlobalConfig _data;

    public TbGlobalConfig(JSONNode _json)
    {
        if(!_json.IsArray)
        {
            throw new SerializationException();
        }
        if (_json.Count != 1) throw new SerializationException("table mode=one, but size != 1");
        _data = common.GlobalConfig.DeserializeGlobalConfig(_json[0]);
    }

    /// <summary>
    /// 背包容量
    /// </summary>
     public int BagCapacity => _data.BagCapacity;
     public int BagCapacitySpecial => _data.BagCapacitySpecial;
     public int BagTempExpendableCapacity => _data.BagTempExpendableCapacity;
     public int BagTempToolCapacity => _data.BagTempToolCapacity;
     public int BagInitCapacity => _data.BagInitCapacity;
     public int QuickBagCapacity => _data.QuickBagCapacity;
     public int ClothBagCapacity => _data.ClothBagCapacity;
     public int ClothBagInitCapacity => _data.ClothBagInitCapacity;
     public int ClothBagCapacitySpecial => _data.ClothBagCapacitySpecial;
     public int? BagInitItemsDropId => _data.BagInitItemsDropId;
        public bonus.DropInfo BagInitItemsDropId_Ref => _data.BagInitItemsDropId_Ref;
     public int MailBoxCapacity => _data.MailBoxCapacity;
     public float DamageParamC => _data.DamageParamC;
     public float DamageParamE => _data.DamageParamE;
     public float DamageParamF => _data.DamageParamF;
     public float DamageParamD => _data.DamageParamD;
     public float RoleSpeed => _data.RoleSpeed;
     public float MonsterSpeed => _data.MonsterSpeed;
     public int InitEnergy => _data.InitEnergy;
     public int InitViality => _data.InitViality;
     public int MaxViality => _data.MaxViality;
     public int PerVialityRecoveryTime => _data.PerVialityRecoveryTime;

    public void Resolve(Dictionary<string, object> _tables)
    {
        _data.Resolve(_tables);
        OnResolveFinish(_tables);
    }


    partial void OnResolveFinish(Dictionary<string, object> _tables);
}

}
