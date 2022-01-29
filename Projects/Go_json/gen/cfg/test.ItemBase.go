//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type TestItemBase struct {
    Id int32
    Name string
    Desc string
}

const TypeId_TestItemBase = -1631171968

func (*TestItemBase) GetTypeId() int32 {
    return -1631171968
}

func (_v *TestItemBase)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.Name, _ok_ = _buf["name"].(string); !_ok_ { err = errors.New("name error"); return } }
    { var _ok_ bool; if _v.Desc, _ok_ = _buf["desc"].(string); !_ok_ { err = errors.New("desc error"); return } }
    return
}

func DeserializeTestItemBase(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["__type__"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "Item": _v := &TestItem{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.Item") } else { return _v, nil }
        case "Equipment": _v := &TestEquipment{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.Equipment") } else { return _v, nil }
        case "Decorator": _v := &TestDecorator{}; if err := _v.Deserialize(_buf); err != nil { return nil, errors.New("test.Decorator") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}
