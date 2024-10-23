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
/// CREATE TABLE [OPTIONS]
/// (
/// [State] Text (6),
/// [Citizen] Text (6),
/// [LSC] Text (6),
/// [Standard] Text (16),
/// [Record] Text (16),
/// [Course] Text (2),
/// [TeamType] Text (6),
/// [RegType] Text (8),
/// [Line1] Text (80),
/// [Line2] Text (80),
/// [RptUCase] Boolean NOT NULL,
/// [SysAgeUp] DateTime,
/// [MtAgeUp] Integer,
/// [MtDate] DateTime,
/// [FavSex] Byte,
/// [NoAge] Byte,
/// [MinAge] Byte,
/// [FavTeam] Text (10),
/// [FavLSC] Text (6),
/// [CvtFactor] Double,
/// [CvtType] Byte,
/// [Cvt500] Double,
/// [Cvt1650] Double,
/// [FreeTurn] Double,
/// [BackTurn] Double,
/// [BreastTurn] Double,
/// [FlyTurn] Double,
/// [IMTurn] Double,
/// [Straight] Double,
/// [Y2L] Boolean NOT NULL,
/// [Language] Text (16),
/// [LabelOption] Byte,
/// [ShowMI] Boolean NOT NULL,
/// [ShowAges] Boolean NOT NULL,
/// [ShowBirth] Boolean NOT NULL,
/// [ShowClass] Boolean NOT NULL,
/// [ShowFirstFirst] Boolean NOT NULL,
/// [Favorite] Text (16),
/// [ToScreen] Boolean NOT NULL,
/// [NumCopies] Byte,
/// [PaperSize] Byte,
/// [UseLeadOff] Boolean NOT NULL,
/// [UseStrokeRates] Boolean NOT NULL,
/// [CusPrompt1] Text (40),
/// [CusPrompt2] Text (40),
/// [CusPrompt3] Text (40),
/// [RegDate] DateTime,
/// [ShowOnlyFast] Boolean NOT NULL,
/// [LabelType] Byte,
/// [ImportDir] Text (240),
/// [ExportDir] Text (240),
/// [BackupDir] Text (240),
/// [ReportDir] Text (240),
/// [LSCFee] Single,
/// [RegAddr] Text (100),
/// [RegCity] Text (40),
/// [RegState] Text (6),
/// [RegZIP] Text (20),
/// [RegMailTo] Text (80),
/// [RegPayTo] Text (80),
/// [PalmImportDir] Text (240),
/// [LSCSeasonalFee] Single,
/// [BackupCheck] Byte,
/// [UpdateCheck] Byte,
/// [LastBackup] DateTime,
/// [LastSplitExtract] DateTime,
/// [AgeupToCurrent] Boolean NOT NULL,
/// [DbVersion] Text (10),
/// [DefaultDir] Text (240),
/// [RelayOrder] Text (14),
/// [LastDir] Text (240),
/// [SplitPref] Integer,
/// [rptLastFirst] Boolean NOT NULL,
/// [rptShowMI] Boolean NOT NULL,
/// [rptFILast] Boolean NOT NULL,
/// [rptFirstLI] Boolean NOT NULL,
/// [rptShowPref] Boolean NOT NULL,
/// [OfficialLine1] Text (216),
/// [OfficialLine2] Text (216),
/// [OfficialLine3] Text (216),
/// [UseProvince] Boolean NOT NULL,
/// [DefCity] Text (60),
/// [CusPrompt4] Text (40),
/// [CusPrompt5] Text (40),
/// [CusPrompt6] Text (40),
/// [CusPrompt7] Text (40),
/// [CusPrompt8] Text (40),
/// [OnlineRegistrationType] Text (2),
/// [DefZip] Text (20),
/// [DontShowMeetSharing] Boolean NOT NULL
/// );

