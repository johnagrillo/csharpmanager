using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [RecordTags]
/// // (
/// // [tag_ptr] Long Integer,
/// // [tag_order] Integer,
/// // [tag_name] Text (24),
/// // [tag_flag] Text (2),
/// // [team_no] Long Integer,
/// // [allow_exh] Boolean NOT NULL,
/// // [allow_foreigner] Boolean NOT NULL,
/// // [tag_lsc] Text (6)
/// // );

public class Recordtags(long? tag_ptr, short? tag_order, string tag_name, string tag_flag, long? team_no, bool allow_exh, bool allow_foreigner, string tag_lsc )
{
static public List<Recordtags> Get(OdbcConnection connection)
{
  var collection = new List<Recordtags>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* tag_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* tag_order nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* tag_name nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* tag_flag nullable false*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* team_no nullable true*/
  var arg5 = reader.GetBoolean(5); /* allow_exh nullable false*/
  var arg6 = reader.GetBoolean(6); /* allow_foreigner nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* tag_lsc nullable false*/
      collection.Add( new Recordtags(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long? Tag_ptr{ get; } = tag_ptr;
  public short? Tag_order{ get; } = tag_order;
  public string Tag_name{ get; } = tag_name;
  public string Tag_flag{ get; } = tag_flag;
  public long? Team_no{ get; } = team_no;
  public bool Allow_exh{ get; } = allow_exh;
  public bool Allow_foreigner{ get; } = allow_foreigner;
  public string Tag_lsc{ get; } = tag_lsc;
}
}
}
