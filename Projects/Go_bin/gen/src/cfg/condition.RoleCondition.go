
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import (
    "bright/serialization"
    "errors"
)



type Condition_RoleCondition struct {
    Condition_Condition
}


func NewCondition_RoleCondition(_buf *serialization.ByteBuf) (_v *Condition_RoleCondition, err error) {
    _v = &Condition_RoleCondition{}
    var _p *Condition_Condition
     if _p, err = NewCondition_Condition(_buf) ; err != nil { return }
    _v.Condition_Condition = *_p
    return
}
func NewChildCondition_RoleCondition(_buf *serialization.ByteBuf) (_v interface{}, err error) {
    var id int32
    if id, err = _buf.ReadInt() ; err != nil {
        return
    }
    switch id {
        case 934079583: return NewCondition_MultiRoleCondition(_buf)
        case 103675143: return NewCondition_GenderLimit(_buf)
        case -1075273755: return NewCondition_MinLevel(_buf)
        case 700922899: return NewCondition_MaxLevel(_buf)
        case 907499647: return NewCondition_MinMaxLevel(_buf)
        case 696630835: return NewCondition_ClothesPropertyScoreGreaterThan(_buf)
        case 1961145317: return NewCondition_ContainsItem(_buf)
        default: return nil, errors.New("unknown type id")
    }
    return
}

