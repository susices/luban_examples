
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



type Ai_BlackboardKeyData struct {
    Ai_KeyData
    Value string
}

func (Ai_BlackboardKeyData) GetTypeId() int {
    return 1517269500
}

func NewAi_BlackboardKeyData(_buf *serialization.ByteBuf) (_v *Ai_BlackboardKeyData, err error) {
    _v = &Ai_BlackboardKeyData{}
    var _p *Ai_KeyData
     if _p, err = NewAi_KeyData(_buf) ; err != nil { return }
    _v.Ai_KeyData = *_p
    { if _v.Value, err = _buf.ReadString(); err != nil { return } }
    return
}

