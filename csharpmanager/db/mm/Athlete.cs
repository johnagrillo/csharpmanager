using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Athlete]
/// // (
/// // [Ath_no] Long Integer,
/// // [Last_name] Text (40),
/// // [First_name] Text (40),
/// // [Initial] Text (2),
/// // [Ath_Sex] Text (2),
/// // [Birth_date] DateTime,
/// // [Team_no] Long Integer,
/// // [Schl_yr] Text (4),
/// // [Ath_age] Integer,
/// // [Reg_no] Text (28),
/// // [Ath_stat] Text (2),
/// // [Div_no] Long Integer,
/// // [Comp_no] Long Integer,
/// // [Pref_name] Text (40),
/// // [Home_addr1] Text (60),
/// // [Home_addr2] Text (60),
/// // [Home_city] Text (60),
/// // [Home_prov] Text (60),
/// // [Home_statenew] Text (6),
/// // [Home_zip] Text (20),
/// // [Home_cntry] Text (6),
/// // [Home_daytele] Text (40),
/// // [Home_evetele] Text (40),
/// // [Home_faxtele] Text (40),
/// // [Citizen_of] Text (6),
/// // [Picture_bmp] Text (60),
/// // [second_club] Text (32),
/// // [home_email] Text (100),
/// // [Home_celltele] Text (40),
/// // [bcssa_type] Text (4),
/// // [Home_emergcontact] Text (60),
/// // [Home_emergtele] Text (40),
/// // [Disab_Scode] Integer,
/// // [Disab_SBcode] Integer,
/// // [Disab_SMcode] Integer,
/// // [Disab_SDMSID] Text (14),
/// // [Disab_Exeptioncodes] Text (28),
/// // [Masters_RegVerified] Boolean NOT NULL,
/// // [PC_Hide] Boolean NOT NULL,
/// // [Ath_Sex_BS] Text (2)
/// // );

public class Athlete(long? athNo, string lastName, string firstName, string initial, string athSex, DateTime? birthDate, long? teamNo, string schlYr, short? athAge, string regNo, string athStat, long? divNo, long? compNo, string prefName, string homeAddr1, string homeAddr2, string homeCity, string homeProv, string homeStatenew, string homeZip, string homeCntry, string homeDaytele, string homeEvetele, string homeFaxtele, string citizenOf, string pictureBmp, string second_club, string home_email, string homeCelltele, string bcssa_type, string homeEmergcontact, string homeEmergtele, short? disabScode, short? disabSBcode, short? disabSMcode, string disabSDMSID, string disabExeptioncodes, bool mastersRegVerified, bool pCHide, string athSexBS )
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Ath_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Last_name nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* First_name nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Initial nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Ath_Sex nullable false*/
  var arg5 = reader.IsDBNull(5) ? (DateTime?)null :reader.GetDateTime(5); /* Birth_date nullable true*/
  var arg6 = reader.IsDBNull(6) ? (long?)null :reader.GetInt32(6); /* Team_no nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* Schl_yr nullable false*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* Ath_age nullable true*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* Reg_no nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* Ath_stat nullable false*/
  var arg11 = reader.IsDBNull(11) ? (long?)null :reader.GetInt32(11); /* Div_no nullable true*/
  var arg12 = reader.IsDBNull(12) ? (long?)null :reader.GetInt32(12); /* Comp_no nullable true*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Pref_name nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Home_addr1 nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Home_addr2 nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Home_city nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* Home_prov nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* Home_statenew nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* Home_zip nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* Home_cntry nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* Home_daytele nullable false*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* Home_evetele nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* Home_faxtele nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* Citizen_of nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* Picture_bmp nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* second_club nullable false*/
  var arg27 = reader.GetTextReader(27).ReadLine(); /* home_email nullable false*/
  var arg28 = reader.GetTextReader(28).ReadLine(); /* Home_celltele nullable false*/
  var arg29 = reader.GetTextReader(29).ReadLine(); /* bcssa_type nullable false*/
  var arg30 = reader.GetTextReader(30).ReadLine(); /* Home_emergcontact nullable false*/
  var arg31 = reader.GetTextReader(31).ReadLine(); /* Home_emergtele nullable false*/
  var arg32 = reader.IsDBNull(32) ? (short?)null :reader.GetInt16(32); /* Disab_Scode nullable true*/
  var arg33 = reader.IsDBNull(33) ? (short?)null :reader.GetInt16(33); /* Disab_SBcode nullable true*/
  var arg34 = reader.IsDBNull(34) ? (short?)null :reader.GetInt16(34); /* Disab_SMcode nullable true*/
  var arg35 = reader.GetTextReader(35).ReadLine(); /* Disab_SDMSID nullable false*/
  var arg36 = reader.GetTextReader(36).ReadLine(); /* Disab_Exeptioncodes nullable false*/
  var arg37 = reader.GetBoolean(37); /* Masters_RegVerified nullable false*/
  var arg38 = reader.GetBoolean(38); /* PC_Hide nullable false*/
  var arg39 = reader.GetTextReader(39).ReadLine(); /* Ath_Sex_BS nullable false*/
      collection.Add( new Athlete(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39));
    }
  }
  return collection;
}
  // Properties
  public long? AthNo{ get; } = athNo;
  public string LastName{ get; } = lastName;
  public string FirstName{ get; } = firstName;
  public string Initial{ get; } = initial;
  public string AthSex{ get; } = athSex;
  public DateTime? BirthDate{ get; } = birthDate;
  public long? TeamNo{ get; } = teamNo;
  public string SchlYr{ get; } = schlYr;
  public short? AthAge{ get; } = athAge;
  public string RegNo{ get; } = regNo;
  public string AthStat{ get; } = athStat;
  public long? DivNo{ get; } = divNo;
  public long? CompNo{ get; } = compNo;
  public string PrefName{ get; } = prefName;
  public string HomeAddr1{ get; } = homeAddr1;
  public string HomeAddr2{ get; } = homeAddr2;
  public string HomeCity{ get; } = homeCity;
  public string HomeProv{ get; } = homeProv;
  public string HomeStatenew{ get; } = homeStatenew;
  public string HomeZip{ get; } = homeZip;
  public string HomeCntry{ get; } = homeCntry;
  public string HomeDaytele{ get; } = homeDaytele;
  public string HomeEvetele{ get; } = homeEvetele;
  public string HomeFaxtele{ get; } = homeFaxtele;
  public string CitizenOf{ get; } = citizenOf;
  public string PictureBmp{ get; } = pictureBmp;
  public string Second_club{ get; } = second_club;
  public string Home_email{ get; } = home_email;
  public string HomeCelltele{ get; } = homeCelltele;
  public string Bcssa_type{ get; } = bcssa_type;
  public string HomeEmergcontact{ get; } = homeEmergcontact;
  public string HomeEmergtele{ get; } = homeEmergtele;
  public short? DisabScode{ get; } = disabScode;
  public short? DisabSBcode{ get; } = disabSBcode;
  public short? DisabSMcode{ get; } = disabSMcode;
  public string DisabSDMSID{ get; } = disabSDMSID;
  public string DisabExeptioncodes{ get; } = disabExeptioncodes;
  public bool MastersRegVerified{ get; } = mastersRegVerified;
  public bool PCHide{ get; } = pCHide;
  public string AthSexBS{ get; } = athSexBS;
}
}
}
