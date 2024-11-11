using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Entry]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Ath_no] Long Integer,
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
/// // [Seed_place] Integer,
/// // [fin_heatltr] Text (2),
/// // [event_age] Integer,
/// // [Pre_watch1] Single,
/// // [Pre_pad] Single,
/// // [Sem_watch1] Single,
/// // [Sem_pad] Single,
/// // [Fin_watch1] Single,
/// // [Fin_pad] Single,
/// // [Fin_dqcode] Text (4),
/// // [Pre_dqcode] Text (4),
/// // [Sem_dqcode] Text (8),
/// // [Fin_dqcodeSecond] Text (4),
/// // [Pre_dqcodeSecond] Text (4),
/// // [Sem_dqcodeSecond] Text (4),
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
/// // [super_prefinalist] Boolean NOT NULL,
/// // [super_finfinalist] Boolean NOT NULL,
/// // [fin_adjuststat] Text (2),
/// // [pre_adjuststat] Text (2),
/// // [sem_adjuststat] Text (2),
/// // [fin_divingdd] Text (8),
/// // [pre_divingdd] Text (8),
/// // [sem_divingdd] Text (8),
/// // [entry_method] Text (2),
/// // [fin_dqofficial] Long Integer,
/// // [pre_dqofficial] Long Integer,
/// // [sem_dqofficial] Long Integer,
/// // [pre_contacted] Boolean NOT NULL,
/// // [Fin_reactiontime1] Text (16),
/// // [Pre_reactiontime1] Text (16),
/// // [Sem_reactiontime1] Text (16),
/// // [P_early_seed] Boolean NOT NULL
/// // );

