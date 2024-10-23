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
/// CREATE TABLE [CUSTOMAGEGROUP]
/// (
/// [Lo_Hi] Integer,
/// [EventNum] Integer,
/// [Stroke] Integer,
/// [Distance] Integer
/// );

public class TmCustomagegroup 
{
List<TmCustomagegroup> get(OdbcConnection connection)
{
  var collection = new List<TmCustomagegroup>();
  string query = "select * from CUSTOMAGEGROUP";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* Lo_Hi */
      var arg1 = reader.GetInt16(2); /* EventNum */
      var arg2 = reader.GetInt16(3); /* Stroke */
      var arg3 = reader.GetInt16(4); /* Distance */
      collection.Add( new TmCustomagegroup(arg0, arg1, arg2, arg3));
    }
  }
  return collection;
}
  // Properties
  public short LoHi{ get; }
  public short EventNum{ get; }
  public short Stroke{ get; }
  public short Distance{ get; }
  // Constructor
  TmCustomagegroup(short loHi, short eventNum, short stroke, short distance )
  {
    LoHi = loHi;
    EventNum = eventNum;
    Stroke = stroke;
    Distance = distance;
  }
}
