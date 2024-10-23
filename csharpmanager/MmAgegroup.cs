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
/// CREATE TABLE [Agegroup]
/// (
/// [Low_age] Integer,
/// [High_age] Integer
/// );

public class MmAgegroup 
{
List<MmAgegroup> get(OdbcConnection connection)
{
  var collection = new List<MmAgegroup>();
  string query = "select * from Agegroup";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* Low_age */
      var arg1 = reader.GetInt16(2); /* High_age */
      collection.Add( new MmAgegroup(arg0, arg1));
    }
  }
  return collection;
}
  // Properties
  public short LowAge{ get; }
  public short HighAge{ get; }
  // Constructor
  MmAgegroup(short lowAge, short highAge )
  {
    LowAge = lowAge;
    HighAge = highAge;
  }
}
