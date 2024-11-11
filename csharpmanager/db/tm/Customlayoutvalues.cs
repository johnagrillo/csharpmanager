using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [CustomLayoutValues]
/// // (
/// // [LayoutID] Long Integer,
/// // [Line] Byte,
/// // [Sequence] Byte,
/// // [FieldName] Text (40),
/// // [FieldSize] Byte,
/// // [Abbr] Text (30),
/// // [RJustified] Boolean NOT NULL
/// // );

public class Customlayoutvalues(long? layoutID, byte? line, byte? sequence, string fieldName, byte? fieldSize, string abbr, bool rJustified )
{
static public List<Customlayoutvalues> Get(OdbcConnection connection)
{
  var collection = new List<Customlayoutvalues>();
  string query = "select * from CustomLayoutValues";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* LayoutID nullable true*/
  var arg1 = reader.IsDBNull(1) ? (byte?)null :reader.GetByte(1); /* Line nullable true*/
  var arg2 = reader.IsDBNull(2) ? (byte?)null :reader.GetByte(2); /* Sequence nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* FieldName nullable false*/
  var arg4 = reader.IsDBNull(4) ? (byte?)null :reader.GetByte(4); /* FieldSize nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Abbr nullable false*/
  var arg6 = reader.GetBoolean(6); /* RJustified nullable false*/
      collection.Add( new Customlayoutvalues(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public long? LayoutID{ get; } = layoutID;
  public byte? Line{ get; } = line;
  public byte? Sequence{ get; } = sequence;
  public string FieldName{ get; } = fieldName;
  public byte? FieldSize{ get; } = fieldSize;
  public string Abbr{ get; } = abbr;
  public bool RJustified{ get; } = rJustified;
}
}
}
