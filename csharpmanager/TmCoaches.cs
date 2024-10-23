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
/// CREATE TABLE [COACHES]
/// (
/// [Coaches] Long Integer,
/// [Team] Long Integer,
/// [CPhone] Text (28),
/// [CEMail] Text (72),
/// [CName] Text (60),
/// [CTitle] Text (30),
/// [Cert1] Text (30),
/// [Cert2] Text (30),
/// [Cert3] Text (30),
/// [Head] Boolean NOT NULL,
/// [CoachCell] Text (40),
/// [Export] Boolean NOT NULL,
/// [Cert4] Text (30),
/// [Cert5] Text (30),
/// [Cert1Expire] DateTime,
/// [Cert2Expire] DateTime,
/// [Cert3Expire] DateTime,
/// [Cert4Expire] DateTime,
/// [Cert5Expire] DateTime,
/// [PrimaryMale] Boolean NOT NULL,
/// [PrimaryFemale] Boolean NOT NULL,
/// [MaleOnly] Boolean NOT NULL,
/// [FemaleOnly] Boolean NOT NULL,
/// [cLastName] Text (40),
/// [cFirstName] Text (40),
/// [CFirst] Text (30),
/// [CLast] Text (30)
/// );

public class TmCoaches 
{
List<TmCoaches> get(OdbcConnection connection)
{
  var collection = new List<TmCoaches>();
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
      var arg0 = reader.GetInt64(1); /* Coaches */
      var arg1 = reader.GetInt64(2); /* Team */
      var arg2 = reader.GetTextReader(3).ToString(); /* CPhone */
      var arg3 = reader.GetTextReader(4).ToString(); /* CEMail */
      var arg4 = reader.GetTextReader(5).ToString(); /* CName */
      var arg5 = reader.GetTextReader(6).ToString(); /* CTitle */
      var arg6 = reader.GetTextReader(7).ToString(); /* Cert1 */
      var arg7 = reader.GetTextReader(8).ToString(); /* Cert2 */
      var arg8 = reader.GetTextReader(9).ToString(); /* Cert3 */
      var arg9 = reader.GetBoolean(10); /* Head */
      var arg10 = reader.GetTextReader(11).ToString(); /* CoachCell */
      var arg11 = reader.GetBoolean(12); /* Export */
      var arg12 = reader.GetTextReader(13).ToString(); /* Cert4 */
      var arg13 = reader.GetTextReader(14).ToString(); /* Cert5 */
      var arg14 = reader.GetDateTime(15); /* Cert1Expire */
      var arg15 = reader.GetDateTime(16); /* Cert2Expire */
      var arg16 = reader.GetDateTime(17); /* Cert3Expire */
      var arg17 = reader.GetDateTime(18); /* Cert4Expire */
      var arg18 = reader.GetDateTime(19); /* Cert5Expire */
      var arg19 = reader.GetBoolean(20); /* PrimaryMale */
      var arg20 = reader.GetBoolean(21); /* PrimaryFemale */
      var arg21 = reader.GetBoolean(22); /* MaleOnly */
      var arg22 = reader.GetBoolean(23); /* FemaleOnly */
      var arg23 = reader.GetTextReader(24).ToString(); /* cLastName */
      var arg24 = reader.GetTextReader(25).ToString(); /* cFirstName */
      var arg25 = reader.GetTextReader(26).ToString(); /* CFirst */
      var arg26 = reader.GetTextReader(27).ToString(); /* CLast */
      collection.Add( new TmCoaches(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26));
    }
  }
  return collection;
}
  // Properties
  public long Coaches{ get; }
  public long Team{ get; }
  public string CPhone{ get; }
  public string CEMail{ get; }
  public string CName{ get; }
  public string CTitle{ get; }
  public string Cert1{ get; }
  public string Cert2{ get; }
  public string Cert3{ get; }
  public bool Head{ get; }
  public string CoachCell{ get; }
  public bool Cexport{ get; }
  public string Cert4{ get; }
  public string Cert5{ get; }
  public DateTime Cert1Expire{ get; }
  public DateTime Cert2Expire{ get; }
  public DateTime Cert3Expire{ get; }
  public DateTime Cert4Expire{ get; }
  public DateTime Cert5Expire{ get; }
  public bool PrimaryMale{ get; }
  public bool PrimaryFemale{ get; }
  public bool MaleOnly{ get; }
  public bool FemaleOnly{ get; }
  public string CLastName{ get; }
  public string CFirstName{ get; }
  public string CFirst{ get; }
  public string CLast{ get; }
  // Constructor
  TmCoaches(long coaches, long team, string cPhone, string cEMail, string cName, string cTitle, string cert1, string cert2, string cert3, bool head, string coachCell, bool cexport, string cert4, string cert5, DateTime cert1Expire, DateTime cert2Expire, DateTime cert3Expire, DateTime cert4Expire, DateTime cert5Expire, bool primaryMale, bool primaryFemale, bool maleOnly, bool femaleOnly, string cLastName, string cFirstName, string cFirst, string cLast )
  {
    Coaches = coaches;
    Team = team;
    CPhone = cPhone;
    CEMail = cEMail;
    CName = cName;
    CTitle = cTitle;
    Cert1 = cert1;
    Cert2 = cert2;
    Cert3 = cert3;
    Head = head;
    CoachCell = coachCell;
    Cexport = cexport;
    Cert4 = cert4;
    Cert5 = cert5;
    Cert1Expire = cert1Expire;
    Cert2Expire = cert2Expire;
    Cert3Expire = cert3Expire;
    Cert4Expire = cert4Expire;
    Cert5Expire = cert5Expire;
    PrimaryMale = primaryMale;
    PrimaryFemale = primaryFemale;
    MaleOnly = maleOnly;
    FemaleOnly = femaleOnly;
    CLastName = cLastName;
    CFirstName = cFirstName;
    CFirst = cFirst;
    CLast = cLast;
  }
}
