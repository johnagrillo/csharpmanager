using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MTEVENT]
/// // (
/// // [Meet] Long Integer,
/// // [MtEv] Integer,
/// // [MtEvX] Text (2),
/// // [Lo_Hi] Integer,
/// // [Course] Text (2),
/// // [MtEvent] Long Integer,
/// // [Distance] Integer,
/// // [Stroke] Integer,
/// // [Sex] Text (2),
/// // [I_R] Text (2),
/// // [Session] Byte,
/// // [Division] Text (6),
/// // [EventType] Text (2),
/// // [SessX] Text (2)
/// // );

public class Mtevent(long? meet, short? mtEv, string mtEvX, short? loHi, string course, long mtEvent, short? distance, short? stroke, string sex, string i_r, byte? session, string division, string eventType, string sessX )
{
static public List<Mtevent> Get(OdbcConnection connection)
{
  var collection = new List<Mtevent>();
  string query = "select * from MTEVENT";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Meet nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* MtEv nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* MtEvX nullable false*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Lo_Hi nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Course nullable false*/
  var arg5 = reader.GetInt32(5); /* MtEvent nullable false*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* Distance nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Stroke nullable true*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Sex nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* I_R nullable false*/
  var arg10 = reader.IsDBNull(10) ? (byte?)null :reader.GetByte(10); /* Session nullable true*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Division nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* EventType nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* SessX nullable false*/
      collection.Add( new Mtevent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public long? Meet{ get; } = meet;
  public short? MtEv{ get; } = mtEv;
  public string MtEvX{ get; } = mtEvX;
  public short? LoHi{ get; } = loHi;
  public string Course{ get; } = course;
  public long MtEvent{ get; } = mtEvent;
  public short? Distance{ get; } = distance;
  public short? Stroke{ get; } = stroke;
  public string Sex{ get; } = sex;
  public string I_r{ get; } = i_r;
  public byte? Session{ get; } = session;
  public string Division{ get; } = division;
  public string EventType{ get; } = eventType;
  public string SessX{ get; } = sessX;
}
}
}
