
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
package cfg

import (
    "bright/serialization"
)



type Test_TestJson2 struct {
    Id int32
    M1 map[int32]int32
    M2 map[int64]int32
    M3 map[string]int32
    M4 map[string]*Test_DemoType1
}

func (Test_TestJson2) GetTypeId() int {
    return 1942237276
}

func NewTest_TestJson2(_buf *serialization.ByteBuf) (_v *Test_TestJson2, err error) {
    _v = &Test_TestJson2{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { return } }
    {
                _v.M1 = make(map[int32]int32)
                var _n_ int
                if _n_, err = _buf.ReadSize(); err != nil {return}
                for i := 0 ; i < _n_ ; i++ {
                    var _key_ int32
                    { if _key_, err = _buf.ReadInt(); err != nil { return } }
                    var _value_ int32
                    { if _value_, err = _buf.ReadInt(); err != nil { return } }
                    _v.M1[_key_] = _value_
                }
                }
    {
                _v.M2 = make(map[int64]int32)
                var _n_ int
                if _n_, err = _buf.ReadSize(); err != nil {return}
                for i := 0 ; i < _n_ ; i++ {
                    var _key_ int64
                    { if _key_, err = _buf.ReadLong(); err != nil { return } }
                    var _value_ int32
                    { if _value_, err = _buf.ReadInt(); err != nil { return } }
                    _v.M2[_key_] = _value_
                }
                }
    {
                _v.M3 = make(map[string]int32)
                var _n_ int
                if _n_, err = _buf.ReadSize(); err != nil {return}
                for i := 0 ; i < _n_ ; i++ {
                    var _key_ string
                    { if _key_, err = _buf.ReadString(); err != nil { return } }
                    var _value_ int32
                    { if _value_, err = _buf.ReadInt(); err != nil { return } }
                    _v.M3[_key_] = _value_
                }
                }
    {
                _v.M4 = make(map[string]*Test_DemoType1)
                var _n_ int
                if _n_, err = _buf.ReadSize(); err != nil {return}
                for i := 0 ; i < _n_ ; i++ {
                    var _key_ string
                    { if _key_, err = _buf.ReadString(); err != nil { return } }
                    var _value_ *Test_DemoType1
                    { if _value_, err = NewTest_DemoType1(_buf); err != nil { return } }
                    _v.M4[_key_] = _value_
                }
                }
    return
}

