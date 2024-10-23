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
/// CREATE TABLE [modt30times]
/// (
/// [athlete] Long Integer,
/// [event_no] Integer,
/// [course_yls] Text (2),
/// [event_dist] Long Integer,
/// [event_time] Long Integer,
/// [shave_type] Text (2)
/// );

public class TmModt30times 
{
List<TmModt30times> get(OdbcConnection connection)
{
  var collection = new List<TmModt30times>();
  string query = "select * from modt30times";
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
      var arg1 = reader.GetInt16(2); /* event_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* course_yls */
      var arg3 = reader.GetInt64(4); /* event_dist */
      var arg4 = reader.GetInt64(5); /* event_time */
      var arg5 = reader.GetTextReader(6).ToString(); /* shave_type */
      collection.Add( new TmModt30times(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long Athlete{ get; }
  public short Event_no{ get; }
  public string Course_yls{ get; }
  public long Event_dist{ get; }
  public long Event_time{ get; }
  public string Shave_type{ get; }
  // Constructor
  TmModt30times(long athlete, short event_no, string course_yls, long event_dist, long event_time, string shave_type )
  {
    Athlete = athlete;
    Event_no = event_no;
    Course_yls = course_yls;
    Event_dist = event_dist;
    Event_time = event_time;
    Shave_type = shave_type;
  }
}
