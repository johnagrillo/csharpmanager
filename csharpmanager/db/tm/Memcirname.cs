using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MemCirName]
/// // (
/// // [cir_no] Long Integer,
/// // [cir_name] Text (180),
/// // [tot_lines] Integer,
/// // [tot_dist] Long Integer,
/// // [tot_seconds] Long Integer
/// // );

public class Memcirname(long? cir_no, string cir_name, short? tot_lines, long? tot_dist, long? tot_seconds )
{
static public List<Memcirname> Get(OdbcConnection connection)
{
  var collection = new List<Memcirname>();
  string query = "select * from MemCirName";
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
  var arg1 = reader.GetTextReader(1).ReadLine(); /* cir_name nullable false*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* tot_lines nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* tot_dist nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* tot_seconds nullable true*/
      collection.Add( new Memcirname(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public long? Cir_no{ get; } = cir_no;
  public string Cir_name{ get; } = cir_name;
  public short? Tot_lines{ get; } = tot_lines;
  public long? Tot_dist{ get; } = tot_dist;
  public long? Tot_seconds{ get; } = tot_seconds;
}
}
}
