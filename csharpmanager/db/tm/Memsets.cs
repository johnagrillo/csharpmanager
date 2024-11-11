using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MemSets]
/// // (
/// // [set_no] Long Integer,
/// // [set_reps] Long Integer,
/// // [set_dist] Long Integer,
/// // [set_interval] Long Integer,
/// // [set_desc] Text (64),
/// // [set_energyno] Integer,
/// // [set_type] Text (8),
/// // [set_categoryabbr] Text (6)
/// // );

public class Memsets(long? set_no, long? set_reps, long? set_dist, long? set_interval, string set_desc, short? set_energyno, string set_type, string set_categoryabbr )
{
static public List<Memsets> Get(OdbcConnection connection)
{
  var collection = new List<Memsets>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* set_no nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* set_reps nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* set_dist nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* set_interval nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* set_desc nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* set_energyno nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* set_type nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* set_categoryabbr nullable false*/
      collection.Add( new Memsets(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long? Set_no{ get; } = set_no;
  public long? Set_reps{ get; } = set_reps;
  public long? Set_dist{ get; } = set_dist;
  public long? Set_interval{ get; } = set_interval;
  public string Set_desc{ get; } = set_desc;
  public short? Set_energyno{ get; } = set_energyno;
  public string Set_type{ get; } = set_type;
  public string Set_categoryabbr{ get; } = set_categoryabbr;
}
}
}
