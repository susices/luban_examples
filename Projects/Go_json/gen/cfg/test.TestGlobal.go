//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestTestGlobal struct {
    UnlockEquip int32
    UnlockHero int32
}

const TypeId_TestTestGlobal = -12548655

func (*TestTestGlobal) GetTypeId() int32 {
    return -12548655
}

func (_v *TestTestGlobal)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["unlock_equip"].(float64); !_ok_ { err = errors.New("unlock_equip error"); return }; _v.UnlockEquip = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["unlock_hero"].(float64); !_ok_ { err = errors.New("unlock_hero error"); return }; _v.UnlockHero = int32(_tempNum_) }
    return
}

func DeserializeTestTestGlobal(_buf map[string]interface{}) (*TestTestGlobal, error) {
    v := &TestTestGlobal{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
