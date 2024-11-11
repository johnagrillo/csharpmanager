using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [TestSet]
/// // (
/// // [test_no] Long Integer,
/// // [test_date] DateTime,
/// // [tot_reps] Integer,
/// // [test_dist] Long Integer,
/// // [test_interval] Long Integer,
/// // [test_sly] Text (2),
/// // [push_off] Boolean NOT NULL,
/// // [test_rmk] Text (80),
/// // [test_stroke] Integer,
/// // [use_it] Boolean NOT NULL
/// // );

public class Testset(long? test_no, DateTime? test_date, short? tot_reps, long? test_dist, long? test_interval, string test_sly, bool push_off, string test_rmk, short? test_stroke, bool use_it )
{
static public List<Testset> Get(OdbcConnection connection)
{
  var collection = new List<Testset>();
  string query = "select * from TestSet";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* test_no nullable true*/
  var arg1 = reader.IsDBNull(1) ? (DateTime?)null :reader.GetDateTime(1); /* test_date nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* tot_reps nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* test_dist nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* test_interval nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* test_sly nullable false*/
  var arg6 = reader.GetBoolean(6); /* push_off nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* test_rmk nullable false*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* test_stroke nullable true*/
  var arg9 = reader.GetBoolean(9); /* use_it nullable false*/
      collection.Add( new Testset(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
    }
  }
  return collection;
}
  // Properties
  public long? Test_no{ get; } = test_no;
  public DateTime? Test_date{ get; } = test_date;
  public short? Tot_reps{ get; } = tot_reps;
  public long? Test_dist{ get; } = test_dist;
  public long? Test_interval{ get; } = test_interval;
  public string Test_sly{ get; } = test_sly;
  public bool Push_off{ get; } = push_off;
  public string Test_rmk{ get; } = test_rmk;
  public short? Test_stroke{ get; } = test_stroke;
  public bool Use_it{ get; } = use_it;
}
}
}
