
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



type Bonus_Bonus struct {
}


func NewBonus_Bonus(_buf *serialization.ByteBuf) (_v *Bonus_Bonus, err error) {
    _v = &Bonus_Bonus{}
    return
}
func NewChildBonus_Bonus(_buf *serialization.ByteBuf) (_v interface{}, err error) {
    var id int32
    if id, err = _buf.ReadInt() ; err != nil {
        return
    }
    switch id {
        case -1649658966: return NewBonus_OneItem(_buf)
        case 400179721: return NewBonus_OneItems(_buf)
        case 1689011106: return NewBonus_Item(_buf)
        case 819736849: return NewBonus_Items(_buf)
        case -229470727: return NewBonus_CoefficientItem(_buf)
        case -356202311: return NewBonus_WeightItems(_buf)
        case 366387866: return NewBonus_ProbabilityItems(_buf)
        case 1421907893: return NewBonus_MultiBonus(_buf)
        case 359783161: return NewBonus_ProbabilityBonus(_buf)
        case -362807016: return NewBonus_WeightBonus(_buf)
        case 1959868225: return NewBonus_DropBonus(_buf)
        default: return nil, errors.New("unknown type id")
    }
    return
}

