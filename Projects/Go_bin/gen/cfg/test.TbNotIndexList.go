
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "luban_examples/go_bin/bright/serialization"

type TestTbNotIndexList struct {
    _dataList []*TestNotIndexList
}

func NewTestTbNotIndexList(_buf *serialization.ByteBuf) (*TestTbNotIndexList, error) {
	if size, err := _buf.ReadSize() ; err != nil {
		return nil, err
	} else {
		_dataList := make([]*TestNotIndexList, 0, size)

		for i := 0 ; i < size ; i++ {
			if _v, err2 := DeserializeTestNotIndexList(_buf); err2 != nil {
				return nil, err2
			} else {
				_dataList = append(_dataList, _v)
			}
		}
		return &TestTbNotIndexList{_dataList:_dataList}, nil
	}
}

func (table *TestTbNotIndexList) GetDataList() []*TestNotIndexList {
    return table._dataList
}

func (table *TestTbNotIndexList) Get(index int) *TestNotIndexList {
    return table._dataList[index]
}