public class TmOptions 
{
List<TmOptions> get(OdbcConnection connection)
{
  var collection = new List<TmOptions>();
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
      var arg0 = reader.GetTextReader(1).ToString(); /* State */
      var arg1 = reader.GetTextReader(2).ToString(); /* Citizen */
      var arg2 = reader.GetTextReader(3).ToString(); /* LSC */
      var arg3 = reader.GetTextReader(4).ToString(); /* Standard */
      var arg4 = reader.GetTextReader(5).ToString(); /* Record */
      var arg5 = reader.GetTextReader(6).ToString(); /* Course */
      var arg6 = reader.GetTextReader(7).ToString(); /* TeamType */
      var arg7 = reader.GetTextReader(8).ToString(); /* RegType */
      var arg8 = reader.GetTextReader(9).ToString(); /* Line1 */
      var arg9 = reader.GetTextReader(10).ToString(); /* Line2 */
      var arg10 = reader.GetBoolean(11); /* RptUCase */
      var arg11 = reader.GetDateTime(12); /* SysAgeUp */
      var arg12 = reader.GetInt16(13); /* MtAgeUp */
      var arg13 = reader.GetDateTime(14); /* MtDate */
      var arg14 = reader.GetByte(15); /* FavSex */
      var arg15 = reader.GetByte(16); /* NoAge */
      var arg16 = reader.GetByte(17); /* MinAge */
      var arg17 = reader.GetTextReader(18).ToString(); /* FavTeam */
      var arg18 = reader.GetTextReader(19).ToString(); /* FavLSC */
      var arg19 = reader.GetFloat(20); /* CvtFactor */
      var arg20 = reader.GetByte(21); /* CvtType */
      var arg21 = reader.GetFloat(22); /* Cvt500 */
      var arg22 = reader.GetFloat(23); /* Cvt1650 */
      var arg23 = reader.GetFloat(24); /* FreeTurn */
      var arg24 = reader.GetFloat(25); /* BackTurn */
      var arg25 = reader.GetFloat(26); /* BreastTurn */
      var arg26 = reader.GetFloat(27); /* FlyTurn */
      var arg27 = reader.GetFloat(28); /* IMTurn */
      var arg28 = reader.GetFloat(29); /* Straight */
      var arg29 = reader.GetBoolean(30); /* Y2L */
      var arg30 = reader.GetTextReader(31).ToString(); /* Language */
      var arg31 = reader.GetByte(32); /* LabelOption */
      var arg32 = reader.GetBoolean(33); /* ShowMI */
      var arg33 = reader.GetBoolean(34); /* ShowAges */
      var arg34 = reader.GetBoolean(35); /* ShowBirth */
      var arg35 = reader.GetBoolean(36); /* ShowClass */
      var arg36 = reader.GetBoolean(37); /* ShowFirstFirst */
      var arg37 = reader.GetTextReader(38).ToString(); /* Favorite */
      var arg38 = reader.GetBoolean(39); /* ToScreen */
      var arg39 = reader.GetByte(40); /* NumCopies */
      var arg40 = reader.GetByte(41); /* PaperSize */
      var arg41 = reader.GetBoolean(42); /* UseLeadOff */
      var arg42 = reader.GetBoolean(43); /* UseStrokeRates */
      var arg43 = reader.GetTextReader(44).ToString(); /* CusPrompt1 */
      var arg44 = reader.GetTextReader(45).ToString(); /* CusPrompt2 */
      var arg45 = reader.GetTextReader(46).ToString(); /* CusPrompt3 */
      var arg46 = reader.GetDateTime(47); /* RegDate */
      var arg47 = reader.GetBoolean(48); /* ShowOnlyFast */
      var arg48 = reader.GetByte(49); /* LabelType */
      var arg49 = reader.GetTextReader(50).ToString(); /* ImportDir */
      var arg50 = reader.GetTextReader(51).ToString(); /* ExportDir */
      var arg51 = reader.GetTextReader(52).ToString(); /* BackupDir */
      var arg52 = reader.GetTextReader(53).ToString(); /* ReportDir */
      var arg53 = reader.GetFloat(54); /* LSCFee */
      var arg54 = reader.GetTextReader(55).ToString(); /* RegAddr */
      var arg55 = reader.GetTextReader(56).ToString(); /* RegCity */
      var arg56 = reader.GetTextReader(57).ToString(); /* RegState */
      var arg57 = reader.GetTextReader(58).ToString(); /* RegZIP */
      var arg58 = reader.GetTextReader(59).ToString(); /* RegMailTo */
      var arg59 = reader.GetTextReader(60).ToString(); /* RegPayTo */
      var arg60 = reader.GetTextReader(61).ToString(); /* PalmImportDir */
      var arg61 = reader.GetFloat(62); /* LSCSeasonalFee */
      var arg62 = reader.GetByte(63); /* BackupCheck */
      var arg63 = reader.GetByte(64); /* UpdateCheck */
      var arg64 = reader.GetDateTime(65); /* LastBackup */
      var arg65 = reader.GetDateTime(66); /* LastSplitExtract */
      var arg66 = reader.GetBoolean(67); /* AgeupToCurrent */
      var arg67 = reader.GetTextReader(68).ToString(); /* DbVersion */
      var arg68 = reader.GetTextReader(69).ToString(); /* DefaultDir */
      var arg69 = reader.GetTextReader(70).ToString(); /* RelayOrder */
      var arg70 = reader.GetTextReader(71).ToString(); /* LastDir */
      var arg71 = reader.GetInt16(72); /* SplitPref */
      var arg72 = reader.GetBoolean(73); /* rptLastFirst */
      var arg73 = reader.GetBoolean(74); /* rptShowMI */
      var arg74 = reader.GetBoolean(75); /* rptFILast */
      var arg75 = reader.GetBoolean(76); /* rptFirstLI */
      var arg76 = reader.GetBoolean(77); /* rptShowPref */
      var arg77 = reader.GetTextReader(78).ToString(); /* OfficialLine1 */
      var arg78 = reader.GetTextReader(79).ToString(); /* OfficialLine2 */
      var arg79 = reader.GetTextReader(80).ToString(); /* OfficialLine3 */
      var arg80 = reader.GetBoolean(81); /* UseProvince */
      var arg81 = reader.GetTextReader(82).ToString(); /* DefCity */
      var arg82 = reader.GetTextReader(83).ToString(); /* CusPrompt4 */
      var arg83 = reader.GetTextReader(84).ToString(); /* CusPrompt5 */
      var arg84 = reader.GetTextReader(85).ToString(); /* CusPrompt6 */
      var arg85 = reader.GetTextReader(86).ToString(); /* CusPrompt7 */
      var arg86 = reader.GetTextReader(87).ToString(); /* CusPrompt8 */
      var arg87 = reader.GetTextReader(88).ToString(); /* OnlineRegistrationType */
      var arg88 = reader.GetTextReader(89).ToString(); /* DefZip */
      var arg89 = reader.GetBoolean(90); /* DontShowMeetSharing */
      collection.Add( new TmOptions(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89));
    }
  }
  return collection;
}
  // Properties
  public string State{ get; }
  public string Citizen{ get; }
  public string Lsc{ get; }
  public string Standard{ get; }
  public string Record{ get; }
  public string Course{ get; }
  public string TeamType{ get; }
  public string RegType{ get; }
  public string Line1{ get; }
  public string Line2{ get; }
  public bool RptUCase{ get; }
  public DateTime SysAgeUp{ get; }
  public short MtAgeUp{ get; }
  public DateTime MtDate{ get; }
  public byte FavSex{ get; }
  public byte NoAge{ get; }
  public byte MinAge{ get; }
  public string FavTeam{ get; }
  public string FavLSC{ get; }
  public double CvtFactor{ get; }
  public byte CvtType{ get; }
  public double Cvt500{ get; }
  public double Cvt1650{ get; }
  public double FreeTurn{ get; }
  public double BackTurn{ get; }
  public double BreastTurn{ get; }
  public double FlyTurn{ get; }
  public double IMTurn{ get; }
  public double Straight{ get; }
  public bool Y2l{ get; }
  public string Language{ get; }
  public byte LabelOption{ get; }
  public bool ShowMI{ get; }
  public bool ShowAges{ get; }
  public bool ShowBirth{ get; }
  public bool ShowClass{ get; }
  public bool ShowFirstFirst{ get; }
  public string Favorite{ get; }
  public bool ToScreen{ get; }
  public byte NumCopies{ get; }
  public byte PaperSize{ get; }
  public bool UseLeadOff{ get; }
  public bool UseStrokeRates{ get; }
  public string CusPrompt1{ get; }
  public string CusPrompt2{ get; }
  public string CusPrompt3{ get; }
  public DateTime RegDate{ get; }
  public bool ShowOnlyFast{ get; }
  public byte LabelType{ get; }
  public string ImportDir{ get; }
  public string ExportDir{ get; }
  public string BackupDir{ get; }
  public string ReportDir{ get; }
  public float LSCFee{ get; }
  public string RegAddr{ get; }
  public string RegCity{ get; }
  public string RegState{ get; }
  public string RegZIP{ get; }
  public string RegMailTo{ get; }
  public string RegPayTo{ get; }
  public string PalmImportDir{ get; }
  public float LSCSeasonalFee{ get; }
  public byte BackupCheck{ get; }
  public byte UpdateCheck{ get; }
  public DateTime LastBackup{ get; }
  public DateTime LastSplitExtract{ get; }
  public bool AgeupToCurrent{ get; }
  public string DbVersion{ get; }
  public string DefaultDir{ get; }
  public string RelayOrder{ get; }
  public string LastDir{ get; }
  public short SplitPref{ get; }
  public bool RptLastFirst{ get; }
  public bool RptShowMI{ get; }
  public bool RptFILast{ get; }
  public bool RptFirstLI{ get; }
  public bool RptShowPref{ get; }
  public string OfficialLine1{ get; }
  public string OfficialLine2{ get; }
  public string OfficialLine3{ get; }
  public bool UseProvince{ get; }
  public string DefCity{ get; }
  public string CusPrompt4{ get; }
  public string CusPrompt5{ get; }
  public string CusPrompt6{ get; }
  public string CusPrompt7{ get; }
  public string CusPrompt8{ get; }
  public string OnlineRegistrationType{ get; }
  public string DefZip{ get; }
  public bool DontShowMeetSharing{ get; }
  // Constructor
  TmOptions(string state, string citizen, string lsc, string standard, string record, string course, string teamType, string regType, string line1, string line2, bool rptUCase, DateTime sysAgeUp, short mtAgeUp, DateTime mtDate, byte favSex, byte noAge, byte minAge, string favTeam, string favLSC, double cvtFactor, byte cvtType, double cvt500, double cvt1650, double freeTurn, double backTurn, double breastTurn, double flyTurn, double iMTurn, double straight, bool y2l, string language, byte labelOption, bool showMI, bool showAges, bool showBirth, bool showClass, bool showFirstFirst, string favorite, bool toScreen, byte numCopies, byte paperSize, bool useLeadOff, bool useStrokeRates, string cusPrompt1, string cusPrompt2, string cusPrompt3, DateTime regDate, bool showOnlyFast, byte labelType, string importDir, string exportDir, string backupDir, string reportDir, float lSCFee, string regAddr, string regCity, string regState, string regZIP, string regMailTo, string regPayTo, string palmImportDir, float lSCSeasonalFee, byte backupCheck, byte updateCheck, DateTime lastBackup, DateTime lastSplitExtract, bool ageupToCurrent, string dbVersion, string defaultDir, string relayOrder, string lastDir, short splitPref, bool rptLastFirst, bool rptShowMI, bool rptFILast, bool rptFirstLI, bool rptShowPref, string officialLine1, string officialLine2, string officialLine3, bool useProvince, string defCity, string cusPrompt4, string cusPrompt5, string cusPrompt6, string cusPrompt7, string cusPrompt8, string onlineRegistrationType, string defZip, bool dontShowMeetSharing )
  {
    State = state;
    Citizen = citizen;
    Lsc = lsc;
    Standard = standard;
    Record = record;
    Course = course;
    TeamType = teamType;
    RegType = regType;
    Line1 = line1;
    Line2 = line2;
    RptUCase = rptUCase;
    SysAgeUp = sysAgeUp;
    MtAgeUp = mtAgeUp;
    MtDate = mtDate;
    FavSex = favSex;
    NoAge = noAge;
    MinAge = minAge;
    FavTeam = favTeam;
    FavLSC = favLSC;
    CvtFactor = cvtFactor;
    CvtType = cvtType;
    Cvt500 = cvt500;
    Cvt1650 = cvt1650;
    FreeTurn = freeTurn;
    BackTurn = backTurn;
    BreastTurn = breastTurn;
    FlyTurn = flyTurn;
    IMTurn = iMTurn;
    Straight = straight;
    Y2l = y2l;
    Language = language;
    LabelOption = labelOption;
    ShowMI = showMI;
    ShowAges = showAges;
    ShowBirth = showBirth;
    ShowClass = showClass;
    ShowFirstFirst = showFirstFirst;
    Favorite = favorite;
    ToScreen = toScreen;
    NumCopies = numCopies;
    PaperSize = paperSize;
    UseLeadOff = useLeadOff;
    UseStrokeRates = useStrokeRates;
    CusPrompt1 = cusPrompt1;
    CusPrompt2 = cusPrompt2;
    CusPrompt3 = cusPrompt3;
    RegDate = regDate;
    ShowOnlyFast = showOnlyFast;
    LabelType = labelType;
    ImportDir = importDir;
    ExportDir = exportDir;
    BackupDir = backupDir;
    ReportDir = reportDir;
    LSCFee = lSCFee;
    RegAddr = regAddr;
    RegCity = regCity;
    RegState = regState;
    RegZIP = regZIP;
    RegMailTo = regMailTo;
    RegPayTo = regPayTo;
    PalmImportDir = palmImportDir;
    LSCSeasonalFee = lSCSeasonalFee;
    BackupCheck = backupCheck;
    UpdateCheck = updateCheck;
    LastBackup = lastBackup;
    LastSplitExtract = lastSplitExtract;
    AgeupToCurrent = ageupToCurrent;
    DbVersion = dbVersion;
    DefaultDir = defaultDir;
    RelayOrder = relayOrder;
    LastDir = lastDir;
    SplitPref = splitPref;
    RptLastFirst = rptLastFirst;
    RptShowMI = rptShowMI;
    RptFILast = rptFILast;
    RptFirstLI = rptFirstLI;
    RptShowPref = rptShowPref;
    OfficialLine1 = officialLine1;
    OfficialLine2 = officialLine2;
    OfficialLine3 = officialLine3;
    UseProvince = useProvince;
    DefCity = defCity;
    CusPrompt4 = cusPrompt4;
    CusPrompt5 = cusPrompt5;
    CusPrompt6 = cusPrompt6;
    CusPrompt7 = cusPrompt7;
    CusPrompt8 = cusPrompt8;
    OnlineRegistrationType = onlineRegistrationType;
    DefZip = defZip;
    DontShowMeetSharing = dontShowMeetSharing;
  }
}
