
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_DemoD2 struct {
    Test_DemoDynamic
    X2 int32
}

func (Test_DemoD2) GetTypeId() int {
    return -2138341747
}

func NewTest_DemoD2(_buf map[string]interface{}) (_v *Test_DemoD2, err error) {
    _v = &Test_DemoD2{}
    var _p *Test_DemoDynamic
     if _p, err = NewTest_DemoDynamic(_buf) ; err != nil { return }
    _v.Test_DemoDynamic = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x2"].(float64); !_ok_ { err = errors.New("x2 error"); return }; _v.X2 = int32(_tempNum_) }
    return
}

