using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Session]
/// // (
/// // [Sess_no] Integer,
/// // [Sess_ltr] Text (2),
/// // [Sess_ptr] Long Integer,
/// // [Sess_day] Integer,
/// // [Sess_starttime] Long Integer,
/// // [Sess_entrymax] Integer,
/// // [Sess_name] Text (120),
/// // [Sess_interval] Integer,
/// // [Sess_course] Text (2),
/// // [Sess_entrymaxind] Integer,
/// // [Sess_entrymaxrel] Integer,
/// // [Sess_backinterval] Integer,
/// // [Sess_divinginterval] Integer,
/// // [Sess_chaseinterval] Integer
/// // );

public class Session(short? sessNo, string sessLtr, long? sessPtr, short? sessDay, long? sessStarttime, short? sessEntrymax, string sessName, short? sessInterval, string sessCourse, short? sessEntrymaxind, short? sessEntrymaxrel, short? sessBackinterval, short? sessDivinginterval, short? sessChaseinterval )
{
static public List<Session> Get(OdbcConnection connection)
{
  var collection = new List<Session>();
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
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* Sess_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Sess_ltr nullable false*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Sess_ptr nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Sess_day nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* Sess_starttime nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Sess_entrymax nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* Sess_name nullable false*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Sess_interval nullable true*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Sess_course nullable false*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* Sess_entrymaxind nullable true*/
  var arg10 = reader.IsDBNull(10) ? (short?)null :reader.GetInt16(10); /* Sess_entrymaxrel nullable true*/
  var arg11 = reader.IsDBNull(11) ? (short?)null :reader.GetInt16(11); /* Sess_backinterval nullable true*/
  var arg12 = reader.IsDBNull(12) ? (short?)null :reader.GetInt16(12); /* Sess_divinginterval nullable true*/
  var arg13 = reader.IsDBNull(13) ? (short?)null :reader.GetInt16(13); /* Sess_chaseinterval nullable true*/
      collection.Add( new Session(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public short? SessNo{ get; } = sessNo;
  public string SessLtr{ get; } = sessLtr;
  public long? SessPtr{ get; } = sessPtr;
  public short? SessDay{ get; } = sessDay;
  public long? SessStarttime{ get; } = sessStarttime;
  public short? SessEntrymax{ get; } = sessEntrymax;
  public string SessName{ get; } = sessName;
  public short? SessInterval{ get; } = sessInterval;
  public string SessCourse{ get; } = sessCourse;
  public short? SessEntrymaxind{ get; } = sessEntrymaxind;
  public short? SessEntrymaxrel{ get; } = sessEntrymaxrel;
  public short? SessBackinterval{ get; } = sessBackinterval;
  public short? SessDivinginterval{ get; } = sessDivinginterval;
  public short? SessChaseinterval{ get; } = sessChaseinterval;
}
}
}
