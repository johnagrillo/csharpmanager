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
/// CREATE TABLE [Entry]
/// (
/// [Event_ptr] Long Integer,
/// [Ath_no] Long Integer,
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
/// [Seed_place] Integer,
/// [fin_heatltr] Text (2),
/// [event_age] Integer,
/// [Pre_watch1] Single,
/// [Pre_pad] Single,
/// [Sem_watch1] Single,
/// [Sem_pad] Single,
/// [Fin_watch1] Single,
/// [Fin_pad] Single,
/// [Fin_dqcode] Text (4),
/// [Pre_dqcode] Text (4),
/// [Sem_dqcode] Text (8),
/// [Fin_dqcodeSecond] Text (4),
/// [Pre_dqcodeSecond] Text (4),
/// [Sem_dqcodeSecond] Text (4),
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
/// [super_prefinalist] Boolean NOT NULL,
/// [super_finfinalist] Boolean NOT NULL,
/// [fin_adjuststat] Text (2),
/// [pre_adjuststat] Text (2),
/// [sem_adjuststat] Text (2),
/// [fin_divingdd] Text (8),
/// [pre_divingdd] Text (8),
/// [sem_divingdd] Text (8),
/// [entry_method] Text (2),
/// [fin_dqofficial] Long Integer,
/// [pre_dqofficial] Long Integer,
/// [sem_dqofficial] Long Integer,
/// [pre_contacted] Boolean NOT NULL,
/// [Fin_reactiontime1] Text (16),
/// [Pre_reactiontime1] Text (16),
/// [Sem_reactiontime1] Text (16),
/// [P_early_seed] Boolean NOT NULL
/// );

