
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg

import (
    "luban_examples/go_bin/bright/serialization"
)

import "errors"

type AiDebugPrint struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
    IgnoreRestartSelf bool
    Text string
}

const TypeId_AiDebugPrint = 1357409728

func (*AiDebugPrint) GetTypeId() int32 {
    return 1357409728
}

func (_v *AiDebugPrint)Serialize(_buf *serialization.ByteBuf) {
    // not support
}

func (_v *AiDebugPrint)Deserialize(_buf *serialization.ByteBuf) (err error) {
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("_v.Id error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("_v.NodeName error"); return } }
    {_v.Decorators = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Decorators error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiDecorator(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Decorators = append(_v.Decorators, _e_) } }
    {_v.Services = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("_v.Services error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = DeserializeAiService(_buf); err != nil { err = errors.New("_e_ error"); return } }; _v.Services = append(_v.Services, _e_) } }
    { if _v.IgnoreRestartSelf, err = _buf.ReadBool(); err != nil { err = errors.New("_v.IgnoreRestartSelf error"); err = errors.New("_v.IgnoreRestartSelf error"); return } }
    { if _v.Text, err = _buf.ReadString(); err != nil { err = errors.New("_v.Text error"); return } }
    return
}

func DeserializeAiDebugPrint(_buf *serialization.ByteBuf) (*AiDebugPrint, error) {
    v := &AiDebugPrint{}
    if err := v.Deserialize(_buf); err == nil {
        return v, nil
    } else {
        return nil, err
    }
}
