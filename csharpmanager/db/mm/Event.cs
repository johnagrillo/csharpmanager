using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Event]
/// // (
/// // [Event_no] Integer,
/// // [Event_ltr] Text (2),
/// // [Event_ptr] Long Integer,
/// // [Ind_rel] Text (2),
/// // [Event_sex] Text (2),
/// // [Event_gender] Text (2),
/// // [Event_dist] Single,
/// // [Event_stroke] Text (2),
/// // [Low_age] Integer,
/// // [High_Age] Integer,
/// // [Multi_age] Boolean NOT NULL,
/// // [Event_stat] Text (2),
/// // [Event_rounds] Integer,
/// // [Num_prelanes] Integer,
/// // [Num_finlanes] Integer,
/// // [Heats_infinal] Text (2),
/// // [Heats_insemi] Integer,
/// // [Std_lanes] Text (2),
/// // [Auto_seed] Boolean NOT NULL,
/// // [Twoperlane_req] Boolean NOT NULL,
/// // [Preheat_order] Text (2),
/// // [Finheat_order] Text (2),
/// // [Score_event] Boolean NOT NULL,
/// // [Div_no] Integer,
/// // [Relay_size] Integer,
/// // [Comm_1] Text (72),
/// // [Comm_2] Text (72),
/// // [Comm_3] Text (72),
/// // [Comm_4] Text (72),
/// // [Entry_fee] Currency,
/// // [Is_locked] Boolean NOT NULL,
/// // [Locked_by] Text (40),
/// // [Event_Type] Text (2),
/// // [Locked_list] Text (24),
/// // [Event_note] Text (40),
/// // [Suppress_stroke] Boolean NOT NULL,
/// // [Custom_ABCFinal] Boolean NOT NULL,
/// // [Num_dives] Integer,
/// // [Num_HeatsInFinal] Integer,
/// // [Multiage_SuperFinal] Boolean NOT NULL,
/// // [Finals_LanesVary] Boolean NOT NULL,
/// // [Finals_LanesVaryOrder] Text (36),
/// // [ABCfinal_order] Text (12),
/// // [ABC_Style] Boolean NOT NULL,
/// // [PrelimsAs_ExtendedFinal] Boolean NOT NULL,
/// // [Num_LanesInBestHeatsTimedFinal] Integer,
/// // [Num_BestHeatsTimedFinal] Integer,
/// // [TimedFinal_LanesVary] Boolean NOT NULL,
/// // [ScoreTimedFinal_asABC] Boolean NOT NULL,
/// // [Num_HeatsInTimedFinalToScore] Integer,
/// // [Pads_BothEnds] Boolean NOT NULL,
/// // [Multiage_SuperSeed] Boolean NOT NULL,
/// // [Suppress_distance] Boolean NOT NULL,
/// // [Fin_AwardsPrinted] Boolean NOT NULL,
/// // [Pre_AwardsPrinted] Boolean NOT NULL,
/// // [Sem_AwardsPrinted] Boolean NOT NULL,
/// // [FastTimeStd_Abbr] Text (8),
/// // [SlowTimeStd_Abbr] Text (8),
/// // [SuperFinal_ElimOldAgeGrp] Boolean NOT NULL,
/// // [SeedMultiAge_OldToYoung] Boolean NOT NULL,
/// // [Multi_ageScnd] Boolean NOT NULL,
/// // [Num_RelayLegs] Integer,
/// // [Pads_BothEndsFinals] Boolean NOT NULL,
/// // [Checkin_starttime] Long Integer,
/// // [Checkin_endtime] Long Integer,
/// // [Checkin_startdate] DateTime,
/// // [Checkin_enddate] DateTime,
/// // [Num_semlanes] Integer,
/// // [EvtMaxAgeFor_CFinal] Integer,
/// // [EvtMaxAgeNumHeats_CFinal] Integer,
/// // [fin_actualstarttime] Long Integer,
/// // [sem_actualstarttime] Long Integer,
/// // [pre_actualstarttime] Long Integer,
/// // [Swimoff_SourcePtr] Long Integer,
/// // [Swimoff_SourceRndLtr] Text (2),
/// // [Swimoff_Created] DateTime,
/// // [Multiage_BestRestFinal] Boolean NOT NULL
/// // );

