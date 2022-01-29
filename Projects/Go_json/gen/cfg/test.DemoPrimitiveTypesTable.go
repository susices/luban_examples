//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"
import "luban_examples/go_json/bright/serialization"

type TestDemoPrimitiveTypesTable struct {
    X1 bool
    X2 byte
    X3 int16
    X4 int32
    X5 int64
    X6 float32
    X7 float64
    S1 string
    S2 string
    V2 serialization.Vector2
    V3 serialization.Vector3
    V4 serialization.Vector4
    T1 int32
}

const TypeId_TestDemoPrimitiveTypesTable = -370934083

func (*TestDemoPrimitiveTypesTable) GetTypeId() int32 {
    return -370934083
}

func (_v *TestDemoPrimitiveTypesTable)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; if _v.X1, _ok_ = _buf["x1"].(bool); !_ok_ { err = errors.New("x1 error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x2"].(float64); !_ok_ { err = errors.New("x2 error"); return }; _v.X2 = byte(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x3"].(float64); !_ok_ { err = errors.New("x3 error"); return }; _v.X3 = int16(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x4"].(float64); !_ok_ { err = errors.New("x4 error"); return }; _v.X4 = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x5"].(float64); !_ok_ { err = errors.New("x5 error"); return }; _v.X5 = int64(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x6"].(float64); !_ok_ { err = errors.New("x6 error"); return }; _v.X6 = float32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["x7"].(float64); !_ok_ { err = errors.New("x7 error"); return }; _v.X7 = float64(_tempNum_) }
    { var _ok_ bool; if _v.S1, _ok_ = _buf["s1"].(string); !_ok_ { err = errors.New("s1 error"); return } }
    {var _ok_ bool; var __json_text__ map[string]interface{}; if __json_text__, _ok_ = _buf["s2"].(map[string]interface{}) ; !_ok_ { err = errors.New("_v.S2 error"); return };  { var _ok_ bool; if _, _ok_ = __json_text__["key"].(string); !_ok_ { err = errors.New("key error"); return } }; { var _ok_ bool; if _v.S2, _ok_ = __json_text__["text"].(string); !_ok_ { err = errors.New("text error"); return } } }
    { var _ok_ bool; var _v_ map[string]interface{}; if _v_, _ok_ = _buf["v2"].(map[string]interface{}); !_ok_ { err = errors.New("v2 error"); return }
            var _x_, _y_ float32;
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["x"].(float64); !_ok_ { err = errors.New("x error"); return }; _x_ = float32(_tempNum_) }
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["y"].(float64); !_ok_ { err = errors.New("y error"); return }; _y_ = float32(_tempNum_) }
            _v.V2 = serialization.NewVector2(_x_, _y_)
            }

    { var _ok_ bool; var _v_ map[string]interface{}; if _v_, _ok_ = _buf["v3"].(map[string]interface{}); !_ok_ { err = errors.New("v3 error"); return }
            var _x_, _y_, _z_ float32;
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["x"].(float64); !_ok_ { err = errors.New("x error"); return }; _x_ = float32(_tempNum_) }
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["y"].(float64); !_ok_ { err = errors.New("y error"); return }; _y_ = float32(_tempNum_) }
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["z"].(float64); !_ok_ { err = errors.New("z error"); return }; _z_ = float32(_tempNum_) }
            _v.V3 = serialization.NewVector3(_x_, _y_, _z_)
            }

    { var _ok_ bool; var _v_ map[string]interface{}; if _v_, _ok_ = _buf["v4"].(map[string]interface{}); !_ok_ { err = errors.New("v4 error"); return }
            var _x_, _y_, _z_, _w_ float32;
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["x"].(float64); !_ok_ { err = errors.New("x error"); return }; _x_ = float32(_tempNum_) }
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["y"].(float64); !_ok_ { err = errors.New("y error"); return }; _y_ = float32(_tempNum_) }
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["z"].(float64); !_ok_ { err = errors.New("z error"); return }; _z_ = float32(_tempNum_) }
            { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _v_["w"].(float64); !_ok_ { err = errors.New("w error"); return }; _w_ = float32(_tempNum_) }
            _v.V4 = serialization.NewVector4(_x_, _y_, _z_, _w_)
            }

    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["t1"].(float64); !_ok_ { err = errors.New("t1 error"); return }; _v.T1 = int32(_tempNum_) }
    return
}

func DeserializeTestDemoPrimitiveTypesTable(_buf map[string]interface{}) (*TestDemoPrimitiveTypesTable, error) {
    v := &TestDemoPrimitiveTypesTable{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
