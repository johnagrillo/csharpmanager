using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Agegroup]
/// // (
/// // [Low_age] Integer,
/// // [High_age] Integer
/// // );

public class Agegroup(short? lowAge, short? highAge )
{
static public List<Agegroup> Get(OdbcConnection connection)
{
  var collection = new List<Agegroup>();
  string query = "select * from Agegroup";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* Low_age nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* High_age nullable true*/
      collection.Add( new Agegroup(arg0, arg1));
    }
  }
  return collection;
}
  // Properties
  public short? LowAge{ get; } = lowAge;
  public short? HighAge{ get; } = highAge;
}
}
}
