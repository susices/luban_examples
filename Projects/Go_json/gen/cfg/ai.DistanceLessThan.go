//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import "errors"

type AiDistanceLessThan struct {
    Id int32
    NodeName string
    FlowAbortMode int32
    Actor1Key string
    Actor2Key string
    Distance float32
    ReverseResult bool
}

const TypeId_AiDistanceLessThan = -1207170283

func (*AiDistanceLessThan) GetTypeId() int32 {
    return -1207170283
}

func (_v *AiDistanceLessThan)Deserialize(_buf map[string]interface{}) (err error) {
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.NodeName, _ok_ = _buf["node_name"].(string); !_ok_ { err = errors.New("node_name error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["flow_abort_mode"].(float64); !_ok_ { err = errors.New("flow_abort_mode error"); return }; _v.FlowAbortMode = int32(_tempNum_) }
    { var _ok_ bool; if _v.Actor1Key, _ok_ = _buf["actor1_key"].(string); !_ok_ { err = errors.New("actor1_key error"); return } }
    { var _ok_ bool; if _v.Actor2Key, _ok_ = _buf["actor2_key"].(string); !_ok_ { err = errors.New("actor2_key error"); return } }
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["distance"].(float64); !_ok_ { err = errors.New("distance error"); return }; _v.Distance = float32(_tempNum_) }
    { var _ok_ bool; if _v.ReverseResult, _ok_ = _buf["reverse_result"].(bool); !_ok_ { err = errors.New("reverse_result error"); return } }
    return
}

func DeserializeAiDistanceLessThan(_buf map[string]interface{}) (*AiDistanceLessThan, error) {
    v := &AiDistanceLessThan{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
