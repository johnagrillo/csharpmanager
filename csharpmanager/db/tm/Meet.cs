using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [MEET]
/// // (
/// // [Meet] Long Integer,
/// // [MName] Text (90),
/// // [Start] DateTime,
/// // [End] DateTime,
/// // [AgeUp] DateTime,
/// // [Since] DateTime,
/// // [Course] Text (4),
/// // [Location] Text (90),
/// // [Remarks] Text (100),
/// // [IndCharge] Single,
/// // [RelCharge] Single,
/// // [SurCharge] Single,
/// // [Type] Text (6),
/// // [Sanction] Text (30),
/// // [MaxIndEnt] Integer,
/// // [MaxRelEnt] Integer,
/// // [MaxEnt] Integer,
/// // [RestrictBest] Boolean NOT NULL,
/// // [NonConform] Double,
/// // [EnterAtQTime] Boolean NOT NULL,
/// // [FacilityFee] Single,
/// // [TeamFee] Single,
/// // [Instructions] Text (500),
/// // [MinAge] Integer,
/// // [EnforceQualifying] Boolean NOT NULL,
/// // [Altitude] Integer,
/// // [EnforceSlowQtime] Boolean NOT NULL,
/// // [BanNoTimes] Boolean NOT NULL,
/// // [Lanes] Integer,
/// // [EvenOrOdd] Integer,
/// // [FastToSlow] Boolean NOT NULL,
/// // [Masters] Boolean NOT NULL,
/// // [ActiveFeeXMLSent] Boolean NOT NULL,
/// // [MinAge10AndUnder] Integer,
/// // [SeedLanes] Text (32),
/// // [DeadLine] DateTime,
/// // [ActiveMeetID] Long Integer,
/// // [CustIndCharge] Single,
/// // [CustRelCharge] Single,
/// // [CustSurCharge] Single,
/// // [CustIndAction] Byte,
/// // [CustRelAction] Byte,
/// // [CustSurAction] Byte,
/// // [Addr] Text (60),
/// // [Addr2] Text (60),
/// // [City] Text (60),
/// // [State] Text (6),
/// // [ZIP] Text (20),
/// // [Cntry] Text (40),
/// // [UseCustomFees] Boolean NOT NULL,
/// // [OMEEntryStyle] Byte,
/// // [SwimmerEntryDeadLine] DateTime,
/// // [SwimmerEntryOpen] DateTime,
/// // [AllowCustomTimes] Boolean NOT NULL,
/// // [ExportEntriesDate] DateTime,
/// // [LastSyncDate] DateTime,
/// // [FinalizeEntriesDate] DateTime,
/// // [UseSwimmersTeam] Boolean NOT NULL,
/// // [HonorInviteList] Boolean NOT NULL,
/// // [EntryTeam] Long Integer,
/// // [EMailFrom] Text (100),
/// // [EMailText] Text (508),
/// // [EMailSubject] Text (200),
/// // [OnlyPreEntered] Boolean NOT NULL,
/// // [License] Text (240),
/// // [CollectFeesOnline] Boolean NOT NULL,
/// // [OMEBillDate] DateTime,
/// // [InviteEmailDate] DateTime,
/// // [EntryEMailText] Text (508),
/// // [EntryEMailSubject] Text (200),
/// // [EntryEMailFrom] Text (100),
/// // [OMEValidated] Boolean NOT NULL,
/// // [OMECustomTeam] Boolean NOT NULL,
/// // [OMEFilterTeam] Long Integer,
/// // [OMENeedsSync] Boolean NOT NULL,
/// // [OMENeedSync] Boolean NOT NULL,
/// // [MeetSharingStatus] Text (40),
/// // [FileExportType] Integer,
/// // [MeetRegistrationOpens] DateTime,
/// // [MeetRegistrationCloses] DateTime,
/// // [MeetSharingMeetID] Long Integer,
/// // [MeetSharingPayStatus] Text (40),
/// // [MeetSharingResultDate] DateTime,
/// // [EV3Version] Byte
/// // );

