// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct BlueprintTbClazz : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static BlueprintTbClazz GetRootAsBlueprintTbClazz(ByteBuffer _bb) { return GetRootAsBlueprintTbClazz(_bb, new BlueprintTbClazz()); }
  public static BlueprintTbClazz GetRootAsBlueprintTbClazz(ByteBuffer _bb, BlueprintTbClazz obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BlueprintTbClazz __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.BlueprintClazz DataListType(int j) { int o = __p.__offset(4); return o != 0 ? (cfg.BlueprintClazz)__p.bb.Get(__p.__vector(o) + j * 1) : (cfg.BlueprintClazz)0; }
  public int DataListTypeLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<cfg.BlueprintClazz> GetDataListTypeBytes() { return __p.__vector_as_span<cfg.BlueprintClazz>(4, 1); }
#else
  public ArraySegment<byte>? GetDataListTypeBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public cfg.BlueprintClazz[] GetDataListTypeArray() { int o = __p.__offset(4); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); cfg.BlueprintClazz[] a = new cfg.BlueprintClazz[l]; for (int i = 0; i < l; i++) { a[i] = (cfg.BlueprintClazz)__p.bb.Get(p + i * 1); } return a; }
  public TTable? DataList<TTable>(int j) where TTable : struct, IFlatbufferObject { int o = __p.__offset(6); return o != 0 ? (TTable?)__p.__union<TTable>(__p.__vector(o) + j * 4) : null; }
  public int DataListLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<cfg.BlueprintTbClazz> CreateBlueprintTbClazz(FlatBufferBuilder builder,
      VectorOffset data_list_typeOffset = default(VectorOffset),
      VectorOffset data_listOffset = default(VectorOffset)) {
    builder.StartTable(2);
    BlueprintTbClazz.AddDataList(builder, data_listOffset);
    BlueprintTbClazz.AddDataListType(builder, data_list_typeOffset);
    return BlueprintTbClazz.EndBlueprintTbClazz(builder);
  }

  public static void StartBlueprintTbClazz(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddDataListType(FlatBufferBuilder builder, VectorOffset dataListTypeOffset) { builder.AddOffset(0, dataListTypeOffset.Value, 0); }
  public static VectorOffset CreateDataListTypeVector(FlatBufferBuilder builder, cfg.BlueprintClazz[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte((byte)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataListTypeVectorBlock(FlatBufferBuilder builder, cfg.BlueprintClazz[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static void StartDataListTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(1, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.BlueprintTbClazz> EndBlueprintTbClazz(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // data_list_type
    builder.Required(o, 6);  // data_list
    return new Offset<cfg.BlueprintTbClazz>(o);
  }
};


}