public class Event(short? eventNo, string eventLtr, long? eventPtr, string indRel, string eventSex, string eventGender, float? eventDist, string eventStroke, short? lowAge, short? highAge, bool multiAge, string eventStat, short? eventRounds, short? numPrelanes, short? numFinlanes, string heatsInfinal, short? heatsInsemi, string stdLanes, bool autoSeed, bool twoperlaneReq, string preheatOrder, string finheatOrder, bool scoreEvent, short? divNo, short? relaySize, string comm1, string comm2, string comm3, string comm4, decimal? entryFee, bool isLocked, string lockedBy, string eventType, string lockedList, string eventNote, bool suppressStroke, bool customABCFinal, short? numDives, short? numHeatsInFinal, bool multiageSuperFinal, bool finalsLanesVary, string finalsLanesVaryOrder, string aBCfinalOrder, bool aBCStyle, bool prelimsAsExtendedFinal, short? numLanesInBestHeatsTimedFinal, short? numBestHeatsTimedFinal, bool timedFinalLanesVary, bool scoreTimedFinalAsABC, short? numHeatsInTimedFinalToScore, bool padsBothEnds, bool multiageSuperSeed, bool suppressDistance, bool finAwardsPrinted, bool preAwardsPrinted, bool semAwardsPrinted, string fastTimeStdAbbr, string slowTimeStdAbbr, bool superFinalElimOldAgeGrp, bool seedMultiAgeOldToYoung, bool multiAgeScnd, short? numRelayLegs, bool padsBothEndsFinals, long? checkinStarttime, long? checkinEndtime, DateTime? checkinStartdate, DateTime? checkinEnddate, short? numSemlanes, short? evtMaxAgeForCFinal, short? evtMaxAgeNumHeatsCFinal, long? fin_actualstarttime, long? sem_actualstarttime, long? pre_actualstarttime, long? swimoffSourcePtr, string swimoffSourceRndLtr, DateTime? swimoffCreated, bool multiageBestRestFinal )
{
static public List<Event> Get(OdbcConnection connection)
{
  var collection = new List<Event>();
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
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* Event_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Event_ltr nullable false*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Event_ptr nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Ind_rel nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Event_sex nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Event_gender nullable false*/
  var arg6 = reader.IsDBNull(6) ? (float?)null :reader.GetFloat(6); /* Event_dist nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Event_stroke nullable false*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* Low_age nullable true*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* High_Age nullable true*/
  var arg10 = reader.GetBoolean(10); /* Multi_age nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Event_stat nullable false*/
  var arg12 = reader.IsDBNull(12) ? (short?)null :reader.GetInt16(12); /* Event_rounds nullable true*/
  var arg13 = reader.IsDBNull(13) ? (short?)null :reader.GetInt16(13); /* Num_prelanes nullable true*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* Num_finlanes nullable true*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Heats_infinal nullable false*/
  var arg16 = reader.IsDBNull(16) ? (short?)null :reader.GetInt16(16); /* Heats_insemi nullable true*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* Std_lanes nullable false*/
  var arg18 = reader.GetBoolean(18); /* Auto_seed nullable false*/
  var arg19 = reader.GetBoolean(19); /* Twoperlane_req nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* Preheat_order nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* Finheat_order nullable false*/
  var arg22 = reader.GetBoolean(22); /* Score_event nullable false*/
  var arg23 = reader.IsDBNull(23) ? (short?)null :reader.GetInt16(23); /* Div_no nullable true*/
  var arg24 = reader.IsDBNull(24) ? (short?)null :reader.GetInt16(24); /* Relay_size nullable true*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* Comm_1 nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* Comm_2 nullable false*/
  var arg27 = reader.GetTextReader(27).ReadLine(); /* Comm_3 nullable false*/
  var arg28 = reader.GetTextReader(28).ReadLine(); /* Comm_4 nullable false*/
  var arg29 = reader.IsDBNull(29) ? (decimal?)null :reader.GetDecimal(29); /* Entry_fee nullable true*/
  var arg30 = reader.GetBoolean(30); /* Is_locked nullable false*/
  var arg31 = reader.GetTextReader(31).ReadLine(); /* Locked_by nullable false*/
  var arg32 = reader.GetTextReader(32).ReadLine(); /* Event_Type nullable false*/
  var arg33 = reader.GetTextReader(33).ReadLine(); /* Locked_list nullable false*/
  var arg34 = reader.GetTextReader(34).ReadLine(); /* Event_note nullable false*/
  var arg35 = reader.GetBoolean(35); /* Suppress_stroke nullable false*/
  var arg36 = reader.GetBoolean(36); /* Custom_ABCFinal nullable false*/
  var arg37 = reader.IsDBNull(37) ? (short?)null :reader.GetInt16(37); /* Num_dives nullable true*/
  var arg38 = reader.IsDBNull(38) ? (short?)null :reader.GetInt16(38); /* Num_HeatsInFinal nullable true*/
  var arg39 = reader.GetBoolean(39); /* Multiage_SuperFinal nullable false*/
  var arg40 = reader.GetBoolean(40); /* Finals_LanesVary nullable false*/
  var arg41 = reader.GetTextReader(41).ReadLine(); /* Finals_LanesVaryOrder nullable false*/
  var arg42 = reader.GetTextReader(42).ReadLine(); /* ABCfinal_order nullable false*/
  var arg43 = reader.GetBoolean(43); /* ABC_Style nullable false*/
  var arg44 = reader.GetBoolean(44); /* PrelimsAs_ExtendedFinal nullable false*/
  var arg45 = reader.IsDBNull(45) ? (short?)null :reader.GetInt16(45); /* Num_LanesInBestHeatsTimedFinal nullable true*/
  var arg46 = reader.IsDBNull(46) ? (short?)null :reader.GetInt16(46); /* Num_BestHeatsTimedFinal nullable true*/
  var arg47 = reader.GetBoolean(47); /* TimedFinal_LanesVary nullable false*/
  var arg48 = reader.GetBoolean(48); /* ScoreTimedFinal_asABC nullable false*/
  var arg49 = reader.IsDBNull(49) ? (short?)null :reader.GetInt16(49); /* Num_HeatsInTimedFinalToScore nullable true*/
  var arg50 = reader.GetBoolean(50); /* Pads_BothEnds nullable false*/
  var arg51 = reader.GetBoolean(51); /* Multiage_SuperSeed nullable false*/
  var arg52 = reader.GetBoolean(52); /* Suppress_distance nullable false*/
  var arg53 = reader.GetBoolean(53); /* Fin_AwardsPrinted nullable false*/
  var arg54 = reader.GetBoolean(54); /* Pre_AwardsPrinted nullable false*/
  var arg55 = reader.GetBoolean(55); /* Sem_AwardsPrinted nullable false*/
  var arg56 = reader.GetTextReader(56).ReadLine(); /* FastTimeStd_Abbr nullable false*/
  var arg57 = reader.GetTextReader(57).ReadLine(); /* SlowTimeStd_Abbr nullable false*/
  var arg58 = reader.GetBoolean(58); /* SuperFinal_ElimOldAgeGrp nullable false*/
  var arg59 = reader.GetBoolean(59); /* SeedMultiAge_OldToYoung nullable false*/
  var arg60 = reader.GetBoolean(60); /* Multi_ageScnd nullable false*/
  var arg61 = reader.IsDBNull(61) ? (short?)null :reader.GetInt16(61); /* Num_RelayLegs nullable true*/
  var arg62 = reader.GetBoolean(62); /* Pads_BothEndsFinals nullable false*/
  var arg63 = reader.IsDBNull(63) ? (long?)null :reader.GetInt32(63); /* Checkin_starttime nullable true*/
  var arg64 = reader.IsDBNull(64) ? (long?)null :reader.GetInt32(64); /* Checkin_endtime nullable true*/
  var arg65 = reader.IsDBNull(65) ? (DateTime?)null :reader.GetDateTime(65); /* Checkin_startdate nullable true*/
  var arg66 = reader.IsDBNull(66) ? (DateTime?)null :reader.GetDateTime(66); /* Checkin_enddate nullable true*/
  var arg67 = reader.IsDBNull(67) ? (short?)null :reader.GetInt16(67); /* Num_semlanes nullable true*/
  var arg68 = reader.IsDBNull(68) ? (short?)null :reader.GetInt16(68); /* EvtMaxAgeFor_CFinal nullable true*/
  var arg69 = reader.IsDBNull(69) ? (short?)null :reader.GetInt16(69); /* EvtMaxAgeNumHeats_CFinal nullable true*/
  var arg70 = reader.IsDBNull(70) ? (long?)null :reader.GetInt32(70); /* fin_actualstarttime nullable true*/
  var arg71 = reader.IsDBNull(71) ? (long?)null :reader.GetInt32(71); /* sem_actualstarttime nullable true*/
  var arg72 = reader.IsDBNull(72) ? (long?)null :reader.GetInt32(72); /* pre_actualstarttime nullable true*/
  var arg73 = reader.IsDBNull(73) ? (long?)null :reader.GetInt32(73); /* Swimoff_SourcePtr nullable true*/
  var arg74 = reader.GetTextReader(74).ReadLine(); /* Swimoff_SourceRndLtr nullable false*/
  var arg75 = reader.IsDBNull(75) ? (DateTime?)null :reader.GetDateTime(75); /* Swimoff_Created nullable true*/
  var arg76 = reader.GetBoolean(76); /* Multiage_BestRestFinal nullable false*/
      collection.Add( new Event(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76));
    }
  }
  return collection;
}
  // Properties
  public short? EventNo{ get; } = eventNo;
  public string EventLtr{ get; } = eventLtr;
  public long? EventPtr{ get; } = eventPtr;
  public string IndRel{ get; } = indRel;
  public string EventSex{ get; } = eventSex;
  public string EventGender{ get; } = eventGender;
  public float? EventDist{ get; } = eventDist;
  public string EventStroke{ get; } = eventStroke;
  public short? LowAge{ get; } = lowAge;
  public short? HighAge{ get; } = highAge;
  public bool MultiAge{ get; } = multiAge;
  public string EventStat{ get; } = eventStat;
  public short? EventRounds{ get; } = eventRounds;
  public short? NumPrelanes{ get; } = numPrelanes;
  public short? NumFinlanes{ get; } = numFinlanes;
  public string HeatsInfinal{ get; } = heatsInfinal;
  public short? HeatsInsemi{ get; } = heatsInsemi;
  public string StdLanes{ get; } = stdLanes;
  public bool AutoSeed{ get; } = autoSeed;
  public bool TwoperlaneReq{ get; } = twoperlaneReq;
  public string PreheatOrder{ get; } = preheatOrder;
  public string FinheatOrder{ get; } = finheatOrder;
  public bool ScoreEvent{ get; } = scoreEvent;
  public short? DivNo{ get; } = divNo;
  public short? RelaySize{ get; } = relaySize;
  public string Comm1{ get; } = comm1;
  public string Comm2{ get; } = comm2;
  public string Comm3{ get; } = comm3;
  public string Comm4{ get; } = comm4;
  public decimal? EntryFee{ get; } = entryFee;
  public bool IsLocked{ get; } = isLocked;
  public string LockedBy{ get; } = lockedBy;
  public string EventType{ get; } = eventType;
  public string LockedList{ get; } = lockedList;
  public string EventNote{ get; } = eventNote;
  public bool SuppressStroke{ get; } = suppressStroke;
  public bool CustomABCFinal{ get; } = customABCFinal;
  public short? NumDives{ get; } = numDives;
  public short? NumHeatsInFinal{ get; } = numHeatsInFinal;
  public bool MultiageSuperFinal{ get; } = multiageSuperFinal;
  public bool FinalsLanesVary{ get; } = finalsLanesVary;
  public string FinalsLanesVaryOrder{ get; } = finalsLanesVaryOrder;
  public string ABCfinalOrder{ get; } = aBCfinalOrder;
  public bool ABCStyle{ get; } = aBCStyle;
  public bool PrelimsAsExtendedFinal{ get; } = prelimsAsExtendedFinal;
  public short? NumLanesInBestHeatsTimedFinal{ get; } = numLanesInBestHeatsTimedFinal;
  public short? NumBestHeatsTimedFinal{ get; } = numBestHeatsTimedFinal;
  public bool TimedFinalLanesVary{ get; } = timedFinalLanesVary;
  public bool ScoreTimedFinalAsABC{ get; } = scoreTimedFinalAsABC;
  public short? NumHeatsInTimedFinalToScore{ get; } = numHeatsInTimedFinalToScore;
  public bool PadsBothEnds{ get; } = padsBothEnds;
  public bool MultiageSuperSeed{ get; } = multiageSuperSeed;
  public bool SuppressDistance{ get; } = suppressDistance;
  public bool FinAwardsPrinted{ get; } = finAwardsPrinted;
  public bool PreAwardsPrinted{ get; } = preAwardsPrinted;
  public bool SemAwardsPrinted{ get; } = semAwardsPrinted;
  public string FastTimeStdAbbr{ get; } = fastTimeStdAbbr;
  public string SlowTimeStdAbbr{ get; } = slowTimeStdAbbr;
  public bool SuperFinalElimOldAgeGrp{ get; } = superFinalElimOldAgeGrp;
  public bool SeedMultiAgeOldToYoung{ get; } = seedMultiAgeOldToYoung;
  public bool MultiAgeScnd{ get; } = multiAgeScnd;
  public short? NumRelayLegs{ get; } = numRelayLegs;
  public bool PadsBothEndsFinals{ get; } = padsBothEndsFinals;
  public long? CheckinStarttime{ get; } = checkinStarttime;
  public long? CheckinEndtime{ get; } = checkinEndtime;
  public DateTime? CheckinStartdate{ get; } = checkinStartdate;
  public DateTime? CheckinEnddate{ get; } = checkinEnddate;
  public short? NumSemlanes{ get; } = numSemlanes;
  public short? EvtMaxAgeForCFinal{ get; } = evtMaxAgeForCFinal;
  public short? EvtMaxAgeNumHeatsCFinal{ get; } = evtMaxAgeNumHeatsCFinal;
  public long? Fin_actualstarttime{ get; } = fin_actualstarttime;
  public long? Sem_actualstarttime{ get; } = sem_actualstarttime;
  public long? Pre_actualstarttime{ get; } = pre_actualstarttime;
  public long? SwimoffSourcePtr{ get; } = swimoffSourcePtr;
  public string SwimoffSourceRndLtr{ get; } = swimoffSourceRndLtr;
  public DateTime? SwimoffCreated{ get; } = swimoffCreated;
  public bool MultiageBestRestFinal{ get; } = multiageBestRestFinal;
}
}
}
