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
/// CREATE TABLE [Relay]
/// (
/// [Event_ptr] Long Integer,
/// [Team_no] Long Integer,
/// [Team_ltr] Text (2),
/// [Rel_age] Integer,
/// [Rel_sex] Text (2),
/// [ActSeed_course] Text (2),
/// [ActualSeed_time] Single,
/// [ConvSeed_course] Text (2),
/// [ConvSeed_time] Single,
/// [Scr_stat] Boolean NOT NULL,
/// [Spec_stat] Text (2),
/// [Dec_stat] Text (2),
/// [Alt_stat] Boolean NOT NULL,
/// [Bonus_event] Boolean NOT NULL,
/// [Div_no] Long Integer,
/// [Ev_score] Single,
/// [dq_type] Text (2),
/// [Pre_heat] Integer,
/// [Pre_lane] Integer,
/// [Pre_stat] Text (2),
/// [Pre_Time] Single,
/// [Pre_course] Text (2),
/// [Pre_heatplace] Integer,
/// [Pre_place] Integer,
/// [Pre_jdplace] Integer,
/// [Pre_exh] Text (2),
/// [Pre_points] Integer,
/// [Pre_back1] Single,
/// [Pre_back2] Single,
/// [Pre_back3] Single,
/// [Fin_heat] Integer,
/// [Fin_lane] Integer,
/// [Fin_group] Integer,
/// [Fin_stat] Text (2),
/// [Fin_Time] Single,
/// [Fin_course] Text (2),
/// [Fin_heatplace] Integer,
/// [Fin_jdheatplace] Integer,
/// [Fin_place] Integer,
/// [Fin_jdplace] Integer,
/// [Fin_ptsplace] Integer,
/// [Fin_exh] Text (2),
/// [Fin_points] Integer,
/// [Fin_back1] Single,
/// [Fin_back2] Single,
/// [Fin_back3] Single,
/// [Sem_heat] Integer,
/// [Sem_lane] Integer,
/// [Sem_stat] Text (2),
/// [Sem_Time] Single,
/// [Sem_course] Text (2),
/// [Sem_heatplace] Integer,
/// [Sem_place] Integer,
/// [Sem_jdplace] Integer,
/// [Sem_exh] Text (2),
/// [Sem_points] Integer,
/// [Sem_back1] Single,
/// [Sem_back2] Single,
/// [Sem_back3] Single,
/// [Swimoff_heat] Integer,
/// [Swimoff_lane] Integer,
/// [Swimoff_stat] Text (2),
/// [Swimoff_Time] Single,
/// [Swimoff_course] Text (2),
/// [Swimoff_heatplace] Integer,
/// [Swimoff_place] Integer,
/// [Swimoff_jdplace] Integer,
/// [Swimoff_points] Integer,
/// [Swimoff_back1] Single,
/// [Swimoff_back2] Single,
/// [Swimoff_back3] Single,
/// [JDEv_score] Single,
/// [Relay_no] Long Integer,
/// [Seed_place] Integer,
/// [fin_heatltr] Text (2),
/// [Pre_watch1] Single,
/// [Pre_pad] Single,
/// [Sem_watch1] Single,
/// [Sem_pad] Single,
/// [Fin_watch1] Single,
/// [Fin_pad] Single,
/// [Fin_reactiontime1] Text (10),
/// [Pre_reactiontime1] Text (10),
/// [Sem_reactiontime1] Text (10),
/// [Fin_dqcode] Text (4),
/// [Pre_dqcode] Text (4),
/// [Sem_dqcode] Text (4),
/// [Fin_dqcodeSecond] Text (4),
/// [Pre_dqcodeSecond] Text (4),
/// [Sem_dqcodeSecond] Text (4),
/// [Fin_reactiontime2] Text (10),
/// [Pre_reactiontime2] Text (10),
/// [Sem_reactiontime2] Text (10),
/// [Fin_reactiontime3] Text (10),
/// [Pre_reactiontime3] Text (10),
/// [Sem_reactiontime3] Text (10),
/// [Fin_reactiontime4] Text (10),
/// [Pre_reactiontime4] Text (10),
/// [Sem_reactiontime4] Text (10),
/// [Fin_TimeType] Text (2),
/// [Pre_TimeType] Text (2),
/// [Sem_TimeType] Text (2),
/// [Fin_dolphin1] Single,
/// [Fin_dolphin2] Single,
/// [Fin_dolphin3] Single,
/// [Pre_dolphin1] Single,
/// [Pre_dolphin2] Single,
/// [Pre_dolphin3] Single,
/// [Sem_dolphin1] Single,
/// [Sem_dolphin2] Single,
/// [Sem_dolphin3] Single,
/// [early_seed] Boolean NOT NULL,
/// [fin_adjuststat] Text (2),
/// [pre_adjuststat] Text (2),
/// [sem_adjuststat] Text (2),
/// [entry_method] Text (2),
/// [fin_dqofficial] Long Integer,
/// [pre_dqofficial] Long Integer,
/// [sem_dqofficial] Long Integer,
/// [pre_contacted] Boolean NOT NULL
/// );

