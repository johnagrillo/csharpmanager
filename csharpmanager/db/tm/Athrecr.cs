using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [ATHRECR]
/// // (
/// // [Athlete] Long Integer,
/// // [Grad] Integer,
/// // [PicFile] Text (22),
/// // [HS_Name] Text (60),
/// // [HS_Phone] Text (40),
/// // [HS_Addr] Text (60),
/// // [HS_City] Text (40),
/// // [HS_State] Text (6),
/// // [HS_ZIP] Text (20),
/// // [HS_Coach] Text (60),
/// // [Oth_Team] Text (60),
/// // [Oth_Coach] Text (60),
/// // [HS_Study] Text (40),
/// // [HS_Rank] Integer,
/// // [HS_Num] Integer,
/// // [HS_GPA] Single,
/// // [Activities] Text (100),
/// // [Awards] Text (40),
/// // [Add_Info] Text (100),
/// // [Camps] Text (100),
/// // [T1Score] Integer,
/// // [Remarks] Text (100),
/// // [T3Score1] Integer,
/// // [T2Score] Integer,
/// // [Height] Integer,
/// // [Weight] Integer,
/// // [Oth_Phone] Text (40),
/// // [Picture] Text (120),
/// // [Video] Boolean NOT NULL,
/// // [Comments] Text (510),
/// // [T1Name] Text (16),
/// // [T2Name] Text (16),
/// // [T3Name] Text (16),
/// // [T3SName1] Text (16),
/// // [T3SName2] Text (16),
/// // [T3Score2] Integer
/// // );

public class Athrecr(long? athlete, short? grad, string picFile, string hSName, string hSPhone, string hSAddr, string hSCity, string hSState, string hs_zip, string hSCoach, string othTeam, string othCoach, string hSStudy, short? hSRank, short? hSNum, float? hs_gpa, string activities, string awards, string addInfo, string camps, short? t1Score, string remarks, short? t3Score1, short? t2Score, short? height, short? weight, string othPhone, string picture, bool video, string comments, string t1Name, string t2Name, string t3Name, string t3SName1, string t3SName2, short? t3Score2 )
{
static public List<Athrecr> Get(OdbcConnection connection)
{
  var collection = new List<Athrecr>();
  string query = "select * from ATHRECR";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Athlete nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Grad nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* PicFile nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* HS_Name nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* HS_Phone nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* HS_Addr nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* HS_City nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* HS_State nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* HS_ZIP nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* HS_Coach nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Oth_Team nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Oth_Coach nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* HS_Study nullable false*/
  var arg13 = reader.IsDBNull(13) ? (short?)null :reader.GetInt16(13); /* HS_Rank nullable true*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* HS_Num nullable true*/
  var arg15 = reader.IsDBNull(15) ? (float?)null :reader.GetFloat(15); /* HS_GPA nullable true*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Activities nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* Awards nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* Add_Info nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* Camps nullable false*/
  var arg20 = reader.IsDBNull(20) ? (short?)null :reader.GetInt16(20); /* T1Score nullable true*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* Remarks nullable false*/
  var arg22 = reader.IsDBNull(22) ? (short?)null :reader.GetInt16(22); /* T3Score1 nullable true*/
  var arg23 = reader.IsDBNull(23) ? (short?)null :reader.GetInt16(23); /* T2Score nullable true*/
  var arg24 = reader.IsDBNull(24) ? (short?)null :reader.GetInt16(24); /* Height nullable true*/
  var arg25 = reader.IsDBNull(25) ? (short?)null :reader.GetInt16(25); /* Weight nullable true*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* Oth_Phone nullable false*/
  var arg27 = reader.GetTextReader(27).ReadLine(); /* Picture nullable false*/
  var arg28 = reader.GetBoolean(28); /* Video nullable false*/
  var arg29 = reader.GetTextReader(29).ReadLine(); /* Comments nullable false*/
  var arg30 = reader.GetTextReader(30).ReadLine(); /* T1Name nullable false*/
  var arg31 = reader.GetTextReader(31).ReadLine(); /* T2Name nullable false*/
  var arg32 = reader.GetTextReader(32).ReadLine(); /* T3Name nullable false*/
  var arg33 = reader.GetTextReader(33).ReadLine(); /* T3SName1 nullable false*/
  var arg34 = reader.GetTextReader(34).ReadLine(); /* T3SName2 nullable false*/
  var arg35 = reader.IsDBNull(35) ? (short?)null :reader.GetInt16(35); /* T3Score2 nullable true*/
      collection.Add( new Athrecr(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35));
    }
  }
  return collection;
}
  // Properties
  public long? Athlete{ get; } = athlete;
  public short? Grad{ get; } = grad;
  public string PicFile{ get; } = picFile;
  public string HSName{ get; } = hSName;
  public string HSPhone{ get; } = hSPhone;
  public string HSAddr{ get; } = hSAddr;
  public string HSCity{ get; } = hSCity;
  public string HSState{ get; } = hSState;
  public string Hs_zip{ get; } = hs_zip;
  public string HSCoach{ get; } = hSCoach;
  public string OthTeam{ get; } = othTeam;
  public string OthCoach{ get; } = othCoach;
  public string HSStudy{ get; } = hSStudy;
  public short? HSRank{ get; } = hSRank;
  public short? HSNum{ get; } = hSNum;
  public float? Hs_gpa{ get; } = hs_gpa;
  public string Activities{ get; } = activities;
  public string Awards{ get; } = awards;
  public string AddInfo{ get; } = addInfo;
  public string Camps{ get; } = camps;
  public short? T1Score{ get; } = t1Score;
  public string Remarks{ get; } = remarks;
  public short? T3Score1{ get; } = t3Score1;
  public short? T2Score{ get; } = t2Score;
  public short? Height{ get; } = height;
  public short? Weight{ get; } = weight;
  public string OthPhone{ get; } = othPhone;
  public string Picture{ get; } = picture;
  public bool Video{ get; } = video;
  public string Comments{ get; } = comments;
  public string T1Name{ get; } = t1Name;
  public string T2Name{ get; } = t2Name;
  public string T3Name{ get; } = t3Name;
  public string T3SName1{ get; } = t3SName1;
  public string T3SName2{ get; } = t3SName2;
  public short? T3Score2{ get; } = t3Score2;
}
}
}
