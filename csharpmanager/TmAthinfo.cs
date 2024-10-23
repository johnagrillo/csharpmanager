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
/// CREATE TABLE [AthInfo]
/// (
/// [Athlete] Long Integer,
/// [Addr] Text (60),
/// [City] Text (60),
/// [ZIP] Text (20),
/// [Cntry] Text (40),
/// [DayP1] Text (40),
/// [EveP1] Text (40),
/// [FaxP1] Text (40),
/// [DayP2] Text (40),
/// [EveP2] Text (40),
/// [FaxP2] Text (40),
/// [MailTo] Text (80),
/// [Seasonal] Text (2),
/// [FinaFed] Boolean NOT NULL,
/// [RegDate] DateTime,
/// [NRCD] Text (2),
/// [EMail] Text (100),
/// [Member] Boolean NOT NULL,
/// [JrHS] Boolean NOT NULL,
/// [HS] Boolean NOT NULL,
/// [YMCA] Boolean NOT NULL,
/// [Coll] Boolean NOT NULL,
/// [SL] Boolean NOT NULL,
/// [DUAL] Boolean NOT NULL,
/// [Mast] Boolean NOT NULL,
/// [Dis] Boolean NOT NULL,
/// [Polo] Boolean NOT NULL,
/// [Ethnic] Byte,
/// [MedCondition] Text (240),
/// [Medication] Text (240),
/// [DoctorName] Text (60),
/// [DoctorPhone] Text (40),
/// [EmerContact] Text (60),
/// [EmerPhone] Text (40),
/// [MailTo2] Text (80),
/// [Addr2] Text (60),
/// [City2] Text (60),
/// [State2] Text (6),
/// [ZIP2] Text (20),
/// [Cntry2] Text (40),
/// [EMail2] Text (100),
/// [UseMailTo] Boolean NOT NULL,
/// [CusPrompt1] Text (40),
/// [CusValue1] Text (40),
/// [CusPrompt2] Text (40),
/// [CusValue2] Text (40),
/// [CusPrompt3] Text (40),
/// [CusValue3] Text (40),
/// [State] Text (6),
/// [BLIND] Boolean NOT NULL,
/// [DEAF] Boolean NOT NULL,
/// [PHYSICAL] Boolean NOT NULL,
/// [COGNITIVE] Boolean NOT NULL,
/// [SecAddr] Text (60),
/// [SecAddr2] Text (60),
/// [PrimaryLast] Text (40),
/// [PrimaryFirst1] Text (40),
/// [PrimaryFirst2] Text (40),
/// [SecondaryLast] Text (40),
/// [SecondaryFirst1] Text (40),
/// [SecondaryFirst2] Text (40),
/// [CellP1] Text (40),
/// [CellP2] Text (40),
/// [UseBoth] Boolean NOT NULL,
/// [EveP1P2] Text (40),
/// [CellP1P2] Text (40),
/// [EMail1P2] Text (100),
/// [EveP2P2] Text (40),
/// [CellP2P2] Text (40),
/// [EMail2P2] Text (100),
/// [CellAthlete] Text (40),
/// [EMailAthlete] Text (100),
/// [Middle] Text (40),
/// [USSDonation] Boolean NOT NULL,
/// [PrimaryLast2] Text (40),
/// [FinaFedCntry] Text (6),
/// [ExpAthEmail] Boolean NOT NULL,
/// [ExpFatherEmail] Boolean NOT NULL,
/// [ExpMotherEmail] Boolean NOT NULL,
/// [ExpParent1Email] Boolean NOT NULL,
/// [ExpParent2Email] Boolean NOT NULL,
/// [RegEMail] Text (100),
/// [USSNewsLetter] Boolean NOT NULL,
/// [CusPrompt4] Text (40),
/// [CusValue4] Text (40),
/// [CusPrompt5] Text (40),
/// [CusValue5] Text (40),
/// [CusPrompt6] Text (40),
/// [CusValue6] Text (40),
/// [CusPrompt7] Text (40),
/// [CusValue7] Text (40),
/// [CusPrompt8] Text (40),
/// [CusValue8] Text (40),
/// [HSGradYear] Integer,
/// [FINACompeted] Boolean NOT NULL,
/// [CustUSSFee] Text (20)
/// );

