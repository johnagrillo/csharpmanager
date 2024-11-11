using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [SetDescriptions]
/// // (
/// // [set_name] Text (60)
/// // );

public class Setdescriptions(string set_name )
{
static public List<Setdescriptions> Get(OdbcConnection connection)
{
  var collection = new List<Setdescriptions>();
  string query = "select * from SetDescriptions";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* set_name nullable false*/
      collection.Add( new Setdescriptions(arg0));
    }
  }
  return collection;
}
  // Properties
  public string Set_name{ get; } = set_name;
}
}
}
