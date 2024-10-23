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
/// CREATE TABLE [Workout]
/// (
/// [wk_ptr] Long Integer,
/// [wk_line] Integer,
/// [wk_type] Text (2),
/// [circuit_line] Integer,
/// [circuit_tot] Integer,
/// [circuit_reps] Integer,
/// [set_reps] Long Integer,
/// [set_dist] Long Integer,
/// [set_interval] Long Integer,
/// [set_desc] Text (64),
/// [set_note] Text (110),
/// [set_energyno] Integer,
/// [set_type] Text (8),
/// [set_categoryabbr] Text (6),
/// [tot_yards] Long Integer,
/// [set_starttime] Long Integer,
/// [set_finishtime] Long Integer
/// );

public class TmWorkout 
{
List<TmWorkout> get(OdbcConnection connection)
{
  var collection = new List<TmWorkout>();
  string query = "select * from Workout";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* wk_ptr */
      var arg1 = reader.GetInt16(2); /* wk_line */
      var arg2 = reader.GetTextReader(3).ToString(); /* wk_type */
      var arg3 = reader.GetInt16(4); /* circuit_line */
      var arg4 = reader.GetInt16(5); /* circuit_tot */
      var arg5 = reader.GetInt16(6); /* circuit_reps */
      var arg6 = reader.GetInt64(7); /* set_reps */
      var arg7 = reader.GetInt64(8); /* set_dist */
      var arg8 = reader.GetInt64(9); /* set_interval */
      var arg9 = reader.GetTextReader(10).ToString(); /* set_desc */
      var arg10 = reader.GetTextReader(11).ToString(); /* set_note */
      var arg11 = reader.GetInt16(12); /* set_energyno */
      var arg12 = reader.GetTextReader(13).ToString(); /* set_type */
      var arg13 = reader.GetTextReader(14).ToString(); /* set_categoryabbr */
      var arg14 = reader.GetInt64(15); /* tot_yards */
      var arg15 = reader.GetInt64(16); /* set_starttime */
      var arg16 = reader.GetInt64(17); /* set_finishtime */
      collection.Add( new TmWorkout(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
    }
  }
  return collection;
}
  // Properties
  public long Wk_ptr{ get; }
  public short Wk_line{ get; }
  public string Wk_type{ get; }
  public short Circuit_line{ get; }
  public short Circuit_tot{ get; }
  public short Circuit_reps{ get; }
  public long Set_reps{ get; }
  public long Set_dist{ get; }
  public long Set_interval{ get; }
  public string Set_desc{ get; }
  public string Set_note{ get; }
  public short Set_energyno{ get; }
  public string Set_type{ get; }
  public string Set_categoryabbr{ get; }
  public long Tot_yards{ get; }
  public long Set_starttime{ get; }
  public long Set_finishtime{ get; }
  // Constructor
  TmWorkout(long wk_ptr, short wk_line, string wk_type, short circuit_line, short circuit_tot, short circuit_reps, long set_reps, long set_dist, long set_interval, string set_desc, string set_note, short set_energyno, string set_type, string set_categoryabbr, long tot_yards, long set_starttime, long set_finishtime )
  {
    Wk_ptr = wk_ptr;
    Wk_line = wk_line;
    Wk_type = wk_type;
    Circuit_line = circuit_line;
    Circuit_tot = circuit_tot;
    Circuit_reps = circuit_reps;
    Set_reps = set_reps;
    Set_dist = set_dist;
    Set_interval = set_interval;
    Set_desc = set_desc;
    Set_note = set_note;
    Set_energyno = set_energyno;
    Set_type = set_type;
    Set_categoryabbr = set_categoryabbr;
    Tot_yards = tot_yards;
    Set_starttime = set_starttime;
    Set_finishtime = set_finishtime;
  }
}
