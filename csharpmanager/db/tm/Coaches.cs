using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [COACHES]
/// // (
/// // [Coaches] Long Integer,
/// // [Team] Long Integer,
/// // [CPhone] Text (28),
/// // [CEMail] Text (72),
/// // [CName] Text (60),
/// // [CTitle] Text (30),
/// // [Cert1] Text (30),
/// // [Cert2] Text (30),
/// // [Cert3] Text (30),
/// // [Head] Boolean NOT NULL,
/// // [CoachCell] Text (40),
/// // [Export] Boolean NOT NULL,
/// // [Cert4] Text (30),
/// // [Cert5] Text (30),
/// // [Cert1Expire] DateTime,
/// // [Cert2Expire] DateTime,
/// // [Cert3Expire] DateTime,
/// // [Cert4Expire] DateTime,
/// // [Cert5Expire] DateTime,
/// // [PrimaryMale] Boolean NOT NULL,
/// // [PrimaryFemale] Boolean NOT NULL,
/// // [MaleOnly] Boolean NOT NULL,
/// // [FemaleOnly] Boolean NOT NULL,
/// // [cLastName] Text (40),
/// // [cFirstName] Text (40),
/// // [CFirst] Text (30),
/// // [CLast] Text (30)
/// // );

public class Coaches(long coaches, long? team, string cPhone, string cEMail, string cName, string cTitle, string cert1, string cert2, string cert3, bool head, string coachCell, bool cexport, string cert4, string cert5, DateTime? cert1Expire, DateTime? cert2Expire, DateTime? cert3Expire, DateTime? cert4Expire, DateTime? cert5Expire, bool primaryMale, bool primaryFemale, bool maleOnly, bool femaleOnly, string cLastName, string cFirstName, string cFirst, string cLast )
{
static public List<Coaches> Get(OdbcConnection connection)
{
  var collection = new List<Coaches>();
  string query = "select * from COACHES";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetInt32(0); /* Coaches nullable false*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Team nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* CPhone nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* CEMail nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* CName nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* CTitle nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* Cert1 nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Cert2 nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Cert3 nullable false*/
  var arg9 = reader.GetBoolean(9); /* Head nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* CoachCell nullable false*/
  var arg11 = reader.GetBoolean(11); /* Export nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Cert4 nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Cert5 nullable false*/
  var arg14 = reader.IsDBNull(14) ? (DateTime?)null :reader.GetDateTime(14); /* Cert1Expire nullable true*/
  var arg15 = reader.IsDBNull(15) ? (DateTime?)null :reader.GetDateTime(15); /* Cert2Expire nullable true*/
  var arg16 = reader.IsDBNull(16) ? (DateTime?)null :reader.GetDateTime(16); /* Cert3Expire nullable true*/
  var arg17 = reader.IsDBNull(17) ? (DateTime?)null :reader.GetDateTime(17); /* Cert4Expire nullable true*/
  var arg18 = reader.IsDBNull(18) ? (DateTime?)null :reader.GetDateTime(18); /* Cert5Expire nullable true*/
  var arg19 = reader.GetBoolean(19); /* PrimaryMale nullable false*/
  var arg20 = reader.GetBoolean(20); /* PrimaryFemale nullable false*/
  var arg21 = reader.GetBoolean(21); /* MaleOnly nullable false*/
  var arg22 = reader.GetBoolean(22); /* FemaleOnly nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* cLastName nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* cFirstName nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* CFirst nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* CLast nullable false*/
      collection.Add( new Coaches(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26));
    }
  }
  return collection;
}
  // Properties
  public long Coaches_{ get; } = coaches;
  public long? Team{ get; } = team;
  public string CPhone{ get; } = cPhone;
  public string CEMail{ get; } = cEMail;
  public string CName{ get; } = cName;
  public string CTitle{ get; } = cTitle;
  public string Cert1{ get; } = cert1;
  public string Cert2{ get; } = cert2;
  public string Cert3{ get; } = cert3;
  public bool Head{ get; } = head;
  public string CoachCell{ get; } = coachCell;
  public bool Cexport{ get; } = cexport;
  public string Cert4{ get; } = cert4;
  public string Cert5{ get; } = cert5;
  public DateTime? Cert1Expire{ get; } = cert1Expire;
  public DateTime? Cert2Expire{ get; } = cert2Expire;
  public DateTime? Cert3Expire{ get; } = cert3Expire;
  public DateTime? Cert4Expire{ get; } = cert4Expire;
  public DateTime? Cert5Expire{ get; } = cert5Expire;
  public bool PrimaryMale{ get; } = primaryMale;
  public bool PrimaryFemale{ get; } = primaryFemale;
  public bool MaleOnly{ get; } = maleOnly;
  public bool FemaleOnly{ get; } = femaleOnly;
  public string CLastName{ get; } = cLastName;
  public string CFirstName{ get; } = cFirstName;
  public string CFirst{ get; } = cFirst;
  public string CLast{ get; } = cLast;
}
}
}
