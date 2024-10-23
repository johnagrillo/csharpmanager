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
/// CREATE TABLE [Split]
/// (
/// [Event_ptr] Long Integer,
/// [Ath_no] Long Integer,
/// [Team_no] Long Integer,
/// [Team_ltr] Text (2),
/// [Rnd_ltr] Text (2),
/// [Split_no] Integer,
/// [Split_Time] Single,
/// [Relay_no] Long Integer
/// );

public class MmSplit 
{
List<MmSplit> get(OdbcConnection connection)
{
  var collection = new List<MmSplit>();
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
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt64(2); /* Ath_no */
      var arg2 = reader.GetInt64(3); /* Team_no */
      var arg3 = reader.GetTextReader(4).ToString(); /* Team_ltr */
      var arg4 = reader.GetTextReader(5).ToString(); /* Rnd_ltr */
      var arg5 = reader.GetInt16(6); /* Split_no */
      var arg6 = reader.GetFloat(7); /* Split_Time */
      var arg7 = reader.GetInt64(8); /* Relay_no */
      collection.Add( new MmSplit(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public long AthNo{ get; }
  public long TeamNo{ get; }
  public string TeamLtr{ get; }
  public string RndLtr{ get; }
  public short SplitNo{ get; }
  public float SplitTime{ get; }
  public long RelayNo{ get; }
  // Constructor
  MmSplit(long eventPtr, long athNo, long teamNo, string teamLtr, string rndLtr, short splitNo, float splitTime, long relayNo )
  {
    EventPtr = eventPtr;
    AthNo = athNo;
    TeamNo = teamNo;
    TeamLtr = teamLtr;
    RndLtr = rndLtr;
    SplitNo = splitNo;
    SplitTime = splitTime;
    RelayNo = relayNo;
  }
}
