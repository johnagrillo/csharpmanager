using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [CODE]
/// // (
/// // [ABBR] Text (6),
/// // [DESC] Text (60),
/// // [CODE] Long Integer,
/// // [TYPE] Byte
/// // );

public class Code(string abbr, string desc, long code, byte? type )
{
static public List<Code> Get(OdbcConnection connection)
{
  var collection = new List<Code>();
  string query = "select * from CODE";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* ABBR nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* DESC nullable false*/
  var arg2 = reader.GetInt32(2); /* CODE nullable false*/
  var arg3 = reader.IsDBNull(3) ? (byte?)null :reader.GetByte(3); /* TYPE nullable true*/
      collection.Add( new Code(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public string Abbr{ get; } = abbr;
  public string Desc{ get; } = desc;
  public long Code_{ get; } = code;
  public byte? Type{ get; } = type;
}
}
}
