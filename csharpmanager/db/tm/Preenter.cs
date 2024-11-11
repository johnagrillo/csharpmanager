using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [PREENTER]
/// // (
/// // [THEATHLETE] Long Integer,
/// // [THEMEET] Long Integer,
/// // [PREENTERED] Boolean NOT NULL,
/// // [SESSION1] Text (6),
/// // [SESSION2] Text (6),
/// // [SESSION3] Text (6),
/// // [SESSION4] Text (6),
/// // [SESSION5] Text (6),
/// // [SESSION6] Text (6),
/// // [SESSION7] Text (6),
/// // [SESSION8] Text (6),
/// // [SESSION9] Text (6),
/// // [SESSION10] Text (6),
/// // [NOTATTENDING] Boolean NOT NULL
/// // );

public class Preenter(long? theathlete, long? themeet, bool preentered, string session1, string session2, string session3, string session4, string session5, string session6, string session7, string session8, string session9, string session10, bool notattending )
{
static public List<Preenter> Get(OdbcConnection connection)
{
  var collection = new List<Preenter>();
  string query = "select * from PREENTER";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* THEATHLETE nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* THEMEET nullable true*/
  var arg2 = reader.GetBoolean(2); /* PREENTERED nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* SESSION1 nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* SESSION2 nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* SESSION3 nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* SESSION4 nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* SESSION5 nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* SESSION6 nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* SESSION7 nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* SESSION8 nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* SESSION9 nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* SESSION10 nullable false*/
  var arg13 = reader.GetBoolean(13); /* NOTATTENDING nullable false*/
      collection.Add( new Preenter(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public long? Theathlete{ get; } = theathlete;
  public long? Themeet{ get; } = themeet;
  public bool Preentered{ get; } = preentered;
  public string Session1{ get; } = session1;
  public string Session2{ get; } = session2;
  public string Session3{ get; } = session3;
  public string Session4{ get; } = session4;
  public string Session5{ get; } = session5;
  public string Session6{ get; } = session6;
  public string Session7{ get; } = session7;
  public string Session8{ get; } = session8;
  public string Session9{ get; } = session9;
  public string Session10{ get; } = session10;
  public bool Notattending{ get; } = notattending;
}
}
}
