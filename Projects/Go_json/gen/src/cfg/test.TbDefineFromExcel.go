
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Test_TbDefineFromExcel struct {
    _dataMap map[int32]*Test_DefineFromExcel
    _dataList []*Test_DefineFromExcel
}

func NewTest_TbDefineFromExcel(_buf []map[string]interface{}) (*Test_TbDefineFromExcel, error) {
	_dataList := make([]*Test_DefineFromExcel, 0, len(_buf))
	dataMap := make(map[int32]*Test_DefineFromExcel)
	for _, _ele_ := range _buf {
		if _v, err2 := NewTest_DefineFromExcel(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Test_TbDefineFromExcel{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Test_TbDefineFromExcel) GetDataMap() map[int32]*Test_DefineFromExcel {
    return table._dataMap
}

func (table *Test_TbDefineFromExcel) GetDataList() []*Test_DefineFromExcel {
    return table._dataList
}

func (table *Test_TbDefineFromExcel) Get(key int32) *Test_DefineFromExcel {
    return table._dataMap[key]
}


