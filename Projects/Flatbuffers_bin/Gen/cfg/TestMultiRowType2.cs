// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TestMultiRowType2 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static TestMultiRowType2 GetRootAsTestMultiRowType2(ByteBuffer _bb) { return GetRootAsTestMultiRowType2(_bb, new TestMultiRowType2()); }
  public static TestMultiRowType2 GetRootAsTestMultiRowType2(ByteBuffer _bb, TestMultiRowType2 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestMultiRowType2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Y { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<cfg.TestMultiRowType2> CreateTestMultiRowType2(FlatBufferBuilder builder,
      int id = 0,
      int x = 0,
      float y = 0.0f) {
    builder.StartTable(3);
    TestMultiRowType2.AddY(builder, y);
    TestMultiRowType2.AddX(builder, x);
    TestMultiRowType2.AddId(builder, id);
    return TestMultiRowType2.EndTestMultiRowType2(builder);
  }

  public static void StartTestMultiRowType2(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddX(FlatBufferBuilder builder, int x) { builder.AddInt(1, x, 0); }
  public static void AddY(FlatBufferBuilder builder, float y) { builder.AddFloat(2, y, 0.0f); }
  public static Offset<cfg.TestMultiRowType2> EndTestMultiRowType2(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestMultiRowType2>(o);
  }
};


}
