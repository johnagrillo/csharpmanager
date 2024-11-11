using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Dualteams]
/// // (
/// // [team_gender] Text (2),
/// // [ateam_no] Long Integer,
/// // [bteam_no] Long Integer
/// // );

public class Dualteams(string team_gender, long? ateam_no, long? bteam_no )
{
static public List<Dualteams> Get(OdbcConnection connection)
{
  var collection = new List<Dualteams>();
  string query = "select * from Dualteams";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* team_gender nullable false*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* ateam_no nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* bteam_no nullable true*/
      collection.Add( new Dualteams(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public string Team_gender{ get; } = team_gender;
  public long? Ateam_no{ get; } = ateam_no;
  public long? Bteam_no{ get; } = bteam_no;
}
}
}
