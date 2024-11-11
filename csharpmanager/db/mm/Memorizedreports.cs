using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [MemorizedReports]
/// // (
/// // [Mem_Name] Text (80),
/// // [Mem_Type] Integer,
/// // [Mem_Ptr] Long Integer,
/// // [Num_Columns] Integer,
/// // [Sort_Order] Integer,
/// // [Date_Time] Integer,
/// // [ID_Type] Integer,
/// // [Top_HowMany] Integer,
/// // [Num_RelayNames] Integer,
/// // [Show_StartTimes] Boolean NOT NULL,
/// // [Incl_Records] Boolean NOT NULL,
/// // [Incl_TimeStds] Boolean NOT NULL,
/// // [Incl_QualTimes] Boolean NOT NULL,
/// // [Incl_EvtComments] Boolean NOT NULL,
/// // [Line_ForResults] Boolean NOT NULL,
/// // [Incl_NoEntries] Boolean NOT NULL,
/// // [Incl_PriorResults] Boolean NOT NULL,
/// // [Incl_Rnd1Alt] Boolean NOT NULL,
/// // [Incl_EmptyLanes] Boolean NOT NULL,
/// // [Show_SeedTimes] Boolean NOT NULL,
/// // [Sep_ABFinal] Boolean NOT NULL,
/// // [OneEvent_PerPage] Boolean NOT NULL,
/// // [Ref_Format] Boolean NOT NULL,
/// // [OneHeat_PerPage] Boolean NOT NULL,
/// // [Dbl_Space] Boolean NOT NULL,
/// // [Show_Ranks] Boolean NOT NULL,
/// // [MultiAge_Split] Boolean NOT NULL,
/// // [Incl_QualifiedAlts] Boolean NOT NULL,
/// // [ScrAltExhSpec_Filters] Integer,
/// // [Incl_Scratches] Boolean NOT NULL,
/// // [Ignore_Psych] Boolean NOT NULL,
/// // [Sess_Row] Long Integer,
/// // [Evt_Gender] Integer,
/// // [Evt_LowAge] Integer,
/// // [Evt_HighAge] Integer,
/// // [Team_Abbr] Text (18),
/// // [Evt_Round] Integer,
/// // [Evt_IndivOrRelay] Integer,
/// // [Report_Type] Integer,
/// // [Sort_OrderAthAge] Integer,
/// // [Incl_AthNoEntries] Boolean NOT NULL,
/// // [Incl_AthNoEntries4Col] Boolean NOT NULL,
/// // [AddApost_ClassYear] Boolean NOT NULL,
/// // [Incl_CompNo] Boolean NOT NULL,
/// // [Incl_CompNo4Col] Boolean NOT NULL,
/// // [AddrSort_ByTeam] Boolean NOT NULL,
/// // [AddrSort_ByZip] Boolean NOT NULL,
/// // [Incl_ScrInEntryCount] Boolean NOT NULL,
/// // [Incl_AltInEntryCount] Boolean NOT NULL,
/// // [Incl_BirthDate] Boolean NOT NULL,
/// // [Incl_TeamAddr] Boolean NOT NULL,
/// // [Incl_Coaches] Boolean NOT NULL,
/// // [AthUseAbbr_ForTeam] Boolean NOT NULL,
/// // [Div_Abbr] Text (60),
/// // [Report_Format] Integer,
/// // [Incl_HeatLane] Boolean NOT NULL,
/// // [Add_LineSpace] Boolean NOT NULL,
/// // [Incl_RegID] Boolean NOT NULL,
/// // [Show_CheckIn] Boolean NOT NULL,
/// // [NumAth_PerPage] Integer,
/// // [Splits_Choice] Integer,
/// // [Results_ByHeat] Boolean NOT NULL,
/// // [Page_Break] Boolean NOT NULL,
/// // [Incl_SpecPts] Boolean NOT NULL,
/// // [Incl_TimeTrials] Boolean NOT NULL,
/// // [Incl_NoShows] Boolean NOT NULL,
/// // [Incl_TeamPts] Boolean NOT NULL,
/// // [Low_Lane] Integer,
/// // [High_Lane] Integer,
/// // [Score_Female] Boolean NOT NULL,
/// // [Score_Male] Boolean NOT NULL,
/// // [Score_Combined] Boolean NOT NULL,
/// // [Score_CombinedBoth] Boolean NOT NULL,
/// // [BAG_CATS] Boolean NOT NULL,
/// // [Flat_HTML] Boolean NOT NULL,
/// // [DotMatrix_LabelChoice] Text (80),
/// // [Laser_LabelChoice] Text (80),
/// // [Incl_TeamScore] Boolean NOT NULL,
/// // [Incl_FemaleTeamScore] Boolean NOT NULL,
/// // [Incl_MaleTeamScore] Boolean NOT NULL,
/// // [CombineDivisions_ForTeamPoints] Boolean NOT NULL,
/// // [Incl_DQCodes] Boolean NOT NULL,
/// // [Incl_ReactionTimes] Boolean NOT NULL,
/// // [Incl_Backups] Boolean NOT NULL,
/// // [UseLaser_Label] Integer,
/// // [UseDQTimesfor_CombinedEvents] Boolean NOT NULL,
/// // [Incl_EntryTimes] Boolean NOT NULL,
/// // [Incl_PriorResultsSplits] Boolean NOT NULL,
/// // [Incl_LogosinFooter] Boolean NOT NULL,
/// // [LaneTimer_Pads] Boolean NOT NULL,
/// // [UseBestTimes_AllRounds] Boolean NOT NULL,
/// // [Qual_Club] Boolean NOT NULL,
/// // [QualClub_Scorers] Boolean NOT NULL,
/// // [PtBreakOut_HighPt] Boolean NOT NULL,
/// // [RTF_export] Boolean NOT NULL,
/// // [Results_ByHeatInclLane] Boolean NOT NULL,
/// // [NoShows_Only] Boolean NOT NULL,
/// // [Scratches_Only] Boolean NOT NULL,
/// // [DQs_Only] Boolean NOT NULL,
/// // [Combined_BothMustScore] Boolean NOT NULL
/// // );

