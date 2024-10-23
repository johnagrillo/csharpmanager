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
/// CREATE TABLE [ATHRECR]
/// (
/// [Athlete] Long Integer,
/// [Grad] Integer,
/// [PicFile] Text (22),
/// [HS_Name] Text (60),
/// [HS_Phone] Text (40),
/// [HS_Addr] Text (60),
/// [HS_City] Text (40),
/// [HS_State] Text (6),
/// [HS_ZIP] Text (20),
/// [HS_Coach] Text (60),
/// [Oth_Team] Text (60),
/// [Oth_Coach] Text (60),
/// [HS_Study] Text (40),
/// [HS_Rank] Integer,
/// [HS_Num] Integer,
/// [HS_GPA] Single,
/// [Activities] Text (100),
/// [Awards] Text (40),
/// [Add_Info] Text (100),
/// [Camps] Text (100),
/// [T1Score] Integer,
/// [Remarks] Text (100),
/// [T3Score1] Integer,
/// [T2Score] Integer,
/// [Height] Integer,
/// [Weight] Integer,
/// [Oth_Phone] Text (40),
/// [Picture] Text (120),
/// [Video] Boolean NOT NULL,
/// [Comments] Text (510),
/// [T1Name] Text (16),
/// [T2Name] Text (16),
/// [T3Name] Text (16),
/// [T3SName1] Text (16),
/// [T3SName2] Text (16),
/// [T3Score2] Integer
/// );

public class TmAthrecr 
{
List<TmAthrecr> get(OdbcConnection connection)
{
  var collection = new List<TmAthrecr>();
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
      var arg0 = reader.GetInt64(1); /* Athlete */
      var arg1 = reader.GetInt16(2); /* Grad */
      var arg2 = reader.GetTextReader(3).ToString(); /* PicFile */
      var arg3 = reader.GetTextReader(4).ToString(); /* HS_Name */
      var arg4 = reader.GetTextReader(5).ToString(); /* HS_Phone */
      var arg5 = reader.GetTextReader(6).ToString(); /* HS_Addr */
      var arg6 = reader.GetTextReader(7).ToString(); /* HS_City */
      var arg7 = reader.GetTextReader(8).ToString(); /* HS_State */
      var arg8 = reader.GetTextReader(9).ToString(); /* HS_ZIP */
      var arg9 = reader.GetTextReader(10).ToString(); /* HS_Coach */
      var arg10 = reader.GetTextReader(11).ToString(); /* Oth_Team */
      var arg11 = reader.GetTextReader(12).ToString(); /* Oth_Coach */
      var arg12 = reader.GetTextReader(13).ToString(); /* HS_Study */
      var arg13 = reader.GetInt16(14); /* HS_Rank */
      var arg14 = reader.GetInt16(15); /* HS_Num */
      var arg15 = reader.GetFloat(16); /* HS_GPA */
      var arg16 = reader.GetTextReader(17).ToString(); /* Activities */
      var arg17 = reader.GetTextReader(18).ToString(); /* Awards */
      var arg18 = reader.GetTextReader(19).ToString(); /* Add_Info */
      var arg19 = reader.GetTextReader(20).ToString(); /* Camps */
      var arg20 = reader.GetInt16(21); /* T1Score */
      var arg21 = reader.GetTextReader(22).ToString(); /* Remarks */
      var arg22 = reader.GetInt16(23); /* T3Score1 */
      var arg23 = reader.GetInt16(24); /* T2Score */
      var arg24 = reader.GetInt16(25); /* Height */
      var arg25 = reader.GetInt16(26); /* Weight */
      var arg26 = reader.GetTextReader(27).ToString(); /* Oth_Phone */
      var arg27 = reader.GetTextReader(28).ToString(); /* Picture */
      var arg28 = reader.GetBoolean(29); /* Video */
      var arg29 = reader.GetTextReader(30).ToString(); /* Comments */
      var arg30 = reader.GetTextReader(31).ToString(); /* T1Name */
      var arg31 = reader.GetTextReader(32).ToString(); /* T2Name */
      var arg32 = reader.GetTextReader(33).ToString(); /* T3Name */
      var arg33 = reader.GetTextReader(34).ToString(); /* T3SName1 */
      var arg34 = reader.GetTextReader(35).ToString(); /* T3SName2 */
      var arg35 = reader.GetInt16(36); /* T3Score2 */
      collection.Add( new TmAthrecr(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35));
    }
  }
  return collection;
}
  // Properties
  public long Athlete{ get; }
  public short Grad{ get; }
  public string PicFile{ get; }
  public string HSName{ get; }
  public string HSPhone{ get; }
  public string HSAddr{ get; }
  public string HSCity{ get; }
  public string HSState{ get; }
  public string Hs_zip{ get; }
  public string HSCoach{ get; }
  public string OthTeam{ get; }
  public string OthCoach{ get; }
  public string HSStudy{ get; }
  public short HSRank{ get; }
  public short HSNum{ get; }
  public float Hs_gpa{ get; }
  public string Activities{ get; }
  public string Awards{ get; }
  public string AddInfo{ get; }
  public string Camps{ get; }
  public short T1Score{ get; }
  public string Remarks{ get; }
  public short T3Score1{ get; }
  public short T2Score{ get; }
  public short Height{ get; }
  public short Weight{ get; }
  public string OthPhone{ get; }
  public string Picture{ get; }
  public bool Video{ get; }
  public string Comments{ get; }
  public string T1Name{ get; }
  public string T2Name{ get; }
  public string T3Name{ get; }
  public string T3SName1{ get; }
  public string T3SName2{ get; }
  public short T3Score2{ get; }
  // Constructor
  TmAthrecr(long athlete, short grad, string picFile, string hSName, string hSPhone, string hSAddr, string hSCity, string hSState, string hs_zip, string hSCoach, string othTeam, string othCoach, string hSStudy, short hSRank, short hSNum, float hs_gpa, string activities, string awards, string addInfo, string camps, short t1Score, string remarks, short t3Score1, short t2Score, short height, short weight, string othPhone, string picture, bool video, string comments, string t1Name, string t2Name, string t3Name, string t3SName1, string t3SName2, short t3Score2 )
  {
    Athlete = athlete;
    Grad = grad;
    PicFile = picFile;
    HSName = hSName;
    HSPhone = hSPhone;
    HSAddr = hSAddr;
    HSCity = hSCity;
    HSState = hSState;
    Hs_zip = hs_zip;
    HSCoach = hSCoach;
    OthTeam = othTeam;
    OthCoach = othCoach;
    HSStudy = hSStudy;
    HSRank = hSRank;
    HSNum = hSNum;
    Hs_gpa = hs_gpa;
    Activities = activities;
    Awards = awards;
    AddInfo = addInfo;
    Camps = camps;
    T1Score = t1Score;
    Remarks = remarks;
    T3Score1 = t3Score1;
    T2Score = t2Score;
    Height = height;
    Weight = weight;
    OthPhone = othPhone;
    Picture = picture;
    Video = video;
    Comments = comments;
    T1Name = t1Name;
    T2Name = t2Name;
    T3Name = t3Name;
    T3SName1 = t3SName1;
    T3SName2 = t3SName2;
    T3Score2 = t3Score2;
  }
}
