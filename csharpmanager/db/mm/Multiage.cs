using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Multiage]
/// // (
/// // [event_ptr] Long Integer,
/// // [low_age] Integer,
/// // [high_age] Integer,
/// // [Heats_infinal] Text (2),
/// // [Num_Heatsinfinal] Integer
/// // );

public class Multiage(long? event_ptr, short? low_age, short? high_age, string heatsInfinal, short? numHeatsinfinal )
{
static public List<Multiage> Get(OdbcConnection connection)
{
  var collection = new List<Multiage>();
  string query = "select * from Multiage";
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
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Heats_infinal nullable false*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* Num_Heatsinfinal nullable true*/
      collection.Add( new Multiage(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public long? Event_ptr{ get; } = event_ptr;
  public short? Low_age{ get; } = low_age;
  public short? High_age{ get; } = high_age;
  public string HeatsInfinal{ get; } = heatsInfinal;
  public short? NumHeatsinfinal{ get; } = numHeatsinfinal;
}
}
}
