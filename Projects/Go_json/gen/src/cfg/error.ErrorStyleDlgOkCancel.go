
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Error_ErrorStyleDlgOkCancel struct {
    Error_ErrorStyle
    Btn1Name string
    Btn2Name string
}

func (Error_ErrorStyleDlgOkCancel) GetTypeId() int {
    return 971221414
}

func NewError_ErrorStyleDlgOkCancel(_buf map[string]interface{}) (_v *Error_ErrorStyleDlgOkCancel, err error) {
    _v = &Error_ErrorStyleDlgOkCancel{}
    var _p *Error_ErrorStyle
     if _p, err = NewError_ErrorStyle(_buf) ; err != nil { return }
    _v.Error_ErrorStyle = *_p
    { var _ok_ bool; if _v.Btn1Name, _ok_ = _buf["btn1_name"].(string); !_ok_ { err = errors.New("btn1_name error"); return } }
    { var _ok_ bool; if _v.Btn2Name, _ok_ = _buf["btn2_name"].(string); !_ok_ { err = errors.New("btn2_name error"); return } }
    return
}

