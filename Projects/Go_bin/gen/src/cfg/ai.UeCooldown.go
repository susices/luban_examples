
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
)



type Ai_UeCooldown struct {
    Ai_Decorator
    CooldownTime float32
}

func (Ai_UeCooldown) GetTypeId() int {
    return -951439423
}

func NewAi_UeCooldown(_buf *serialization.ByteBuf) (_v *Ai_UeCooldown, err error) {
    _v = &Ai_UeCooldown{}
    var _p *Ai_Decorator
     if _p, err = NewAi_Decorator(_buf) ; err != nil { return }
    _v.Ai_Decorator = *_p
    { if _v.CooldownTime, err = _buf.ReadFloat(); err != nil { return } }
    return
}

