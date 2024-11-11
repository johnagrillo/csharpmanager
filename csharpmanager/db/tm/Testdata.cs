using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [TestData]
/// // (
/// // [test_no] Long Integer,
/// // [athlete] Long Integer,
/// // [heart_1] Integer,
/// // [heart_2] Integer,
/// // [heart_3] Integer,
/// // [ind_rmk] Text (80)
/// // );

public class Testdata(long? test_no, long? athlete, short? heart_1, short? heart_2, short? heart_3, string ind_rmk )
{
static public List<Testdata> Get(OdbcConnection connection)
{
  var collection = new List<Testdata>();
  string query = "select * from TestData";
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
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* athlete nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* heart_1 nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* heart_2 nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* heart_3 nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* ind_rmk nullable false*/
      collection.Add( new Testdata(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long? Test_no{ get; } = test_no;
  public long? Athlete{ get; } = athlete;
  public short? Heart_1{ get; } = heart_1;
  public short? Heart_2{ get; } = heart_2;
  public short? Heart_3{ get; } = heart_3;
  public string Ind_rmk{ get; } = ind_rmk;
}
}
}
