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
/// CREATE TABLE [ESPLITS]
/// (
/// [SplitID] Long Integer,
/// [SplitIndex] Byte,
/// [Split] Long Integer,
/// [RelayLeg] Text (2)
/// );

public class TmEsplits 
{
List<TmEsplits> get(OdbcConnection connection)
{
  var collection = new List<TmEsplits>();
  string query = "select * from ESPLITS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* SplitID */
      var arg1 = reader.GetByte(2); /* SplitIndex */
      var arg2 = reader.GetInt64(3); /* Split */
      var arg3 = reader.GetTextReader(4).ToString(); /* RelayLeg */
      collection.Add( new TmEsplits(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long SplitID{ get; }
  public byte SplitIndex{ get; }
  public long Split{ get; }
  public string RelayLeg{ get; }
  // Constructor
  TmEsplits(long splitID, byte splitIndex, long split, string relayLeg )
  {
    SplitID = splitID;
    SplitIndex = splitIndex;
    Split = split;
    RelayLeg = relayLeg;
  }
}
