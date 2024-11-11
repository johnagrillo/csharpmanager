using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Sessitem]
/// // (
/// // [Sess_order] Long Integer,
/// // [Sess_ptr] Long Integer,
/// // [Event_ptr] Long Integer,
/// // [Sess_rnd] Text (2),
/// // [Rept_type] Text (2),
/// // [Delay_seconds] Long Integer,
/// // [Alt_With] Boolean NOT NULL,
/// // [Timed_finalheats] Integer,
/// // [EventTo_AlternateWith] Long Integer,
/// // [Delay_desc] Text (100),
/// // [AltHeats_StartCount] Integer,
/// // [Event_Interval] Long Integer
/// // );

public class Sessitem(long? sessOrder, long? sessPtr, long? eventPtr, string sessRnd, string reptType, long? delaySeconds, bool altWith, short? timedFinalheats, long? eventToAlternateWith, string delayDesc, short? altHeatsStartCount, long? eventInterval )
{
static public List<Sessitem> Get(OdbcConnection connection)
{
  var collection = new List<Sessitem>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Sess_order nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Sess_ptr nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Event_ptr nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Sess_rnd nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Rept_type nullable false*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* Delay_seconds nullable true*/
  var arg6 = reader.GetBoolean(6); /* Alt_With nullable false*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Timed_finalheats nullable true*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* EventTo_AlternateWith nullable true*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Delay_desc nullable false*/
  var arg10 = reader.IsDBNull(10) ? (short?)null :reader.GetInt16(10); /* AltHeats_StartCount nullable true*/
  var arg11 = reader.IsDBNull(11) ? (long?)null :reader.GetInt32(11); /* Event_Interval nullable true*/
      collection.Add( new Sessitem(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
    }
  }
  return collection;
}
  // Properties
  public long? SessOrder{ get; } = sessOrder;
  public long? SessPtr{ get; } = sessPtr;
  public long? EventPtr{ get; } = eventPtr;
  public string SessRnd{ get; } = sessRnd;
  public string ReptType{ get; } = reptType;
  public long? DelaySeconds{ get; } = delaySeconds;
  public bool AltWith{ get; } = altWith;
  public short? TimedFinalheats{ get; } = timedFinalheats;
  public long? EventToAlternateWith{ get; } = eventToAlternateWith;
  public string DelayDesc{ get; } = delayDesc;
  public short? AltHeatsStartCount{ get; } = altHeatsStartCount;
  public long? EventInterval{ get; } = eventInterval;
}
}
}
