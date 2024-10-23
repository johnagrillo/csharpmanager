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
/// CREATE TABLE [RecordTags]
/// (
/// [tag_ptr] Long Integer,
/// [tag_order] Integer,
/// [tag_name] Text (24),
/// [tag_flag] Text (2),
/// [team_no] Long Integer,
/// [allow_exh] Boolean NOT NULL,
/// [allow_foreigner] Boolean NOT NULL,
/// [tag_lsc] Text (6)
/// );

public class MmRecordtags 
{
List<MmRecordtags> get(OdbcConnection connection)
{
  var collection = new List<MmRecordtags>();
  string query = "select * from RecordTags";
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
      var arg1 = reader.GetInt16(2); /* tag_order */
      var arg2 = reader.GetTextReader(3).ToString(); /* tag_name */
      var arg3 = reader.GetTextReader(4).ToString(); /* tag_flag */
      var arg4 = reader.GetInt64(5); /* team_no */
      var arg5 = reader.GetBoolean(6); /* allow_exh */
      var arg6 = reader.GetBoolean(7); /* allow_foreigner */
      var arg7 = reader.GetTextReader(8).ToString(); /* tag_lsc */
      collection.Add( new MmRecordtags(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long Tag_ptr{ get; }
  public short Tag_order{ get; }
  public string Tag_name{ get; }
  public string Tag_flag{ get; }
  public long Team_no{ get; }
  public bool Allow_exh{ get; }
  public bool Allow_foreigner{ get; }
  public string Tag_lsc{ get; }
  // Constructor
  MmRecordtags(long tag_ptr, short tag_order, string tag_name, string tag_flag, long team_no, bool allow_exh, bool allow_foreigner, string tag_lsc )
  {
    Tag_ptr = tag_ptr;
    Tag_order = tag_order;
    Tag_name = tag_name;
    Tag_flag = tag_flag;
    Team_no = team_no;
    Allow_exh = allow_exh;
    Allow_foreigner = allow_foreigner;
    Tag_lsc = tag_lsc;
  }
}
