
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



type Cost_CostItems struct {
    Cost_Cost
    ItemList []*Cost_CostItem
}

func (Cost_CostItems) GetTypeId() int {
    return -77945102
}

func NewCost_CostItems(_buf *serialization.ByteBuf) (_v *Cost_CostItems, err error) {
    _v = &Cost_CostItems{}
    var _p *Cost_Cost
     if _p, err = NewCost_Cost(_buf) ; err != nil { return }
    _v.Cost_Cost = *_p
     {
                _v.ItemList = make([]*Cost_CostItem, 0)
                var _n_ int
                if _n_, err = _buf.ReadSize(); err != nil {return}
                for i := 0 ; i < _n_ ; i++ {
                    var _e_ *Cost_CostItem
                    { if _e_, err = NewCost_CostItem (_buf); err != nil { return } }
                    _v.ItemList = append(_v.ItemList, _e_)
                }
            }

    return
}

