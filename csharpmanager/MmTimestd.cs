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
/// CREATE TABLE [TimeStd]
/// (
/// [tag_ptr] Long Integer,
/// [tag_gender] Text (2),
/// [tag_indrel] Text (2),
/// [tag_dist] Long Integer,
/// [tag_stroke] Text (2),
/// [low_age] Integer,
/// [high_Age] Integer,
/// [tag_time] Single,
/// [tag_course] Text (2),
/// [div_abbr] Text (20)
/// );

public class MmTimestd 
{
List<MmTimestd> get(OdbcConnection connection)
{
  var collection = new List<MmTimestd>();
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
      var arg0 = reader.GetInt64(1); /* tag_ptr */
      var arg1 = reader.GetTextReader(2).ToString(); /* tag_gender */
      var arg2 = reader.GetTextReader(3).ToString(); /* tag_indrel */
      var arg3 = reader.GetInt64(4); /* tag_dist */
      var arg4 = reader.GetTextReader(5).ToString(); /* tag_stroke */
      var arg5 = reader.GetInt16(6); /* low_age */
      var arg6 = reader.GetInt16(7); /* high_Age */
      var arg7 = reader.GetFloat(8); /* tag_time */
      var arg8 = reader.GetTextReader(9).ToString(); /* tag_course */
      var arg9 = reader.GetTextReader(10).ToString(); /* div_abbr */
      collection.Add( new MmTimestd(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
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
  public float Tag_time{ get; }
  public string Tag_course{ get; }
  public string Div_abbr{ get; }
  // Constructor
  MmTimestd(long tag_ptr, string tag_gender, string tag_indrel, long tag_dist, string tag_stroke, short low_age, short highAge, float tag_time, string tag_course, string div_abbr )
  {
    Tag_ptr = tag_ptr;
    Tag_gender = tag_gender;
    Tag_indrel = tag_indrel;
    Tag_dist = tag_dist;
    Tag_stroke = tag_stroke;
    Low_age = low_age;
    HighAge = highAge;
    Tag_time = tag_time;
    Tag_course = tag_course;
    Div_abbr = div_abbr;
  }
}
