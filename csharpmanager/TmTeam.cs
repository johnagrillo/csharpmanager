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
/// CREATE TABLE [TEAM]
/// (
/// [Team] Long Integer,
/// [TCode] Text (10),
/// [TName] Text (60),
/// [Short] Text (32),
/// [LSC] Text (6),
/// [MailTo] Text (80),
/// [TAddr] Text (60),
/// [TCity] Text (60),
/// [TState] Text (6),
/// [TZip] Text (20),
/// [TCntry] Text (6),
/// [Day] Text (40),
/// [Eve] Text (40),
/// [Fax] Text (40),
/// [TType] Text (6),
/// [Regn] Text (2),
/// [Reg] Text (8),
/// [MinAge] Integer,
/// [NumAth] Long Integer,
/// [EMail] Text (72),
/// [TM50] Boolean NOT NULL,
/// [TDivision] Text (6)
/// );

public class TmTeam 
{
Dictionary<long,TmTeam> get(OdbcConnection connection)
{
  var collection = new Dictionary<long,TmTeam>();
  string query = "select * from TEAM";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Team */
      var arg1 = reader.GetTextReader(2).ToString(); /* TCode */
      var arg2 = reader.GetTextReader(3).ToString(); /* TName */
      var arg3 = reader.GetTextReader(4).ToString(); /* Short */
      var arg4 = reader.GetTextReader(5).ToString(); /* LSC */
      var arg5 = reader.GetTextReader(6).ToString(); /* MailTo */
      var arg6 = reader.GetTextReader(7).ToString(); /* TAddr */
      var arg7 = reader.GetTextReader(8).ToString(); /* TCity */
      var arg8 = reader.GetTextReader(9).ToString(); /* TState */
      var arg9 = reader.GetTextReader(10).ToString(); /* TZip */
      var arg10 = reader.GetTextReader(11).ToString(); /* TCntry */
      var arg11 = reader.GetTextReader(12).ToString(); /* Day */
      var arg12 = reader.GetTextReader(13).ToString(); /* Eve */
      var arg13 = reader.GetTextReader(14).ToString(); /* Fax */
      var arg14 = reader.GetTextReader(15).ToString(); /* TType */
      var arg15 = reader.GetTextReader(16).ToString(); /* Regn */
      var arg16 = reader.GetTextReader(17).ToString(); /* Reg */
      var arg17 = reader.GetInt16(18); /* MinAge */
      var arg18 = reader.GetInt64(19); /* NumAth */
      var arg19 = reader.GetTextReader(20).ToString(); /* EMail */
      var arg20 = reader.GetBoolean(21); /* TM50 */
      var arg21 = reader.GetTextReader(22).ToString(); /* TDivision */
      var obj = new TmTeam(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
      collection[obj.Team] = obj;
    }
  }
  return collection;
}
  // Properties
  public long Team{ get; }
  public string TCode{ get; }
  public string TName{ get; }
  public string Cshort{ get; }
  public string Lsc{ get; }
  public string MailTo{ get; }
  public string TAddr{ get; }
  public string TCity{ get; }
  public string TState{ get; }
  public string TZip{ get; }
  public string TCntry{ get; }
  public string Day{ get; }
  public string Eve{ get; }
  public string Fax{ get; }
  public string TType{ get; }
  public string Regn{ get; }
  public string Reg{ get; }
  public short MinAge{ get; }
  public long NumAth{ get; }
  public string EMail{ get; }
  public bool Tm50{ get; }
  public string TDivision{ get; }
  // Constructor
  TmTeam(long team, string tCode, string tName, string cshort, string lsc, string mailTo, string tAddr, string tCity, string tState, string tZip, string tCntry, string day, string eve, string fax, string tType, string regn, string reg, short minAge, long numAth, string eMail, bool tm50, string tDivision )
  {
    Team = team;
    TCode = tCode;
    TName = tName;
    Cshort = cshort;
    Lsc = lsc;
    MailTo = mailTo;
    TAddr = tAddr;
    TCity = tCity;
    TState = tState;
    TZip = tZip;
    TCntry = tCntry;
    Day = day;
    Eve = eve;
    Fax = fax;
    TType = tType;
    Regn = regn;
    Reg = reg;
    MinAge = minAge;
    NumAth = numAth;
    EMail = eMail;
    Tm50 = tm50;
    TDivision = tDivision;
  }
}
