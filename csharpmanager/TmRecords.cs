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
/// CREATE TABLE [RECORDS]
/// (
/// [Record] Long Integer,
/// [Lo_Age] Integer,
/// [Hi_Age] Integer,
/// [RecText] Text (160),
/// [RecDate] DateTime,
/// [RecTime] Long Integer,
/// [RecLSC] Text (6),
/// [RecTeam] Text (10),
/// [Ex] Text (2),
/// [Distance] Integer,
/// [Stroke] Integer,
/// [Sex] Text (2),
/// [I_R] Text (2),
/// [Rec] Long Integer,
/// [Course] Text (2),
/// [Division] Text (4)
/// );

public class TmRecords 
{
List<TmRecords> get(OdbcConnection connection)
{
  var collection = new List<TmRecords>();
  string query = "select * from RECORDS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Record */
      var arg1 = reader.GetInt16(2); /* Lo_Age */
      var arg2 = reader.GetInt16(3); /* Hi_Age */
      var arg3 = reader.GetTextReader(4).ToString(); /* RecText */
      var arg4 = reader.GetDateTime(5); /* RecDate */
      var arg5 = reader.GetInt64(6); /* RecTime */
      var arg6 = reader.GetTextReader(7).ToString(); /* RecLSC */
      var arg7 = reader.GetTextReader(8).ToString(); /* RecTeam */
      var arg8 = reader.GetTextReader(9).ToString(); /* Ex */
      var arg9 = reader.GetInt16(10); /* Distance */
      var arg10 = reader.GetInt16(11); /* Stroke */
      var arg11 = reader.GetTextReader(12).ToString(); /* Sex */
      var arg12 = reader.GetTextReader(13).ToString(); /* I_R */
      var arg13 = reader.GetInt64(14); /* Rec */
      var arg14 = reader.GetTextReader(15).ToString(); /* Course */
      var arg15 = reader.GetTextReader(16).ToString(); /* Division */
      collection.Add( new TmRecords(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
    }
  }
  return collection;
}
  // Properties
  public long Record{ get; }
  public short LoAge{ get; }
  public short HiAge{ get; }
  public string RecText{ get; }
  public DateTime RecDate{ get; }
  public long RecTime{ get; }
  public string RecLSC{ get; }
  public string RecTeam{ get; }
  public string Ex{ get; }
  public short Distance{ get; }
  public short Stroke{ get; }
  public string Sex{ get; }
  public string I_r{ get; }
  public long Rec{ get; }
  public string Course{ get; }
  public string Division{ get; }
  // Constructor
  TmRecords(long record, short loAge, short hiAge, string recText, DateTime recDate, long recTime, string recLSC, string recTeam, string ex, short distance, short stroke, string sex, string i_r, long rec, string course, string division )
  {
    Record = record;
    LoAge = loAge;
    HiAge = hiAge;
    RecText = recText;
    RecDate = recDate;
    RecTime = recTime;
    RecLSC = recLSC;
    RecTeam = recTeam;
    Ex = ex;
    Distance = distance;
    Stroke = stroke;
    Sex = sex;
    I_r = i_r;
    Rec = rec;
    Course = course;
    Division = division;
  }
}
