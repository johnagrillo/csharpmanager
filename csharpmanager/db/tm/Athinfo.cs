using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [AthInfo]
/// // (
/// // [Athlete] Long Integer,
/// // [Addr] Text (60),
/// // [City] Text (60),
/// // [ZIP] Text (20),
/// // [Cntry] Text (40),
/// // [DayP1] Text (40),
/// // [EveP1] Text (40),
/// // [FaxP1] Text (40),
/// // [DayP2] Text (40),
/// // [EveP2] Text (40),
/// // [FaxP2] Text (40),
/// // [MailTo] Text (80),
/// // [Seasonal] Text (2),
/// // [FinaFed] Boolean NOT NULL,
/// // [RegDate] DateTime,
/// // [NRCD] Text (2),
/// // [EMail] Text (100),
/// // [Member] Boolean NOT NULL,
/// // [JrHS] Boolean NOT NULL,
/// // [HS] Boolean NOT NULL,
/// // [YMCA] Boolean NOT NULL,
/// // [Coll] Boolean NOT NULL,
/// // [SL] Boolean NOT NULL,
/// // [DUAL] Boolean NOT NULL,
/// // [Mast] Boolean NOT NULL,
/// // [Dis] Boolean NOT NULL,
/// // [Polo] Boolean NOT NULL,
/// // [Ethnic] Byte,
/// // [MedCondition] Text (240),
/// // [Medication] Text (240),
/// // [DoctorName] Text (60),
/// // [DoctorPhone] Text (40),
/// // [EmerContact] Text (60),
/// // [EmerPhone] Text (40),
/// // [MailTo2] Text (80),
/// // [Addr2] Text (60),
/// // [City2] Text (60),
/// // [State2] Text (6),
/// // [ZIP2] Text (20),
/// // [Cntry2] Text (40),
/// // [EMail2] Text (100),
/// // [UseMailTo] Boolean NOT NULL,
/// // [CusPrompt1] Text (40),
/// // [CusValue1] Text (40),
/// // [CusPrompt2] Text (40),
/// // [CusValue2] Text (40),
/// // [CusPrompt3] Text (40),
/// // [CusValue3] Text (40),
/// // [State] Text (6),
/// // [BLIND] Boolean NOT NULL,
/// // [DEAF] Boolean NOT NULL,
/// // [PHYSICAL] Boolean NOT NULL,
/// // [COGNITIVE] Boolean NOT NULL,
/// // [SecAddr] Text (60),
/// // [SecAddr2] Text (60),
/// // [PrimaryLast] Text (40),
/// // [PrimaryFirst1] Text (40),
/// // [PrimaryFirst2] Text (40),
/// // [SecondaryLast] Text (40),
/// // [SecondaryFirst1] Text (40),
/// // [SecondaryFirst2] Text (40),
/// // [CellP1] Text (40),
/// // [CellP2] Text (40),
/// // [UseBoth] Boolean NOT NULL,
/// // [EveP1P2] Text (40),
/// // [CellP1P2] Text (40),
/// // [EMail1P2] Text (100),
/// // [EveP2P2] Text (40),
/// // [CellP2P2] Text (40),
/// // [EMail2P2] Text (100),
/// // [CellAthlete] Text (40),
/// // [EMailAthlete] Text (100),
/// // [Middle] Text (40),
/// // [USSDonation] Boolean NOT NULL,
/// // [PrimaryLast2] Text (40),
/// // [FinaFedCntry] Text (6),
/// // [ExpAthEmail] Boolean NOT NULL,
/// // [ExpFatherEmail] Boolean NOT NULL,
/// // [ExpMotherEmail] Boolean NOT NULL,
/// // [ExpParent1Email] Boolean NOT NULL,
/// // [ExpParent2Email] Boolean NOT NULL,
/// // [RegEMail] Text (100),
/// // [USSNewsLetter] Boolean NOT NULL,
/// // [CusPrompt4] Text (40),
/// // [CusValue4] Text (40),
/// // [CusPrompt5] Text (40),
/// // [CusValue5] Text (40),
/// // [CusPrompt6] Text (40),
/// // [CusValue6] Text (40),
/// // [CusPrompt7] Text (40),
/// // [CusValue7] Text (40),
/// // [CusPrompt8] Text (40),
/// // [CusValue8] Text (40),
/// // [HSGradYear] Integer,
/// // [FINACompeted] Boolean NOT NULL,
/// // [CustUSSFee] Text (20)
/// // );

