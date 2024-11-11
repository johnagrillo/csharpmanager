using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [TEAM]
/// // (
/// // [Team] Long Integer,
/// // [TCode] Text (10),
/// // [TName] Text (60),
/// // [Short] Text (32),
/// // [LSC] Text (6),
/// // [MailTo] Text (80),
/// // [TAddr] Text (60),
/// // [TCity] Text (60),
/// // [TState] Text (6),
/// // [TZip] Text (20),
/// // [TCntry] Text (6),
/// // [Day] Text (40),
/// // [Eve] Text (40),
/// // [Fax] Text (40),
/// // [TType] Text (6),
/// // [Regn] Text (2),
/// // [Reg] Text (8),
/// // [MinAge] Integer,
/// // [NumAth] Long Integer,
/// // [EMail] Text (72),
/// // [TM50] Boolean NOT NULL,
/// // [TDivision] Text (6)
/// // );

public class Team(long team, string tCode, string tName, string cshort, string lsc, string mailTo, string tAddr, string tCity, string tState, string tZip, string tCntry, string day, string eve, string fax, string tType, string regn, string reg, short? minAge, long? numAth, string eMail, bool tm50, string tDivision )
{
static public List<Team> Get(OdbcConnection connection)
{
  var collection = new List<Team>();
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
  var arg0 = reader.GetInt32(0); /* Team nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* TCode nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* TName nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Short nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* LSC nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* MailTo nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* TAddr nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* TCity nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* TState nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* TZip nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* TCntry nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Day nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* Eve nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Fax nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* TType nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Regn nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* Reg nullable false*/
  var arg17 = reader.IsDBNull(17) ? (short?)null :reader.GetInt16(17); /* MinAge nullable true*/
  var arg18 = reader.IsDBNull(18) ? (long?)null :reader.GetInt32(18); /* NumAth nullable true*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* EMail nullable false*/
  var arg20 = reader.GetBoolean(20); /* TM50 nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* TDivision nullable false*/
      collection.Add( new Team(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21));
    }
  }
  return collection;
}
  // Properties
  public long Team_{ get; } = team;
  public string TCode{ get; } = tCode;
  public string TName{ get; } = tName;
  public string Cshort{ get; } = cshort;
  public string Lsc{ get; } = lsc;
  public string MailTo{ get; } = mailTo;
  public string TAddr{ get; } = tAddr;
  public string TCity{ get; } = tCity;
  public string TState{ get; } = tState;
  public string TZip{ get; } = tZip;
  public string TCntry{ get; } = tCntry;
  public string Day{ get; } = day;
  public string Eve{ get; } = eve;
  public string Fax{ get; } = fax;
  public string TType{ get; } = tType;
  public string Regn{ get; } = regn;
  public string Reg{ get; } = reg;
  public short? MinAge{ get; } = minAge;
  public long? NumAth{ get; } = numAth;
  public string EMail{ get; } = eMail;
  public bool Tm50{ get; } = tm50;
  public string TDivision{ get; } = tDivision;
}
}
}
