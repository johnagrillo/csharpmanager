using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [DELETEENTRY]
/// // (
/// // [Meet] Long Integer,
/// // [Athlete] Long Integer,
/// // [MtEvent] Long Integer
/// // );

public class Deleteentry(long? meet, long? athlete, long? mtEvent )
{
static public List<Deleteentry> Get(OdbcConnection connection)
{
  var collection = new List<Deleteentry>();
  string query = "select * from DELETEENTRY";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Meet nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Athlete nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* MtEvent nullable true*/
      collection.Add( new Deleteentry(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public long? Meet{ get; } = meet;
  public long? Athlete{ get; } = athlete;
  public long? MtEvent{ get; } = mtEvent;
}
}
}