public class MmRelay 
{
List<MmRelay> get(OdbcConnection connection)
{
  var collection = new List<MmRelay>();
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
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt64(2); /* Team_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* Team_ltr */
      var arg3 = reader.GetInt16(4); /* Rel_age */
      var arg4 = reader.GetTextReader(5).ToString(); /* Rel_sex */
      var arg5 = reader.GetTextReader(6).ToString(); /* ActSeed_course */
      var arg6 = reader.GetFloat(7); /* ActualSeed_time */
      var arg7 = reader.GetTextReader(8).ToString(); /* ConvSeed_course */
      var arg8 = reader.GetFloat(9); /* ConvSeed_time */
      var arg9 = reader.GetBoolean(10); /* Scr_stat */
      var arg10 = reader.GetTextReader(11).ToString(); /* Spec_stat */
      var arg11 = reader.GetTextReader(12).ToString(); /* Dec_stat */
      var arg12 = reader.GetBoolean(13); /* Alt_stat */
      var arg13 = reader.GetBoolean(14); /* Bonus_event */
      var arg14 = reader.GetInt64(15); /* Div_no */
      var arg15 = reader.GetFloat(16); /* Ev_score */
      var arg16 = reader.GetTextReader(17).ToString(); /* dq_type */
      var arg17 = reader.GetInt16(18); /* Pre_heat */
      var arg18 = reader.GetInt16(19); /* Pre_lane */
      var arg19 = reader.GetTextReader(20).ToString(); /* Pre_stat */
      var arg20 = reader.GetFloat(21); /* Pre_Time */
      var arg21 = reader.GetTextReader(22).ToString(); /* Pre_course */
      var arg22 = reader.GetInt16(23); /* Pre_heatplace */
      var arg23 = reader.GetInt16(24); /* Pre_place */
      var arg24 = reader.GetInt16(25); /* Pre_jdplace */
      var arg25 = reader.GetTextReader(26).ToString(); /* Pre_exh */
      var arg26 = reader.GetInt16(27); /* Pre_points */
      var arg27 = reader.GetFloat(28); /* Pre_back1 */
      var arg28 = reader.GetFloat(29); /* Pre_back2 */
      var arg29 = reader.GetFloat(30); /* Pre_back3 */
      var arg30 = reader.GetInt16(31); /* Fin_heat */
      var arg31 = reader.GetInt16(32); /* Fin_lane */
      var arg32 = reader.GetInt16(33); /* Fin_group */
      var arg33 = reader.GetTextReader(34).ToString(); /* Fin_stat */
      var arg34 = reader.GetFloat(35); /* Fin_Time */
      var arg35 = reader.GetTextReader(36).ToString(); /* Fin_course */
      var arg36 = reader.GetInt16(37); /* Fin_heatplace */
      var arg37 = reader.GetInt16(38); /* Fin_jdheatplace */
      var arg38 = reader.GetInt16(39); /* Fin_place */
      var arg39 = reader.GetInt16(40); /* Fin_jdplace */
      var arg40 = reader.GetInt16(41); /* Fin_ptsplace */
      var arg41 = reader.GetTextReader(42).ToString(); /* Fin_exh */
      var arg42 = reader.GetInt16(43); /* Fin_points */
      var arg43 = reader.GetFloat(44); /* Fin_back1 */
      var arg44 = reader.GetFloat(45); /* Fin_back2 */
      var arg45 = reader.GetFloat(46); /* Fin_back3 */
      var arg46 = reader.GetInt16(47); /* Sem_heat */
      var arg47 = reader.GetInt16(48); /* Sem_lane */
      var arg48 = reader.GetTextReader(49).ToString(); /* Sem_stat */
      var arg49 = reader.GetFloat(50); /* Sem_Time */
      var arg50 = reader.GetTextReader(51).ToString(); /* Sem_course */
      var arg51 = reader.GetInt16(52); /* Sem_heatplace */
      var arg52 = reader.GetInt16(53); /* Sem_place */
      var arg53 = reader.GetInt16(54); /* Sem_jdplace */
      var arg54 = reader.GetTextReader(55).ToString(); /* Sem_exh */
      var arg55 = reader.GetInt16(56); /* Sem_points */
      var arg56 = reader.GetFloat(57); /* Sem_back1 */
      var arg57 = reader.GetFloat(58); /* Sem_back2 */
      var arg58 = reader.GetFloat(59); /* Sem_back3 */
      var arg59 = reader.GetInt16(60); /* Swimoff_heat */
      var arg60 = reader.GetInt16(61); /* Swimoff_lane */
      var arg61 = reader.GetTextReader(62).ToString(); /* Swimoff_stat */
      var arg62 = reader.GetFloat(63); /* Swimoff_Time */
      var arg63 = reader.GetTextReader(64).ToString(); /* Swimoff_course */
      var arg64 = reader.GetInt16(65); /* Swimoff_heatplace */
      var arg65 = reader.GetInt16(66); /* Swimoff_place */
      var arg66 = reader.GetInt16(67); /* Swimoff_jdplace */
      var arg67 = reader.GetInt16(68); /* Swimoff_points */
      var arg68 = reader.GetFloat(69); /* Swimoff_back1 */
      var arg69 = reader.GetFloat(70); /* Swimoff_back2 */
      var arg70 = reader.GetFloat(71); /* Swimoff_back3 */
      var arg71 = reader.GetFloat(72); /* JDEv_score */
      var arg72 = reader.GetInt64(73); /* Relay_no */
      var arg73 = reader.GetInt16(74); /* Seed_place */
      var arg74 = reader.GetTextReader(75).ToString(); /* fin_heatltr */
      var arg75 = reader.GetFloat(76); /* Pre_watch1 */
      var arg76 = reader.GetFloat(77); /* Pre_pad */
      var arg77 = reader.GetFloat(78); /* Sem_watch1 */
      var arg78 = reader.GetFloat(79); /* Sem_pad */
      var arg79 = reader.GetFloat(80); /* Fin_watch1 */
      var arg80 = reader.GetFloat(81); /* Fin_pad */
      var arg81 = reader.GetTextReader(82).ToString(); /* Fin_reactiontime1 */
      var arg82 = reader.GetTextReader(83).ToString(); /* Pre_reactiontime1 */
      var arg83 = reader.GetTextReader(84).ToString(); /* Sem_reactiontime1 */
      var arg84 = reader.GetTextReader(85).ToString(); /* Fin_dqcode */
      var arg85 = reader.GetTextReader(86).ToString(); /* Pre_dqcode */
      var arg86 = reader.GetTextReader(87).ToString(); /* Sem_dqcode */
      var arg87 = reader.GetTextReader(88).ToString(); /* Fin_dqcodeSecond */
      var arg88 = reader.GetTextReader(89).ToString(); /* Pre_dqcodeSecond */
      var arg89 = reader.GetTextReader(90).ToString(); /* Sem_dqcodeSecond */
      var arg90 = reader.GetTextReader(91).ToString(); /* Fin_reactiontime2 */
      var arg91 = reader.GetTextReader(92).ToString(); /* Pre_reactiontime2 */
      var arg92 = reader.GetTextReader(93).ToString(); /* Sem_reactiontime2 */
      var arg93 = reader.GetTextReader(94).ToString(); /* Fin_reactiontime3 */
      var arg94 = reader.GetTextReader(95).ToString(); /* Pre_reactiontime3 */
      var arg95 = reader.GetTextReader(96).ToString(); /* Sem_reactiontime3 */
      var arg96 = reader.GetTextReader(97).ToString(); /* Fin_reactiontime4 */
      var arg97 = reader.GetTextReader(98).ToString(); /* Pre_reactiontime4 */
      var arg98 = reader.GetTextReader(99).ToString(); /* Sem_reactiontime4 */
      var arg99 = reader.GetTextReader(100).ToString(); /* Fin_TimeType */
      var arg100 = reader.GetTextReader(101).ToString(); /* Pre_TimeType */
      var arg101 = reader.GetTextReader(102).ToString(); /* Sem_TimeType */
      var arg102 = reader.GetFloat(103); /* Fin_dolphin1 */
      var arg103 = reader.GetFloat(104); /* Fin_dolphin2 */
      var arg104 = reader.GetFloat(105); /* Fin_dolphin3 */
      var arg105 = reader.GetFloat(106); /* Pre_dolphin1 */
      var arg106 = reader.GetFloat(107); /* Pre_dolphin2 */
      var arg107 = reader.GetFloat(108); /* Pre_dolphin3 */
      var arg108 = reader.GetFloat(109); /* Sem_dolphin1 */
      var arg109 = reader.GetFloat(110); /* Sem_dolphin2 */
      var arg110 = reader.GetFloat(111); /* Sem_dolphin3 */
      var arg111 = reader.GetBoolean(112); /* early_seed */
      var arg112 = reader.GetTextReader(113).ToString(); /* fin_adjuststat */
      var arg113 = reader.GetTextReader(114).ToString(); /* pre_adjuststat */
      var arg114 = reader.GetTextReader(115).ToString(); /* sem_adjuststat */
      var arg115 = reader.GetTextReader(116).ToString(); /* entry_method */
      var arg116 = reader.GetInt64(117); /* fin_dqofficial */
      var arg117 = reader.GetInt64(118); /* pre_dqofficial */
      var arg118 = reader.GetInt64(119); /* sem_dqofficial */
      var arg119 = reader.GetBoolean(120); /* pre_contacted */
      collection.Add( new MmRelay(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99, arg100, arg101, arg102, arg103, arg104, arg105, arg106, arg107, arg108, arg109, arg110, arg111, arg112, arg113, arg114, arg115, arg116, arg117, arg118, arg119));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public long TeamNo{ get; }
  public string TeamLtr{ get; }
  public short RelAge{ get; }
  public string RelSex{ get; }
  public string ActSeedCourse{ get; }
  public float ActualSeedTime{ get; }
  public string ConvSeedCourse{ get; }
  public float ConvSeedTime{ get; }
  public bool ScrStat{ get; }
  public string SpecStat{ get; }
  public string DecStat{ get; }
  public bool AltStat{ get; }
  public bool BonusEvent{ get; }
  public long DivNo{ get; }
  public float EvScore{ get; }
  public string Dq_type{ get; }
  public short PreHeat{ get; }
  public short PreLane{ get; }
  public string PreStat{ get; }
  public float PreTime{ get; }
  public string PreCourse{ get; }
  public short PreHeatplace{ get; }
  public short PrePlace{ get; }
  public short PreJdplace{ get; }
  public string PreExh{ get; }
  public short PrePoints{ get; }
  public float PreBack1{ get; }
  public float PreBack2{ get; }
  public float PreBack3{ get; }
  public short FinHeat{ get; }
  public short FinLane{ get; }
  public short FinGroup{ get; }
  public string FinStat{ get; }
  public float FinTime{ get; }
  public string FinCourse{ get; }
  public short FinHeatplace{ get; }
  public short FinJdheatplace{ get; }
  public short FinPlace{ get; }
  public short FinJdplace{ get; }
  public short FinPtsplace{ get; }
  public string FinExh{ get; }
  public short FinPoints{ get; }
  public float FinBack1{ get; }
  public float FinBack2{ get; }
  public float FinBack3{ get; }
  public short SemHeat{ get; }
  public short SemLane{ get; }
  public string SemStat{ get; }
  public float SemTime{ get; }
  public string SemCourse{ get; }
  public short SemHeatplace{ get; }
  public short SemPlace{ get; }
  public short SemJdplace{ get; }
  public string SemExh{ get; }
  public short SemPoints{ get; }
  public float SemBack1{ get; }
  public float SemBack2{ get; }
  public float SemBack3{ get; }
  public short SwimoffHeat{ get; }
  public short SwimoffLane{ get; }
  public string SwimoffStat{ get; }
  public float SwimoffTime{ get; }
  public string SwimoffCourse{ get; }
  public short SwimoffHeatplace{ get; }
  public short SwimoffPlace{ get; }
  public short SwimoffJdplace{ get; }
  public short SwimoffPoints{ get; }
  public float SwimoffBack1{ get; }
  public float SwimoffBack2{ get; }
  public float SwimoffBack3{ get; }
  public float JDEvScore{ get; }
  public long RelayNo{ get; }
  public short SeedPlace{ get; }
  public string Fin_heatltr{ get; }
  public float PreWatch1{ get; }
  public float PrePad{ get; }
  public float SemWatch1{ get; }
  public float SemPad{ get; }
  public float FinWatch1{ get; }
  public float FinPad{ get; }
  public string FinReactiontime1{ get; }
  public string PreReactiontime1{ get; }
  public string SemReactiontime1{ get; }
  public string FinDqcode{ get; }
  public string PreDqcode{ get; }
  public string SemDqcode{ get; }
  public string FinDqcodeSecond{ get; }
  public string PreDqcodeSecond{ get; }
  public string SemDqcodeSecond{ get; }
  public string FinReactiontime2{ get; }
  public string PreReactiontime2{ get; }
  public string SemReactiontime2{ get; }
  public string FinReactiontime3{ get; }
  public string PreReactiontime3{ get; }
  public string SemReactiontime3{ get; }
  public string FinReactiontime4{ get; }
  public string PreReactiontime4{ get; }
  public string SemReactiontime4{ get; }
  public string FinTimeType{ get; }
  public string PreTimeType{ get; }
  public string SemTimeType{ get; }
  public float FinDolphin1{ get; }
  public float FinDolphin2{ get; }
  public float FinDolphin3{ get; }
  public float PreDolphin1{ get; }
  public float PreDolphin2{ get; }
  public float PreDolphin3{ get; }
  public float SemDolphin1{ get; }
  public float SemDolphin2{ get; }
  public float SemDolphin3{ get; }
  public bool Early_seed{ get; }
  public string Fin_adjuststat{ get; }
  public string Pre_adjuststat{ get; }
  public string Sem_adjuststat{ get; }
  public string Entry_method{ get; }
  public long Fin_dqofficial{ get; }
  public long Pre_dqofficial{ get; }
  public long Sem_dqofficial{ get; }
  public bool Pre_contacted{ get; }
  // Constructor
  MmRelay(long eventPtr, long teamNo, string teamLtr, short relAge, string relSex, string actSeedCourse, float actualSeedTime, string convSeedCourse, float convSeedTime, bool scrStat, string specStat, string decStat, bool altStat, bool bonusEvent, long divNo, float evScore, string dq_type, short preHeat, short preLane, string preStat, float preTime, string preCourse, short preHeatplace, short prePlace, short preJdplace, string preExh, short prePoints, float preBack1, float preBack2, float preBack3, short finHeat, short finLane, short finGroup, string finStat, float finTime, string finCourse, short finHeatplace, short finJdheatplace, short finPlace, short finJdplace, short finPtsplace, string finExh, short finPoints, float finBack1, float finBack2, float finBack3, short semHeat, short semLane, string semStat, float semTime, string semCourse, short semHeatplace, short semPlace, short semJdplace, string semExh, short semPoints, float semBack1, float semBack2, float semBack3, short swimoffHeat, short swimoffLane, string swimoffStat, float swimoffTime, string swimoffCourse, short swimoffHeatplace, short swimoffPlace, short swimoffJdplace, short swimoffPoints, float swimoffBack1, float swimoffBack2, float swimoffBack3, float jDEvScore, long relayNo, short seedPlace, string fin_heatltr, float preWatch1, float prePad, float semWatch1, float semPad, float finWatch1, float finPad, string finReactiontime1, string preReactiontime1, string semReactiontime1, string finDqcode, string preDqcode, string semDqcode, string finDqcodeSecond, string preDqcodeSecond, string semDqcodeSecond, string finReactiontime2, string preReactiontime2, string semReactiontime2, string finReactiontime3, string preReactiontime3, string semReactiontime3, string finReactiontime4, string preReactiontime4, string semReactiontime4, string finTimeType, string preTimeType, string semTimeType, float finDolphin1, float finDolphin2, float finDolphin3, float preDolphin1, float preDolphin2, float preDolphin3, float semDolphin1, float semDolphin2, float semDolphin3, bool early_seed, string fin_adjuststat, string pre_adjuststat, string sem_adjuststat, string entry_method, long fin_dqofficial, long pre_dqofficial, long sem_dqofficial, bool pre_contacted )
  {
    EventPtr = eventPtr;
    TeamNo = teamNo;
    TeamLtr = teamLtr;
    RelAge = relAge;
    RelSex = relSex;
    ActSeedCourse = actSeedCourse;
    ActualSeedTime = actualSeedTime;
    ConvSeedCourse = convSeedCourse;
    ConvSeedTime = convSeedTime;
    ScrStat = scrStat;
    SpecStat = specStat;
    DecStat = decStat;
    AltStat = altStat;
    BonusEvent = bonusEvent;
    DivNo = divNo;
    EvScore = evScore;
    Dq_type = dq_type;
    PreHeat = preHeat;
    PreLane = preLane;
    PreStat = preStat;
    PreTime = preTime;
    PreCourse = preCourse;
    PreHeatplace = preHeatplace;
    PrePlace = prePlace;
    PreJdplace = preJdplace;
    PreExh = preExh;
    PrePoints = prePoints;
    PreBack1 = preBack1;
    PreBack2 = preBack2;
    PreBack3 = preBack3;
    FinHeat = finHeat;
    FinLane = finLane;
    FinGroup = finGroup;
    FinStat = finStat;
    FinTime = finTime;
    FinCourse = finCourse;
    FinHeatplace = finHeatplace;
    FinJdheatplace = finJdheatplace;
    FinPlace = finPlace;
    FinJdplace = finJdplace;
    FinPtsplace = finPtsplace;
    FinExh = finExh;
    FinPoints = finPoints;
    FinBack1 = finBack1;
    FinBack2 = finBack2;
    FinBack3 = finBack3;
    SemHeat = semHeat;
    SemLane = semLane;
    SemStat = semStat;
    SemTime = semTime;
    SemCourse = semCourse;
    SemHeatplace = semHeatplace;
    SemPlace = semPlace;
    SemJdplace = semJdplace;
    SemExh = semExh;
    SemPoints = semPoints;
    SemBack1 = semBack1;
    SemBack2 = semBack2;
    SemBack3 = semBack3;
    SwimoffHeat = swimoffHeat;
    SwimoffLane = swimoffLane;
    SwimoffStat = swimoffStat;
    SwimoffTime = swimoffTime;
    SwimoffCourse = swimoffCourse;
    SwimoffHeatplace = swimoffHeatplace;
    SwimoffPlace = swimoffPlace;
    SwimoffJdplace = swimoffJdplace;
    SwimoffPoints = swimoffPoints;
    SwimoffBack1 = swimoffBack1;
    SwimoffBack2 = swimoffBack2;
    SwimoffBack3 = swimoffBack3;
    JDEvScore = jDEvScore;
    RelayNo = relayNo;
    SeedPlace = seedPlace;
    Fin_heatltr = fin_heatltr;
    PreWatch1 = preWatch1;
    PrePad = prePad;
    SemWatch1 = semWatch1;
    SemPad = semPad;
    FinWatch1 = finWatch1;
    FinPad = finPad;
    FinReactiontime1 = finReactiontime1;
    PreReactiontime1 = preReactiontime1;
    SemReactiontime1 = semReactiontime1;
    FinDqcode = finDqcode;
    PreDqcode = preDqcode;
    SemDqcode = semDqcode;
    FinDqcodeSecond = finDqcodeSecond;
    PreDqcodeSecond = preDqcodeSecond;
    SemDqcodeSecond = semDqcodeSecond;
    FinReactiontime2 = finReactiontime2;
    PreReactiontime2 = preReactiontime2;
    SemReactiontime2 = semReactiontime2;
    FinReactiontime3 = finReactiontime3;
    PreReactiontime3 = preReactiontime3;
    SemReactiontime3 = semReactiontime3;
    FinReactiontime4 = finReactiontime4;
    PreReactiontime4 = preReactiontime4;
    SemReactiontime4 = semReactiontime4;
    FinTimeType = finTimeType;
    PreTimeType = preTimeType;
    SemTimeType = semTimeType;
    FinDolphin1 = finDolphin1;
    FinDolphin2 = finDolphin2;
    FinDolphin3 = finDolphin3;
    PreDolphin1 = preDolphin1;
    PreDolphin2 = preDolphin2;
    PreDolphin3 = preDolphin3;
    SemDolphin1 = semDolphin1;
    SemDolphin2 = semDolphin2;
    SemDolphin3 = semDolphin3;
    Early_seed = early_seed;
    Fin_adjuststat = fin_adjuststat;
    Pre_adjuststat = pre_adjuststat;
    Sem_adjuststat = sem_adjuststat;
    Entry_method = entry_method;
    Fin_dqofficial = fin_dqofficial;
    Pre_dqofficial = pre_dqofficial;
    Sem_dqofficial = sem_dqofficial;
    Pre_contacted = pre_contacted;
  }
}
