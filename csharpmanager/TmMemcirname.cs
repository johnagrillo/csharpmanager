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
/// CREATE TABLE [MemCirName]
/// (
/// [cir_no] Long Integer,
/// [cir_name] Text (180),
/// [tot_lines] Integer,
/// [tot_dist] Long Integer,
/// [tot_seconds] Long Integer
/// );

public class TmMemcirname 
{
List<TmMemcirname> get(OdbcConnection connection)
{
  var collection = new List<TmMemcirname>();
  string query = "select * from MemCirName";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* cir_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* cir_name */
      var arg2 = reader.GetInt16(3); /* tot_lines */
      var arg3 = reader.GetInt64(4); /* tot_dist */
      var arg4 = reader.GetInt64(5); /* tot_seconds */
      collection.Add( new TmMemcirname(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public long Cir_no{ get; }
  public string Cir_name{ get; }
  public short Tot_lines{ get; }
  public long Tot_dist{ get; }
  public long Tot_seconds{ get; }
  // Constructor
  TmMemcirname(long cir_no, string cir_name, short tot_lines, long tot_dist, long tot_seconds )
  {
    Cir_no = cir_no;
    Cir_name = cir_name;
    Tot_lines = tot_lines;
    Tot_dist = tot_dist;
    Tot_seconds = tot_seconds;
  }
}
