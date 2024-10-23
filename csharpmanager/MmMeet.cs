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
/// CREATE TABLE [Meet]
/// (
/// [Meet_name1] Text (90),
/// [Meet_location] Text (90),
/// [Meet_start] DateTime,
/// [Meet_end] DateTime,
/// [Meet_idformat] Integer,
/// [Meet_class] Integer,
/// [Meet_meettype] Integer,
/// [Meet_course] Integer,
/// [Enter_ages] Boolean NOT NULL,
/// [Enter_birthdate] Boolean NOT NULL,
/// [Calc_date] DateTime,
/// [Enter_schoolyr] Boolean NOT NULL,
/// [A_Relaysonly] Boolean NOT NULL,
/// [Use_hometown] Boolean NOT NULL,
/// [Show_countrycode] Boolean NOT NULL,
/// [Scores_afterevt] Boolean NOT NULL,
/// [Lastname_first] Boolean NOT NULL,
/// [Punct_names] Boolean NOT NULL,
/// [Punct_teams] Boolean NOT NULL,
/// [win_mm] Boolean NOT NULL,
/// [meet_numlanes] Integer,
/// [prelimheats_circle] Integer,
/// [timedfinal_circleseed] Boolean NOT NULL,
/// [foreign_infinal] Boolean NOT NULL,
/// [exh_infinal] Boolean NOT NULL,
/// [nonconform_last] Boolean NOT NULL,
/// [course_order] Text (510),
/// [seed_exhlast] Boolean NOT NULL,
/// [dual_evenodd] Boolean NOT NULL,
/// [strict_evenodd] Boolean NOT NULL,
/// [team_evenlanes] Long Integer,
/// [team_oddlanes] Long Integer,
/// [masters_bytimeonly] Boolean NOT NULL,
/// [masters_agegrpsskip] Integer,
/// [timer_port] Integer,
/// [scbd_port] Integer,
/// [timer_vendor] Text (8),
/// [scbd_vendor] Text (8),
/// [show_initial] Boolean NOT NULL,
/// [ucase_names] Boolean NOT NULL,
/// [ucase_teams] Boolean NOT NULL,
/// [open_senior_none] Text (2),
/// [entryqual_faster] Boolean NOT NULL,
/// [indentryfee_surcharge] Currency,
/// [anyone_onrelay] Boolean NOT NULL,
/// [language_choice] Text (40),
/// [military_time] Boolean NOT NULL,
/// [check_times] Boolean NOT NULL,
/// [enterkey_astab] Boolean NOT NULL,
/// [double_endedsplits] Boolean NOT NULL,
/// [use_compnumbers] Boolean NOT NULL,
/// [flighted_minentries] Integer,
/// [diffpts_malefemale] Boolean NOT NULL,
/// [diffpts_eachdivision] Boolean NOT NULL,
/// [scoreonly_ifexceedqualtime] Boolean NOT NULL,
/// [score_fastestheatonly] Boolean NOT NULL,
/// [entrylimits_warn] Boolean NOT NULL,
/// [pointsbasedon_seedtime] Boolean NOT NULL,
/// [pointsfor_overachievers] Boolean NOT NULL,
/// [pointsfor_underachievers] Boolean NOT NULL,
/// [indmaxscorers_perteam] Integer,
/// [relmaxscorers_perteam] Integer,
/// [indtopmany_awards] Integer,
/// [reltopmany_awards] Integer,
/// [entrymax_total] Integer,
/// [indmax_perath] Integer,
/// [relmax_perath] Integer,
/// [foreign_getteampoints] Boolean NOT NULL,
/// [include_swimupsinteamscore] Boolean NOT NULL,
/// [enter_citizenof] Boolean NOT NULL,
/// [meet_meetstyle] Integer,
/// [flag_overachievers] Boolean NOT NULL,
/// [flag_underachievers] Boolean NOT NULL,
/// [scbd_punctuation] Integer,
/// [scbd_names] Integer,
/// [scbd_relaynames] Integer,
/// [scbd_cycle] Boolean NOT NULL,
/// [scbd_cycleseconds] Integer,
/// [copies_toprinter] Integer,
/// [report_headersonly] Boolean NOT NULL,
/// [autoinc_compno] Boolean NOT NULL,
/// [pentscoring_usedqtime] Boolean NOT NULL,
/// [swimmer_surcharge] Currency,
/// [directly_toprinter] Boolean NOT NULL,
/// [lastname_asinitial] Boolean NOT NULL,
/// [under_eventname] Boolean NOT NULL,
/// [suppress_Arelay] Boolean NOT NULL,
/// [Punct_recholders] Boolean NOT NULL,
/// [ucase_recholders] Boolean NOT NULL,
/// [suppress_lsc] Boolean NOT NULL,
/// [showathlete_status] Boolean NOT NULL,
/// [open_lowage] Integer,
/// [useeventsex_teamscore] Boolean NOT NULL,
/// [suppress_smallx] Boolean NOT NULL,
/// [score_Arelayonly] Boolean NOT NULL,
/// [thirteenandover_assenior] Boolean NOT NULL,
/// [suppress_jd] Boolean NOT NULL,
/// [abcfinal_order] Text (6),
/// [maxagefor_cfinal] Integer,
/// [include_sanction] Boolean NOT NULL,
/// [special_points] Integer,
/// [countrelay_alt] Boolean NOT NULL,
/// [UseNonConforming_PoolFactor] Boolean NOT NULL,
/// [NonConforming_PoolFactor] Single,
/// [apnews_team] Text (2),
/// [PointsAwarded_ForDQ] Single,
/// [PointsAwarded_ForScratch] Single,
/// [PointsAwarded_ForNT] Single,
/// [Enter_AthStat] Boolean NOT NULL,
/// [Show_secondclub] Boolean NOT NULL,
/// [firstinitial_fulllastname] Boolean NOT NULL,
/// [turnon_autobackup] Boolean NOT NULL,
/// [autobackup_interval] Integer,
/// [PointsAwarded_ForExh] Boolean NOT NULL,
/// [Use_AltTeamAbbr] Boolean NOT NULL,
/// [IsCanadian_Masters] Boolean NOT NULL,
/// [entry_msg] Text (160),
/// [timedfinalnonconform_last] Boolean NOT NULL,
/// [referee_name] Text (60),
/// [referee_homphone] Text (40),
/// [referee_offphone] Text (40),
/// [Meet_altitude] Long Integer,
/// [Read_Only] Boolean NOT NULL,
/// [masters_indlowage] Integer,
/// [masters_rellowage] Integer,
/// [Import_Dir] Text (160),
/// [Export_Dir] Text (160),
/// [Backup_Dir] Text (160),
/// [RestoreFrom_Dir] Text (160),
/// [RestoreTo_Dir] Text (160),
/// [FlatHtml_Dir] Text (160),
/// [APNews_Dir] Text (160),
/// [AllowSameEvent_DupRelayNames] Boolean NOT NULL,
/// [dualteam_lane1] Long Integer,
/// [dualteam_lane2] Long Integer,
/// [dualteam_lane3] Long Integer,
/// [dualteam_lane4] Long Integer,
/// [dualteam_lane5] Long Integer,
/// [dualteam_lane6] Long Integer,
/// [dualteam_lane7] Long Integer,
/// [dualteam_lane8] Long Integer,
/// [dualteam_lane9] Long Integer,
/// [dualteam_lane10] Long Integer,
/// [strict_evenoddfastestheatonly] Boolean NOT NULL,
/// [dualseeding_altunusedlane] Boolean NOT NULL,
/// [team_surcharge] Currency,
/// [display_actualentrytime] Boolean NOT NULL,
/// [indmaxadvance_perteam] Integer,
/// [relmaxadvance_perteam] Integer,
/// [RelayNames_LinkByLSC] Boolean NOT NULL,
/// [Flighted_BasedOnResultsTime] Boolean NOT NULL,
/// [ShowYear_InPlaceOfAge] Boolean NOT NULL,
/// [PenaltyPts_ForNS] Single,
/// [EntryEligibility_date] DateTime,
/// [Facility_Surcharge] Currency,
/// [Suppress_TimeStdAbbr] Boolean NOT NULL,
/// [Custom_QualTimes] Boolean NOT NULL,
/// [Suppress_SplitsForDQs] Boolean NOT NULL,
/// [Suppress_SplitsForDQsRelay] Boolean NOT NULL,
/// [DQCodes_Type] Text (2),
/// [SuppressTimes_NotMeetQualTime] Boolean NOT NULL,
/// [Show_AgeandBirthYear] Boolean NOT NULL,
/// [Meet_state] Text (6),
/// [Meet_country] Text (6),
/// [Meet_lsc] Text (6),
/// [BCSSA_DivbyTimeStd] Boolean NOT NULL,
/// [Show_HyTekDecimals] Boolean NOT NULL,
/// [Suppress_ResultsAdvQ] Boolean NOT NULL,
/// [RelaysAs_4x100Style] Boolean NOT NULL,
/// [flighted_flightcount] Integer,
/// [flighted_inclDQ] Boolean NOT NULL,
/// [RelaysAlternate_TwoFastestFirst] Boolean NOT NULL,
/// [dualteam_lane11] Long Integer,
/// [dualteam_lane12] Long Integer,
/// [entry_deadline] DateTime,
/// [Meet_addr1] Text (60),
/// [Meet_addr2] Text (60),
/// [Meet_city] Text (60),
/// [Meet_zip] Text (20),
/// [Meet_hostlsc] Text (6),
/// [Meet_USMastersMeetID] Text (40),
/// [ShowFirstName_OverPreferred] Boolean NOT NULL,
/// [ExcludeNTEntries_WhenImporting] Boolean NOT NULL,
/// [Enter_birthcentury] Boolean NOT NULL,
/// [Using_twopools] Boolean NOT NULL,
/// [Pool1_name] Text (60),
/// [Pool2_name] Text (60),
/// [indtopmany_awardsSr] Integer,
/// [reltopmany_awardsSr] Integer,
/// [maxforeign_infinal] Integer,
/// [Flag_FastestRecordOnly] Boolean NOT NULL,
/// [athlete_earlysurcharge] Currency,
/// [athlete_latesurcharge] Currency,
/// [athlete_earlysurchargedate] DateTime,
/// [athlete_latesurchargedate] DateTime,
/// [entry_OMEopendate] DateTime,
/// [DisplayNTfor_TimesUnder5Sec] Boolean NOT NULL,
/// [SortTeamCombos_ByTeamName] Boolean NOT NULL,
/// [FastestHeat_SomeLanesDoNotScore] Boolean NOT NULL,
/// [RankDisabled_ByPoints] Boolean NOT NULL,
/// [special_parapoints] Integer,
/// [DisabledDoNot_AdvanceToFinals] Boolean NOT NULL,
/// [prelimheats_circledist] Integer,
/// [DisabledIgnoreQualTime_ForScoring] Boolean NOT NULL,
/// [CountTimeTrial_Events] Boolean NOT NULL,
/// [Meet_header1] Text (150),
/// [Meet_header2] Text (150),
/// [QualNonConformCourse_UseMinStd] Boolean NOT NULL,
/// [entry_OpenDate] DateTime,
/// [TimeAdj_Method] Text (2),
/// [Lock_Reseed] Boolean NOT NULL,
/// [sanction_number] Text (60),
/// [Last_updated] Text (80),
/// [MixedRelays_DividedPoints] Boolean NOT NULL,
/// [RelayOnly_Surcharge] Currency,
/// [DisabledSeedWithAgeGroup_IfTimedFinalSuperSeed] Boolean NOT NULL,
/// [Competition_Code] Text (12),
/// [PenaltyTimeSec_ForCombEvtDQ] Single
/// );

