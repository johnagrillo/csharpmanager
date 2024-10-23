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
/// CREATE TABLE [SESSIONS]
/// (
/// [MEETID] Long Integer,
/// [SESSION] Byte,
/// [MAXIND] Byte,
/// [MAXREL] Byte,
/// [MAXCOMBINED] Byte,
/// [DAY] Byte,
/// [STARTTIME] Text (10),
/// [AMPM] Boolean NOT NULL,
/// [SessX] Text (2)
/// );

public class TmSessions 
{
List<TmSessions> get(OdbcConnection connection)
{
  var collection = new List<TmSessions>();
  string query = "select * from SESSIONS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* MEETID */
      var arg1 = reader.GetByte(2); /* SESSION */
      var arg2 = reader.GetByte(3); /* MAXIND */
      var arg3 = reader.GetByte(4); /* MAXREL */
      var arg4 = reader.GetByte(5); /* MAXCOMBINED */
      var arg5 = reader.GetByte(6); /* DAY */
      var arg6 = reader.GetTextReader(7).ToString(); /* STARTTIME */
      var arg7 = reader.GetBoolean(8); /* AMPM */
      var arg8 = reader.GetTextReader(9).ToString(); /* SessX */
      collection.Add( new TmSessions(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }
  }
  return collection;
}
  // Properties
  public long Meetid{ get; }
  public byte Session{ get; }
  public byte Maxind{ get; }
  public byte Maxrel{ get; }
  public byte Maxcombined{ get; }
  public byte Day{ get; }
  public string Starttime{ get; }
  public bool Ampm{ get; }
  public string SessX{ get; }
  // Constructor
  TmSessions(long meetid, byte session, byte maxind, byte maxrel, byte maxcombined, byte day, string starttime, bool ampm, string sessX )
  {
    Meetid = meetid;
    Session = session;
    Maxind = maxind;
    Maxrel = maxrel;
    Maxcombined = maxcombined;
    Day = day;
    Starttime = starttime;
    Ampm = ampm;
    SessX = sessX;
  }
}
