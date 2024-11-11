using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Divisions]
/// // (
/// // [Div_no] Long Integer,
/// // [Div_name] Text (40),
/// // [old_date] DateTime,
/// // [young_date] DateTime,
/// // [div_abbr] Text (20)
/// // );

public class Divisions(long? divNo, string divName, DateTime? old_date, DateTime? young_date, string div_abbr )
{
static public List<Divisions> Get(OdbcConnection connection)
{
  var collection = new List<Divisions>();
  string query = "select * from Divisions";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Div_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Div_name nullable false*/
  var arg2 = reader.IsDBNull(2) ? (DateTime?)null :reader.GetDateTime(2); /* old_date nullable true*/
  var arg3 = reader.IsDBNull(3) ? (DateTime?)null :reader.GetDateTime(3); /* young_date nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* div_abbr nullable false*/
      collection.Add( new Divisions(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public long? DivNo{ get; } = divNo;
  public string DivName{ get; } = divName;
  public DateTime? Old_date{ get; } = old_date;
  public DateTime? Young_date{ get; } = young_date;
  public string Div_abbr{ get; } = div_abbr;
}
}
}