public class MmMeet 
{
List<MmMeet> get(OdbcConnection connection)
{
  var collection = new List<MmMeet>();
  string query = "select * from Meet";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* Meet_name1 */
      var arg1 = reader.GetTextReader(2).ToString(); /* Meet_location */
      var arg2 = reader.GetDateTime(3); /* Meet_start */
      var arg3 = reader.GetDateTime(4); /* Meet_end */
      var arg4 = reader.GetInt16(5); /* Meet_idformat */
      var arg5 = reader.GetInt16(6); /* Meet_class */
      var arg6 = reader.GetInt16(7); /* Meet_meettype */
      var arg7 = reader.GetInt16(8); /* Meet_course */
      var arg8 = reader.GetBoolean(9); /* Enter_ages */
      var arg9 = reader.GetBoolean(10); /* Enter_birthdate */
      var arg10 = reader.GetDateTime(11); /* Calc_date */
      var arg11 = reader.GetBoolean(12); /* Enter_schoolyr */
      var arg12 = reader.GetBoolean(13); /* A_Relaysonly */
      var arg13 = reader.GetBoolean(14); /* Use_hometown */
      var arg14 = reader.GetBoolean(15); /* Show_countrycode */
      var arg15 = reader.GetBoolean(16); /* Scores_afterevt */
      var arg16 = reader.GetBoolean(17); /* Lastname_first */
      var arg17 = reader.GetBoolean(18); /* Punct_names */
      var arg18 = reader.GetBoolean(19); /* Punct_teams */
      var arg19 = reader.GetBoolean(20); /* win_mm */
      var arg20 = reader.GetInt16(21); /* meet_numlanes */
      var arg21 = reader.GetInt16(22); /* prelimheats_circle */
      var arg22 = reader.GetBoolean(23); /* timedfinal_circleseed */
      var arg23 = reader.GetBoolean(24); /* foreign_infinal */
      var arg24 = reader.GetBoolean(25); /* exh_infinal */
      var arg25 = reader.GetBoolean(26); /* nonconform_last */
      var arg26 = reader.GetTextReader(27).ToString(); /* course_order */
      var arg27 = reader.GetBoolean(28); /* seed_exhlast */
      var arg28 = reader.GetBoolean(29); /* dual_evenodd */
      var arg29 = reader.GetBoolean(30); /* strict_evenodd */
      var arg30 = reader.GetInt64(31); /* team_evenlanes */
      var arg31 = reader.GetInt64(32); /* team_oddlanes */
      var arg32 = reader.GetBoolean(33); /* masters_bytimeonly */
      var arg33 = reader.GetInt16(34); /* masters_agegrpsskip */
      var arg34 = reader.GetInt16(35); /* timer_port */
      var arg35 = reader.GetInt16(36); /* scbd_port */
      var arg36 = reader.GetTextReader(37).ToString(); /* timer_vendor */
      var arg37 = reader.GetTextReader(38).ToString(); /* scbd_vendor */
      var arg38 = reader.GetBoolean(39); /* show_initial */
      var arg39 = reader.GetBoolean(40); /* ucase_names */
      var arg40 = reader.GetBoolean(41); /* ucase_teams */
      var arg41 = reader.GetTextReader(42).ToString(); /* open_senior_none */
      var arg42 = reader.GetBoolean(43); /* entryqual_faster */
      var arg43 = reader.GetDecimal(44); /* indentryfee_surcharge */
      var arg44 = reader.GetBoolean(45); /* anyone_onrelay */
      var arg45 = reader.GetTextReader(46).ToString(); /* language_choice */
      var arg46 = reader.GetBoolean(47); /* military_time */
      var arg47 = reader.GetBoolean(48); /* check_times */
      var arg48 = reader.GetBoolean(49); /* enterkey_astab */
      var arg49 = reader.GetBoolean(50); /* double_endedsplits */
      var arg50 = reader.GetBoolean(51); /* use_compnumbers */
      var arg51 = reader.GetInt16(52); /* flighted_minentries */
      var arg52 = reader.GetBoolean(53); /* diffpts_malefemale */
      var arg53 = reader.GetBoolean(54); /* diffpts_eachdivision */
      var arg54 = reader.GetBoolean(55); /* scoreonly_ifexceedqualtime */
      var arg55 = reader.GetBoolean(56); /* score_fastestheatonly */
      var arg56 = reader.GetBoolean(57); /* entrylimits_warn */
      var arg57 = reader.GetBoolean(58); /* pointsbasedon_seedtime */
      var arg58 = reader.GetBoolean(59); /* pointsfor_overachievers */
      var arg59 = reader.GetBoolean(60); /* pointsfor_underachievers */
      var arg60 = reader.GetInt16(61); /* indmaxscorers_perteam */
      var arg61 = reader.GetInt16(62); /* relmaxscorers_perteam */
      var arg62 = reader.GetInt16(63); /* indtopmany_awards */
      var arg63 = reader.GetInt16(64); /* reltopmany_awards */
      var arg64 = reader.GetInt16(65); /* entrymax_total */
      var arg65 = reader.GetInt16(66); /* indmax_perath */
      var arg66 = reader.GetInt16(67); /* relmax_perath */
      var arg67 = reader.GetBoolean(68); /* foreign_getteampoints */
      var arg68 = reader.GetBoolean(69); /* include_swimupsinteamscore */
      var arg69 = reader.GetBoolean(70); /* enter_citizenof */
      var arg70 = reader.GetInt16(71); /* meet_meetstyle */
      var arg71 = reader.GetBoolean(72); /* flag_overachievers */
      var arg72 = reader.GetBoolean(73); /* flag_underachievers */
      var arg73 = reader.GetInt16(74); /* scbd_punctuation */
      var arg74 = reader.GetInt16(75); /* scbd_names */
      var arg75 = reader.GetInt16(76); /* scbd_relaynames */
      var arg76 = reader.GetBoolean(77); /* scbd_cycle */
      var arg77 = reader.GetInt16(78); /* scbd_cycleseconds */
      var arg78 = reader.GetInt16(79); /* copies_toprinter */
      var arg79 = reader.GetBoolean(80); /* report_headersonly */
      var arg80 = reader.GetBoolean(81); /* autoinc_compno */
      var arg81 = reader.GetBoolean(82); /* pentscoring_usedqtime */
      var arg82 = reader.GetDecimal(83); /* swimmer_surcharge */
      var arg83 = reader.GetBoolean(84); /* directly_toprinter */
      var arg84 = reader.GetBoolean(85); /* lastname_asinitial */
      var arg85 = reader.GetBoolean(86); /* under_eventname */
      var arg86 = reader.GetBoolean(87); /* suppress_Arelay */
      var arg87 = reader.GetBoolean(88); /* Punct_recholders */
      var arg88 = reader.GetBoolean(89); /* ucase_recholders */
      var arg89 = reader.GetBoolean(90); /* suppress_lsc */
      var arg90 = reader.GetBoolean(91); /* showathlete_status */
      var arg91 = reader.GetInt16(92); /* open_lowage */
      var arg92 = reader.GetBoolean(93); /* useeventsex_teamscore */
      var arg93 = reader.GetBoolean(94); /* suppress_smallx */
      var arg94 = reader.GetBoolean(95); /* score_Arelayonly */
      var arg95 = reader.GetBoolean(96); /* thirteenandover_assenior */
      var arg96 = reader.GetBoolean(97); /* suppress_jd */
      var arg97 = reader.GetTextReader(98).ToString(); /* abcfinal_order */
      var arg98 = reader.GetInt16(99); /* maxagefor_cfinal */
      var arg99 = reader.GetBoolean(100); /* include_sanction */
      var arg100 = reader.GetInt16(101); /* special_points */
      var arg101 = reader.GetBoolean(102); /* countrelay_alt */
      var arg102 = reader.GetBoolean(103); /* UseNonConforming_PoolFactor */
      var arg103 = reader.GetFloat(104); /* NonConforming_PoolFactor */
      var arg104 = reader.GetTextReader(105).ToString(); /* apnews_team */
      var arg105 = reader.GetFloat(106); /* PointsAwarded_ForDQ */
      var arg106 = reader.GetFloat(107); /* PointsAwarded_ForScratch */
      var arg107 = reader.GetFloat(108); /* PointsAwarded_ForNT */
      var arg108 = reader.GetBoolean(109); /* Enter_AthStat */
      var arg109 = reader.GetBoolean(110); /* Show_secondclub */
      var arg110 = reader.GetBoolean(111); /* firstinitial_fulllastname */
      var arg111 = reader.GetBoolean(112); /* turnon_autobackup */
      var arg112 = reader.GetInt16(113); /* autobackup_interval */
      var arg113 = reader.GetBoolean(114); /* PointsAwarded_ForExh */
      var arg114 = reader.GetBoolean(115); /* Use_AltTeamAbbr */
      var arg115 = reader.GetBoolean(116); /* IsCanadian_Masters */
      var arg116 = reader.GetTextReader(117).ToString(); /* entry_msg */
      var arg117 = reader.GetBoolean(118); /* timedfinalnonconform_last */
      var arg118 = reader.GetTextReader(119).ToString(); /* referee_name */
      var arg119 = reader.GetTextReader(120).ToString(); /* referee_homphone */
      var arg120 = reader.GetTextReader(121).ToString(); /* referee_offphone */
      var arg121 = reader.GetInt64(122); /* Meet_altitude */
      var arg122 = reader.GetBoolean(123); /* Read_Only */
      var arg123 = reader.GetInt16(124); /* masters_indlowage */
      var arg124 = reader.GetInt16(125); /* masters_rellowage */
      var arg125 = reader.GetTextReader(126).ToString(); /* Import_Dir */
      var arg126 = reader.GetTextReader(127).ToString(); /* Export_Dir */
      var arg127 = reader.GetTextReader(128).ToString(); /* Backup_Dir */
      var arg128 = reader.GetTextReader(129).ToString(); /* RestoreFrom_Dir */
      var arg129 = reader.GetTextReader(130).ToString(); /* RestoreTo_Dir */
      var arg130 = reader.GetTextReader(131).ToString(); /* FlatHtml_Dir */
      var arg131 = reader.GetTextReader(132).ToString(); /* APNews_Dir */
      var arg132 = reader.GetBoolean(133); /* AllowSameEvent_DupRelayNames */
      var arg133 = reader.GetInt64(134); /* dualteam_lane1 */
      var arg134 = reader.GetInt64(135); /* dualteam_lane2 */
      var arg135 = reader.GetInt64(136); /* dualteam_lane3 */
      var arg136 = reader.GetInt64(137); /* dualteam_lane4 */
      var arg137 = reader.GetInt64(138); /* dualteam_lane5 */
      var arg138 = reader.GetInt64(139); /* dualteam_lane6 */
      var arg139 = reader.GetInt64(140); /* dualteam_lane7 */
      var arg140 = reader.GetInt64(141); /* dualteam_lane8 */
      var arg141 = reader.GetInt64(142); /* dualteam_lane9 */
      var arg142 = reader.GetInt64(143); /* dualteam_lane10 */
      var arg143 = reader.GetBoolean(144); /* strict_evenoddfastestheatonly */
      var arg144 = reader.GetBoolean(145); /* dualseeding_altunusedlane */
      var arg145 = reader.GetDecimal(146); /* team_surcharge */
      var arg146 = reader.GetBoolean(147); /* display_actualentrytime */
      var arg147 = reader.GetInt16(148); /* indmaxadvance_perteam */
      var arg148 = reader.GetInt16(149); /* relmaxadvance_perteam */
      var arg149 = reader.GetBoolean(150); /* RelayNames_LinkByLSC */
      var arg150 = reader.GetBoolean(151); /* Flighted_BasedOnResultsTime */
      var arg151 = reader.GetBoolean(152); /* ShowYear_InPlaceOfAge */
      var arg152 = reader.GetFloat(153); /* PenaltyPts_ForNS */
      var arg153 = reader.GetDateTime(154); /* EntryEligibility_date */
      var arg154 = reader.GetDecimal(155); /* Facility_Surcharge */
      var arg155 = reader.GetBoolean(156); /* Suppress_TimeStdAbbr */
      var arg156 = reader.GetBoolean(157); /* Custom_QualTimes */
      var arg157 = reader.GetBoolean(158); /* Suppress_SplitsForDQs */
      var arg158 = reader.GetBoolean(159); /* Suppress_SplitsForDQsRelay */
      var arg159 = reader.GetTextReader(160).ToString(); /* DQCodes_Type */
      var arg160 = reader.GetBoolean(161); /* SuppressTimes_NotMeetQualTime */
      var arg161 = reader.GetBoolean(162); /* Show_AgeandBirthYear */
      var arg162 = reader.GetTextReader(163).ToString(); /* Meet_state */
      var arg163 = reader.GetTextReader(164).ToString(); /* Meet_country */
      var arg164 = reader.GetTextReader(165).ToString(); /* Meet_lsc */
      var arg165 = reader.GetBoolean(166); /* BCSSA_DivbyTimeStd */
      var arg166 = reader.GetBoolean(167); /* Show_HyTekDecimals */
      var arg167 = reader.GetBoolean(168); /* Suppress_ResultsAdvQ */
      var arg168 = reader.GetBoolean(169); /* RelaysAs_4x100Style */
      var arg169 = reader.GetInt16(170); /* flighted_flightcount */
      var arg170 = reader.GetBoolean(171); /* flighted_inclDQ */
      var arg171 = reader.GetBoolean(172); /* RelaysAlternate_TwoFastestFirst */
      var arg172 = reader.GetInt64(173); /* dualteam_lane11 */
      var arg173 = reader.GetInt64(174); /* dualteam_lane12 */
      var arg174 = reader.GetDateTime(175); /* entry_deadline */
      var arg175 = reader.GetTextReader(176).ToString(); /* Meet_addr1 */
      var arg176 = reader.GetTextReader(177).ToString(); /* Meet_addr2 */
      var arg177 = reader.GetTextReader(178).ToString(); /* Meet_city */
      var arg178 = reader.GetTextReader(179).ToString(); /* Meet_zip */
      var arg179 = reader.GetTextReader(180).ToString(); /* Meet_hostlsc */
      var arg180 = reader.GetTextReader(181).ToString(); /* Meet_USMastersMeetID */
      var arg181 = reader.GetBoolean(182); /* ShowFirstName_OverPreferred */
      var arg182 = reader.GetBoolean(183); /* ExcludeNTEntries_WhenImporting */
      var arg183 = reader.GetBoolean(184); /* Enter_birthcentury */
      var arg184 = reader.GetBoolean(185); /* Using_twopools */
      var arg185 = reader.GetTextReader(186).ToString(); /* Pool1_name */
      var arg186 = reader.GetTextReader(187).ToString(); /* Pool2_name */
      var arg187 = reader.GetInt16(188); /* indtopmany_awardsSr */
      var arg188 = reader.GetInt16(189); /* reltopmany_awardsSr */
      var arg189 = reader.GetInt16(190); /* maxforeign_infinal */
      var arg190 = reader.GetBoolean(191); /* Flag_FastestRecordOnly */
      var arg191 = reader.GetDecimal(192); /* athlete_earlysurcharge */
      var arg192 = reader.GetDecimal(193); /* athlete_latesurcharge */
      var arg193 = reader.GetDateTime(194); /* athlete_earlysurchargedate */
      var arg194 = reader.GetDateTime(195); /* athlete_latesurchargedate */
      var arg195 = reader.GetDateTime(196); /* entry_OMEopendate */
      var arg196 = reader.GetBoolean(197); /* DisplayNTfor_TimesUnder5Sec */
      var arg197 = reader.GetBoolean(198); /* SortTeamCombos_ByTeamName */
      var arg198 = reader.GetBoolean(199); /* FastestHeat_SomeLanesDoNotScore */
      var arg199 = reader.GetBoolean(200); /* RankDisabled_ByPoints */
      var arg200 = reader.GetInt16(201); /* special_parapoints */
      var arg201 = reader.GetBoolean(202); /* DisabledDoNot_AdvanceToFinals */
      var arg202 = reader.GetInt16(203); /* prelimheats_circledist */
      var arg203 = reader.GetBoolean(204); /* DisabledIgnoreQualTime_ForScoring */
      var arg204 = reader.GetBoolean(205); /* CountTimeTrial_Events */
      var arg205 = reader.GetTextReader(206).ToString(); /* Meet_header1 */
      var arg206 = reader.GetTextReader(207).ToString(); /* Meet_header2 */
      var arg207 = reader.GetBoolean(208); /* QualNonConformCourse_UseMinStd */
      var arg208 = reader.GetDateTime(209); /* entry_OpenDate */
      var arg209 = reader.GetTextReader(210).ToString(); /* TimeAdj_Method */
      var arg210 = reader.GetBoolean(211); /* Lock_Reseed */
      var arg211 = reader.GetTextReader(212).ToString(); /* sanction_number */
      var arg212 = reader.GetTextReader(213).ToString(); /* Last_updated */
      var arg213 = reader.GetBoolean(214); /* MixedRelays_DividedPoints */
      var arg214 = reader.GetDecimal(215); /* RelayOnly_Surcharge */
      var arg215 = reader.GetBoolean(216); /* DisabledSeedWithAgeGroup_IfTimedFinalSuperSeed */
      var arg216 = reader.GetTextReader(217).ToString(); /* Competition_Code */
      var arg217 = reader.GetFloat(218); /* PenaltyTimeSec_ForCombEvtDQ */
      collection.Add( new MmMeet(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99, arg100, arg101, arg102, arg103, arg104, arg105, arg106, arg107, arg108, arg109, arg110, arg111, arg112, arg113, arg114, arg115, arg116, arg117, arg118, arg119, arg120, arg121, arg122, arg123, arg124, arg125, arg126, arg127, arg128, arg129, arg130, arg131, arg132, arg133, arg134, arg135, arg136, arg137, arg138, arg139, arg140, arg141, arg142, arg143, arg144, arg145, arg146, arg147, arg148, arg149, arg150, arg151, arg152, arg153, arg154, arg155, arg156, arg157, arg158, arg159, arg160, arg161, arg162, arg163, arg164, arg165, arg166, arg167, arg168, arg169, arg170, arg171, arg172, arg173, arg174, arg175, arg176, arg177, arg178, arg179, arg180, arg181, arg182, arg183, arg184, arg185, arg186, arg187, arg188, arg189, arg190, arg191, arg192, arg193, arg194, arg195, arg196, arg197, arg198, arg199, arg200, arg201, arg202, arg203, arg204, arg205, arg206, arg207, arg208, arg209, arg210, arg211, arg212, arg213, arg214, arg215, arg216, arg217));
    }
  }
  return collection;
}
  // Properties
  public string MeetName1{ get; }
  public string MeetLocation{ get; }
  public DateTime MeetStart{ get; }
  public DateTime MeetEnd{ get; }
  public short MeetIdformat{ get; }
  public short MeetClass{ get; }
  public short MeetMeettype{ get; }
  public short MeetCourse{ get; }
  public bool EnterAges{ get; }
  public bool EnterBirthdate{ get; }
  public DateTime CalcDate{ get; }
  public bool EnterSchoolyr{ get; }
  public bool ARelaysonly{ get; }
  public bool UseHometown{ get; }
  public bool ShowCountrycode{ get; }
  public bool ScoresAfterevt{ get; }
  public bool LastnameFirst{ get; }
  public bool PunctNames{ get; }
  public bool PunctTeams{ get; }
  public bool Win_mm{ get; }
  public short Meet_numlanes{ get; }
  public short Prelimheats_circle{ get; }
  public bool Timedfinal_circleseed{ get; }
  public bool Foreign_infinal{ get; }
  public bool Exh_infinal{ get; }
  public bool Nonconform_last{ get; }
  public string Course_order{ get; }
  public bool Seed_exhlast{ get; }
  public bool Dual_evenodd{ get; }
  public bool Strict_evenodd{ get; }
  public long Team_evenlanes{ get; }
  public long Team_oddlanes{ get; }
  public bool Masters_bytimeonly{ get; }
  public short Masters_agegrpsskip{ get; }
  public short Timer_port{ get; }
  public short Scbd_port{ get; }
  public string Timer_vendor{ get; }
  public string Scbd_vendor{ get; }
  public bool Show_initial{ get; }
  public bool Ucase_names{ get; }
  public bool Ucase_teams{ get; }
  public string Open_senior_none{ get; }
  public bool Entryqual_faster{ get; }
  public decimal Indentryfee_surcharge{ get; }
  public bool Anyone_onrelay{ get; }
  public string Language_choice{ get; }
  public bool Military_time{ get; }
  public bool Check_times{ get; }
  public bool Enterkey_astab{ get; }
  public bool Double_endedsplits{ get; }
  public bool Use_compnumbers{ get; }
  public short Flighted_minentries{ get; }
  public bool Diffpts_malefemale{ get; }
  public bool Diffpts_eachdivision{ get; }
  public bool Scoreonly_ifexceedqualtime{ get; }
  public bool Score_fastestheatonly{ get; }
  public bool Entrylimits_warn{ get; }
  public bool Pointsbasedon_seedtime{ get; }
  public bool Pointsfor_overachievers{ get; }
  public bool Pointsfor_underachievers{ get; }
  public short Indmaxscorers_perteam{ get; }
  public short Relmaxscorers_perteam{ get; }
  public short Indtopmany_awards{ get; }
  public short Reltopmany_awards{ get; }
  public short Entrymax_total{ get; }
  public short Indmax_perath{ get; }
  public short Relmax_perath{ get; }
  public bool Foreign_getteampoints{ get; }
  public bool Include_swimupsinteamscore{ get; }
  public bool Enter_citizenof{ get; }
  public short Meet_meetstyle{ get; }
  public bool Flag_overachievers{ get; }
  public bool Flag_underachievers{ get; }
  public short Scbd_punctuation{ get; }
  public short Scbd_names{ get; }
  public short Scbd_relaynames{ get; }
  public bool Scbd_cycle{ get; }
  public short Scbd_cycleseconds{ get; }
  public short Copies_toprinter{ get; }
  public bool Report_headersonly{ get; }
  public bool Autoinc_compno{ get; }
  public bool Pentscoring_usedqtime{ get; }
  public decimal Swimmer_surcharge{ get; }
  public bool Directly_toprinter{ get; }
  public bool Lastname_asinitial{ get; }
  public bool Under_eventname{ get; }
  public bool SuppressArelay{ get; }
  public bool PunctRecholders{ get; }
  public bool Ucase_recholders{ get; }
  public bool Suppress_lsc{ get; }
  public bool Showathlete_status{ get; }
  public short Open_lowage{ get; }
  public bool Useeventsex_teamscore{ get; }
  public bool Suppress_smallx{ get; }
  public bool ScoreArelayonly{ get; }
  public bool Thirteenandover_assenior{ get; }
  public bool Suppress_jd{ get; }
  public string Abcfinal_order{ get; }
  public short Maxagefor_cfinal{ get; }
  public bool Include_sanction{ get; }
  public short Special_points{ get; }
  public bool Countrelay_alt{ get; }
  public bool UseNonConformingPoolFactor{ get; }
  public float NonConformingPoolFactor{ get; }
  public string Apnews_team{ get; }
  public float PointsAwardedForDQ{ get; }
  public float PointsAwardedForScratch{ get; }
  public float PointsAwardedForNT{ get; }
  public bool EnterAthStat{ get; }
  public bool ShowSecondclub{ get; }
  public bool Firstinitial_fulllastname{ get; }
  public bool Turnon_autobackup{ get; }
  public short Autobackup_interval{ get; }
  public bool PointsAwardedForExh{ get; }
  public bool UseAltTeamAbbr{ get; }
  public bool IsCanadianMasters{ get; }
  public string Entry_msg{ get; }
  public bool Timedfinalnonconform_last{ get; }
  public string Referee_name{ get; }
  public string Referee_homphone{ get; }
  public string Referee_offphone{ get; }
  public long MeetAltitude{ get; }
  public bool ReadOnly{ get; }
  public short Masters_indlowage{ get; }
  public short Masters_rellowage{ get; }
  public string ImportDir{ get; }
  public string ExportDir{ get; }
  public string BackupDir{ get; }
  public string RestoreFromDir{ get; }
  public string RestoreToDir{ get; }
  public string FlatHtmlDir{ get; }
  public string APNewsDir{ get; }
  public bool AllowSameEventDupRelayNames{ get; }
  public long Dualteam_lane1{ get; }
  public long Dualteam_lane2{ get; }
  public long Dualteam_lane3{ get; }
  public long Dualteam_lane4{ get; }
  public long Dualteam_lane5{ get; }
  public long Dualteam_lane6{ get; }
  public long Dualteam_lane7{ get; }
  public long Dualteam_lane8{ get; }
  public long Dualteam_lane9{ get; }
  public long Dualteam_lane10{ get; }
  public bool Strict_evenoddfastestheatonly{ get; }
  public bool Dualseeding_altunusedlane{ get; }
  public decimal Team_surcharge{ get; }
  public bool Display_actualentrytime{ get; }
  public short Indmaxadvance_perteam{ get; }
  public short Relmaxadvance_perteam{ get; }
  public bool RelayNamesLinkByLSC{ get; }
  public bool FlightedBasedOnResultsTime{ get; }
  public bool ShowYearInPlaceOfAge{ get; }
  public float PenaltyPtsForNS{ get; }
  public DateTime EntryEligibilityDate{ get; }
  public decimal FacilitySurcharge{ get; }
  public bool SuppressTimeStdAbbr{ get; }
  public bool CustomQualTimes{ get; }
  public bool SuppressSplitsForDQs{ get; }
  public bool SuppressSplitsForDQsRelay{ get; }
  public string DQCodesType{ get; }
  public bool SuppressTimesNotMeetQualTime{ get; }
  public bool ShowAgeandBirthYear{ get; }
  public string MeetState{ get; }
  public string MeetCountry{ get; }
  public string MeetLsc{ get; }
  public bool BCSSADivbyTimeStd{ get; }
  public bool ShowHyTekDecimals{ get; }
  public bool SuppressResultsAdvQ{ get; }
  public bool RelaysAs4x100Style{ get; }
  public short Flighted_flightcount{ get; }
  public bool FlightedInclDQ{ get; }
  public bool RelaysAlternateTwoFastestFirst{ get; }
  public long Dualteam_lane11{ get; }
  public long Dualteam_lane12{ get; }
  public DateTime Entry_deadline{ get; }
  public string MeetAddr1{ get; }
  public string MeetAddr2{ get; }
  public string MeetCity{ get; }
  public string MeetZip{ get; }
  public string MeetHostlsc{ get; }
  public string MeetUSMastersMeetID{ get; }
  public bool ShowFirstNameOverPreferred{ get; }
  public bool ExcludeNTEntriesWhenImporting{ get; }
  public bool EnterBirthcentury{ get; }
  public bool UsingTwopools{ get; }
  public string Pool1Name{ get; }
  public string Pool2Name{ get; }
  public short IndtopmanyAwardsSr{ get; }
  public short ReltopmanyAwardsSr{ get; }
  public short Maxforeign_infinal{ get; }
  public bool FlagFastestRecordOnly{ get; }
  public decimal Athlete_earlysurcharge{ get; }
  public decimal Athlete_latesurcharge{ get; }
  public DateTime Athlete_earlysurchargedate{ get; }
  public DateTime Athlete_latesurchargedate{ get; }
  public DateTime EntryOMEopendate{ get; }
  public bool DisplayNTforTimesUnder5Sec{ get; }
  public bool SortTeamCombosByTeamName{ get; }
  public bool FastestHeatSomeLanesDoNotScore{ get; }
  public bool RankDisabledByPoints{ get; }
  public short Special_parapoints{ get; }
  public bool DisabledDoNotAdvanceToFinals{ get; }
  public short Prelimheats_circledist{ get; }
  public bool DisabledIgnoreQualTimeForScoring{ get; }
  public bool CountTimeTrialEvents{ get; }
  public string MeetHeader1{ get; }
  public string MeetHeader2{ get; }
  public bool QualNonConformCourseUseMinStd{ get; }
  public DateTime EntryOpenDate{ get; }
  public string TimeAdjMethod{ get; }
  public bool LockReseed{ get; }
  public string Sanction_number{ get; }
  public string LastUpdated{ get; }
  public bool MixedRelaysDividedPoints{ get; }
  public decimal RelayOnlySurcharge{ get; }
  public bool DisabledSeedWithAgeGroupIfTimedFinalSuperSeed{ get; }
  public string CompetitionCode{ get; }
  public float PenaltyTimeSecForCombEvtDQ{ get; }
  // Constructor
  MmMeet(string meetName1, string meetLocation, DateTime meetStart, DateTime meetEnd, short meetIdformat, short meetClass, short meetMeettype, short meetCourse, bool enterAges, bool enterBirthdate, DateTime calcDate, bool enterSchoolyr, bool aRelaysonly, bool useHometown, bool showCountrycode, bool scoresAfterevt, bool lastnameFirst, bool punctNames, bool punctTeams, bool win_mm, short meet_numlanes, short prelimheats_circle, bool timedfinal_circleseed, bool foreign_infinal, bool exh_infinal, bool nonconform_last, string course_order, bool seed_exhlast, bool dual_evenodd, bool strict_evenodd, long team_evenlanes, long team_oddlanes, bool masters_bytimeonly, short masters_agegrpsskip, short timer_port, short scbd_port, string timer_vendor, string scbd_vendor, bool show_initial, bool ucase_names, bool ucase_teams, string open_senior_none, bool entryqual_faster, decimal indentryfee_surcharge, bool anyone_onrelay, string language_choice, bool military_time, bool check_times, bool enterkey_astab, bool double_endedsplits, bool use_compnumbers, short flighted_minentries, bool diffpts_malefemale, bool diffpts_eachdivision, bool scoreonly_ifexceedqualtime, bool score_fastestheatonly, bool entrylimits_warn, bool pointsbasedon_seedtime, bool pointsfor_overachievers, bool pointsfor_underachievers, short indmaxscorers_perteam, short relmaxscorers_perteam, short indtopmany_awards, short reltopmany_awards, short entrymax_total, short indmax_perath, short relmax_perath, bool foreign_getteampoints, bool include_swimupsinteamscore, bool enter_citizenof, short meet_meetstyle, bool flag_overachievers, bool flag_underachievers, short scbd_punctuation, short scbd_names, short scbd_relaynames, bool scbd_cycle, short scbd_cycleseconds, short copies_toprinter, bool report_headersonly, bool autoinc_compno, bool pentscoring_usedqtime, decimal swimmer_surcharge, bool directly_toprinter, bool lastname_asinitial, bool under_eventname, bool suppressArelay, bool punctRecholders, bool ucase_recholders, bool suppress_lsc, bool showathlete_status, short open_lowage, bool useeventsex_teamscore, bool suppress_smallx, bool scoreArelayonly, bool thirteenandover_assenior, bool suppress_jd, string abcfinal_order, short maxagefor_cfinal, bool include_sanction, short special_points, bool countrelay_alt, bool useNonConformingPoolFactor, float nonConformingPoolFactor, string apnews_team, float pointsAwardedForDQ, float pointsAwardedForScratch, float pointsAwardedForNT, bool enterAthStat, bool showSecondclub, bool firstinitial_fulllastname, bool turnon_autobackup, short autobackup_interval, bool pointsAwardedForExh, bool useAltTeamAbbr, bool isCanadianMasters, string entry_msg, bool timedfinalnonconform_last, string referee_name, string referee_homphone, string referee_offphone, long meetAltitude, bool readOnly, short masters_indlowage, short masters_rellowage, string importDir, string exportDir, string backupDir, string restoreFromDir, string restoreToDir, string flatHtmlDir, string aPNewsDir, bool allowSameEventDupRelayNames, long dualteam_lane1, long dualteam_lane2, long dualteam_lane3, long dualteam_lane4, long dualteam_lane5, long dualteam_lane6, long dualteam_lane7, long dualteam_lane8, long dualteam_lane9, long dualteam_lane10, bool strict_evenoddfastestheatonly, bool dualseeding_altunusedlane, decimal team_surcharge, bool display_actualentrytime, short indmaxadvance_perteam, short relmaxadvance_perteam, bool relayNamesLinkByLSC, bool flightedBasedOnResultsTime, bool showYearInPlaceOfAge, float penaltyPtsForNS, DateTime entryEligibilityDate, decimal facilitySurcharge, bool suppressTimeStdAbbr, bool customQualTimes, bool suppressSplitsForDQs, bool suppressSplitsForDQsRelay, string dQCodesType, bool suppressTimesNotMeetQualTime, bool showAgeandBirthYear, string meetState, string meetCountry, string meetLsc, bool bCSSADivbyTimeStd, bool showHyTekDecimals, bool suppressResultsAdvQ, bool relaysAs4x100Style, short flighted_flightcount, bool flightedInclDQ, bool relaysAlternateTwoFastestFirst, long dualteam_lane11, long dualteam_lane12, DateTime entry_deadline, string meetAddr1, string meetAddr2, string meetCity, string meetZip, string meetHostlsc, string meetUSMastersMeetID, bool showFirstNameOverPreferred, bool excludeNTEntriesWhenImporting, bool enterBirthcentury, bool usingTwopools, string pool1Name, string pool2Name, short indtopmanyAwardsSr, short reltopmanyAwardsSr, short maxforeign_infinal, bool flagFastestRecordOnly, decimal athlete_earlysurcharge, decimal athlete_latesurcharge, DateTime athlete_earlysurchargedate, DateTime athlete_latesurchargedate, DateTime entryOMEopendate, bool displayNTforTimesUnder5Sec, bool sortTeamCombosByTeamName, bool fastestHeatSomeLanesDoNotScore, bool rankDisabledByPoints, short special_parapoints, bool disabledDoNotAdvanceToFinals, short prelimheats_circledist, bool disabledIgnoreQualTimeForScoring, bool countTimeTrialEvents, string meetHeader1, string meetHeader2, bool qualNonConformCourseUseMinStd, DateTime entryOpenDate, string timeAdjMethod, bool lockReseed, string sanction_number, string lastUpdated, bool mixedRelaysDividedPoints, decimal relayOnlySurcharge, bool disabledSeedWithAgeGroupIfTimedFinalSuperSeed, string competitionCode, float penaltyTimeSecForCombEvtDQ )
  {
    MeetName1 = meetName1;
    MeetLocation = meetLocation;
    MeetStart = meetStart;
    MeetEnd = meetEnd;
    MeetIdformat = meetIdformat;
    MeetClass = meetClass;
    MeetMeettype = meetMeettype;
    MeetCourse = meetCourse;
    EnterAges = enterAges;
    EnterBirthdate = enterBirthdate;
    CalcDate = calcDate;
    EnterSchoolyr = enterSchoolyr;
    ARelaysonly = aRelaysonly;
    UseHometown = useHometown;
    ShowCountrycode = showCountrycode;
    ScoresAfterevt = scoresAfterevt;
    LastnameFirst = lastnameFirst;
    PunctNames = punctNames;
    PunctTeams = punctTeams;
    Win_mm = win_mm;
    Meet_numlanes = meet_numlanes;
    Prelimheats_circle = prelimheats_circle;
    Timedfinal_circleseed = timedfinal_circleseed;
    Foreign_infinal = foreign_infinal;
    Exh_infinal = exh_infinal;
    Nonconform_last = nonconform_last;
    Course_order = course_order;
    Seed_exhlast = seed_exhlast;
    Dual_evenodd = dual_evenodd;
    Strict_evenodd = strict_evenodd;
    Team_evenlanes = team_evenlanes;
    Team_oddlanes = team_oddlanes;
    Masters_bytimeonly = masters_bytimeonly;
    Masters_agegrpsskip = masters_agegrpsskip;
    Timer_port = timer_port;
    Scbd_port = scbd_port;
    Timer_vendor = timer_vendor;
    Scbd_vendor = scbd_vendor;
    Show_initial = show_initial;
    Ucase_names = ucase_names;
    Ucase_teams = ucase_teams;
    Open_senior_none = open_senior_none;
    Entryqual_faster = entryqual_faster;
    Indentryfee_surcharge = indentryfee_surcharge;
    Anyone_onrelay = anyone_onrelay;
    Language_choice = language_choice;
    Military_time = military_time;
    Check_times = check_times;
    Enterkey_astab = enterkey_astab;
    Double_endedsplits = double_endedsplits;
    Use_compnumbers = use_compnumbers;
    Flighted_minentries = flighted_minentries;
    Diffpts_malefemale = diffpts_malefemale;
    Diffpts_eachdivision = diffpts_eachdivision;
    Scoreonly_ifexceedqualtime = scoreonly_ifexceedqualtime;
    Score_fastestheatonly = score_fastestheatonly;
    Entrylimits_warn = entrylimits_warn;
    Pointsbasedon_seedtime = pointsbasedon_seedtime;
    Pointsfor_overachievers = pointsfor_overachievers;
    Pointsfor_underachievers = pointsfor_underachievers;
    Indmaxscorers_perteam = indmaxscorers_perteam;
    Relmaxscorers_perteam = relmaxscorers_perteam;
    Indtopmany_awards = indtopmany_awards;
    Reltopmany_awards = reltopmany_awards;
    Entrymax_total = entrymax_total;
    Indmax_perath = indmax_perath;
    Relmax_perath = relmax_perath;
    Foreign_getteampoints = foreign_getteampoints;
    Include_swimupsinteamscore = include_swimupsinteamscore;
    Enter_citizenof = enter_citizenof;
    Meet_meetstyle = meet_meetstyle;
    Flag_overachievers = flag_overachievers;
    Flag_underachievers = flag_underachievers;
    Scbd_punctuation = scbd_punctuation;
    Scbd_names = scbd_names;
    Scbd_relaynames = scbd_relaynames;
    Scbd_cycle = scbd_cycle;
    Scbd_cycleseconds = scbd_cycleseconds;
    Copies_toprinter = copies_toprinter;
    Report_headersonly = report_headersonly;
    Autoinc_compno = autoinc_compno;
    Pentscoring_usedqtime = pentscoring_usedqtime;
    Swimmer_surcharge = swimmer_surcharge;
    Directly_toprinter = directly_toprinter;
    Lastname_asinitial = lastname_asinitial;
    Under_eventname = under_eventname;
    SuppressArelay = suppressArelay;
    PunctRecholders = punctRecholders;
    Ucase_recholders = ucase_recholders;
    Suppress_lsc = suppress_lsc;
    Showathlete_status = showathlete_status;
    Open_lowage = open_lowage;
    Useeventsex_teamscore = useeventsex_teamscore;
    Suppress_smallx = suppress_smallx;
    ScoreArelayonly = scoreArelayonly;
    Thirteenandover_assenior = thirteenandover_assenior;
    Suppress_jd = suppress_jd;
    Abcfinal_order = abcfinal_order;
    Maxagefor_cfinal = maxagefor_cfinal;
    Include_sanction = include_sanction;
    Special_points = special_points;
    Countrelay_alt = countrelay_alt;
    UseNonConformingPoolFactor = useNonConformingPoolFactor;
    NonConformingPoolFactor = nonConformingPoolFactor;
    Apnews_team = apnews_team;
    PointsAwardedForDQ = pointsAwardedForDQ;
    PointsAwardedForScratch = pointsAwardedForScratch;
    PointsAwardedForNT = pointsAwardedForNT;
    EnterAthStat = enterAthStat;
    ShowSecondclub = showSecondclub;
    Firstinitial_fulllastname = firstinitial_fulllastname;
    Turnon_autobackup = turnon_autobackup;
    Autobackup_interval = autobackup_interval;
    PointsAwardedForExh = pointsAwardedForExh;
    UseAltTeamAbbr = useAltTeamAbbr;
    IsCanadianMasters = isCanadianMasters;
    Entry_msg = entry_msg;
    Timedfinalnonconform_last = timedfinalnonconform_last;
    Referee_name = referee_name;
    Referee_homphone = referee_homphone;
    Referee_offphone = referee_offphone;
    MeetAltitude = meetAltitude;
    ReadOnly = readOnly;
    Masters_indlowage = masters_indlowage;
    Masters_rellowage = masters_rellowage;
    ImportDir = importDir;
    ExportDir = exportDir;
    BackupDir = backupDir;
    RestoreFromDir = restoreFromDir;
    RestoreToDir = restoreToDir;
    FlatHtmlDir = flatHtmlDir;
    APNewsDir = aPNewsDir;
    AllowSameEventDupRelayNames = allowSameEventDupRelayNames;
    Dualteam_lane1 = dualteam_lane1;
    Dualteam_lane2 = dualteam_lane2;
    Dualteam_lane3 = dualteam_lane3;
    Dualteam_lane4 = dualteam_lane4;
    Dualteam_lane5 = dualteam_lane5;
    Dualteam_lane6 = dualteam_lane6;
    Dualteam_lane7 = dualteam_lane7;
    Dualteam_lane8 = dualteam_lane8;
    Dualteam_lane9 = dualteam_lane9;
    Dualteam_lane10 = dualteam_lane10;
    Strict_evenoddfastestheatonly = strict_evenoddfastestheatonly;
    Dualseeding_altunusedlane = dualseeding_altunusedlane;
    Team_surcharge = team_surcharge;
    Display_actualentrytime = display_actualentrytime;
    Indmaxadvance_perteam = indmaxadvance_perteam;
    Relmaxadvance_perteam = relmaxadvance_perteam;
    RelayNamesLinkByLSC = relayNamesLinkByLSC;
    FlightedBasedOnResultsTime = flightedBasedOnResultsTime;
    ShowYearInPlaceOfAge = showYearInPlaceOfAge;
    PenaltyPtsForNS = penaltyPtsForNS;
    EntryEligibilityDate = entryEligibilityDate;
    FacilitySurcharge = facilitySurcharge;
    SuppressTimeStdAbbr = suppressTimeStdAbbr;
    CustomQualTimes = customQualTimes;
    SuppressSplitsForDQs = suppressSplitsForDQs;
    SuppressSplitsForDQsRelay = suppressSplitsForDQsRelay;
    DQCodesType = dQCodesType;
    SuppressTimesNotMeetQualTime = suppressTimesNotMeetQualTime;
    ShowAgeandBirthYear = showAgeandBirthYear;
    MeetState = meetState;
    MeetCountry = meetCountry;
    MeetLsc = meetLsc;
    BCSSADivbyTimeStd = bCSSADivbyTimeStd;
    ShowHyTekDecimals = showHyTekDecimals;
    SuppressResultsAdvQ = suppressResultsAdvQ;
    RelaysAs4x100Style = relaysAs4x100Style;
    Flighted_flightcount = flighted_flightcount;
    FlightedInclDQ = flightedInclDQ;
    RelaysAlternateTwoFastestFirst = relaysAlternateTwoFastestFirst;
    Dualteam_lane11 = dualteam_lane11;
    Dualteam_lane12 = dualteam_lane12;
    Entry_deadline = entry_deadline;
    MeetAddr1 = meetAddr1;
    MeetAddr2 = meetAddr2;
    MeetCity = meetCity;
    MeetZip = meetZip;
    MeetHostlsc = meetHostlsc;
    MeetUSMastersMeetID = meetUSMastersMeetID;
    ShowFirstNameOverPreferred = showFirstNameOverPreferred;
    ExcludeNTEntriesWhenImporting = excludeNTEntriesWhenImporting;
    EnterBirthcentury = enterBirthcentury;
    UsingTwopools = usingTwopools;
    Pool1Name = pool1Name;
    Pool2Name = pool2Name;
    IndtopmanyAwardsSr = indtopmanyAwardsSr;
    ReltopmanyAwardsSr = reltopmanyAwardsSr;
    Maxforeign_infinal = maxforeign_infinal;
    FlagFastestRecordOnly = flagFastestRecordOnly;
    Athlete_earlysurcharge = athlete_earlysurcharge;
    Athlete_latesurcharge = athlete_latesurcharge;
    Athlete_earlysurchargedate = athlete_earlysurchargedate;
    Athlete_latesurchargedate = athlete_latesurchargedate;
    EntryOMEopendate = entryOMEopendate;
    DisplayNTforTimesUnder5Sec = displayNTforTimesUnder5Sec;
    SortTeamCombosByTeamName = sortTeamCombosByTeamName;
    FastestHeatSomeLanesDoNotScore = fastestHeatSomeLanesDoNotScore;
    RankDisabledByPoints = rankDisabledByPoints;
    Special_parapoints = special_parapoints;
    DisabledDoNotAdvanceToFinals = disabledDoNotAdvanceToFinals;
    Prelimheats_circledist = prelimheats_circledist;
    DisabledIgnoreQualTimeForScoring = disabledIgnoreQualTimeForScoring;
    CountTimeTrialEvents = countTimeTrialEvents;
    MeetHeader1 = meetHeader1;
    MeetHeader2 = meetHeader2;
    QualNonConformCourseUseMinStd = qualNonConformCourseUseMinStd;
    EntryOpenDate = entryOpenDate;
    TimeAdjMethod = timeAdjMethod;
    LockReseed = lockReseed;
    Sanction_number = sanction_number;
    LastUpdated = lastUpdated;
    MixedRelaysDividedPoints = mixedRelaysDividedPoints;
    RelayOnlySurcharge = relayOnlySurcharge;
    DisabledSeedWithAgeGroupIfTimedFinalSuperSeed = disabledSeedWithAgeGroupIfTimedFinalSuperSeed;
    CompetitionCode = competitionCode;
    PenaltyTimeSecForCombEvtDQ = penaltyTimeSecForCombEvtDQ;
  }
}
