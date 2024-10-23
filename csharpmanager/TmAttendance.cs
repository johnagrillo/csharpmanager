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
/// CREATE TABLE [Attendance]
/// (
/// [athlete] Long Integer,
/// [attend_date] DateTime,
/// [morn_aft] Text (2),
/// [attn_stat] Text (2),
/// [actual_dist] Long Integer,
/// [yd_mtr] Text (2)
/// );

public class TmAttendance 
{
List<TmAttendance> get(OdbcConnection connection)
{
  var collection = new List<TmAttendance>();
  string query = "select * from Attendance";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* athlete */
      var arg1 = reader.GetDateTime(2); /* attend_date */
      var arg2 = reader.GetTextReader(3).ToString(); /* morn_aft */
      var arg3 = reader.GetTextReader(4).ToString(); /* attn_stat */
      var arg4 = reader.GetInt64(5); /* actual_dist */
      var arg5 = reader.GetTextReader(6).ToString(); /* yd_mtr */
      collection.Add( new TmAttendance(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long Athlete{ get; }
  public DateTime Attend_date{ get; }
  public string Morn_aft{ get; }
  public string Attn_stat{ get; }
  public long Actual_dist{ get; }
  public string Yd_mtr{ get; }
  // Constructor
  TmAttendance(long athlete, DateTime attend_date, string morn_aft, string attn_stat, long actual_dist, string yd_mtr )
  {
    Athlete = athlete;
    Attend_date = attend_date;
    Morn_aft = morn_aft;
    Attn_stat = attn_stat;
    Actual_dist = actual_dist;
    Yd_mtr = yd_mtr;
  }
}
