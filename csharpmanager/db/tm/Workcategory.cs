using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [WorkCategory]
/// // (
/// // [stroke_abbr] Text (2),
/// // [stroke_name] Text (40)
/// // );

public class Workcategory(string stroke_abbr, string stroke_name )
{
static public List<Workcategory> Get(OdbcConnection connection)
{
  var collection = new List<Workcategory>();
  string query = "select * from WorkCategory";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* stroke_abbr nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* stroke_name nullable false*/
      collection.Add( new Workcategory(arg0, arg1));
    }
  }
  return collection;
}
  // Properties
  public string Stroke_abbr{ get; } = stroke_abbr;
  public string Stroke_name{ get; } = stroke_name;
}
}
}
