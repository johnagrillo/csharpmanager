using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Meet]
/// // (
/// // [Meet_name1] Text (90),
/// // [Meet_location] Text (90),
/// // [Meet_start] DateTime,
/// // [Meet_end] DateTime,
/// // [Meet_idformat] Integer,
/// // [Meet_class] Integer,
/// // [Meet_meettype] Integer,
/// // [Meet_course] Integer,
/// // [Enter_ages] Boolean NOT NULL,
/// // [Enter_birthdate] Boolean NOT NULL,
/// // [Calc_date] DateTime,
/// // [Enter_schoolyr] Boolean NOT NULL,
/// // [A_Relaysonly] Boolean NOT NULL,
/// // [Use_hometown] Boolean NOT NULL,
/// // [Show_countrycode] Boolean NOT NULL,
/// // [Scores_afterevt] Boolean NOT NULL,
/// // [Lastname_first] Boolean NOT NULL,
/// // [Punct_names] Boolean NOT NULL,
/// // [Punct_teams] Boolean NOT NULL,
/// // [win_mm] Boolean NOT NULL,
/// // [meet_numlanes] Integer,
/// // [prelimheats_circle] Integer,
/// // [timedfinal_circleseed] Boolean NOT NULL,
/// // [foreign_infinal] Boolean NOT NULL,
/// // [exh_infinal] Boolean NOT NULL,
/// // [nonconform_last] Boolean NOT NULL,
/// // [course_order] Text (510),
/// // [seed_exhlast] Boolean NOT NULL,
/// // [dual_evenodd] Boolean NOT NULL,
/// // [strict_evenodd] Boolean NOT NULL,
/// // [team_evenlanes] Long Integer,
/// // [team_oddlanes] Long Integer,
/// // [masters_bytimeonly] Boolean NOT NULL,
/// // [masters_agegrpsskip] Integer,
/// // [timer_port] Integer,
/// // [scbd_port] Integer,
/// // [timer_vendor] Text (8),
/// // [scbd_vendor] Text (8),
/// // [show_initial] Boolean NOT NULL,
/// // [ucase_names] Boolean NOT NULL,
/// // [ucase_teams] Boolean NOT NULL,
/// // [open_senior_none] Text (2),
/// // [entryqual_faster] Boolean NOT NULL,
/// // [indentryfee_surcharge] Currency,
/// // [anyone_onrelay] Boolean NOT NULL,
/// // [language_choice] Text (40),
/// // [military_time] Boolean NOT NULL,
/// // [check_times] Boolean NOT NULL,
/// // [enterkey_astab] Boolean NOT NULL,
/// // [double_endedsplits] Boolean NOT NULL,
/// // [use_compnumbers] Boolean NOT NULL,
/// // [flighted_minentries] Integer,
/// // [diffpts_malefemale] Boolean NOT NULL,
/// // [diffpts_eachdivision] Boolean NOT NULL,
/// // [scoreonly_ifexceedqualtime] Boolean NOT NULL,
/// // [score_fastestheatonly] Boolean NOT NULL,
/// // [entrylimits_warn] Boolean NOT NULL,
/// // [pointsbasedon_seedtime] Boolean NOT NULL,
/// // [pointsfor_overachievers] Boolean NOT NULL,
/// // [pointsfor_underachievers] Boolean NOT NULL,
/// // [indmaxscorers_perteam] Integer,
/// // [relmaxscorers_perteam] Integer,
/// // [indtopmany_awards] Integer,
/// // [reltopmany_awards] Integer,
/// // [entrymax_total] Integer,
/// // [indmax_perath] Integer,
/// // [relmax_perath] Integer,
/// // [foreign_getteampoints] Boolean NOT NULL,
/// // [include_swimupsinteamscore] Boolean NOT NULL,
/// // [enter_citizenof] Boolean NOT NULL,
/// // [meet_meetstyle] Integer,
/// // [flag_overachievers] Boolean NOT NULL,
/// // [flag_underachievers] Boolean NOT NULL,
/// // [scbd_punctuation] Integer,
/// // [scbd_names] Integer,
/// // [scbd_relaynames] Integer,
/// // [scbd_cycle] Boolean NOT NULL,
/// // [scbd_cycleseconds] Integer,
/// // [copies_toprinter] Integer,
/// // [report_headersonly] Boolean NOT NULL,
/// // [autoinc_compno] Boolean NOT NULL,
/// // [pentscoring_usedqtime] Boolean NOT NULL,
/// // [swimmer_surcharge] Currency,
/// // [directly_toprinter] Boolean NOT NULL,
/// // [lastname_asinitial] Boolean NOT NULL,
/// // [under_eventname] Boolean NOT NULL,
/// // [suppress_Arelay] Boolean NOT NULL,
/// // [Punct_recholders] Boolean NOT NULL,
/// // [ucase_recholders] Boolean NOT NULL,
/// // [suppress_lsc] Boolean NOT NULL,
/// // [showathlete_status] Boolean NOT NULL,
/// // [open_lowage] Integer,
/// // [useeventsex_teamscore] Boolean NOT NULL,
/// // [suppress_smallx] Boolean NOT NULL,
/// // [score_Arelayonly] Boolean NOT NULL,
/// // [thirteenandover_assenior] Boolean NOT NULL,
/// // [suppress_jd] Boolean NOT NULL,
/// // [abcfinal_order] Text (6),
/// // [maxagefor_cfinal] Integer,
/// // [include_sanction] Boolean NOT NULL,
/// // [special_points] Integer,
/// // [countrelay_alt] Boolean NOT NULL,
/// // [UseNonConforming_PoolFactor] Boolean NOT NULL,
/// // [NonConforming_PoolFactor] Single,
/// // [apnews_team] Text (2),
/// // [PointsAwarded_ForDQ] Single,
/// // [PointsAwarded_ForScratch] Single,
/// // [PointsAwarded_ForNT] Single,
/// // [Enter_AthStat] Boolean NOT NULL,
/// // [Show_secondclub] Boolean NOT NULL,
/// // [firstinitial_fulllastname] Boolean NOT NULL,
/// // [turnon_autobackup] Boolean NOT NULL,
/// // [autobackup_interval] Integer,
/// // [PointsAwarded_ForExh] Boolean NOT NULL,
/// // [Use_AltTeamAbbr] Boolean NOT NULL,
/// // [IsCanadian_Masters] Boolean NOT NULL,
/// // [entry_msg] Text (160),
/// // [timedfinalnonconform_last] Boolean NOT NULL,
/// // [referee_name] Text (60),
/// // [referee_homphone] Text (40),
/// // [referee_offphone] Text (40),
/// // [Meet_altitude] Long Integer,
/// // [Read_Only] Boolean NOT NULL,
/// // [masters_indlowage] Integer,
/// // [masters_rellowage] Integer,
/// // [Import_Dir] Text (160),
/// // [Export_Dir] Text (160),
/// // [Backup_Dir] Text (160),
/// // [RestoreFrom_Dir] Text (160),
/// // [RestoreTo_Dir] Text (160),
/// // [FlatHtml_Dir] Text (160),
/// // [APNews_Dir] Text (160),
/// // [AllowSameEvent_DupRelayNames] Boolean NOT NULL,
/// // [dualteam_lane1] Long Integer,
/// // [dualteam_lane2] Long Integer,
/// // [dualteam_lane3] Long Integer,
/// // [dualteam_lane4] Long Integer,
/// // [dualteam_lane5] Long Integer,
/// // [dualteam_lane6] Long Integer,
/// // [dualteam_lane7] Long Integer,
/// // [dualteam_lane8] Long Integer,
/// // [dualteam_lane9] Long Integer,
/// // [dualteam_lane10] Long Integer,
/// // [strict_evenoddfastestheatonly] Boolean NOT NULL,
/// // [dualseeding_altunusedlane] Boolean NOT NULL,
/// // [team_surcharge] Currency,
/// // [display_actualentrytime] Boolean NOT NULL,
/// // [indmaxadvance_perteam] Integer,
/// // [relmaxadvance_perteam] Integer,
/// // [RelayNames_LinkByLSC] Boolean NOT NULL,
/// // [Flighted_BasedOnResultsTime] Boolean NOT NULL,
/// // [ShowYear_InPlaceOfAge] Boolean NOT NULL,
/// // [PenaltyPts_ForNS] Single,
/// // [EntryEligibility_date] DateTime,
/// // [Facility_Surcharge] Currency,
/// // [Suppress_TimeStdAbbr] Boolean NOT NULL,
/// // [Custom_QualTimes] Boolean NOT NULL,
/// // [Suppress_SplitsForDQs] Boolean NOT NULL,
/// // [Suppress_SplitsForDQsRelay] Boolean NOT NULL,
/// // [DQCodes_Type] Text (2),
/// // [SuppressTimes_NotMeetQualTime] Boolean NOT NULL,
/// // [Show_AgeandBirthYear] Boolean NOT NULL,
/// // [Meet_state] Text (6),
/// // [Meet_country] Text (6),
/// // [Meet_lsc] Text (6),
/// // [BCSSA_DivbyTimeStd] Boolean NOT NULL,
/// // [Show_HyTekDecimals] Boolean NOT NULL,
/// // [Suppress_ResultsAdvQ] Boolean NOT NULL,
/// // [RelaysAs_4x100Style] Boolean NOT NULL,
/// // [flighted_flightcount] Integer,
/// // [flighted_inclDQ] Boolean NOT NULL,
/// // [RelaysAlternate_TwoFastestFirst] Boolean NOT NULL,
/// // [dualteam_lane11] Long Integer,
/// // [dualteam_lane12] Long Integer,
/// // [entry_deadline] DateTime,
/// // [Meet_addr1] Text (60),
/// // [Meet_addr2] Text (60),
/// // [Meet_city] Text (60),
/// // [Meet_zip] Text (20),
/// // [Meet_hostlsc] Text (6),
/// // [Meet_USMastersMeetID] Text (40),
/// // [ShowFirstName_OverPreferred] Boolean NOT NULL,
/// // [ExcludeNTEntries_WhenImporting] Boolean NOT NULL,
/// // [Enter_birthcentury] Boolean NOT NULL,
/// // [Using_twopools] Boolean NOT NULL,
/// // [Pool1_name] Text (60),
/// // [Pool2_name] Text (60),
/// // [indtopmany_awardsSr] Integer,
/// // [reltopmany_awardsSr] Integer,
/// // [maxforeign_infinal] Integer,
/// // [Flag_FastestRecordOnly] Boolean NOT NULL,
/// // [athlete_earlysurcharge] Currency,
/// // [athlete_latesurcharge] Currency,
/// // [athlete_earlysurchargedate] DateTime,
/// // [athlete_latesurchargedate] DateTime,
/// // [entry_OMEopendate] DateTime,
/// // [DisplayNTfor_TimesUnder5Sec] Boolean NOT NULL,
/// // [SortTeamCombos_ByTeamName] Boolean NOT NULL,
/// // [FastestHeat_SomeLanesDoNotScore] Boolean NOT NULL,
/// // [RankDisabled_ByPoints] Boolean NOT NULL,
/// // [special_parapoints] Integer,
/// // [DisabledDoNot_AdvanceToFinals] Boolean NOT NULL,
/// // [prelimheats_circledist] Integer,
/// // [DisabledIgnoreQualTime_ForScoring] Boolean NOT NULL,
/// // [CountTimeTrial_Events] Boolean NOT NULL,
/// // [Meet_header1] Text (150),
/// // [Meet_header2] Text (150),
/// // [QualNonConformCourse_UseMinStd] Boolean NOT NULL,
/// // [entry_OpenDate] DateTime,
/// // [TimeAdj_Method] Text (2),
/// // [Lock_Reseed] Boolean NOT NULL,
/// // [sanction_number] Text (60),
/// // [Last_updated] Text (80),
/// // [MixedRelays_DividedPoints] Boolean NOT NULL,
/// // [RelayOnly_Surcharge] Currency,
/// // [DisabledSeedWithAgeGroup_IfTimedFinalSuperSeed] Boolean NOT NULL,
/// // [Competition_Code] Text (12),
/// // [PenaltyTimeSec_ForCombEvtDQ] Single
/// // );