public class Athinfo(long? athlete, string addr, string city, string zip, string cntry, string dayP1, string eveP1, string faxP1, string dayP2, string eveP2, string faxP2, string mailTo, string seasonal, bool finaFed, DateTime? regDate, string nrcd, string eMail, bool member, bool jrHS, bool hs, bool ymca, bool coll, bool sl, bool dual, bool mast, bool dis, bool polo, byte? ethnic, string medCondition, string medication, string doctorName, string doctorPhone, string emerContact, string emerPhone, string mailTo2, string addr2, string city2, string state2, string zip2, string cntry2, string eMail2, bool useMailTo, string cusPrompt1, string cusValue1, string cusPrompt2, string cusValue2, string cusPrompt3, string cusValue3, string state, bool blind, bool deaf, bool physical, bool cognitive, string secAddr, string secAddr2, string primaryLast, string primaryFirst1, string primaryFirst2, string secondaryLast, string secondaryFirst1, string secondaryFirst2, string cellP1, string cellP2, bool useBoth, string eveP1P2, string cellP1P2, string eMail1P2, string eveP2P2, string cellP2P2, string eMail2P2, string cellAthlete, string eMailAthlete, string middle, bool uSSDonation, string primaryLast2, string finaFedCntry, bool expAthEmail, bool expFatherEmail, bool expMotherEmail, bool expParent1Email, bool expParent2Email, string regEMail, bool uSSNewsLetter, string cusPrompt4, string cusValue4, string cusPrompt5, string cusValue5, string cusPrompt6, string cusValue6, string cusPrompt7, string cusValue7, string cusPrompt8, string cusValue8, short? hSGradYear, bool fINACompeted, string custUSSFee )
{
static public List<Athinfo> Get(OdbcConnection connection)
{
  var collection = new List<Athinfo>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Athlete nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Addr nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* City nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* ZIP nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Cntry nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* DayP1 nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* EveP1 nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* FaxP1 nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* DayP2 nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* EveP2 nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* FaxP2 nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* MailTo nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Seasonal nullable false*/
  var arg13 = reader.GetBoolean(13); /* FinaFed nullable false*/
  var arg14 = reader.IsDBNull(14) ? (DateTime?)null :reader.GetDateTime(14); /* RegDate nullable true*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* NRCD nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* EMail nullable false*/
  var arg17 = reader.GetBoolean(17); /* Member nullable false*/
  var arg18 = reader.GetBoolean(18); /* JrHS nullable false*/
  var arg19 = reader.GetBoolean(19); /* HS nullable false*/
  var arg20 = reader.GetBoolean(20); /* YMCA nullable false*/
  var arg21 = reader.GetBoolean(21); /* Coll nullable false*/
  var arg22 = reader.GetBoolean(22); /* SL nullable false*/
  var arg23 = reader.GetBoolean(23); /* DUAL nullable false*/
  var arg24 = reader.GetBoolean(24); /* Mast nullable false*/
  var arg25 = reader.GetBoolean(25); /* Dis nullable false*/
  var arg26 = reader.GetBoolean(26); /* Polo nullable false*/
  var arg27 = reader.IsDBNull(27) ? (byte?)null :reader.GetByte(27); /* Ethnic nullable true*/
  var arg28 = reader.GetTextReader(28).ReadLine(); /* MedCondition nullable false*/
  var arg29 = reader.GetTextReader(29).ReadLine(); /* Medication nullable false*/
  var arg30 = reader.GetTextReader(30).ReadLine(); /* DoctorName nullable false*/
  var arg31 = reader.GetTextReader(31).ReadLine(); /* DoctorPhone nullable false*/
  var arg32 = reader.GetTextReader(32).ReadLine(); /* EmerContact nullable false*/
  var arg33 = reader.GetTextReader(33).ReadLine(); /* EmerPhone nullable false*/
  var arg34 = reader.GetTextReader(34).ReadLine(); /* MailTo2 nullable false*/
  var arg35 = reader.GetTextReader(35).ReadLine(); /* Addr2 nullable false*/
  var arg36 = reader.GetTextReader(36).ReadLine(); /* City2 nullable false*/
  var arg37 = reader.GetTextReader(37).ReadLine(); /* State2 nullable false*/
  var arg38 = reader.GetTextReader(38).ReadLine(); /* ZIP2 nullable false*/
  var arg39 = reader.GetTextReader(39).ReadLine(); /* Cntry2 nullable false*/
  var arg40 = reader.GetTextReader(40).ReadLine(); /* EMail2 nullable false*/
  var arg41 = reader.GetBoolean(41); /* UseMailTo nullable false*/
  var arg42 = reader.GetTextReader(42).ReadLine(); /* CusPrompt1 nullable false*/
  var arg43 = reader.GetTextReader(43).ReadLine(); /* CusValue1 nullable false*/
  var arg44 = reader.GetTextReader(44).ReadLine(); /* CusPrompt2 nullable false*/
  var arg45 = reader.GetTextReader(45).ReadLine(); /* CusValue2 nullable false*/
  var arg46 = reader.GetTextReader(46).ReadLine(); /* CusPrompt3 nullable false*/
  var arg47 = reader.GetTextReader(47).ReadLine(); /* CusValue3 nullable false*/
  var arg48 = reader.GetTextReader(48).ReadLine(); /* State nullable false*/
  var arg49 = reader.GetBoolean(49); /* BLIND nullable false*/
  var arg50 = reader.GetBoolean(50); /* DEAF nullable false*/
  var arg51 = reader.GetBoolean(51); /* PHYSICAL nullable false*/
  var arg52 = reader.GetBoolean(52); /* COGNITIVE nullable false*/
  var arg53 = reader.GetTextReader(53).ReadLine(); /* SecAddr nullable false*/
  var arg54 = reader.GetTextReader(54).ReadLine(); /* SecAddr2 nullable false*/
  var arg55 = reader.GetTextReader(55).ReadLine(); /* PrimaryLast nullable false*/
  var arg56 = reader.GetTextReader(56).ReadLine(); /* PrimaryFirst1 nullable false*/
  var arg57 = reader.GetTextReader(57).ReadLine(); /* PrimaryFirst2 nullable false*/
  var arg58 = reader.GetTextReader(58).ReadLine(); /* SecondaryLast nullable false*/
  var arg59 = reader.GetTextReader(59).ReadLine(); /* SecondaryFirst1 nullable false*/
  var arg60 = reader.GetTextReader(60).ReadLine(); /* SecondaryFirst2 nullable false*/
  var arg61 = reader.GetTextReader(61).ReadLine(); /* CellP1 nullable false*/
  var arg62 = reader.GetTextReader(62).ReadLine(); /* CellP2 nullable false*/
  var arg63 = reader.GetBoolean(63); /* UseBoth nullable false*/
  var arg64 = reader.GetTextReader(64).ReadLine(); /* EveP1P2 nullable false*/
  var arg65 = reader.GetTextReader(65).ReadLine(); /* CellP1P2 nullable false*/
  var arg66 = reader.GetTextReader(66).ReadLine(); /* EMail1P2 nullable false*/
  var arg67 = reader.GetTextReader(67).ReadLine(); /* EveP2P2 nullable false*/
  var arg68 = reader.GetTextReader(68).ReadLine(); /* CellP2P2 nullable false*/
  var arg69 = reader.GetTextReader(69).ReadLine(); /* EMail2P2 nullable false*/
  var arg70 = reader.GetTextReader(70).ReadLine(); /* CellAthlete nullable false*/
  var arg71 = reader.GetTextReader(71).ReadLine(); /* EMailAthlete nullable false*/
  var arg72 = reader.GetTextReader(72).ReadLine(); /* Middle nullable false*/
  var arg73 = reader.GetBoolean(73); /* USSDonation nullable false*/
  var arg74 = reader.GetTextReader(74).ReadLine(); /* PrimaryLast2 nullable false*/
  var arg75 = reader.GetTextReader(75).ReadLine(); /* FinaFedCntry nullable false*/
  var arg76 = reader.GetBoolean(76); /* ExpAthEmail nullable false*/
  var arg77 = reader.GetBoolean(77); /* ExpFatherEmail nullable false*/
  var arg78 = reader.GetBoolean(78); /* ExpMotherEmail nullable false*/
  var arg79 = reader.GetBoolean(79); /* ExpParent1Email nullable false*/
  var arg80 = reader.GetBoolean(80); /* ExpParent2Email nullable false*/
  var arg81 = reader.GetTextReader(81).ReadLine(); /* RegEMail nullable false*/
  var arg82 = reader.GetBoolean(82); /* USSNewsLetter nullable false*/
  var arg83 = reader.GetTextReader(83).ReadLine(); /* CusPrompt4 nullable false*/
  var arg84 = reader.GetTextReader(84).ReadLine(); /* CusValue4 nullable false*/
  var arg85 = reader.GetTextReader(85).ReadLine(); /* CusPrompt5 nullable false*/
  var arg86 = reader.GetTextReader(86).ReadLine(); /* CusValue5 nullable false*/
  var arg87 = reader.GetTextReader(87).ReadLine(); /* CusPrompt6 nullable false*/
  var arg88 = reader.GetTextReader(88).ReadLine(); /* CusValue6 nullable false*/
  var arg89 = reader.GetTextReader(89).ReadLine(); /* CusPrompt7 nullable false*/
  var arg90 = reader.GetTextReader(90).ReadLine(); /* CusValue7 nullable false*/
  var arg91 = reader.GetTextReader(91).ReadLine(); /* CusPrompt8 nullable false*/
  var arg92 = reader.GetTextReader(92).ReadLine(); /* CusValue8 nullable false*/
  var arg93 = reader.IsDBNull(93) ? (short?)null :reader.GetInt16(93); /* HSGradYear nullable true*/
  var arg94 = reader.GetBoolean(94); /* FINACompeted nullable false*/
  var arg95 = reader.GetTextReader(95).ReadLine(); /* CustUSSFee nullable false*/
      collection.Add( new Athinfo(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79, arg80, arg81, arg82, arg83, arg84, arg85, arg86, arg87, arg88, arg89, arg90, arg91, arg92, arg93, arg94, arg95));
    }
  }
  return collection;
}
  // Properties
  public long? Athlete{ get; } = athlete;
  public string Addr{ get; } = addr;
  public string City{ get; } = city;
  public string Zip{ get; } = zip;
  public string Cntry{ get; } = cntry;
  public string DayP1{ get; } = dayP1;
  public string EveP1{ get; } = eveP1;
  public string FaxP1{ get; } = faxP1;
  public string DayP2{ get; } = dayP2;
  public string EveP2{ get; } = eveP2;
  public string FaxP2{ get; } = faxP2;
  public string MailTo{ get; } = mailTo;
  public string Seasonal{ get; } = seasonal;
  public bool FinaFed{ get; } = finaFed;
  public DateTime? RegDate{ get; } = regDate;
  public string Nrcd{ get; } = nrcd;
  public string EMail{ get; } = eMail;
  public bool Member{ get; } = member;
  public bool JrHS{ get; } = jrHS;
  public bool Hs{ get; } = hs;
  public bool Ymca{ get; } = ymca;
  public bool Coll{ get; } = coll;
  public bool Sl{ get; } = sl;
  public bool Dual{ get; } = dual;
  public bool Mast{ get; } = mast;
  public bool Dis{ get; } = dis;
  public bool Polo{ get; } = polo;
  public byte? Ethnic{ get; } = ethnic;
  public string MedCondition{ get; } = medCondition;
  public string Medication{ get; } = medication;
  public string DoctorName{ get; } = doctorName;
  public string DoctorPhone{ get; } = doctorPhone;
  public string EmerContact{ get; } = emerContact;
  public string EmerPhone{ get; } = emerPhone;
  public string MailTo2{ get; } = mailTo2;
  public string Addr2{ get; } = addr2;
  public string City2{ get; } = city2;
  public string State2{ get; } = state2;
  public string Zip2{ get; } = zip2;
  public string Cntry2{ get; } = cntry2;
  public string EMail2{ get; } = eMail2;
  public bool UseMailTo{ get; } = useMailTo;
  public string CusPrompt1{ get; } = cusPrompt1;
  public string CusValue1{ get; } = cusValue1;
  public string CusPrompt2{ get; } = cusPrompt2;
  public string CusValue2{ get; } = cusValue2;
  public string CusPrompt3{ get; } = cusPrompt3;
  public string CusValue3{ get; } = cusValue3;
  public string State{ get; } = state;
  public bool Blind{ get; } = blind;
  public bool Deaf{ get; } = deaf;
  public bool Physical{ get; } = physical;
  public bool Cognitive{ get; } = cognitive;
  public string SecAddr{ get; } = secAddr;
  public string SecAddr2{ get; } = secAddr2;
  public string PrimaryLast{ get; } = primaryLast;
  public string PrimaryFirst1{ get; } = primaryFirst1;
  public string PrimaryFirst2{ get; } = primaryFirst2;
  public string SecondaryLast{ get; } = secondaryLast;
  public string SecondaryFirst1{ get; } = secondaryFirst1;
  public string SecondaryFirst2{ get; } = secondaryFirst2;
  public string CellP1{ get; } = cellP1;
  public string CellP2{ get; } = cellP2;
  public bool UseBoth{ get; } = useBoth;
  public string EveP1P2{ get; } = eveP1P2;
  public string CellP1P2{ get; } = cellP1P2;
  public string EMail1P2{ get; } = eMail1P2;
  public string EveP2P2{ get; } = eveP2P2;
  public string CellP2P2{ get; } = cellP2P2;
  public string EMail2P2{ get; } = eMail2P2;
  public string CellAthlete{ get; } = cellAthlete;
  public string EMailAthlete{ get; } = eMailAthlete;
  public string Middle{ get; } = middle;
  public bool USSDonation{ get; } = uSSDonation;
  public string PrimaryLast2{ get; } = primaryLast2;
  public string FinaFedCntry{ get; } = finaFedCntry;
  public bool ExpAthEmail{ get; } = expAthEmail;
  public bool ExpFatherEmail{ get; } = expFatherEmail;
  public bool ExpMotherEmail{ get; } = expMotherEmail;
  public bool ExpParent1Email{ get; } = expParent1Email;
  public bool ExpParent2Email{ get; } = expParent2Email;
  public string RegEMail{ get; } = regEMail;
  public bool USSNewsLetter{ get; } = uSSNewsLetter;
  public string CusPrompt4{ get; } = cusPrompt4;
  public string CusValue4{ get; } = cusValue4;
  public string CusPrompt5{ get; } = cusPrompt5;
  public string CusValue5{ get; } = cusValue5;
  public string CusPrompt6{ get; } = cusPrompt6;
  public string CusValue6{ get; } = cusValue6;
  public string CusPrompt7{ get; } = cusPrompt7;
  public string CusValue7{ get; } = cusValue7;
  public string CusPrompt8{ get; } = cusPrompt8;
  public string CusValue8{ get; } = cusValue8;
  public short? HSGradYear{ get; } = hSGradYear;
  public bool FINACompeted{ get; } = fINACompeted;
  public string CustUSSFee{ get; } = custUSSFee;
}
}
}
