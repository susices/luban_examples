
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Test_DateTimeRange struct {
    StartTime int32
    EndTime int32
}

func (Test_DateTimeRange) GetTypeId() int {
    return 495315430
}

func NewTest_DateTimeRange(_buf map[string]interface{}) (_v *Test_DateTimeRange, err error) {
    _v = &Test_DateTimeRange{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["start_time"].(float64); !_ok_ { err = errors.New("start_time error"); return }; _v.StartTime = int32(_tempNum_) }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["end_time"].(float64); !_ok_ { err = errors.New("end_time error"); return }; _v.EndTime = int32(_tempNum_) }
    return
}

