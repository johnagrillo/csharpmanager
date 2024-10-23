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
/// CREATE TABLE [StrokeCategory]
/// (
/// [stroke_abbr] Text (6),
/// [stroke_name] Text (40)
/// );

public class TmStrokecategory 
{
List<TmStrokecategory> get(OdbcConnection connection)
{
  var collection = new List<TmStrokecategory>();
  string query = "select * from StrokeCategory";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* stroke_abbr */
      var arg1 = reader.GetTextReader(2).ToString(); /* stroke_name */
      collection.Add( new TmStrokecategory(arg0, arg1));
    }
  }
  return collection;
}
  // Properties
  public string Stroke_abbr{ get; }
  public string Stroke_name{ get; }
  // Constructor
  TmStrokecategory(string stroke_abbr, string stroke_name )
  {
    Stroke_abbr = stroke_abbr;
    Stroke_name = stroke_name;
  }
}
