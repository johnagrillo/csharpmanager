using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [MultiageScnd]
/// // (
/// // [event_ptr] Long Integer,
/// // [low_age] Integer,
/// // [high_age] Integer
/// // );

public class Multiagescnd(long? event_ptr, short? low_age, short? high_age )
{
static public List<Multiagescnd> Get(OdbcConnection connection)
{
  var collection = new List<Multiagescnd>();
  string query = "select * from MultiageScnd";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* event_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* low_age nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* high_age nullable true*/
      collection.Add( new Multiagescnd(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public long? Event_ptr{ get; } = event_ptr;
  public short? Low_age{ get; } = low_age;
  public short? High_age{ get; } = high_age;
}
}
}
