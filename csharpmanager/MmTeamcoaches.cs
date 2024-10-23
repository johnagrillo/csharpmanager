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
/// CREATE TABLE [TeamCoaches]
/// (
/// [Coach_no] Long Integer,
/// [Team_no] Long Integer,
/// [Coach_LastName] Text (40),
/// [Coach_FirstName] Text (40),
/// [Coach_Title] Text (30),
/// [Primary_MaleHeadCoach] Boolean NOT NULL,
/// [Primary_FemaleHeadCoach] Boolean NOT NULL,
/// [MaleCoach_Only] Boolean NOT NULL,
/// [FemaleCoach_Only] Boolean NOT NULL,
/// [Coach_Phone] Text (40),
/// [Coach_Cell] Text (40),
/// [Coach_EMail] Text (72),
/// [Coach_Cert1] Text (30),
/// [Coach_Cert2] Text (30),
/// [Coach_Cert3] Text (30),
/// [Coach_Cert4] Text (30),
/// [Coach_ExpDate1] DateTime,
/// [Coach_ExpDate2] DateTime,
/// [Coach_ExpDate3] DateTime,
/// [Coach_ExpDate4] DateTime
/// );

public class MmTeamcoaches 
{
List<MmTeamcoaches> get(OdbcConnection connection)
{
  var collection = new List<MmTeamcoaches>();
  string query = "select * from TeamCoaches";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Coach_no */
      var arg1 = reader.GetInt64(2); /* Team_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* Coach_LastName */
      var arg3 = reader.GetTextReader(4).ToString(); /* Coach_FirstName */
      var arg4 = reader.GetTextReader(5).ToString(); /* Coach_Title */
      var arg5 = reader.GetBoolean(6); /* Primary_MaleHeadCoach */
      var arg6 = reader.GetBoolean(7); /* Primary_FemaleHeadCoach */
      var arg7 = reader.GetBoolean(8); /* MaleCoach_Only */
      var arg8 = reader.GetBoolean(9); /* FemaleCoach_Only */
      var arg9 = reader.GetTextReader(10).ToString(); /* Coach_Phone */
      var arg10 = reader.GetTextReader(11).ToString(); /* Coach_Cell */
      var arg11 = reader.GetTextReader(12).ToString(); /* Coach_EMail */
      var arg12 = reader.GetTextReader(13).ToString(); /* Coach_Cert1 */
      var arg13 = reader.GetTextReader(14).ToString(); /* Coach_Cert2 */
      var arg14 = reader.GetTextReader(15).ToString(); /* Coach_Cert3 */
      var arg15 = reader.GetTextReader(16).ToString(); /* Coach_Cert4 */
      var arg16 = reader.GetDateTime(17); /* Coach_ExpDate1 */
      var arg17 = reader.GetDateTime(18); /* Coach_ExpDate2 */
      var arg18 = reader.GetDateTime(19); /* Coach_ExpDate3 */
      var arg19 = reader.GetDateTime(20); /* Coach_ExpDate4 */
      collection.Add( new MmTeamcoaches(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19));
    }
  }
  return collection;
}
  // Properties
  public long CoachNo{ get; }
  public long TeamNo{ get; }
  public string CoachLastName{ get; }
  public string CoachFirstName{ get; }
  public string CoachTitle{ get; }
  public bool PrimaryMaleHeadCoach{ get; }
  public bool PrimaryFemaleHeadCoach{ get; }
  public bool MaleCoachOnly{ get; }
  public bool FemaleCoachOnly{ get; }
  public string CoachPhone{ get; }
  public string CoachCell{ get; }
  public string CoachEMail{ get; }
  public string CoachCert1{ get; }
  public string CoachCert2{ get; }
  public string CoachCert3{ get; }
  public string CoachCert4{ get; }
  public DateTime CoachExpDate1{ get; }
  public DateTime CoachExpDate2{ get; }
  public DateTime CoachExpDate3{ get; }
  public DateTime CoachExpDate4{ get; }
  // Constructor
  MmTeamcoaches(long coachNo, long teamNo, string coachLastName, string coachFirstName, string coachTitle, bool primaryMaleHeadCoach, bool primaryFemaleHeadCoach, bool maleCoachOnly, bool femaleCoachOnly, string coachPhone, string coachCell, string coachEMail, string coachCert1, string coachCert2, string coachCert3, string coachCert4, DateTime coachExpDate1, DateTime coachExpDate2, DateTime coachExpDate3, DateTime coachExpDate4 )
  {
    CoachNo = coachNo;
    TeamNo = teamNo;
    CoachLastName = coachLastName;
    CoachFirstName = coachFirstName;
    CoachTitle = coachTitle;
    PrimaryMaleHeadCoach = primaryMaleHeadCoach;
    PrimaryFemaleHeadCoach = primaryFemaleHeadCoach;
    MaleCoachOnly = maleCoachOnly;
    FemaleCoachOnly = femaleCoachOnly;
    CoachPhone = coachPhone;
    CoachCell = coachCell;
    CoachEMail = coachEMail;
    CoachCert1 = coachCert1;
    CoachCert2 = coachCert2;
    CoachCert3 = coachCert3;
    CoachCert4 = coachCert4;
    CoachExpDate1 = coachExpDate1;
    CoachExpDate2 = coachExpDate2;
    CoachExpDate3 = coachExpDate3;
    CoachExpDate4 = coachExpDate4;
  }
}
