//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type RoleLevelExpAttr struct {
    Level int32
    NeedExp int64
    ClothesAttrs []int32
}

const TypeId_RoleLevelExpAttr = -1569837022

func (*RoleLevelExpAttr) GetTypeId() int32 {
    return -1569837022
}

func (_v *RoleLevelExpAttr)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["level"].(float64); !_ok_ { err = errors.New("level error"); return }; _v.Level = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["need_exp"].(float64); !_ok_ { err = errors.New("need_exp error"); return }; _v.NeedExp = int64(_tempNum_) }
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["clothes_attrs"].([]interface{}); !_ok_ { err = errors.New("clothes_attrs error"); return }

                _v.ClothesAttrs = make([]int32, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ int32
                    { var _ok_ bool; var _x_ float64; if _x_, _ok_ = _e_.(float64); !_ok_ { err = errors.New("_list_v_ error"); return }; _list_v_ = int32(_x_) }
                    _v.ClothesAttrs = append(_v.ClothesAttrs, _list_v_)
                }
            }

    return
}

func DeserializeRoleLevelExpAttr(_buf map[string]interface{}) (*RoleLevelExpAttr, error) {
    v := &RoleLevelExpAttr{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
