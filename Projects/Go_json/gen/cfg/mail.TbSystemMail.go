//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

type MailTbSystemMail struct {
    _dataMap map[int32]*MailSystemMail
    _dataList []*MailSystemMail
}

func NewMailTbSystemMail(_buf []map[string]interface{}) (*MailTbSystemMail, error) {
	_dataList := make([]*MailSystemMail, 0, len(_buf))
	dataMap := make(map[int32]*MailSystemMail)
	for _, _ele_ := range _buf {
		if _v, err2 := DeserializeMailSystemMail(_ele_); err2 != nil {
			return nil, err2
		} else {
			_dataList = append(_dataList, _v)
			dataMap[_v.Id] = _v
		}
	}
	return &MailTbSystemMail{_dataList:_dataList, _dataMap:dataMap}, nil
}

func (table *MailTbSystemMail) GetDataMap() map[int32]*MailSystemMail {
    return table._dataMap
}

func (table *MailTbSystemMail) GetDataList() []*MailSystemMail {
    return table._dataList
}

func (table *MailTbSystemMail) Get(key int32) *MailSystemMail {
    return table._dataMap[key]
}


