//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestDemoD2 struct {
    X1 int32
    X2 int32
}

const TypeId_TestDemoD2 = -2138341747

func (*TestDemoD2) GetTypeId() int32 {
    return -2138341747
}

func (_v *TestDemoD2)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x2"].(float64); !_ok_ { err = errors.New("x2 error"); return }; _v.X2 = int32(_tempNum_) }
    return
}

func DeserializeTestDemoD2(_buf map[string]interface{}) (*TestDemoD2, error) {
    v := &TestDemoD2{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
