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
/// CREATE TABLE [TestLine]
/// (
/// [test_no] Long Integer,
/// [athlete] Long Integer,
/// [rep_no] Integer,
/// [rep_time] Long Integer
/// );

public class TmTestline 
{
List<TmTestline> get(OdbcConnection connection)
{
  var collection = new List<TmTestline>();
  string query = "select * from TestLine";
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
      var arg1 = reader.GetInt64(2); /* athlete */
      var arg2 = reader.GetInt16(3); /* rep_no */
      var arg3 = reader.GetInt64(4); /* rep_time */
      collection.Add( new TmTestline(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long Test_no{ get; }
  public long Athlete{ get; }
  public short Rep_no{ get; }
  public long Rep_time{ get; }
  // Constructor
  TmTestline(long test_no, long athlete, short rep_no, long rep_time )
  {
    Test_no = test_no;
    Athlete = athlete;
    Rep_no = rep_no;
    Rep_time = rep_time;
  }
}
