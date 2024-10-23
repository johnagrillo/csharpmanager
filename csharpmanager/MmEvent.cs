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
/// CREATE TABLE [Event]
/// (
/// [Event_no] Integer,
/// [Event_ltr] Text (2),
/// [Event_ptr] Long Integer,
/// [Ind_rel] Text (2),
/// [Event_sex] Text (2),
/// [Event_gender] Text (2),
/// [Event_dist] Single,
/// [Event_stroke] Text (2),
/// [Low_age] Integer,
/// [High_Age] Integer,
/// [Multi_age] Boolean NOT NULL,
/// [Event_stat] Text (2),
/// [Event_rounds] Integer,
/// [Num_prelanes] Integer,
/// [Num_finlanes] Integer,
/// [Heats_infinal] Text (2),
/// [Heats_insemi] Integer,
/// [Std_lanes] Text (2),
/// [Auto_seed] Boolean NOT NULL,
/// [Twoperlane_req] Boolean NOT NULL,
/// [Preheat_order] Text (2),
/// [Finheat_order] Text (2),
/// [Score_event] Boolean NOT NULL,
/// [Div_no] Integer,
/// [Relay_size] Integer,
/// [Comm_1] Text (72),
/// [Comm_2] Text (72),
/// [Comm_3] Text (72),
/// [Comm_4] Text (72),
/// [Entry_fee] Currency,
/// [Is_locked] Boolean NOT NULL,
/// [Locked_by] Text (40),
/// [Event_Type] Text (2),
/// [Locked_list] Text (24),
/// [Event_note] Text (40),
/// [Suppress_stroke] Boolean NOT NULL,
/// [Custom_ABCFinal] Boolean NOT NULL,
/// [Num_dives] Integer,
/// [Num_HeatsInFinal] Integer,
/// [Multiage_SuperFinal] Boolean NOT NULL,
/// [Finals_LanesVary] Boolean NOT NULL,
/// [Finals_LanesVaryOrder] Text (36),
/// [ABCfinal_order] Text (12),
/// [ABC_Style] Boolean NOT NULL,
/// [PrelimsAs_ExtendedFinal] Boolean NOT NULL,
/// [Num_LanesInBestHeatsTimedFinal] Integer,
/// [Num_BestHeatsTimedFinal] Integer,
/// [TimedFinal_LanesVary] Boolean NOT NULL,
/// [ScoreTimedFinal_asABC] Boolean NOT NULL,
/// [Num_HeatsInTimedFinalToScore] Integer,
/// [Pads_BothEnds] Boolean NOT NULL,
/// [Multiage_SuperSeed] Boolean NOT NULL,
/// [Suppress_distance] Boolean NOT NULL,
/// [Fin_AwardsPrinted] Boolean NOT NULL,
/// [Pre_AwardsPrinted] Boolean NOT NULL,
/// [Sem_AwardsPrinted] Boolean NOT NULL,
/// [FastTimeStd_Abbr] Text (8),
/// [SlowTimeStd_Abbr] Text (8),
/// [SuperFinal_ElimOldAgeGrp] Boolean NOT NULL,
/// [SeedMultiAge_OldToYoung] Boolean NOT NULL,
/// [Multi_ageScnd] Boolean NOT NULL,
/// [Num_RelayLegs] Integer,
/// [Pads_BothEndsFinals] Boolean NOT NULL,
/// [Checkin_starttime] Long Integer,
/// [Checkin_endtime] Long Integer,
/// [Checkin_startdate] DateTime,
/// [Checkin_enddate] DateTime,
/// [Num_semlanes] Integer,
/// [EvtMaxAgeFor_CFinal] Integer,
/// [EvtMaxAgeNumHeats_CFinal] Integer,
/// [fin_actualstarttime] Long Integer,
/// [sem_actualstarttime] Long Integer,
/// [pre_actualstarttime] Long Integer,
/// [Swimoff_SourcePtr] Long Integer,
/// [Swimoff_SourceRndLtr] Text (2),
/// [Swimoff_Created] DateTime,
/// [Multiage_BestRestFinal] Boolean NOT NULL
/// );

