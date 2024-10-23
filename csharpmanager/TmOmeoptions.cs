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
/// CREATE TABLE [OMEOPTIONS]
/// (
/// [OMEEntryStyle] Byte,
/// [OMEReviewTime] Byte,
/// [EMailFrom] Text (100),
/// [EMailSubject] Text (200),
/// [EMailText] Text (508),
/// [LastName] Text (100),
/// [FirstName] Text (100),
/// [Phone] Text (40),
/// [EMail] Text (100),
/// [TeamName] Text (100),
/// [Addr] Text (100),
/// [SecAddr] Text (60),
/// [City] Text (60),
/// [State] Text (6),
/// [Zip] Text (20),
/// [Cntry] Text (6),
/// [TimeZone] Text (100),
/// [PayTo] Text (100),
/// [Classification] Text (100),
/// [WebSite] Text (100),
/// [NoShowMeetList] Boolean NOT NULL,
/// [NoShowMeetSetup] Boolean NOT NULL,
/// [NoShowActiveComSetup] Boolean NOT NULL,
/// [USASwimming] Boolean NOT NULL,
/// [Masters] Boolean NOT NULL,
/// [SwimLessons] Boolean NOT NULL,
/// [HighSchool] Boolean NOT NULL,
/// [SummerLeague] Boolean NOT NULL,
/// [OpenWater] Boolean NOT NULL,
/// [College] Boolean NOT NULL,
/// [Swimathons] Boolean NOT NULL,
/// [HostSwimMeets] Boolean NOT NULL,
/// [Other] Boolean NOT NULL,
/// [OtherText] Text (100),
/// [Token] Text (200),
/// [OMEWebSite] Text (200),
/// [AgencyID] Text (80),
/// [License] Text (240)
/// );

