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
/// CREATE TABLE [Dualteams]
/// (
/// [team_gender] Text (2),
/// [ateam_no] Long Integer,
/// [bteam_no] Long Integer
/// );

public class MmDualteams 
{
List<MmDualteams> get(OdbcConnection connection)
{
  var collection = new List<MmDualteams>();
  string query = "select * from Dualteams";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* team_gender */
      var arg1 = reader.GetInt64(2); /* ateam_no */
      var arg2 = reader.GetInt64(3); /* bteam_no */
      collection.Add( new MmDualteams(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public string Team_gender{ get; }
  public long Ateam_no{ get; }
  public long Bteam_no{ get; }
  // Constructor
  MmDualteams(string team_gender, long ateam_no, long bteam_no )
  {
    Team_gender = team_gender;
    Ateam_no = ateam_no;
    Bteam_no = bteam_no;
  }
}
