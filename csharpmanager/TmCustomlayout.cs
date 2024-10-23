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
/// CREATE TABLE [CustomLayout]
/// (
/// [ID] Long Integer,
/// [Name] Text (40),
/// [Portrait] Boolean NOT NULL,
/// [Title] Text (100)
/// );

public class TmCustomlayout 
{
List<TmCustomlayout> get(OdbcConnection connection)
{
  var collection = new List<TmCustomlayout>();
  string query = "select * from CustomLayout";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* ID */
      var arg1 = reader.GetTextReader(2).ToString(); /* Name */
      var arg2 = reader.GetBoolean(3); /* Portrait */
      var arg3 = reader.GetTextReader(4).ToString(); /* Title */
      collection.Add( new TmCustomlayout(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long Id{ get; }
  public string Name{ get; }
  public bool Portrait{ get; }
  public string Title{ get; }
  // Constructor
  TmCustomlayout(long id, string name, bool portrait, string title )
  {
    Id = id;
    Name = name;
    Portrait = portrait;
    Title = title;
  }
}
