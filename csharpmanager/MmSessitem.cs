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
/// CREATE TABLE [Sessitem]
/// (
/// [Sess_order] Long Integer,
/// [Sess_ptr] Long Integer,
/// [Event_ptr] Long Integer,
/// [Sess_rnd] Text (2),
/// [Rept_type] Text (2),
/// [Delay_seconds] Long Integer,
/// [Alt_With] Boolean NOT NULL,
/// [Timed_finalheats] Integer,
/// [EventTo_AlternateWith] Long Integer,
/// [Delay_desc] Text (100),
/// [AltHeats_StartCount] Integer,
/// [Event_Interval] Long Integer
/// );

public class MmSessitem 
{
List<MmSessitem> get(OdbcConnection connection)
{
  var collection = new List<MmSessitem>();
  string query = "select * from Sessitem";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Sess_order */
      var arg1 = reader.GetInt64(2); /* Sess_ptr */
      var arg2 = reader.GetInt64(3); /* Event_ptr */
      var arg3 = reader.GetTextReader(4).ToString(); /* Sess_rnd */
      var arg4 = reader.GetTextReader(5).ToString(); /* Rept_type */
      var arg5 = reader.GetInt64(6); /* Delay_seconds */
      var arg6 = reader.GetBoolean(7); /* Alt_With */
      var arg7 = reader.GetInt16(8); /* Timed_finalheats */
      var arg8 = reader.GetInt64(9); /* EventTo_AlternateWith */
      var arg9 = reader.GetTextReader(10).ToString(); /* Delay_desc */
      var arg10 = reader.GetInt16(11); /* AltHeats_StartCount */
      var arg11 = reader.GetInt64(12); /* Event_Interval */
      collection.Add( new MmSessitem(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
    }
  }
  return collection;
}
  // Properties
  public long SessOrder{ get; }
  public long SessPtr{ get; }
  public long EventPtr{ get; }
  public string SessRnd{ get; }
  public string ReptType{ get; }
  public long DelaySeconds{ get; }
  public bool AltWith{ get; }
  public short TimedFinalheats{ get; }
  public long EventToAlternateWith{ get; }
  public string DelayDesc{ get; }
  public short AltHeatsStartCount{ get; }
  public long EventInterval{ get; }
  // Constructor
  MmSessitem(long sessOrder, long sessPtr, long eventPtr, string sessRnd, string reptType, long delaySeconds, bool altWith, short timedFinalheats, long eventToAlternateWith, string delayDesc, short altHeatsStartCount, long eventInterval )
  {
    SessOrder = sessOrder;
    SessPtr = sessPtr;
    EventPtr = eventPtr;
    SessRnd = sessRnd;
    ReptType = reptType;
    DelaySeconds = delaySeconds;
    AltWith = altWith;
    TimedFinalheats = timedFinalheats;
    EventToAlternateWith = eventToAlternateWith;
    DelayDesc = delayDesc;
    AltHeatsStartCount = altHeatsStartCount;
    EventInterval = eventInterval;
  }
}
