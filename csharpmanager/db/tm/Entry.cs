using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [ENTRY]
/// // (
/// // [Meet] Long Integer,
/// // [Athlete] Long Integer,
/// // [I_R] Text (2),
/// // [Team] Long Integer,
/// // [Course] Text (4),
/// // [Score] Long Integer,
/// // [Ex] Text (2),
/// // [MtEvent] Long Integer,
/// // [Misc] Text (2),
/// // [Entry] Long Integer,
/// // [Division] Text (6),
/// // [HEAT] Byte,
/// // [LANE] Byte,
/// // [FromOME] Boolean NOT NULL
/// // );

public class Entry(long? meet, long? athlete, string i_r, long? team, string course, long? score, string ex, long? mtEvent, string misc, long entry, string division, byte? heat, byte? lane, bool fromOME )
{
static public List<Entry> Get(OdbcConnection connection)
{
  var collection = new List<Entry>();
  string query = "select * from ENTRY";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Meet nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Athlete nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* I_R nullable false*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* Team nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Course nullable false*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* Score nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* Ex nullable false*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* MtEvent nullable true*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Misc nullable false*/
  var arg9 = reader.GetInt32(9); /* Entry nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Division nullable false*/
  var arg11 = reader.IsDBNull(11) ? (byte?)null :reader.GetByte(11); /* HEAT nullable true*/
  var arg12 = reader.IsDBNull(12) ? (byte?)null :reader.GetByte(12); /* LANE nullable true*/
  var arg13 = reader.GetBoolean(13); /* FromOME nullable false*/
      collection.Add( new Entry(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public long? Meet{ get; } = meet;
  public long? Athlete{ get; } = athlete;
  public string I_r{ get; } = i_r;
  public long? Team{ get; } = team;
  public string Course{ get; } = course;
  public long? Score{ get; } = score;
  public string Ex{ get; } = ex;
  public long? MtEvent{ get; } = mtEvent;
  public string Misc{ get; } = misc;
  public long Entry_{ get; } = entry;
  public string Division{ get; } = division;
  public byte? Heat{ get; } = heat;
  public byte? Lane{ get; } = lane;
  public bool FromOME{ get; } = fromOME;
}
}
}
