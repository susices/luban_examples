
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import "errors"

type Ai_UeWaitBlackboardTime struct {
    Ai_Task
    BlackboardKey string
}

func (Ai_UeWaitBlackboardTime) GetTypeId() int {
    return 1215378271
}

func NewAi_UeWaitBlackboardTime(_buf map[string]interface{}) (_v *Ai_UeWaitBlackboardTime, err error) {
    _v = &Ai_UeWaitBlackboardTime{}
    var _p *Ai_Task
     if _p, err = NewAi_Task(_buf) ; err != nil { return }
    _v.Ai_Task = *_p
    { var _ok_ bool; if _v.BlackboardKey, _ok_ = _buf["blackboard_key"].(string); !_ok_ { err = errors.New("blackboard_key error"); return } }
    return
}

