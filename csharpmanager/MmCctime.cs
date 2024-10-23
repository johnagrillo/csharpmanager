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
/// CREATE TABLE [CCtime]
/// (
/// [Event_ptr] Long Integer,
/// [Ath_no] Long Integer,
/// [Chute_rank] Long Integer,
/// [Chute_no] Integer,
/// [Fin_hand] Boolean NOT NULL,
/// [Fin_stat] Text (2),
/// [Fin_Time] Single
/// );

public class MmCctime 
{
List<MmCctime> get(OdbcConnection connection)
{
  var collection = new List<MmCctime>();
  string query = "select * from CCtime";
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
      var arg2 = reader.GetInt64(3); /* Chute_rank */
      var arg3 = reader.GetInt16(4); /* Chute_no */
      var arg4 = reader.GetBoolean(5); /* Fin_hand */
      var arg5 = reader.GetTextReader(6).ToString(); /* Fin_stat */
      var arg6 = reader.GetFloat(7); /* Fin_Time */
      collection.Add( new MmCctime(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public long AthNo{ get; }
  public long ChuteRank{ get; }
  public short ChuteNo{ get; }
  public bool FinHand{ get; }
  public string FinStat{ get; }
  public float FinTime{ get; }
  // Constructor
  MmCctime(long eventPtr, long athNo, long chuteRank, short chuteNo, bool finHand, string finStat, float finTime )
  {
    EventPtr = eventPtr;
    AthNo = athNo;
    ChuteRank = chuteRank;
    ChuteNo = chuteNo;
    FinHand = finHand;
    FinStat = finStat;
    FinTime = finTime;
  }
}
