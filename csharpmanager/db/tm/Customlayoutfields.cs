using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [CustomLayoutFields]
/// // (
/// // [FieldName] Text (40),
/// // [Description] Text (60),
/// // [Size] Integer,
/// // [Abbr] Text (30)
/// // );

public class Customlayoutfields(string fieldName, string description, short? size, string abbr )
{
static public List<Customlayoutfields> Get(OdbcConnection connection)
{
  var collection = new List<Customlayoutfields>();
  string query = "select * from CustomLayoutFields";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* FieldName nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Description nullable false*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* Size nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Abbr nullable false*/
      collection.Add( new Customlayoutfields(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public string FieldName{ get; } = fieldName;
  public string Description{ get; } = description;
  public short? Size{ get; } = size;
  public string Abbr{ get; } = abbr;
}
}
}
