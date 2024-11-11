using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [modt30times]
/// // (
/// // [athlete] Long Integer,
/// // [event_no] Integer,
/// // [course_yls] Text (2),
/// // [event_dist] Long Integer,
/// // [event_time] Long Integer,
/// // [shave_type] Text (2)
/// // );

public class Modt30times(long? athlete, short? event_no, string course_yls, long? event_dist, long? event_time, string shave_type )
{
static public List<Modt30times> Get(OdbcConnection connection)
{
  var collection = new List<Modt30times>();
  string query = "select * from modt30times";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* athlete nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* event_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* course_yls nullable false*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* event_dist nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* event_time nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* shave_type nullable false*/
      collection.Add( new Modt30times(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long? Athlete{ get; } = athlete;
  public short? Event_no{ get; } = event_no;
  public string Course_yls{ get; } = course_yls;
  public long? Event_dist{ get; } = event_dist;
  public long? Event_time{ get; } = event_time;
  public string Shave_type{ get; } = shave_type;
}
}
}
