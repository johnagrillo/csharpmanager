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
/// CREATE TABLE [MEET]
/// (
/// [Meet] Long Integer,
/// [MName] Text (90),
/// [Start] DateTime,
/// [End] DateTime,
/// [AgeUp] DateTime,
/// [Since] DateTime,
/// [Course] Text (4),
/// [Location] Text (90),
/// [Remarks] Text (100),
/// [IndCharge] Single,
/// [RelCharge] Single,
/// [SurCharge] Single,
/// [Type] Text (6),
/// [Sanction] Text (30),
/// [MaxIndEnt] Integer,
/// [MaxRelEnt] Integer,
/// [MaxEnt] Integer,
/// [RestrictBest] Boolean NOT NULL,
/// [NonConform] Double,
/// [EnterAtQTime] Boolean NOT NULL,
/// [FacilityFee] Single,
/// [TeamFee] Single,
/// [Instructions] Text (500),
/// [MinAge] Integer,
/// [EnforceQualifying] Boolean NOT NULL,
/// [Altitude] Integer,
/// [EnforceSlowQtime] Boolean NOT NULL,
/// [BanNoTimes] Boolean NOT NULL,
/// [Lanes] Integer,
/// [EvenOrOdd] Integer,
/// [FastToSlow] Boolean NOT NULL,
/// [Masters] Boolean NOT NULL,
/// [ActiveFeeXMLSent] Boolean NOT NULL,
/// [MinAge10AndUnder] Integer,
/// [SeedLanes] Text (32),
/// [DeadLine] DateTime,
/// [ActiveMeetID] Long Integer,
/// [CustIndCharge] Single,
/// [CustRelCharge] Single,
/// [CustSurCharge] Single,
/// [CustIndAction] Byte,
/// [CustRelAction] Byte,
/// [CustSurAction] Byte,
/// [Addr] Text (60),
/// [Addr2] Text (60),
/// [City] Text (60),
/// [State] Text (6),
/// [ZIP] Text (20),
/// [Cntry] Text (40),
/// [UseCustomFees] Boolean NOT NULL,
/// [OMEEntryStyle] Byte,
/// [SwimmerEntryDeadLine] DateTime,
/// [SwimmerEntryOpen] DateTime,
/// [AllowCustomTimes] Boolean NOT NULL,
/// [ExportEntriesDate] DateTime,
/// [LastSyncDate] DateTime,
/// [FinalizeEntriesDate] DateTime,
/// [UseSwimmersTeam] Boolean NOT NULL,
/// [HonorInviteList] Boolean NOT NULL,
/// [EntryTeam] Long Integer,
/// [EMailFrom] Text (100),
/// [EMailText] Text (508),
/// [EMailSubject] Text (200),
/// [OnlyPreEntered] Boolean NOT NULL,
/// [License] Text (240),
/// [CollectFeesOnline] Boolean NOT NULL,
/// [OMEBillDate] DateTime,
/// [InviteEmailDate] DateTime,
/// [EntryEMailText] Text (508),
/// [EntryEMailSubject] Text (200),
/// [EntryEMailFrom] Text (100),
/// [OMEValidated] Boolean NOT NULL,
/// [OMECustomTeam] Boolean NOT NULL,
/// [OMEFilterTeam] Long Integer,
/// [OMENeedsSync] Boolean NOT NULL,
/// [OMENeedSync] Boolean NOT NULL,
/// [MeetSharingStatus] Text (40),
/// [FileExportType] Integer,
/// [MeetRegistrationOpens] DateTime,
/// [MeetRegistrationCloses] DateTime,
/// [MeetSharingMeetID] Long Integer,
/// [MeetSharingPayStatus] Text (40),
/// [MeetSharingResultDate] DateTime,
/// [EV3Version] Byte
/// );

