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
/// CREATE TABLE [MTEVENT]
/// (
/// [Meet] Long Integer,
/// [MtEv] Integer,
/// [MtEvX] Text (2),
/// [Lo_Hi] Integer,
/// [Course] Text (2),
/// [MtEvent] Long Integer,
/// [Distance] Integer,
/// [Stroke] Integer,
/// [Sex] Text (2),
/// [I_R] Text (2),
/// [Session] Byte,
/// [Division] Text (6),
/// [EventType] Text (2),
/// [SessX] Text (2)
/// );

public class TmMtevent 
{
Dictionary<long,TmMtevent> get(OdbcConnection connection)
{
  var collection = new Dictionary<long,TmMtevent>();
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
      var arg0 = reader.GetInt64(1); /* Meet */
      var arg1 = reader.GetInt16(2); /* MtEv */
      var arg2 = reader.GetTextReader(3).ToString(); /* MtEvX */
      var arg3 = reader.GetInt16(4); /* Lo_Hi */
      var arg4 = reader.GetTextReader(5).ToString(); /* Course */
      var arg5 = reader.GetInt64(6); /* MtEvent */
      var arg6 = reader.GetInt16(7); /* Distance */
      var arg7 = reader.GetInt16(8); /* Stroke */
      var arg8 = reader.GetTextReader(9).ToString(); /* Sex */
      var arg9 = reader.GetTextReader(10).ToString(); /* I_R */
      var arg10 = reader.GetByte(11); /* Session */
      var arg11 = reader.GetTextReader(12).ToString(); /* Division */
      var arg12 = reader.GetTextReader(13).ToString(); /* EventType */
      var arg13 = reader.GetTextReader(14).ToString(); /* SessX */
      var obj = new TmMtevent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
      collection[obj.MtEvent] = obj;
    }
  }
  return collection;
}
  // Properties
  public long Meet{ get; }
  public short MtEv{ get; }
  public string MtEvX{ get; }
  public short LoHi{ get; }
  public string Course{ get; }
  public long MtEvent{ get; }
  public short Distance{ get; }
  public short Stroke{ get; }
  public string Sex{ get; }
  public string I_r{ get; }
  public byte Session{ get; }
  public string Division{ get; }
  public string EventType{ get; }
  public string SessX{ get; }
  // Constructor
  TmMtevent(long meet, short mtEv, string mtEvX, short loHi, string course, long mtEvent, short distance, short stroke, string sex, string i_r, byte session, string division, string eventType, string sessX )
  {
    Meet = meet;
    MtEv = mtEv;
    MtEvX = mtEvX;
    LoHi = loHi;
    Course = course;
    MtEvent = mtEvent;
    Distance = distance;
    Stroke = stroke;
    Sex = sex;
    I_r = i_r;
    Session = session;
    Division = division;
    EventType = eventType;
    SessX = sessX;
  }
}
