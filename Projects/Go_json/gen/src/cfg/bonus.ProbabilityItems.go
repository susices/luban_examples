
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Bonus_ProbabilityItems struct {
    Bonus_Bonus
    ItemList []*Bonus_ProbabilityItemInfo
}

func (Bonus_ProbabilityItems) GetTypeId() int {
    return 366387866
}

func NewBonus_ProbabilityItems(_buf map[string]interface{}) (_v *Bonus_ProbabilityItems, err error) {
    _v = &Bonus_ProbabilityItems{}
    var _p *Bonus_Bonus
     if _p, err = NewBonus_Bonus(_buf) ; err != nil { return }
    _v.Bonus_Bonus = *_p
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["item_list"].([]interface{}); !_ok_ { err = errors.New("item_list error"); return }

                _v.ItemList = make([]*Bonus_ProbabilityItemInfo, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *Bonus_ProbabilityItemInfo
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = NewBonus_ProbabilityItemInfo (_x_); err != nil { return } }
                    _v.ItemList = append(_v.ItemList, _list_v_)
                }
            }

    return
}