public class Memorizedreports(string memName, short? memType, long? memPtr, short? numColumns, short? sortOrder, short? dateTime, short? iDType, short? topHowMany, short? numRelayNames, bool showStartTimes, bool inclRecords, bool inclTimeStds, bool inclQualTimes, bool inclEvtComments, bool lineForResults, bool inclNoEntries, bool inclPriorResults, bool inclRnd1Alt, bool inclEmptyLanes, bool showSeedTimes, bool sepABFinal, bool oneEventPerPage, bool refFormat, bool oneHeatPerPage, bool dblSpace, bool showRanks, bool multiAgeSplit, bool inclQualifiedAlts, short? scrAltExhSpecFilters, bool inclScratches, bool ignorePsych, long? sessRow, short? evtGender, short? evtLowAge, short? evtHighAge, string teamAbbr, short? evtRound, short? evtIndivOrRelay, short? reportType, short? sortOrderAthAge, bool inclAthNoEntries, bool inclAthNoEntries4Col, bool addApostClassYear, bool inclCompNo, bool inclCompNo4Col, bool addrSortByTeam, bool addrSortByZip, bool inclScrInEntryCount, bool inclAltInEntryCount, bool inclBirthDate, bool inclTeamAddr, bool inclCoaches, bool athUseAbbrForTeam, string divAbbr, short? reportFormat, bool inclHeatLane, bool addLineSpace, bool inclRegID, bool showCheckIn, short? numAthPerPage, short? splitsChoice, bool resultsByHeat, bool pageBreak, bool inclSpecPts, bool inclTimeTrials, bool inclNoShows, bool inclTeamPts, short? lowLane, short? highLane, bool scoreFemale, bool scoreMale, bool scoreCombined, bool scoreCombinedBoth, bool bag_cats, bool flatHTML, string dotMatrixLabelChoice, string laserLabelChoice, bool inclTeamScore, bool inclFemaleTeamScore, bool inclMaleTeamScore, bool combineDivisionsForTeamPoints, bool inclDQCodes, bool inclReactionTimes, bool inclBackups, short? useLaserLabel, bool useDQTimesforCombinedEvents, bool inclEntryTimes, bool inclPriorResultsSplits, bool inclLogosinFooter, bool laneTimerPads, bool useBestTimesAllRounds, bool qualClub, bool qualClubScorers, bool ptBreakOutHighPt, bool rTFExport, bool resultsByHeatInclLane, bool noShowsOnly, bool scratchesOnly, bool dQsOnly, bool combinedBothMustScore )
{
static public List<Memorizedreports> Get(OdbcConnection connection)
{
  var collection = new List<Memorizedreports>();
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
  var arg0 = reader.GetTextReader(0).ReadLine(); /* Mem_Name nullable false*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Mem_Type nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Mem_Ptr nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Num_Columns nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* Sort_Order nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Date_Time nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* ID_Type nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Top_HowMany nullable true*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* Num_RelayNames nullable true*/
  var arg9 = reader.GetBoolean(9); /* Show_StartTimes nullable false*/
  var arg10 = reader.GetBoolean(10); /* Incl_Records nullable false*/
  var arg11 = reader.GetBoolean(11); /* Incl_TimeStds nullable false*/
  var arg12 = reader.GetBoolean(12); /* Incl_QualTimes nullable false*/
  var arg13 = reader.GetBoolean(13); /* Incl_EvtComments nullable false*/
  var arg14 = reader.GetBoolean(14); /* Line_ForResults nullable false*/
  var arg15 = reader.GetBoolean(15); /* Incl_NoEntries nullable false*/
  var arg16 = reader.GetBoolean(16); /* Incl_PriorResults nullable false*/
  var arg17 = reader.GetBoolean(17); /* Incl_Rnd1Alt nullable false*/
  var arg18 = reader.GetBoolean(18); /* Incl_EmptyLanes nullable false*/
  var arg19 = reader.GetBoolean(19); /* Show_SeedTimes nullable false*/
  var arg20 = reader.GetBoolean(20); /* Sep_ABFinal nullable false*/
  var arg21 = reader.GetBoolean(21); /* OneEvent_PerPage nullable false*/
  var arg22 = reader.GetBoolean(22); /* Ref_Format nullable false*/
  var arg23 = reader.GetBoolean(23); /* OneHeat_PerPage nullable false*/
  var arg24 = reader.GetBoolean(24); /* Dbl_Space nullable false*/
  var arg25 = reader.GetBoolean(25); /* Show_Ranks nullable false*/
  var arg26 = reader.GetBoolean(26); /* MultiAge_Split nullable false*/
  var arg27 = reader.GetBoolean(27); /* Incl_QualifiedAlts nullable false*/
  var arg28 = reader.IsDBNull(28) ? (short?)null :reader.GetInt16(28); /* ScrAltExhSpec_Filters nullable true*/
  var arg29 = reader.GetBoolean(29); /* Incl_Scratches nullable false*/
  var arg30 = reader.GetBoolean(30); /* Ignore_Psych nullable false*/
  var arg31 = reader.IsDBNull(31) ? (long?)null :reader.GetInt32(31); /* Sess_Row nullable true*/
  var arg32 = reader.IsDBNull(32) ? (short?)null :reader.GetInt16(32); /* Evt_Gender nullable true*/
  var arg33 = reader.IsDBNull(33) ? (short?)null :reader.GetInt16(33); /* Evt_LowAge nullable true*/
  var arg34 = reader.IsDBNull(34) ? (short?)null :reader.GetInt16(34); /* Evt_HighAge nullable true*/
  var arg35 = reader.GetTextReader(35).ReadLine(); /* Team_Abbr nullable false*/
  var arg36 = reader.IsDBNull(36) ? (short?)null :reader.GetInt16(36); /* Evt_Round nullable true*/
  var arg37 = reader.IsDBNull(37) ? (short?)null :reader.GetInt16(37); /* Evt_IndivOrRelay nullable true*/
  var arg38 = reader.IsDBNull(38) ? (short?)null :reader.GetInt16(38); /* Report_Type nullable true*/
  var arg39 = reader.IsDBNull(39) ? (short?)null :reader.GetInt16(39); /* Sort_OrderAthAge nullable true*/
  var arg40 = reader.GetBoolean(40); /* Incl_AthNoEntries nullable false*/
  var arg41 = reader.GetBoolean(41); /* Incl_AthNoEntries4Col nullable false*/
  var arg42 = reader.GetBoolean(42); /* AddApost_ClassYear nullable false*/
  var arg43 = reader.GetBoolean(43); /* Incl_CompNo nullable false*/
  var arg44 = reader.GetBoolean(44); /* Incl_CompNo4Col nullable false*/
  var arg45 = reader.GetBoolean(45); /* AddrSort_ByTeam nullable false*/
  var arg46 = reader.GetBoolean(46); /* AddrSort_ByZip nullable false*/
  var arg47 = reader.GetBoolean(47); /* Incl_ScrInEntryCount nullable false*/
  var arg48 = reader.GetBoolean(48); /* Incl_AltInEntryCount nullable false*/
  var arg49 = reader.GetBoolean(49); /* Incl_BirthDate nullable false*/
  var arg50 = reader.GetBoolean(50); /* Incl_TeamAddr nullable false*/
  var arg51 = reader.GetBoolean(51); /* Incl_Coaches nullable false*/
  var arg52 = reader.GetBoolean(52); /* AthUseAbbr_ForTeam nullable false*/
  var arg53 = reader.GetTextReader(53).ReadLine(); /* Div_Abbr nullable false*/
  var arg54 = reader.IsDBNull(54) ? (short?)null :reader.GetInt16(54); /* Report_Format nullable true*/
  var arg55 = reader.GetBoolean(55); /* Incl_HeatLane nullable false*/
  var arg56 = reader.GetBoolean(56); /* Add_LineSpace nullable false*/
  var arg57 = reader.GetBoolean(57); /* Incl_RegID nullable false*/
  var arg58 = reader.GetBoolean(58); /* Show_CheckIn nullable false*/
  var arg59 = reader.IsDBNull(59) ? (short?)null :reader.GetInt16(59); /* NumAth_PerPage nullable true*/
  var arg60 = reader.IsDBNull(60) ? (short?)null :reader.GetInt16(60); /* Splits_Choice nullable true*/
  var arg61 = reader.GetBoolean(61); /* Results_ByHeat nullable false*/
  var arg62 = reader.GetBoolean(62); /* Page_Break nullable false*/
  var arg63 = reader.GetBoolean(63); /* Incl_SpecPts nullable false*/
  var arg64 = reader.GetBoolean(64); /* Incl_TimeTrials nullable false*/
  var arg65 = reader.GetBoolean(65); /* Incl_NoShows nullable false*/
  var arg66 = reader.GetBoolean(66); /* Incl_TeamPts nullable false*/
  var arg67 = reader.IsDBNull(67) ? (short?)null :reader.GetInt16(67); /* Low_Lane nullable true*/
  var arg68 = reader.IsDBNull(68) ? (short?)null :reader.GetInt16(68); /* High_Lane nullable true*/
  var arg69 = reader.GetBoolean(69); /* Score_Female nullable false*/
  var arg70 = reader.GetBoolean(70); /* Score_Male nullable false*/
  var arg71 = reader.GetBoolean(71); /* Score_Combined nullable false*/
  var arg72 = reader.GetBoolean(72); /* Score_CombinedBoth nullable false*/
  var arg73 = reader.GetBoolean(73); /* BAG_CATS nullable false*/
  var arg74 = reader.GetBoolean(74); /* Flat_HTML nullable false*/
  var arg75 = reader.GetTextReader(75).ReadLine(); /* DotMatrix_LabelChoice nullable false*/
  var arg76 = reader.GetTextReader(76).ReadLine(); /* Laser_LabelChoice nullable false*/
  var arg77 = reader.GetBoolean(77); /* Incl_TeamScore nullable false*/
  var arg78 = reader.GetBoolean(78); /* Incl_FemaleTeamScore nullable false*/
  var arg79 = reader.GetBoolean(79); /* Incl_MaleTeamScore nullable false*/
  var arg80 = reader.GetBoolean(80); /* CombineDivisions_ForTeamPoints nullable false*/
  var arg81 = reader.GetBoolean(81); /* Incl_DQCodes nullable false*/
  var arg82 = reader.GetBoolean(82); /* Incl_ReactionTimes nullable false*/
  var arg83 = reader.GetBoolean(83); /* Incl_Backups nullable false*/
  var arg84 = reader.IsDBNull(84) ? (short?)null :reader.GetInt16(84); /* UseLaser_Label nullable true*/
  var arg85 = reader.GetBoolean(85); /* UseDQTimesfor_CombinedEvents nullable false*/
  var arg86 = reader.GetBoolean(86); /* Incl_EntryTimes nullable false*/
  var arg87 = reader.GetBoolean(87); /* Incl_PriorResultsSplits nullable false*/
  var arg88 = reader.GetBoolean(88); /* Incl_LogosinFooter nullable false*/
  var arg89 = reader.GetBoolean(89); /* LaneTimer_Pads nullable false*/
  var arg90 = reader.GetBoolean(90); /* UseBestTimes_AllRounds nullable false*/
  var arg91 = reader.GetBoolean(91); /* Qual_Club nullable false*/
  var arg92 = reader.GetBoolean(92); /* QualClub_Scorers nullable false*/
  var arg93 = reader.GetBoolean(93); /* PtBreakOut_HighPt nullable false*/
  var arg94 = reader.GetBoolean(94); /* RTF_export nullable false*/
  var arg95 = reader.GetBoolean(95); /* Results_ByHeatInclLane nullable false*/
  var arg96 = reader.GetBoolean(96); /* NoShows_Only nullable false*/
  var arg97 = reader.GetBoolean(97); /* Scratches_Only nullable false*/
  var arg98 = reader.GetBoolean(98); /* DQs_Only nullable false*/
  var arg99 = reader.GetBoolean(99); /* Combined_BothMustScore nullable false*/
      collection.Add( new Memorizedreports(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99));
    }
  }
  return collection;
}
  // Properties
  public string MemName{ get; } = memName;
  public short? MemType{ get; } = memType;
  public long? MemPtr{ get; } = memPtr;
  public short? NumColumns{ get; } = numColumns;
  public short? SortOrder{ get; } = sortOrder;
  public short? DateTime{ get; } = dateTime;
  public short? IDType{ get; } = iDType;
  public short? TopHowMany{ get; } = topHowMany;
  public short? NumRelayNames{ get; } = numRelayNames;
  public bool ShowStartTimes{ get; } = showStartTimes;
  public bool InclRecords{ get; } = inclRecords;
  public bool InclTimeStds{ get; } = inclTimeStds;
  public bool InclQualTimes{ get; } = inclQualTimes;
  public bool InclEvtComments{ get; } = inclEvtComments;
  public bool LineForResults{ get; } = lineForResults;
  public bool InclNoEntries{ get; } = inclNoEntries;
  public bool InclPriorResults{ get; } = inclPriorResults;
  public bool InclRnd1Alt{ get; } = inclRnd1Alt;
  public bool InclEmptyLanes{ get; } = inclEmptyLanes;
  public bool ShowSeedTimes{ get; } = showSeedTimes;
  public bool SepABFinal{ get; } = sepABFinal;
  public bool OneEventPerPage{ get; } = oneEventPerPage;
  public bool RefFormat{ get; } = refFormat;
  public bool OneHeatPerPage{ get; } = oneHeatPerPage;
  public bool DblSpace{ get; } = dblSpace;
  public bool ShowRanks{ get; } = showRanks;
  public bool MultiAgeSplit{ get; } = multiAgeSplit;
  public bool InclQualifiedAlts{ get; } = inclQualifiedAlts;
  public short? ScrAltExhSpecFilters{ get; } = scrAltExhSpecFilters;
  public bool InclScratches{ get; } = inclScratches;
  public bool IgnorePsych{ get; } = ignorePsych;
  public long? SessRow{ get; } = sessRow;
  public short? EvtGender{ get; } = evtGender;
  public short? EvtLowAge{ get; } = evtLowAge;
  public short? EvtHighAge{ get; } = evtHighAge;
  public string TeamAbbr{ get; } = teamAbbr;
  public short? EvtRound{ get; } = evtRound;
  public short? EvtIndivOrRelay{ get; } = evtIndivOrRelay;
  public short? ReportType{ get; } = reportType;
  public short? SortOrderAthAge{ get; } = sortOrderAthAge;
  public bool InclAthNoEntries{ get; } = inclAthNoEntries;
  public bool InclAthNoEntries4Col{ get; } = inclAthNoEntries4Col;
  public bool AddApostClassYear{ get; } = addApostClassYear;
  public bool InclCompNo{ get; } = inclCompNo;
  public bool InclCompNo4Col{ get; } = inclCompNo4Col;
  public bool AddrSortByTeam{ get; } = addrSortByTeam;
  public bool AddrSortByZip{ get; } = addrSortByZip;
  public bool InclScrInEntryCount{ get; } = inclScrInEntryCount;
  public bool InclAltInEntryCount{ get; } = inclAltInEntryCount;
  public bool InclBirthDate{ get; } = inclBirthDate;
  public bool InclTeamAddr{ get; } = inclTeamAddr;
  public bool InclCoaches{ get; } = inclCoaches;
  public bool AthUseAbbrForTeam{ get; } = athUseAbbrForTeam;
  public string DivAbbr{ get; } = divAbbr;
  public short? ReportFormat{ get; } = reportFormat;
  public bool InclHeatLane{ get; } = inclHeatLane;
  public bool AddLineSpace{ get; } = addLineSpace;
  public bool InclRegID{ get; } = inclRegID;
  public bool ShowCheckIn{ get; } = showCheckIn;
  public short? NumAthPerPage{ get; } = numAthPerPage;
  public short? SplitsChoice{ get; } = splitsChoice;
  public bool ResultsByHeat{ get; } = resultsByHeat;
  public bool PageBreak{ get; } = pageBreak;
  public bool InclSpecPts{ get; } = inclSpecPts;
  public bool InclTimeTrials{ get; } = inclTimeTrials;
  public bool InclNoShows{ get; } = inclNoShows;
  public bool InclTeamPts{ get; } = inclTeamPts;
  public short? LowLane{ get; } = lowLane;
  public short? HighLane{ get; } = highLane;
  public bool ScoreFemale{ get; } = scoreFemale;
  public bool ScoreMale{ get; } = scoreMale;
  public bool ScoreCombined{ get; } = scoreCombined;
  public bool ScoreCombinedBoth{ get; } = scoreCombinedBoth;
  public bool Bag_cats{ get; } = bag_cats;
  public bool FlatHTML{ get; } = flatHTML;
  public string DotMatrixLabelChoice{ get; } = dotMatrixLabelChoice;
  public string LaserLabelChoice{ get; } = laserLabelChoice;
  public bool InclTeamScore{ get; } = inclTeamScore;
  public bool InclFemaleTeamScore{ get; } = inclFemaleTeamScore;
  public bool InclMaleTeamScore{ get; } = inclMaleTeamScore;
  public bool CombineDivisionsForTeamPoints{ get; } = combineDivisionsForTeamPoints;
  public bool InclDQCodes{ get; } = inclDQCodes;
  public bool InclReactionTimes{ get; } = inclReactionTimes;
  public bool InclBackups{ get; } = inclBackups;
  public short? UseLaserLabel{ get; } = useLaserLabel;
  public bool UseDQTimesforCombinedEvents{ get; } = useDQTimesforCombinedEvents;
  public bool InclEntryTimes{ get; } = inclEntryTimes;
  public bool InclPriorResultsSplits{ get; } = inclPriorResultsSplits;
  public bool InclLogosinFooter{ get; } = inclLogosinFooter;
  public bool LaneTimerPads{ get; } = laneTimerPads;
  public bool UseBestTimesAllRounds{ get; } = useBestTimesAllRounds;
  public bool QualClub{ get; } = qualClub;
  public bool QualClubScorers{ get; } = qualClubScorers;
  public bool PtBreakOutHighPt{ get; } = ptBreakOutHighPt;
  public bool RTFExport{ get; } = rTFExport;
  public bool ResultsByHeatInclLane{ get; } = resultsByHeatInclLane;
  public bool NoShowsOnly{ get; } = noShowsOnly;
  public bool ScratchesOnly{ get; } = scratchesOnly;
  public bool DQsOnly{ get; } = dQsOnly;
  public bool CombinedBothMustScore{ get; } = combinedBothMustScore;
}
}
}
