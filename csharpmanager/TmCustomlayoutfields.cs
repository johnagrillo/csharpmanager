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
/// CREATE TABLE [CustomLayoutFields]
/// (
/// [FieldName] Text (40),
/// [Description] Text (60),
/// [Size] Integer,
/// [Abbr] Text (30)
/// );

public class TmCustomlayoutfields 
{
List<TmCustomlayoutfields> get(OdbcConnection connection)
{
  var collection = new List<TmCustomlayoutfields>();
  string query = "select * from CustomLayoutFields";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* FieldName */
      var arg1 = reader.GetTextReader(2).ToString(); /* Description */
      var arg2 = reader.GetInt16(3); /* Size */
      var arg3 = reader.GetTextReader(4).ToString(); /* Abbr */
      collection.Add( new TmCustomlayoutfields(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public string FieldName{ get; }
  public string Description{ get; }
  public short Size{ get; }
  public string Abbr{ get; }
  // Constructor
  TmCustomlayoutfields(string fieldName, string description, short size, string abbr )
  {
    FieldName = fieldName;
    Description = description;
    Size = size;
    Abbr = abbr;
  }
}
