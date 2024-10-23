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
/// CREATE TABLE [WaveOffset]
/// (
/// [Event_ptr] Long Integer,
/// [Heat_no] Integer,
/// [Rnd_ltr] Text (2),
/// [Wave_offset] Single
/// );

public class MmWaveoffset 
{
List<MmWaveoffset> get(OdbcConnection connection)
{
  var collection = new List<MmWaveoffset>();
  string query = "select * from WaveOffset";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt16(2); /* Heat_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* Rnd_ltr */
      var arg3 = reader.GetFloat(4); /* Wave_offset */
      collection.Add( new MmWaveoffset(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public short HeatNo{ get; }
  public string RndLtr{ get; }
  public float WaveOffset{ get; }
  // Constructor
  MmWaveoffset(long eventPtr, short heatNo, string rndLtr, float waveOffset )
  {
    EventPtr = eventPtr;
    HeatNo = heatNo;
    RndLtr = rndLtr;
    WaveOffset = waveOffset;
  }
}
