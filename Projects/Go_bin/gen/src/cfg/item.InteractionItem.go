
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



type Item_InteractionItem struct {
    Item_ItemExtra
    AttackNum *int32
    HoldingStaticMesh string
    HoldingStaticMeshMat string
}

func (Item_InteractionItem) GetTypeId() int {
    return 640937802
}

func NewItem_InteractionItem(_buf *serialization.ByteBuf) (_v *Item_InteractionItem, err error) {
    _v = &Item_InteractionItem{}
    var _p *Item_ItemExtra
     if _p, err = NewItem_ItemExtra(_buf) ; err != nil { return }
    _v.Item_ItemExtra = *_p
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ int32;  { if __x__, err = _buf.ReadInt(); err != nil { return } }; _v.AttackNum = &__x__ }}
    { if _v.HoldingStaticMesh, err = _buf.ReadString(); err != nil { return } }
    { if _v.HoldingStaticMeshMat, err = _buf.ReadString(); err != nil { return } }
    return
}

