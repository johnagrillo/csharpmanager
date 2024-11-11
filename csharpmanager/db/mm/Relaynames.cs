using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [RelayNames]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Team_no] Long Integer,
/// // [Team_ltr] Text (510),
/// // [Ath_no] Long Integer,
/// // [Pos_no] Integer,
/// // [Event_round] Text (2),
/// // [Relay_no] Long Integer
/// // );

public class Relaynames(long? eventPtr, long? teamNo, string teamLtr, long? athNo, short? posNo, string eventRound, long? relayNo )
{
static public List<Relaynames> Get(OdbcConnection connection)
{
  var collection = new List<Relaynames>();
  string query = "select * from RelayNames";
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
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Team_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Team_ltr nullable false*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* Ath_no nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* Pos_no nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Event_round nullable false*/
  var arg6 = reader.IsDBNull(6) ? (long?)null :reader.GetInt32(6); /* Relay_no nullable true*/
      collection.Add( new Relaynames(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public long? TeamNo{ get; } = teamNo;
  public string TeamLtr{ get; } = teamLtr;
  public long? AthNo{ get; } = athNo;
  public short? PosNo{ get; } = posNo;
  public string EventRound{ get; } = eventRound;
  public long? RelayNo{ get; } = relayNo;
}
}
}
