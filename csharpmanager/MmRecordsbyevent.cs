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
/// CREATE TABLE [RecordsbyEvent]
/// (
/// [tag_ptr] Long Integer,
/// [event_ptr] Long Integer,
/// [low_age] Integer,
/// [high_Age] Integer,
/// [Record_month] Integer,
/// [Record_day] Integer,
/// [Record_year] Integer,
/// [Record_Holder] Text (60),
/// [Record_Holderteam] Text (32),
/// [Relay_Names] Text (100),
/// [Record_Time] Single,
/// [Record_course] Text (2),
/// [tag_gender] Text (2),
/// [hide_me] Boolean NOT NULL,
/// [Record_teamabbr] Text (10),
/// [Record_teamlsc] Text (4),
/// [div_abbr] Text (20)
/// );

public class MmRecordsbyevent 
{
List<MmRecordsbyevent> get(OdbcConnection connection)
{
  var collection = new List<MmRecordsbyevent>();
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
      var arg0 = reader.GetInt64(1); /* tag_ptr */
      var arg1 = reader.GetInt64(2); /* event_ptr */
      var arg2 = reader.GetInt16(3); /* low_age */
      var arg3 = reader.GetInt16(4); /* high_Age */
      var arg4 = reader.GetInt16(5); /* Record_month */
      var arg5 = reader.GetInt16(6); /* Record_day */
      var arg6 = reader.GetInt16(7); /* Record_year */
      var arg7 = reader.GetTextReader(8).ToString(); /* Record_Holder */
      var arg8 = reader.GetTextReader(9).ToString(); /* Record_Holderteam */
      var arg9 = reader.GetTextReader(10).ToString(); /* Relay_Names */
      var arg10 = reader.GetFloat(11); /* Record_Time */
      var arg11 = reader.GetTextReader(12).ToString(); /* Record_course */
      var arg12 = reader.GetTextReader(13).ToString(); /* tag_gender */
      var arg13 = reader.GetBoolean(14); /* hide_me */
      var arg14 = reader.GetTextReader(15).ToString(); /* Record_teamabbr */
      var arg15 = reader.GetTextReader(16).ToString(); /* Record_teamlsc */
      var arg16 = reader.GetTextReader(17).ToString(); /* div_abbr */
      collection.Add( new MmRecordsbyevent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16));
    }
  }
  return collection;
}
  // Properties
  public long Tag_ptr{ get; }
  public long Event_ptr{ get; }
  public short Low_age{ get; }
  public short HighAge{ get; }
  public short RecordMonth{ get; }
  public short RecordDay{ get; }
  public short RecordYear{ get; }
  public string RecordHolder{ get; }
  public string RecordHolderteam{ get; }
  public string RelayNames{ get; }
  public float RecordTime{ get; }
  public string RecordCourse{ get; }
  public string Tag_gender{ get; }
  public bool Hide_me{ get; }
  public string RecordTeamabbr{ get; }
  public string RecordTeamlsc{ get; }
  public string Div_abbr{ get; }
  // Constructor
  MmRecordsbyevent(long tag_ptr, long event_ptr, short low_age, short highAge, short recordMonth, short recordDay, short recordYear, string recordHolder, string recordHolderteam, string relayNames, float recordTime, string recordCourse, string tag_gender, bool hide_me, string recordTeamabbr, string recordTeamlsc, string div_abbr )
  {
    Tag_ptr = tag_ptr;
    Event_ptr = event_ptr;
    Low_age = low_age;
    HighAge = highAge;
    RecordMonth = recordMonth;
    RecordDay = recordDay;
    RecordYear = recordYear;
    RecordHolder = recordHolder;
    RecordHolderteam = recordHolderteam;
    RelayNames = relayNames;
    RecordTime = recordTime;
    RecordCourse = recordCourse;
    Tag_gender = tag_gender;
    Hide_me = hide_me;
    RecordTeamabbr = recordTeamabbr;
    RecordTeamlsc = recordTeamlsc;
    Div_abbr = div_abbr;
  }
}
