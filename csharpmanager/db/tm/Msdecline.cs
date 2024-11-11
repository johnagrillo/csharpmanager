using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MSDecline]
/// // (
/// // [MName] Text (90),
/// // [Start] DateTime,
/// // [MeetSharingMeetID] Long Integer,
/// // [MeetRegistrationOpens] DateTime,
/// // [MeetRegistrationCloses] DateTime,
/// // [MeetSharingStatus] Text (40),
/// // [MeetSharingPayStatus] Text (40)
/// // );

public class Msdecline(string mName, DateTime? start, long? meetSharingMeetID, DateTime? meetRegistrationOpens, DateTime? meetRegistrationCloses, string meetSharingStatus, string meetSharingPayStatus )
{
static public List<Msdecline> Get(OdbcConnection connection)
{
  var collection = new List<Msdecline>();
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
  var arg0 = reader.GetTextReader(0).ReadLine(); /* MName nullable false*/
  var arg1 = reader.IsDBNull(1) ? (DateTime?)null :reader.GetDateTime(1); /* Start nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* MeetSharingMeetID nullable true*/
  var arg3 = reader.IsDBNull(3) ? (DateTime?)null :reader.GetDateTime(3); /* MeetRegistrationOpens nullable true*/
  var arg4 = reader.IsDBNull(4) ? (DateTime?)null :reader.GetDateTime(4); /* MeetRegistrationCloses nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* MeetSharingStatus nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* MeetSharingPayStatus nullable false*/
      collection.Add( new Msdecline(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public string MName{ get; } = mName;
  public DateTime? Start{ get; } = start;
  public long? MeetSharingMeetID{ get; } = meetSharingMeetID;
  public DateTime? MeetRegistrationOpens{ get; } = meetRegistrationOpens;
  public DateTime? MeetRegistrationCloses{ get; } = meetRegistrationCloses;
  public string MeetSharingStatus{ get; } = meetSharingStatus;
  public string MeetSharingPayStatus{ get; } = meetSharingPayStatus;
}
}
}
