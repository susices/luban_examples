
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Error_ErrorStyleDlgOk struct {
    Error_ErrorStyle
    BtnName string
}

func (Error_ErrorStyleDlgOk) GetTypeId() int {
    return -2010134516
}

func NewError_ErrorStyleDlgOk(_buf map[string]interface{}) (_v *Error_ErrorStyleDlgOk, err error) {
    _v = &Error_ErrorStyleDlgOk{}
    var _p *Error_ErrorStyle
     if _p, err = NewError_ErrorStyle(_buf) ; err != nil { return }
    _v.Error_ErrorStyle = *_p
    { var _ok_ bool; if _v.BtnName, _ok_ = _buf["btn_name"].(string); !_ok_ { err = errors.New("btn_name error"); return } }
    return
}

