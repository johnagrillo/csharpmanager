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
/// CREATE TABLE [Multiage]
/// (
/// [event_ptr] Long Integer,
/// [low_age] Integer,
/// [high_age] Integer,
/// [Heats_infinal] Text (2),
/// [Num_Heatsinfinal] Integer
/// );

public class MmMultiage 
{
List<MmMultiage> get(OdbcConnection connection)
{
  var collection = new List<MmMultiage>();
  string query = "select * from Multiage";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* event_ptr */
      var arg1 = reader.GetInt16(2); /* low_age */
      var arg2 = reader.GetInt16(3); /* high_age */
      var arg3 = reader.GetTextReader(4).ToString(); /* Heats_infinal */
      var arg4 = reader.GetInt16(5); /* Num_Heatsinfinal */
      collection.Add( new MmMultiage(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public long Event_ptr{ get; }
  public short Low_age{ get; }
  public short High_age{ get; }
  public string HeatsInfinal{ get; }
  public short NumHeatsinfinal{ get; }
  // Constructor
  MmMultiage(long event_ptr, short low_age, short high_age, string heatsInfinal, short numHeatsinfinal )
  {
    Event_ptr = event_ptr;
    Low_age = low_age;
    High_age = high_age;
    HeatsInfinal = heatsInfinal;
    NumHeatsinfinal = numHeatsinfinal;
  }
}
