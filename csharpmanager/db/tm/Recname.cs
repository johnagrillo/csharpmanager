using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [RECNAME]
/// // (
/// // [RecFile] Text (16),
/// // [Year] Text (8),
/// // [Descript] Text (40),
/// // [Flag] Text (2),
/// // [Course] Text (2),
/// // [Record] Long Integer
/// // );

public class Recname(string recFile, string year, string descript, string flag, string course, long? record )
{
static public List<Recname> Get(OdbcConnection connection)
{
  var collection = new List<Recname>();
  string query = "select * from RECNAME";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* RecFile nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Year nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Descript nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Flag nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Course nullable false*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* Record nullable true*/
      collection.Add( new Recname(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public string RecFile{ get; } = recFile;
  public string Year{ get; } = year;
  public string Descript{ get; } = descript;
  public string Flag{ get; } = flag;
  public string Course{ get; } = course;
  public long? Record{ get; } = record;
}
}
}
