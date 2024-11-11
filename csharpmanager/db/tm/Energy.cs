using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [Energy]
/// // (
/// // [energy_no] Integer,
/// // [energy_abbr] Text (6),
/// // [energy_name] Text (40),
/// // [stress_index] Integer
/// // );

public class Energy(short? energy_no, string energy_abbr, string energy_name, short? stress_index )
{
static public List<Energy> Get(OdbcConnection connection)
{
  var collection = new List<Energy>();
  string query = "select * from Energy";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* energy_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* energy_abbr nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* energy_name nullable false*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* stress_index nullable true*/
      collection.Add( new Energy(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public short? Energy_no{ get; } = energy_no;
  public string Energy_abbr{ get; } = energy_abbr;
  public string Energy_name{ get; } = energy_name;
  public short? Stress_index{ get; } = stress_index;
}
}
}
