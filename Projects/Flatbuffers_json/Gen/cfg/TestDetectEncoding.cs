// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct TestDetectEncoding : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static TestDetectEncoding GetRootAsTestDetectEncoding(ByteBuffer _bb) { return GetRootAsTestDetectEncoding(_bb, new TestDetectEncoding()); }
  public static TestDetectEncoding GetRootAsTestDetectEncoding(ByteBuffer _bb, TestDetectEncoding obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestDetectEncoding __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<cfg.TestDetectEncoding> CreateTestDetectEncoding(FlatBufferBuilder builder,
      int id = 0,
      StringOffset nameOffset = default(StringOffset)) {
    builder.StartTable(2);
    TestDetectEncoding.AddName(builder, nameOffset);
    TestDetectEncoding.AddId(builder, id);
    return TestDetectEncoding.EndTestDetectEncoding(builder);
  }

  public static void StartTestDetectEncoding(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static Offset<cfg.TestDetectEncoding> EndTestDetectEncoding(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestDetectEncoding>(o);
  }
};


}
