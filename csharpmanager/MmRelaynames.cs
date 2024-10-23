using System;
using System.Collections.Generic;
using System.Data.Odbc;
/// -- ----------------------------------------------------------
/// -- MDB Tools - A library for reading MS Access database files
/// -- Copyright (C) 2000-2011 Brian Bruns and others.
/// -- Files in libmdb are licensed under LGPL and the utilities under
/// -- the GPL, see COPYING.LIB and COPYING files respectively.
/// -- Check out http://mdbtools.sourceforge.net
/// -- ----------------------------------------------------------
/// 
/// -- That file uses encoding UTF-8
/// 
/// CREATE TABLE [RelayNames]
/// (
/// [Event_ptr] Long Integer,
/// [Team_no] Long Integer,
/// [Team_ltr] Text (510),
/// [Ath_no] Long Integer,
/// [Pos_no] Integer,
/// [Event_round] Text (2),
/// [Relay_no] Long Integer
/// );

public class MmRelaynames 
{
List<MmRelaynames> get(OdbcConnection connection)
{
  var collection = new List<MmRelaynames>();
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
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt64(2); /* Team_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* Team_ltr */
      var arg3 = reader.GetInt64(4); /* Ath_no */
      var arg4 = reader.GetInt16(5); /* Pos_no */
      var arg5 = reader.GetTextReader(6).ToString(); /* Event_round */
      var arg6 = reader.GetInt64(7); /* Relay_no */
      collection.Add( new MmRelaynames(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public long TeamNo{ get; }
  public string TeamLtr{ get; }
  public long AthNo{ get; }
  public short PosNo{ get; }
  public string EventRound{ get; }
  public long RelayNo{ get; }
  // Constructor
  MmRelaynames(long eventPtr, long teamNo, string teamLtr, long athNo, short posNo, string eventRound, long relayNo )
  {
    EventPtr = eventPtr;
    TeamNo = teamNo;
    TeamLtr = teamLtr;
    AthNo = athNo;
    PosNo = posNo;
    EventRound = eventRound;
    RelayNo = relayNo;
  }
}
