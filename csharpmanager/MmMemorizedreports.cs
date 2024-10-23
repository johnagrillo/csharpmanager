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
/// CREATE TABLE [MemorizedReports]
/// (
/// [Mem_Name] Text (80),
/// [Mem_Type] Integer,
/// [Mem_Ptr] Long Integer,
/// [Num_Columns] Integer,
/// [Sort_Order] Integer,
/// [Date_Time] Integer,
/// [ID_Type] Integer,
/// [Top_HowMany] Integer,
/// [Num_RelayNames] Integer,
/// [Show_StartTimes] Boolean NOT NULL,
/// [Incl_Records] Boolean NOT NULL,
/// [Incl_TimeStds] Boolean NOT NULL,
/// [Incl_QualTimes] Boolean NOT NULL,
/// [Incl_EvtComments] Boolean NOT NULL,
/// [Line_ForResults] Boolean NOT NULL,
/// [Incl_NoEntries] Boolean NOT NULL,
/// [Incl_PriorResults] Boolean NOT NULL,
/// [Incl_Rnd1Alt] Boolean NOT NULL,
/// [Incl_EmptyLanes] Boolean NOT NULL,
/// [Show_SeedTimes] Boolean NOT NULL,
/// [Sep_ABFinal] Boolean NOT NULL,
/// [OneEvent_PerPage] Boolean NOT NULL,
/// [Ref_Format] Boolean NOT NULL,
/// [OneHeat_PerPage] Boolean NOT NULL,
/// [Dbl_Space] Boolean NOT NULL,
/// [Show_Ranks] Boolean NOT NULL,
/// [MultiAge_Split] Boolean NOT NULL,
/// [Incl_QualifiedAlts] Boolean NOT NULL,
/// [ScrAltExhSpec_Filters] Integer,
/// [Incl_Scratches] Boolean NOT NULL,
/// [Ignore_Psych] Boolean NOT NULL,
/// [Sess_Row] Long Integer,
/// [Evt_Gender] Integer,
/// [Evt_LowAge] Integer,
/// [Evt_HighAge] Integer,
/// [Team_Abbr] Text (18),
/// [Evt_Round] Integer,
/// [Evt_IndivOrRelay] Integer,
/// [Report_Type] Integer,
/// [Sort_OrderAthAge] Integer,
/// [Incl_AthNoEntries] Boolean NOT NULL,
/// [Incl_AthNoEntries4Col] Boolean NOT NULL,
/// [AddApost_ClassYear] Boolean NOT NULL,
/// [Incl_CompNo] Boolean NOT NULL,
/// [Incl_CompNo4Col] Boolean NOT NULL,
/// [AddrSort_ByTeam] Boolean NOT NULL,
/// [AddrSort_ByZip] Boolean NOT NULL,
/// [Incl_ScrInEntryCount] Boolean NOT NULL,
/// [Incl_AltInEntryCount] Boolean NOT NULL,
/// [Incl_BirthDate] Boolean NOT NULL,
/// [Incl_TeamAddr] Boolean NOT NULL,
/// [Incl_Coaches] Boolean NOT NULL,
/// [AthUseAbbr_ForTeam] Boolean NOT NULL,
/// [Div_Abbr] Text (60),
/// [Report_Format] Integer,
/// [Incl_HeatLane] Boolean NOT NULL,
/// [Add_LineSpace] Boolean NOT NULL,
/// [Incl_RegID] Boolean NOT NULL,
/// [Show_CheckIn] Boolean NOT NULL,
/// [NumAth_PerPage] Integer,
/// [Splits_Choice] Integer,
/// [Results_ByHeat] Boolean NOT NULL,
/// [Page_Break] Boolean NOT NULL,
/// [Incl_SpecPts] Boolean NOT NULL,
/// [Incl_TimeTrials] Boolean NOT NULL,
/// [Incl_NoShows] Boolean NOT NULL,
/// [Incl_TeamPts] Boolean NOT NULL,
/// [Low_Lane] Integer,
/// [High_Lane] Integer,
/// [Score_Female] Boolean NOT NULL,
/// [Score_Male] Boolean NOT NULL,
/// [Score_Combined] Boolean NOT NULL,
/// [Score_CombinedBoth] Boolean NOT NULL,
/// [BAG_CATS] Boolean NOT NULL,
/// [Flat_HTML] Boolean NOT NULL,
/// [DotMatrix_LabelChoice] Text (80),
/// [Laser_LabelChoice] Text (80),
/// [Incl_TeamScore] Boolean NOT NULL,
/// [Incl_FemaleTeamScore] Boolean NOT NULL,
/// [Incl_MaleTeamScore] Boolean NOT NULL,
/// [CombineDivisions_ForTeamPoints] Boolean NOT NULL,
/// [Incl_DQCodes] Boolean NOT NULL,
/// [Incl_ReactionTimes] Boolean NOT NULL,
/// [Incl_Backups] Boolean NOT NULL,
/// [UseLaser_Label] Integer,
/// [UseDQTimesfor_CombinedEvents] Boolean NOT NULL,
/// [Incl_EntryTimes] Boolean NOT NULL,
/// [Incl_PriorResultsSplits] Boolean NOT NULL,
/// [Incl_LogosinFooter] Boolean NOT NULL,
/// [LaneTimer_Pads] Boolean NOT NULL,
/// [UseBestTimes_AllRounds] Boolean NOT NULL,
/// [Qual_Club] Boolean NOT NULL,
/// [QualClub_Scorers] Boolean NOT NULL,
/// [PtBreakOut_HighPt] Boolean NOT NULL,
/// [RTF_export] Boolean NOT NULL,
/// [Results_ByHeatInclLane] Boolean NOT NULL,
/// [NoShows_Only] Boolean NOT NULL,
/// [Scratches_Only] Boolean NOT NULL,
/// [DQs_Only] Boolean NOT NULL,
/// [Combined_BothMustScore] Boolean NOT NULL
/// );

