
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



type Item_Dymmy struct {
    Item_ItemExtra
    Cost interface{}
}

func (Item_Dymmy) GetTypeId() int {
    return 896889705
}

func NewItem_Dymmy(_buf *serialization.ByteBuf) (_v *Item_Dymmy, err error) {
    _v = &Item_Dymmy{}
    var _p *Item_ItemExtra
     if _p, err = NewItem_ItemExtra(_buf) ; err != nil { return }
    _v.Item_ItemExtra = *_p
    { if _v.Cost, err = NewChildCost_Cost(_buf); err != nil { return } }
    return
}

