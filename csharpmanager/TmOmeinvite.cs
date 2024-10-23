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
/// CREATE TABLE [OMEINVITE]
/// (
/// [IMEET] Long Integer,
/// [IATHLETE] Long Integer,
/// [INVITEDATE] DateTime,
/// [NEWADD] Boolean NOT NULL,
/// [DELETED] Boolean NOT NULL,
/// [ITEAM] Long Integer,
/// [ITEAMCODE] Text (10),
/// [INVITEEMAILSENT] DateTime
/// );

public class TmOmeinvite 
{
List<TmOmeinvite> get(OdbcConnection connection)
{
  var collection = new List<TmOmeinvite>();
  string query = "select * from OMEINVITE";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* IMEET */
      var arg1 = reader.GetInt64(2); /* IATHLETE */
      var arg2 = reader.GetDateTime(3); /* INVITEDATE */
      var arg3 = reader.GetBoolean(4); /* NEWADD */
      var arg4 = reader.GetBoolean(5); /* DELETED */
      var arg5 = reader.GetInt64(6); /* ITEAM */
      var arg6 = reader.GetTextReader(7).ToString(); /* ITEAMCODE */
      var arg7 = reader.GetDateTime(8); /* INVITEEMAILSENT */
      collection.Add( new TmOmeinvite(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long Imeet{ get; }
  public long Iathlete{ get; }
  public DateTime Invitedate{ get; }
  public bool Newadd{ get; }
  public bool Deleted{ get; }
  public long Iteam{ get; }
  public string Iteamcode{ get; }
  public DateTime Inviteemailsent{ get; }
  // Constructor
  TmOmeinvite(long imeet, long iathlete, DateTime invitedate, bool newadd, bool deleted, long iteam, string iteamcode, DateTime inviteemailsent )
  {
    Imeet = imeet;
    Iathlete = iathlete;
    Invitedate = invitedate;
    Newadd = newadd;
    Deleted = deleted;
    Iteam = iteam;
    Iteamcode = iteamcode;
    Inviteemailsent = inviteemailsent;
  }
}
