using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Team]
/// // (
/// // [Team_no] Long Integer,
/// // [Team_name] Text (60),
/// // [Team_short] Text (32),
/// // [Team_abbr] Text (10),
/// // [Team_stat] Text (2),
/// // [Team_div] Integer,
/// // [Team_region] Integer,
/// // [Team_head] Text (60),
/// // [Team_asst] Text (60),
/// // [Team_addr1] Text (60),
/// // [Team_addr2] Text (60),
/// // [Team_city] Text (60),
/// // [Team_prov] Text (60),
/// // [Team_statenew] Text (6),
/// // [Team_zip] Text (20),
/// // [Team_cntry] Text (6),
/// // [Team_daytele] Text (40),
/// // [Team_evetele] Text (40),
/// // [Team_faxtele] Text (40),
/// // [Team_email] Text (72),
/// // [Team_c3] Text (60),
/// // [Team_c4] Text (60),
/// // [Team_c5] Text (60),
/// // [Team_c6] Text (60),
/// // [Team_c7] Text (60),
/// // [Team_c8] Text (60),
/// // [Team_c9] Text (60),
/// // [Team_c10] Text (60),
/// // [Team_altabbr] Text (10),
/// // [Team_NoPoints] Boolean NOT NULL,
/// // [Team_Selected] Boolean NOT NULL,
/// // [Team_altname] Text (32),
/// // [InvitedTeam_AgencyID] Long Integer,
/// // [InvitedTeam_Email] Text (110),
/// // [Invited_InviteCode] Text (30),
/// // [InvitedEntry_status] Text (50),
/// // [InvitedPayment_status] Text (50),
/// // [Invited_notes] Text (510),
/// // [Invited_GovBody] Text (100),
/// // [Invited_TeamID] Long Integer,
/// // [InvitedHas_notes] Boolean NOT NULL,
/// // [InvitedLeague_name] Text (50),
/// // [InvitedFile_status] Text (50),
/// // [InvitedFile_importdatetime] Text (50),
/// // [InvitedFile_TMuploaddatetime] Text (50),
/// // [InvitedFile_source] Text (50),
/// // [Invited_TeamEntryID] Long Integer,
/// // [Invited_Athletecount] Text (30),
/// // [team_lsc] Text (6),
/// // [NoTeam_surcharge] Boolean NOT NULL,
/// // [NoFacility_surcharge] Boolean NOT NULL,
/// // [NoAthlete_surcharge] Boolean NOT NULL,
/// // [Team_cell] Text (40),
/// // [NoRelayOnly_surcharge] Boolean NOT NULL,
/// // [Team_Code] Text (60),
/// // [Team_Gender] Text (2)
/// // );

