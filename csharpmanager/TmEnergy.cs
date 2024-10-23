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
/// CREATE TABLE [Energy]
/// (
/// [energy_no] Integer,
/// [energy_abbr] Text (6),
/// [energy_name] Text (40),
/// [stress_index] Integer
/// );

public class TmEnergy 
{
List<TmEnergy> get(OdbcConnection connection)
{
  var collection = new List<TmEnergy>();
  string query = "select * from Energy";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* energy_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* energy_abbr */
      var arg2 = reader.GetTextReader(3).ToString(); /* energy_name */
      var arg3 = reader.GetInt16(4); /* stress_index */
      collection.Add( new TmEnergy(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public short Energy_no{ get; }
  public string Energy_abbr{ get; }
  public string Energy_name{ get; }
  public short Stress_index{ get; }
  // Constructor
  TmEnergy(short energy_no, string energy_abbr, string energy_name, short stress_index )
  {
    Energy_no = energy_no;
    Energy_abbr = energy_abbr;
    Energy_name = energy_name;
    Stress_index = stress_index;
  }
}
