using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MTEVENTE]
/// // (
/// // [Meet] Long Integer,
/// // [MtEv] Integer,
/// // [MtEvX] Text (2),
/// // [Lo_Hi] Integer,
/// // [FastCut] Long Integer,
/// // [SlowCut] Long Integer,
/// // [Course] Text (2),
/// // [MtEvent] Long Integer,
/// // [Fast_L] Long Integer,
/// // [Slow_L] Long Integer,
/// // [Fast_Y] Long Integer,
/// // [Slow_Y] Long Integer,
/// // [TstdFile] Text (16),
/// // [TstDesig] Text (8),
/// // [Distance] Integer,
/// // [Stroke] Integer,
/// // [Sex] Text (2),
/// // [I_R] Text (2),
/// // [Session] Byte,
/// // [Division] Text (6),
/// // [Fee] Single,
/// // [ExportEvent] Text (8),
/// // [GenderMix] Byte,
/// // [SessX] Text (2)
/// // );

public class Mtevente(long? meet, short? mtEv, string mtEvX, short? loHi, long? fastCut, long? slowCut, string course, long? mtEvent, long? fastL, long? slowL, long? fastY, long? slowY, string tstdFile, string tstDesig, short? distance, short? stroke, string sex, string i_r, byte? session, string division, float? fee, string exportEvent, byte? genderMix, string sessX )
{
static public List<Mtevente> Get(OdbcConnection connection)
{
  var collection = new List<Mtevente>();
  string query = "select * from MTEVENTE";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Meet nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* MtEv nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* MtEvX nullable false*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Lo_Hi nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* FastCut nullable true*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* SlowCut nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* Course nullable false*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* MtEvent nullable true*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* Fast_L nullable true*/
  var arg9 = reader.IsDBNull(9) ? (long?)null :reader.GetInt32(9); /* Slow_L nullable true*/
  var arg10 = reader.IsDBNull(10) ? (long?)null :reader.GetInt32(10); /* Fast_Y nullable true*/
  var arg11 = reader.IsDBNull(11) ? (long?)null :reader.GetInt32(11); /* Slow_Y nullable true*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* TstdFile nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* TstDesig nullable false*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* Distance nullable true*/
  var arg15 = reader.IsDBNull(15) ? (short?)null :reader.GetInt16(15); /* Stroke nullable true*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Sex nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* I_R nullable false*/
  var arg18 = reader.IsDBNull(18) ? (byte?)null :reader.GetByte(18); /* Session nullable true*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* Division nullable false*/
  var arg20 = reader.IsDBNull(20) ? (float?)null :reader.GetFloat(20); /* Fee nullable true*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* ExportEvent nullable false*/
  var arg22 = reader.IsDBNull(22) ? (byte?)null :reader.GetByte(22); /* GenderMix nullable true*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* SessX nullable false*/
      collection.Add( new Mtevente(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23));
    }
  }
  return collection;
}
  // Properties
  public long? Meet{ get; } = meet;
  public short? MtEv{ get; } = mtEv;
  public string MtEvX{ get; } = mtEvX;
  public short? LoHi{ get; } = loHi;
  public long? FastCut{ get; } = fastCut;
  public long? SlowCut{ get; } = slowCut;
  public string Course{ get; } = course;
  public long? MtEvent{ get; } = mtEvent;
  public long? FastL{ get; } = fastL;
  public long? SlowL{ get; } = slowL;
  public long? FastY{ get; } = fastY;
  public long? SlowY{ get; } = slowY;
  public string TstdFile{ get; } = tstdFile;
  public string TstDesig{ get; } = tstDesig;
  public short? Distance{ get; } = distance;
  public short? Stroke{ get; } = stroke;
  public string Sex{ get; } = sex;
  public string I_r{ get; } = i_r;
  public byte? Session{ get; } = session;
  public string Division{ get; } = division;
  public float? Fee{ get; } = fee;
  public string ExportEvent{ get; } = exportEvent;
  public byte? GenderMix{ get; } = genderMix;
  public string SessX{ get; } = sessX;
}
}
}
