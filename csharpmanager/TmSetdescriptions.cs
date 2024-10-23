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
/// CREATE TABLE [SetDescriptions]
/// (
/// [set_name] Text (60)
/// );

public class TmSetdescriptions 
{
List<TmSetdescriptions> get(OdbcConnection connection)
{
  var collection = new List<TmSetdescriptions>();
  string query = "select * from SetDescriptions";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* set_name */
      collection.Add( new TmSetdescriptions(arg0));
    }
  }
  return collection;
}
  // Properties
  public string Set_name{ get; }
  // Constructor
  TmSetdescriptions(string set_name )
  {
    Set_name = set_name;
  }
}