using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [CombinedEvent]
/// // (
/// // [Event_no] Integer,
/// // [Event_ltr] Text (2),
/// // [CombEvent_ptr] Long Integer,
/// // [Event_sex] Text (2),
/// // [Event_gender] Text (2),
/// // [Low_age] Integer,
/// // [High_Age] Integer,
/// // [Num_events] Integer,
/// // [Score_event] Boolean NOT NULL,
/// // [Div_no] Integer,
/// // [Comm_1] Text (72),
/// // [Comm_2] Text (72),
/// // [Comm_3] Text (72),
/// // [Comm_4] Text (72),
/// // [Entry_fee] Currency,
/// // [Event_note] Text (40),
/// // [Event_ptr1] Long Integer,
/// // [Event_ptr2] Long Integer,
/// // [Event_ptr3] Long Integer,
/// // [Event_ptr4] Long Integer,
/// // [Event_ptr5] Long Integer,
/// // [Event_ptr6] Long Integer,
/// // [Event_ptr7] Long Integer,
/// // [Event_ptr8] Long Integer,
/// // [Event_ptr9] Long Integer,
/// // [Event_ptr10] Long Integer
/// // );

public class Combinedevent(short? eventNo, string eventLtr, long? combEventPtr, string eventSex, string eventGender, short? lowAge, short? highAge, short? numEvents, bool scoreEvent, short? divNo, string comm1, string comm2, string comm3, string comm4, decimal? entryFee, string eventNote, long? eventPtr1, long? eventPtr2, long? eventPtr3, long? eventPtr4, long? eventPtr5, long? eventPtr6, long? eventPtr7, long? eventPtr8, long? eventPtr9, long? eventPtr10 )
{
static public List<Combinedevent> Get(OdbcConnection connection)
{
  var collection = new List<Combinedevent>();
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
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* Event_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Event_ltr nullable false*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* CombEvent_ptr nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Event_sex nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Event_gender nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Low_age nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* High_Age nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Num_events nullable true*/
  var arg8 = reader.GetBoolean(8); /* Score_event nullable false*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* Div_no nullable true*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Comm_1 nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Comm_2 nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Comm_3 nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Comm_4 nullable false*/
  var arg14 = reader.IsDBNull(14) ? (decimal?)null :reader.GetDecimal(14); /* Entry_fee nullable true*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Event_note nullable false*/
  var arg16 = reader.IsDBNull(16) ? (long?)null :reader.GetInt32(16); /* Event_ptr1 nullable true*/
  var arg17 = reader.IsDBNull(17) ? (long?)null :reader.GetInt32(17); /* Event_ptr2 nullable true*/
  var arg18 = reader.IsDBNull(18) ? (long?)null :reader.GetInt32(18); /* Event_ptr3 nullable true*/
  var arg19 = reader.IsDBNull(19) ? (long?)null :reader.GetInt32(19); /* Event_ptr4 nullable true*/
  var arg20 = reader.IsDBNull(20) ? (long?)null :reader.GetInt32(20); /* Event_ptr5 nullable true*/
  var arg21 = reader.IsDBNull(21) ? (long?)null :reader.GetInt32(21); /* Event_ptr6 nullable true*/
  var arg22 = reader.IsDBNull(22) ? (long?)null :reader.GetInt32(22); /* Event_ptr7 nullable true*/
  var arg23 = reader.IsDBNull(23) ? (long?)null :reader.GetInt32(23); /* Event_ptr8 nullable true*/
  var arg24 = reader.IsDBNull(24) ? (long?)null :reader.GetInt32(24); /* Event_ptr9 nullable true*/
  var arg25 = reader.IsDBNull(25) ? (long?)null :reader.GetInt32(25); /* Event_ptr10 nullable true*/
      collection.Add( new Combinedevent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25));
    }
  }
  return collection;
}
  // Properties
  public short? EventNo{ get; } = eventNo;
  public string EventLtr{ get; } = eventLtr;
  public long? CombEventPtr{ get; } = combEventPtr;
  public string EventSex{ get; } = eventSex;
  public string EventGender{ get; } = eventGender;
  public short? LowAge{ get; } = lowAge;
  public short? HighAge{ get; } = highAge;
  public short? NumEvents{ get; } = numEvents;
  public bool ScoreEvent{ get; } = scoreEvent;
  public short? DivNo{ get; } = divNo;
  public string Comm1{ get; } = comm1;
  public string Comm2{ get; } = comm2;
  public string Comm3{ get; } = comm3;
  public string Comm4{ get; } = comm4;
  public decimal? EntryFee{ get; } = entryFee;
  public string EventNote{ get; } = eventNote;
  public long? EventPtr1{ get; } = eventPtr1;
  public long? EventPtr2{ get; } = eventPtr2;
  public long? EventPtr3{ get; } = eventPtr3;
  public long? EventPtr4{ get; } = eventPtr4;
  public long? EventPtr5{ get; } = eventPtr5;
  public long? EventPtr6{ get; } = eventPtr6;
  public long? EventPtr7{ get; } = eventPtr7;
  public long? EventPtr8{ get; } = eventPtr8;
  public long? EventPtr9{ get; } = eventPtr9;
  public long? EventPtr10{ get; } = eventPtr10;
}
}
}
