using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [Athlete]
/// // (
/// // [Athlete] Long Integer,
/// // [Team1] Long Integer,
/// // [Team2] Long Integer,
/// // [Team3] Long Integer,
/// // [Group] Text (6),
/// // [SubGr] Text (6),
/// // [Last] Text (40),
/// // [First] Text (40),
/// // [Initial] Text (2),
/// // [Sex] Text (2),
/// // [Birth] DateTime,
/// // [Age] Integer,
/// // [Class] Text (6),
/// // [ID_NO] Text (34),
/// // [Citizen] Text (6),
/// // [Inactive] Boolean NOT NULL,
/// // [Pref] Text (40),
/// // [Batch] Integer,
/// // [WMGroup] Text (6),
/// // [WMSubGr] Text (6),
/// // [BCSSASwimmer] Text (4),
/// // [BCSSADiver] Text (4),
/// // [BCSSASyncro] Text (4),
/// // [BCSSAPolo] Text (4),
/// // [TheSort] Long Integer,
/// // [DiveCertified] Boolean NOT NULL,
/// // [DateClubJoined] DateTime,
/// // [DateGroupJoined] DateTime,
/// // [AWRegType] Text (2),
/// // [RegYear] Integer,
/// // [Foreign] Boolean NOT NULL,
/// // [ForeignCitizenOf] Text (6),
/// // [LastUpdated] DateTime,
/// // [PC_Hide] Boolean NOT NULL
/// // );

public class Athlete(long athlete, long? team1, long? team2, long? team3, string group, string subGr, string last, string first, string initial, string sex, DateTime? birth, short? age, string cclass, string id_no, string citizen, bool inactive, string pref, short? batch, string wMGroup, string wMSubGr, string bCSSASwimmer, string bCSSADiver, string bCSSASyncro, string bCSSAPolo, long? theSort, bool diveCertified, DateTime? dateClubJoined, DateTime? dateGroupJoined, string aWRegType, short? regYear, bool foreign, string foreignCitizenOf, DateTime? lastUpdated, bool pCHide )
{
static public List<Athlete> Get(OdbcConnection connection)
{
  var collection = new List<Athlete>();
  string query = "select * from Athlete";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetInt32(0); /* Athlete nullable false*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Team1 nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Team2 nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* Team3 nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Group nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* SubGr nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* Last nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* First nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Initial nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Sex nullable false*/
  var arg10 = reader.IsDBNull(10) ? (DateTime?)null :reader.GetDateTime(10); /* Birth nullable true*/
  var arg11 = reader.IsDBNull(11) ? (short?)null :reader.GetInt16(11); /* Age nullable true*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Class nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* ID_NO nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Citizen nullable false*/
  var arg15 = reader.GetBoolean(15); /* Inactive nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Pref nullable false*/
  var arg17 = reader.IsDBNull(17) ? (short?)null :reader.GetInt16(17); /* Batch nullable true*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* WMGroup nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* WMSubGr nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* BCSSASwimmer nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* BCSSADiver nullable false*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* BCSSASyncro nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* BCSSAPolo nullable false*/
  var arg24 = reader.IsDBNull(24) ? (long?)null :reader.GetInt32(24); /* TheSort nullable true*/
  var arg25 = reader.GetBoolean(25); /* DiveCertified nullable false*/
  var arg26 = reader.IsDBNull(26) ? (DateTime?)null :reader.GetDateTime(26); /* DateClubJoined nullable true*/
  var arg27 = reader.IsDBNull(27) ? (DateTime?)null :reader.GetDateTime(27); /* DateGroupJoined nullable true*/
  var arg28 = reader.GetTextReader(28).ReadLine(); /* AWRegType nullable false*/
  var arg29 = reader.IsDBNull(29) ? (short?)null :reader.GetInt16(29); /* RegYear nullable true*/
  var arg30 = reader.GetBoolean(30); /* Foreign nullable false*/
  var arg31 = reader.GetTextReader(31).ReadLine(); /* ForeignCitizenOf nullable false*/
  var arg32 = reader.IsDBNull(32) ? (DateTime?)null :reader.GetDateTime(32); /* LastUpdated nullable true*/
  var arg33 = reader.GetBoolean(33); /* PC_Hide nullable false*/
      collection.Add( new Athlete(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33));
    }
  }
  return collection;
}
  // Properties
  public long Athlete_{ get; } = athlete;
  public long? Team1{ get; } = team1;
  public long? Team2{ get; } = team2;
  public long? Team3{ get; } = team3;
  public string Group{ get; } = group;
  public string SubGr{ get; } = subGr;
  public string Last{ get; } = last;
  public string First{ get; } = first;
  public string Initial{ get; } = initial;
  public string Sex{ get; } = sex;
  public DateTime? Birth{ get; } = birth;
  public short? Age{ get; } = age;
  public string Cclass{ get; } = cclass;
  public string Id_no{ get; } = id_no;
  public string Citizen{ get; } = citizen;
  public bool Inactive{ get; } = inactive;
  public string Pref{ get; } = pref;
  public short? Batch{ get; } = batch;
  public string WMGroup{ get; } = wMGroup;
  public string WMSubGr{ get; } = wMSubGr;
  public string BCSSASwimmer{ get; } = bCSSASwimmer;
  public string BCSSADiver{ get; } = bCSSADiver;
  public string BCSSASyncro{ get; } = bCSSASyncro;
  public string BCSSAPolo{ get; } = bCSSAPolo;
  public long? TheSort{ get; } = theSort;
  public bool DiveCertified{ get; } = diveCertified;
  public DateTime? DateClubJoined{ get; } = dateClubJoined;
  public DateTime? DateGroupJoined{ get; } = dateGroupJoined;
  public string AWRegType{ get; } = aWRegType;
  public short? RegYear{ get; } = regYear;
  public bool Foreign{ get; } = foreign;
  public string ForeignCitizenOf{ get; } = foreignCitizenOf;
  public DateTime? LastUpdated{ get; } = lastUpdated;
  public bool PCHide{ get; } = pCHide;
}
}
}
