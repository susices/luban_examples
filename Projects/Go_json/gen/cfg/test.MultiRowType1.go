//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestMultiRowType1 struct {
    Id int32
    X int32
}

const TypeId_TestMultiRowType1 = 540474970

func (*TestMultiRowType1) GetTypeId() int32 {
    return 540474970
}

func (_v *TestMultiRowType1)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x"].(float64); !_ok_ { err = errors.New("x error"); return }; _v.X = int32(_tempNum_) }
    return
}

func DeserializeTestMultiRowType1(_buf map[string]interface{}) (*TestMultiRowType1, error) {
    v := &TestMultiRowType1{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
