
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Test_TbDataFromLua struct {
    _dataMap map[int32]*Test_DemoType2
    _dataList []*Test_DemoType2
}

func NewTest_TbDataFromLua(_buf []map[string]interface{}) (*Test_TbDataFromLua, error) {
	_dataList := make([]*Test_DemoType2, 0, len(_buf))
	dataMap := make(map[int32]*Test_DemoType2)
	for _, _ele_ := range _buf {
		if _v, err2 := NewTest_DemoType2 (_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.X4] = _v
		}
	}
	return &Test_TbDataFromLua{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Test_TbDataFromLua) GetDataMap() map[int32]*Test_DemoType2 {
    return table._dataMap
}

func (table *Test_TbDataFromLua) GetDataList() []*Test_DemoType2 {
    return table._dataList
}

func (table *Test_TbDataFromLua) Get(key int32) *Test_DemoType2 {
    return table._dataMap[key]
}


