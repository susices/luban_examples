// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct MailSystemMail : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_2_0_0(); }
  public static MailSystemMail GetRootAsMailSystemMail(ByteBuffer _bb) { return GetRootAsMailSystemMail(_bb, new MailSystemMail()); }
  public static MailSystemMail GetRootAsMailSystemMail(ByteBuffer _bb, MailSystemMail obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MailSystemMail __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Title { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTitleBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTitleArray() { return __p.__vector_as_array<byte>(6); }
  public string Sender { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSenderBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetSenderBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetSenderArray() { return __p.__vector_as_array<byte>(8); }
  public string Content { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetContentBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetContentBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetContentArray() { return __p.__vector_as_array<byte>(10); }
  public int Award(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int AwardLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetAwardBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetAwardBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetAwardArray() { return __p.__vector_as_array<int>(12); }

  public static Offset<cfg.MailSystemMail> CreateMailSystemMail(FlatBufferBuilder builder,
      int id = 0,
      StringOffset titleOffset = default(StringOffset),
      StringOffset senderOffset = default(StringOffset),
      StringOffset contentOffset = default(StringOffset),
      VectorOffset awardOffset = default(VectorOffset)) {
    builder.StartTable(5);
    MailSystemMail.AddAward(builder, awardOffset);
    MailSystemMail.AddContent(builder, contentOffset);
    MailSystemMail.AddSender(builder, senderOffset);
    MailSystemMail.AddTitle(builder, titleOffset);
    MailSystemMail.AddId(builder, id);
    return MailSystemMail.EndMailSystemMail(builder);
  }

  public static void StartMailSystemMail(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset) { builder.AddOffset(1, titleOffset.Value, 0); }
  public static void AddSender(FlatBufferBuilder builder, StringOffset senderOffset) { builder.AddOffset(2, senderOffset.Value, 0); }
  public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset) { builder.AddOffset(3, contentOffset.Value, 0); }
  public static void AddAward(FlatBufferBuilder builder, VectorOffset awardOffset) { builder.AddOffset(4, awardOffset.Value, 0); }
  public static VectorOffset CreateAwardVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAwardVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartAwardVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.MailSystemMail> EndMailSystemMail(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 12);  // award
    return new Offset<cfg.MailSystemMail>(o);
  }
};


}
