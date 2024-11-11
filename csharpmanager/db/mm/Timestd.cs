using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [TimeStd]
/// // (
/// // [tag_ptr] Long Integer,
/// // [tag_gender] Text (2),
/// // [tag_indrel] Text (2),
/// // [tag_dist] Long Integer,
/// // [tag_stroke] Text (2),
/// // [low_age] Integer,
/// // [high_Age] Integer,
/// // [tag_time] Single,
/// // [tag_course] Text (2),
/// // [div_abbr] Text (20)
/// // );

public class Timestd(long? tag_ptr, string tag_gender, string tag_indrel, long? tag_dist, string tag_stroke, short? low_age, short? highAge, float? tag_time, string tag_course, string div_abbr )
{
static public List<Timestd> Get(OdbcConnection connection)
{
  var collection = new List<Timestd>();
  string query = "select * from TimeStd";
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
  var arg7 = reader.IsDBNull(7) ? (float?)null :reader.GetFloat(7); /* tag_time nullable true*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* tag_course nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* div_abbr nullable false*/
      collection.Add( new Timestd(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
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
  public float? Tag_time{ get; } = tag_time;
  public string Tag_course{ get; } = tag_course;
  public string Div_abbr{ get; } = div_abbr;
}
}
}
