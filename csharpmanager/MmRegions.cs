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
/// CREATE TABLE [Regions]
/// (
/// [Reg_no] Long Integer,
/// [Reg_abbr] Text (4),
/// [Reg_name] Text (40),
/// [fem_size] Integer,
/// [male_size] Integer,
/// [combined_size] Integer
/// );

public class MmRegions 
{
List<MmRegions> get(OdbcConnection connection)
{
  var collection = new List<MmRegions>();
  string query = "select * from Regions";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Reg_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Reg_abbr */
      var arg2 = reader.GetTextReader(3).ToString(); /* Reg_name */
      var arg3 = reader.GetInt16(4); /* fem_size */
      var arg4 = reader.GetInt16(5); /* male_size */
      var arg5 = reader.GetInt16(6); /* combined_size */
      collection.Add( new MmRegions(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long RegNo{ get; }
  public string RegAbbr{ get; }
  public string RegName{ get; }
  public short Fem_size{ get; }
  public short Male_size{ get; }
  public short Combined_size{ get; }
  // Constructor
  MmRegions(long regNo, string regAbbr, string regName, short fem_size, short male_size, short combined_size )
  {
    RegNo = regNo;
    RegAbbr = regAbbr;
    RegName = regName;
    Fem_size = fem_size;
    Male_size = male_size;
    Combined_size = combined_size;
  }
}
