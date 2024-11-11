using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [Workout]
/// // (
/// // [wk_ptr] Long Integer,
/// // [wk_line] Integer,
/// // [wk_type] Text (2),
/// // [circuit_line] Integer,
/// // [circuit_tot] Integer,
/// // [circuit_reps] Integer,
/// // [set_reps] Long Integer,
/// // [set_dist] Long Integer,
/// // [set_interval] Long Integer,
/// // [set_desc] Text (64),
/// // [set_note] Text (110),
/// // [set_energyno] Integer,
/// // [set_type] Text (8),
/// // [set_categoryabbr] Text (6),
/// // [tot_yards] Long Integer,
/// // [set_starttime] Long Integer,
/// // [set_finishtime] Long Integer
/// // );

public class Workout(long? wk_ptr, short? wk_line, string wk_type, short? circuit_line, short? circuit_tot, short? circuit_reps, long? set_reps, long? set_dist, long? set_interval, string set_desc, string set_note, short? set_energyno, string set_type, string set_categoryabbr, long? tot_yards, long? set_starttime, long? set_finishtime )
{
static public List<Workout> Get(OdbcConnection connection)
{
  var collection = new List<Workout>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* wk_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* wk_line nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* wk_type nullable false*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* circuit_line nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* circuit_tot nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* circuit_reps nullable true*/
  var arg6 = reader.IsDBNull(6) ? (long?)null :reader.GetInt32(6); /* set_reps nullable true*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* set_dist nullable true*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* set_interval nullable true*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* set_desc nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* set_note nullable false*/
  var arg11 = reader.IsDBNull(11) ? (short?)null :reader.GetInt16(11); /* set_energyno nullable true*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* set_type nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* set_categoryabbr nullable false*/
  var arg14 = reader.IsDBNull(14) ? (long?)null :reader.GetInt32(14); /* tot_yards nullable true*/
  var arg15 = reader.IsDBNull(15) ? (long?)null :reader.GetInt32(15); /* set_starttime nullable true*/
  var arg16 = reader.IsDBNull(16) ? (long?)null :reader.GetInt32(16); /* set_finishtime nullable true*/
      collection.Add( new Workout(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
    }
  }
  return collection;
}
  // Properties
  public long? Wk_ptr{ get; } = wk_ptr;
  public short? Wk_line{ get; } = wk_line;
  public string Wk_type{ get; } = wk_type;
  public short? Circuit_line{ get; } = circuit_line;
  public short? Circuit_tot{ get; } = circuit_tot;
  public short? Circuit_reps{ get; } = circuit_reps;
  public long? Set_reps{ get; } = set_reps;
  public long? Set_dist{ get; } = set_dist;
  public long? Set_interval{ get; } = set_interval;
  public string Set_desc{ get; } = set_desc;
  public string Set_note{ get; } = set_note;
  public short? Set_energyno{ get; } = set_energyno;
  public string Set_type{ get; } = set_type;
  public string Set_categoryabbr{ get; } = set_categoryabbr;
  public long? Tot_yards{ get; } = tot_yards;
  public long? Set_starttime{ get; } = set_starttime;
  public long? Set_finishtime{ get; } = set_finishtime;
}
}
}