public class TmAthinfo 
{
List<TmAthinfo> get(OdbcConnection connection)
{
  var collection = new List<TmAthinfo>();
  string query = "select * from AthInfo";
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
      var arg1 = reader.GetTextReader(2).ToString(); /* Addr */
      var arg2 = reader.GetTextReader(3).ToString(); /* City */
      var arg3 = reader.GetTextReader(4).ToString(); /* ZIP */
      var arg4 = reader.GetTextReader(5).ToString(); /* Cntry */
      var arg5 = reader.GetTextReader(6).ToString(); /* DayP1 */
      var arg6 = reader.GetTextReader(7).ToString(); /* EveP1 */
      var arg7 = reader.GetTextReader(8).ToString(); /* FaxP1 */
      var arg8 = reader.GetTextReader(9).ToString(); /* DayP2 */
      var arg9 = reader.GetTextReader(10).ToString(); /* EveP2 */
      var arg10 = reader.GetTextReader(11).ToString(); /* FaxP2 */
      var arg11 = reader.GetTextReader(12).ToString(); /* MailTo */
      var arg12 = reader.GetTextReader(13).ToString(); /* Seasonal */
      var arg13 = reader.GetBoolean(14); /* FinaFed */
      var arg14 = reader.GetDateTime(15); /* RegDate */
      var arg15 = reader.GetTextReader(16).ToString(); /* NRCD */
      var arg16 = reader.GetTextReader(17).ToString(); /* EMail */
      var arg17 = reader.GetBoolean(18); /* Member */
      var arg18 = reader.GetBoolean(19); /* JrHS */
      var arg19 = reader.GetBoolean(20); /* HS */
      var arg20 = reader.GetBoolean(21); /* YMCA */
      var arg21 = reader.GetBoolean(22); /* Coll */
      var arg22 = reader.GetBoolean(23); /* SL */
      var arg23 = reader.GetBoolean(24); /* DUAL */
      var arg24 = reader.GetBoolean(25); /* Mast */
      var arg25 = reader.GetBoolean(26); /* Dis */
      var arg26 = reader.GetBoolean(27); /* Polo */
      var arg27 = reader.GetByte(28); /* Ethnic */
      var arg28 = reader.GetTextReader(29).ToString(); /* MedCondition */
      var arg29 = reader.GetTextReader(30).ToString(); /* Medication */
      var arg30 = reader.GetTextReader(31).ToString(); /* DoctorName */
      var arg31 = reader.GetTextReader(32).ToString(); /* DoctorPhone */
      var arg32 = reader.GetTextReader(33).ToString(); /* EmerContact */
      var arg33 = reader.GetTextReader(34).ToString(); /* EmerPhone */
      var arg34 = reader.GetTextReader(35).ToString(); /* MailTo2 */
      var arg35 = reader.GetTextReader(36).ToString(); /* Addr2 */
      var arg36 = reader.GetTextReader(37).ToString(); /* City2 */
      var arg37 = reader.GetTextReader(38).ToString(); /* State2 */
      var arg38 = reader.GetTextReader(39).ToString(); /* ZIP2 */
      var arg39 = reader.GetTextReader(40).ToString(); /* Cntry2 */
      var arg40 = reader.GetTextReader(41).ToString(); /* EMail2 */
      var arg41 = reader.GetBoolean(42); /* UseMailTo */
      var arg42 = reader.GetTextReader(43).ToString(); /* CusPrompt1 */
      var arg43 = reader.GetTextReader(44).ToString(); /* CusValue1 */
      var arg44 = reader.GetTextReader(45).ToString(); /* CusPrompt2 */
      var arg45 = reader.GetTextReader(46).ToString(); /* CusValue2 */
      var arg46 = reader.GetTextReader(47).ToString(); /* CusPrompt3 */
      var arg47 = reader.GetTextReader(48).ToString(); /* CusValue3 */
      var arg48 = reader.GetTextReader(49).ToString(); /* State */
      var arg49 = reader.GetBoolean(50); /* BLIND */
      var arg50 = reader.GetBoolean(51); /* DEAF */
      var arg51 = reader.GetBoolean(52); /* PHYSICAL */
      var arg52 = reader.GetBoolean(53); /* COGNITIVE */
      var arg53 = reader.GetTextReader(54).ToString(); /* SecAddr */
      var arg54 = reader.GetTextReader(55).ToString(); /* SecAddr2 */
      var arg55 = reader.GetTextReader(56).ToString(); /* PrimaryLast */
      var arg56 = reader.GetTextReader(57).ToString(); /* PrimaryFirst1 */
      var arg57 = reader.GetTextReader(58).ToString(); /* PrimaryFirst2 */
      var arg58 = reader.GetTextReader(59).ToString(); /* SecondaryLast */
      var arg59 = reader.GetTextReader(60).ToString(); /* SecondaryFirst1 */
      var arg60 = reader.GetTextReader(61).ToString(); /* SecondaryFirst2 */
      var arg61 = reader.GetTextReader(62).ToString(); /* CellP1 */
      var arg62 = reader.GetTextReader(63).ToString(); /* CellP2 */
      var arg63 = reader.GetBoolean(64); /* UseBoth */
      var arg64 = reader.GetTextReader(65).ToString(); /* EveP1P2 */
      var arg65 = reader.GetTextReader(66).ToString(); /* CellP1P2 */
      var arg66 = reader.GetTextReader(67).ToString(); /* EMail1P2 */
      var arg67 = reader.GetTextReader(68).ToString(); /* EveP2P2 */
      var arg68 = reader.GetTextReader(69).ToString(); /* CellP2P2 */
      var arg69 = reader.GetTextReader(70).ToString(); /* EMail2P2 */
      var arg70 = reader.GetTextReader(71).ToString(); /* CellAthlete */
      var arg71 = reader.GetTextReader(72).ToString(); /* EMailAthlete */
      var arg72 = reader.GetTextReader(73).ToString(); /* Middle */
      var arg73 = reader.GetBoolean(74); /* USSDonation */
      var arg74 = reader.GetTextReader(75).ToString(); /* PrimaryLast2 */
      var arg75 = reader.GetTextReader(76).ToString(); /* FinaFedCntry */
      var arg76 = reader.GetBoolean(77); /* ExpAthEmail */
      var arg77 = reader.GetBoolean(78); /* ExpFatherEmail */
      var arg78 = reader.GetBoolean(79); /* ExpMotherEmail */
      var arg79 = reader.GetBoolean(80); /* ExpParent1Email */
      var arg80 = reader.GetBoolean(81); /* ExpParent2Email */
      var arg81 = reader.GetTextReader(82).ToString(); /* RegEMail */
      var arg82 = reader.GetBoolean(83); /* USSNewsLetter */
      var arg83 = reader.GetTextReader(84).ToString(); /* CusPrompt4 */
      var arg84 = reader.GetTextReader(85).ToString(); /* CusValue4 */
      var arg85 = reader.GetTextReader(86).ToString(); /* CusPrompt5 */
      var arg86 = reader.GetTextReader(87).ToString(); /* CusValue5 */
      var arg87 = reader.GetTextReader(88).ToString(); /* CusPrompt6 */
      var arg88 = reader.GetTextReader(89).ToString(); /* CusValue6 */
      var arg89 = reader.GetTextReader(90).ToString(); /* CusPrompt7 */
      var arg90 = reader.GetTextReader(91).ToString(); /* CusValue7 */
      var arg91 = reader.GetTextReader(92).ToString(); /* CusPrompt8 */
      var arg92 = reader.GetTextReader(93).ToString(); /* CusValue8 */
      var arg93 = reader.GetInt16(94); /* HSGradYear */
      var arg94 = reader.GetBoolean(95); /* FINACompeted */
      var arg95 = reader.GetTextReader(96).ToString(); /* CustUSSFee */
      collection.Add( new TmAthinfo(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95));
    }
  }
  return collection;
}
  // Properties
  public long Athlete{ get; }
  public string Addr{ get; }
  public string City{ get; }
  public string Zip{ get; }
  public string Cntry{ get; }
  public string DayP1{ get; }
  public string EveP1{ get; }
  public string FaxP1{ get; }
  public string DayP2{ get; }
  public string EveP2{ get; }
  public string FaxP2{ get; }
  public string MailTo{ get; }
  public string Seasonal{ get; }
  public bool FinaFed{ get; }
  public DateTime RegDate{ get; }
  public string Nrcd{ get; }
  public string EMail{ get; }
  public bool Member{ get; }
  public bool JrHS{ get; }
  public bool Hs{ get; }
  public bool Ymca{ get; }
  public bool Coll{ get; }
  public bool Sl{ get; }
  public bool Dual{ get; }
  public bool Mast{ get; }
  public bool Dis{ get; }
  public bool Polo{ get; }
  public byte Ethnic{ get; }
  public string MedCondition{ get; }
  public string Medication{ get; }
  public string DoctorName{ get; }
  public string DoctorPhone{ get; }
  public string EmerContact{ get; }
  public string EmerPhone{ get; }
  public string MailTo2{ get; }
  public string Addr2{ get; }
  public string City2{ get; }
  public string State2{ get; }
  public string Zip2{ get; }
  public string Cntry2{ get; }
  public string EMail2{ get; }
  public bool UseMailTo{ get; }
  public string CusPrompt1{ get; }
  public string CusValue1{ get; }
  public string CusPrompt2{ get; }
  public string CusValue2{ get; }
  public string CusPrompt3{ get; }
  public string CusValue3{ get; }
  public string State{ get; }
  public bool Blind{ get; }
  public bool Deaf{ get; }
  public bool Physical{ get; }
  public bool Cognitive{ get; }
  public string SecAddr{ get; }
  public string SecAddr2{ get; }
  public string PrimaryLast{ get; }
  public string PrimaryFirst1{ get; }
  public string PrimaryFirst2{ get; }
  public string SecondaryLast{ get; }
  public string SecondaryFirst1{ get; }
  public string SecondaryFirst2{ get; }
  public string CellP1{ get; }
  public string CellP2{ get; }
  public bool UseBoth{ get; }
  public string EveP1P2{ get; }
  public string CellP1P2{ get; }
  public string EMail1P2{ get; }
  public string EveP2P2{ get; }
  public string CellP2P2{ get; }
  public string EMail2P2{ get; }
  public string CellAthlete{ get; }
  public string EMailAthlete{ get; }
  public string Middle{ get; }
  public bool USSDonation{ get; }
  public string PrimaryLast2{ get; }
  public string FinaFedCntry{ get; }
  public bool ExpAthEmail{ get; }
  public bool ExpFatherEmail{ get; }
  public bool ExpMotherEmail{ get; }
  public bool ExpParent1Email{ get; }
  public bool ExpParent2Email{ get; }
  public string RegEMail{ get; }
  public bool USSNewsLetter{ get; }
  public string CusPrompt4{ get; }
  public string CusValue4{ get; }
  public string CusPrompt5{ get; }
  public string CusValue5{ get; }
  public string CusPrompt6{ get; }
  public string CusValue6{ get; }
  public string CusPrompt7{ get; }
  public string CusValue7{ get; }
  public string CusPrompt8{ get; }
  public string CusValue8{ get; }
  public short HSGradYear{ get; }
  public bool FINACompeted{ get; }
  public string CustUSSFee{ get; }
  // Constructor
  TmAthinfo(long athlete, string addr, string city, string zip, string cntry, string dayP1, string eveP1, string faxP1, string dayP2, string eveP2, string faxP2, string mailTo, string seasonal, bool finaFed, DateTime regDate, string nrcd, string eMail, bool member, bool jrHS, bool hs, bool ymca, bool coll, bool sl, bool dual, bool mast, bool dis, bool polo, byte ethnic, string medCondition, string medication, string doctorName, string doctorPhone, string emerContact, string emerPhone, string mailTo2, string addr2, string city2, string state2, string zip2, string cntry2, string eMail2, bool useMailTo, string cusPrompt1, string cusValue1, string cusPrompt2, string cusValue2, string cusPrompt3, string cusValue3, string state, bool blind, bool deaf, bool physical, bool cognitive, string secAddr, string secAddr2, string primaryLast, string primaryFirst1, string primaryFirst2, string secondaryLast, string secondaryFirst1, string secondaryFirst2, string cellP1, string cellP2, bool useBoth, string eveP1P2, string cellP1P2, string eMail1P2, string eveP2P2, string cellP2P2, string eMail2P2, string cellAthlete, string eMailAthlete, string middle, bool uSSDonation, string primaryLast2, string finaFedCntry, bool expAthEmail, bool expFatherEmail, bool expMotherEmail, bool expParent1Email, bool expParent2Email, string regEMail, bool uSSNewsLetter, string cusPrompt4, string cusValue4, string cusPrompt5, string cusValue5, string cusPrompt6, string cusValue6, string cusPrompt7, string cusValue7, string cusPrompt8, string cusValue8, short hSGradYear, bool fINACompeted, string custUSSFee )
  {
    Athlete = athlete;
    Addr = addr;
    City = city;
    Zip = zip;
    Cntry = cntry;
    DayP1 = dayP1;
    EveP1 = eveP1;
    FaxP1 = faxP1;
    DayP2 = dayP2;
    EveP2 = eveP2;
    FaxP2 = faxP2;
    MailTo = mailTo;
    Seasonal = seasonal;
    FinaFed = finaFed;
    RegDate = regDate;
    Nrcd = nrcd;
    EMail = eMail;
    Member = member;
    JrHS = jrHS;
    Hs = hs;
    Ymca = ymca;
    Coll = coll;
    Sl = sl;
    Dual = dual;
    Mast = mast;
    Dis = dis;
    Polo = polo;
    Ethnic = ethnic;
    MedCondition = medCondition;
    Medication = medication;
    DoctorName = doctorName;
    DoctorPhone = doctorPhone;
    EmerContact = emerContact;
    EmerPhone = emerPhone;
    MailTo2 = mailTo2;
    Addr2 = addr2;
    City2 = city2;
    State2 = state2;
    Zip2 = zip2;
    Cntry2 = cntry2;
    EMail2 = eMail2;
    UseMailTo = useMailTo;
    CusPrompt1 = cusPrompt1;
    CusValue1 = cusValue1;
    CusPrompt2 = cusPrompt2;
    CusValue2 = cusValue2;
    CusPrompt3 = cusPrompt3;
    CusValue3 = cusValue3;
    State = state;
    Blind = blind;
    Deaf = deaf;
    Physical = physical;
    Cognitive = cognitive;
    SecAddr = secAddr;
    SecAddr2 = secAddr2;
    PrimaryLast = primaryLast;
    PrimaryFirst1 = primaryFirst1;
    PrimaryFirst2 = primaryFirst2;
    SecondaryLast = secondaryLast;
    SecondaryFirst1 = secondaryFirst1;
    SecondaryFirst2 = secondaryFirst2;
    CellP1 = cellP1;
    CellP2 = cellP2;
    UseBoth = useBoth;
    EveP1P2 = eveP1P2;
    CellP1P2 = cellP1P2;
    EMail1P2 = eMail1P2;
    EveP2P2 = eveP2P2;
    CellP2P2 = cellP2P2;
    EMail2P2 = eMail2P2;
    CellAthlete = cellAthlete;
    EMailAthlete = eMailAthlete;
    Middle = middle;
    USSDonation = uSSDonation;
    PrimaryLast2 = primaryLast2;
    FinaFedCntry = finaFedCntry;
    ExpAthEmail = expAthEmail;
    ExpFatherEmail = expFatherEmail;
    ExpMotherEmail = expMotherEmail;
    ExpParent1Email = expParent1Email;
    ExpParent2Email = expParent2Email;
    RegEMail = regEMail;
    USSNewsLetter = uSSNewsLetter;
    CusPrompt4 = cusPrompt4;
    CusValue4 = cusValue4;
    CusPrompt5 = cusPrompt5;
    CusValue5 = cusValue5;
    CusPrompt6 = cusPrompt6;
    CusValue6 = cusValue6;
    CusPrompt7 = cusPrompt7;
    CusValue7 = cusValue7;
    CusPrompt8 = cusPrompt8;
    CusValue8 = cusValue8;
    HSGradYear = hSGradYear;
    FINACompeted = fINACompeted;
    CustUSSFee = custUSSFee;
  }
}
