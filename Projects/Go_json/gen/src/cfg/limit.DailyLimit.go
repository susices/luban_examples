
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Limit_DailyLimit struct {
    Limit_DailyLimitBase
    Num int32
}

func (Limit_DailyLimit) GetTypeId() int {
    return 303235413
}

func NewLimit_DailyLimit(_buf map[string]interface{}) (_v *Limit_DailyLimit, err error) {
    _v = &Limit_DailyLimit{}
    var _p *Limit_DailyLimitBase
     if _p, err = NewLimit_DailyLimitBase(_buf) ; err != nil { return }
    _v.Limit_DailyLimitBase = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["num"].(float64); !_ok_ { err = errors.New("num error"); return }; _v.Num = int32(_tempNum_) }
    return
}

