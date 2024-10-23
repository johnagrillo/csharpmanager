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
/// CREATE TABLE [Officials]
/// (
/// [Official_no] Long Integer,
/// [Last_name] Text (40),
/// [First_name] Text (40),
/// [Initial] Text (2),
/// [Pref_name] Text (40),
/// [Home_email] Text (100)
/// );

public class MmOfficials 
{
List<MmOfficials> get(OdbcConnection connection)
{
  var collection = new List<MmOfficials>();
  string query = "select * from Officials";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Official_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Last_name */
      var arg2 = reader.GetTextReader(3).ToString(); /* First_name */
      var arg3 = reader.GetTextReader(4).ToString(); /* Initial */
      var arg4 = reader.GetTextReader(5).ToString(); /* Pref_name */
      var arg5 = reader.GetTextReader(6).ToString(); /* Home_email */
      collection.Add( new MmOfficials(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long OfficialNo{ get; }
  public string LastName{ get; }
  public string FirstName{ get; }
  public string Initial{ get; }
  public string PrefName{ get; }
  public string HomeEmail{ get; }
  // Constructor
  MmOfficials(long officialNo, string lastName, string firstName, string initial, string prefName, string homeEmail )
  {
    OfficialNo = officialNo;
    LastName = lastName;
    FirstName = firstName;
    Initial = initial;
    PrefName = prefName;
    HomeEmail = homeEmail;
  }
}