public class Meet(long meet, string mName, DateTime? start, DateTime? end, DateTime? ageUp, DateTime? since, string course, string location, string remarks, float? indCharge, float? relCharge, float? surCharge, string type, string sanction, short? maxIndEnt, short? maxRelEnt, short? maxEnt, bool restrictBest, double? nonConform, bool enterAtQTime, float? facilityFee, float? teamFee, string instructions, short? minAge, bool enforceQualifying, short? altitude, bool enforceSlowQtime, bool banNoTimes, short? lanes, short? evenOrOdd, bool fastToSlow, bool masters, bool activeFeeXMLSent, short? minAge10AndUnder, string seedLanes, DateTime? deadLine, long? activeMeetID, float? custIndCharge, float? custRelCharge, float? custSurCharge, byte? custIndAction, byte? custRelAction, byte? custSurAction, string addr, string addr2, string city, string state, string zip, string cntry, bool useCustomFees, byte? oMEEntryStyle, DateTime? swimmerEntryDeadLine, DateTime? swimmerEntryOpen, bool allowCustomTimes, DateTime? exportEntriesDate, DateTime? lastSyncDate, DateTime? finalizeEntriesDate, bool useSwimmersTeam, bool honorInviteList, long? entryTeam, string eMailFrom, string eMailText, string eMailSubject, bool onlyPreEntered, string license, bool collectFeesOnline, DateTime? oMEBillDate, DateTime? inviteEmailDate, string entryEMailText, string entryEMailSubject, string entryEMailFrom, bool oMEValidated, bool oMECustomTeam, long? oMEFilterTeam, bool oMENeedsSync, bool oMENeedSync, string meetSharingStatus, short? fileExportType, DateTime? meetRegistrationOpens, DateTime? meetRegistrationCloses, long? meetSharingMeetID, string meetSharingPayStatus, DateTime? meetSharingResultDate, byte? eV3Version )
{
static public List<Meet> Get(OdbcConnection connection)
{
  var collection = new List<Meet>();
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
  var arg0 = reader.GetInt32(0); /* Meet nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* MName nullable false*/
  var arg2 = reader.IsDBNull(2) ? (DateTime?)null :reader.GetDateTime(2); /* Start nullable true*/
  var arg3 = reader.IsDBNull(3) ? (DateTime?)null :reader.GetDateTime(3); /* End nullable true*/
  var arg4 = reader.IsDBNull(4) ? (DateTime?)null :reader.GetDateTime(4); /* AgeUp nullable true*/
  var arg5 = reader.IsDBNull(5) ? (DateTime?)null :reader.GetDateTime(5); /* Since nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* Course nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Location nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Remarks nullable false*/
  var arg9 = reader.IsDBNull(9) ? (float?)null :reader.GetFloat(9); /* IndCharge nullable true*/
  var arg10 = reader.IsDBNull(10) ? (float?)null :reader.GetFloat(10); /* RelCharge nullable true*/
  var arg11 = reader.IsDBNull(11) ? (float?)null :reader.GetFloat(11); /* SurCharge nullable true*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Type nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Sanction nullable false*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* MaxIndEnt nullable true*/
  var arg15 = reader.IsDBNull(15) ? (short?)null :reader.GetInt16(15); /* MaxRelEnt nullable true*/
  var arg16 = reader.IsDBNull(16) ? (short?)null :reader.GetInt16(16); /* MaxEnt nullable true*/
  var arg17 = reader.GetBoolean(17); /* RestrictBest nullable false*/
  var arg18 = reader.IsDBNull(18) ? (double?)null :reader.GetFloat(18); /* NonConform nullable true*/
  var arg19 = reader.GetBoolean(19); /* EnterAtQTime nullable false*/
  var arg20 = reader.IsDBNull(20) ? (float?)null :reader.GetFloat(20); /* FacilityFee nullable true*/
  var arg21 = reader.IsDBNull(21) ? (float?)null :reader.GetFloat(21); /* TeamFee nullable true*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* Instructions nullable false*/
  var arg23 = reader.IsDBNull(23) ? (short?)null :reader.GetInt16(23); /* MinAge nullable true*/
  var arg24 = reader.GetBoolean(24); /* EnforceQualifying nullable false*/
  var arg25 = reader.IsDBNull(25) ? (short?)null :reader.GetInt16(25); /* Altitude nullable true*/
  var arg26 = reader.GetBoolean(26); /* EnforceSlowQtime nullable false*/
  var arg27 = reader.GetBoolean(27); /* BanNoTimes nullable false*/
  var arg28 = reader.IsDBNull(28) ? (short?)null :reader.GetInt16(28); /* Lanes nullable true*/
  var arg29 = reader.IsDBNull(29) ? (short?)null :reader.GetInt16(29); /* EvenOrOdd nullable true*/
  var arg30 = reader.GetBoolean(30); /* FastToSlow nullable false*/
  var arg31 = reader.GetBoolean(31); /* Masters nullable false*/
  var arg32 = reader.GetBoolean(32); /* ActiveFeeXMLSent nullable false*/
  var arg33 = reader.IsDBNull(33) ? (short?)null :reader.GetInt16(33); /* MinAge10AndUnder nullable true*/
  var arg34 = reader.GetTextReader(34).ReadLine(); /* SeedLanes nullable false*/
  var arg35 = reader.IsDBNull(35) ? (DateTime?)null :reader.GetDateTime(35); /* DeadLine nullable true*/
  var arg36 = reader.IsDBNull(36) ? (long?)null :reader.GetInt32(36); /* ActiveMeetID nullable true*/
  var arg37 = reader.IsDBNull(37) ? (float?)null :reader.GetFloat(37); /* CustIndCharge nullable true*/
  var arg38 = reader.IsDBNull(38) ? (float?)null :reader.GetFloat(38); /* CustRelCharge nullable true*/
  var arg39 = reader.IsDBNull(39) ? (float?)null :reader.GetFloat(39); /* CustSurCharge nullable true*/
  var arg40 = reader.IsDBNull(40) ? (byte?)null :reader.GetByte(40); /* CustIndAction nullable true*/
  var arg41 = reader.IsDBNull(41) ? (byte?)null :reader.GetByte(41); /* CustRelAction nullable true*/
  var arg42 = reader.IsDBNull(42) ? (byte?)null :reader.GetByte(42); /* CustSurAction nullable true*/
  var arg43 = reader.GetTextReader(43).ReadLine(); /* Addr nullable false*/
  var arg44 = reader.GetTextReader(44).ReadLine(); /* Addr2 nullable false*/
  var arg45 = reader.GetTextReader(45).ReadLine(); /* City nullable false*/
  var arg46 = reader.GetTextReader(46).ReadLine(); /* State nullable false*/
  var arg47 = reader.GetTextReader(47).ReadLine(); /* ZIP nullable false*/
  var arg48 = reader.GetTextReader(48).ReadLine(); /* Cntry nullable false*/
  var arg49 = reader.GetBoolean(49); /* UseCustomFees nullable false*/
  var arg50 = reader.IsDBNull(50) ? (byte?)null :reader.GetByte(50); /* OMEEntryStyle nullable true*/
  var arg51 = reader.IsDBNull(51) ? (DateTime?)null :reader.GetDateTime(51); /* SwimmerEntryDeadLine nullable true*/
  var arg52 = reader.IsDBNull(52) ? (DateTime?)null :reader.GetDateTime(52); /* SwimmerEntryOpen nullable true*/
  var arg53 = reader.GetBoolean(53); /* AllowCustomTimes nullable false*/
  var arg54 = reader.IsDBNull(54) ? (DateTime?)null :reader.GetDateTime(54); /* ExportEntriesDate nullable true*/
  var arg55 = reader.IsDBNull(55) ? (DateTime?)null :reader.GetDateTime(55); /* LastSyncDate nullable true*/
  var arg56 = reader.IsDBNull(56) ? (DateTime?)null :reader.GetDateTime(56); /* FinalizeEntriesDate nullable true*/
  var arg57 = reader.GetBoolean(57); /* UseSwimmersTeam nullable false*/
  var arg58 = reader.GetBoolean(58); /* HonorInviteList nullable false*/
  var arg59 = reader.IsDBNull(59) ? (long?)null :reader.GetInt32(59); /* EntryTeam nullable true*/
  var arg60 = reader.GetTextReader(60).ReadLine(); /* EMailFrom nullable false*/
  var arg61 = reader.GetTextReader(61).ReadLine(); /* EMailText nullable false*/
  var arg62 = reader.GetTextReader(62).ReadLine(); /* EMailSubject nullable false*/
  var arg63 = reader.GetBoolean(63); /* OnlyPreEntered nullable false*/
  var arg64 = reader.GetTextReader(64).ReadLine(); /* License nullable false*/
  var arg65 = reader.GetBoolean(65); /* CollectFeesOnline nullable false*/
  var arg66 = reader.IsDBNull(66) ? (DateTime?)null :reader.GetDateTime(66); /* OMEBillDate nullable true*/
  var arg67 = reader.IsDBNull(67) ? (DateTime?)null :reader.GetDateTime(67); /* InviteEmailDate nullable true*/
  var arg68 = reader.GetTextReader(68).ReadLine(); /* EntryEMailText nullable false*/
  var arg69 = reader.GetTextReader(69).ReadLine(); /* EntryEMailSubject nullable false*/
  var arg70 = reader.GetTextReader(70).ReadLine(); /* EntryEMailFrom nullable false*/
  var arg71 = reader.GetBoolean(71); /* OMEValidated nullable false*/
  var arg72 = reader.GetBoolean(72); /* OMECustomTeam nullable false*/
  var arg73 = reader.IsDBNull(73) ? (long?)null :reader.GetInt32(73); /* OMEFilterTeam nullable true*/
  var arg74 = reader.GetBoolean(74); /* OMENeedsSync nullable false*/
  var arg75 = reader.GetBoolean(75); /* OMENeedSync nullable false*/
  var arg76 = reader.GetTextReader(76).ReadLine(); /* MeetSharingStatus nullable false*/
  var arg77 = reader.IsDBNull(77) ? (short?)null :reader.GetInt16(77); /* FileExportType nullable true*/
  var arg78 = reader.IsDBNull(78) ? (DateTime?)null :reader.GetDateTime(78); /* MeetRegistrationOpens nullable true*/
  var arg79 = reader.IsDBNull(79) ? (DateTime?)null :reader.GetDateTime(79); /* MeetRegistrationCloses nullable true*/
  var arg80 = reader.IsDBNull(80) ? (long?)null :reader.GetInt32(80); /* MeetSharingMeetID nullable true*/
  var arg81 = reader.GetTextReader(81).ReadLine(); /* MeetSharingPayStatus nullable false*/
  var arg82 = reader.IsDBNull(82) ? (DateTime?)null :reader.GetDateTime(82); /* MeetSharingResultDate nullable true*/
  var arg83 = reader.IsDBNull(83) ? (byte?)null :reader.GetByte(83); /* EV3Version nullable true*/
      collection.Add( new Meet(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83));
    }
  }
  return collection;
}
  // Properties
  public long Meet_{ get; } = meet;
  public string MName{ get; } = mName;
  public DateTime? Start{ get; } = start;
  public DateTime? End{ get; } = end;
  public DateTime? AgeUp{ get; } = ageUp;
  public DateTime? Since{ get; } = since;
  public string Course{ get; } = course;
  public string Location{ get; } = location;
  public string Remarks{ get; } = remarks;
  public float? IndCharge{ get; } = indCharge;
  public float? RelCharge{ get; } = relCharge;
  public float? SurCharge{ get; } = surCharge;
  public string Type{ get; } = type;
  public string Sanction{ get; } = sanction;
  public short? MaxIndEnt{ get; } = maxIndEnt;
  public short? MaxRelEnt{ get; } = maxRelEnt;
  public short? MaxEnt{ get; } = maxEnt;
  public bool RestrictBest{ get; } = restrictBest;
  public double? NonConform{ get; } = nonConform;
  public bool EnterAtQTime{ get; } = enterAtQTime;
  public float? FacilityFee{ get; } = facilityFee;
  public float? TeamFee{ get; } = teamFee;
  public string Instructions{ get; } = instructions;
  public short? MinAge{ get; } = minAge;
  public bool EnforceQualifying{ get; } = enforceQualifying;
  public short? Altitude{ get; } = altitude;
  public bool EnforceSlowQtime{ get; } = enforceSlowQtime;
  public bool BanNoTimes{ get; } = banNoTimes;
  public short? Lanes{ get; } = lanes;
  public short? EvenOrOdd{ get; } = evenOrOdd;
  public bool FastToSlow{ get; } = fastToSlow;
  public bool Masters{ get; } = masters;
  public bool ActiveFeeXMLSent{ get; } = activeFeeXMLSent;
  public short? MinAge10AndUnder{ get; } = minAge10AndUnder;
  public string SeedLanes{ get; } = seedLanes;
  public DateTime? DeadLine{ get; } = deadLine;
  public long? ActiveMeetID{ get; } = activeMeetID;
  public float? CustIndCharge{ get; } = custIndCharge;
  public float? CustRelCharge{ get; } = custRelCharge;
  public float? CustSurCharge{ get; } = custSurCharge;
  public byte? CustIndAction{ get; } = custIndAction;
  public byte? CustRelAction{ get; } = custRelAction;
  public byte? CustSurAction{ get; } = custSurAction;
  public string Addr{ get; } = addr;
  public string Addr2{ get; } = addr2;
  public string City{ get; } = city;
  public string State{ get; } = state;
  public string Zip{ get; } = zip;
  public string Cntry{ get; } = cntry;
  public bool UseCustomFees{ get; } = useCustomFees;
  public byte? OMEEntryStyle{ get; } = oMEEntryStyle;
  public DateTime? SwimmerEntryDeadLine{ get; } = swimmerEntryDeadLine;
  public DateTime? SwimmerEntryOpen{ get; } = swimmerEntryOpen;
  public bool AllowCustomTimes{ get; } = allowCustomTimes;
  public DateTime? ExportEntriesDate{ get; } = exportEntriesDate;
  public DateTime? LastSyncDate{ get; } = lastSyncDate;
  public DateTime? FinalizeEntriesDate{ get; } = finalizeEntriesDate;
  public bool UseSwimmersTeam{ get; } = useSwimmersTeam;
  public bool HonorInviteList{ get; } = honorInviteList;
  public long? EntryTeam{ get; } = entryTeam;
  public string EMailFrom{ get; } = eMailFrom;
  public string EMailText{ get; } = eMailText;
  public string EMailSubject{ get; } = eMailSubject;
  public bool OnlyPreEntered{ get; } = onlyPreEntered;
  public string License{ get; } = license;
  public bool CollectFeesOnline{ get; } = collectFeesOnline;
  public DateTime? OMEBillDate{ get; } = oMEBillDate;
  public DateTime? InviteEmailDate{ get; } = inviteEmailDate;
  public string EntryEMailText{ get; } = entryEMailText;
  public string EntryEMailSubject{ get; } = entryEMailSubject;
  public string EntryEMailFrom{ get; } = entryEMailFrom;
  public bool OMEValidated{ get; } = oMEValidated;
  public bool OMECustomTeam{ get; } = oMECustomTeam;
  public long? OMEFilterTeam{ get; } = oMEFilterTeam;
  public bool OMENeedsSync{ get; } = oMENeedsSync;
  public bool OMENeedSync{ get; } = oMENeedSync;
  public string MeetSharingStatus{ get; } = meetSharingStatus;
  public short? FileExportType{ get; } = fileExportType;
  public DateTime? MeetRegistrationOpens{ get; } = meetRegistrationOpens;
  public DateTime? MeetRegistrationCloses{ get; } = meetRegistrationCloses;
  public long? MeetSharingMeetID{ get; } = meetSharingMeetID;
  public string MeetSharingPayStatus{ get; } = meetSharingPayStatus;
  public DateTime? MeetSharingResultDate{ get; } = meetSharingResultDate;
  public byte? EV3Version{ get; } = eV3Version;
}
}
}
