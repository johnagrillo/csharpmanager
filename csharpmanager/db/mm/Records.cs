using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Records]
/// // (
/// // [tag_ptr] Long Integer,
/// // [tag_gender] Text (2),
/// // [tag_indrel] Text (2),
/// // [tag_dist] Long Integer,
/// // [tag_stroke] Text (2),
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
/// // [Record_teamabbr] Text (10),
/// // [Record_teamlsc] Text (4),
/// // [div_abbr] Text (20)
/// // );

public class Records(long? tag_ptr, string tag_gender, string tag_indrel, long? tag_dist, string tag_stroke, short? low_age, short? highAge, short? recordMonth, short? recordDay, short? recordYear, string recordHolder, string recordHolderteam, string relayNames, float? recordTime, string recordCourse, string recordTeamabbr, string recordTeamlsc, string div_abbr )
{
static public List<Records> Get(OdbcConnection connection)
{
  var collection = new List<Records>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* tag_ptr nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* tag_gender nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* tag_indrel nullable false*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* tag_dist nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* tag_stroke nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* low_age nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* high_Age nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Record_month nullable true*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* Record_day nullable true*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* Record_year nullable true*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Record_Holder nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Record_Holderteam nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Relay_Names nullable false*/
  var arg13 = reader.IsDBNull(13) ? (float?)null :reader.GetFloat(13); /* Record_Time nullable true*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Record_course nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Record_teamabbr nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Record_teamlsc nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* div_abbr nullable false*/
      collection.Add( new Records(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17));
    }
  }
  return collection;
}
  // Properties
  public long? Tag_ptr{ get; } = tag_ptr;
  public string Tag_gender{ get; } = tag_gender;
  public string Tag_indrel{ get; } = tag_indrel;
  public long? Tag_dist{ get; } = tag_dist;
  public string Tag_stroke{ get; } = tag_stroke;
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
  public string RecordTeamabbr{ get; } = recordTeamabbr;
  public string RecordTeamlsc{ get; } = recordTeamlsc;
  public string Div_abbr{ get; } = div_abbr;
}
}
}