public class MmEvent 
{
List<MmEvent> get(OdbcConnection connection)
{
  var collection = new List<MmEvent>();
  string query = "select * from Event";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* Event_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Event_ltr */
      var arg2 = reader.GetInt64(3); /* Event_ptr */
      var arg3 = reader.GetTextReader(4).ToString(); /* Ind_rel */
      var arg4 = reader.GetTextReader(5).ToString(); /* Event_sex */
      var arg5 = reader.GetTextReader(6).ToString(); /* Event_gender */
      var arg6 = reader.GetFloat(7); /* Event_dist */
      var arg7 = reader.GetTextReader(8).ToString(); /* Event_stroke */
      var arg8 = reader.GetInt16(9); /* Low_age */
      var arg9 = reader.GetInt16(10); /* High_Age */
      var arg10 = reader.GetBoolean(11); /* Multi_age */
      var arg11 = reader.GetTextReader(12).ToString(); /* Event_stat */
      var arg12 = reader.GetInt16(13); /* Event_rounds */
      var arg13 = reader.GetInt16(14); /* Num_prelanes */
      var arg14 = reader.GetInt16(15); /* Num_finlanes */
      var arg15 = reader.GetTextReader(16).ToString(); /* Heats_infinal */
      var arg16 = reader.GetInt16(17); /* Heats_insemi */
      var arg17 = reader.GetTextReader(18).ToString(); /* Std_lanes */
      var arg18 = reader.GetBoolean(19); /* Auto_seed */
      var arg19 = reader.GetBoolean(20); /* Twoperlane_req */
      var arg20 = reader.GetTextReader(21).ToString(); /* Preheat_order */
      var arg21 = reader.GetTextReader(22).ToString(); /* Finheat_order */
      var arg22 = reader.GetBoolean(23); /* Score_event */
      var arg23 = reader.GetInt16(24); /* Div_no */
      var arg24 = reader.GetInt16(25); /* Relay_size */
      var arg25 = reader.GetTextReader(26).ToString(); /* Comm_1 */
      var arg26 = reader.GetTextReader(27).ToString(); /* Comm_2 */
      var arg27 = reader.GetTextReader(28).ToString(); /* Comm_3 */
      var arg28 = reader.GetTextReader(29).ToString(); /* Comm_4 */
      var arg29 = reader.GetDecimal(30); /* Entry_fee */
      var arg30 = reader.GetBoolean(31); /* Is_locked */
      var arg31 = reader.GetTextReader(32).ToString(); /* Locked_by */
      var arg32 = reader.GetTextReader(33).ToString(); /* Event_Type */
      var arg33 = reader.GetTextReader(34).ToString(); /* Locked_list */
      var arg34 = reader.GetTextReader(35).ToString(); /* Event_note */
      var arg35 = reader.GetBoolean(36); /* Suppress_stroke */
      var arg36 = reader.GetBoolean(37); /* Custom_ABCFinal */
      var arg37 = reader.GetInt16(38); /* Num_dives */
      var arg38 = reader.GetInt16(39); /* Num_HeatsInFinal */
      var arg39 = reader.GetBoolean(40); /* Multiage_SuperFinal */
      var arg40 = reader.GetBoolean(41); /* Finals_LanesVary */
      var arg41 = reader.GetTextReader(42).ToString(); /* Finals_LanesVaryOrder */
      var arg42 = reader.GetTextReader(43).ToString(); /* ABCfinal_order */
      var arg43 = reader.GetBoolean(44); /* ABC_Style */
      var arg44 = reader.GetBoolean(45); /* PrelimsAs_ExtendedFinal */
      var arg45 = reader.GetInt16(46); /* Num_LanesInBestHeatsTimedFinal */
      var arg46 = reader.GetInt16(47); /* Num_BestHeatsTimedFinal */
      var arg47 = reader.GetBoolean(48); /* TimedFinal_LanesVary */
      var arg48 = reader.GetBoolean(49); /* ScoreTimedFinal_asABC */
      var arg49 = reader.GetInt16(50); /* Num_HeatsInTimedFinalToScore */
      var arg50 = reader.GetBoolean(51); /* Pads_BothEnds */
      var arg51 = reader.GetBoolean(52); /* Multiage_SuperSeed */
      var arg52 = reader.GetBoolean(53); /* Suppress_distance */
      var arg53 = reader.GetBoolean(54); /* Fin_AwardsPrinted */
      var arg54 = reader.GetBoolean(55); /* Pre_AwardsPrinted */
      var arg55 = reader.GetBoolean(56); /* Sem_AwardsPrinted */
      var arg56 = reader.GetTextReader(57).ToString(); /* FastTimeStd_Abbr */
      var arg57 = reader.GetTextReader(58).ToString(); /* SlowTimeStd_Abbr */
      var arg58 = reader.GetBoolean(59); /* SuperFinal_ElimOldAgeGrp */
      var arg59 = reader.GetBoolean(60); /* SeedMultiAge_OldToYoung */
      var arg60 = reader.GetBoolean(61); /* Multi_ageScnd */
      var arg61 = reader.GetInt16(62); /* Num_RelayLegs */
      var arg62 = reader.GetBoolean(63); /* Pads_BothEndsFinals */
      var arg63 = reader.GetInt64(64); /* Checkin_starttime */
      var arg64 = reader.GetInt64(65); /* Checkin_endtime */
      var arg65 = reader.GetDateTime(66); /* Checkin_startdate */
      var arg66 = reader.GetDateTime(67); /* Checkin_enddate */
      var arg67 = reader.GetInt16(68); /* Num_semlanes */
      var arg68 = reader.GetInt16(69); /* EvtMaxAgeFor_CFinal */
      var arg69 = reader.GetInt16(70); /* EvtMaxAgeNumHeats_CFinal */
      var arg70 = reader.GetInt64(71); /* fin_actualstarttime */
      var arg71 = reader.GetInt64(72); /* sem_actualstarttime */
      var arg72 = reader.GetInt64(73); /* pre_actualstarttime */
      var arg73 = reader.GetInt64(74); /* Swimoff_SourcePtr */
      var arg74 = reader.GetTextReader(75).ToString(); /* Swimoff_SourceRndLtr */
      var arg75 = reader.GetDateTime(76); /* Swimoff_Created */
      var arg76 = reader.GetBoolean(77); /* Multiage_BestRestFinal */
      collection.Add( new MmEvent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76));
    }
  }
  return collection;
}
  // Properties
  public short EventNo{ get; }
  public string EventLtr{ get; }
  public long EventPtr{ get; }
  public string IndRel{ get; }
  public string EventSex{ get; }
  public string EventGender{ get; }
  public float EventDist{ get; }
  public string EventStroke{ get; }
  public short LowAge{ get; }
  public short HighAge{ get; }
  public bool MultiAge{ get; }
  public string EventStat{ get; }
  public short EventRounds{ get; }
  public short NumPrelanes{ get; }
  public short NumFinlanes{ get; }
  public string HeatsInfinal{ get; }
  public short HeatsInsemi{ get; }
  public string StdLanes{ get; }
  public bool AutoSeed{ get; }
  public bool TwoperlaneReq{ get; }
  public string PreheatOrder{ get; }
  public string FinheatOrder{ get; }
  public bool ScoreEvent{ get; }
  public short DivNo{ get; }
  public short RelaySize{ get; }
  public string Comm1{ get; }
  public string Comm2{ get; }
  public string Comm3{ get; }
  public string Comm4{ get; }
  public decimal EntryFee{ get; }
  public bool IsLocked{ get; }
  public string LockedBy{ get; }
  public string EventType{ get; }
  public string LockedList{ get; }
  public string EventNote{ get; }
  public bool SuppressStroke{ get; }
  public bool CustomABCFinal{ get; }
  public short NumDives{ get; }
  public short NumHeatsInFinal{ get; }
  public bool MultiageSuperFinal{ get; }
  public bool FinalsLanesVary{ get; }
  public string FinalsLanesVaryOrder{ get; }
  public string ABCfinalOrder{ get; }
  public bool ABCStyle{ get; }
  public bool PrelimsAsExtendedFinal{ get; }
  public short NumLanesInBestHeatsTimedFinal{ get; }
  public short NumBestHeatsTimedFinal{ get; }
  public bool TimedFinalLanesVary{ get; }
  public bool ScoreTimedFinalAsABC{ get; }
  public short NumHeatsInTimedFinalToScore{ get; }
  public bool PadsBothEnds{ get; }
  public bool MultiageSuperSeed{ get; }
  public bool SuppressDistance{ get; }
  public bool FinAwardsPrinted{ get; }
  public bool PreAwardsPrinted{ get; }
  public bool SemAwardsPrinted{ get; }
  public string FastTimeStdAbbr{ get; }
  public string SlowTimeStdAbbr{ get; }
  public bool SuperFinalElimOldAgeGrp{ get; }
  public bool SeedMultiAgeOldToYoung{ get; }
  public bool MultiAgeScnd{ get; }
  public short NumRelayLegs{ get; }
  public bool PadsBothEndsFinals{ get; }
  public long CheckinStarttime{ get; }
  public long CheckinEndtime{ get; }
  public DateTime CheckinStartdate{ get; }
  public DateTime CheckinEnddate{ get; }
  public short NumSemlanes{ get; }
  public short EvtMaxAgeForCFinal{ get; }
  public short EvtMaxAgeNumHeatsCFinal{ get; }
  public long Fin_actualstarttime{ get; }
  public long Sem_actualstarttime{ get; }
  public long Pre_actualstarttime{ get; }
  public long SwimoffSourcePtr{ get; }
  public string SwimoffSourceRndLtr{ get; }
  public DateTime SwimoffCreated{ get; }
  public bool MultiageBestRestFinal{ get; }
  // Constructor
  MmEvent(short eventNo, string eventLtr, long eventPtr, string indRel, string eventSex, string eventGender, float eventDist, string eventStroke, short lowAge, short highAge, bool multiAge, string eventStat, short eventRounds, short numPrelanes, short numFinlanes, string heatsInfinal, short heatsInsemi, string stdLanes, bool autoSeed, bool twoperlaneReq, string preheatOrder, string finheatOrder, bool scoreEvent, short divNo, short relaySize, string comm1, string comm2, string comm3, string comm4, decimal entryFee, bool isLocked, string lockedBy, string eventType, string lockedList, string eventNote, bool suppressStroke, bool customABCFinal, short numDives, short numHeatsInFinal, bool multiageSuperFinal, bool finalsLanesVary, string finalsLanesVaryOrder, string aBCfinalOrder, bool aBCStyle, bool prelimsAsExtendedFinal, short numLanesInBestHeatsTimedFinal, short numBestHeatsTimedFinal, bool timedFinalLanesVary, bool scoreTimedFinalAsABC, short numHeatsInTimedFinalToScore, bool padsBothEnds, bool multiageSuperSeed, bool suppressDistance, bool finAwardsPrinted, bool preAwardsPrinted, bool semAwardsPrinted, string fastTimeStdAbbr, string slowTimeStdAbbr, bool superFinalElimOldAgeGrp, bool seedMultiAgeOldToYoung, bool multiAgeScnd, short numRelayLegs, bool padsBothEndsFinals, long checkinStarttime, long checkinEndtime, DateTime checkinStartdate, DateTime checkinEnddate, short numSemlanes, short evtMaxAgeForCFinal, short evtMaxAgeNumHeatsCFinal, long fin_actualstarttime, long sem_actualstarttime, long pre_actualstarttime, long swimoffSourcePtr, string swimoffSourceRndLtr, DateTime swimoffCreated, bool multiageBestRestFinal )
  {
    EventNo = eventNo;
    EventLtr = eventLtr;
    EventPtr = eventPtr;
    IndRel = indRel;
    EventSex = eventSex;
    EventGender = eventGender;
    EventDist = eventDist;
    EventStroke = eventStroke;
    LowAge = lowAge;
    HighAge = highAge;
    MultiAge = multiAge;
    EventStat = eventStat;
    EventRounds = eventRounds;
    NumPrelanes = numPrelanes;
    NumFinlanes = numFinlanes;
    HeatsInfinal = heatsInfinal;
    HeatsInsemi = heatsInsemi;
    StdLanes = stdLanes;
    AutoSeed = autoSeed;
    TwoperlaneReq = twoperlaneReq;
    PreheatOrder = preheatOrder;
    FinheatOrder = finheatOrder;
    ScoreEvent = scoreEvent;
    DivNo = divNo;
    RelaySize = relaySize;
    Comm1 = comm1;
    Comm2 = comm2;
    Comm3 = comm3;
    Comm4 = comm4;
    EntryFee = entryFee;
    IsLocked = isLocked;
    LockedBy = lockedBy;
    EventType = eventType;
    LockedList = lockedList;
    EventNote = eventNote;
    SuppressStroke = suppressStroke;
    CustomABCFinal = customABCFinal;
    NumDives = numDives;
    NumHeatsInFinal = numHeatsInFinal;
    MultiageSuperFinal = multiageSuperFinal;
    FinalsLanesVary = finalsLanesVary;
    FinalsLanesVaryOrder = finalsLanesVaryOrder;
    ABCfinalOrder = aBCfinalOrder;
    ABCStyle = aBCStyle;
    PrelimsAsExtendedFinal = prelimsAsExtendedFinal;
    NumLanesInBestHeatsTimedFinal = numLanesInBestHeatsTimedFinal;
    NumBestHeatsTimedFinal = numBestHeatsTimedFinal;
    TimedFinalLanesVary = timedFinalLanesVary;
    ScoreTimedFinalAsABC = scoreTimedFinalAsABC;
    NumHeatsInTimedFinalToScore = numHeatsInTimedFinalToScore;
    PadsBothEnds = padsBothEnds;
    MultiageSuperSeed = multiageSuperSeed;
    SuppressDistance = suppressDistance;
    FinAwardsPrinted = finAwardsPrinted;
    PreAwardsPrinted = preAwardsPrinted;
    SemAwardsPrinted = semAwardsPrinted;
    FastTimeStdAbbr = fastTimeStdAbbr;
    SlowTimeStdAbbr = slowTimeStdAbbr;
    SuperFinalElimOldAgeGrp = superFinalElimOldAgeGrp;
    SeedMultiAgeOldToYoung = seedMultiAgeOldToYoung;
    MultiAgeScnd = multiAgeScnd;
    NumRelayLegs = numRelayLegs;
    PadsBothEndsFinals = padsBothEndsFinals;
    CheckinStarttime = checkinStarttime;
    CheckinEndtime = checkinEndtime;
    CheckinStartdate = checkinStartdate;
    CheckinEnddate = checkinEnddate;
    NumSemlanes = numSemlanes;
    EvtMaxAgeForCFinal = evtMaxAgeForCFinal;
    EvtMaxAgeNumHeatsCFinal = evtMaxAgeNumHeatsCFinal;
    Fin_actualstarttime = fin_actualstarttime;
    Sem_actualstarttime = sem_actualstarttime;
    Pre_actualstarttime = pre_actualstarttime;
    SwimoffSourcePtr = swimoffSourcePtr;
    SwimoffSourceRndLtr = swimoffSourceRndLtr;
    SwimoffCreated = swimoffCreated;
    MultiageBestRestFinal = multiageBestRestFinal;
  }
}