public class TmMeet 
{
Dictionary<long,TmMeet> get(OdbcConnection connection)
{
  var collection = new Dictionary<long,TmMeet>();
  string query = "select * from MEET";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Meet */
      var arg1 = reader.GetTextReader(2).ToString(); /* MName */
      var arg2 = reader.GetDateTime(3); /* Start */
      var arg3 = reader.GetDateTime(4); /* End */
      var arg4 = reader.GetDateTime(5); /* AgeUp */
      var arg5 = reader.GetDateTime(6); /* Since */
      var arg6 = reader.GetTextReader(7).ToString(); /* Course */
      var arg7 = reader.GetTextReader(8).ToString(); /* Location */
      var arg8 = reader.GetTextReader(9).ToString(); /* Remarks */
      var arg9 = reader.GetFloat(10); /* IndCharge */
      var arg10 = reader.GetFloat(11); /* RelCharge */
      var arg11 = reader.GetFloat(12); /* SurCharge */
      var arg12 = reader.GetTextReader(13).ToString(); /* Type */
      var arg13 = reader.GetTextReader(14).ToString(); /* Sanction */
      var arg14 = reader.GetInt16(15); /* MaxIndEnt */
      var arg15 = reader.GetInt16(16); /* MaxRelEnt */
      var arg16 = reader.GetInt16(17); /* MaxEnt */
      var arg17 = reader.GetBoolean(18); /* RestrictBest */
      var arg18 = reader.GetFloat(19); /* NonConform */
      var arg19 = reader.GetBoolean(20); /* EnterAtQTime */
      var arg20 = reader.GetFloat(21); /* FacilityFee */
      var arg21 = reader.GetFloat(22); /* TeamFee */
      var arg22 = reader.GetTextReader(23).ToString(); /* Instructions */
      var arg23 = reader.GetInt16(24); /* MinAge */
      var arg24 = reader.GetBoolean(25); /* EnforceQualifying */
      var arg25 = reader.GetInt16(26); /* Altitude */
      var arg26 = reader.GetBoolean(27); /* EnforceSlowQtime */
      var arg27 = reader.GetBoolean(28); /* BanNoTimes */
      var arg28 = reader.GetInt16(29); /* Lanes */
      var arg29 = reader.GetInt16(30); /* EvenOrOdd */
      var arg30 = reader.GetBoolean(31); /* FastToSlow */
      var arg31 = reader.GetBoolean(32); /* Masters */
      var arg32 = reader.GetBoolean(33); /* ActiveFeeXMLSent */
      var arg33 = reader.GetInt16(34); /* MinAge10AndUnder */
      var arg34 = reader.GetTextReader(35).ToString(); /* SeedLanes */
      var arg35 = reader.GetDateTime(36); /* DeadLine */
      var arg36 = reader.GetInt64(37); /* ActiveMeetID */
      var arg37 = reader.GetFloat(38); /* CustIndCharge */
      var arg38 = reader.GetFloat(39); /* CustRelCharge */
      var arg39 = reader.GetFloat(40); /* CustSurCharge */
      var arg40 = reader.GetByte(41); /* CustIndAction */
      var arg41 = reader.GetByte(42); /* CustRelAction */
      var arg42 = reader.GetByte(43); /* CustSurAction */
      var arg43 = reader.GetTextReader(44).ToString(); /* Addr */
      var arg44 = reader.GetTextReader(45).ToString(); /* Addr2 */
      var arg45 = reader.GetTextReader(46).ToString(); /* City */
      var arg46 = reader.GetTextReader(47).ToString(); /* State */
      var arg47 = reader.GetTextReader(48).ToString(); /* ZIP */
      var arg48 = reader.GetTextReader(49).ToString(); /* Cntry */
      var arg49 = reader.GetBoolean(50); /* UseCustomFees */
      var arg50 = reader.GetByte(51); /* OMEEntryStyle */
      var arg51 = reader.GetDateTime(52); /* SwimmerEntryDeadLine */
      var arg52 = reader.GetDateTime(53); /* SwimmerEntryOpen */
      var arg53 = reader.GetBoolean(54); /* AllowCustomTimes */
      var arg54 = reader.GetDateTime(55); /* ExportEntriesDate */
      var arg55 = reader.GetDateTime(56); /* LastSyncDate */
      var arg56 = reader.GetDateTime(57); /* FinalizeEntriesDate */
      var arg57 = reader.GetBoolean(58); /* UseSwimmersTeam */
      var arg58 = reader.GetBoolean(59); /* HonorInviteList */
      var arg59 = reader.GetInt64(60); /* EntryTeam */
      var arg60 = reader.GetTextReader(61).ToString(); /* EMailFrom */
      var arg61 = reader.GetTextReader(62).ToString(); /* EMailText */
      var arg62 = reader.GetTextReader(63).ToString(); /* EMailSubject */
      var arg63 = reader.GetBoolean(64); /* OnlyPreEntered */
      var arg64 = reader.GetTextReader(65).ToString(); /* License */
      var arg65 = reader.GetBoolean(66); /* CollectFeesOnline */
      var arg66 = reader.GetDateTime(67); /* OMEBillDate */
      var arg67 = reader.GetDateTime(68); /* InviteEmailDate */
      var arg68 = reader.GetTextReader(69).ToString(); /* EntryEMailText */
      var arg69 = reader.GetTextReader(70).ToString(); /* EntryEMailSubject */
      var arg70 = reader.GetTextReader(71).ToString(); /* EntryEMailFrom */
      var arg71 = reader.GetBoolean(72); /* OMEValidated */
      var arg72 = reader.GetBoolean(73); /* OMECustomTeam */
      var arg73 = reader.GetInt64(74); /* OMEFilterTeam */
      var arg74 = reader.GetBoolean(75); /* OMENeedsSync */
      var arg75 = reader.GetBoolean(76); /* OMENeedSync */
      var arg76 = reader.GetTextReader(77).ToString(); /* MeetSharingStatus */
      var arg77 = reader.GetInt16(78); /* FileExportType */
      var arg78 = reader.GetDateTime(79); /* MeetRegistrationOpens */
      var arg79 = reader.GetDateTime(80); /* MeetRegistrationCloses */
      var arg80 = reader.GetInt64(81); /* MeetSharingMeetID */
      var arg81 = reader.GetTextReader(82).ToString(); /* MeetSharingPayStatus */
      var arg82 = reader.GetDateTime(83); /* MeetSharingResultDate */
      var arg83 = reader.GetByte(84); /* EV3Version */
      var obj = new TmMeet(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83);
      collection[obj.Meet] = obj;
    }
  }
  return collection;
}
  // Properties
  public long Meet{ get; }
  public string MName{ get; }
  public DateTime Start{ get; }
  public DateTime End{ get; }
  public DateTime AgeUp{ get; }
  public DateTime Since{ get; }
  public string Course{ get; }
  public string Location{ get; }
  public string Remarks{ get; }
  public float IndCharge{ get; }
  public float RelCharge{ get; }
  public float SurCharge{ get; }
  public string Type{ get; }
  public string Sanction{ get; }
  public short MaxIndEnt{ get; }
  public short MaxRelEnt{ get; }
  public short MaxEnt{ get; }
  public bool RestrictBest{ get; }
  public double NonConform{ get; }
  public bool EnterAtQTime{ get; }
  public float FacilityFee{ get; }
  public float TeamFee{ get; }
  public string Instructions{ get; }
  public short MinAge{ get; }
  public bool EnforceQualifying{ get; }
  public short Altitude{ get; }
  public bool EnforceSlowQtime{ get; }
  public bool BanNoTimes{ get; }
  public short Lanes{ get; }
  public short EvenOrOdd{ get; }
  public bool FastToSlow{ get; }
  public bool Masters{ get; }
  public bool ActiveFeeXMLSent{ get; }
  public short MinAge10AndUnder{ get; }
  public string SeedLanes{ get; }
  public DateTime DeadLine{ get; }
  public long ActiveMeetID{ get; }
  public float CustIndCharge{ get; }
  public float CustRelCharge{ get; }
  public float CustSurCharge{ get; }
  public byte CustIndAction{ get; }
  public byte CustRelAction{ get; }
  public byte CustSurAction{ get; }
  public string Addr{ get; }
  public string Addr2{ get; }
  public string City{ get; }
  public string State{ get; }
  public string Zip{ get; }
  public string Cntry{ get; }
  public bool UseCustomFees{ get; }
  public byte OMEEntryStyle{ get; }
  public DateTime SwimmerEntryDeadLine{ get; }
  public DateTime SwimmerEntryOpen{ get; }
  public bool AllowCustomTimes{ get; }
  public DateTime ExportEntriesDate{ get; }
  public DateTime LastSyncDate{ get; }
  public DateTime FinalizeEntriesDate{ get; }
  public bool UseSwimmersTeam{ get; }
  public bool HonorInviteList{ get; }
  public long EntryTeam{ get; }
  public string EMailFrom{ get; }
  public string EMailText{ get; }
  public string EMailSubject{ get; }
  public bool OnlyPreEntered{ get; }
  public string License{ get; }
  public bool CollectFeesOnline{ get; }
  public DateTime OMEBillDate{ get; }
  public DateTime InviteEmailDate{ get; }
  public string EntryEMailText{ get; }
  public string EntryEMailSubject{ get; }
  public string EntryEMailFrom{ get; }
  public bool OMEValidated{ get; }
  public bool OMECustomTeam{ get; }
  public long OMEFilterTeam{ get; }
  public bool OMENeedsSync{ get; }
  public bool OMENeedSync{ get; }
  public string MeetSharingStatus{ get; }
  public short FileExportType{ get; }
  public DateTime MeetRegistrationOpens{ get; }
  public DateTime MeetRegistrationCloses{ get; }
  public long MeetSharingMeetID{ get; }
  public string MeetSharingPayStatus{ get; }
  public DateTime MeetSharingResultDate{ get; }
  public byte EV3Version{ get; }
  // Constructor
  TmMeet(long meet, string mName, DateTime start, DateTime end, DateTime ageUp, DateTime since, string course, string location, string remarks, float indCharge, float relCharge, float surCharge, string type, string sanction, short maxIndEnt, short maxRelEnt, short maxEnt, bool restrictBest, double nonConform, bool enterAtQTime, float facilityFee, float teamFee, string instructions, short minAge, bool enforceQualifying, short altitude, bool enforceSlowQtime, bool banNoTimes, short lanes, short evenOrOdd, bool fastToSlow, bool masters, bool activeFeeXMLSent, short minAge10AndUnder, string seedLanes, DateTime deadLine, long activeMeetID, float custIndCharge, float custRelCharge, float custSurCharge, byte custIndAction, byte custRelAction, byte custSurAction, string addr, string addr2, string city, string state, string zip, string cntry, bool useCustomFees, byte oMEEntryStyle, DateTime swimmerEntryDeadLine, DateTime swimmerEntryOpen, bool allowCustomTimes, DateTime exportEntriesDate, DateTime lastSyncDate, DateTime finalizeEntriesDate, bool useSwimmersTeam, bool honorInviteList, long entryTeam, string eMailFrom, string eMailText, string eMailSubject, bool onlyPreEntered, string license, bool collectFeesOnline, DateTime oMEBillDate, DateTime inviteEmailDate, string entryEMailText, string entryEMailSubject, string entryEMailFrom, bool oMEValidated, bool oMECustomTeam, long oMEFilterTeam, bool oMENeedsSync, bool oMENeedSync, string meetSharingStatus, short fileExportType, DateTime meetRegistrationOpens, DateTime meetRegistrationCloses, long meetSharingMeetID, string meetSharingPayStatus, DateTime meetSharingResultDate, byte eV3Version )
  {
    Meet = meet;
    MName = mName;
    Start = start;
    End = end;
    AgeUp = ageUp;
    Since = since;
    Course = course;
    Location = location;
    Remarks = remarks;
    IndCharge = indCharge;
    RelCharge = relCharge;
    SurCharge = surCharge;
    Type = type;
    Sanction = sanction;
    MaxIndEnt = maxIndEnt;
    MaxRelEnt = maxRelEnt;
    MaxEnt = maxEnt;
    RestrictBest = restrictBest;
    NonConform = nonConform;
    EnterAtQTime = enterAtQTime;
    FacilityFee = facilityFee;
    TeamFee = teamFee;
    Instructions = instructions;
    MinAge = minAge;
    EnforceQualifying = enforceQualifying;
    Altitude = altitude;
    EnforceSlowQtime = enforceSlowQtime;
    BanNoTimes = banNoTimes;
    Lanes = lanes;
    EvenOrOdd = evenOrOdd;
    FastToSlow = fastToSlow;
    Masters = masters;
    ActiveFeeXMLSent = activeFeeXMLSent;
    MinAge10AndUnder = minAge10AndUnder;
    SeedLanes = seedLanes;
    DeadLine = deadLine;
    ActiveMeetID = activeMeetID;
    CustIndCharge = custIndCharge;
    CustRelCharge = custRelCharge;
    CustSurCharge = custSurCharge;
    CustIndAction = custIndAction;
    CustRelAction = custRelAction;
    CustSurAction = custSurAction;
    Addr = addr;
    Addr2 = addr2;
    City = city;
    State = state;
    Zip = zip;
    Cntry = cntry;
    UseCustomFees = useCustomFees;
    OMEEntryStyle = oMEEntryStyle;
    SwimmerEntryDeadLine = swimmerEntryDeadLine;
    SwimmerEntryOpen = swimmerEntryOpen;
    AllowCustomTimes = allowCustomTimes;
    ExportEntriesDate = exportEntriesDate;
    LastSyncDate = lastSyncDate;
    FinalizeEntriesDate = finalizeEntriesDate;
    UseSwimmersTeam = useSwimmersTeam;
    HonorInviteList = honorInviteList;
    EntryTeam = entryTeam;
    EMailFrom = eMailFrom;
    EMailText = eMailText;
    EMailSubject = eMailSubject;
    OnlyPreEntered = onlyPreEntered;
    License = license;
    CollectFeesOnline = collectFeesOnline;
    OMEBillDate = oMEBillDate;
    InviteEmailDate = inviteEmailDate;
    EntryEMailText = entryEMailText;
    EntryEMailSubject = entryEMailSubject;
    EntryEMailFrom = entryEMailFrom;
    OMEValidated = oMEValidated;
    OMECustomTeam = oMECustomTeam;
    OMEFilterTeam = oMEFilterTeam;
    OMENeedsSync = oMENeedsSync;
    OMENeedSync = oMENeedSync;
    MeetSharingStatus = meetSharingStatus;
    FileExportType = fileExportType;
    MeetRegistrationOpens = meetRegistrationOpens;
    MeetRegistrationCloses = meetRegistrationCloses;
    MeetSharingMeetID = meetSharingMeetID;
    MeetSharingPayStatus = meetSharingPayStatus;
    MeetSharingResultDate = meetSharingResultDate;
    EV3Version = eV3Version;
  }
}
