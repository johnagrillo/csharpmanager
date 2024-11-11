using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [SPLITS]
/// // (
/// // [SplitID] Long Integer,
/// // [SplitIndex] Byte,
/// // [Split] Long Integer,
/// // [StrokeRate] Single
/// // );

public class Splits(long? splitID, byte? splitIndex, long? split, float? strokeRate )
{
static public List<Splits> Get(OdbcConnection connection)
{
  var collection = new List<Splits>();
  string query = "select * from SPLITS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* SplitID nullable true*/
  var arg1 = reader.IsDBNull(1) ? (byte?)null :reader.GetByte(1); /* SplitIndex nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Split nullable true*/
  var arg3 = reader.IsDBNull(3) ? (float?)null :reader.GetFloat(3); /* StrokeRate nullable true*/
      collection.Add( new Splits(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long? SplitID{ get; } = splitID;
  public byte? SplitIndex{ get; } = splitIndex;
  public long? Split{ get; } = split;
  public float? StrokeRate{ get; } = strokeRate;
}
}
}
