// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class Grid : Struct {
  public Grid __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int X { get { return bb.GetInt(bb_pos + 0); } }
  public int Y { get { return bb.GetInt(bb_pos + 4); } }

  public static Offset<Grid> CreateGrid(FlatBufferBuilder builder, int X, int Y) {
    builder.Prep(4, 8);
    builder.PutInt(Y);
    builder.PutInt(X);
    return new Offset<Grid>(builder.Offset);
  }
};
