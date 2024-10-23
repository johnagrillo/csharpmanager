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
/// [Ath_no] Long Integer,
/// [Last_name] Text (40),
/// [First_name] Text (40),
/// [Initial] Text (2),
/// [Ath_Sex] Text (2),
/// [Birth_date] DateTime,
/// [Team_no] Long Integer,
/// [Schl_yr] Text (4),
/// [Ath_age] Integer,
/// [Reg_no] Text (28),
/// [Ath_stat] Text (2),
/// [Div_no] Long Integer,
/// [Comp_no] Long Integer,
/// [Pref_name] Text (40),
/// [Home_addr1] Text (60),
/// [Home_addr2] Text (60),
/// [Home_city] Text (60),
/// [Home_prov] Text (60),
/// [Home_statenew] Text (6),
/// [Home_zip] Text (20),
/// [Home_cntry] Text (6),
/// [Home_daytele] Text (40),
/// [Home_evetele] Text (40),
/// [Home_faxtele] Text (40),
/// [Citizen_of] Text (6),
/// [Picture_bmp] Text (60),
/// [second_club] Text (32),
/// [home_email] Text (100),
/// [Home_celltele] Text (40),
/// [bcssa_type] Text (4),
/// [Home_emergcontact] Text (60),
/// [Home_emergtele] Text (40),
/// [Disab_Scode] Integer,
/// [Disab_SBcode] Integer,
/// [Disab_SMcode] Integer,
/// [Disab_SDMSID] Text (14),
/// [Disab_Exeptioncodes] Text (28),
/// [Masters_RegVerified] Boolean NOT NULL,
/// [PC_Hide] Boolean NOT NULL,
/// [Ath_Sex_BS] Text (2)
/// );

