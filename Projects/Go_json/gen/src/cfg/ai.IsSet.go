
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg



type Ai_IsSet struct {
    Ai_KeyQueryOperator
}

func (Ai_IsSet) GetTypeId() int {
    return 1635350898
}

func NewAi_IsSet(_buf map[string]interface{}) (_v *Ai_IsSet, err error) {
    _v = &Ai_IsSet{}
    var _p *Ai_KeyQueryOperator
     if _p, err = NewAi_KeyQueryOperator(_buf) ; err != nil { return }
    _v.Ai_KeyQueryOperator = *_p
    return
}

