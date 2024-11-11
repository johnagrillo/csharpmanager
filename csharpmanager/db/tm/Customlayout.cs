using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [CustomLayout]
/// // (
/// // [ID] Long Integer,
/// // [Name] Text (40),
/// // [Portrait] Boolean NOT NULL,
/// // [Title] Text (100)
/// // );

public class Customlayout(long? id, string name, bool portrait, string title )
{
static public List<Customlayout> Get(OdbcConnection connection)
{
  var collection = new List<Customlayout>();
  string query = "select * from CustomLayout";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* ID nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Name nullable false*/
  var arg2 = reader.GetBoolean(2); /* Portrait nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Title nullable false*/
      collection.Add( new Customlayout(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long? Id{ get; } = id;
  public string Name{ get; } = name;
  public bool Portrait{ get; } = portrait;
  public string Title{ get; } = title;
}
}
}
