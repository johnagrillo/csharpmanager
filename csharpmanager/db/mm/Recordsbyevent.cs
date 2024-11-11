using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [RecordsbyEvent]
/// // (
/// // [tag_ptr] Long Integer,
/// // [event_ptr] Long Integer,
/// // [low_age] Integer,
/// // [high_Age] Integer,
/// // [Record_month] Integer,
/// // [Record_day] Integer,
/// // [Record_year] Integer,
/// // [Record_Holder] Text (60),
/// // [Record_Holderteam] Text (32),
/// // [Relay_Names] Text (100),
/// // [Record_Time] Single,
/// // [Record_course] Text (2),
/// // [tag_gender] Text (2),
/// // [hide_me] Boolean NOT NULL,
/// // [Record_teamabbr] Text (10),
/// // [Record_teamlsc] Text (4),
/// // [div_abbr] Text (20)
/// // );

public class Recordsbyevent(long? tag_ptr, long? event_ptr, short? low_age, short? highAge, short? recordMonth, short? recordDay, short? recordYear, string recordHolder, string recordHolderteam, string relayNames, float? recordTime, string recordCourse, string tag_gender, bool hide_me, string recordTeamabbr, string recordTeamlsc, string div_abbr )
{
static public List<Recordsbyevent> Get(OdbcConnection connection)
{
  var collection = new List<Recordsbyevent>();
  string query = "select * from RecordsbyEvent";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* tag_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* event_ptr nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* low_age nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* high_Age nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* Record_month nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Record_day nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* Record_year nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Record_Holder nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Record_Holderteam nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Relay_Names nullable false*/
  var arg10 = reader.IsDBNull(10) ? (float?)null :reader.GetFloat(10); /* Record_Time nullable true*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Record_course nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* tag_gender nullable false*/
  var arg13 = reader.GetBoolean(13); /* hide_me nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Record_teamabbr nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Record_teamlsc nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* div_abbr nullable false*/
      collection.Add( new Recordsbyevent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
    }
  }
  return collection;
}
  // Properties
  public long? Tag_ptr{ get; } = tag_ptr;
  public long? Event_ptr{ get; } = event_ptr;
  public short? Low_age{ get; } = low_age;
  public short? HighAge{ get; } = highAge;
  public short? RecordMonth{ get; } = recordMonth;
  public short? RecordDay{ get; } = recordDay;
  public short? RecordYear{ get; } = recordYear;
  public string RecordHolder{ get; } = recordHolder;
  public string RecordHolderteam{ get; } = recordHolderteam;
  public string RelayNames{ get; } = relayNames;
  public float? RecordTime{ get; } = recordTime;
  public string RecordCourse{ get; } = recordCourse;
  public string Tag_gender{ get; } = tag_gender;
  public bool Hide_me{ get; } = hide_me;
  public string RecordTeamabbr{ get; } = recordTeamabbr;
  public string RecordTeamlsc{ get; } = recordTeamlsc;
  public string Div_abbr{ get; } = div_abbr;
}
}
}
