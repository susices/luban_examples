
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



type Ai_Selector struct {
    Ai_ComposeNode
    Children []interface{}
}

func (Ai_Selector) GetTypeId() int {
    return -1946981627
}

func NewAi_Selector(_buf *serialization.ByteBuf) (_v *Ai_Selector, err error) {
    _v = &Ai_Selector{}
    var _p *Ai_ComposeNode
     if _p, err = NewAi_ComposeNode(_buf) ; err != nil { return }
    _v.Ai_ComposeNode = *_p
     {
                _v.Children = make([]interface{}, 0)
                var _n_ int
                if _n_, err = _buf.ReadSize(); err != nil {return}
                for i := 0 ; i < _n_ ; i++ {
                    var _e_ interface{}
                    { if _e_, err = NewChildAi_FlowNode(_buf); err != nil { return } }
                    _v.Children = append(_v.Children, _e_)
                }
            }

    return
}

