using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [MEETMOBILE2OPTIONS]
/// // (
/// // [MeetMobile2MeetID] Long Integer,
/// // [AgencyID] Text (80),
/// // [EV5_uploaded] Boolean NOT NULL,
/// // [Heatpsych_uploaded] Boolean NOT NULL,
/// // [Heatsheet_amount] Single,
/// // [Teamscoring_choice] Integer,
/// // [Contract_agreed] Boolean NOT NULL,
/// // [DoNotShow_timeline] Boolean NOT NULL,
/// // [HeatPsych_choice] Integer,
/// // [Contract_PersonName] Text (80),
/// // [Contract_PersonBirth] DateTime,
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
/// // [Token] Text (160),
/// // [OMEWebSite] Text (200),
/// // [License] Text (240),
/// // [NoShowActiveComSetup] Boolean NOT NULL,
/// // [AnnounceEV5_uploaded] Boolean NOT NULL,
/// // [SharingEV5_uploaded] Boolean NOT NULL,
/// // [FileSharingMeetID] Long Integer,
/// // [FileSharingEvtsOk] Boolean NOT NULL,
/// // [FileSharingPricingOk] Boolean NOT NULL,
/// // [FileSharingEntryLimitsOk] Boolean NOT NULL,
/// // [FileSharingQualTimesOk] Boolean NOT NULL,
/// // [FileSharingMeetSetupOk] Boolean NOT NULL,
/// // [NotInterestedIn_FileSharing] Boolean NOT NULL,
/// // [DoNotShow_MeetSharingImportMsg] Boolean NOT NULL,
/// // [ResultsFile_uploaded] Boolean NOT NULL,
/// // [MeetResultsID] Long Integer,
/// // [NotInterestedIn_MeetMobile] Boolean NOT NULL,
/// // [Contract_agreedMeetSharing] Boolean NOT NULL,
/// // [Contract_PersonNameMeetSharing] Text (80),
/// // [Contract_PersonBirthMeetSharing] DateTime,
/// // [HeatSheetsAre_Free] Boolean NOT NULL
/// // );

