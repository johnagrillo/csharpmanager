using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [OPTIONS]
/// // (
/// // [State] Text (6),
/// // [Citizen] Text (6),
/// // [LSC] Text (6),
/// // [Standard] Text (16),
/// // [Record] Text (16),
/// // [Course] Text (2),
/// // [TeamType] Text (6),
/// // [RegType] Text (8),
/// // [Line1] Text (80),
/// // [Line2] Text (80),
/// // [RptUCase] Boolean NOT NULL,
/// // [SysAgeUp] DateTime,
/// // [MtAgeUp] Integer,
/// // [MtDate] DateTime,
/// // [FavSex] Byte,
/// // [NoAge] Byte,
/// // [MinAge] Byte,
/// // [FavTeam] Text (10),
/// // [FavLSC] Text (6),
/// // [CvtFactor] Double,
/// // [CvtType] Byte,
/// // [Cvt500] Double,
/// // [Cvt1650] Double,
/// // [FreeTurn] Double,
/// // [BackTurn] Double,
/// // [BreastTurn] Double,
/// // [FlyTurn] Double,
/// // [IMTurn] Double,
/// // [Straight] Double,
/// // [Y2L] Boolean NOT NULL,
/// // [Language] Text (16),
/// // [LabelOption] Byte,
/// // [ShowMI] Boolean NOT NULL,
/// // [ShowAges] Boolean NOT NULL,
/// // [ShowBirth] Boolean NOT NULL,
/// // [ShowClass] Boolean NOT NULL,
/// // [ShowFirstFirst] Boolean NOT NULL,
/// // [Favorite] Text (16),
/// // [ToScreen] Boolean NOT NULL,
/// // [NumCopies] Byte,
/// // [PaperSize] Byte,
/// // [UseLeadOff] Boolean NOT NULL,
/// // [UseStrokeRates] Boolean NOT NULL,
/// // [CusPrompt1] Text (40),
/// // [CusPrompt2] Text (40),
/// // [CusPrompt3] Text (40),
/// // [RegDate] DateTime,
/// // [ShowOnlyFast] Boolean NOT NULL,
/// // [LabelType] Byte,
/// // [ImportDir] Text (240),
/// // [ExportDir] Text (240),
/// // [BackupDir] Text (240),
/// // [ReportDir] Text (240),
/// // [LSCFee] Single,
/// // [RegAddr] Text (100),
/// // [RegCity] Text (40),
/// // [RegState] Text (6),
/// // [RegZIP] Text (20),
/// // [RegMailTo] Text (80),
/// // [RegPayTo] Text (80),
/// // [PalmImportDir] Text (240),
/// // [LSCSeasonalFee] Single,
/// // [BackupCheck] Byte,
/// // [UpdateCheck] Byte,
/// // [LastBackup] DateTime,
/// // [LastSplitExtract] DateTime,
/// // [AgeupToCurrent] Boolean NOT NULL,
/// // [DbVersion] Text (10),
/// // [DefaultDir] Text (240),
/// // [RelayOrder] Text (14),
/// // [LastDir] Text (240),
/// // [SplitPref] Integer,
/// // [rptLastFirst] Boolean NOT NULL,
/// // [rptShowMI] Boolean NOT NULL,
/// // [rptFILast] Boolean NOT NULL,
/// // [rptFirstLI] Boolean NOT NULL,
/// // [rptShowPref] Boolean NOT NULL,
/// // [OfficialLine1] Text (216),
/// // [OfficialLine2] Text (216),
/// // [OfficialLine3] Text (216),
/// // [UseProvince] Boolean NOT NULL,
/// // [DefCity] Text (60),
/// // [CusPrompt4] Text (40),
/// // [CusPrompt5] Text (40),
/// // [CusPrompt6] Text (40),
/// // [CusPrompt7] Text (40),
/// // [CusPrompt8] Text (40),
/// // [OnlineRegistrationType] Text (2),
/// // [DefZip] Text (20),
/// // [DontShowMeetSharing] Boolean NOT NULL
/// // );

