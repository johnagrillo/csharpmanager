using System;
using System.Collections.Generic;
using System.Data.Odbc;
/// -- ----------------------------------------------------------
/// -- MDB Tools - A library for reading MS Access database files
/// -- Copyright (C) 2000-2011 Brian Bruns and others.
/// -- Files in libmdb are licensed under LGPL and the utilities under
/// -- the GPL, see COPYING.LIB and COPYING files respectively.
/// -- Check out http://mdbtools.sourceforge.net
/// -- ----------------------------------------------------------
/// 
/// -- That file uses encoding UTF-8
/// 
/// CREATE TABLE [MTEVENTE]
/// (
/// [Meet] Long Integer,
/// [MtEv] Integer,
/// [MtEvX] Text (2),
/// [Lo_Hi] Integer,
/// [FastCut] Long Integer,
/// [SlowCut] Long Integer,
/// [Course] Text (2),
/// [MtEvent] Long Integer,
/// [Fast_L] Long Integer,
/// [Slow_L] Long Integer,
/// [Fast_Y] Long Integer,
/// [Slow_Y] Long Integer,
/// [TstdFile] Text (16),
/// [TstDesig] Text (8),
/// [Distance] Integer,
/// [Stroke] Integer,
/// [Sex] Text (2),
/// [I_R] Text (2),
/// [Session] Byte,
/// [Division] Text (6),
/// [Fee] Single,
/// [ExportEvent] Text (8),
/// [GenderMix] Byte,
/// [SessX] Text (2)
/// );

public class TmMtevente 
{
Dictionary<long,TmMtevente> get(OdbcConnection connection)
{
  var collection = new Dictionary<long,TmMtevente>();
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
      var arg0 = reader.GetInt64(1); /* Meet */
      var arg1 = reader.GetInt16(2); /* MtEv */
      var arg2 = reader.GetTextReader(3).ToString(); /* MtEvX */
      var arg3 = reader.GetInt16(4); /* Lo_Hi */
      var arg4 = reader.GetInt64(5); /* FastCut */
      var arg5 = reader.GetInt64(6); /* SlowCut */
      var arg6 = reader.GetTextReader(7).ToString(); /* Course */
      var arg7 = reader.GetInt64(8); /* MtEvent */
      var arg8 = reader.GetInt64(9); /* Fast_L */
      var arg9 = reader.GetInt64(10); /* Slow_L */
      var arg10 = reader.GetInt64(11); /* Fast_Y */
      var arg11 = reader.GetInt64(12); /* Slow_Y */
      var arg12 = reader.GetTextReader(13).ToString(); /* TstdFile */
      var arg13 = reader.GetTextReader(14).ToString(); /* TstDesig */
      var arg14 = reader.GetInt16(15); /* Distance */
      var arg15 = reader.GetInt16(16); /* Stroke */
      var arg16 = reader.GetTextReader(17).ToString(); /* Sex */
      var arg17 = reader.GetTextReader(18).ToString(); /* I_R */
      var arg18 = reader.GetByte(19); /* Session */
      var arg19 = reader.GetTextReader(20).ToString(); /* Division */
      var arg20 = reader.GetFloat(21); /* Fee */
      var arg21 = reader.GetTextReader(22).ToString(); /* ExportEvent */
      var arg22 = reader.GetByte(23); /* GenderMix */
      var arg23 = reader.GetTextReader(24).ToString(); /* SessX */
      var obj = new TmMtevente(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
      collection[obj.MtEvent] = obj;
    }
  }
  return collection;
}
  // Properties
  public long Meet{ get; }
  public short MtEv{ get; }
  public string MtEvX{ get; }
  public short LoHi{ get; }
  public long FastCut{ get; }
  public long SlowCut{ get; }
  public string Course{ get; }
  public long MtEvent{ get; }
  public long FastL{ get; }
  public long SlowL{ get; }
  public long FastY{ get; }
  public long SlowY{ get; }
  public string TstdFile{ get; }
  public string TstDesig{ get; }
  public short Distance{ get; }
  public short Stroke{ get; }
  public string Sex{ get; }
  public string I_r{ get; }
  public byte Session{ get; }
  public string Division{ get; }
  public float Fee{ get; }
  public string ExportEvent{ get; }
  public byte GenderMix{ get; }
  public string SessX{ get; }
  // Constructor
  TmMtevente(long meet, short mtEv, string mtEvX, short loHi, long fastCut, long slowCut, string course, long mtEvent, long fastL, long slowL, long fastY, long slowY, string tstdFile, string tstDesig, short distance, short stroke, string sex, string i_r, byte session, string division, float fee, string exportEvent, byte genderMix, string sessX )
  {
    Meet = meet;
    MtEv = mtEv;
    MtEvX = mtEvX;
    LoHi = loHi;
    FastCut = fastCut;
    SlowCut = slowCut;
    Course = course;
    MtEvent = mtEvent;
    FastL = fastL;
    SlowL = slowL;
    FastY = fastY;
    SlowY = slowY;
    TstdFile = tstdFile;
    TstDesig = tstDesig;
    Distance = distance;
    Stroke = stroke;
    Sex = sex;
    I_r = i_r;
    Session = session;
    Division = division;
    Fee = fee;
    ExportEvent = exportEvent;
    GenderMix = genderMix;
    SessX = sessX;
  }
}
