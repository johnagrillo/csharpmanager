using System;
using System.Collections.Generic;
using System.Data.Odbc;
/// -- ----------------------------------------------------------
/// -- MDB Tools - A library for reading MS Access database files
/// -- Copyright (C) 2000-2011 Brian Bruns and others.
/// -- Files in libmdb are licensed under LGPL and the utilities under
/// -- the GPL, see COPYING.LIB and COPYING files respectively.
/// -- Check out http://mdbtools.sourceforge.net
/// -- ----------------------------------------------------------
/// 
/// -- That file uses encoding UTF-8
/// 
/// CREATE TABLE [TestT30]
/// (
/// [athlete] Long Integer,
/// [test_date] DateTime,
/// [test_stroke] Integer,
/// [test_dist] Long Integer,
/// [test_time] Long Integer,
/// [test_sly] Text (2),
/// [test_rmk] Text (80),
/// [heart_1] Integer,
/// [heart_2] Integer,
/// [heart_3] Integer,
/// [use_it] Boolean NOT NULL
/// );

public class TmTestt30 
{
List<TmTestt30> get(OdbcConnection connection)
{
  var collection = new List<TmTestt30>();
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
      var arg0 = reader.GetInt64(1); /* athlete */
      var arg1 = reader.GetDateTime(2); /* test_date */
      var arg2 = reader.GetInt16(3); /* test_stroke */
      var arg3 = reader.GetInt64(4); /* test_dist */
      var arg4 = reader.GetInt64(5); /* test_time */
      var arg5 = reader.GetTextReader(6).ToString(); /* test_sly */
      var arg6 = reader.GetTextReader(7).ToString(); /* test_rmk */
      var arg7 = reader.GetInt16(8); /* heart_1 */
      var arg8 = reader.GetInt16(9); /* heart_2 */
      var arg9 = reader.GetInt16(10); /* heart_3 */
      var arg10 = reader.GetBoolean(11); /* use_it */
      collection.Add( new TmTestt30(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
    }
  }
  return collection;
}
  // Properties
  public long Athlete{ get; }
  public DateTime Test_date{ get; }
  public short Test_stroke{ get; }
  public long Test_dist{ get; }
  public long Test_time{ get; }
  public string Test_sly{ get; }
  public string Test_rmk{ get; }
  public short Heart_1{ get; }
  public short Heart_2{ get; }
  public short Heart_3{ get; }
  public bool Use_it{ get; }
  // Constructor
  TmTestt30(long athlete, DateTime test_date, short test_stroke, long test_dist, long test_time, string test_sly, string test_rmk, short heart_1, short heart_2, short heart_3, bool use_it )
  {
    Athlete = athlete;
    Test_date = test_date;
    Test_stroke = test_stroke;
    Test_dist = test_dist;
    Test_time = test_time;
    Test_sly = test_sly;
    Test_rmk = test_rmk;
    Heart_1 = heart_1;
    Heart_2 = heart_2;
    Heart_3 = heart_3;
    Use_it = use_it;
  }
}