public class MmAthlete 
{
List<MmAthlete> get(OdbcConnection connection)
{
  var collection = new List<MmAthlete>();
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
      var arg0 = reader.GetInt64(1); /* Ath_no */
      var arg1 = reader.GetTextReader(2).ToString(); /* Last_name */
      var arg2 = reader.GetTextReader(3).ToString(); /* First_name */
      var arg3 = reader.GetTextReader(4).ToString(); /* Initial */
      var arg4 = reader.GetTextReader(5).ToString(); /* Ath_Sex */
      var arg5 = reader.GetDateTime(6); /* Birth_date */
      var arg6 = reader.GetInt64(7); /* Team_no */
      var arg7 = reader.GetTextReader(8).ToString(); /* Schl_yr */
      var arg8 = reader.GetInt16(9); /* Ath_age */
      var arg9 = reader.GetTextReader(10).ToString(); /* Reg_no */
      var arg10 = reader.GetTextReader(11).ToString(); /* Ath_stat */
      var arg11 = reader.GetInt64(12); /* Div_no */
      var arg12 = reader.GetInt64(13); /* Comp_no */
      var arg13 = reader.GetTextReader(14).ToString(); /* Pref_name */
      var arg14 = reader.GetTextReader(15).ToString(); /* Home_addr1 */
      var arg15 = reader.GetTextReader(16).ToString(); /* Home_addr2 */
      var arg16 = reader.GetTextReader(17).ToString(); /* Home_city */
      var arg17 = reader.GetTextReader(18).ToString(); /* Home_prov */
      var arg18 = reader.GetTextReader(19).ToString(); /* Home_statenew */
      var arg19 = reader.GetTextReader(20).ToString(); /* Home_zip */
      var arg20 = reader.GetTextReader(21).ToString(); /* Home_cntry */
      var arg21 = reader.GetTextReader(22).ToString(); /* Home_daytele */
      var arg22 = reader.GetTextReader(23).ToString(); /* Home_evetele */
      var arg23 = reader.GetTextReader(24).ToString(); /* Home_faxtele */
      var arg24 = reader.GetTextReader(25).ToString(); /* Citizen_of */
      var arg25 = reader.GetTextReader(26).ToString(); /* Picture_bmp */
      var arg26 = reader.GetTextReader(27).ToString(); /* second_club */
      var arg27 = reader.GetTextReader(28).ToString(); /* home_email */
      var arg28 = reader.GetTextReader(29).ToString(); /* Home_celltele */
      var arg29 = reader.GetTextReader(30).ToString(); /* bcssa_type */
      var arg30 = reader.GetTextReader(31).ToString(); /* Home_emergcontact */
      var arg31 = reader.GetTextReader(32).ToString(); /* Home_emergtele */
      var arg32 = reader.GetInt16(33); /* Disab_Scode */
      var arg33 = reader.GetInt16(34); /* Disab_SBcode */
      var arg34 = reader.GetInt16(35); /* Disab_SMcode */
      var arg35 = reader.GetTextReader(36).ToString(); /* Disab_SDMSID */
      var arg36 = reader.GetTextReader(37).ToString(); /* Disab_Exeptioncodes */
      var arg37 = reader.GetBoolean(38); /* Masters_RegVerified */
      var arg38 = reader.GetBoolean(39); /* PC_Hide */
      var arg39 = reader.GetTextReader(40).ToString(); /* Ath_Sex_BS */
      collection.Add( new MmAthlete(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39));
    }
  }
  return collection;
}
  // Properties
  public long AthNo{ get; }
  public string LastName{ get; }
  public string FirstName{ get; }
  public string Initial{ get; }
  public string AthSex{ get; }
  public DateTime BirthDate{ get; }
  public long TeamNo{ get; }
  public string SchlYr{ get; }
  public short AthAge{ get; }
  public string RegNo{ get; }
  public string AthStat{ get; }
  public long DivNo{ get; }
  public long CompNo{ get; }
  public string PrefName{ get; }
  public string HomeAddr1{ get; }
  public string HomeAddr2{ get; }
  public string HomeCity{ get; }
  public string HomeProv{ get; }
  public string HomeStatenew{ get; }
  public string HomeZip{ get; }
  public string HomeCntry{ get; }
  public string HomeDaytele{ get; }
  public string HomeEvetele{ get; }
  public string HomeFaxtele{ get; }
  public string CitizenOf{ get; }
  public string PictureBmp{ get; }
  public string Second_club{ get; }
  public string Home_email{ get; }
  public string HomeCelltele{ get; }
  public string Bcssa_type{ get; }
  public string HomeEmergcontact{ get; }
  public string HomeEmergtele{ get; }
  public short DisabScode{ get; }
  public short DisabSBcode{ get; }
  public short DisabSMcode{ get; }
  public string DisabSDMSID{ get; }
  public string DisabExeptioncodes{ get; }
  public bool MastersRegVerified{ get; }
  public bool PCHide{ get; }
  public string AthSexBS{ get; }
  // Constructor
  MmAthlete(long athNo, string lastName, string firstName, string initial, string athSex, DateTime birthDate, long teamNo, string schlYr, short athAge, string regNo, string athStat, long divNo, long compNo, string prefName, string homeAddr1, string homeAddr2, string homeCity, string homeProv, string homeStatenew, string homeZip, string homeCntry, string homeDaytele, string homeEvetele, string homeFaxtele, string citizenOf, string pictureBmp, string second_club, string home_email, string homeCelltele, string bcssa_type, string homeEmergcontact, string homeEmergtele, short disabScode, short disabSBcode, short disabSMcode, string disabSDMSID, string disabExeptioncodes, bool mastersRegVerified, bool pCHide, string athSexBS )
  {
    AthNo = athNo;
    LastName = lastName;
    FirstName = firstName;
    Initial = initial;
    AthSex = athSex;
    BirthDate = birthDate;
    TeamNo = teamNo;
    SchlYr = schlYr;
    AthAge = athAge;
    RegNo = regNo;
    AthStat = athStat;
    DivNo = divNo;
    CompNo = compNo;
    PrefName = prefName;
    HomeAddr1 = homeAddr1;
    HomeAddr2 = homeAddr2;
    HomeCity = homeCity;
    HomeProv = homeProv;
    HomeStatenew = homeStatenew;
    HomeZip = homeZip;
    HomeCntry = homeCntry;
    HomeDaytele = homeDaytele;
    HomeEvetele = homeEvetele;
    HomeFaxtele = homeFaxtele;
    CitizenOf = citizenOf;
    PictureBmp = pictureBmp;
    Second_club = second_club;
    Home_email = home_email;
    HomeCelltele = homeCelltele;
    Bcssa_type = bcssa_type;
    HomeEmergcontact = homeEmergcontact;
    HomeEmergtele = homeEmergtele;
    DisabScode = disabScode;
    DisabSBcode = disabSBcode;
    DisabSMcode = disabSMcode;
    DisabSDMSID = disabSDMSID;
    DisabExeptioncodes = disabExeptioncodes;
    MastersRegVerified = mastersRegVerified;
    PCHide = pCHide;
    AthSexBS = athSexBS;
  }
}
