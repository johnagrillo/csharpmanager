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
/// CREATE TABLE [MSDecline]
/// (
/// [MName] Text (90),
/// [Start] DateTime,
/// [MeetSharingMeetID] Long Integer,
/// [MeetRegistrationOpens] DateTime,
/// [MeetRegistrationCloses] DateTime,
/// [MeetSharingStatus] Text (40),
/// [MeetSharingPayStatus] Text (40)
/// );

public class TmMsdecline 
{
List<TmMsdecline> get(OdbcConnection connection)
{
  var collection = new List<TmMsdecline>();
  string query = "select * from MSDecline";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* MName */
      var arg1 = reader.GetDateTime(2); /* Start */
      var arg2 = reader.GetInt64(3); /* MeetSharingMeetID */
      var arg3 = reader.GetDateTime(4); /* MeetRegistrationOpens */
      var arg4 = reader.GetDateTime(5); /* MeetRegistrationCloses */
      var arg5 = reader.GetTextReader(6).ToString(); /* MeetSharingStatus */
      var arg6 = reader.GetTextReader(7).ToString(); /* MeetSharingPayStatus */
      collection.Add( new TmMsdecline(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public string MName{ get; }
  public DateTime Start{ get; }
  public long MeetSharingMeetID{ get; }
  public DateTime MeetRegistrationOpens{ get; }
  public DateTime MeetRegistrationCloses{ get; }
  public string MeetSharingStatus{ get; }
  public string MeetSharingPayStatus{ get; }
  // Constructor
  TmMsdecline(string mName, DateTime start, long meetSharingMeetID, DateTime meetRegistrationOpens, DateTime meetRegistrationCloses, string meetSharingStatus, string meetSharingPayStatus )
  {
    MName = mName;
    Start = start;
    MeetSharingMeetID = meetSharingMeetID;
    MeetRegistrationOpens = meetRegistrationOpens;
    MeetRegistrationCloses = meetRegistrationCloses;
    MeetSharingStatus = meetSharingStatus;
    MeetSharingPayStatus = meetSharingPayStatus;
  }
}
