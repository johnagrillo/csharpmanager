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
/// CREATE TABLE [MEETMOBILE2OPTIONS]
/// (
/// [MeetMobile2MeetID] Long Integer,
/// [AgencyID] Text (80),
/// [EV5_uploaded] Boolean NOT NULL,
/// [Heatpsych_uploaded] Boolean NOT NULL,
/// [Heatsheet_amount] Single,
/// [Teamscoring_choice] Integer,
/// [Contract_agreed] Boolean NOT NULL,
/// [DoNotShow_timeline] Boolean NOT NULL,
/// [HeatPsych_choice] Integer,
/// [Contract_PersonName] Text (80),
/// [Contract_PersonBirth] DateTime,
/// [LastName] Text (100),
/// [FirstName] Text (100),
/// [Phone] Text (40),
/// [EMail] Text (100),
/// [TeamName] Text (100),
/// [Addr] Text (100),
/// [SecAddr] Text (60),
/// [City] Text (60),
/// [State] Text (6),
/// [Zip] Text (20),
/// [Cntry] Text (6),
/// [TimeZone] Text (100),
/// [PayTo] Text (100),
/// [Classification] Text (100),
/// [WebSite] Text (100),
/// [Token] Text (160),
/// [OMEWebSite] Text (200),
/// [License] Text (240),
/// [NoShowActiveComSetup] Boolean NOT NULL,
/// [AnnounceEV5_uploaded] Boolean NOT NULL,
/// [SharingEV5_uploaded] Boolean NOT NULL,
/// [FileSharingMeetID] Long Integer,
/// [FileSharingEvtsOk] Boolean NOT NULL,
/// [FileSharingPricingOk] Boolean NOT NULL,
/// [FileSharingEntryLimitsOk] Boolean NOT NULL,
/// [FileSharingQualTimesOk] Boolean NOT NULL,
/// [FileSharingMeetSetupOk] Boolean NOT NULL,
/// [NotInterestedIn_FileSharing] Boolean NOT NULL,
/// [DoNotShow_MeetSharingImportMsg] Boolean NOT NULL,
/// [ResultsFile_uploaded] Boolean NOT NULL,
/// [MeetResultsID] Long Integer,
/// [NotInterestedIn_MeetMobile] Boolean NOT NULL,
/// [Contract_agreedMeetSharing] Boolean NOT NULL,
/// [Contract_PersonNameMeetSharing] Text (80),
/// [Contract_PersonBirthMeetSharing] DateTime,
/// [HeatSheetsAre_Free] Boolean NOT NULL
/// );