public class MmEntry 
{
List<MmEntry> get(OdbcConnection connection)
{
  var collection = new List<MmEntry>();
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
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt64(2); /* Ath_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* ActSeed_course */
      var arg3 = reader.GetFloat(4); /* ActualSeed_time */
      var arg4 = reader.GetTextReader(5).ToString(); /* ConvSeed_course */
      var arg5 = reader.GetFloat(6); /* ConvSeed_time */
      var arg6 = reader.GetBoolean(7); /* Scr_stat */
      var arg7 = reader.GetTextReader(8).ToString(); /* Spec_stat */
      var arg8 = reader.GetTextReader(9).ToString(); /* Dec_stat */
      var arg9 = reader.GetBoolean(10); /* Alt_stat */
      var arg10 = reader.GetBoolean(11); /* Bonus_event */
      var arg11 = reader.GetInt64(12); /* Div_no */
      var arg12 = reader.GetFloat(13); /* Ev_score */
      var arg13 = reader.GetTextReader(14).ToString(); /* dq_type */
      var arg14 = reader.GetInt16(15); /* Pre_heat */
      var arg15 = reader.GetInt16(16); /* Pre_lane */
      var arg16 = reader.GetTextReader(17).ToString(); /* Pre_stat */
      var arg17 = reader.GetFloat(18); /* Pre_Time */
      var arg18 = reader.GetTextReader(19).ToString(); /* Pre_course */
      var arg19 = reader.GetInt16(20); /* Pre_heatplace */
      var arg20 = reader.GetInt16(21); /* Pre_place */
      var arg21 = reader.GetInt16(22); /* Pre_jdplace */
      var arg22 = reader.GetTextReader(23).ToString(); /* Pre_exh */
      var arg23 = reader.GetInt16(24); /* Pre_points */
      var arg24 = reader.GetFloat(25); /* Pre_back1 */
      var arg25 = reader.GetFloat(26); /* Pre_back2 */
      var arg26 = reader.GetFloat(27); /* Pre_back3 */
      var arg27 = reader.GetInt16(28); /* Fin_heat */
      var arg28 = reader.GetInt16(29); /* Fin_lane */
      var arg29 = reader.GetInt16(30); /* Fin_group */
      var arg30 = reader.GetTextReader(31).ToString(); /* Fin_stat */
      var arg31 = reader.GetFloat(32); /* Fin_Time */
      var arg32 = reader.GetTextReader(33).ToString(); /* Fin_course */
      var arg33 = reader.GetInt16(34); /* Fin_heatplace */
      var arg34 = reader.GetInt16(35); /* Fin_jdheatplace */
      var arg35 = reader.GetInt16(36); /* Fin_place */
      var arg36 = reader.GetInt16(37); /* Fin_jdplace */
      var arg37 = reader.GetInt16(38); /* Fin_ptsplace */
      var arg38 = reader.GetTextReader(39).ToString(); /* Fin_exh */
      var arg39 = reader.GetInt16(40); /* Fin_points */
      var arg40 = reader.GetFloat(41); /* Fin_back1 */
      var arg41 = reader.GetFloat(42); /* Fin_back2 */
      var arg42 = reader.GetFloat(43); /* Fin_back3 */
      var arg43 = reader.GetInt16(44); /* Sem_heat */
      var arg44 = reader.GetInt16(45); /* Sem_lane */
      var arg45 = reader.GetTextReader(46).ToString(); /* Sem_stat */
      var arg46 = reader.GetFloat(47); /* Sem_Time */
      var arg47 = reader.GetTextReader(48).ToString(); /* Sem_course */
      var arg48 = reader.GetInt16(49); /* Sem_heatplace */
      var arg49 = reader.GetInt16(50); /* Sem_place */
      var arg50 = reader.GetInt16(51); /* Sem_jdplace */
      var arg51 = reader.GetTextReader(52).ToString(); /* Sem_exh */
      var arg52 = reader.GetInt16(53); /* Sem_points */
      var arg53 = reader.GetFloat(54); /* Sem_back1 */
      var arg54 = reader.GetFloat(55); /* Sem_back2 */
      var arg55 = reader.GetFloat(56); /* Sem_back3 */
      var arg56 = reader.GetInt16(57); /* Swimoff_heat */
      var arg57 = reader.GetInt16(58); /* Swimoff_lane */
      var arg58 = reader.GetTextReader(59).ToString(); /* Swimoff_stat */
      var arg59 = reader.GetFloat(60); /* Swimoff_Time */
      var arg60 = reader.GetTextReader(61).ToString(); /* Swimoff_course */
      var arg61 = reader.GetInt16(62); /* Swimoff_heatplace */
      var arg62 = reader.GetInt16(63); /* Swimoff_place */
      var arg63 = reader.GetInt16(64); /* Swimoff_jdplace */
      var arg64 = reader.GetInt16(65); /* Swimoff_points */
      var arg65 = reader.GetFloat(66); /* Swimoff_back1 */
      var arg66 = reader.GetFloat(67); /* Swimoff_back2 */
      var arg67 = reader.GetFloat(68); /* Swimoff_back3 */
      var arg68 = reader.GetFloat(69); /* JDEv_score */
      var arg69 = reader.GetInt16(70); /* Seed_place */
      var arg70 = reader.GetTextReader(71).ToString(); /* fin_heatltr */
      var arg71 = reader.GetInt16(72); /* event_age */
      var arg72 = reader.GetFloat(73); /* Pre_watch1 */
      var arg73 = reader.GetFloat(74); /* Pre_pad */
      var arg74 = reader.GetFloat(75); /* Sem_watch1 */
      var arg75 = reader.GetFloat(76); /* Sem_pad */
      var arg76 = reader.GetFloat(77); /* Fin_watch1 */
      var arg77 = reader.GetFloat(78); /* Fin_pad */
      var arg78 = reader.GetTextReader(79).ToString(); /* Fin_dqcode */
      var arg79 = reader.GetTextReader(80).ToString(); /* Pre_dqcode */
      var arg80 = reader.GetTextReader(81).ToString(); /* Sem_dqcode */
      var arg81 = reader.GetTextReader(82).ToString(); /* Fin_dqcodeSecond */
      var arg82 = reader.GetTextReader(83).ToString(); /* Pre_dqcodeSecond */
      var arg83 = reader.GetTextReader(84).ToString(); /* Sem_dqcodeSecond */
      var arg84 = reader.GetTextReader(85).ToString(); /* Fin_TimeType */
      var arg85 = reader.GetTextReader(86).ToString(); /* Pre_TimeType */
      var arg86 = reader.GetTextReader(87).ToString(); /* Sem_TimeType */
      var arg87 = reader.GetFloat(88); /* Fin_dolphin1 */
      var arg88 = reader.GetFloat(89); /* Fin_dolphin2 */
      var arg89 = reader.GetFloat(90); /* Fin_dolphin3 */
      var arg90 = reader.GetFloat(91); /* Pre_dolphin1 */
      var arg91 = reader.GetFloat(92); /* Pre_dolphin2 */
      var arg92 = reader.GetFloat(93); /* Pre_dolphin3 */
      var arg93 = reader.GetFloat(94); /* Sem_dolphin1 */
      var arg94 = reader.GetFloat(95); /* Sem_dolphin2 */
      var arg95 = reader.GetFloat(96); /* Sem_dolphin3 */
      var arg96 = reader.GetBoolean(97); /* early_seed */
      var arg97 = reader.GetBoolean(98); /* super_prefinalist */
      var arg98 = reader.GetBoolean(99); /* super_finfinalist */
      var arg99 = reader.GetTextReader(100).ToString(); /* fin_adjuststat */
      var arg100 = reader.GetTextReader(101).ToString(); /* pre_adjuststat */
      var arg101 = reader.GetTextReader(102).ToString(); /* sem_adjuststat */
      var arg102 = reader.GetTextReader(103).ToString(); /* fin_divingdd */
      var arg103 = reader.GetTextReader(104).ToString(); /* pre_divingdd */
      var arg104 = reader.GetTextReader(105).ToString(); /* sem_divingdd */
      var arg105 = reader.GetTextReader(106).ToString(); /* entry_method */
      var arg106 = reader.GetInt64(107); /* fin_dqofficial */
      var arg107 = reader.GetInt64(108); /* pre_dqofficial */
      var arg108 = reader.GetInt64(109); /* sem_dqofficial */
      var arg109 = reader.GetBoolean(110); /* pre_contacted */
      var arg110 = reader.GetTextReader(111).ToString(); /* Fin_reactiontime1 */
      var arg111 = reader.GetTextReader(112).ToString(); /* Pre_reactiontime1 */
      var arg112 = reader.GetTextReader(113).ToString(); /* Sem_reactiontime1 */
      var arg113 = reader.GetBoolean(114); /* P_early_seed */
      collection.Add( new MmEntry(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99, arg100, arg101, arg102, arg103, arg104, arg105, arg106, arg107, arg108, arg109, arg110, arg111, arg112, arg113));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public long AthNo{ get; }
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
  public short SeedPlace{ get; }
  public string Fin_heatltr{ get; }
  public short Event_age{ get; }
  public float PreWatch1{ get; }
  public float PrePad{ get; }
  public float SemWatch1{ get; }
  public float SemPad{ get; }
  public float FinWatch1{ get; }
  public float FinPad{ get; }
  public string FinDqcode{ get; }
  public string PreDqcode{ get; }
  public string SemDqcode{ get; }
  public string FinDqcodeSecond{ get; }
  public string PreDqcodeSecond{ get; }
  public string SemDqcodeSecond{ get; }
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
  public bool Super_prefinalist{ get; }
  public bool Super_finfinalist{ get; }
  public string Fin_adjuststat{ get; }
  public string Pre_adjuststat{ get; }
  public string Sem_adjuststat{ get; }
  public string Fin_divingdd{ get; }
  public string Pre_divingdd{ get; }
  public string Sem_divingdd{ get; }
  public string Entry_method{ get; }
  public long Fin_dqofficial{ get; }
  public long Pre_dqofficial{ get; }
  public long Sem_dqofficial{ get; }
  public bool Pre_contacted{ get; }
  public string FinReactiontime1{ get; }
  public string PreReactiontime1{ get; }
  public string SemReactiontime1{ get; }
  public bool PEarlySeed{ get; }
  // Constructor
  MmEntry(long eventPtr, long athNo, string actSeedCourse, float actualSeedTime, string convSeedCourse, float convSeedTime, bool scrStat, string specStat, string decStat, bool altStat, bool bonusEvent, long divNo, float evScore, string dq_type, short preHeat, short preLane, string preStat, float preTime, string preCourse, short preHeatplace, short prePlace, short preJdplace, string preExh, short prePoints, float preBack1, float preBack2, float preBack3, short finHeat, short finLane, short finGroup, string finStat, float finTime, string finCourse, short finHeatplace, short finJdheatplace, short finPlace, short finJdplace, short finPtsplace, string finExh, short finPoints, float finBack1, float finBack2, float finBack3, short semHeat, short semLane, string semStat, float semTime, string semCourse, short semHeatplace, short semPlace, short semJdplace, string semExh, short semPoints, float semBack1, float semBack2, float semBack3, short swimoffHeat, short swimoffLane, string swimoffStat, float swimoffTime, string swimoffCourse, short swimoffHeatplace, short swimoffPlace, short swimoffJdplace, short swimoffPoints, float swimoffBack1, float swimoffBack2, float swimoffBack3, float jDEvScore, short seedPlace, string fin_heatltr, short event_age, float preWatch1, float prePad, float semWatch1, float semPad, float finWatch1, float finPad, string finDqcode, string preDqcode, string semDqcode, string finDqcodeSecond, string preDqcodeSecond, string semDqcodeSecond, string finTimeType, string preTimeType, string semTimeType, float finDolphin1, float finDolphin2, float finDolphin3, float preDolphin1, float preDolphin2, float preDolphin3, float semDolphin1, float semDolphin2, float semDolphin3, bool early_seed, bool super_prefinalist, bool super_finfinalist, string fin_adjuststat, string pre_adjuststat, string sem_adjuststat, string fin_divingdd, string pre_divingdd, string sem_divingdd, string entry_method, long fin_dqofficial, long pre_dqofficial, long sem_dqofficial, bool pre_contacted, string finReactiontime1, string preReactiontime1, string semReactiontime1, bool pEarlySeed )
  {
    EventPtr = eventPtr;
    AthNo = athNo;
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
    SeedPlace = seedPlace;
    Fin_heatltr = fin_heatltr;
    Event_age = event_age;
    PreWatch1 = preWatch1;
    PrePad = prePad;
    SemWatch1 = semWatch1;
    SemPad = semPad;
    FinWatch1 = finWatch1;
    FinPad = finPad;
    FinDqcode = finDqcode;
    PreDqcode = preDqcode;
    SemDqcode = semDqcode;
    FinDqcodeSecond = finDqcodeSecond;
    PreDqcodeSecond = preDqcodeSecond;
    SemDqcodeSecond = semDqcodeSecond;
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
    Super_prefinalist = super_prefinalist;
    Super_finfinalist = super_finfinalist;
    Fin_adjuststat = fin_adjuststat;
    Pre_adjuststat = pre_adjuststat;
    Sem_adjuststat = sem_adjuststat;
    Fin_divingdd = fin_divingdd;
    Pre_divingdd = pre_divingdd;
    Sem_divingdd = sem_divingdd;
    Entry_method = entry_method;
    Fin_dqofficial = fin_dqofficial;
    Pre_dqofficial = pre_dqofficial;
    Sem_dqofficial = sem_dqofficial;
    Pre_contacted = pre_contacted;
    FinReactiontime1 = finReactiontime1;
    PreReactiontime1 = preReactiontime1;
    SemReactiontime1 = semReactiontime1;
    PEarlySeed = pEarlySeed;
  }
}
