using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [CUSTOMAGEGROUP]
/// // (
/// // [Lo_Hi] Integer,
/// // [EventNum] Integer,
/// // [Stroke] Integer,
/// // [Distance] Integer
/// // );

public class Customagegroup(short? loHi, short? eventNum, short? stroke, short? distance )
{
static public List<Customagegroup> Get(OdbcConnection connection)
{
  var collection = new List<Customagegroup>();
  string query = "select * from CUSTOMAGEGROUP";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* Lo_Hi nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* EventNum nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* Stroke nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Distance nullable true*/
      collection.Add( new Customagegroup(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public short? LoHi{ get; } = loHi;
  public short? EventNum{ get; } = eventNum;
  public short? Stroke{ get; } = stroke;
  public short? Distance{ get; } = distance;
}
}
}
