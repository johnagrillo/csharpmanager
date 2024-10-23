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
/// CREATE TABLE [Divisions]
/// (
/// [Div_no] Long Integer,
/// [Div_name] Text (40),
/// [old_date] DateTime,
/// [young_date] DateTime,
/// [div_abbr] Text (20)
/// );

public class MmDivisions 
{
List<MmDivisions> get(OdbcConnection connection)
{
  var collection = new List<MmDivisions>();
  string query = "select * from Divisions";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Div_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Div_name */
      var arg2 = reader.GetDateTime(3); /* old_date */
      var arg3 = reader.GetDateTime(4); /* young_date */
      var arg4 = reader.GetTextReader(5).ToString(); /* div_abbr */
      collection.Add( new MmDivisions(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public long DivNo{ get; }
  public string DivName{ get; }
  public DateTime Old_date{ get; }
  public DateTime Young_date{ get; }
  public string Div_abbr{ get; }
  // Constructor
  MmDivisions(long divNo, string divName, DateTime old_date, DateTime young_date, string div_abbr )
  {
    DivNo = divNo;
    DivName = divName;
    Old_date = old_date;
    Young_date = young_date;
    Div_abbr = div_abbr;
  }
}
