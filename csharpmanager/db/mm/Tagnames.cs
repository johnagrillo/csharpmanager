using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [TagNames]
/// // (
/// // [tag_ptr] Long Integer,
/// // [tag_name] Text (8),
/// // [for_scoring] Boolean NOT NULL,
/// // [for_entryqual] Boolean NOT NULL,
/// // [for_timestd] Boolean NOT NULL,
/// // [tag_desc] Text (40)
/// // );

public class Tagnames(long? tag_ptr, string tag_name, bool for_scoring, bool for_entryqual, bool for_timestd, string tag_desc )
{
static public List<Tagnames> Get(OdbcConnection connection)
{
  var collection = new List<Tagnames>();
  string query = "select * from TagNames";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* tag_ptr nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* tag_name nullable false*/
  var arg2 = reader.GetBoolean(2); /* for_scoring nullable false*/
  var arg3 = reader.GetBoolean(3); /* for_entryqual nullable false*/
  var arg4 = reader.GetBoolean(4); /* for_timestd nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* tag_desc nullable false*/
      collection.Add( new Tagnames(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long? Tag_ptr{ get; } = tag_ptr;
  public string Tag_name{ get; } = tag_name;
  public bool For_scoring{ get; } = for_scoring;
  public bool For_entryqual{ get; } = for_entryqual;
  public bool For_timestd{ get; } = for_timestd;
  public string Tag_desc{ get; } = tag_desc;
}
}
}
