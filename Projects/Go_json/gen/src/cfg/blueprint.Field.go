
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Blueprint_Field struct {
    Name string
    Type string
    Desc string
}

func (Blueprint_Field) GetTypeId() int {
    return 1694158271
}

func NewBlueprint_Field(_buf map[string]interface{}) (_v *Blueprint_Field, err error) {
    _v = &Blueprint_Field{}
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Type, _ok_ = _buf["type"].(string); !_ok_ { err = errors.New("type error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    return
}

