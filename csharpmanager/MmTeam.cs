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
/// CREATE TABLE [Team]
/// (
/// [Team_no] Long Integer,
/// [Team_name] Text (60),
/// [Team_short] Text (32),
/// [Team_abbr] Text (10),
/// [Team_stat] Text (2),
/// [Team_div] Integer,
/// [Team_region] Integer,
/// [Team_head] Text (60),
/// [Team_asst] Text (60),
/// [Team_addr1] Text (60),
/// [Team_addr2] Text (60),
/// [Team_city] Text (60),
/// [Team_prov] Text (60),
/// [Team_statenew] Text (6),
/// [Team_zip] Text (20),
/// [Team_cntry] Text (6),
/// [Team_daytele] Text (40),
/// [Team_evetele] Text (40),
/// [Team_faxtele] Text (40),
/// [Team_email] Text (72),
/// [Team_c3] Text (60),
/// [Team_c4] Text (60),
/// [Team_c5] Text (60),
/// [Team_c6] Text (60),
/// [Team_c7] Text (60),
/// [Team_c8] Text (60),
/// [Team_c9] Text (60),
/// [Team_c10] Text (60),
/// [Team_altabbr] Text (10),
/// [Team_NoPoints] Boolean NOT NULL,
/// [Team_Selected] Boolean NOT NULL,
/// [Team_altname] Text (32),
/// [InvitedTeam_AgencyID] Long Integer,
/// [InvitedTeam_Email] Text (110),
/// [Invited_InviteCode] Text (30),
/// [InvitedEntry_status] Text (50),
/// [InvitedPayment_status] Text (50),
/// [Invited_notes] Text (510),
/// [Invited_GovBody] Text (100),
/// [Invited_TeamID] Long Integer,
/// [InvitedHas_notes] Boolean NOT NULL,
/// [InvitedLeague_name] Text (50),
/// [InvitedFile_status] Text (50),
/// [InvitedFile_importdatetime] Text (50),
/// [InvitedFile_TMuploaddatetime] Text (50),
/// [InvitedFile_source] Text (50),
/// [Invited_TeamEntryID] Long Integer,
/// [Invited_Athletecount] Text (30),
/// [team_lsc] Text (6),
/// [NoTeam_surcharge] Boolean NOT NULL,
/// [NoFacility_surcharge] Boolean NOT NULL,
/// [NoAthlete_surcharge] Boolean NOT NULL,
/// [Team_cell] Text (40),
/// [NoRelayOnly_surcharge] Boolean NOT NULL,
/// [Team_Code] Text (60),
/// [Team_Gender] Text (2)
/// );

