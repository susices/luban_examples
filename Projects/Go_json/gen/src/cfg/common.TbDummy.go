
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

type Common_TbDummy struct {
    _dataMap map[int32]*Common_Dummy
    _dataList []*Common_Dummy
}

func NewCommon_TbDummy(_buf []map[string]interface{}) (*Common_TbDummy, error) {
	_dataList := make([]*Common_Dummy, 0, len(_buf))
	dataMap := make(map[int32]*Common_Dummy)
	for _, _ele_ := range _buf {
		if _v, err2 := NewCommon_Dummy (_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &Common_TbDummy{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *Common_TbDummy) GetDataMap() map[int32]*Common_Dummy {
    return table._dataMap
}

func (table *Common_TbDummy) GetDataList() []*Common_Dummy {
    return table._dataList
}

func (table *Common_TbDummy) Get(key int32) *Common_Dummy {
    return table._dataMap[key]
}


