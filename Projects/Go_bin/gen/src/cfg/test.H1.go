
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



type Test_H1 struct {
    Y2 *Test_H2
    Y3 int32
}

func (Test_H1) GetTypeId() int {
    return -1422503995
}

func NewTest_H1(_buf *serialization.ByteBuf) (_v *Test_H1, err error) {
    _v = &Test_H1{}
    { if _v.Y2, err = NewTest_H2 (_buf); err != nil { return } }
    { if _v.Y3, err = _buf.ReadInt(); err != nil { return } }
    return
}

