using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [SESSIONS]
/// // (
/// // [MEETID] Long Integer,
/// // [SESSION] Byte,
/// // [MAXIND] Byte,
/// // [MAXREL] Byte,
/// // [MAXCOMBINED] Byte,
/// // [DAY] Byte,
/// // [STARTTIME] Text (10),
/// // [AMPM] Boolean NOT NULL,
/// // [SessX] Text (2)
/// // );

public class Sessions(long? meetid, byte? session, byte? maxind, byte? maxrel, byte? maxcombined, byte? day, string starttime, bool ampm, string sessX )
{
static public List<Sessions> Get(OdbcConnection connection)
{
  var collection = new List<Sessions>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* MEETID nullable true*/
  var arg1 = reader.IsDBNull(1) ? (byte?)null :reader.GetByte(1); /* SESSION nullable true*/
  var arg2 = reader.IsDBNull(2) ? (byte?)null :reader.GetByte(2); /* MAXIND nullable true*/
  var arg3 = reader.IsDBNull(3) ? (byte?)null :reader.GetByte(3); /* MAXREL nullable true*/
  var arg4 = reader.IsDBNull(4) ? (byte?)null :reader.GetByte(4); /* MAXCOMBINED nullable true*/
  var arg5 = reader.IsDBNull(5) ? (byte?)null :reader.GetByte(5); /* DAY nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* STARTTIME nullable false*/
  var arg7 = reader.GetBoolean(7); /* AMPM nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* SessX nullable false*/
      collection.Add( new Sessions(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }
  }
  return collection;
}
  // Properties
  public long? Meetid{ get; } = meetid;
  public byte? Session{ get; } = session;
  public byte? Maxind{ get; } = maxind;
  public byte? Maxrel{ get; } = maxrel;
  public byte? Maxcombined{ get; } = maxcombined;
  public byte? Day{ get; } = day;
  public string Starttime{ get; } = starttime;
  public bool Ampm{ get; } = ampm;
  public string SessX{ get; } = sessX;
}
}
}
