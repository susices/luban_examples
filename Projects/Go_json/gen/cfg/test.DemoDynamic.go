//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestDemoDynamic struct {
    X1 int32
}

const TypeId_TestDemoDynamic = -1863156384

func (*TestDemoDynamic) GetTypeId() int32 {
    return -1863156384
}

func (_v *TestDemoDynamic)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x1"].(float64); !_ok_ { err = errors.New("x1 error"); return }; _v.X1 = int32(_tempNum_) }
    return
}

func DeserializeTestDemoDynamic(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "DemoD2": _v := &TestDemoD2{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.DemoD2") } else { return _v, nil }
        case "DemoE1": _v := &TestDemoE1{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.DemoE1") } else { return _v, nil }
        case "test.login.RoleInfo": _v := &TestLoginRoleInfo{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.login.RoleInfo") } else { return _v, nil }
        case "DemoD5": _v := &TestDemoD5{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.DemoD5") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}
