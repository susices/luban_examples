//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type CostCostCurrencies struct {
    Currencies []*CostCostCurrency
}

const TypeId_CostCostCurrencies = 103084157

func (*CostCostCurrencies) GetTypeId() int32 {
    return 103084157
}

func (_v *CostCostCurrencies)Deserialize(_buf map[string]interface{}) (err error) {
     {
                var _arr_ []interface{}
                var _ok_ bool
                if _arr_, _ok_ = _buf["currencies"].([]interface{}); !_ok_ { err = errors.New("currencies error"); return }

                _v.Currencies = make([]*CostCostCurrency, 0, len(_arr_))
                
                for _, _e_ := range _arr_ {
                    var _list_v_ *CostCostCurrency
                    { var _ok_ bool; var _x_ map[string]interface{}; if _x_, _ok_ = _e_.(map[string]interface{}); !_ok_ { err = errors.New("_list_v_ error"); return }; if _list_v_, err = DeserializeCostCostCurrency(_x_); err != nil { return } }
                    _v.Currencies = append(_v.Currencies, _list_v_)
                }
            }

    return
}

func DeserializeCostCostCurrencies(_buf map[string]interface{}) (*CostCostCurrencies, error) {
    v := &CostCostCurrencies{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