public class Team(long? teamNo, string teamName, string teamShort, string teamAbbr, string teamStat, short? teamDiv, short? teamRegion, string teamHead, string teamAsst, string teamAddr1, string teamAddr2, string teamCity, string teamProv, string teamStatenew, string teamZip, string teamCntry, string teamDaytele, string teamEvetele, string teamFaxtele, string teamEmail, string teamC3, string teamC4, string teamC5, string teamC6, string teamC7, string teamC8, string teamC9, string teamC10, string teamAltabbr, bool teamNoPoints, bool teamSelected, string teamAltname, long? invitedTeamAgencyID, string invitedTeamEmail, string invitedInviteCode, string invitedEntryStatus, string invitedPaymentStatus, string invitedNotes, string invitedGovBody, long? invitedTeamID, bool invitedHasNotes, string invitedLeagueName, string invitedFileStatus, string invitedFileImportdatetime, string invitedFileTMuploaddatetime, string invitedFileSource, long? invitedTeamEntryID, string invitedAthletecount, string team_lsc, bool noTeamSurcharge, bool noFacilitySurcharge, bool noAthleteSurcharge, string teamCell, bool noRelayOnlySurcharge, string teamCode, string teamGender )
{
static public List<Team> Get(OdbcConnection connection)
{
  var collection = new List<Team>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Team_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Team_name nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Team_short nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Team_abbr nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Team_stat nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Team_div nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* Team_region nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Team_head nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Team_asst nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Team_addr1 nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Team_addr2 nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Team_city nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Team_prov nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Team_statenew nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Team_zip nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Team_cntry nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Team_daytele nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* Team_evetele nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* Team_faxtele nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* Team_email nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* Team_c3 nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* Team_c4 nullable false*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* Team_c5 nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* Team_c6 nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* Team_c7 nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* Team_c8 nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* Team_c9 nullable false*/
  var arg27 = reader.GetTextReader(27).ReadLine(); /* Team_c10 nullable false*/
  var arg28 = reader.GetTextReader(28).ReadLine(); /* Team_altabbr nullable false*/
  var arg29 = reader.GetBoolean(29); /* Team_NoPoints nullable false*/
  var arg30 = reader.GetBoolean(30); /* Team_Selected nullable false*/
  var arg31 = reader.GetTextReader(31).ReadLine(); /* Team_altname nullable false*/
  var arg32 = reader.IsDBNull(32) ? (long?)null :reader.GetInt32(32); /* InvitedTeam_AgencyID nullable true*/
  var arg33 = reader.GetTextReader(33).ReadLine(); /* InvitedTeam_Email nullable false*/
  var arg34 = reader.GetTextReader(34).ReadLine(); /* Invited_InviteCode nullable false*/
  var arg35 = reader.GetTextReader(35).ReadLine(); /* InvitedEntry_status nullable false*/
  var arg36 = reader.GetTextReader(36).ReadLine(); /* InvitedPayment_status nullable false*/
  var arg37 = reader.GetTextReader(37).ReadLine(); /* Invited_notes nullable false*/
  var arg38 = reader.GetTextReader(38).ReadLine(); /* Invited_GovBody nullable false*/
  var arg39 = reader.IsDBNull(39) ? (long?)null :reader.GetInt32(39); /* Invited_TeamID nullable true*/
  var arg40 = reader.GetBoolean(40); /* InvitedHas_notes nullable false*/
  var arg41 = reader.GetTextReader(41).ReadLine(); /* InvitedLeague_name nullable false*/
  var arg42 = reader.GetTextReader(42).ReadLine(); /* InvitedFile_status nullable false*/
  var arg43 = reader.GetTextReader(43).ReadLine(); /* InvitedFile_importdatetime nullable false*/
  var arg44 = reader.GetTextReader(44).ReadLine(); /* InvitedFile_TMuploaddatetime nullable false*/
  var arg45 = reader.GetTextReader(45).ReadLine(); /* InvitedFile_source nullable false*/
  var arg46 = reader.IsDBNull(46) ? (long?)null :reader.GetInt32(46); /* Invited_TeamEntryID nullable true*/
  var arg47 = reader.GetTextReader(47).ReadLine(); /* Invited_Athletecount nullable false*/
  var arg48 = reader.GetTextReader(48).ReadLine(); /* team_lsc nullable false*/
  var arg49 = reader.GetBoolean(49); /* NoTeam_surcharge nullable false*/
  var arg50 = reader.GetBoolean(50); /* NoFacility_surcharge nullable false*/
  var arg51 = reader.GetBoolean(51); /* NoAthlete_surcharge nullable false*/
  var arg52 = reader.GetTextReader(52).ReadLine(); /* Team_cell nullable false*/
  var arg53 = reader.GetBoolean(53); /* NoRelayOnly_surcharge nullable false*/
  var arg54 = reader.GetTextReader(54).ReadLine(); /* Team_Code nullable false*/
  var arg55 = reader.GetTextReader(55).ReadLine(); /* Team_Gender nullable false*/
      collection.Add( new Team(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55));
    }
  }
  return collection;
}
  // Properties
  public long? TeamNo{ get; } = teamNo;
  public string TeamName{ get; } = teamName;
  public string TeamShort{ get; } = teamShort;
  public string TeamAbbr{ get; } = teamAbbr;
  public string TeamStat{ get; } = teamStat;
  public short? TeamDiv{ get; } = teamDiv;
  public short? TeamRegion{ get; } = teamRegion;
  public string TeamHead{ get; } = teamHead;
  public string TeamAsst{ get; } = teamAsst;
  public string TeamAddr1{ get; } = teamAddr1;
  public string TeamAddr2{ get; } = teamAddr2;
  public string TeamCity{ get; } = teamCity;
  public string TeamProv{ get; } = teamProv;
  public string TeamStatenew{ get; } = teamStatenew;
  public string TeamZip{ get; } = teamZip;
  public string TeamCntry{ get; } = teamCntry;
  public string TeamDaytele{ get; } = teamDaytele;
  public string TeamEvetele{ get; } = teamEvetele;
  public string TeamFaxtele{ get; } = teamFaxtele;
  public string TeamEmail{ get; } = teamEmail;
  public string TeamC3{ get; } = teamC3;
  public string TeamC4{ get; } = teamC4;
  public string TeamC5{ get; } = teamC5;
  public string TeamC6{ get; } = teamC6;
  public string TeamC7{ get; } = teamC7;
  public string TeamC8{ get; } = teamC8;
  public string TeamC9{ get; } = teamC9;
  public string TeamC10{ get; } = teamC10;
  public string TeamAltabbr{ get; } = teamAltabbr;
  public bool TeamNoPoints{ get; } = teamNoPoints;
  public bool TeamSelected{ get; } = teamSelected;
  public string TeamAltname{ get; } = teamAltname;
  public long? InvitedTeamAgencyID{ get; } = invitedTeamAgencyID;
  public string InvitedTeamEmail{ get; } = invitedTeamEmail;
  public string InvitedInviteCode{ get; } = invitedInviteCode;
  public string InvitedEntryStatus{ get; } = invitedEntryStatus;
  public string InvitedPaymentStatus{ get; } = invitedPaymentStatus;
  public string InvitedNotes{ get; } = invitedNotes;
  public string InvitedGovBody{ get; } = invitedGovBody;
  public long? InvitedTeamID{ get; } = invitedTeamID;
  public bool InvitedHasNotes{ get; } = invitedHasNotes;
  public string InvitedLeagueName{ get; } = invitedLeagueName;
  public string InvitedFileStatus{ get; } = invitedFileStatus;
  public string InvitedFileImportdatetime{ get; } = invitedFileImportdatetime;
  public string InvitedFileTMuploaddatetime{ get; } = invitedFileTMuploaddatetime;
  public string InvitedFileSource{ get; } = invitedFileSource;
  public long? InvitedTeamEntryID{ get; } = invitedTeamEntryID;
  public string InvitedAthletecount{ get; } = invitedAthletecount;
  public string Team_lsc{ get; } = team_lsc;
  public bool NoTeamSurcharge{ get; } = noTeamSurcharge;
  public bool NoFacilitySurcharge{ get; } = noFacilitySurcharge;
  public bool NoAthleteSurcharge{ get; } = noAthleteSurcharge;
  public string TeamCell{ get; } = teamCell;
  public bool NoRelayOnlySurcharge{ get; } = noRelayOnlySurcharge;
  public string TeamCode{ get; } = teamCode;
  public string TeamGender{ get; } = teamGender;
}
}
}
