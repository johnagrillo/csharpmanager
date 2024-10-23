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
/// CREATE TABLE [ENTRY]
/// (
/// [Meet] Long Integer,
/// [Athlete] Long Integer,
/// [I_R] Text (2),
/// [Team] Long Integer,
/// [Course] Text (4),
/// [Score] Long Integer,
/// [Ex] Text (2),
/// [MtEvent] Long Integer,
/// [Misc] Text (2),
/// [Entry] Long Integer,
/// [Division] Text (6),
/// [HEAT] Byte,
/// [LANE] Byte,
/// [FromOME] Boolean NOT NULL
/// );

public class TmEntry 
{
List<TmEntry> get(OdbcConnection connection)
{
  var collection = new List<TmEntry>();
  string query = "select * from ENTRY";
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
      var arg1 = reader.GetInt64(2); /* Athlete */
      var arg2 = reader.GetTextReader(3).ToString(); /* I_R */
      var arg3 = reader.GetInt64(4); /* Team */
      var arg4 = reader.GetTextReader(5).ToString(); /* Course */
      var arg5 = reader.GetInt64(6); /* Score */
      var arg6 = reader.GetTextReader(7).ToString(); /* Ex */
      var arg7 = reader.GetInt64(8); /* MtEvent */
      var arg8 = reader.GetTextReader(9).ToString(); /* Misc */
      var arg9 = reader.GetInt64(10); /* Entry */
      var arg10 = reader.GetTextReader(11).ToString(); /* Division */
      var arg11 = reader.GetByte(12); /* HEAT */
      var arg12 = reader.GetByte(13); /* LANE */
      var arg13 = reader.GetBoolean(14); /* FromOME */
      collection.Add( new TmEntry(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public long Meet{ get; }
  public long Athlete{ get; }
  public string I_r{ get; }
  public long Team{ get; }
  public string Course{ get; }
  public long Score{ get; }
  public string Ex{ get; }
  public long MtEvent{ get; }
  public string Misc{ get; }
  public long Entry{ get; }
  public string Division{ get; }
  public byte Heat{ get; }
  public byte Lane{ get; }
  public bool FromOME{ get; }
  // Constructor
  TmEntry(long meet, long athlete, string i_r, long team, string course, long score, string ex, long mtEvent, string misc, long entry, string division, byte heat, byte lane, bool fromOME )
  {
    Meet = meet;
    Athlete = athlete;
    I_r = i_r;
    Team = team;
    Course = course;
    Score = score;
    Ex = ex;
    MtEvent = mtEvent;
    Misc = misc;
    Entry = entry;
    Division = division;
    Heat = heat;
    Lane = lane;
    FromOME = fromOME;
  }
}
