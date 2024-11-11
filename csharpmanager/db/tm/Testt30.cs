using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [TestT30]
/// // (
/// // [athlete] Long Integer,
/// // [test_date] DateTime,
/// // [test_stroke] Integer,
/// // [test_dist] Long Integer,
/// // [test_time] Long Integer,
/// // [test_sly] Text (2),
/// // [test_rmk] Text (80),
/// // [heart_1] Integer,
/// // [heart_2] Integer,
/// // [heart_3] Integer,
/// // [use_it] Boolean NOT NULL
/// // );

public class Testt30(long? athlete, DateTime? test_date, short? test_stroke, long? test_dist, long? test_time, string test_sly, string test_rmk, short? heart_1, short? heart_2, short? heart_3, bool use_it )
{
static public List<Testt30> Get(OdbcConnection connection)
{
  var collection = new List<Testt30>();
  string query = "select * from TestT30";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* athlete nullable true*/
  var arg1 = reader.IsDBNull(1) ? (DateTime?)null :reader.GetDateTime(1); /* test_date nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* test_stroke nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* test_dist nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* test_time nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* test_sly nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* test_rmk nullable false*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* heart_1 nullable true*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* heart_2 nullable true*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* heart_3 nullable true*/
  var arg10 = reader.GetBoolean(10); /* use_it nullable false*/
      collection.Add( new Testt30(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
    }
  }
  return collection;
}
  // Properties
  public long? Athlete{ get; } = athlete;
  public DateTime? Test_date{ get; } = test_date;
  public short? Test_stroke{ get; } = test_stroke;
  public long? Test_dist{ get; } = test_dist;
  public long? Test_time{ get; } = test_time;
  public string Test_sly{ get; } = test_sly;
  public string Test_rmk{ get; } = test_rmk;
  public short? Heart_1{ get; } = heart_1;
  public short? Heart_2{ get; } = heart_2;
  public short? Heart_3{ get; } = heart_3;
  public bool Use_it{ get; } = use_it;
}
}
}
