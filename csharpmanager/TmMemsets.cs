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
/// CREATE TABLE [MemSets]
/// (
/// [set_no] Long Integer,
/// [set_reps] Long Integer,
/// [set_dist] Long Integer,
/// [set_interval] Long Integer,
/// [set_desc] Text (64),
/// [set_energyno] Integer,
/// [set_type] Text (8),
/// [set_categoryabbr] Text (6)
/// );

public class TmMemsets 
{
List<TmMemsets> get(OdbcConnection connection)
{
  var collection = new List<TmMemsets>();
  string query = "select * from MemSets";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* set_no */
      var arg1 = reader.GetInt64(2); /* set_reps */
      var arg2 = reader.GetInt64(3); /* set_dist */
      var arg3 = reader.GetInt64(4); /* set_interval */
      var arg4 = reader.GetTextReader(5).ToString(); /* set_desc */
      var arg5 = reader.GetInt16(6); /* set_energyno */
      var arg6 = reader.GetTextReader(7).ToString(); /* set_type */
      var arg7 = reader.GetTextReader(8).ToString(); /* set_categoryabbr */
      collection.Add( new TmMemsets(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long Set_no{ get; }
  public long Set_reps{ get; }
  public long Set_dist{ get; }
  public long Set_interval{ get; }
  public string Set_desc{ get; }
  public short Set_energyno{ get; }
  public string Set_type{ get; }
  public string Set_categoryabbr{ get; }
  // Constructor
  TmMemsets(long set_no, long set_reps, long set_dist, long set_interval, string set_desc, short set_energyno, string set_type, string set_categoryabbr )
  {
    Set_no = set_no;
    Set_reps = set_reps;
    Set_dist = set_dist;
    Set_interval = set_interval;
    Set_desc = set_desc;
    Set_energyno = set_energyno;
    Set_type = set_type;
    Set_categoryabbr = set_categoryabbr;
  }
}
