using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [TestLine]
/// // (
/// // [test_no] Long Integer,
/// // [athlete] Long Integer,
/// // [rep_no] Integer,
/// // [rep_time] Long Integer
/// // );

public class Testline(long? test_no, long? athlete, short? rep_no, long? rep_time )
{
static public List<Testline> Get(OdbcConnection connection)
{
  var collection = new List<Testline>();
  string query = "select * from TestLine";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* test_no nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* athlete nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* rep_no nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* rep_time nullable true*/
      collection.Add( new Testline(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long? Test_no{ get; } = test_no;
  public long? Athlete{ get; } = athlete;
  public short? Rep_no{ get; } = rep_no;
  public long? Rep_time{ get; } = rep_time;
}
}
}