public class MmTeam 
{
List<MmTeam> get(OdbcConnection connection)
{
  var collection = new List<MmTeam>();
  string query = "select * from Team";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Team_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Team_name */
      var arg2 = reader.GetTextReader(3).ToString(); /* Team_short */
      var arg3 = reader.GetTextReader(4).ToString(); /* Team_abbr */
      var arg4 = reader.GetTextReader(5).ToString(); /* Team_stat */
      var arg5 = reader.GetInt16(6); /* Team_div */
      var arg6 = reader.GetInt16(7); /* Team_region */
      var arg7 = reader.GetTextReader(8).ToString(); /* Team_head */
      var arg8 = reader.GetTextReader(9).ToString(); /* Team_asst */
      var arg9 = reader.GetTextReader(10).ToString(); /* Team_addr1 */
      var arg10 = reader.GetTextReader(11).ToString(); /* Team_addr2 */
      var arg11 = reader.GetTextReader(12).ToString(); /* Team_city */
      var arg12 = reader.GetTextReader(13).ToString(); /* Team_prov */
      var arg13 = reader.GetTextReader(14).ToString(); /* Team_statenew */
      var arg14 = reader.GetTextReader(15).ToString(); /* Team_zip */
      var arg15 = reader.GetTextReader(16).ToString(); /* Team_cntry */
      var arg16 = reader.GetTextReader(17).ToString(); /* Team_daytele */
      var arg17 = reader.GetTextReader(18).ToString(); /* Team_evetele */
      var arg18 = reader.GetTextReader(19).ToString(); /* Team_faxtele */
      var arg19 = reader.GetTextReader(20).ToString(); /* Team_email */
      var arg20 = reader.GetTextReader(21).ToString(); /* Team_c3 */
      var arg21 = reader.GetTextReader(22).ToString(); /* Team_c4 */
      var arg22 = reader.GetTextReader(23).ToString(); /* Team_c5 */
      var arg23 = reader.GetTextReader(24).ToString(); /* Team_c6 */
      var arg24 = reader.GetTextReader(25).ToString(); /* Team_c7 */
      var arg25 = reader.GetTextReader(26).ToString(); /* Team_c8 */
      var arg26 = reader.GetTextReader(27).ToString(); /* Team_c9 */
      var arg27 = reader.GetTextReader(28).ToString(); /* Team_c10 */
      var arg28 = reader.GetTextReader(29).ToString(); /* Team_altabbr */
      var arg29 = reader.GetBoolean(30); /* Team_NoPoints */
      var arg30 = reader.GetBoolean(31); /* Team_Selected */
      var arg31 = reader.GetTextReader(32).ToString(); /* Team_altname */
      var arg32 = reader.GetInt64(33); /* InvitedTeam_AgencyID */
      var arg33 = reader.GetTextReader(34).ToString(); /* InvitedTeam_Email */
      var arg34 = reader.GetTextReader(35).ToString(); /* Invited_InviteCode */
      var arg35 = reader.GetTextReader(36).ToString(); /* InvitedEntry_status */
      var arg36 = reader.GetTextReader(37).ToString(); /* InvitedPayment_status */
      var arg37 = reader.GetTextReader(38).ToString(); /* Invited_notes */
      var arg38 = reader.GetTextReader(39).ToString(); /* Invited_GovBody */
      var arg39 = reader.GetInt64(40); /* Invited_TeamID */
      var arg40 = reader.GetBoolean(41); /* InvitedHas_notes */
      var arg41 = reader.GetTextReader(42).ToString(); /* InvitedLeague_name */
      var arg42 = reader.GetTextReader(43).ToString(); /* InvitedFile_status */
      var arg43 = reader.GetTextReader(44).ToString(); /* InvitedFile_importdatetime */
      var arg44 = reader.GetTextReader(45).ToString(); /* InvitedFile_TMuploaddatetime */
      var arg45 = reader.GetTextReader(46).ToString(); /* InvitedFile_source */
      var arg46 = reader.GetInt64(47); /* Invited_TeamEntryID */
      var arg47 = reader.GetTextReader(48).ToString(); /* Invited_Athletecount */
      var arg48 = reader.GetTextReader(49).ToString(); /* team_lsc */
      var arg49 = reader.GetBoolean(50); /* NoTeam_surcharge */
      var arg50 = reader.GetBoolean(51); /* NoFacility_surcharge */
      var arg51 = reader.GetBoolean(52); /* NoAthlete_surcharge */
      var arg52 = reader.GetTextReader(53).ToString(); /* Team_cell */
      var arg53 = reader.GetBoolean(54); /* NoRelayOnly_surcharge */
      var arg54 = reader.GetTextReader(55).ToString(); /* Team_Code */
      var arg55 = reader.GetTextReader(56).ToString(); /* Team_Gender */
      collection.Add( new MmTeam(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55));
    }
  }
  return collection;
}
  // Properties
  public long TeamNo{ get; }
  public string TeamName{ get; }
  public string TeamShort{ get; }
  public string TeamAbbr{ get; }
  public string TeamStat{ get; }
  public short TeamDiv{ get; }
  public short TeamRegion{ get; }
  public string TeamHead{ get; }
  public string TeamAsst{ get; }
  public string TeamAddr1{ get; }
  public string TeamAddr2{ get; }
  public string TeamCity{ get; }
  public string TeamProv{ get; }
  public string TeamStatenew{ get; }
  public string TeamZip{ get; }
  public string TeamCntry{ get; }
  public string TeamDaytele{ get; }
  public string TeamEvetele{ get; }
  public string TeamFaxtele{ get; }
  public string TeamEmail{ get; }
  public string TeamC3{ get; }
  public string TeamC4{ get; }
  public string TeamC5{ get; }
  public string TeamC6{ get; }
  public string TeamC7{ get; }
  public string TeamC8{ get; }
  public string TeamC9{ get; }
  public string TeamC10{ get; }
  public string TeamAltabbr{ get; }
  public bool TeamNoPoints{ get; }
  public bool TeamSelected{ get; }
  public string TeamAltname{ get; }
  public long InvitedTeamAgencyID{ get; }
  public string InvitedTeamEmail{ get; }
  public string InvitedInviteCode{ get; }
  public string InvitedEntryStatus{ get; }
  public string InvitedPaymentStatus{ get; }
  public string InvitedNotes{ get; }
  public string InvitedGovBody{ get; }
  public long InvitedTeamID{ get; }
  public bool InvitedHasNotes{ get; }
  public string InvitedLeagueName{ get; }
  public string InvitedFileStatus{ get; }
  public string InvitedFileImportdatetime{ get; }
  public string InvitedFileTMuploaddatetime{ get; }
  public string InvitedFileSource{ get; }
  public long InvitedTeamEntryID{ get; }
  public string InvitedAthletecount{ get; }
  public string Team_lsc{ get; }
  public bool NoTeamSurcharge{ get; }
  public bool NoFacilitySurcharge{ get; }
  public bool NoAthleteSurcharge{ get; }
  public string TeamCell{ get; }
  public bool NoRelayOnlySurcharge{ get; }
  public string TeamCode{ get; }
  public string TeamGender{ get; }
  // Constructor
  MmTeam(long teamNo, string teamName, string teamShort, string teamAbbr, string teamStat, short teamDiv, short teamRegion, string teamHead, string teamAsst, string teamAddr1, string teamAddr2, string teamCity, string teamProv, string teamStatenew, string teamZip, string teamCntry, string teamDaytele, string teamEvetele, string teamFaxtele, string teamEmail, string teamC3, string teamC4, string teamC5, string teamC6, string teamC7, string teamC8, string teamC9, string teamC10, string teamAltabbr, bool teamNoPoints, bool teamSelected, string teamAltname, long invitedTeamAgencyID, string invitedTeamEmail, string invitedInviteCode, string invitedEntryStatus, string invitedPaymentStatus, string invitedNotes, string invitedGovBody, long invitedTeamID, bool invitedHasNotes, string invitedLeagueName, string invitedFileStatus, string invitedFileImportdatetime, string invitedFileTMuploaddatetime, string invitedFileSource, long invitedTeamEntryID, string invitedAthletecount, string team_lsc, bool noTeamSurcharge, bool noFacilitySurcharge, bool noAthleteSurcharge, string teamCell, bool noRelayOnlySurcharge, string teamCode, string teamGender )
  {
    TeamNo = teamNo;
    TeamName = teamName;
    TeamShort = teamShort;
    TeamAbbr = teamAbbr;
    TeamStat = teamStat;
    TeamDiv = teamDiv;
    TeamRegion = teamRegion;
    TeamHead = teamHead;
    TeamAsst = teamAsst;
    TeamAddr1 = teamAddr1;
    TeamAddr2 = teamAddr2;
    TeamCity = teamCity;
    TeamProv = teamProv;
    TeamStatenew = teamStatenew;
    TeamZip = teamZip;
    TeamCntry = teamCntry;
    TeamDaytele = teamDaytele;
    TeamEvetele = teamEvetele;
    TeamFaxtele = teamFaxtele;
    TeamEmail = teamEmail;
    TeamC3 = teamC3;
    TeamC4 = teamC4;
    TeamC5 = teamC5;
    TeamC6 = teamC6;
    TeamC7 = teamC7;
    TeamC8 = teamC8;
    TeamC9 = teamC9;
    TeamC10 = teamC10;
    TeamAltabbr = teamAltabbr;
    TeamNoPoints = teamNoPoints;
    TeamSelected = teamSelected;
    TeamAltname = teamAltname;
    InvitedTeamAgencyID = invitedTeamAgencyID;
    InvitedTeamEmail = invitedTeamEmail;
    InvitedInviteCode = invitedInviteCode;
    InvitedEntryStatus = invitedEntryStatus;
    InvitedPaymentStatus = invitedPaymentStatus;
    InvitedNotes = invitedNotes;
    InvitedGovBody = invitedGovBody;
    InvitedTeamID = invitedTeamID;
    InvitedHasNotes = invitedHasNotes;
    InvitedLeagueName = invitedLeagueName;
    InvitedFileStatus = invitedFileStatus;
    InvitedFileImportdatetime = invitedFileImportdatetime;
    InvitedFileTMuploaddatetime = invitedFileTMuploaddatetime;
    InvitedFileSource = invitedFileSource;
    InvitedTeamEntryID = invitedTeamEntryID;
    InvitedAthletecount = invitedAthletecount;
    Team_lsc = team_lsc;
    NoTeamSurcharge = noTeamSurcharge;
    NoFacilitySurcharge = noFacilitySurcharge;
    NoAthleteSurcharge = noAthleteSurcharge;
    TeamCell = teamCell;
    NoRelayOnlySurcharge = noRelayOnlySurcharge;
    TeamCode = teamCode;
    TeamGender = teamGender;
  }
}
