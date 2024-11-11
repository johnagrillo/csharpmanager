using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Relay]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Team_no] Long Integer,
/// // [Team_ltr] Text (2),
/// // [Rel_age] Integer,
/// // [Rel_sex] Text (2),
/// // [ActSeed_course] Text (2),
/// // [ActualSeed_time] Single,
/// // [ConvSeed_course] Text (2),
/// // [ConvSeed_time] Single,
/// // [Scr_stat] Boolean NOT NULL,
/// // [Spec_stat] Text (2),
/// // [Dec_stat] Text (2),
/// // [Alt_stat] Boolean NOT NULL,
/// // [Bonus_event] Boolean NOT NULL,
/// // [Div_no] Long Integer,
/// // [Ev_score] Single,
/// // [dq_type] Text (2),
/// // [Pre_heat] Integer,
/// // [Pre_lane] Integer,
/// // [Pre_stat] Text (2),
/// // [Pre_Time] Single,
/// // [Pre_course] Text (2),
/// // [Pre_heatplace] Integer,
/// // [Pre_place] Integer,
/// // [Pre_jdplace] Integer,
/// // [Pre_exh] Text (2),
/// // [Pre_points] Integer,
/// // [Pre_back1] Single,
/// // [Pre_back2] Single,
/// // [Pre_back3] Single,
/// // [Fin_heat] Integer,
/// // [Fin_lane] Integer,
/// // [Fin_group] Integer,
/// // [Fin_stat] Text (2),
/// // [Fin_Time] Single,
/// // [Fin_course] Text (2),
/// // [Fin_heatplace] Integer,
/// // [Fin_jdheatplace] Integer,
/// // [Fin_place] Integer,
/// // [Fin_jdplace] Integer,
/// // [Fin_ptsplace] Integer,
/// // [Fin_exh] Text (2),
/// // [Fin_points] Integer,
/// // [Fin_back1] Single,
/// // [Fin_back2] Single,
/// // [Fin_back3] Single,
/// // [Sem_heat] Integer,
/// // [Sem_lane] Integer,
/// // [Sem_stat] Text (2),
/// // [Sem_Time] Single,
/// // [Sem_course] Text (2),
/// // [Sem_heatplace] Integer,
/// // [Sem_place] Integer,
/// // [Sem_jdplace] Integer,
/// // [Sem_exh] Text (2),
/// // [Sem_points] Integer,
/// // [Sem_back1] Single,
/// // [Sem_back2] Single,
/// // [Sem_back3] Single,
/// // [Swimoff_heat] Integer,
/// // [Swimoff_lane] Integer,
/// // [Swimoff_stat] Text (2),
/// // [Swimoff_Time] Single,
/// // [Swimoff_course] Text (2),
/// // [Swimoff_heatplace] Integer,
/// // [Swimoff_place] Integer,
/// // [Swimoff_jdplace] Integer,
/// // [Swimoff_points] Integer,
/// // [Swimoff_back1] Single,
/// // [Swimoff_back2] Single,
/// // [Swimoff_back3] Single,
/// // [JDEv_score] Single,
/// // [Relay_no] Long Integer,
/// // [Seed_place] Integer,
/// // [fin_heatltr] Text (2),
/// // [Pre_watch1] Single,
/// // [Pre_pad] Single,
/// // [Sem_watch1] Single,
/// // [Sem_pad] Single,
/// // [Fin_watch1] Single,
/// // [Fin_pad] Single,
/// // [Fin_reactiontime1] Text (10),
/// // [Pre_reactiontime1] Text (10),
/// // [Sem_reactiontime1] Text (10),
/// // [Fin_dqcode] Text (4),
/// // [Pre_dqcode] Text (4),
/// // [Sem_dqcode] Text (4),
/// // [Fin_dqcodeSecond] Text (4),
/// // [Pre_dqcodeSecond] Text (4),
/// // [Sem_dqcodeSecond] Text (4),
/// // [Fin_reactiontime2] Text (10),
/// // [Pre_reactiontime2] Text (10),
/// // [Sem_reactiontime2] Text (10),
/// // [Fin_reactiontime3] Text (10),
/// // [Pre_reactiontime3] Text (10),
/// // [Sem_reactiontime3] Text (10),
/// // [Fin_reactiontime4] Text (10),
/// // [Pre_reactiontime4] Text (10),
/// // [Sem_reactiontime4] Text (10),
/// // [Fin_TimeType] Text (2),
/// // [Pre_TimeType] Text (2),
/// // [Sem_TimeType] Text (2),
/// // [Fin_dolphin1] Single,
/// // [Fin_dolphin2] Single,
/// // [Fin_dolphin3] Single,
/// // [Pre_dolphin1] Single,
/// // [Pre_dolphin2] Single,
/// // [Pre_dolphin3] Single,
/// // [Sem_dolphin1] Single,
/// // [Sem_dolphin2] Single,
/// // [Sem_dolphin3] Single,
/// // [early_seed] Boolean NOT NULL,
/// // [fin_adjuststat] Text (2),
/// // [pre_adjuststat] Text (2),
/// // [sem_adjuststat] Text (2),
/// // [entry_method] Text (2),
/// // [fin_dqofficial] Long Integer,
/// // [pre_dqofficial] Long Integer,
/// // [sem_dqofficial] Long Integer,
/// // [pre_contacted] Boolean NOT NULL
/// // );

