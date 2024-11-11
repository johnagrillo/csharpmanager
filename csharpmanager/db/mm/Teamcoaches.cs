using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [TeamCoaches]
/// // (
/// // [Coach_no] Long Integer,
/// // [Team_no] Long Integer,
/// // [Coach_LastName] Text (40),
/// // [Coach_FirstName] Text (40),
/// // [Coach_Title] Text (30),
/// // [Primary_MaleHeadCoach] Boolean NOT NULL,
/// // [Primary_FemaleHeadCoach] Boolean NOT NULL,
/// // [MaleCoach_Only] Boolean NOT NULL,
/// // [FemaleCoach_Only] Boolean NOT NULL,
/// // [Coach_Phone] Text (40),
/// // [Coach_Cell] Text (40),
/// // [Coach_EMail] Text (72),
/// // [Coach_Cert1] Text (30),
/// // [Coach_Cert2] Text (30),
/// // [Coach_Cert3] Text (30),
/// // [Coach_Cert4] Text (30),
/// // [Coach_ExpDate1] DateTime,
/// // [Coach_ExpDate2] DateTime,
/// // [Coach_ExpDate3] DateTime,
/// // [Coach_ExpDate4] DateTime
/// // );

public class Teamcoaches(long? coachNo, long? teamNo, string coachLastName, string coachFirstName, string coachTitle, bool primaryMaleHeadCoach, bool primaryFemaleHeadCoach, bool maleCoachOnly, bool femaleCoachOnly, string coachPhone, string coachCell, string coachEMail, string coachCert1, string coachCert2, string coachCert3, string coachCert4, DateTime? coachExpDate1, DateTime? coachExpDate2, DateTime? coachExpDate3, DateTime? coachExpDate4 )
{
static public List<Teamcoaches> Get(OdbcConnection connection)
{
  var collection = new List<Teamcoaches>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Coach_no nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Team_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Coach_LastName nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Coach_FirstName nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Coach_Title nullable false*/
  var arg5 = reader.GetBoolean(5); /* Primary_MaleHeadCoach nullable false*/
  var arg6 = reader.GetBoolean(6); /* Primary_FemaleHeadCoach nullable false*/
  var arg7 = reader.GetBoolean(7); /* MaleCoach_Only nullable false*/
  var arg8 = reader.GetBoolean(8); /* FemaleCoach_Only nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Coach_Phone nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Coach_Cell nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Coach_EMail nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Coach_Cert1 nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Coach_Cert2 nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Coach_Cert3 nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Coach_Cert4 nullable false*/
  var arg16 = reader.IsDBNull(16) ? (DateTime?)null :reader.GetDateTime(16); /* Coach_ExpDate1 nullable true*/
  var arg17 = reader.IsDBNull(17) ? (DateTime?)null :reader.GetDateTime(17); /* Coach_ExpDate2 nullable true*/
  var arg18 = reader.IsDBNull(18) ? (DateTime?)null :reader.GetDateTime(18); /* Coach_ExpDate3 nullable true*/
  var arg19 = reader.IsDBNull(19) ? (DateTime?)null :reader.GetDateTime(19); /* Coach_ExpDate4 nullable true*/
      collection.Add( new Teamcoaches(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19));
    }
  }
  return collection;
}
  // Properties
  public long? CoachNo{ get; } = coachNo;
  public long? TeamNo{ get; } = teamNo;
  public string CoachLastName{ get; } = coachLastName;
  public string CoachFirstName{ get; } = coachFirstName;
  public string CoachTitle{ get; } = coachTitle;
  public bool PrimaryMaleHeadCoach{ get; } = primaryMaleHeadCoach;
  public bool PrimaryFemaleHeadCoach{ get; } = primaryFemaleHeadCoach;
  public bool MaleCoachOnly{ get; } = maleCoachOnly;
  public bool FemaleCoachOnly{ get; } = femaleCoachOnly;
  public string CoachPhone{ get; } = coachPhone;
  public string CoachCell{ get; } = coachCell;
  public string CoachEMail{ get; } = coachEMail;
  public string CoachCert1{ get; } = coachCert1;
  public string CoachCert2{ get; } = coachCert2;
  public string CoachCert3{ get; } = coachCert3;
  public string CoachCert4{ get; } = coachCert4;
  public DateTime? CoachExpDate1{ get; } = coachExpDate1;
  public DateTime? CoachExpDate2{ get; } = coachExpDate2;
  public DateTime? CoachExpDate3{ get; } = coachExpDate3;
  public DateTime? CoachExpDate4{ get; } = coachExpDate4;
}
}
}