public class Options(string state, string citizen, string lsc, string standard, string record, string course, string teamType, string regType, string line1, string line2, bool rptUCase, DateTime? sysAgeUp, short? mtAgeUp, DateTime? mtDate, byte? favSex, byte? noAge, byte? minAge, string favTeam, string favLSC, double? cvtFactor, byte? cvtType, double? cvt500, double? cvt1650, double? freeTurn, double? backTurn, double? breastTurn, double? flyTurn, double? iMTurn, double? straight, bool y2l, string language, byte? labelOption, bool showMI, bool showAges, bool showBirth, bool showClass, bool showFirstFirst, string favorite, bool toScreen, byte? numCopies, byte? paperSize, bool useLeadOff, bool useStrokeRates, string cusPrompt1, string cusPrompt2, string cusPrompt3, DateTime? regDate, bool showOnlyFast, byte? labelType, string importDir, string exportDir, string backupDir, string reportDir, float? lSCFee, string regAddr, string regCity, string regState, string regZIP, string regMailTo, string regPayTo, string palmImportDir, float? lSCSeasonalFee, byte? backupCheck, byte? updateCheck, DateTime? lastBackup, DateTime? lastSplitExtract, bool ageupToCurrent, string dbVersion, string defaultDir, string relayOrder, string lastDir, short? splitPref, bool rptLastFirst, bool rptShowMI, bool rptFILast, bool rptFirstLI, bool rptShowPref, string officialLine1, string officialLine2, string officialLine3, bool useProvince, string defCity, string cusPrompt4, string cusPrompt5, string cusPrompt6, string cusPrompt7, string cusPrompt8, string onlineRegistrationType, string defZip, bool dontShowMeetSharing )
{
static public List<Options> Get(OdbcConnection connection)
{
  var collection = new List<Options>();
  string query = "select * from OPTIONS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* State nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Citizen nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* LSC nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Standard nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Record nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Course nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* TeamType nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* RegType nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Line1 nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Line2 nullable false*/
  var arg10 = reader.GetBoolean(10); /* RptUCase nullable false*/
  var arg11 = reader.IsDBNull(11) ? (DateTime?)null :reader.GetDateTime(11); /* SysAgeUp nullable true*/
  var arg12 = reader.IsDBNull(12) ? (short?)null :reader.GetInt16(12); /* MtAgeUp nullable true*/
  var arg13 = reader.IsDBNull(13) ? (DateTime?)null :reader.GetDateTime(13); /* MtDate nullable true*/
  var arg14 = reader.IsDBNull(14) ? (byte?)null :reader.GetByte(14); /* FavSex nullable true*/
  var arg15 = reader.IsDBNull(15) ? (byte?)null :reader.GetByte(15); /* NoAge nullable true*/
  var arg16 = reader.IsDBNull(16) ? (byte?)null :reader.GetByte(16); /* MinAge nullable true*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* FavTeam nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* FavLSC nullable false*/
  var arg19 = reader.IsDBNull(19) ? (double?)null :reader.GetFloat(19); /* CvtFactor nullable true*/
  var arg20 = reader.IsDBNull(20) ? (byte?)null :reader.GetByte(20); /* CvtType nullable true*/
  var arg21 = reader.IsDBNull(21) ? (double?)null :reader.GetFloat(21); /* Cvt500 nullable true*/
  var arg22 = reader.IsDBNull(22) ? (double?)null :reader.GetFloat(22); /* Cvt1650 nullable true*/
  var arg23 = reader.IsDBNull(23) ? (double?)null :reader.GetFloat(23); /* FreeTurn nullable true*/
  var arg24 = reader.IsDBNull(24) ? (double?)null :reader.GetFloat(24); /* BackTurn nullable true*/
  var arg25 = reader.IsDBNull(25) ? (double?)null :reader.GetFloat(25); /* BreastTurn nullable true*/
  var arg26 = reader.IsDBNull(26) ? (double?)null :reader.GetFloat(26); /* FlyTurn nullable true*/
  var arg27 = reader.IsDBNull(27) ? (double?)null :reader.GetFloat(27); /* IMTurn nullable true*/
  var arg28 = reader.IsDBNull(28) ? (double?)null :reader.GetFloat(28); /* Straight nullable true*/
  var arg29 = reader.GetBoolean(29); /* Y2L nullable false*/
  var arg30 = reader.GetTextReader(30).ReadLine(); /* Language nullable false*/
  var arg31 = reader.IsDBNull(31) ? (byte?)null :reader.GetByte(31); /* LabelOption nullable true*/
  var arg32 = reader.GetBoolean(32); /* ShowMI nullable false*/
  var arg33 = reader.GetBoolean(33); /* ShowAges nullable false*/
  var arg34 = reader.GetBoolean(34); /* ShowBirth nullable false*/
  var arg35 = reader.GetBoolean(35); /* ShowClass nullable false*/
  var arg36 = reader.GetBoolean(36); /* ShowFirstFirst nullable false*/
  var arg37 = reader.GetTextReader(37).ReadLine(); /* Favorite nullable false*/
  var arg38 = reader.GetBoolean(38); /* ToScreen nullable false*/
  var arg39 = reader.IsDBNull(39) ? (byte?)null :reader.GetByte(39); /* NumCopies nullable true*/
  var arg40 = reader.IsDBNull(40) ? (byte?)null :reader.GetByte(40); /* PaperSize nullable true*/
  var arg41 = reader.GetBoolean(41); /* UseLeadOff nullable false*/
  var arg42 = reader.GetBoolean(42); /* UseStrokeRates nullable false*/
  var arg43 = reader.GetTextReader(43).ReadLine(); /* CusPrompt1 nullable false*/
  var arg44 = reader.GetTextReader(44).ReadLine(); /* CusPrompt2 nullable false*/
  var arg45 = reader.GetTextReader(45).ReadLine(); /* CusPrompt3 nullable false*/
  var arg46 = reader.IsDBNull(46) ? (DateTime?)null :reader.GetDateTime(46); /* RegDate nullable true*/
  var arg47 = reader.GetBoolean(47); /* ShowOnlyFast nullable false*/
  var arg48 = reader.IsDBNull(48) ? (byte?)null :reader.GetByte(48); /* LabelType nullable true*/
  var arg49 = reader.GetTextReader(49).ReadLine(); /* ImportDir nullable false*/
  var arg50 = reader.GetTextReader(50).ReadLine(); /* ExportDir nullable false*/
  var arg51 = reader.GetTextReader(51).ReadLine(); /* BackupDir nullable false*/
  var arg52 = reader.GetTextReader(52).ReadLine(); /* ReportDir nullable false*/
  var arg53 = reader.IsDBNull(53) ? (float?)null :reader.GetFloat(53); /* LSCFee nullable true*/
  var arg54 = reader.GetTextReader(54).ReadLine(); /* RegAddr nullable false*/
  var arg55 = reader.GetTextReader(55).ReadLine(); /* RegCity nullable false*/
  var arg56 = reader.GetTextReader(56).ReadLine(); /* RegState nullable false*/
  var arg57 = reader.GetTextReader(57).ReadLine(); /* RegZIP nullable false*/
  var arg58 = reader.GetTextReader(58).ReadLine(); /* RegMailTo nullable false*/
  var arg59 = reader.GetTextReader(59).ReadLine(); /* RegPayTo nullable false*/
  var arg60 = reader.GetTextReader(60).ReadLine(); /* PalmImportDir nullable false*/
  var arg61 = reader.IsDBNull(61) ? (float?)null :reader.GetFloat(61); /* LSCSeasonalFee nullable true*/
  var arg62 = reader.IsDBNull(62) ? (byte?)null :reader.GetByte(62); /* BackupCheck nullable true*/
  var arg63 = reader.IsDBNull(63) ? (byte?)null :reader.GetByte(63); /* UpdateCheck nullable true*/
  var arg64 = reader.IsDBNull(64) ? (DateTime?)null :reader.GetDateTime(64); /* LastBackup nullable true*/
  var arg65 = reader.IsDBNull(65) ? (DateTime?)null :reader.GetDateTime(65); /* LastSplitExtract nullable true*/
  var arg66 = reader.GetBoolean(66); /* AgeupToCurrent nullable false*/
  var arg67 = reader.GetTextReader(67).ReadLine(); /* DbVersion nullable false*/
  var arg68 = reader.GetTextReader(68).ReadLine(); /* DefaultDir nullable false*/
  var arg69 = reader.GetTextReader(69).ReadLine(); /* RelayOrder nullable false*/
  var arg70 = reader.GetTextReader(70).ReadLine(); /* LastDir nullable false*/
  var arg71 = reader.IsDBNull(71) ? (short?)null :reader.GetInt16(71); /* SplitPref nullable true*/
  var arg72 = reader.GetBoolean(72); /* rptLastFirst nullable false*/
  var arg73 = reader.GetBoolean(73); /* rptShowMI nullable false*/
  var arg74 = reader.GetBoolean(74); /* rptFILast nullable false*/
  var arg75 = reader.GetBoolean(75); /* rptFirstLI nullable false*/
  var arg76 = reader.GetBoolean(76); /* rptShowPref nullable false*/
  var arg77 = reader.GetTextReader(77).ReadLine(); /* OfficialLine1 nullable false*/
  var arg78 = reader.GetTextReader(78).ReadLine(); /* OfficialLine2 nullable false*/
  var arg79 = reader.GetTextReader(79).ReadLine(); /* OfficialLine3 nullable false*/
  var arg80 = reader.GetBoolean(80); /* UseProvince nullable false*/
  var arg81 = reader.GetTextReader(81).ReadLine(); /* DefCity nullable false*/
  var arg82 = reader.GetTextReader(82).ReadLine(); /* CusPrompt4 nullable false*/
  var arg83 = reader.GetTextReader(83).ReadLine(); /* CusPrompt5 nullable false*/
  var arg84 = reader.GetTextReader(84).ReadLine(); /* CusPrompt6 nullable false*/
  var arg85 = reader.GetTextReader(85).ReadLine(); /* CusPrompt7 nullable false*/
  var arg86 = reader.GetTextReader(86).ReadLine(); /* CusPrompt8 nullable false*/
  var arg87 = reader.GetTextReader(87).ReadLine(); /* OnlineRegistrationType nullable false*/
  var arg88 = reader.GetTextReader(88).ReadLine(); /* DefZip nullable false*/
  var arg89 = reader.GetBoolean(89); /* DontShowMeetSharing nullable false*/
      collection.Add( new Options(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89));
    }
  }
  return collection;
}
  // Properties
  public string State{ get; } = state;
  public string Citizen{ get; } = citizen;
  public string Lsc{ get; } = lsc;
  public string Standard{ get; } = standard;
  public string Record{ get; } = record;
  public string Course{ get; } = course;
  public string TeamType{ get; } = teamType;
  public string RegType{ get; } = regType;
  public string Line1{ get; } = line1;
  public string Line2{ get; } = line2;
  public bool RptUCase{ get; } = rptUCase;
  public DateTime? SysAgeUp{ get; } = sysAgeUp;
  public short? MtAgeUp{ get; } = mtAgeUp;
  public DateTime? MtDate{ get; } = mtDate;
  public byte? FavSex{ get; } = favSex;
  public byte? NoAge{ get; } = noAge;
  public byte? MinAge{ get; } = minAge;
  public string FavTeam{ get; } = favTeam;
  public string FavLSC{ get; } = favLSC;
  public double? CvtFactor{ get; } = cvtFactor;
  public byte? CvtType{ get; } = cvtType;
  public double? Cvt500{ get; } = cvt500;
  public double? Cvt1650{ get; } = cvt1650;
  public double? FreeTurn{ get; } = freeTurn;
  public double? BackTurn{ get; } = backTurn;
  public double? BreastTurn{ get; } = breastTurn;
  public double? FlyTurn{ get; } = flyTurn;
  public double? IMTurn{ get; } = iMTurn;
  public double? Straight{ get; } = straight;
  public bool Y2l{ get; } = y2l;
  public string Language{ get; } = language;
  public byte? LabelOption{ get; } = labelOption;
  public bool ShowMI{ get; } = showMI;
  public bool ShowAges{ get; } = showAges;
  public bool ShowBirth{ get; } = showBirth;
  public bool ShowClass{ get; } = showClass;
  public bool ShowFirstFirst{ get; } = showFirstFirst;
  public string Favorite{ get; } = favorite;
  public bool ToScreen{ get; } = toScreen;
  public byte? NumCopies{ get; } = numCopies;
  public byte? PaperSize{ get; } = paperSize;
  public bool UseLeadOff{ get; } = useLeadOff;
  public bool UseStrokeRates{ get; } = useStrokeRates;
  public string CusPrompt1{ get; } = cusPrompt1;
  public string CusPrompt2{ get; } = cusPrompt2;
  public string CusPrompt3{ get; } = cusPrompt3;
  public DateTime? RegDate{ get; } = regDate;
  public bool ShowOnlyFast{ get; } = showOnlyFast;
  public byte? LabelType{ get; } = labelType;
  public string ImportDir{ get; } = importDir;
  public string ExportDir{ get; } = exportDir;
  public string BackupDir{ get; } = backupDir;
  public string ReportDir{ get; } = reportDir;
  public float? LSCFee{ get; } = lSCFee;
  public string RegAddr{ get; } = regAddr;
  public string RegCity{ get; } = regCity;
  public string RegState{ get; } = regState;
  public string RegZIP{ get; } = regZIP;
  public string RegMailTo{ get; } = regMailTo;
  public string RegPayTo{ get; } = regPayTo;
  public string PalmImportDir{ get; } = palmImportDir;
  public float? LSCSeasonalFee{ get; } = lSCSeasonalFee;
  public byte? BackupCheck{ get; } = backupCheck;
  public byte? UpdateCheck{ get; } = updateCheck;
  public DateTime? LastBackup{ get; } = lastBackup;
  public DateTime? LastSplitExtract{ get; } = lastSplitExtract;
  public bool AgeupToCurrent{ get; } = ageupToCurrent;
  public string DbVersion{ get; } = dbVersion;
  public string DefaultDir{ get; } = defaultDir;
  public string RelayOrder{ get; } = relayOrder;
  public string LastDir{ get; } = lastDir;
  public short? SplitPref{ get; } = splitPref;
  public bool RptLastFirst{ get; } = rptLastFirst;
  public bool RptShowMI{ get; } = rptShowMI;
  public bool RptFILast{ get; } = rptFILast;
  public bool RptFirstLI{ get; } = rptFirstLI;
  public bool RptShowPref{ get; } = rptShowPref;
  public string OfficialLine1{ get; } = officialLine1;
  public string OfficialLine2{ get; } = officialLine2;
  public string OfficialLine3{ get; } = officialLine3;
  public bool UseProvince{ get; } = useProvince;
  public string DefCity{ get; } = defCity;
  public string CusPrompt4{ get; } = cusPrompt4;
  public string CusPrompt5{ get; } = cusPrompt5;
  public string CusPrompt6{ get; } = cusPrompt6;
  public string CusPrompt7{ get; } = cusPrompt7;
  public string CusPrompt8{ get; } = cusPrompt8;
  public string OnlineRegistrationType{ get; } = onlineRegistrationType;
  public string DefZip{ get; } = defZip;
  public bool DontShowMeetSharing{ get; } = dontShowMeetSharing;
}
}
}
