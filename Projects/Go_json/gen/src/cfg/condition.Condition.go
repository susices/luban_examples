
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Condition_Condition struct {
}


func NewCondition_Condition(_buf map[string]interface{}) (_v *Condition_Condition, err error) {
    _v = &Condition_Condition{}
    return
}
func NewChildCondition_Condition(_buf map[string]interface{}) (_v interface{}, err error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "TimeRange": return NewCondition_TimeRange(_buf);
        case "MultiRoleCondition": return NewCondition_MultiRoleCondition(_buf);
        case "GenderLimit": return NewCondition_GenderLimit(_buf);
        case "MinLevel": return NewCondition_MinLevel(_buf);
        case "MaxLevel": return NewCondition_MaxLevel(_buf);
        case "MinMaxLevel": return NewCondition_MinMaxLevel(_buf);
        case "ClothesPropertyScoreGreaterThan": return NewCondition_ClothesPropertyScoreGreaterThan(_buf);
        case "ContainsItem": return NewCondition_ContainsItem(_buf);
        default: return nil, errors.New("unknown type id")
    }
    return
}

