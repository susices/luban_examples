// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TestTbTestRef : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static TestTbTestRef GetRootAsTestTbTestRef(ByteBuffer _bb) { return GetRootAsTestTbTestRef(_bb, new TestTbTestRef()); }
  public static TestTbTestRef GetRootAsTestTbTestRef(ByteBuffer _bb, TestTbTestRef obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestTbTestRef __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.TestTestRef? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (cfg.TestTestRef?)(new cfg.TestTestRef()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<cfg.TestTbTestRef> CreateTestTbTestRef(FlatBufferBuilder builder,
      VectorOffset data_listOffset = default(VectorOffset)) {
    builder.StartTable(1);
    TestTbTestRef.AddDataList(builder, data_listOffset);
    return TestTbTestRef.EndTestTbTestRef(builder);
  }

  public static void StartTestTbTestRef(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<cfg.TestTestRef>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<cfg.TestTestRef>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.TestTbTestRef> EndTestTbTestRef(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // data_list
    return new Offset<cfg.TestTbTestRef>(o);
  }
};


}
