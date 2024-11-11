using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Split]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Ath_no] Long Integer,
/// // [Team_no] Long Integer,
/// // [Team_ltr] Text (2),
/// // [Rnd_ltr] Text (2),
/// // [Split_no] Integer,
/// // [Split_Time] Single,
/// // [Relay_no] Long Integer
/// // );

public class Split(long? eventPtr, long? athNo, long? teamNo, string teamLtr, string rndLtr, short? splitNo, float? splitTime, long? relayNo )
{
static public List<Split> Get(OdbcConnection connection)
{
  var collection = new List<Split>();
  string query = "select * from Split";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Event_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Ath_no nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Team_no nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Team_ltr nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Rnd_ltr nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Split_no nullable true*/
  var arg6 = reader.IsDBNull(6) ? (float?)null :reader.GetFloat(6); /* Split_Time nullable true*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* Relay_no nullable true*/
      collection.Add( new Split(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public long? AthNo{ get; } = athNo;
  public long? TeamNo{ get; } = teamNo;
  public string TeamLtr{ get; } = teamLtr;
  public string RndLtr{ get; } = rndLtr;
  public short? SplitNo{ get; } = splitNo;
  public float? SplitTime{ get; } = splitTime;
  public long? RelayNo{ get; } = relayNo;
}
}
}
