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
/// CREATE TABLE [DELETEENTRY]
/// (
/// [Meet] Long Integer,
/// [Athlete] Long Integer,
/// [MtEvent] Long Integer
/// );

public class TmDeleteentry 
{
List<TmDeleteentry> get(OdbcConnection connection)
{
  var collection = new List<TmDeleteentry>();
  string query = "select * from DELETEENTRY";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Meet */
      var arg1 = reader.GetInt64(2); /* Athlete */
      var arg2 = reader.GetInt64(3); /* MtEvent */
      collection.Add( new TmDeleteentry(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public long Meet{ get; }
  public long Athlete{ get; }
  public long MtEvent{ get; }
  // Constructor
  TmDeleteentry(long meet, long athlete, long mtEvent )
  {
    Meet = meet;
    Athlete = athlete;
    MtEvent = mtEvent;
  }
}