public class Relay(long? eventPtr, long? teamNo, string teamLtr, short? relAge, string relSex, string actSeedCourse, float? actualSeedTime, string convSeedCourse, float? convSeedTime, bool scrStat, string specStat, string decStat, bool altStat, bool bonusEvent, long? divNo, float? evScore, string dq_type, short? preHeat, short? preLane, string preStat, float? preTime, string preCourse, short? preHeatplace, short? prePlace, short? preJdplace, string preExh, short? prePoints, float? preBack1, float? preBack2, float? preBack3, short? finHeat, short? finLane, short? finGroup, string finStat, float? finTime, string finCourse, short? finHeatplace, short? finJdheatplace, short? finPlace, short? finJdplace, short? finPtsplace, string finExh, short? finPoints, float? finBack1, float? finBack2, float? finBack3, short? semHeat, short? semLane, string semStat, float? semTime, string semCourse, short? semHeatplace, short? semPlace, short? semJdplace, string semExh, short? semPoints, float? semBack1, float? semBack2, float? semBack3, short? swimoffHeat, short? swimoffLane, string swimoffStat, float? swimoffTime, string swimoffCourse, short? swimoffHeatplace, short? swimoffPlace, short? swimoffJdplace, short? swimoffPoints, float? swimoffBack1, float? swimoffBack2, float? swimoffBack3, float? jDEvScore, long? relayNo, short? seedPlace, string fin_heatltr, float? preWatch1, float? prePad, float? semWatch1, float? semPad, float? finWatch1, float? finPad, string finReactiontime1, string preReactiontime1, string semReactiontime1, string finDqcode, string preDqcode, string semDqcode, string finDqcodeSecond, string preDqcodeSecond, string semDqcodeSecond, string finReactiontime2, string preReactiontime2, string semReactiontime2, string finReactiontime3, string preReactiontime3, string semReactiontime3, string finReactiontime4, string preReactiontime4, string semReactiontime4, string finTimeType, string preTimeType, string semTimeType, float? finDolphin1, float? finDolphin2, float? finDolphin3, float? preDolphin1, float? preDolphin2, float? preDolphin3, float? semDolphin1, float? semDolphin2, float? semDolphin3, bool early_seed, string fin_adjuststat, string pre_adjuststat, string sem_adjuststat, string entry_method, long? fin_dqofficial, long? pre_dqofficial, long? sem_dqofficial, bool pre_contacted )
{
static public List<Relay> Get(OdbcConnection connection)
{
  var collection = new List<Relay>();
  string query = "select * from Relay";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Event_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Team_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Team_ltr nullable false*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Rel_age nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Rel_sex nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* ActSeed_course nullable false*/
  var arg6 = reader.IsDBNull(6) ? (float?)null :reader.GetFloat(6); /* ActualSeed_time nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* ConvSeed_course nullable false*/
  var arg8 = reader.IsDBNull(8) ? (float?)null :reader.GetFloat(8); /* ConvSeed_time nullable true*/
  var arg9 = reader.GetBoolean(9); /* Scr_stat nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Spec_stat nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Dec_stat nullable false*/
  var arg12 = reader.GetBoolean(12); /* Alt_stat nullable false*/
  var arg13 = reader.GetBoolean(13); /* Bonus_event nullable false*/
  var arg14 = reader.IsDBNull(14) ? (long?)null :reader.GetInt32(14); /* Div_no nullable true*/
  var arg15 = reader.IsDBNull(15) ? (float?)null :reader.GetFloat(15); /* Ev_score nullable true*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* dq_type nullable false*/
  var arg17 = reader.IsDBNull(17) ? (short?)null :reader.GetInt16(17); /* Pre_heat nullable true*/
  var arg18 = reader.IsDBNull(18) ? (short?)null :reader.GetInt16(18); /* Pre_lane nullable true*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* Pre_stat nullable false*/
  var arg20 = reader.IsDBNull(20) ? (float?)null :reader.GetFloat(20); /* Pre_Time nullable true*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* Pre_course nullable false*/
  var arg22 = reader.IsDBNull(22) ? (short?)null :reader.GetInt16(22); /* Pre_heatplace nullable true*/
  var arg23 = reader.IsDBNull(23) ? (short?)null :reader.GetInt16(23); /* Pre_place nullable true*/
  var arg24 = reader.IsDBNull(24) ? (short?)null :reader.GetInt16(24); /* Pre_jdplace nullable true*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* Pre_exh nullable false*/
  var arg26 = reader.IsDBNull(26) ? (short?)null :reader.GetInt16(26); /* Pre_points nullable true*/
  var arg27 = reader.IsDBNull(27) ? (float?)null :reader.GetFloat(27); /* Pre_back1 nullable true*/
  var arg28 = reader.IsDBNull(28) ? (float?)null :reader.GetFloat(28); /* Pre_back2 nullable true*/
  var arg29 = reader.IsDBNull(29) ? (float?)null :reader.GetFloat(29); /* Pre_back3 nullable true*/
  var arg30 = reader.IsDBNull(30) ? (short?)null :reader.GetInt16(30); /* Fin_heat nullable true*/
  var arg31 = reader.IsDBNull(31) ? (short?)null :reader.GetInt16(31); /* Fin_lane nullable true*/
  var arg32 = reader.IsDBNull(32) ? (short?)null :reader.GetInt16(32); /* Fin_group nullable true*/
  var arg33 = reader.GetTextReader(33).ReadLine(); /* Fin_stat nullable false*/
  var arg34 = reader.IsDBNull(34) ? (float?)null :reader.GetFloat(34); /* Fin_Time nullable true*/
  var arg35 = reader.GetTextReader(35).ReadLine(); /* Fin_course nullable false*/
  var arg36 = reader.IsDBNull(36) ? (short?)null :reader.GetInt16(36); /* Fin_heatplace nullable true*/
  var arg37 = reader.IsDBNull(37) ? (short?)null :reader.GetInt16(37); /* Fin_jdheatplace nullable true*/
  var arg38 = reader.IsDBNull(38) ? (short?)null :reader.GetInt16(38); /* Fin_place nullable true*/
  var arg39 = reader.IsDBNull(39) ? (short?)null :reader.GetInt16(39); /* Fin_jdplace nullable true*/
  var arg40 = reader.IsDBNull(40) ? (short?)null :reader.GetInt16(40); /* Fin_ptsplace nullable true*/
  var arg41 = reader.GetTextReader(41).ReadLine(); /* Fin_exh nullable false*/
  var arg42 = reader.IsDBNull(42) ? (short?)null :reader.GetInt16(42); /* Fin_points nullable true*/
  var arg43 = reader.IsDBNull(43) ? (float?)null :reader.GetFloat(43); /* Fin_back1 nullable true*/
  var arg44 = reader.IsDBNull(44) ? (float?)null :reader.GetFloat(44); /* Fin_back2 nullable true*/
  var arg45 = reader.IsDBNull(45) ? (float?)null :reader.GetFloat(45); /* Fin_back3 nullable true*/
  var arg46 = reader.IsDBNull(46) ? (short?)null :reader.GetInt16(46); /* Sem_heat nullable true*/
  var arg47 = reader.IsDBNull(47) ? (short?)null :reader.GetInt16(47); /* Sem_lane nullable true*/
  var arg48 = reader.GetTextReader(48).ReadLine(); /* Sem_stat nullable false*/
  var arg49 = reader.IsDBNull(49) ? (float?)null :reader.GetFloat(49); /* Sem_Time nullable true*/
  var arg50 = reader.GetTextReader(50).ReadLine(); /* Sem_course nullable false*/
  var arg51 = reader.IsDBNull(51) ? (short?)null :reader.GetInt16(51); /* Sem_heatplace nullable true*/
  var arg52 = reader.IsDBNull(52) ? (short?)null :reader.GetInt16(52); /* Sem_place nullable true*/
  var arg53 = reader.IsDBNull(53) ? (short?)null :reader.GetInt16(53); /* Sem_jdplace nullable true*/
  var arg54 = reader.GetTextReader(54).ReadLine(); /* Sem_exh nullable false*/
  var arg55 = reader.IsDBNull(55) ? (short?)null :reader.GetInt16(55); /* Sem_points nullable true*/
  var arg56 = reader.IsDBNull(56) ? (float?)null :reader.GetFloat(56); /* Sem_back1 nullable true*/
  var arg57 = reader.IsDBNull(57) ? (float?)null :reader.GetFloat(57); /* Sem_back2 nullable true*/
  var arg58 = reader.IsDBNull(58) ? (float?)null :reader.GetFloat(58); /* Sem_back3 nullable true*/
  var arg59 = reader.IsDBNull(59) ? (short?)null :reader.GetInt16(59); /* Swimoff_heat nullable true*/
  var arg60 = reader.IsDBNull(60) ? (short?)null :reader.GetInt16(60); /* Swimoff_lane nullable true*/
  var arg61 = reader.GetTextReader(61).ReadLine(); /* Swimoff_stat nullable false*/
  var arg62 = reader.IsDBNull(62) ? (float?)null :reader.GetFloat(62); /* Swimoff_Time nullable true*/
  var arg63 = reader.GetTextReader(63).ReadLine(); /* Swimoff_course nullable false*/
  var arg64 = reader.IsDBNull(64) ? (short?)null :reader.GetInt16(64); /* Swimoff_heatplace nullable true*/
  var arg65 = reader.IsDBNull(65) ? (short?)null :reader.GetInt16(65); /* Swimoff_place nullable true*/
  var arg66 = reader.IsDBNull(66) ? (short?)null :reader.GetInt16(66); /* Swimoff_jdplace nullable true*/
  var arg67 = reader.IsDBNull(67) ? (short?)null :reader.GetInt16(67); /* Swimoff_points nullable true*/
  var arg68 = reader.IsDBNull(68) ? (float?)null :reader.GetFloat(68); /* Swimoff_back1 nullable true*/
  var arg69 = reader.IsDBNull(69) ? (float?)null :reader.GetFloat(69); /* Swimoff_back2 nullable true*/
  var arg70 = reader.IsDBNull(70) ? (float?)null :reader.GetFloat(70); /* Swimoff_back3 nullable true*/
  var arg71 = reader.IsDBNull(71) ? (float?)null :reader.GetFloat(71); /* JDEv_score nullable true*/
  var arg72 = reader.IsDBNull(72) ? (long?)null :reader.GetInt32(72); /* Relay_no nullable true*/
  var arg73 = reader.IsDBNull(73) ? (short?)null :reader.GetInt16(73); /* Seed_place nullable true*/
  var arg74 = reader.GetTextReader(74).ReadLine(); /* fin_heatltr nullable false*/
  var arg75 = reader.IsDBNull(75) ? (float?)null :reader.GetFloat(75); /* Pre_watch1 nullable true*/
  var arg76 = reader.IsDBNull(76) ? (float?)null :reader.GetFloat(76); /* Pre_pad nullable true*/
  var arg77 = reader.IsDBNull(77) ? (float?)null :reader.GetFloat(77); /* Sem_watch1 nullable true*/
  var arg78 = reader.IsDBNull(78) ? (float?)null :reader.GetFloat(78); /* Sem_pad nullable true*/
  var arg79 = reader.IsDBNull(79) ? (float?)null :reader.GetFloat(79); /* Fin_watch1 nullable true*/
  var arg80 = reader.IsDBNull(80) ? (float?)null :reader.GetFloat(80); /* Fin_pad nullable true*/
  var arg81 = reader.GetTextReader(81).ReadLine(); /* Fin_reactiontime1 nullable false*/
  var arg82 = reader.GetTextReader(82).ReadLine(); /* Pre_reactiontime1 nullable false*/
  var arg83 = reader.GetTextReader(83).ReadLine(); /* Sem_reactiontime1 nullable false*/
  var arg84 = reader.GetTextReader(84).ReadLine(); /* Fin_dqcode nullable false*/
  var arg85 = reader.GetTextReader(85).ReadLine(); /* Pre_dqcode nullable false*/
  var arg86 = reader.GetTextReader(86).ReadLine(); /* Sem_dqcode nullable false*/
  var arg87 = reader.GetTextReader(87).ReadLine(); /* Fin_dqcodeSecond nullable false*/
  var arg88 = reader.GetTextReader(88).ReadLine(); /* Pre_dqcodeSecond nullable false*/
  var arg89 = reader.GetTextReader(89).ReadLine(); /* Sem_dqcodeSecond nullable false*/
  var arg90 = reader.GetTextReader(90).ReadLine(); /* Fin_reactiontime2 nullable false*/
  var arg91 = reader.GetTextReader(91).ReadLine(); /* Pre_reactiontime2 nullable false*/
  var arg92 = reader.GetTextReader(92).ReadLine(); /* Sem_reactiontime2 nullable false*/
  var arg93 = reader.GetTextReader(93).ReadLine(); /* Fin_reactiontime3 nullable false*/
  var arg94 = reader.GetTextReader(94).ReadLine(); /* Pre_reactiontime3 nullable false*/
  var arg95 = reader.GetTextReader(95).ReadLine(); /* Sem_reactiontime3 nullable false*/
  var arg96 = reader.GetTextReader(96).ReadLine(); /* Fin_reactiontime4 nullable false*/
  var arg97 = reader.GetTextReader(97).ReadLine(); /* Pre_reactiontime4 nullable false*/
  var arg98 = reader.GetTextReader(98).ReadLine(); /* Sem_reactiontime4 nullable false*/
  var arg99 = reader.GetTextReader(99).ReadLine(); /* Fin_TimeType nullable false*/
  var arg100 = reader.GetTextReader(100).ReadLine(); /* Pre_TimeType nullable false*/
  var arg101 = reader.GetTextReader(101).ReadLine(); /* Sem_TimeType nullable false*/
  var arg102 = reader.IsDBNull(102) ? (float?)null :reader.GetFloat(102); /* Fin_dolphin1 nullable true*/
  var arg103 = reader.IsDBNull(103) ? (float?)null :reader.GetFloat(103); /* Fin_dolphin2 nullable true*/
  var arg104 = reader.IsDBNull(104) ? (float?)null :reader.GetFloat(104); /* Fin_dolphin3 nullable true*/
  var arg105 = reader.IsDBNull(105) ? (float?)null :reader.GetFloat(105); /* Pre_dolphin1 nullable true*/
  var arg106 = reader.IsDBNull(106) ? (float?)null :reader.GetFloat(106); /* Pre_dolphin2 nullable true*/
  var arg107 = reader.IsDBNull(107) ? (float?)null :reader.GetFloat(107); /* Pre_dolphin3 nullable true*/
  var arg108 = reader.IsDBNull(108) ? (float?)null :reader.GetFloat(108); /* Sem_dolphin1 nullable true*/
  var arg109 = reader.IsDBNull(109) ? (float?)null :reader.GetFloat(109); /* Sem_dolphin2 nullable true*/
  var arg110 = reader.IsDBNull(110) ? (float?)null :reader.GetFloat(110); /* Sem_dolphin3 nullable true*/
  var arg111 = reader.GetBoolean(111); /* early_seed nullable false*/
  var arg112 = reader.GetTextReader(112).ReadLine(); /* fin_adjuststat nullable false*/
  var arg113 = reader.GetTextReader(113).ReadLine(); /* pre_adjuststat nullable false*/
  var arg114 = reader.GetTextReader(114).ReadLine(); /* sem_adjuststat nullable false*/
  var arg115 = reader.GetTextReader(115).ReadLine(); /* entry_method nullable false*/
  var arg116 = reader.IsDBNull(116) ? (long?)null :reader.GetInt32(116); /* fin_dqofficial nullable true*/
  var arg117 = reader.IsDBNull(117) ? (long?)null :reader.GetInt32(117); /* pre_dqofficial nullable true*/
  var arg118 = reader.IsDBNull(118) ? (long?)null :reader.GetInt32(118); /* sem_dqofficial nullable true*/
  var arg119 = reader.GetBoolean(119); /* pre_contacted nullable false*/
      collection.Add( new Relay(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99, arg100, arg101, arg102, arg103, arg104, arg105, arg106, arg107, arg108, arg109, arg110, arg111, arg112, arg113, arg114, arg115, arg116, arg117, arg118, arg119));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public long? TeamNo{ get; } = teamNo;
  public string TeamLtr{ get; } = teamLtr;
  public short? RelAge{ get; } = relAge;
  public string RelSex{ get; } = relSex;
  public string ActSeedCourse{ get; } = actSeedCourse;
  public float? ActualSeedTime{ get; } = actualSeedTime;
  public string ConvSeedCourse{ get; } = convSeedCourse;
  public float? ConvSeedTime{ get; } = convSeedTime;
  public bool ScrStat{ get; } = scrStat;
  public string SpecStat{ get; } = specStat;
  public string DecStat{ get; } = decStat;
  public bool AltStat{ get; } = altStat;
  public bool BonusEvent{ get; } = bonusEvent;
  public long? DivNo{ get; } = divNo;
  public float? EvScore{ get; } = evScore;
  public string Dq_type{ get; } = dq_type;
  public short? PreHeat{ get; } = preHeat;
  public short? PreLane{ get; } = preLane;
  public string PreStat{ get; } = preStat;
  public float? PreTime{ get; } = preTime;
  public string PreCourse{ get; } = preCourse;
  public short? PreHeatplace{ get; } = preHeatplace;
  public short? PrePlace{ get; } = prePlace;
  public short? PreJdplace{ get; } = preJdplace;
  public string PreExh{ get; } = preExh;
  public short? PrePoints{ get; } = prePoints;
  public float? PreBack1{ get; } = preBack1;
  public float? PreBack2{ get; } = preBack2;
  public float? PreBack3{ get; } = preBack3;
  public short? FinHeat{ get; } = finHeat;
  public short? FinLane{ get; } = finLane;
  public short? FinGroup{ get; } = finGroup;
  public string FinStat{ get; } = finStat;
  public float? FinTime{ get; } = finTime;
  public string FinCourse{ get; } = finCourse;
  public short? FinHeatplace{ get; } = finHeatplace;
  public short? FinJdheatplace{ get; } = finJdheatplace;
  public short? FinPlace{ get; } = finPlace;
  public short? FinJdplace{ get; } = finJdplace;
  public short? FinPtsplace{ get; } = finPtsplace;
  public string FinExh{ get; } = finExh;
  public short? FinPoints{ get; } = finPoints;
  public float? FinBack1{ get; } = finBack1;
  public float? FinBack2{ get; } = finBack2;
  public float? FinBack3{ get; } = finBack3;
  public short? SemHeat{ get; } = semHeat;
  public short? SemLane{ get; } = semLane;
  public string SemStat{ get; } = semStat;
  public float? SemTime{ get; } = semTime;
  public string SemCourse{ get; } = semCourse;
  public short? SemHeatplace{ get; } = semHeatplace;
  public short? SemPlace{ get; } = semPlace;
  public short? SemJdplace{ get; } = semJdplace;
  public string SemExh{ get; } = semExh;
  public short? SemPoints{ get; } = semPoints;
  public float? SemBack1{ get; } = semBack1;
  public float? SemBack2{ get; } = semBack2;
  public float? SemBack3{ get; } = semBack3;
  public short? SwimoffHeat{ get; } = swimoffHeat;
  public short? SwimoffLane{ get; } = swimoffLane;
  public string SwimoffStat{ get; } = swimoffStat;
  public float? SwimoffTime{ get; } = swimoffTime;
  public string SwimoffCourse{ get; } = swimoffCourse;
  public short? SwimoffHeatplace{ get; } = swimoffHeatplace;
  public short? SwimoffPlace{ get; } = swimoffPlace;
  public short? SwimoffJdplace{ get; } = swimoffJdplace;
  public short? SwimoffPoints{ get; } = swimoffPoints;
  public float? SwimoffBack1{ get; } = swimoffBack1;
  public float? SwimoffBack2{ get; } = swimoffBack2;
  public float? SwimoffBack3{ get; } = swimoffBack3;
  public float? JDEvScore{ get; } = jDEvScore;
  public long? RelayNo{ get; } = relayNo;
  public short? SeedPlace{ get; } = seedPlace;
  public string Fin_heatltr{ get; } = fin_heatltr;
  public float? PreWatch1{ get; } = preWatch1;
  public float? PrePad{ get; } = prePad;
  public float? SemWatch1{ get; } = semWatch1;
  public float? SemPad{ get; } = semPad;
  public float? FinWatch1{ get; } = finWatch1;
  public float? FinPad{ get; } = finPad;
  public string FinReactiontime1{ get; } = finReactiontime1;
  public string PreReactiontime1{ get; } = preReactiontime1;
  public string SemReactiontime1{ get; } = semReactiontime1;
  public string FinDqcode{ get; } = finDqcode;
  public string PreDqcode{ get; } = preDqcode;
  public string SemDqcode{ get; } = semDqcode;
  public string FinDqcodeSecond{ get; } = finDqcodeSecond;
  public string PreDqcodeSecond{ get; } = preDqcodeSecond;
  public string SemDqcodeSecond{ get; } = semDqcodeSecond;
  public string FinReactiontime2{ get; } = finReactiontime2;
  public string PreReactiontime2{ get; } = preReactiontime2;
  public string SemReactiontime2{ get; } = semReactiontime2;
  public string FinReactiontime3{ get; } = finReactiontime3;
  public string PreReactiontime3{ get; } = preReactiontime3;
  public string SemReactiontime3{ get; } = semReactiontime3;
  public string FinReactiontime4{ get; } = finReactiontime4;
  public string PreReactiontime4{ get; } = preReactiontime4;
  public string SemReactiontime4{ get; } = semReactiontime4;
  public string FinTimeType{ get; } = finTimeType;
  public string PreTimeType{ get; } = preTimeType;
  public string SemTimeType{ get; } = semTimeType;
  public float? FinDolphin1{ get; } = finDolphin1;
  public float? FinDolphin2{ get; } = finDolphin2;
  public float? FinDolphin3{ get; } = finDolphin3;
  public float? PreDolphin1{ get; } = preDolphin1;
  public float? PreDolphin2{ get; } = preDolphin2;
  public float? PreDolphin3{ get; } = preDolphin3;
  public float? SemDolphin1{ get; } = semDolphin1;
  public float? SemDolphin2{ get; } = semDolphin2;
  public float? SemDolphin3{ get; } = semDolphin3;
  public bool Early_seed{ get; } = early_seed;
  public string Fin_adjuststat{ get; } = fin_adjuststat;
  public string Pre_adjuststat{ get; } = pre_adjuststat;
  public string Sem_adjuststat{ get; } = sem_adjuststat;
  public string Entry_method{ get; } = entry_method;
  public long? Fin_dqofficial{ get; } = fin_dqofficial;
  public long? Pre_dqofficial{ get; } = pre_dqofficial;
  public long? Sem_dqofficial{ get; } = sem_dqofficial;
  public bool Pre_contacted{ get; } = pre_contacted;
}
}
}
