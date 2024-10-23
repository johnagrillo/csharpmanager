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
/// CREATE TABLE [TestSet]
/// (
/// [test_no] Long Integer,
/// [test_date] DateTime,
/// [tot_reps] Integer,
/// [test_dist] Long Integer,
/// [test_interval] Long Integer,
/// [test_sly] Text (2),
/// [push_off] Boolean NOT NULL,
/// [test_rmk] Text (80),
/// [test_stroke] Integer,
/// [use_it] Boolean NOT NULL
/// );

public class TmTestset 
{
List<TmTestset> get(OdbcConnection connection)
{
  var collection = new List<TmTestset>();
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
      var arg0 = reader.GetInt64(1); /* test_no */
      var arg1 = reader.GetDateTime(2); /* test_date */
      var arg2 = reader.GetInt16(3); /* tot_reps */
      var arg3 = reader.GetInt64(4); /* test_dist */
      var arg4 = reader.GetInt64(5); /* test_interval */
      var arg5 = reader.GetTextReader(6).ToString(); /* test_sly */
      var arg6 = reader.GetBoolean(7); /* push_off */
      var arg7 = reader.GetTextReader(8).ToString(); /* test_rmk */
      var arg8 = reader.GetInt16(9); /* test_stroke */
      var arg9 = reader.GetBoolean(10); /* use_it */
      collection.Add( new TmTestset(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
    }
  }
  return collection;
}
  // Properties
  public long Test_no{ get; }
  public DateTime Test_date{ get; }
  public short Tot_reps{ get; }
  public long Test_dist{ get; }
  public long Test_interval{ get; }
  public string Test_sly{ get; }
  public bool Push_off{ get; }
  public string Test_rmk{ get; }
  public short Test_stroke{ get; }
  public bool Use_it{ get; }
  // Constructor
  TmTestset(long test_no, DateTime test_date, short tot_reps, long test_dist, long test_interval, string test_sly, bool push_off, string test_rmk, short test_stroke, bool use_it )
  {
    Test_no = test_no;
    Test_date = test_date;
    Tot_reps = tot_reps;
    Test_dist = test_dist;
    Test_interval = test_interval;
    Test_sly = test_sly;
    Push_off = push_off;
    Test_rmk = test_rmk;
    Test_stroke = test_stroke;
    Use_it = use_it;
  }
}