public class Meetmobile2options(long? meetMobile2MeetID, string agencyID, bool eV5Uploaded, bool heatpsychUploaded, float? heatsheetAmount, short? teamscoringChoice, bool contractAgreed, bool doNotShowTimeline, short? heatPsychChoice, string contractPersonName, DateTime? contractPersonBirth, string lastName, string firstName, string phone, string eMail, string teamName, string addr, string secAddr, string city, string state, string zip, string cntry, string timeZone, string payTo, string classification, string webSite, string token, string oMEWebSite, string license, bool noShowActiveComSetup, bool announceEV5Uploaded, bool sharingEV5Uploaded, long? fileSharingMeetID, bool fileSharingEvtsOk, bool fileSharingPricingOk, bool fileSharingEntryLimitsOk, bool fileSharingQualTimesOk, bool fileSharingMeetSetupOk, bool notInterestedInFileSharing, bool doNotShowMeetSharingImportMsg, bool resultsFileUploaded, long? meetResultsID, bool notInterestedInMeetMobile, bool contractAgreedMeetSharing, string contractPersonNameMeetSharing, DateTime? contractPersonBirthMeetSharing, bool heatSheetsAreFree )
{
static public List<Meetmobile2options> Get(OdbcConnection connection)
{
  var collection = new List<Meetmobile2options>();
  string query = "select * from MEETMOBILE2OPTIONS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* MeetMobile2MeetID nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* AgencyID nullable false*/
  var arg2 = reader.GetBoolean(2); /* EV5_uploaded nullable false*/
  var arg3 = reader.GetBoolean(3); /* Heatpsych_uploaded nullable false*/
  var arg4 = reader.IsDBNull(4) ? (float?)null :reader.GetFloat(4); /* Heatsheet_amount nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Teamscoring_choice nullable true*/
  var arg6 = reader.GetBoolean(6); /* Contract_agreed nullable false*/
  var arg7 = reader.GetBoolean(7); /* DoNotShow_timeline nullable false*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* HeatPsych_choice nullable true*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Contract_PersonName nullable false*/
  var arg10 = reader.IsDBNull(10) ? (DateTime?)null :reader.GetDateTime(10); /* Contract_PersonBirth nullable true*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* LastName nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* FirstName nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Phone nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* EMail nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* TeamName nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Addr nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* SecAddr nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* City nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* State nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* Zip nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* Cntry nullable false*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* TimeZone nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* PayTo nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* Classification nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* WebSite nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* Token nullable false*/
  var arg27 = reader.GetTextReader(27).ReadLine(); /* OMEWebSite nullable false*/
  var arg28 = reader.GetTextReader(28).ReadLine(); /* License nullable false*/
  var arg29 = reader.GetBoolean(29); /* NoShowActiveComSetup nullable false*/
  var arg30 = reader.GetBoolean(30); /* AnnounceEV5_uploaded nullable false*/
  var arg31 = reader.GetBoolean(31); /* SharingEV5_uploaded nullable false*/
  var arg32 = reader.IsDBNull(32) ? (long?)null :reader.GetInt32(32); /* FileSharingMeetID nullable true*/
  var arg33 = reader.GetBoolean(33); /* FileSharingEvtsOk nullable false*/
  var arg34 = reader.GetBoolean(34); /* FileSharingPricingOk nullable false*/
  var arg35 = reader.GetBoolean(35); /* FileSharingEntryLimitsOk nullable false*/
  var arg36 = reader.GetBoolean(36); /* FileSharingQualTimesOk nullable false*/
  var arg37 = reader.GetBoolean(37); /* FileSharingMeetSetupOk nullable false*/
  var arg38 = reader.GetBoolean(38); /* NotInterestedIn_FileSharing nullable false*/
  var arg39 = reader.GetBoolean(39); /* DoNotShow_MeetSharingImportMsg nullable false*/
  var arg40 = reader.GetBoolean(40); /* ResultsFile_uploaded nullable false*/
  var arg41 = reader.IsDBNull(41) ? (long?)null :reader.GetInt32(41); /* MeetResultsID nullable true*/
  var arg42 = reader.GetBoolean(42); /* NotInterestedIn_MeetMobile nullable false*/
  var arg43 = reader.GetBoolean(43); /* Contract_agreedMeetSharing nullable false*/
  var arg44 = reader.GetTextReader(44).ReadLine(); /* Contract_PersonNameMeetSharing nullable false*/
  var arg45 = reader.IsDBNull(45) ? (DateTime?)null :reader.GetDateTime(45); /* Contract_PersonBirthMeetSharing nullable true*/
  var arg46 = reader.GetBoolean(46); /* HeatSheetsAre_Free nullable false*/
      collection.Add( new Meetmobile2options(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46));
    }
  }
  return collection;
}
  // Properties
  public long? MeetMobile2MeetID{ get; } = meetMobile2MeetID;
  public string AgencyID{ get; } = agencyID;
  public bool EV5Uploaded{ get; } = eV5Uploaded;
  public bool HeatpsychUploaded{ get; } = heatpsychUploaded;
  public float? HeatsheetAmount{ get; } = heatsheetAmount;
  public short? TeamscoringChoice{ get; } = teamscoringChoice;
  public bool ContractAgreed{ get; } = contractAgreed;
  public bool DoNotShowTimeline{ get; } = doNotShowTimeline;
  public short? HeatPsychChoice{ get; } = heatPsychChoice;
  public string ContractPersonName{ get; } = contractPersonName;
  public DateTime? ContractPersonBirth{ get; } = contractPersonBirth;
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
  public string Token{ get; } = token;
  public string OMEWebSite{ get; } = oMEWebSite;
  public string License{ get; } = license;
  public bool NoShowActiveComSetup{ get; } = noShowActiveComSetup;
  public bool AnnounceEV5Uploaded{ get; } = announceEV5Uploaded;
  public bool SharingEV5Uploaded{ get; } = sharingEV5Uploaded;
  public long? FileSharingMeetID{ get; } = fileSharingMeetID;
  public bool FileSharingEvtsOk{ get; } = fileSharingEvtsOk;
  public bool FileSharingPricingOk{ get; } = fileSharingPricingOk;
  public bool FileSharingEntryLimitsOk{ get; } = fileSharingEntryLimitsOk;
  public bool FileSharingQualTimesOk{ get; } = fileSharingQualTimesOk;
  public bool FileSharingMeetSetupOk{ get; } = fileSharingMeetSetupOk;
  public bool NotInterestedInFileSharing{ get; } = notInterestedInFileSharing;
  public bool DoNotShowMeetSharingImportMsg{ get; } = doNotShowMeetSharingImportMsg;
  public bool ResultsFileUploaded{ get; } = resultsFileUploaded;
  public long? MeetResultsID{ get; } = meetResultsID;
  public bool NotInterestedInMeetMobile{ get; } = notInterestedInMeetMobile;
  public bool ContractAgreedMeetSharing{ get; } = contractAgreedMeetSharing;
  public string ContractPersonNameMeetSharing{ get; } = contractPersonNameMeetSharing;
  public DateTime? ContractPersonBirthMeetSharing{ get; } = contractPersonBirthMeetSharing;
  public bool HeatSheetsAreFree{ get; } = heatSheetsAreFree;
}
}
}
