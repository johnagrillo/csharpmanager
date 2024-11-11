using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [OMEOPTIONS]
/// // (
/// // [OMEEntryStyle] Byte,
/// // [OMEReviewTime] Byte,
/// // [EMailFrom] Text (100),
/// // [EMailSubject] Text (200),
/// // [EMailText] Text (508),
/// // [LastName] Text (100),
/// // [FirstName] Text (100),
/// // [Phone] Text (40),
/// // [EMail] Text (100),
/// // [TeamName] Text (100),
/// // [Addr] Text (100),
/// // [SecAddr] Text (60),
/// // [City] Text (60),
/// // [State] Text (6),
/// // [Zip] Text (20),
/// // [Cntry] Text (6),
/// // [TimeZone] Text (100),
/// // [PayTo] Text (100),
/// // [Classification] Text (100),
/// // [WebSite] Text (100),
/// // [NoShowMeetList] Boolean NOT NULL,
/// // [NoShowMeetSetup] Boolean NOT NULL,
/// // [NoShowActiveComSetup] Boolean NOT NULL,
/// // [Token] Text (160),
/// // [OMEWebSite] Text (200),
/// // [AgencyID] Text (80),
/// // [License] Text (240),
/// // [ActiveMeetID] Long Integer,
/// // [EV4_uploaded] Boolean NOT NULL
/// // );

public class Omeoptions(byte? oMEEntryStyle, byte? oMEReviewTime, string eMailFrom, string eMailSubject, string eMailText, string lastName, string firstName, string phone, string eMail, string teamName, string addr, string secAddr, string city, string state, string zip, string cntry, string timeZone, string payTo, string classification, string webSite, bool noShowMeetList, bool noShowMeetSetup, bool noShowActiveComSetup, string token, string oMEWebSite, string agencyID, string license, long? activeMeetID, bool eV4Uploaded )
{
static public List<Omeoptions> Get(OdbcConnection connection)
{
  var collection = new List<Omeoptions>();
  string query = "select * from OMEOPTIONS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (byte?)null :reader.GetByte(0); /* OMEEntryStyle nullable true*/
  var arg1 = reader.IsDBNull(1) ? (byte?)null :reader.GetByte(1); /* OMEReviewTime nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* EMailFrom nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* EMailSubject nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* EMailText nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* LastName nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* FirstName nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Phone nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* EMail nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* TeamName nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Addr nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* SecAddr nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* City nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* State nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Zip nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Cntry nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* TimeZone nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* PayTo nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* Classification nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* WebSite nullable false*/
  var arg20 = reader.GetBoolean(20); /* NoShowMeetList nullable false*/
  var arg21 = reader.GetBoolean(21); /* NoShowMeetSetup nullable false*/
  var arg22 = reader.GetBoolean(22); /* NoShowActiveComSetup nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* Token nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* OMEWebSite nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* AgencyID nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* License nullable false*/
  var arg27 = reader.IsDBNull(27) ? (long?)null :reader.GetInt32(27); /* ActiveMeetID nullable true*/
  var arg28 = reader.GetBoolean(28); /* EV4_uploaded nullable false*/
      collection.Add( new Omeoptions(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28));
    }
  }
  return collection;
}
  // Properties
  public byte? OMEEntryStyle{ get; } = oMEEntryStyle;
  public byte? OMEReviewTime{ get; } = oMEReviewTime;
  public string EMailFrom{ get; } = eMailFrom;
  public string EMailSubject{ get; } = eMailSubject;
  public string EMailText{ get; } = eMailText;
  public string LastName{ get; } = lastName;
  public string FirstName{ get; } = firstName;
  public string Phone{ get; } = phone;
  public string EMail{ get; } = eMail;
  public string TeamName{ get; } = teamName;
  public string Addr{ get; } = addr;
  public string SecAddr{ get; } = secAddr;
  public string City{ get; } = city;
  public string State{ get; } = state;
  public string Zip{ get; } = zip;
  public string Cntry{ get; } = cntry;
  public string TimeZone{ get; } = timeZone;
  public string PayTo{ get; } = payTo;
  public string Classification{ get; } = classification;
  public string WebSite{ get; } = webSite;
  public bool NoShowMeetList{ get; } = noShowMeetList;
  public bool NoShowMeetSetup{ get; } = noShowMeetSetup;
  public bool NoShowActiveComSetup{ get; } = noShowActiveComSetup;
  public string Token{ get; } = token;
  public string OMEWebSite{ get; } = oMEWebSite;
  public string AgencyID{ get; } = agencyID;
  public string License{ get; } = license;
  public long? ActiveMeetID{ get; } = activeMeetID;
  public bool EV4Uploaded{ get; } = eV4Uploaded;
}
}
}
