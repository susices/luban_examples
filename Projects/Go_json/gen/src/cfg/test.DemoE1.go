
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_DemoE1 struct {
    Test_DemoD3
    X4 int32
}

func (Test_DemoE1) GetTypeId() int {
    return -2138341717
}

func NewTest_DemoE1(_buf map[string]interface{}) (_v *Test_DemoE1, err error) {
    _v = &Test_DemoE1{}
    var _p *Test_DemoD3
     if _p, err = NewTest_DemoD3(_buf) ; err != nil { return }
    _v.Test_DemoD3 = *_p
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x4"].(float64); !_ok_ { err = errors.New("x4 error"); return }; _v.X4 = int32(_tempNum_) }
    return
}