public class MmMeetmobile2options 
{
List<MmMeetmobile2options> get(OdbcConnection connection)
{
  var collection = new List<MmMeetmobile2options>();
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
      var arg0 = reader.GetInt64(1); /* MeetMobile2MeetID */
      var arg1 = reader.GetTextReader(2).ToString(); /* AgencyID */
      var arg2 = reader.GetBoolean(3); /* EV5_uploaded */
      var arg3 = reader.GetBoolean(4); /* Heatpsych_uploaded */
      var arg4 = reader.GetFloat(5); /* Heatsheet_amount */
      var arg5 = reader.GetInt16(6); /* Teamscoring_choice */
      var arg6 = reader.GetBoolean(7); /* Contract_agreed */
      var arg7 = reader.GetBoolean(8); /* DoNotShow_timeline */
      var arg8 = reader.GetInt16(9); /* HeatPsych_choice */
      var arg9 = reader.GetTextReader(10).ToString(); /* Contract_PersonName */
      var arg10 = reader.GetDateTime(11); /* Contract_PersonBirth */
      var arg11 = reader.GetTextReader(12).ToString(); /* LastName */
      var arg12 = reader.GetTextReader(13).ToString(); /* FirstName */
      var arg13 = reader.GetTextReader(14).ToString(); /* Phone */
      var arg14 = reader.GetTextReader(15).ToString(); /* EMail */
      var arg15 = reader.GetTextReader(16).ToString(); /* TeamName */
      var arg16 = reader.GetTextReader(17).ToString(); /* Addr */
      var arg17 = reader.GetTextReader(18).ToString(); /* SecAddr */
      var arg18 = reader.GetTextReader(19).ToString(); /* City */
      var arg19 = reader.GetTextReader(20).ToString(); /* State */
      var arg20 = reader.GetTextReader(21).ToString(); /* Zip */
      var arg21 = reader.GetTextReader(22).ToString(); /* Cntry */
      var arg22 = reader.GetTextReader(23).ToString(); /* TimeZone */
      var arg23 = reader.GetTextReader(24).ToString(); /* PayTo */
      var arg24 = reader.GetTextReader(25).ToString(); /* Classification */
      var arg25 = reader.GetTextReader(26).ToString(); /* WebSite */
      var arg26 = reader.GetTextReader(27).ToString(); /* Token */
      var arg27 = reader.GetTextReader(28).ToString(); /* OMEWebSite */
      var arg28 = reader.GetTextReader(29).ToString(); /* License */
      var arg29 = reader.GetBoolean(30); /* NoShowActiveComSetup */
      var arg30 = reader.GetBoolean(31); /* AnnounceEV5_uploaded */
      var arg31 = reader.GetBoolean(32); /* SharingEV5_uploaded */
      var arg32 = reader.GetInt64(33); /* FileSharingMeetID */
      var arg33 = reader.GetBoolean(34); /* FileSharingEvtsOk */
      var arg34 = reader.GetBoolean(35); /* FileSharingPricingOk */
      var arg35 = reader.GetBoolean(36); /* FileSharingEntryLimitsOk */
      var arg36 = reader.GetBoolean(37); /* FileSharingQualTimesOk */
      var arg37 = reader.GetBoolean(38); /* FileSharingMeetSetupOk */
      var arg38 = reader.GetBoolean(39); /* NotInterestedIn_FileSharing */
      var arg39 = reader.GetBoolean(40); /* DoNotShow_MeetSharingImportMsg */
      var arg40 = reader.GetBoolean(41); /* ResultsFile_uploaded */
      var arg41 = reader.GetInt64(42); /* MeetResultsID */
      var arg42 = reader.GetBoolean(43); /* NotInterestedIn_MeetMobile */
      var arg43 = reader.GetBoolean(44); /* Contract_agreedMeetSharing */
      var arg44 = reader.GetTextReader(45).ToString(); /* Contract_PersonNameMeetSharing */
      var arg45 = reader.GetDateTime(46); /* Contract_PersonBirthMeetSharing */
      var arg46 = reader.GetBoolean(47); /* HeatSheetsAre_Free */
      collection.Add( new MmMeetmobile2options(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46));
    }
  }
  return collection;
}
  // Properties
  public long MeetMobile2MeetID{ get; }
  public string AgencyID{ get; }
  public bool EV5Uploaded{ get; }
  public bool HeatpsychUploaded{ get; }
  public float HeatsheetAmount{ get; }
  public short TeamscoringChoice{ get; }
  public bool ContractAgreed{ get; }
  public bool DoNotShowTimeline{ get; }
  public short HeatPsychChoice{ get; }
  public string ContractPersonName{ get; }
  public DateTime ContractPersonBirth{ get; }
  public string LastName{ get; }
  public string FirstName{ get; }
  public string Phone{ get; }
  public string EMail{ get; }
  public string TeamName{ get; }
  public string Addr{ get; }
  public string SecAddr{ get; }
  public string City{ get; }
  public string State{ get; }
  public string Zip{ get; }
  public string Cntry{ get; }
  public string TimeZone{ get; }
  public string PayTo{ get; }
  public string Classification{ get; }
  public string WebSite{ get; }
  public string Token{ get; }
  public string OMEWebSite{ get; }
  public string License{ get; }
  public bool NoShowActiveComSetup{ get; }
  public bool AnnounceEV5Uploaded{ get; }
  public bool SharingEV5Uploaded{ get; }
  public long FileSharingMeetID{ get; }
  public bool FileSharingEvtsOk{ get; }
  public bool FileSharingPricingOk{ get; }
  public bool FileSharingEntryLimitsOk{ get; }
  public bool FileSharingQualTimesOk{ get; }
  public bool FileSharingMeetSetupOk{ get; }
  public bool NotInterestedInFileSharing{ get; }
  public bool DoNotShowMeetSharingImportMsg{ get; }
  public bool ResultsFileUploaded{ get; }
  public long MeetResultsID{ get; }
  public bool NotInterestedInMeetMobile{ get; }
  public bool ContractAgreedMeetSharing{ get; }
  public string ContractPersonNameMeetSharing{ get; }
  public DateTime ContractPersonBirthMeetSharing{ get; }
  public bool HeatSheetsAreFree{ get; }
  // Constructor
  MmMeetmobile2options(long meetMobile2MeetID, string agencyID, bool eV5Uploaded, bool heatpsychUploaded, float heatsheetAmount, short teamscoringChoice, bool contractAgreed, bool doNotShowTimeline, short heatPsychChoice, string contractPersonName, DateTime contractPersonBirth, string lastName, string firstName, string phone, string eMail, string teamName, string addr, string secAddr, string city, string state, string zip, string cntry, string timeZone, string payTo, string classification, string webSite, string token, string oMEWebSite, string license, bool noShowActiveComSetup, bool announceEV5Uploaded, bool sharingEV5Uploaded, long fileSharingMeetID, bool fileSharingEvtsOk, bool fileSharingPricingOk, bool fileSharingEntryLimitsOk, bool fileSharingQualTimesOk, bool fileSharingMeetSetupOk, bool notInterestedInFileSharing, bool doNotShowMeetSharingImportMsg, bool resultsFileUploaded, long meetResultsID, bool notInterestedInMeetMobile, bool contractAgreedMeetSharing, string contractPersonNameMeetSharing, DateTime contractPersonBirthMeetSharing, bool heatSheetsAreFree )
  {
    MeetMobile2MeetID = meetMobile2MeetID;
    AgencyID = agencyID;
    EV5Uploaded = eV5Uploaded;
    HeatpsychUploaded = heatpsychUploaded;
    HeatsheetAmount = heatsheetAmount;
    TeamscoringChoice = teamscoringChoice;
    ContractAgreed = contractAgreed;
    DoNotShowTimeline = doNotShowTimeline;
    HeatPsychChoice = heatPsychChoice;
    ContractPersonName = contractPersonName;
    ContractPersonBirth = contractPersonBirth;
    LastName = lastName;
    FirstName = firstName;
    Phone = phone;
    EMail = eMail;
    TeamName = teamName;
    Addr = addr;
    SecAddr = secAddr;
    City = city;
    State = state;
    Zip = zip;
    Cntry = cntry;
    TimeZone = timeZone;
    PayTo = payTo;
    Classification = classification;
    WebSite = webSite;
    Token = token;
    OMEWebSite = oMEWebSite;
    License = license;
    NoShowActiveComSetup = noShowActiveComSetup;
    AnnounceEV5Uploaded = announceEV5Uploaded;
    SharingEV5Uploaded = sharingEV5Uploaded;
    FileSharingMeetID = fileSharingMeetID;
    FileSharingEvtsOk = fileSharingEvtsOk;
    FileSharingPricingOk = fileSharingPricingOk;
    FileSharingEntryLimitsOk = fileSharingEntryLimitsOk;
    FileSharingQualTimesOk = fileSharingQualTimesOk;
    FileSharingMeetSetupOk = fileSharingMeetSetupOk;
    NotInterestedInFileSharing = notInterestedInFileSharing;
    DoNotShowMeetSharingImportMsg = doNotShowMeetSharingImportMsg;
    ResultsFileUploaded = resultsFileUploaded;
    MeetResultsID = meetResultsID;
    NotInterestedInMeetMobile = notInterestedInMeetMobile;
    ContractAgreedMeetSharing = contractAgreedMeetSharing;
    ContractPersonNameMeetSharing = contractPersonNameMeetSharing;
    ContractPersonBirthMeetSharing = contractPersonBirthMeetSharing;
    HeatSheetsAreFree = heatSheetsAreFree;
  }
}
