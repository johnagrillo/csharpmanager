using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [ESPLITS]
/// // (
/// // [SplitID] Long Integer,
/// // [SplitIndex] Byte,
/// // [Split] Long Integer,
/// // [RelayLeg] Text (2)
/// // );

public class Esplits(long? splitID, byte? splitIndex, long? split, string relayLeg )
{
static public List<Esplits> Get(OdbcConnection connection)
{
  var collection = new List<Esplits>();
  string query = "select * from ESPLITS";
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
  var arg3 = reader.GetTextReader(3).ReadLine(); /* RelayLeg nullable false*/
      collection.Add( new Esplits(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long? SplitID{ get; } = splitID;
  public byte? SplitIndex{ get; } = splitIndex;
  public long? Split{ get; } = split;
  public string RelayLeg{ get; } = relayLeg;
}
}
}
