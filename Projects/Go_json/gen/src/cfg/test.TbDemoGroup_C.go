
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Test_TbDemoGroup_C struct {
    _dataMap map[int32]*Test_DemoGroup
    _dataList []*Test_DemoGroup
}

func NewTest_TbDemoGroup_C(_buf []map[string]interface{}) (*Test_TbDemoGroup_C, error) {
	_dataList := make([]*Test_DemoGroup, 0, len(_buf))
	dataMap := make(map[int32]*Test_DemoGroup)
	for _, _ele_ := range _buf {
		if _v, err2 := NewTest_DemoGroup (_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Test_TbDemoGroup_C{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Test_TbDemoGroup_C) GetDataMap() map[int32]*Test_DemoGroup {
    return table._dataMap
}

func (table *Test_TbDemoGroup_C) GetDataList() []*Test_DemoGroup {
    return table._dataList
}

func (table *Test_TbDemoGroup_C) Get(key int32) *Test_DemoGroup {
    return table._dataMap[key]
}