public class TmOmeoptions 
{
List<TmOmeoptions> get(OdbcConnection connection)
{
  var collection = new List<TmOmeoptions>();
  string query = "select * from OMEOPTIONS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetByte(1); /* OMEEntryStyle */
      var arg1 = reader.GetByte(2); /* OMEReviewTime */
      var arg2 = reader.GetTextReader(3).ToString(); /* EMailFrom */
      var arg3 = reader.GetTextReader(4).ToString(); /* EMailSubject */
      var arg4 = reader.GetTextReader(5).ToString(); /* EMailText */
      var arg5 = reader.GetTextReader(6).ToString(); /* LastName */
      var arg6 = reader.GetTextReader(7).ToString(); /* FirstName */
      var arg7 = reader.GetTextReader(8).ToString(); /* Phone */
      var arg8 = reader.GetTextReader(9).ToString(); /* EMail */
      var arg9 = reader.GetTextReader(10).ToString(); /* TeamName */
      var arg10 = reader.GetTextReader(11).ToString(); /* Addr */
      var arg11 = reader.GetTextReader(12).ToString(); /* SecAddr */
      var arg12 = reader.GetTextReader(13).ToString(); /* City */
      var arg13 = reader.GetTextReader(14).ToString(); /* State */
      var arg14 = reader.GetTextReader(15).ToString(); /* Zip */
      var arg15 = reader.GetTextReader(16).ToString(); /* Cntry */
      var arg16 = reader.GetTextReader(17).ToString(); /* TimeZone */
      var arg17 = reader.GetTextReader(18).ToString(); /* PayTo */
      var arg18 = reader.GetTextReader(19).ToString(); /* Classification */
      var arg19 = reader.GetTextReader(20).ToString(); /* WebSite */
      var arg20 = reader.GetBoolean(21); /* NoShowMeetList */
      var arg21 = reader.GetBoolean(22); /* NoShowMeetSetup */
      var arg22 = reader.GetBoolean(23); /* NoShowActiveComSetup */
      var arg23 = reader.GetBoolean(24); /* USASwimming */
      var arg24 = reader.GetBoolean(25); /* Masters */
      var arg25 = reader.GetBoolean(26); /* SwimLessons */
      var arg26 = reader.GetBoolean(27); /* HighSchool */
      var arg27 = reader.GetBoolean(28); /* SummerLeague */
      var arg28 = reader.GetBoolean(29); /* OpenWater */
      var arg29 = reader.GetBoolean(30); /* College */
      var arg30 = reader.GetBoolean(31); /* Swimathons */
      var arg31 = reader.GetBoolean(32); /* HostSwimMeets */
      var arg32 = reader.GetBoolean(33); /* Other */
      var arg33 = reader.GetTextReader(34).ToString(); /* OtherText */
      var arg34 = reader.GetTextReader(35).ToString(); /* Token */
      var arg35 = reader.GetTextReader(36).ToString(); /* OMEWebSite */
      var arg36 = reader.GetTextReader(37).ToString(); /* AgencyID */
      var arg37 = reader.GetTextReader(38).ToString(); /* License */
      collection.Add( new TmOmeoptions(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37));
    }
  }
  return collection;
}
  // Properties
  public byte OMEEntryStyle{ get; }
  public byte OMEReviewTime{ get; }
  public string EMailFrom{ get; }
  public string EMailSubject{ get; }
  public string EMailText{ get; }
  public string LastName{ get; }
  public string FirstName{ get; }
  public string Phone{ get; }
  public string EMail{ get; }
  public string TeamName{ get; }
  public string Addr{ get; }
  public string SecAddr{ get; }
  public string City{ get; }
  public string State{ get; }
  public string Zip{ get; }
  public string Cntry{ get; }
  public string TimeZone{ get; }
  public string PayTo{ get; }
  public string Classification{ get; }
  public string WebSite{ get; }
  public bool NoShowMeetList{ get; }
  public bool NoShowMeetSetup{ get; }
  public bool NoShowActiveComSetup{ get; }
  public bool USASwimming{ get; }
  public bool Masters{ get; }
  public bool SwimLessons{ get; }
  public bool HighSchool{ get; }
  public bool SummerLeague{ get; }
  public bool OpenWater{ get; }
  public bool College{ get; }
  public bool Swimathons{ get; }
  public bool HostSwimMeets{ get; }
  public bool Other{ get; }
  public string OtherText{ get; }
  public string Token{ get; }
  public string OMEWebSite{ get; }
  public string AgencyID{ get; }
  public string License{ get; }
  // Constructor
  TmOmeoptions(byte oMEEntryStyle, byte oMEReviewTime, string eMailFrom, string eMailSubject, string eMailText, string lastName, string firstName, string phone, string eMail, string teamName, string addr, string secAddr, string city, string state, string zip, string cntry, string timeZone, string payTo, string classification, string webSite, bool noShowMeetList, bool noShowMeetSetup, bool noShowActiveComSetup, bool uSASwimming, bool masters, bool swimLessons, bool highSchool, bool summerLeague, bool openWater, bool college, bool swimathons, bool hostSwimMeets, bool other, string otherText, string token, string oMEWebSite, string agencyID, string license )
  {
    OMEEntryStyle = oMEEntryStyle;
    OMEReviewTime = oMEReviewTime;
    EMailFrom = eMailFrom;
    EMailSubject = eMailSubject;
    EMailText = eMailText;
    LastName = lastName;
    FirstName = firstName;
    Phone = phone;
    EMail = eMail;
    TeamName = teamName;
    Addr = addr;
    SecAddr = secAddr;
    City = city;
    State = state;
    Zip = zip;
    Cntry = cntry;
    TimeZone = timeZone;
    PayTo = payTo;
    Classification = classification;
    WebSite = webSite;
    NoShowMeetList = noShowMeetList;
    NoShowMeetSetup = noShowMeetSetup;
    NoShowActiveComSetup = noShowActiveComSetup;
    USASwimming = uSASwimming;
    Masters = masters;
    SwimLessons = swimLessons;
    HighSchool = highSchool;
    SummerLeague = summerLeague;
    OpenWater = openWater;
    College = college;
    Swimathons = swimathons;
    HostSwimMeets = hostSwimMeets;
    Other = other;
    OtherText = otherText;
    Token = token;
    OMEWebSite = oMEWebSite;
    AgencyID = agencyID;
    License = license;
  }
}
