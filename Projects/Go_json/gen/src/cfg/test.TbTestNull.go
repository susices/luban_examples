
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Test_TbTestNull struct {
    _dataMap map[int32]*Test_TestNull
    _dataList []*Test_TestNull
}

func NewTest_TbTestNull(_buf []map[string]interface{}) (*Test_TbTestNull, error) {
	_dataList := make([]*Test_TestNull, 0, len(_buf))
	dataMap := make(map[int32]*Test_TestNull)
	for _, _ele_ := range _buf {
		if _v, err2 := NewTest_TestNull (_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Test_TbTestNull{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Test_TbTestNull) GetDataMap() map[int32]*Test_TestNull {
    return table._dataMap
}

func (table *Test_TbTestNull) GetDataList() []*Test_TestNull {
    return table._dataList
}

func (table *Test_TbTestNull) Get(key int32) *Test_TestNull {
    return table._dataMap[key]
}


