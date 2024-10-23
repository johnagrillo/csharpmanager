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
/// CREATE TABLE [MemCirSets]
/// (
/// [cir_no] Long Integer,
/// [circuit_line] Integer,
/// [set_reps] Long Integer,
/// [set_dist] Long Integer,
/// [set_interval] Long Integer,
/// [set_desc] Text (64),
/// [set_energyno] Integer,
/// [set_type] Text (8),
/// [set_categoryabbr] Text (6)
/// );

public class TmMemcirsets 
{
List<TmMemcirsets> get(OdbcConnection connection)
{
  var collection = new List<TmMemcirsets>();
  string query = "select * from MemCirSets";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* cir_no */
      var arg1 = reader.GetInt16(2); /* circuit_line */
      var arg2 = reader.GetInt64(3); /* set_reps */
      var arg3 = reader.GetInt64(4); /* set_dist */
      var arg4 = reader.GetInt64(5); /* set_interval */
      var arg5 = reader.GetTextReader(6).ToString(); /* set_desc */
      var arg6 = reader.GetInt16(7); /* set_energyno */
      var arg7 = reader.GetTextReader(8).ToString(); /* set_type */
      var arg8 = reader.GetTextReader(9).ToString(); /* set_categoryabbr */
      collection.Add( new TmMemcirsets(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }
  }
  return collection;
}
  // Properties
  public long Cir_no{ get; }
  public short Circuit_line{ get; }
  public long Set_reps{ get; }
  public long Set_dist{ get; }
  public long Set_interval{ get; }
  public string Set_desc{ get; }
  public short Set_energyno{ get; }
  public string Set_type{ get; }
  public string Set_categoryabbr{ get; }
  // Constructor
  TmMemcirsets(long cir_no, short circuit_line, long set_reps, long set_dist, long set_interval, string set_desc, short set_energyno, string set_type, string set_categoryabbr )
  {
    Cir_no = cir_no;
    Circuit_line = circuit_line;
    Set_reps = set_reps;
    Set_dist = set_dist;
    Set_interval = set_interval;
    Set_desc = set_desc;
    Set_energyno = set_energyno;
    Set_type = set_type;
    Set_categoryabbr = set_categoryabbr;
  }
}