public class Meet(string meetName1, string meetLocation, DateTime? meetStart, DateTime? meetEnd, short? meetIdformat, short? meetClass, short? meetMeettype, short? meetCourse, bool enterAges, bool enterBirthdate, DateTime? calcDate, bool enterSchoolyr, bool aRelaysonly, bool useHometown, bool showCountrycode, bool scoresAfterevt, bool lastnameFirst, bool punctNames, bool punctTeams, bool win_mm, short? meet_numlanes, short? prelimheats_circle, bool timedfinal_circleseed, bool foreign_infinal, bool exh_infinal, bool nonconform_last, string course_order, bool seed_exhlast, bool dual_evenodd, bool strict_evenodd, long? team_evenlanes, long? team_oddlanes, bool masters_bytimeonly, short? masters_agegrpsskip, short? timer_port, short? scbd_port, string timer_vendor, string scbd_vendor, bool show_initial, bool ucase_names, bool ucase_teams, string open_senior_none, bool entryqual_faster, decimal? indentryfee_surcharge, bool anyone_onrelay, string language_choice, bool military_time, bool check_times, bool enterkey_astab, bool double_endedsplits, bool use_compnumbers, short? flighted_minentries, bool diffpts_malefemale, bool diffpts_eachdivision, bool scoreonly_ifexceedqualtime, bool score_fastestheatonly, bool entrylimits_warn, bool pointsbasedon_seedtime, bool pointsfor_overachievers, bool pointsfor_underachievers, short? indmaxscorers_perteam, short? relmaxscorers_perteam, short? indtopmany_awards, short? reltopmany_awards, short? entrymax_total, short? indmax_perath, short? relmax_perath, bool foreign_getteampoints, bool include_swimupsinteamscore, bool enter_citizenof, short? meet_meetstyle, bool flag_overachievers, bool flag_underachievers, short? scbd_punctuation, short? scbd_names, short? scbd_relaynames, bool scbd_cycle, short? scbd_cycleseconds, short? copies_toprinter, bool report_headersonly, bool autoinc_compno, bool pentscoring_usedqtime, decimal? swimmer_surcharge, bool directly_toprinter, bool lastname_asinitial, bool under_eventname, bool suppressArelay, bool punctRecholders, bool ucase_recholders, bool suppress_lsc, bool showathlete_status, short? open_lowage, bool useeventsex_teamscore, bool suppress_smallx, bool scoreArelayonly, bool thirteenandover_assenior, bool suppress_jd, string abcfinal_order, short? maxagefor_cfinal, bool include_sanction, short? special_points, bool countrelay_alt, bool useNonConformingPoolFactor, float? nonConformingPoolFactor, string apnews_team, float? pointsAwardedForDQ, float? pointsAwardedForScratch, float? pointsAwardedForNT, bool enterAthStat, bool showSecondclub, bool firstinitial_fulllastname, bool turnon_autobackup, short? autobackup_interval, bool pointsAwardedForExh, bool useAltTeamAbbr, bool isCanadianMasters, string entry_msg, bool timedfinalnonconform_last, string referee_name, string referee_homphone, string referee_offphone, long? meetAltitude, bool readOnly, short? masters_indlowage, short? masters_rellowage, string importDir, string exportDir, string backupDir, string restoreFromDir, string restoreToDir, string flatHtmlDir, string aPNewsDir, bool allowSameEventDupRelayNames, long? dualteam_lane1, long? dualteam_lane2, long? dualteam_lane3, long? dualteam_lane4, long? dualteam_lane5, long? dualteam_lane6, long? dualteam_lane7, long? dualteam_lane8, long? dualteam_lane9, long? dualteam_lane10, bool strict_evenoddfastestheatonly, bool dualseeding_altunusedlane, decimal? team_surcharge, bool display_actualentrytime, short? indmaxadvance_perteam, short? relmaxadvance_perteam, bool relayNamesLinkByLSC, bool flightedBasedOnResultsTime, bool showYearInPlaceOfAge, float? penaltyPtsForNS, DateTime? entryEligibilityDate, decimal? facilitySurcharge, bool suppressTimeStdAbbr, bool customQualTimes, bool suppressSplitsForDQs, bool suppressSplitsForDQsRelay, string dQCodesType, bool suppressTimesNotMeetQualTime, bool showAgeandBirthYear, string meetState, string meetCountry, string meetLsc, bool bCSSADivbyTimeStd, bool showHyTekDecimals, bool suppressResultsAdvQ, bool relaysAs4x100Style, short? flighted_flightcount, bool flightedInclDQ, bool relaysAlternateTwoFastestFirst, long? dualteam_lane11, long? dualteam_lane12, DateTime? entry_deadline, string meetAddr1, string meetAddr2, string meetCity, string meetZip, string meetHostlsc, string meetUSMastersMeetID, bool showFirstNameOverPreferred, bool excludeNTEntriesWhenImporting, bool enterBirthcentury, bool usingTwopools, string pool1Name, string pool2Name, short? indtopmanyAwardsSr, short? reltopmanyAwardsSr, short? maxforeign_infinal, bool flagFastestRecordOnly, decimal? athlete_earlysurcharge, decimal? athlete_latesurcharge, DateTime? athlete_earlysurchargedate, DateTime? athlete_latesurchargedate, DateTime? entryOMEopendate, bool displayNTforTimesUnder5Sec, bool sortTeamCombosByTeamName, bool fastestHeatSomeLanesDoNotScore, bool rankDisabledByPoints, short? special_parapoints, bool disabledDoNotAdvanceToFinals, short? prelimheats_circledist, bool disabledIgnoreQualTimeForScoring, bool countTimeTrialEvents, string meetHeader1, string meetHeader2, bool qualNonConformCourseUseMinStd, DateTime? entryOpenDate, string timeAdjMethod, bool lockReseed, string sanction_number, string lastUpdated, bool mixedRelaysDividedPoints, decimal? relayOnlySurcharge, bool disabledSeedWithAgeGroupIfTimedFinalSuperSeed, string competitionCode, float? penaltyTimeSecForCombEvtDQ )
{
static public List<Meet> Get(OdbcConnection connection)
{
  var collection = new List<Meet>();
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
  var arg0 = reader.GetTextReader(0).ReadLine(); /* Meet_name1 nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Meet_location nullable false*/
  var arg2 = reader.IsDBNull(2) ? (DateTime?)null :reader.GetDateTime(2); /* Meet_start nullable true*/
  var arg3 = reader.IsDBNull(3) ? (DateTime?)null :reader.GetDateTime(3); /* Meet_end nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* Meet_idformat nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Meet_class nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* Meet_meettype nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Meet_course nullable true*/
  var arg8 = reader.GetBoolean(8); /* Enter_ages nullable false*/
  var arg9 = reader.GetBoolean(9); /* Enter_birthdate nullable false*/
  var arg10 = reader.IsDBNull(10) ? (DateTime?)null :reader.GetDateTime(10); /* Calc_date nullable true*/
  var arg11 = reader.GetBoolean(11); /* Enter_schoolyr nullable false*/
  var arg12 = reader.GetBoolean(12); /* A_Relaysonly nullable false*/
  var arg13 = reader.GetBoolean(13); /* Use_hometown nullable false*/
  var arg14 = reader.GetBoolean(14); /* Show_countrycode nullable false*/
  var arg15 = reader.GetBoolean(15); /* Scores_afterevt nullable false*/
  var arg16 = reader.GetBoolean(16); /* Lastname_first nullable false*/
  var arg17 = reader.GetBoolean(17); /* Punct_names nullable false*/
  var arg18 = reader.GetBoolean(18); /* Punct_teams nullable false*/
  var arg19 = reader.GetBoolean(19); /* win_mm nullable false*/
  var arg20 = reader.IsDBNull(20) ? (short?)null :reader.GetInt16(20); /* meet_numlanes nullable true*/
  var arg21 = reader.IsDBNull(21) ? (short?)null :reader.GetInt16(21); /* prelimheats_circle nullable true*/
  var arg22 = reader.GetBoolean(22); /* timedfinal_circleseed nullable false*/
  var arg23 = reader.GetBoolean(23); /* foreign_infinal nullable false*/
  var arg24 = reader.GetBoolean(24); /* exh_infinal nullable false*/
  var arg25 = reader.GetBoolean(25); /* nonconform_last nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* course_order nullable false*/
  var arg27 = reader.GetBoolean(27); /* seed_exhlast nullable false*/
  var arg28 = reader.GetBoolean(28); /* dual_evenodd nullable false*/
  var arg29 = reader.GetBoolean(29); /* strict_evenodd nullable false*/
  var arg30 = reader.IsDBNull(30) ? (long?)null :reader.GetInt32(30); /* team_evenlanes nullable true*/
  var arg31 = reader.IsDBNull(31) ? (long?)null :reader.GetInt32(31); /* team_oddlanes nullable true*/
  var arg32 = reader.GetBoolean(32); /* masters_bytimeonly nullable false*/
  var arg33 = reader.IsDBNull(33) ? (short?)null :reader.GetInt16(33); /* masters_agegrpsskip nullable true*/
  var arg34 = reader.IsDBNull(34) ? (short?)null :reader.GetInt16(34); /* timer_port nullable true*/
  var arg35 = reader.IsDBNull(35) ? (short?)null :reader.GetInt16(35); /* scbd_port nullable true*/
  var arg36 = reader.GetTextReader(36).ReadLine(); /* timer_vendor nullable false*/
  var arg37 = reader.GetTextReader(37).ReadLine(); /* scbd_vendor nullable false*/
  var arg38 = reader.GetBoolean(38); /* show_initial nullable false*/
  var arg39 = reader.GetBoolean(39); /* ucase_names nullable false*/
  var arg40 = reader.GetBoolean(40); /* ucase_teams nullable false*/
  var arg41 = reader.GetTextReader(41).ReadLine(); /* open_senior_none nullable false*/
  var arg42 = reader.GetBoolean(42); /* entryqual_faster nullable false*/
  var arg43 = reader.IsDBNull(43) ? (decimal?)null :reader.GetDecimal(43); /* indentryfee_surcharge nullable true*/
  var arg44 = reader.GetBoolean(44); /* anyone_onrelay nullable false*/
  var arg45 = reader.GetTextReader(45).ReadLine(); /* language_choice nullable false*/
  var arg46 = reader.GetBoolean(46); /* military_time nullable false*/
  var arg47 = reader.GetBoolean(47); /* check_times nullable false*/
  var arg48 = reader.GetBoolean(48); /* enterkey_astab nullable false*/
  var arg49 = reader.GetBoolean(49); /* double_endedsplits nullable false*/
  var arg50 = reader.GetBoolean(50); /* use_compnumbers nullable false*/
  var arg51 = reader.IsDBNull(51) ? (short?)null :reader.GetInt16(51); /* flighted_minentries nullable true*/
  var arg52 = reader.GetBoolean(52); /* diffpts_malefemale nullable false*/
  var arg53 = reader.GetBoolean(53); /* diffpts_eachdivision nullable false*/
  var arg54 = reader.GetBoolean(54); /* scoreonly_ifexceedqualtime nullable false*/
  var arg55 = reader.GetBoolean(55); /* score_fastestheatonly nullable false*/
  var arg56 = reader.GetBoolean(56); /* entrylimits_warn nullable false*/
  var arg57 = reader.GetBoolean(57); /* pointsbasedon_seedtime nullable false*/
  var arg58 = reader.GetBoolean(58); /* pointsfor_overachievers nullable false*/
  var arg59 = reader.GetBoolean(59); /* pointsfor_underachievers nullable false*/
  var arg60 = reader.IsDBNull(60) ? (short?)null :reader.GetInt16(60); /* indmaxscorers_perteam nullable true*/
  var arg61 = reader.IsDBNull(61) ? (short?)null :reader.GetInt16(61); /* relmaxscorers_perteam nullable true*/
  var arg62 = reader.IsDBNull(62) ? (short?)null :reader.GetInt16(62); /* indtopmany_awards nullable true*/
  var arg63 = reader.IsDBNull(63) ? (short?)null :reader.GetInt16(63); /* reltopmany_awards nullable true*/
  var arg64 = reader.IsDBNull(64) ? (short?)null :reader.GetInt16(64); /* entrymax_total nullable true*/
  var arg65 = reader.IsDBNull(65) ? (short?)null :reader.GetInt16(65); /* indmax_perath nullable true*/
  var arg66 = reader.IsDBNull(66) ? (short?)null :reader.GetInt16(66); /* relmax_perath nullable true*/
  var arg67 = reader.GetBoolean(67); /* foreign_getteampoints nullable false*/
  var arg68 = reader.GetBoolean(68); /* include_swimupsinteamscore nullable false*/
  var arg69 = reader.GetBoolean(69); /* enter_citizenof nullable false*/
  var arg70 = reader.IsDBNull(70) ? (short?)null :reader.GetInt16(70); /* meet_meetstyle nullable true*/
  var arg71 = reader.GetBoolean(71); /* flag_overachievers nullable false*/
  var arg72 = reader.GetBoolean(72); /* flag_underachievers nullable false*/
  var arg73 = reader.IsDBNull(73) ? (short?)null :reader.GetInt16(73); /* scbd_punctuation nullable true*/
  var arg74 = reader.IsDBNull(74) ? (short?)null :reader.GetInt16(74); /* scbd_names nullable true*/
  var arg75 = reader.IsDBNull(75) ? (short?)null :reader.GetInt16(75); /* scbd_relaynames nullable true*/
  var arg76 = reader.GetBoolean(76); /* scbd_cycle nullable false*/
  var arg77 = reader.IsDBNull(77) ? (short?)null :reader.GetInt16(77); /* scbd_cycleseconds nullable true*/
  var arg78 = reader.IsDBNull(78) ? (short?)null :reader.GetInt16(78); /* copies_toprinter nullable true*/
  var arg79 = reader.GetBoolean(79); /* report_headersonly nullable false*/
  var arg80 = reader.GetBoolean(80); /* autoinc_compno nullable false*/
  var arg81 = reader.GetBoolean(81); /* pentscoring_usedqtime nullable false*/
  var arg82 = reader.IsDBNull(82) ? (decimal?)null :reader.GetDecimal(82); /* swimmer_surcharge nullable true*/
  var arg83 = reader.GetBoolean(83); /* directly_toprinter nullable false*/
  var arg84 = reader.GetBoolean(84); /* lastname_asinitial nullable false*/
  var arg85 = reader.GetBoolean(85); /* under_eventname nullable false*/
  var arg86 = reader.GetBoolean(86); /* suppress_Arelay nullable false*/
  var arg87 = reader.GetBoolean(87); /* Punct_recholders nullable false*/
  var arg88 = reader.GetBoolean(88); /* ucase_recholders nullable false*/
  var arg89 = reader.GetBoolean(89); /* suppress_lsc nullable false*/
  var arg90 = reader.GetBoolean(90); /* showathlete_status nullable false*/
  var arg91 = reader.IsDBNull(91) ? (short?)null :reader.GetInt16(91); /* open_lowage nullable true*/
  var arg92 = reader.GetBoolean(92); /* useeventsex_teamscore nullable false*/
  var arg93 = reader.GetBoolean(93); /* suppress_smallx nullable false*/
  var arg94 = reader.GetBoolean(94); /* score_Arelayonly nullable false*/
  var arg95 = reader.GetBoolean(95); /* thirteenandover_assenior nullable false*/
  var arg96 = reader.GetBoolean(96); /* suppress_jd nullable false*/
  var arg97 = reader.GetTextReader(97).ReadLine(); /* abcfinal_order nullable false*/
  var arg98 = reader.IsDBNull(98) ? (short?)null :reader.GetInt16(98); /* maxagefor_cfinal nullable true*/
  var arg99 = reader.GetBoolean(99); /* include_sanction nullable false*/
  var arg100 = reader.IsDBNull(100) ? (short?)null :reader.GetInt16(100); /* special_points nullable true*/
  var arg101 = reader.GetBoolean(101); /* countrelay_alt nullable false*/
  var arg102 = reader.GetBoolean(102); /* UseNonConforming_PoolFactor nullable false*/
  var arg103 = reader.IsDBNull(103) ? (float?)null :reader.GetFloat(103); /* NonConforming_PoolFactor nullable true*/
  var arg104 = reader.GetTextReader(104).ReadLine(); /* apnews_team nullable false*/
  var arg105 = reader.IsDBNull(105) ? (float?)null :reader.GetFloat(105); /* PointsAwarded_ForDQ nullable true*/
  var arg106 = reader.IsDBNull(106) ? (float?)null :reader.GetFloat(106); /* PointsAwarded_ForScratch nullable true*/
  var arg107 = reader.IsDBNull(107) ? (float?)null :reader.GetFloat(107); /* PointsAwarded_ForNT nullable true*/
  var arg108 = reader.GetBoolean(108); /* Enter_AthStat nullable false*/
  var arg109 = reader.GetBoolean(109); /* Show_secondclub nullable false*/
  var arg110 = reader.GetBoolean(110); /* firstinitial_fulllastname nullable false*/
  var arg111 = reader.GetBoolean(111); /* turnon_autobackup nullable false*/
  var arg112 = reader.IsDBNull(112) ? (short?)null :reader.GetInt16(112); /* autobackup_interval nullable true*/
  var arg113 = reader.GetBoolean(113); /* PointsAwarded_ForExh nullable false*/
  var arg114 = reader.GetBoolean(114); /* Use_AltTeamAbbr nullable false*/
  var arg115 = reader.GetBoolean(115); /* IsCanadian_Masters nullable false*/
  var arg116 = reader.GetTextReader(116).ReadLine(); /* entry_msg nullable false*/
  var arg117 = reader.GetBoolean(117); /* timedfinalnonconform_last nullable false*/
  var arg118 = reader.GetTextReader(118).ReadLine(); /* referee_name nullable false*/
  var arg119 = reader.GetTextReader(119).ReadLine(); /* referee_homphone nullable false*/
  var arg120 = reader.GetTextReader(120).ReadLine(); /* referee_offphone nullable false*/
  var arg121 = reader.IsDBNull(121) ? (long?)null :reader.GetInt32(121); /* Meet_altitude nullable true*/
  var arg122 = reader.GetBoolean(122); /* Read_Only nullable false*/
  var arg123 = reader.IsDBNull(123) ? (short?)null :reader.GetInt16(123); /* masters_indlowage nullable true*/
  var arg124 = reader.IsDBNull(124) ? (short?)null :reader.GetInt16(124); /* masters_rellowage nullable true*/
  var arg125 = reader.GetTextReader(125).ReadLine(); /* Import_Dir nullable false*/
  var arg126 = reader.GetTextReader(126).ReadLine(); /* Export_Dir nullable false*/
  var arg127 = reader.GetTextReader(127).ReadLine(); /* Backup_Dir nullable false*/
  var arg128 = reader.GetTextReader(128).ReadLine(); /* RestoreFrom_Dir nullable false*/
  var arg129 = reader.GetTextReader(129).ReadLine(); /* RestoreTo_Dir nullable false*/
  var arg130 = reader.GetTextReader(130).ReadLine(); /* FlatHtml_Dir nullable false*/
  var arg131 = reader.GetTextReader(131).ReadLine(); /* APNews_Dir nullable false*/
  var arg132 = reader.GetBoolean(132); /* AllowSameEvent_DupRelayNames nullable false*/
  var arg133 = reader.IsDBNull(133) ? (long?)null :reader.GetInt32(133); /* dualteam_lane1 nullable true*/
  var arg134 = reader.IsDBNull(134) ? (long?)null :reader.GetInt32(134); /* dualteam_lane2 nullable true*/
  var arg135 = reader.IsDBNull(135) ? (long?)null :reader.GetInt32(135); /* dualteam_lane3 nullable true*/
  var arg136 = reader.IsDBNull(136) ? (long?)null :reader.GetInt32(136); /* dualteam_lane4 nullable true*/
  var arg137 = reader.IsDBNull(137) ? (long?)null :reader.GetInt32(137); /* dualteam_lane5 nullable true*/
  var arg138 = reader.IsDBNull(138) ? (long?)null :reader.GetInt32(138); /* dualteam_lane6 nullable true*/
  var arg139 = reader.IsDBNull(139) ? (long?)null :reader.GetInt32(139); /* dualteam_lane7 nullable true*/
  var arg140 = reader.IsDBNull(140) ? (long?)null :reader.GetInt32(140); /* dualteam_lane8 nullable true*/
  var arg141 = reader.IsDBNull(141) ? (long?)null :reader.GetInt32(141); /* dualteam_lane9 nullable true*/
  var arg142 = reader.IsDBNull(142) ? (long?)null :reader.GetInt32(142); /* dualteam_lane10 nullable true*/
  var arg143 = reader.GetBoolean(143); /* strict_evenoddfastestheatonly nullable false*/
  var arg144 = reader.GetBoolean(144); /* dualseeding_altunusedlane nullable false*/
  var arg145 = reader.IsDBNull(145) ? (decimal?)null :reader.GetDecimal(145); /* team_surcharge nullable true*/
  var arg146 = reader.GetBoolean(146); /* display_actualentrytime nullable false*/
  var arg147 = reader.IsDBNull(147) ? (short?)null :reader.GetInt16(147); /* indmaxadvance_perteam nullable true*/
  var arg148 = reader.IsDBNull(148) ? (short?)null :reader.GetInt16(148); /* relmaxadvance_perteam nullable true*/
  var arg149 = reader.GetBoolean(149); /* RelayNames_LinkByLSC nullable false*/
  var arg150 = reader.GetBoolean(150); /* Flighted_BasedOnResultsTime nullable false*/
  var arg151 = reader.GetBoolean(151); /* ShowYear_InPlaceOfAge nullable false*/
  var arg152 = reader.IsDBNull(152) ? (float?)null :reader.GetFloat(152); /* PenaltyPts_ForNS nullable true*/
  var arg153 = reader.IsDBNull(153) ? (DateTime?)null :reader.GetDateTime(153); /* EntryEligibility_date nullable true*/
  var arg154 = reader.IsDBNull(154) ? (decimal?)null :reader.GetDecimal(154); /* Facility_Surcharge nullable true*/
  var arg155 = reader.GetBoolean(155); /* Suppress_TimeStdAbbr nullable false*/
  var arg156 = reader.GetBoolean(156); /* Custom_QualTimes nullable false*/
  var arg157 = reader.GetBoolean(157); /* Suppress_SplitsForDQs nullable false*/
  var arg158 = reader.GetBoolean(158); /* Suppress_SplitsForDQsRelay nullable false*/
  var arg159 = reader.GetTextReader(159).ReadLine(); /* DQCodes_Type nullable false*/
  var arg160 = reader.GetBoolean(160); /* SuppressTimes_NotMeetQualTime nullable false*/
  var arg161 = reader.GetBoolean(161); /* Show_AgeandBirthYear nullable false*/
  var arg162 = reader.GetTextReader(162).ReadLine(); /* Meet_state nullable false*/
  var arg163 = reader.GetTextReader(163).ReadLine(); /* Meet_country nullable false*/
  var arg164 = reader.GetTextReader(164).ReadLine(); /* Meet_lsc nullable false*/
  var arg165 = reader.GetBoolean(165); /* BCSSA_DivbyTimeStd nullable false*/
  var arg166 = reader.GetBoolean(166); /* Show_HyTekDecimals nullable false*/
  var arg167 = reader.GetBoolean(167); /* Suppress_ResultsAdvQ nullable false*/
  var arg168 = reader.GetBoolean(168); /* RelaysAs_4x100Style nullable false*/
  var arg169 = reader.IsDBNull(169) ? (short?)null :reader.GetInt16(169); /* flighted_flightcount nullable true*/
  var arg170 = reader.GetBoolean(170); /* flighted_inclDQ nullable false*/
  var arg171 = reader.GetBoolean(171); /* RelaysAlternate_TwoFastestFirst nullable false*/
  var arg172 = reader.IsDBNull(172) ? (long?)null :reader.GetInt32(172); /* dualteam_lane11 nullable true*/
  var arg173 = reader.IsDBNull(173) ? (long?)null :reader.GetInt32(173); /* dualteam_lane12 nullable true*/
  var arg174 = reader.IsDBNull(174) ? (DateTime?)null :reader.GetDateTime(174); /* entry_deadline nullable true*/
  var arg175 = reader.GetTextReader(175).ReadLine(); /* Meet_addr1 nullable false*/
  var arg176 = reader.GetTextReader(176).ReadLine(); /* Meet_addr2 nullable false*/
  var arg177 = reader.GetTextReader(177).ReadLine(); /* Meet_city nullable false*/
  var arg178 = reader.GetTextReader(178).ReadLine(); /* Meet_zip nullable false*/
  var arg179 = reader.GetTextReader(179).ReadLine(); /* Meet_hostlsc nullable false*/
  var arg180 = reader.GetTextReader(180).ReadLine(); /* Meet_USMastersMeetID nullable false*/
  var arg181 = reader.GetBoolean(181); /* ShowFirstName_OverPreferred nullable false*/
  var arg182 = reader.GetBoolean(182); /* ExcludeNTEntries_WhenImporting nullable false*/
  var arg183 = reader.GetBoolean(183); /* Enter_birthcentury nullable false*/
  var arg184 = reader.GetBoolean(184); /* Using_twopools nullable false*/
  var arg185 = reader.GetTextReader(185).ReadLine(); /* Pool1_name nullable false*/
  var arg186 = reader.GetTextReader(186).ReadLine(); /* Pool2_name nullable false*/
  var arg187 = reader.IsDBNull(187) ? (short?)null :reader.GetInt16(187); /* indtopmany_awardsSr nullable true*/
  var arg188 = reader.IsDBNull(188) ? (short?)null :reader.GetInt16(188); /* reltopmany_awardsSr nullable true*/
  var arg189 = reader.IsDBNull(189) ? (short?)null :reader.GetInt16(189); /* maxforeign_infinal nullable true*/
  var arg190 = reader.GetBoolean(190); /* Flag_FastestRecordOnly nullable false*/
  var arg191 = reader.IsDBNull(191) ? (decimal?)null :reader.GetDecimal(191); /* athlete_earlysurcharge nullable true*/
  var arg192 = reader.IsDBNull(192) ? (decimal?)null :reader.GetDecimal(192); /* athlete_latesurcharge nullable true*/
  var arg193 = reader.IsDBNull(193) ? (DateTime?)null :reader.GetDateTime(193); /* athlete_earlysurchargedate nullable true*/
  var arg194 = reader.IsDBNull(194) ? (DateTime?)null :reader.GetDateTime(194); /* athlete_latesurchargedate nullable true*/
  var arg195 = reader.IsDBNull(195) ? (DateTime?)null :reader.GetDateTime(195); /* entry_OMEopendate nullable true*/
  var arg196 = reader.GetBoolean(196); /* DisplayNTfor_TimesUnder5Sec nullable false*/
  var arg197 = reader.GetBoolean(197); /* SortTeamCombos_ByTeamName nullable false*/
  var arg198 = reader.GetBoolean(198); /* FastestHeat_SomeLanesDoNotScore nullable false*/
  var arg199 = reader.GetBoolean(199); /* RankDisabled_ByPoints nullable false*/
  var arg200 = reader.IsDBNull(200) ? (short?)null :reader.GetInt16(200); /* special_parapoints nullable true*/
  var arg201 = reader.GetBoolean(201); /* DisabledDoNot_AdvanceToFinals nullable false*/
  var arg202 = reader.IsDBNull(202) ? (short?)null :reader.GetInt16(202); /* prelimheats_circledist nullable true*/
  var arg203 = reader.GetBoolean(203); /* DisabledIgnoreQualTime_ForScoring nullable false*/
  var arg204 = reader.GetBoolean(204); /* CountTimeTrial_Events nullable false*/
  var arg205 = reader.GetTextReader(205).ReadLine(); /* Meet_header1 nullable false*/
  var arg206 = reader.GetTextReader(206).ReadLine(); /* Meet_header2 nullable false*/
  var arg207 = reader.GetBoolean(207); /* QualNonConformCourse_UseMinStd nullable false*/
  var arg208 = reader.IsDBNull(208) ? (DateTime?)null :reader.GetDateTime(208); /* entry_OpenDate nullable true*/
  var arg209 = reader.GetTextReader(209).ReadLine(); /* TimeAdj_Method nullable false*/
  var arg210 = reader.GetBoolean(210); /* Lock_Reseed nullable false*/
  var arg211 = reader.GetTextReader(211).ReadLine(); /* sanction_number nullable false*/
  var arg212 = reader.GetTextReader(212).ReadLine(); /* Last_updated nullable false*/
  var arg213 = reader.GetBoolean(213); /* MixedRelays_DividedPoints nullable false*/
  var arg214 = reader.IsDBNull(214) ? (decimal?)null :reader.GetDecimal(214); /* RelayOnly_Surcharge nullable true*/
  var arg215 = reader.GetBoolean(215); /* DisabledSeedWithAgeGroup_IfTimedFinalSuperSeed nullable false*/
  var arg216 = reader.GetTextReader(216).ReadLine(); /* Competition_Code nullable false*/
  var arg217 = reader.IsDBNull(217) ? (float?)null :reader.GetFloat(217); /* PenaltyTimeSec_ForCombEvtDQ nullable true*/
      collection.Add( new Meet(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95, arg96, arg97, arg98, arg99, arg100, arg101, arg102, arg103, arg104, arg105, arg106, arg107, arg108, arg109, arg110, arg111, arg112, arg113, arg114, arg115, arg116, arg117, arg118, arg119, arg120, arg121, arg122, arg123, arg124, arg125, arg126, arg127, arg128, arg129, arg130, arg131, arg132, arg133, arg134, arg135, arg136, arg137, arg138, arg139, arg140, arg141, arg142, arg143, arg144, arg145, arg146, arg147, arg148, arg149, arg150, arg151, arg152, arg153, arg154, arg155, arg156, arg157, arg158, arg159, arg160, arg161, arg162, arg163, arg164, arg165, arg166, arg167, arg168, arg169, arg170, arg171, arg172, arg173, arg174, arg175, arg176, arg177, arg178, arg179, arg180, arg181, arg182, arg183, arg184, arg185, arg186, arg187, arg188, arg189, arg190, arg191, arg192, arg193, arg194, arg195, arg196, arg197, arg198, arg199, arg200, arg201, arg202, arg203, arg204, arg205, arg206, arg207, arg208, arg209, arg210, arg211, arg212, arg213, arg214, arg215, arg216, arg217));
    }
  }
  return collection;
}
  // Properties
  public string MeetName1{ get; } = meetName1;
  public string MeetLocation{ get; } = meetLocation;
  public DateTime? MeetStart{ get; } = meetStart;
  public DateTime? MeetEnd{ get; } = meetEnd;
  public short? MeetIdformat{ get; } = meetIdformat;
  public short? MeetClass{ get; } = meetClass;
  public short? MeetMeettype{ get; } = meetMeettype;
  public short? MeetCourse{ get; } = meetCourse;
  public bool EnterAges{ get; } = enterAges;
  public bool EnterBirthdate{ get; } = enterBirthdate;
  public DateTime? CalcDate{ get; } = calcDate;
  public bool EnterSchoolyr{ get; } = enterSchoolyr;
  public bool ARelaysonly{ get; } = aRelaysonly;
  public bool UseHometown{ get; } = useHometown;
  public bool ShowCountrycode{ get; } = showCountrycode;
  public bool ScoresAfterevt{ get; } = scoresAfterevt;
  public bool LastnameFirst{ get; } = lastnameFirst;
  public bool PunctNames{ get; } = punctNames;
  public bool PunctTeams{ get; } = punctTeams;
  public bool Win_mm{ get; } = win_mm;
  public short? Meet_numlanes{ get; } = meet_numlanes;
  public short? Prelimheats_circle{ get; } = prelimheats_circle;
  public bool Timedfinal_circleseed{ get; } = timedfinal_circleseed;
  public bool Foreign_infinal{ get; } = foreign_infinal;
  public bool Exh_infinal{ get; } = exh_infinal;
  public bool Nonconform_last{ get; } = nonconform_last;
  public string Course_order{ get; } = course_order;
  public bool Seed_exhlast{ get; } = seed_exhlast;
  public bool Dual_evenodd{ get; } = dual_evenodd;
  public bool Strict_evenodd{ get; } = strict_evenodd;
  public long? Team_evenlanes{ get; } = team_evenlanes;
  public long? Team_oddlanes{ get; } = team_oddlanes;
  public bool Masters_bytimeonly{ get; } = masters_bytimeonly;
  public short? Masters_agegrpsskip{ get; } = masters_agegrpsskip;
  public short? Timer_port{ get; } = timer_port;
  public short? Scbd_port{ get; } = scbd_port;
  public string Timer_vendor{ get; } = timer_vendor;
  public string Scbd_vendor{ get; } = scbd_vendor;
  public bool Show_initial{ get; } = show_initial;
  public bool Ucase_names{ get; } = ucase_names;
  public bool Ucase_teams{ get; } = ucase_teams;
  public string Open_senior_none{ get; } = open_senior_none;
  public bool Entryqual_faster{ get; } = entryqual_faster;
  public decimal? Indentryfee_surcharge{ get; } = indentryfee_surcharge;
  public bool Anyone_onrelay{ get; } = anyone_onrelay;
  public string Language_choice{ get; } = language_choice;
  public bool Military_time{ get; } = military_time;
  public bool Check_times{ get; } = check_times;
  public bool Enterkey_astab{ get; } = enterkey_astab;
  public bool Double_endedsplits{ get; } = double_endedsplits;
  public bool Use_compnumbers{ get; } = use_compnumbers;
  public short? Flighted_minentries{ get; } = flighted_minentries;
  public bool Diffpts_malefemale{ get; } = diffpts_malefemale;
  public bool Diffpts_eachdivision{ get; } = diffpts_eachdivision;
  public bool Scoreonly_ifexceedqualtime{ get; } = scoreonly_ifexceedqualtime;
  public bool Score_fastestheatonly{ get; } = score_fastestheatonly;
  public bool Entrylimits_warn{ get; } = entrylimits_warn;
  public bool Pointsbasedon_seedtime{ get; } = pointsbasedon_seedtime;
  public bool Pointsfor_overachievers{ get; } = pointsfor_overachievers;
  public bool Pointsfor_underachievers{ get; } = pointsfor_underachievers;
  public short? Indmaxscorers_perteam{ get; } = indmaxscorers_perteam;
  public short? Relmaxscorers_perteam{ get; } = relmaxscorers_perteam;
  public short? Indtopmany_awards{ get; } = indtopmany_awards;
  public short? Reltopmany_awards{ get; } = reltopmany_awards;
  public short? Entrymax_total{ get; } = entrymax_total;
  public short? Indmax_perath{ get; } = indmax_perath;
  public short? Relmax_perath{ get; } = relmax_perath;
  public bool Foreign_getteampoints{ get; } = foreign_getteampoints;
  public bool Include_swimupsinteamscore{ get; } = include_swimupsinteamscore;
  public bool Enter_citizenof{ get; } = enter_citizenof;
  public short? Meet_meetstyle{ get; } = meet_meetstyle;
  public bool Flag_overachievers{ get; } = flag_overachievers;
  public bool Flag_underachievers{ get; } = flag_underachievers;
  public short? Scbd_punctuation{ get; } = scbd_punctuation;
  public short? Scbd_names{ get; } = scbd_names;
  public short? Scbd_relaynames{ get; } = scbd_relaynames;
  public bool Scbd_cycle{ get; } = scbd_cycle;
  public short? Scbd_cycleseconds{ get; } = scbd_cycleseconds;
  public short? Copies_toprinter{ get; } = copies_toprinter;
  public bool Report_headersonly{ get; } = report_headersonly;
  public bool Autoinc_compno{ get; } = autoinc_compno;
  public bool Pentscoring_usedqtime{ get; } = pentscoring_usedqtime;
  public decimal? Swimmer_surcharge{ get; } = swimmer_surcharge;
  public bool Directly_toprinter{ get; } = directly_toprinter;
  public bool Lastname_asinitial{ get; } = lastname_asinitial;
  public bool Under_eventname{ get; } = under_eventname;
  public bool SuppressArelay{ get; } = suppressArelay;
  public bool PunctRecholders{ get; } = punctRecholders;
  public bool Ucase_recholders{ get; } = ucase_recholders;
  public bool Suppress_lsc{ get; } = suppress_lsc;
  public bool Showathlete_status{ get; } = showathlete_status;
  public short? Open_lowage{ get; } = open_lowage;
  public bool Useeventsex_teamscore{ get; } = useeventsex_teamscore;
  public bool Suppress_smallx{ get; } = suppress_smallx;
  public bool ScoreArelayonly{ get; } = scoreArelayonly;
  public bool Thirteenandover_assenior{ get; } = thirteenandover_assenior;
  public bool Suppress_jd{ get; } = suppress_jd;
  public string Abcfinal_order{ get; } = abcfinal_order;
  public short? Maxagefor_cfinal{ get; } = maxagefor_cfinal;
  public bool Include_sanction{ get; } = include_sanction;
  public short? Special_points{ get; } = special_points;
  public bool Countrelay_alt{ get; } = countrelay_alt;
  public bool UseNonConformingPoolFactor{ get; } = useNonConformingPoolFactor;
  public float? NonConformingPoolFactor{ get; } = nonConformingPoolFactor;
  public string Apnews_team{ get; } = apnews_team;
  public float? PointsAwardedForDQ{ get; } = pointsAwardedForDQ;
  public float? PointsAwardedForScratch{ get; } = pointsAwardedForScratch;
  public float? PointsAwardedForNT{ get; } = pointsAwardedForNT;
  public bool EnterAthStat{ get; } = enterAthStat;
  public bool ShowSecondclub{ get; } = showSecondclub;
  public bool Firstinitial_fulllastname{ get; } = firstinitial_fulllastname;
  public bool Turnon_autobackup{ get; } = turnon_autobackup;
  public short? Autobackup_interval{ get; } = autobackup_interval;
  public bool PointsAwardedForExh{ get; } = pointsAwardedForExh;
  public bool UseAltTeamAbbr{ get; } = useAltTeamAbbr;
  public bool IsCanadianMasters{ get; } = isCanadianMasters;
  public string Entry_msg{ get; } = entry_msg;
  public bool Timedfinalnonconform_last{ get; } = timedfinalnonconform_last;
  public string Referee_name{ get; } = referee_name;
  public string Referee_homphone{ get; } = referee_homphone;
  public string Referee_offphone{ get; } = referee_offphone;
  public long? MeetAltitude{ get; } = meetAltitude;
  public bool ReadOnly{ get; } = readOnly;
  public short? Masters_indlowage{ get; } = masters_indlowage;
  public short? Masters_rellowage{ get; } = masters_rellowage;
  public string ImportDir{ get; } = importDir;
  public string ExportDir{ get; } = exportDir;
  public string BackupDir{ get; } = backupDir;
  public string RestoreFromDir{ get; } = restoreFromDir;
  public string RestoreToDir{ get; } = restoreToDir;
  public string FlatHtmlDir{ get; } = flatHtmlDir;
  public string APNewsDir{ get; } = aPNewsDir;
  public bool AllowSameEventDupRelayNames{ get; } = allowSameEventDupRelayNames;
  public long? Dualteam_lane1{ get; } = dualteam_lane1;
  public long? Dualteam_lane2{ get; } = dualteam_lane2;
  public long? Dualteam_lane3{ get; } = dualteam_lane3;
  public long? Dualteam_lane4{ get; } = dualteam_lane4;
  public long? Dualteam_lane5{ get; } = dualteam_lane5;
  public long? Dualteam_lane6{ get; } = dualteam_lane6;
  public long? Dualteam_lane7{ get; } = dualteam_lane7;
  public long? Dualteam_lane8{ get; } = dualteam_lane8;
  public long? Dualteam_lane9{ get; } = dualteam_lane9;
  public long? Dualteam_lane10{ get; } = dualteam_lane10;
  public bool Strict_evenoddfastestheatonly{ get; } = strict_evenoddfastestheatonly;
  public bool Dualseeding_altunusedlane{ get; } = dualseeding_altunusedlane;
  public decimal? Team_surcharge{ get; } = team_surcharge;
  public bool Display_actualentrytime{ get; } = display_actualentrytime;
  public short? Indmaxadvance_perteam{ get; } = indmaxadvance_perteam;
  public short? Relmaxadvance_perteam{ get; } = relmaxadvance_perteam;
  public bool RelayNamesLinkByLSC{ get; } = relayNamesLinkByLSC;
  public bool FlightedBasedOnResultsTime{ get; } = flightedBasedOnResultsTime;
  public bool ShowYearInPlaceOfAge{ get; } = showYearInPlaceOfAge;
  public float? PenaltyPtsForNS{ get; } = penaltyPtsForNS;
  public DateTime? EntryEligibilityDate{ get; } = entryEligibilityDate;
  public decimal? FacilitySurcharge{ get; } = facilitySurcharge;
  public bool SuppressTimeStdAbbr{ get; } = suppressTimeStdAbbr;
  public bool CustomQualTimes{ get; } = customQualTimes;
  public bool SuppressSplitsForDQs{ get; } = suppressSplitsForDQs;
  public bool SuppressSplitsForDQsRelay{ get; } = suppressSplitsForDQsRelay;
  public string DQCodesType{ get; } = dQCodesType;
  public bool SuppressTimesNotMeetQualTime{ get; } = suppressTimesNotMeetQualTime;
  public bool ShowAgeandBirthYear{ get; } = showAgeandBirthYear;
  public string MeetState{ get; } = meetState;
  public string MeetCountry{ get; } = meetCountry;
  public string MeetLsc{ get; } = meetLsc;
  public bool BCSSADivbyTimeStd{ get; } = bCSSADivbyTimeStd;
  public bool ShowHyTekDecimals{ get; } = showHyTekDecimals;
  public bool SuppressResultsAdvQ{ get; } = suppressResultsAdvQ;
  public bool RelaysAs4x100Style{ get; } = relaysAs4x100Style;
  public short? Flighted_flightcount{ get; } = flighted_flightcount;
  public bool FlightedInclDQ{ get; } = flightedInclDQ;
  public bool RelaysAlternateTwoFastestFirst{ get; } = relaysAlternateTwoFastestFirst;
  public long? Dualteam_lane11{ get; } = dualteam_lane11;
  public long? Dualteam_lane12{ get; } = dualteam_lane12;
  public DateTime? Entry_deadline{ get; } = entry_deadline;
  public string MeetAddr1{ get; } = meetAddr1;
  public string MeetAddr2{ get; } = meetAddr2;
  public string MeetCity{ get; } = meetCity;
  public string MeetZip{ get; } = meetZip;
  public string MeetHostlsc{ get; } = meetHostlsc;
  public string MeetUSMastersMeetID{ get; } = meetUSMastersMeetID;
  public bool ShowFirstNameOverPreferred{ get; } = showFirstNameOverPreferred;
  public bool ExcludeNTEntriesWhenImporting{ get; } = excludeNTEntriesWhenImporting;
  public bool EnterBirthcentury{ get; } = enterBirthcentury;
  public bool UsingTwopools{ get; } = usingTwopools;
  public string Pool1Name{ get; } = pool1Name;
  public string Pool2Name{ get; } = pool2Name;
  public short? IndtopmanyAwardsSr{ get; } = indtopmanyAwardsSr;
  public short? ReltopmanyAwardsSr{ get; } = reltopmanyAwardsSr;
  public short? Maxforeign_infinal{ get; } = maxforeign_infinal;
  public bool FlagFastestRecordOnly{ get; } = flagFastestRecordOnly;
  public decimal? Athlete_earlysurcharge{ get; } = athlete_earlysurcharge;
  public decimal? Athlete_latesurcharge{ get; } = athlete_latesurcharge;
  public DateTime? Athlete_earlysurchargedate{ get; } = athlete_earlysurchargedate;
  public DateTime? Athlete_latesurchargedate{ get; } = athlete_latesurchargedate;
  public DateTime? EntryOMEopendate{ get; } = entryOMEopendate;
  public bool DisplayNTforTimesUnder5Sec{ get; } = displayNTforTimesUnder5Sec;
  public bool SortTeamCombosByTeamName{ get; } = sortTeamCombosByTeamName;
  public bool FastestHeatSomeLanesDoNotScore{ get; } = fastestHeatSomeLanesDoNotScore;
  public bool RankDisabledByPoints{ get; } = rankDisabledByPoints;
  public short? Special_parapoints{ get; } = special_parapoints;
  public bool DisabledDoNotAdvanceToFinals{ get; } = disabledDoNotAdvanceToFinals;
  public short? Prelimheats_circledist{ get; } = prelimheats_circledist;
  public bool DisabledIgnoreQualTimeForScoring{ get; } = disabledIgnoreQualTimeForScoring;
  public bool CountTimeTrialEvents{ get; } = countTimeTrialEvents;
  public string MeetHeader1{ get; } = meetHeader1;
  public string MeetHeader2{ get; } = meetHeader2;
  public bool QualNonConformCourseUseMinStd{ get; } = qualNonConformCourseUseMinStd;
  public DateTime? EntryOpenDate{ get; } = entryOpenDate;
  public string TimeAdjMethod{ get; } = timeAdjMethod;
  public bool LockReseed{ get; } = lockReseed;
  public string Sanction_number{ get; } = sanction_number;
  public string LastUpdated{ get; } = lastUpdated;
  public bool MixedRelaysDividedPoints{ get; } = mixedRelaysDividedPoints;
  public decimal? RelayOnlySurcharge{ get; } = relayOnlySurcharge;
  public bool DisabledSeedWithAgeGroupIfTimedFinalSuperSeed{ get; } = disabledSeedWithAgeGroupIfTimedFinalSuperSeed;
  public string CompetitionCode{ get; } = competitionCode;
  public float? PenaltyTimeSecForCombEvtDQ{ get; } = penaltyTimeSecForCombEvtDQ;
}
}
}
