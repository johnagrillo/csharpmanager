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
/// CREATE TABLE [Session]
/// (
/// [Sess_no] Integer,
/// [Sess_ltr] Text (2),
/// [Sess_ptr] Long Integer,
/// [Sess_day] Integer,
/// [Sess_starttime] Long Integer,
/// [Sess_entrymax] Integer,
/// [Sess_name] Text (120),
/// [Sess_interval] Integer,
/// [Sess_course] Text (2),
/// [Sess_entrymaxind] Integer,
/// [Sess_entrymaxrel] Integer,
/// [Sess_backinterval] Integer,
/// [Sess_divinginterval] Integer,
/// [Sess_chaseinterval] Integer
/// );

public class MmSession 
{
List<MmSession> get(OdbcConnection connection)
{
  var collection = new List<MmSession>();
  string query = "select * from Session";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* Sess_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Sess_ltr */
      var arg2 = reader.GetInt64(3); /* Sess_ptr */
      var arg3 = reader.GetInt16(4); /* Sess_day */
      var arg4 = reader.GetInt64(5); /* Sess_starttime */
      var arg5 = reader.GetInt16(6); /* Sess_entrymax */
      var arg6 = reader.GetTextReader(7).ToString(); /* Sess_name */
      var arg7 = reader.GetInt16(8); /* Sess_interval */
      var arg8 = reader.GetTextReader(9).ToString(); /* Sess_course */
      var arg9 = reader.GetInt16(10); /* Sess_entrymaxind */
      var arg10 = reader.GetInt16(11); /* Sess_entrymaxrel */
      var arg11 = reader.GetInt16(12); /* Sess_backinterval */
      var arg12 = reader.GetInt16(13); /* Sess_divinginterval */
      var arg13 = reader.GetInt16(14); /* Sess_chaseinterval */
      collection.Add( new MmSession(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public short SessNo{ get; }
  public string SessLtr{ get; }
  public long SessPtr{ get; }
  public short SessDay{ get; }
  public long SessStarttime{ get; }
  public short SessEntrymax{ get; }
  public string SessName{ get; }
  public short SessInterval{ get; }
  public string SessCourse{ get; }
  public short SessEntrymaxind{ get; }
  public short SessEntrymaxrel{ get; }
  public short SessBackinterval{ get; }
  public short SessDivinginterval{ get; }
  public short SessChaseinterval{ get; }
  // Constructor
  MmSession(short sessNo, string sessLtr, long sessPtr, short sessDay, long sessStarttime, short sessEntrymax, string sessName, short sessInterval, string sessCourse, short sessEntrymaxind, short sessEntrymaxrel, short sessBackinterval, short sessDivinginterval, short sessChaseinterval )
  {
    SessNo = sessNo;
    SessLtr = sessLtr;
    SessPtr = sessPtr;
    SessDay = sessDay;
    SessStarttime = sessStarttime;
    SessEntrymax = sessEntrymax;
    SessName = sessName;
    SessInterval = sessInterval;
    SessCourse = sessCourse;
    SessEntrymaxind = sessEntrymaxind;
    SessEntrymaxrel = sessEntrymaxrel;
    SessBackinterval = sessBackinterval;
    SessDivinginterval = sessDivinginterval;
    SessChaseinterval = sessChaseinterval;
  }
}
