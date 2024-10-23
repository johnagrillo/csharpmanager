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
/// CREATE TABLE [TestData]
/// (
/// [test_no] Long Integer,
/// [athlete] Long Integer,
/// [heart_1] Integer,
/// [heart_2] Integer,
/// [heart_3] Integer,
/// [ind_rmk] Text (80)
/// );

public class TmTestdata 
{
List<TmTestdata> get(OdbcConnection connection)
{
  var collection = new List<TmTestdata>();
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
      var arg0 = reader.GetInt64(1); /* test_no */
      var arg1 = reader.GetInt64(2); /* athlete */
      var arg2 = reader.GetInt16(3); /* heart_1 */
      var arg3 = reader.GetInt16(4); /* heart_2 */
      var arg4 = reader.GetInt16(5); /* heart_3 */
      var arg5 = reader.GetTextReader(6).ToString(); /* ind_rmk */
      collection.Add( new TmTestdata(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long Test_no{ get; }
  public long Athlete{ get; }
  public short Heart_1{ get; }
  public short Heart_2{ get; }
  public short Heart_3{ get; }
  public string Ind_rmk{ get; }
  // Constructor
  TmTestdata(long test_no, long athlete, short heart_1, short heart_2, short heart_3, string ind_rmk )
  {
    Test_no = test_no;
    Athlete = athlete;
    Heart_1 = heart_1;
    Heart_2 = heart_2;
    Heart_3 = heart_3;
    Ind_rmk = ind_rmk;
  }
}
