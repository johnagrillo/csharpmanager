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
/// CREATE TABLE [RECNAME]
/// (
/// [RecFile] Text (16),
/// [Year] Text (8),
/// [Descript] Text (40),
/// [Flag] Text (2),
/// [Course] Text (2),
/// [Record] Long Integer
/// );

public class TmRecname 
{
List<TmRecname> get(OdbcConnection connection)
{
  var collection = new List<TmRecname>();
  string query = "select * from RECNAME";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* RecFile */
      var arg1 = reader.GetTextReader(2).ToString(); /* Year */
      var arg2 = reader.GetTextReader(3).ToString(); /* Descript */
      var arg3 = reader.GetTextReader(4).ToString(); /* Flag */
      var arg4 = reader.GetTextReader(5).ToString(); /* Course */
      var arg5 = reader.GetInt64(6); /* Record */
      collection.Add( new TmRecname(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public string RecFile{ get; }
  public string Year{ get; }
  public string Descript{ get; }
  public string Flag{ get; }
  public string Course{ get; }
  public long Record{ get; }
  // Constructor
  TmRecname(string recFile, string year, string descript, string flag, string course, long record )
  {
    RecFile = recFile;
    Year = year;
    Descript = descript;
    Flag = flag;
    Course = course;
    Record = record;
  }
}
