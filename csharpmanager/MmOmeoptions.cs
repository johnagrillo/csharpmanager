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
/// [Token] Text (160),
/// [OMEWebSite] Text (200),
/// [AgencyID] Text (80),
/// [License] Text (240),
/// [ActiveMeetID] Long Integer,
/// [EV4_uploaded] Boolean NOT NULL
/// );

public class MmOmeoptions 
{
List<MmOmeoptions> get(OdbcConnection connection)
{
  var collection = new List<MmOmeoptions>();
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
      var arg23 = reader.GetTextReader(24).ToString(); /* Token */
      var arg24 = reader.GetTextReader(25).ToString(); /* OMEWebSite */
      var arg25 = reader.GetTextReader(26).ToString(); /* AgencyID */
      var arg26 = reader.GetTextReader(27).ToString(); /* License */
      var arg27 = reader.GetInt64(28); /* ActiveMeetID */
      var arg28 = reader.GetBoolean(29); /* EV4_uploaded */
      collection.Add( new MmOmeoptions(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28));
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
  public string Token{ get; }
  public string OMEWebSite{ get; }
  public string AgencyID{ get; }
  public string License{ get; }
  public long ActiveMeetID{ get; }
  public bool EV4Uploaded{ get; }
  // Constructor
  MmOmeoptions(byte oMEEntryStyle, byte oMEReviewTime, string eMailFrom, string eMailSubject, string eMailText, string lastName, string firstName, string phone, string eMail, string teamName, string addr, string secAddr, string city, string state, string zip, string cntry, string timeZone, string payTo, string classification, string webSite, bool noShowMeetList, bool noShowMeetSetup, bool noShowActiveComSetup, string token, string oMEWebSite, string agencyID, string license, long activeMeetID, bool eV4Uploaded )
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
    Token = token;
    OMEWebSite = oMEWebSite;
    AgencyID = agencyID;
    License = license;
    ActiveMeetID = activeMeetID;
    EV4Uploaded = eV4Uploaded;
  }
}
