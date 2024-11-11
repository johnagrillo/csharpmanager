using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [WaveOffset]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Heat_no] Integer,
/// // [Rnd_ltr] Text (2),
/// // [Wave_offset] Single
/// // );

public class Waveoffset(long? eventPtr, short? heatNo, string rndLtr, float? waveOffset )
{
static public List<Waveoffset> Get(OdbcConnection connection)
{
  var collection = new List<Waveoffset>();
  string query = "select * from WaveOffset";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Event_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Heat_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Rnd_ltr nullable false*/
  var arg3 = reader.IsDBNull(3) ? (float?)null :reader.GetFloat(3); /* Wave_offset nullable true*/
      collection.Add( new Waveoffset(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public short? HeatNo{ get; } = heatNo;
  public string RndLtr{ get; } = rndLtr;
  public float? WaveOffset{ get; } = waveOffset;
}
}
}
