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
/// CREATE TABLE [CombinedEvent]
/// (
/// [Event_no] Integer,
/// [Event_ltr] Text (2),
/// [CombEvent_ptr] Long Integer,
/// [Event_sex] Text (2),
/// [Event_gender] Text (2),
/// [Low_age] Integer,
/// [High_Age] Integer,
/// [Num_events] Integer,
/// [Score_event] Boolean NOT NULL,
/// [Div_no] Integer,
/// [Comm_1] Text (72),
/// [Comm_2] Text (72),
/// [Comm_3] Text (72),
/// [Comm_4] Text (72),
/// [Entry_fee] Currency,
/// [Event_note] Text (40),
/// [Event_ptr1] Long Integer,
/// [Event_ptr2] Long Integer,
/// [Event_ptr3] Long Integer,
/// [Event_ptr4] Long Integer,
/// [Event_ptr5] Long Integer,
/// [Event_ptr6] Long Integer,
/// [Event_ptr7] Long Integer,
/// [Event_ptr8] Long Integer,
/// [Event_ptr9] Long Integer,
/// [Event_ptr10] Long Integer
/// );

public class MmCombinedevent 
{
List<MmCombinedevent> get(OdbcConnection connection)
{
  var collection = new List<MmCombinedevent>();
  string query = "select * from CombinedEvent";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* Event_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Event_ltr */
      var arg2 = reader.GetInt64(3); /* CombEvent_ptr */
      var arg3 = reader.GetTextReader(4).ToString(); /* Event_sex */
      var arg4 = reader.GetTextReader(5).ToString(); /* Event_gender */
      var arg5 = reader.GetInt16(6); /* Low_age */
      var arg6 = reader.GetInt16(7); /* High_Age */
      var arg7 = reader.GetInt16(8); /* Num_events */
      var arg8 = reader.GetBoolean(9); /* Score_event */
      var arg9 = reader.GetInt16(10); /* Div_no */
      var arg10 = reader.GetTextReader(11).ToString(); /* Comm_1 */
      var arg11 = reader.GetTextReader(12).ToString(); /* Comm_2 */
      var arg12 = reader.GetTextReader(13).ToString(); /* Comm_3 */
      var arg13 = reader.GetTextReader(14).ToString(); /* Comm_4 */
      var arg14 = reader.GetDecimal(15); /* Entry_fee */
      var arg15 = reader.GetTextReader(16).ToString(); /* Event_note */
      var arg16 = reader.GetInt64(17); /* Event_ptr1 */
      var arg17 = reader.GetInt64(18); /* Event_ptr2 */
      var arg18 = reader.GetInt64(19); /* Event_ptr3 */
      var arg19 = reader.GetInt64(20); /* Event_ptr4 */
      var arg20 = reader.GetInt64(21); /* Event_ptr5 */
      var arg21 = reader.GetInt64(22); /* Event_ptr6 */
      var arg22 = reader.GetInt64(23); /* Event_ptr7 */
      var arg23 = reader.GetInt64(24); /* Event_ptr8 */
      var arg24 = reader.GetInt64(25); /* Event_ptr9 */
      var arg25 = reader.GetInt64(26); /* Event_ptr10 */
      collection.Add( new MmCombinedevent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25));
    }
  }
  return collection;
}
  // Properties
  public short EventNo{ get; }
  public string EventLtr{ get; }
  public long CombEventPtr{ get; }
  public string EventSex{ get; }
  public string EventGender{ get; }
  public short LowAge{ get; }
  public short HighAge{ get; }
  public short NumEvents{ get; }
  public bool ScoreEvent{ get; }
  public short DivNo{ get; }
  public string Comm1{ get; }
  public string Comm2{ get; }
  public string Comm3{ get; }
  public string Comm4{ get; }
  public decimal EntryFee{ get; }
  public string EventNote{ get; }
  public long EventPtr1{ get; }
  public long EventPtr2{ get; }
  public long EventPtr3{ get; }
  public long EventPtr4{ get; }
  public long EventPtr5{ get; }
  public long EventPtr6{ get; }
  public long EventPtr7{ get; }
  public long EventPtr8{ get; }
  public long EventPtr9{ get; }
  public long EventPtr10{ get; }
  // Constructor
  MmCombinedevent(short eventNo, string eventLtr, long combEventPtr, string eventSex, string eventGender, short lowAge, short highAge, short numEvents, bool scoreEvent, short divNo, string comm1, string comm2, string comm3, string comm4, decimal entryFee, string eventNote, long eventPtr1, long eventPtr2, long eventPtr3, long eventPtr4, long eventPtr5, long eventPtr6, long eventPtr7, long eventPtr8, long eventPtr9, long eventPtr10 )
  {
    EventNo = eventNo;
    EventLtr = eventLtr;
    CombEventPtr = combEventPtr;
    EventSex = eventSex;
    EventGender = eventGender;
    LowAge = lowAge;
    HighAge = highAge;
    NumEvents = numEvents;
    ScoreEvent = scoreEvent;
    DivNo = divNo;
    Comm1 = comm1;
    Comm2 = comm2;
    Comm3 = comm3;
    Comm4 = comm4;
    EntryFee = entryFee;
    EventNote = eventNote;
    EventPtr1 = eventPtr1;
    EventPtr2 = eventPtr2;
    EventPtr3 = eventPtr3;
    EventPtr4 = eventPtr4;
    EventPtr5 = eventPtr5;
    EventPtr6 = eventPtr6;
    EventPtr7 = eventPtr7;
    EventPtr8 = eventPtr8;
    EventPtr9 = eventPtr9;
    EventPtr10 = eventPtr10;
  }
}