public class Entry(long? eventPtr, long? athNo, string actSeedCourse, float? actualSeedTime, string convSeedCourse, float? convSeedTime, bool scrStat, string specStat, string decStat, bool altStat, bool bonusEvent, long? divNo, float? evScore, string dq_type, short? preHeat, short? preLane, string preStat, float? preTime, string preCourse, short? preHeatplace, short? prePlace, short? preJdplace, string preExh, short? prePoints, float? preBack1, float? preBack2, float? preBack3, short? finHeat, short? finLane, short? finGroup, string finStat, float? finTime, string finCourse, short? finHeatplace, short? finJdheatplace, short? finPlace, short? finJdplace, short? finPtsplace, string finExh, short? finPoints, float? finBack1, float? finBack2, float? finBack3, short? semHeat, short? semLane, string semStat, float? semTime, string semCourse, short? semHeatplace, short? semPlace, short? semJdplace, string semExh, short? semPoints, float? semBack1, float? semBack2, float? semBack3, short? swimoffHeat, short? swimoffLane, string swimoffStat, float? swimoffTime, string swimoffCourse, short? swimoffHeatplace, short? swimoffPlace, short? swimoffJdplace, short? swimoffPoints, float? swimoffBack1, float? swimoffBack2, float? swimoffBack3, float? jDEvScore, short? seedPlace, string fin_heatltr, short? event_age, float? preWatch1, float? prePad, float? semWatch1, float? semPad, float? finWatch1, float? finPad, string finDqcode, string preDqcode, string semDqcode, string finDqcodeSecond, string preDqcodeSecond, string semDqcodeSecond, string finTimeType, string preTimeType, string semTimeType, float? finDolphin1, float? finDolphin2, float? finDolphin3, float? preDolphin1, float? preDolphin2, float? preDolphin3, float? semDolphin1, float? semDolphin2, float? semDolphin3, bool early_seed, bool super_prefinalist, bool super_finfinalist, string fin_adjuststat, string pre_adjuststat, string sem_adjuststat, string fin_divingdd, string pre_divingdd, string sem_divingdd, string entry_method, long? fin_dqofficial, long? pre_dqofficial, long? sem_dqofficial, bool pre_contacted, string finReactiontime1, string preReactiontime1, string semReactiontime1, bool pEarlySeed )
{
static public List<Entry> Get(OdbcConnection connection)
{
  var collection = new List<Entry>();
  string query = "select * from Entry";
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
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Ath_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* ActSeed_course nullable false*/
  var arg3 = reader.IsDBNull(3) ? (float?)null :reader.GetFloat(3); /* ActualSeed_time nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* ConvSeed_course nullable false*/
  var arg5 = reader.IsDBNull(5) ? (float?)null :reader.GetFloat(5); /* ConvSeed_time nullable true*/
  var arg6 = reader.GetBoolean(6); /* Scr_stat nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Spec_stat nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Dec_stat nullable false*/
  var arg9 = reader.GetBoolean(9); /* Alt_stat nullable false*/
  var arg10 = reader.GetBoolean(10); /* Bonus_event nullable false*/
  var arg11 = reader.IsDBNull(11) ? (long?)null :reader.GetInt32(11); /* Div_no nullable true*/
  var arg12 = reader.IsDBNull(12) ? (float?)null :reader.GetFloat(12); /* Ev_score nullable true*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* dq_type nullable false*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* Pre_heat nullable true*/
  var arg15 = reader.IsDBNull(15) ? (short?)null :reader.GetInt16(15); /* Pre_lane nullable true*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Pre_stat nullable false*/
  var arg17 = reader.IsDBNull(17) ? (float?)null :reader.GetFloat(17); /* Pre_Time nullable true*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* Pre_course nullable false*/
  var arg19 = reader.IsDBNull(19) ? (short?)null :reader.GetInt16(19); /* Pre_heatplace nullable true*/
  var arg20 = reader.IsDBNull(20) ? (short?)null :reader.GetInt16(20); /* Pre_place nullable true*/
  var arg21 = reader.IsDBNull(21) ? (short?)null :reader.GetInt16(21); /* Pre_jdplace nullable true*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* Pre_exh nullable false*/
  var arg23 = reader.IsDBNull(23) ? (short?)null :reader.GetInt16(23); /* Pre_points nullable true*/
  var arg24 = reader.IsDBNull(24) ? (float?)null :reader.GetFloat(24); /* Pre_back1 nullable true*/
  var arg25 = reader.IsDBNull(25) ? (float?)null :reader.GetFloat(25); /* Pre_back2 nullable true*/
  var arg26 = reader.IsDBNull(26) ? (float?)null :reader.GetFloat(26); /* Pre_back3 nullable true*/
  var arg27 = reader.IsDBNull(27) ? (short?)null :reader.GetInt16(27); /* Fin_heat nullable true*/
  var arg28 = reader.IsDBNull(28) ? (short?)null :reader.GetInt16(28); /* Fin_lane nullable true*/
  var arg29 = reader.IsDBNull(29) ? (short?)null :reader.GetInt16(29); /* Fin_group nullable true*/
  var arg30 = reader.GetTextReader(30).ReadLine(); /* Fin_stat nullable false*/
  var arg31 = reader.IsDBNull(31) ? (float?)null :reader.GetFloat(31); /* Fin_Time nullable true*/
  var arg32 = reader.GetTextReader(32).ReadLine(); /* Fin_course nullable false*/
  var arg33 = reader.IsDBNull(33) ? (short?)null :reader.GetInt16(33); /* Fin_heatplace nullable true*/
  var arg34 = reader.IsDBNull(34) ? (short?)null :reader.GetInt16(34); /* Fin_jdheatplace nullable true*/
  var arg35 = reader.IsDBNull(35) ? (short?)null :reader.GetInt16(35); /* Fin_place nullable true*/
  var arg36 = reader.IsDBNull(36) ? (short?)null :reader.GetInt16(36); /* Fin_jdplace nullable true*/
  var arg37 = reader.IsDBNull(37) ? (short?)null :reader.GetInt16(37); /* Fin_ptsplace nullable true*/
  var arg38 = reader.GetTextReader(38).ReadLine(); /* Fin_exh nullable false*/
  var arg39 = reader.IsDBNull(39) ? (short?)null :reader.GetInt16(39); /* Fin_points nullable true*/
  var arg40 = reader.IsDBNull(40) ? (float?)null :reader.GetFloat(40); /* Fin_back1 nullable true*/
  var arg41 = reader.IsDBNull(41) ? (float?)null :reader.GetFloat(41); /* Fin_back2 nullable true*/
  var arg42 = reader.IsDBNull(42) ? (float?)null :reader.GetFloat(42); /* Fin_back3 nullable true*/
  var arg43 = reader.IsDBNull(43) ? (short?)null :reader.GetInt16(43); /* Sem_heat nullable true*/
  var arg44 = reader.IsDBNull(44) ? (short?)null :reader.GetInt16(44); /* Sem_lane nullable true*/
  var arg45 = reader.GetTextReader(45).ReadLine(); /* Sem_stat nullable false*/
  var arg46 = reader.IsDBNull(46) ? (float?)null :reader.GetFloat(46); /* Sem_Time nullable true*/
  var arg47 = reader.GetTextReader(47).ReadLine(); /* Sem_course nullable false*/
  var arg48 = reader.IsDBNull(48) ? (short?)null :reader.GetInt16(48); /* Sem_heatplace nullable true*/
  var arg49 = reader.IsDBNull(49) ? (short?)null :reader.GetInt16(49); /* Sem_place nullable true*/
  var arg50 = reader.IsDBNull(50) ? (short?)null :reader.GetInt16(50); /* Sem_jdplace nullable true*/
  var arg51 = reader.GetTextReader(51).ReadLine(); /* Sem_exh nullable false*/
  var arg52 = reader.IsDBNull(52) ? (short?)null :reader.GetInt16(52); /* Sem_points nullable true*/
  var arg53 = reader.IsDBNull(53) ? (float?)null :reader.GetFloat(53); /* Sem_back1 nullable true*/
  var arg54 = reader.IsDBNull(54) ? (float?)null :reader.GetFloat(54); /* Sem_back2 nullable true*/
  var arg55 = reader.IsDBNull(55) ? (float?)null :reader.GetFloat(55); /* Sem_back3 nullable true*/
  var arg56 = reader.IsDBNull(56) ? (short?)null :reader.GetInt16(56); /* Swimoff_heat nullable true*/
  var arg57 = reader.IsDBNull(57) ? (short?)null :reader.GetInt16(57); /* Swimoff_lane nullable true*/
  var arg58 = reader.GetTextReader(58).ReadLine(); /* Swimoff_stat nullable false*/
  var arg59 = reader.IsDBNull(59) ? (float?)null :reader.GetFloat(59); /* Swimoff_Time nullable true*/
  var arg60 = reader.GetTextReader(60).ReadLine(); /* Swimoff_course nullable false*/
  var arg61 = reader.IsDBNull(61) ? (short?)null :reader.GetInt16(61); /* Swimoff_heatplace nullable true*/
  var arg62 = reader.IsDBNull(62) ? (short?)null :reader.GetInt16(62); /* Swimoff_place nullable true*/
  var arg63 = reader.IsDBNull(63) ? (short?)null :reader.GetInt16(63); /* Swimoff_jdplace nullable true*/
  var arg64 = reader.IsDBNull(64) ? (short?)null :reader.GetInt16(64); /* Swimoff_points nullable true*/
  var arg65 = reader.IsDBNull(65) ? (float?)null :reader.GetFloat(65); /* Swimoff_back1 nullable true*/
  var arg66 = reader.IsDBNull(66) ? (float?)null :reader.GetFloat(66); /* Swimoff_back2 nullable true*/
  var arg67 = reader.IsDBNull(67) ? (float?)null :reader.GetFloat(67); /* Swimoff_back3 nullable true*/
  var arg68 = reader.IsDBNull(68) ? (float?)null :reader.GetFloat(68); /* JDEv_score nullable true*/
  var arg69 = reader.IsDBNull(69) ? (short?)null :reader.GetInt16(69); /* Seed_place nullable true*/
  var arg70 = reader.GetTextReader(70).ReadLine(); /* fin_heatltr nullable false*/
  var arg71 = reader.IsDBNull(71) ? (short?)null :reader.GetInt16(71); /* event_age nullable true*/
  var arg72 = reader.IsDBNull(72) ? (float?)null :reader.GetFloat(72); /* Pre_watch1 nullable true*/
  var arg73 = reader.IsDBNull(73) ? (float?)null :reader.GetFloat(73); /* Pre_pad nullable true*/
  var arg74 = reader.IsDBNull(74) ? (float?)null :reader.GetFloat(74); /* Sem_watch1 nullable true*/
  var arg75 = reader.IsDBNull(75) ? (float?)null :reader.GetFloat(75); /* Sem_pad nullable true*/
  var arg76 = reader.IsDBNull(76) ? (float?)null :reader.GetFloat(76); /* Fin_watch1 nullable true*/
  var arg77 = reader.IsDBNull(77) ? (float?)null :reader.GetFloat(77); /* Fin_pad nullable true*/
  var arg78 = reader.GetTextReader(78).ReadLine(); /* Fin_dqcode nullable false*/
  var arg79 = reader.GetTextReader(79).ReadLine(); /* Pre_dqcode nullable false*/
  var arg80 = reader.GetTextReader(80).ReadLine(); /* Sem_dqcode nullable false*/
  var arg81 = reader.GetTextReader(81).ReadLine(); /* Fin_dqcodeSecond nullable false*/
  var arg82 = reader.GetTextReader(82).ReadLine(); /* Pre_dqcodeSecond nullable false*/
  var arg83 = reader.GetTextReader(83).ReadLine(); /* Sem_dqcodeSecond nullable false*/
  var arg84 = reader.GetTextReader(84).ReadLine(); /* Fin_TimeType nullable false*/
  var arg85 = reader.GetTextReader(85).ReadLine(); /* Pre_TimeType nullable false*/
  var arg86 = reader.GetTextReader(86).ReadLine(); /* Sem_TimeType nullable false*/
  var arg87 = reader.IsDBNull(87) ? (float?)null :reader.GetFloat(87); /* Fin_dolphin1 nullable true*/
  var arg88 = reader.IsDBNull(88) ? (float?)null :reader.GetFloat(88); /* Fin_dolphin2 nullable true*/
  var arg89 = reader.IsDBNull(89) ? (float?)null :reader.GetFloat(89); /* Fin_dolphin3 nullable true*/
  var arg90 = reader.IsDBNull(90) ? (float?)null :reader.GetFloat(90); /* Pre_dolphin1 nullable true*/
  var arg91 = reader.IsDBNull(91) ? (float?)null :reader.GetFloat(91); /* Pre_dolphin2 nullable true*/
  var arg92 = reader.IsDBNull(92) ? (float?)null :reader.GetFloat(92); /* Pre_dolphin3 nullable true*/
  var arg93 = reader.IsDBNull(93) ? (float?)null :reader.GetFloat(93); /* Sem_dolphin1 nullable true*/
  var arg94 = reader.IsDBNull(94) ? (float?)null :reader.GetFloat(94); /* Sem_dolphin2 nullable true*/
  var arg95 = reader.IsDBNull(95) ? (float?)null :reader.GetFloat(95); /* Sem_dolphin3 nullable true*/
  var arg96 = reader.GetBoolean(96); /* early_seed nullable false*/
  var arg97 = reader.GetBoolean(97); /* super_prefinalist nullable false*/
  var arg98 = reader.GetBoolean(98); /* super_finfinalist nullable false*/
  var arg99 = reader.GetTextReader(99).ReadLine(); /* fin_adjuststat nullable false*/
  var arg100 = reader.GetTextReader(100).ReadLine(); /* pre_adjuststat nullable false*/
  var arg101 = reader.GetTextReader(101).ReadLine(); /* sem_adjuststat nullable false*/
  var arg102 = reader.GetTextReader(102).ReadLine(); /* fin_divingdd nullable false*/
  var arg103 = reader.GetTextReader(103).ReadLine(); /* pre_divingdd nullable false*/
  var arg104 = reader.GetTextReader(104).ReadLine(); /* sem_divingdd nullable false*/
  var arg105 = reader.GetTextReader(105).ReadLine(); /* entry_method nullable false*/
  var arg106 = reader.IsDBNull(106) ? (long?)null :reader.GetInt32(106); /* fin_dqofficial nullable true*/
  var arg107 = reader.IsDBNull(107) ? (long?)null :reader.GetInt32(107); /* pre_dqofficial nullable true*/
  var arg108 = reader.IsDBNull(108) ? (long?)null :reader.GetInt32(108); /* sem_dqofficial nullable true*/
  var arg109 = reader.GetBoolean(109); /* pre_contacted nullable false*/
  var arg110 = reader.GetTextReader(110).ReadLine(); /* Fin_reactiontime1 nullable false*/
  var arg111 = reader.GetTextReader(111).ReadLine(); /* Pre_reactiontime1 nullable false*/
  var arg112 = reader.GetTextReader(112).ReadLine(); /* Sem_reactiontime1 nullable false*/
  var arg113 = reader.GetBoolean(113); /* P_early_seed nullable false*/
      collection.Add( new Entry(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99, arg100, arg101, arg102, arg103, arg104, arg105, arg106, arg107, arg108, arg109, arg110, arg111, arg112, arg113));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public long? AthNo{ get; } = athNo;
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
  public short? SeedPlace{ get; } = seedPlace;
  public string Fin_heatltr{ get; } = fin_heatltr;
  public short? Event_age{ get; } = event_age;
  public float? PreWatch1{ get; } = preWatch1;
  public float? PrePad{ get; } = prePad;
  public float? SemWatch1{ get; } = semWatch1;
  public float? SemPad{ get; } = semPad;
  public float? FinWatch1{ get; } = finWatch1;
  public float? FinPad{ get; } = finPad;
  public string FinDqcode{ get; } = finDqcode;
  public string PreDqcode{ get; } = preDqcode;
  public string SemDqcode{ get; } = semDqcode;
  public string FinDqcodeSecond{ get; } = finDqcodeSecond;
  public string PreDqcodeSecond{ get; } = preDqcodeSecond;
  public string SemDqcodeSecond{ get; } = semDqcodeSecond;
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
  public bool Super_prefinalist{ get; } = super_prefinalist;
  public bool Super_finfinalist{ get; } = super_finfinalist;
  public string Fin_adjuststat{ get; } = fin_adjuststat;
  public string Pre_adjuststat{ get; } = pre_adjuststat;
  public string Sem_adjuststat{ get; } = sem_adjuststat;
  public string Fin_divingdd{ get; } = fin_divingdd;
  public string Pre_divingdd{ get; } = pre_divingdd;
  public string Sem_divingdd{ get; } = sem_divingdd;
  public string Entry_method{ get; } = entry_method;
  public long? Fin_dqofficial{ get; } = fin_dqofficial;
  public long? Pre_dqofficial{ get; } = pre_dqofficial;
  public long? Sem_dqofficial{ get; } = sem_dqofficial;
  public bool Pre_contacted{ get; } = pre_contacted;
  public string FinReactiontime1{ get; } = finReactiontime1;
  public string PreReactiontime1{ get; } = preReactiontime1;
  public string SemReactiontime1{ get; } = semReactiontime1;
  public bool PEarlySeed{ get; } = pEarlySeed;
}
}
}