public class MmMemorizedreports 
{
List<MmMemorizedreports> get(OdbcConnection connection)
{
  var collection = new List<MmMemorizedreports>();
  string query = "select * from MemorizedReports";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* Mem_Name */
      var arg1 = reader.GetInt16(2); /* Mem_Type */
      var arg2 = reader.GetInt64(3); /* Mem_Ptr */
      var arg3 = reader.GetInt16(4); /* Num_Columns */
      var arg4 = reader.GetInt16(5); /* Sort_Order */
      var arg5 = reader.GetInt16(6); /* Date_Time */
      var arg6 = reader.GetInt16(7); /* ID_Type */
      var arg7 = reader.GetInt16(8); /* Top_HowMany */
      var arg8 = reader.GetInt16(9); /* Num_RelayNames */
      var arg9 = reader.GetBoolean(10); /* Show_StartTimes */
      var arg10 = reader.GetBoolean(11); /* Incl_Records */
      var arg11 = reader.GetBoolean(12); /* Incl_TimeStds */
      var arg12 = reader.GetBoolean(13); /* Incl_QualTimes */
      var arg13 = reader.GetBoolean(14); /* Incl_EvtComments */
      var arg14 = reader.GetBoolean(15); /* Line_ForResults */
      var arg15 = reader.GetBoolean(16); /* Incl_NoEntries */
      var arg16 = reader.GetBoolean(17); /* Incl_PriorResults */
      var arg17 = reader.GetBoolean(18); /* Incl_Rnd1Alt */
      var arg18 = reader.GetBoolean(19); /* Incl_EmptyLanes */
      var arg19 = reader.GetBoolean(20); /* Show_SeedTimes */
      var arg20 = reader.GetBoolean(21); /* Sep_ABFinal */
      var arg21 = reader.GetBoolean(22); /* OneEvent_PerPage */
      var arg22 = reader.GetBoolean(23); /* Ref_Format */
      var arg23 = reader.GetBoolean(24); /* OneHeat_PerPage */
      var arg24 = reader.GetBoolean(25); /* Dbl_Space */
      var arg25 = reader.GetBoolean(26); /* Show_Ranks */
      var arg26 = reader.GetBoolean(27); /* MultiAge_Split */
      var arg27 = reader.GetBoolean(28); /* Incl_QualifiedAlts */
      var arg28 = reader.GetInt16(29); /* ScrAltExhSpec_Filters */
      var arg29 = reader.GetBoolean(30); /* Incl_Scratches */
      var arg30 = reader.GetBoolean(31); /* Ignore_Psych */
      var arg31 = reader.GetInt64(32); /* Sess_Row */
      var arg32 = reader.GetInt16(33); /* Evt_Gender */
      var arg33 = reader.GetInt16(34); /* Evt_LowAge */
      var arg34 = reader.GetInt16(35); /* Evt_HighAge */
      var arg35 = reader.GetTextReader(36).ToString(); /* Team_Abbr */
      var arg36 = reader.GetInt16(37); /* Evt_Round */
      var arg37 = reader.GetInt16(38); /* Evt_IndivOrRelay */
      var arg38 = reader.GetInt16(39); /* Report_Type */
      var arg39 = reader.GetInt16(40); /* Sort_OrderAthAge */
      var arg40 = reader.GetBoolean(41); /* Incl_AthNoEntries */
      var arg41 = reader.GetBoolean(42); /* Incl_AthNoEntries4Col */
      var arg42 = reader.GetBoolean(43); /* AddApost_ClassYear */
      var arg43 = reader.GetBoolean(44); /* Incl_CompNo */
      var arg44 = reader.GetBoolean(45); /* Incl_CompNo4Col */
      var arg45 = reader.GetBoolean(46); /* AddrSort_ByTeam */
      var arg46 = reader.GetBoolean(47); /* AddrSort_ByZip */
      var arg47 = reader.GetBoolean(48); /* Incl_ScrInEntryCount */
      var arg48 = reader.GetBoolean(49); /* Incl_AltInEntryCount */
      var arg49 = reader.GetBoolean(50); /* Incl_BirthDate */
      var arg50 = reader.GetBoolean(51); /* Incl_TeamAddr */
      var arg51 = reader.GetBoolean(52); /* Incl_Coaches */
      var arg52 = reader.GetBoolean(53); /* AthUseAbbr_ForTeam */
      var arg53 = reader.GetTextReader(54).ToString(); /* Div_Abbr */
      var arg54 = reader.GetInt16(55); /* Report_Format */
      var arg55 = reader.GetBoolean(56); /* Incl_HeatLane */
      var arg56 = reader.GetBoolean(57); /* Add_LineSpace */
      var arg57 = reader.GetBoolean(58); /* Incl_RegID */
      var arg58 = reader.GetBoolean(59); /* Show_CheckIn */
      var arg59 = reader.GetInt16(60); /* NumAth_PerPage */
      var arg60 = reader.GetInt16(61); /* Splits_Choice */
      var arg61 = reader.GetBoolean(62); /* Results_ByHeat */
      var arg62 = reader.GetBoolean(63); /* Page_Break */
      var arg63 = reader.GetBoolean(64); /* Incl_SpecPts */
      var arg64 = reader.GetBoolean(65); /* Incl_TimeTrials */
      var arg65 = reader.GetBoolean(66); /* Incl_NoShows */
      var arg66 = reader.GetBoolean(67); /* Incl_TeamPts */
      var arg67 = reader.GetInt16(68); /* Low_Lane */
      var arg68 = reader.GetInt16(69); /* High_Lane */
      var arg69 = reader.GetBoolean(70); /* Score_Female */
      var arg70 = reader.GetBoolean(71); /* Score_Male */
      var arg71 = reader.GetBoolean(72); /* Score_Combined */
      var arg72 = reader.GetBoolean(73); /* Score_CombinedBoth */
      var arg73 = reader.GetBoolean(74); /* BAG_CATS */
      var arg74 = reader.GetBoolean(75); /* Flat_HTML */
      var arg75 = reader.GetTextReader(76).ToString(); /* DotMatrix_LabelChoice */
      var arg76 = reader.GetTextReader(77).ToString(); /* Laser_LabelChoice */
      var arg77 = reader.GetBoolean(78); /* Incl_TeamScore */
      var arg78 = reader.GetBoolean(79); /* Incl_FemaleTeamScore */
      var arg79 = reader.GetBoolean(80); /* Incl_MaleTeamScore */
      var arg80 = reader.GetBoolean(81); /* CombineDivisions_ForTeamPoints */
      var arg81 = reader.GetBoolean(82); /* Incl_DQCodes */
      var arg82 = reader.GetBoolean(83); /* Incl_ReactionTimes */
      var arg83 = reader.GetBoolean(84); /* Incl_Backups */
      var arg84 = reader.GetInt16(85); /* UseLaser_Label */
      var arg85 = reader.GetBoolean(86); /* UseDQTimesfor_CombinedEvents */
      var arg86 = reader.GetBoolean(87); /* Incl_EntryTimes */
      var arg87 = reader.GetBoolean(88); /* Incl_PriorResultsSplits */
      var arg88 = reader.GetBoolean(89); /* Incl_LogosinFooter */
      var arg89 = reader.GetBoolean(90); /* LaneTimer_Pads */
      var arg90 = reader.GetBoolean(91); /* UseBestTimes_AllRounds */
      var arg91 = reader.GetBoolean(92); /* Qual_Club */
      var arg92 = reader.GetBoolean(93); /* QualClub_Scorers */
      var arg93 = reader.GetBoolean(94); /* PtBreakOut_HighPt */
      var arg94 = reader.GetBoolean(95); /* RTF_export */
      var arg95 = reader.GetBoolean(96); /* Results_ByHeatInclLane */
      var arg96 = reader.GetBoolean(97); /* NoShows_Only */
      var arg97 = reader.GetBoolean(98); /* Scratches_Only */
      var arg98 = reader.GetBoolean(99); /* DQs_Only */
      var arg99 = reader.GetBoolean(100); /* Combined_BothMustScore */
      collection.Add( new MmMemorizedreports(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99));
    }
  }
  return collection;
}
  // Properties
  public string MemName{ get; }
  public short MemType{ get; }
  public long MemPtr{ get; }
  public short NumColumns{ get; }
  public short SortOrder{ get; }
  public short DateTime{ get; }
  public short IDType{ get; }
  public short TopHowMany{ get; }
  public short NumRelayNames{ get; }
  public bool ShowStartTimes{ get; }
  public bool InclRecords{ get; }
  public bool InclTimeStds{ get; }
  public bool InclQualTimes{ get; }
  public bool InclEvtComments{ get; }
  public bool LineForResults{ get; }
  public bool InclNoEntries{ get; }
  public bool InclPriorResults{ get; }
  public bool InclRnd1Alt{ get; }
  public bool InclEmptyLanes{ get; }
  public bool ShowSeedTimes{ get; }
  public bool SepABFinal{ get; }
  public bool OneEventPerPage{ get; }
  public bool RefFormat{ get; }
  public bool OneHeatPerPage{ get; }
  public bool DblSpace{ get; }
  public bool ShowRanks{ get; }
  public bool MultiAgeSplit{ get; }
  public bool InclQualifiedAlts{ get; }
  public short ScrAltExhSpecFilters{ get; }
  public bool InclScratches{ get; }
  public bool IgnorePsych{ get; }
  public long SessRow{ get; }
  public short EvtGender{ get; }
  public short EvtLowAge{ get; }
  public short EvtHighAge{ get; }
  public string TeamAbbr{ get; }
  public short EvtRound{ get; }
  public short EvtIndivOrRelay{ get; }
  public short ReportType{ get; }
  public short SortOrderAthAge{ get; }
  public bool InclAthNoEntries{ get; }
  public bool InclAthNoEntries4Col{ get; }
  public bool AddApostClassYear{ get; }
  public bool InclCompNo{ get; }
  public bool InclCompNo4Col{ get; }
  public bool AddrSortByTeam{ get; }
  public bool AddrSortByZip{ get; }
  public bool InclScrInEntryCount{ get; }
  public bool InclAltInEntryCount{ get; }
  public bool InclBirthDate{ get; }
  public bool InclTeamAddr{ get; }
  public bool InclCoaches{ get; }
  public bool AthUseAbbrForTeam{ get; }
  public string DivAbbr{ get; }
  public short ReportFormat{ get; }
  public bool InclHeatLane{ get; }
  public bool AddLineSpace{ get; }
  public bool InclRegID{ get; }
  public bool ShowCheckIn{ get; }
  public short NumAthPerPage{ get; }
  public short SplitsChoice{ get; }
  public bool ResultsByHeat{ get; }
  public bool PageBreak{ get; }
  public bool InclSpecPts{ get; }
  public bool InclTimeTrials{ get; }
  public bool InclNoShows{ get; }
  public bool InclTeamPts{ get; }
  public short LowLane{ get; }
  public short HighLane{ get; }
  public bool ScoreFemale{ get; }
  public bool ScoreMale{ get; }
  public bool ScoreCombined{ get; }
  public bool ScoreCombinedBoth{ get; }
  public bool Bag_cats{ get; }
  public bool FlatHTML{ get; }
  public string DotMatrixLabelChoice{ get; }
  public string LaserLabelChoice{ get; }
  public bool InclTeamScore{ get; }
  public bool InclFemaleTeamScore{ get; }
  public bool InclMaleTeamScore{ get; }
  public bool CombineDivisionsForTeamPoints{ get; }
  public bool InclDQCodes{ get; }
  public bool InclReactionTimes{ get; }
  public bool InclBackups{ get; }
  public short UseLaserLabel{ get; }
  public bool UseDQTimesforCombinedEvents{ get; }
  public bool InclEntryTimes{ get; }
  public bool InclPriorResultsSplits{ get; }
  public bool InclLogosinFooter{ get; }
  public bool LaneTimerPads{ get; }
  public bool UseBestTimesAllRounds{ get; }
  public bool QualClub{ get; }
  public bool QualClubScorers{ get; }
  public bool PtBreakOutHighPt{ get; }
  public bool RTFExport{ get; }
  public bool ResultsByHeatInclLane{ get; }
  public bool NoShowsOnly{ get; }
  public bool ScratchesOnly{ get; }
  public bool DQsOnly{ get; }
  public bool CombinedBothMustScore{ get; }
  // Constructor
  MmMemorizedreports(string memName, short memType, long memPtr, short numColumns, short sortOrder, short dateTime, short iDType, short topHowMany, short numRelayNames, bool showStartTimes, bool inclRecords, bool inclTimeStds, bool inclQualTimes, bool inclEvtComments, bool lineForResults, bool inclNoEntries, bool inclPriorResults, bool inclRnd1Alt, bool inclEmptyLanes, bool showSeedTimes, bool sepABFinal, bool oneEventPerPage, bool refFormat, bool oneHeatPerPage, bool dblSpace, bool showRanks, bool multiAgeSplit, bool inclQualifiedAlts, short scrAltExhSpecFilters, bool inclScratches, bool ignorePsych, long sessRow, short evtGender, short evtLowAge, short evtHighAge, string teamAbbr, short evtRound, short evtIndivOrRelay, short reportType, short sortOrderAthAge, bool inclAthNoEntries, bool inclAthNoEntries4Col, bool addApostClassYear, bool inclCompNo, bool inclCompNo4Col, bool addrSortByTeam, bool addrSortByZip, bool inclScrInEntryCount, bool inclAltInEntryCount, bool inclBirthDate, bool inclTeamAddr, bool inclCoaches, bool athUseAbbrForTeam, string divAbbr, short reportFormat, bool inclHeatLane, bool addLineSpace, bool inclRegID, bool showCheckIn, short numAthPerPage, short splitsChoice, bool resultsByHeat, bool pageBreak, bool inclSpecPts, bool inclTimeTrials, bool inclNoShows, bool inclTeamPts, short lowLane, short highLane, bool scoreFemale, bool scoreMale, bool scoreCombined, bool scoreCombinedBoth, bool bag_cats, bool flatHTML, string dotMatrixLabelChoice, string laserLabelChoice, bool inclTeamScore, bool inclFemaleTeamScore, bool inclMaleTeamScore, bool combineDivisionsForTeamPoints, bool inclDQCodes, bool inclReactionTimes, bool inclBackups, short useLaserLabel, bool useDQTimesforCombinedEvents, bool inclEntryTimes, bool inclPriorResultsSplits, bool inclLogosinFooter, bool laneTimerPads, bool useBestTimesAllRounds, bool qualClub, bool qualClubScorers, bool ptBreakOutHighPt, bool rTFExport, bool resultsByHeatInclLane, bool noShowsOnly, bool scratchesOnly, bool dQsOnly, bool combinedBothMustScore )
  {
    MemName = memName;
    MemType = memType;
    MemPtr = memPtr;
    NumColumns = numColumns;
    SortOrder = sortOrder;
    DateTime = dateTime;
    IDType = iDType;
    TopHowMany = topHowMany;
    NumRelayNames = numRelayNames;
    ShowStartTimes = showStartTimes;
    InclRecords = inclRecords;
    InclTimeStds = inclTimeStds;
    InclQualTimes = inclQualTimes;
    InclEvtComments = inclEvtComments;
    LineForResults = lineForResults;
    InclNoEntries = inclNoEntries;
    InclPriorResults = inclPriorResults;
    InclRnd1Alt = inclRnd1Alt;
    InclEmptyLanes = inclEmptyLanes;
    ShowSeedTimes = showSeedTimes;
    SepABFinal = sepABFinal;
    OneEventPerPage = oneEventPerPage;
    RefFormat = refFormat;
    OneHeatPerPage = oneHeatPerPage;
    DblSpace = dblSpace;
    ShowRanks = showRanks;
    MultiAgeSplit = multiAgeSplit;
    InclQualifiedAlts = inclQualifiedAlts;
    ScrAltExhSpecFilters = scrAltExhSpecFilters;
    InclScratches = inclScratches;
    IgnorePsych = ignorePsych;
    SessRow = sessRow;
    EvtGender = evtGender;
    EvtLowAge = evtLowAge;
    EvtHighAge = evtHighAge;
    TeamAbbr = teamAbbr;
    EvtRound = evtRound;
    EvtIndivOrRelay = evtIndivOrRelay;
    ReportType = reportType;
    SortOrderAthAge = sortOrderAthAge;
    InclAthNoEntries = inclAthNoEntries;
    InclAthNoEntries4Col = inclAthNoEntries4Col;
    AddApostClassYear = addApostClassYear;
    InclCompNo = inclCompNo;
    InclCompNo4Col = inclCompNo4Col;
    AddrSortByTeam = addrSortByTeam;
    AddrSortByZip = addrSortByZip;
    InclScrInEntryCount = inclScrInEntryCount;
    InclAltInEntryCount = inclAltInEntryCount;
    InclBirthDate = inclBirthDate;
    InclTeamAddr = inclTeamAddr;
    InclCoaches = inclCoaches;
    AthUseAbbrForTeam = athUseAbbrForTeam;
    DivAbbr = divAbbr;
    ReportFormat = reportFormat;
    InclHeatLane = inclHeatLane;
    AddLineSpace = addLineSpace;
    InclRegID = inclRegID;
    ShowCheckIn = showCheckIn;
    NumAthPerPage = numAthPerPage;
    SplitsChoice = splitsChoice;
    ResultsByHeat = resultsByHeat;
    PageBreak = pageBreak;
    InclSpecPts = inclSpecPts;
    InclTimeTrials = inclTimeTrials;
    InclNoShows = inclNoShows;
    InclTeamPts = inclTeamPts;
    LowLane = lowLane;
    HighLane = highLane;
    ScoreFemale = scoreFemale;
    ScoreMale = scoreMale;
    ScoreCombined = scoreCombined;
    ScoreCombinedBoth = scoreCombinedBoth;
    Bag_cats = bag_cats;
    FlatHTML = flatHTML;
    DotMatrixLabelChoice = dotMatrixLabelChoice;
    LaserLabelChoice = laserLabelChoice;
    InclTeamScore = inclTeamScore;
    InclFemaleTeamScore = inclFemaleTeamScore;
    InclMaleTeamScore = inclMaleTeamScore;
    CombineDivisionsForTeamPoints = combineDivisionsForTeamPoints;
    InclDQCodes = inclDQCodes;
    InclReactionTimes = inclReactionTimes;
    InclBackups = inclBackups;
    UseLaserLabel = useLaserLabel;
    UseDQTimesforCombinedEvents = useDQTimesforCombinedEvents;
    InclEntryTimes = inclEntryTimes;
    InclPriorResultsSplits = inclPriorResultsSplits;
    InclLogosinFooter = inclLogosinFooter;
    LaneTimerPads = laneTimerPads;
    UseBestTimesAllRounds = useBestTimesAllRounds;
    QualClub = qualClub;
    QualClubScorers = qualClubScorers;
    PtBreakOutHighPt = ptBreakOutHighPt;
    RTFExport = rTFExport;
    ResultsByHeatInclLane = resultsByHeatInclLane;
    NoShowsOnly = noShowsOnly;
    ScratchesOnly = scratchesOnly;
    DQsOnly = dQsOnly;
    CombinedBothMustScore = combinedBothMustScore;
  }
}
