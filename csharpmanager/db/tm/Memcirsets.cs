using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MemCirSets]
/// // (
/// // [cir_no] Long Integer,
/// // [circuit_line] Integer,
/// // [set_reps] Long Integer,
/// // [set_dist] Long Integer,
/// // [set_interval] Long Integer,
/// // [set_desc] Text (64),
/// // [set_energyno] Integer,
/// // [set_type] Text (8),
/// // [set_categoryabbr] Text (6)
/// // );

public class Memcirsets(long? cir_no, short? circuit_line, long? set_reps, long? set_dist, long? set_interval, string set_desc, short? set_energyno, string set_type, string set_categoryabbr )
{
static public List<Memcirsets> Get(OdbcConnection connection)
{
  var collection = new List<Memcirsets>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* cir_no nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* circuit_line nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* set_reps nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* set_dist nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* set_interval nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* set_desc nullable false*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* set_energyno nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* set_type nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* set_categoryabbr nullable false*/
      collection.Add( new Memcirsets(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }
  }
  return collection;
}
  // Properties
  public long? Cir_no{ get; } = cir_no;
  public short? Circuit_line{ get; } = circuit_line;
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
