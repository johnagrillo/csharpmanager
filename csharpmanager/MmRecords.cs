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
/// CREATE TABLE [Records]
/// (
/// [tag_ptr] Long Integer,
/// [tag_gender] Text (2),
/// [tag_indrel] Text (2),
/// [tag_dist] Long Integer,
/// [tag_stroke] Text (2),
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
/// [Record_teamabbr] Text (10),
/// [Record_teamlsc] Text (4),
/// [div_abbr] Text (20)
/// );

public class MmRecords 
{
List<MmRecords> get(OdbcConnection connection)
{
  var collection = new List<MmRecords>();
  string query = "select * from Records";
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
      var arg1 = reader.GetTextReader(2).ToString(); /* tag_gender */
      var arg2 = reader.GetTextReader(3).ToString(); /* tag_indrel */
      var arg3 = reader.GetInt64(4); /* tag_dist */
      var arg4 = reader.GetTextReader(5).ToString(); /* tag_stroke */
      var arg5 = reader.GetInt16(6); /* low_age */
      var arg6 = reader.GetInt16(7); /* high_Age */
      var arg7 = reader.GetInt16(8); /* Record_month */
      var arg8 = reader.GetInt16(9); /* Record_day */
      var arg9 = reader.GetInt16(10); /* Record_year */
      var arg10 = reader.GetTextReader(11).ToString(); /* Record_Holder */
      var arg11 = reader.GetTextReader(12).ToString(); /* Record_Holderteam */
      var arg12 = reader.GetTextReader(13).ToString(); /* Relay_Names */
      var arg13 = reader.GetFloat(14); /* Record_Time */
      var arg14 = reader.GetTextReader(15).ToString(); /* Record_course */
      var arg15 = reader.GetTextReader(16).ToString(); /* Record_teamabbr */
      var arg16 = reader.GetTextReader(17).ToString(); /* Record_teamlsc */
      var arg17 = reader.GetTextReader(18).ToString(); /* div_abbr */
      collection.Add( new MmRecords(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17));
    }
  }
  return collection;
}
  // Properties
  public long Tag_ptr{ get; }
  public string Tag_gender{ get; }
  public string Tag_indrel{ get; }
  public long Tag_dist{ get; }
  public string Tag_stroke{ get; }
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
  public string RecordTeamabbr{ get; }
  public string RecordTeamlsc{ get; }
  public string Div_abbr{ get; }
  // Constructor
  MmRecords(long tag_ptr, string tag_gender, string tag_indrel, long tag_dist, string tag_stroke, short low_age, short highAge, short recordMonth, short recordDay, short recordYear, string recordHolder, string recordHolderteam, string relayNames, float recordTime, string recordCourse, string recordTeamabbr, string recordTeamlsc, string div_abbr )
  {
    Tag_ptr = tag_ptr;
    Tag_gender = tag_gender;
    Tag_indrel = tag_indrel;
    Tag_dist = tag_dist;
    Tag_stroke = tag_stroke;
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
    RecordTeamabbr = recordTeamabbr;
    RecordTeamlsc = recordTeamlsc;
    Div_abbr = div_abbr;
  }
}
