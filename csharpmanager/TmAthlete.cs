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
/// CREATE TABLE [Athlete]
/// (
/// [Athlete] Long Integer,
/// [Team1] Long Integer,
/// [Team2] Long Integer,
/// [Team3] Long Integer,
/// [Group] Text (6),
/// [SubGr] Text (6),
/// [Last] Text (40),
/// [First] Text (40),
/// [Initial] Text (2),
/// [Sex] Text (2),
/// [Birth] DateTime,
/// [Age] Integer,
/// [Class] Text (6),
/// [ID_NO] Text (34),
/// [Citizen] Text (6),
/// [Inactive] Boolean NOT NULL,
/// [Pref] Text (40),
/// [Batch] Integer,
/// [WMGroup] Text (6),
/// [WMSubGr] Text (6),
/// [BCSSASwimmer] Text (4),
/// [BCSSADiver] Text (4),
/// [BCSSASyncro] Text (4),
/// [BCSSAPolo] Text (4),
/// [TheSort] Long Integer,
/// [DiveCertified] Boolean NOT NULL,
/// [DateClubJoined] DateTime,
/// [DateGroupJoined] DateTime,
/// [AWRegType] Text (2),
/// [RegYear] Integer,
/// [Foreign] Boolean NOT NULL,
/// [ForeignCitizenOf] Text (6),
/// [LastUpdated] DateTime,
/// [PC_Hide] Boolean NOT NULL
/// );

public class TmAthlete 
{
Dictionary<long,TmAthlete> get(OdbcConnection connection)
{
  var collection = new Dictionary<long,TmAthlete>();
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
      var arg0 = reader.GetInt64(1); /* Athlete */
      var arg1 = reader.GetInt64(2); /* Team1 */
      var arg2 = reader.GetInt64(3); /* Team2 */
      var arg3 = reader.GetInt64(4); /* Team3 */
      var arg4 = reader.GetTextReader(5).ToString(); /* Group */
      var arg5 = reader.GetTextReader(6).ToString(); /* SubGr */
      var arg6 = reader.GetTextReader(7).ToString(); /* Last */
      var arg7 = reader.GetTextReader(8).ToString(); /* First */
      var arg8 = reader.GetTextReader(9).ToString(); /* Initial */
      var arg9 = reader.GetTextReader(10).ToString(); /* Sex */
      var arg10 = reader.GetDateTime(11); /* Birth */
      var arg11 = reader.GetInt16(12); /* Age */
      var arg12 = reader.GetTextReader(13).ToString(); /* Class */
      var arg13 = reader.GetTextReader(14).ToString(); /* ID_NO */
      var arg14 = reader.GetTextReader(15).ToString(); /* Citizen */
      var arg15 = reader.GetBoolean(16); /* Inactive */
      var arg16 = reader.GetTextReader(17).ToString(); /* Pref */
      var arg17 = reader.GetInt16(18); /* Batch */
      var arg18 = reader.GetTextReader(19).ToString(); /* WMGroup */
      var arg19 = reader.GetTextReader(20).ToString(); /* WMSubGr */
      var arg20 = reader.GetTextReader(21).ToString(); /* BCSSASwimmer */
      var arg21 = reader.GetTextReader(22).ToString(); /* BCSSADiver */
      var arg22 = reader.GetTextReader(23).ToString(); /* BCSSASyncro */
      var arg23 = reader.GetTextReader(24).ToString(); /* BCSSAPolo */
      var arg24 = reader.GetInt64(25); /* TheSort */
      var arg25 = reader.GetBoolean(26); /* DiveCertified */
      var arg26 = reader.GetDateTime(27); /* DateClubJoined */
      var arg27 = reader.GetDateTime(28); /* DateGroupJoined */
      var arg28 = reader.GetTextReader(29).ToString(); /* AWRegType */
      var arg29 = reader.GetInt16(30); /* RegYear */
      var arg30 = reader.GetBoolean(31); /* Foreign */
      var arg31 = reader.GetTextReader(32).ToString(); /* ForeignCitizenOf */
      var arg32 = reader.GetDateTime(33); /* LastUpdated */
      var arg33 = reader.GetBoolean(34); /* PC_Hide */
      var obj = new TmAthlete(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33);
      collection[obj.Athlete] = obj;
    }
  }
  return collection;
}
  // Properties
  public long Athlete{ get; }
  public long Team1{ get; }
  public long Team2{ get; }
  public long Team3{ get; }
  public string Group{ get; }
  public string SubGr{ get; }
  public string Last{ get; }
  public string First{ get; }
  public string Initial{ get; }
  public string Sex{ get; }
  public DateTime Birth{ get; }
  public short Age{ get; }
  public string Cclass{ get; }
  public string Id_no{ get; }
  public string Citizen{ get; }
  public bool Inactive{ get; }
  public string Pref{ get; }
  public short Batch{ get; }
  public string WMGroup{ get; }
  public string WMSubGr{ get; }
  public string BCSSASwimmer{ get; }
  public string BCSSADiver{ get; }
  public string BCSSASyncro{ get; }
  public string BCSSAPolo{ get; }
  public long TheSort{ get; }
  public bool DiveCertified{ get; }
  public DateTime DateClubJoined{ get; }
  public DateTime DateGroupJoined{ get; }
  public string AWRegType{ get; }
  public short RegYear{ get; }
  public bool Foreign{ get; }
  public string ForeignCitizenOf{ get; }
  public DateTime LastUpdated{ get; }
  public bool PCHide{ get; }
  // Constructor
  TmAthlete(long athlete, long team1, long team2, long team3, string group, string subGr, string last, string first, string initial, string sex, DateTime birth, short age, string cclass, string id_no, string citizen, bool inactive, string pref, short batch, string wMGroup, string wMSubGr, string bCSSASwimmer, string bCSSADiver, string bCSSASyncro, string bCSSAPolo, long theSort, bool diveCertified, DateTime dateClubJoined, DateTime dateGroupJoined, string aWRegType, short regYear, bool foreign, string foreignCitizenOf, DateTime lastUpdated, bool pCHide )
  {
    Athlete = athlete;
    Team1 = team1;
    Team2 = team2;
    Team3 = team3;
    Group = group;
    SubGr = subGr;
    Last = last;
    First = first;
    Initial = initial;
    Sex = sex;
    Birth = birth;
    Age = age;
    Cclass = cclass;
    Id_no = id_no;
    Citizen = citizen;
    Inactive = inactive;
    Pref = pref;
    Batch = batch;
    WMGroup = wMGroup;
    WMSubGr = wMSubGr;
    BCSSASwimmer = bCSSASwimmer;
    BCSSADiver = bCSSADiver;
    BCSSASyncro = bCSSASyncro;
    BCSSAPolo = bCSSAPolo;
    TheSort = theSort;
    DiveCertified = diveCertified;
    DateClubJoined = dateClubJoined;
    DateGroupJoined = dateGroupJoined;
    AWRegType = aWRegType;
    RegYear = regYear;
    Foreign = foreign;
    ForeignCitizenOf = foreignCitizenOf;
    LastUpdated = lastUpdated;
    PCHide = pCHide;
  }
}
