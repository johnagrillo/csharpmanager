using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [JOURNAL]
/// // (
/// // [JDate] DateTime,
/// // [Subject] Text (40),
/// // [Comment] Text (510)
/// // );

public class Journal(DateTime? jDate, string subject, string comment )
{
static public List<Journal> Get(OdbcConnection connection)
{
  var collection = new List<Journal>();
  string query = "select * from JOURNAL";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (DateTime?)null :reader.GetDateTime(0); /* JDate nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Subject nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Comment nullable false*/
      collection.Add( new Journal(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public DateTime? JDate{ get; } = jDate;
  public string Subject{ get; } = subject;
  public string Comment{ get; } = comment;
}
}
}
