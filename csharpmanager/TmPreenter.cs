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
/// CREATE TABLE [PREENTER]
/// (
/// [THEATHLETE] Long Integer,
/// [THEMEET] Long Integer,
/// [PREENTERED] Boolean NOT NULL,
/// [SESSION1] Text (6),
/// [SESSION2] Text (6),
/// [SESSION3] Text (6),
/// [SESSION4] Text (6),
/// [SESSION5] Text (6),
/// [SESSION6] Text (6),
/// [SESSION7] Text (6),
/// [SESSION8] Text (6),
/// [SESSION9] Text (6),
/// [SESSION10] Text (6),
/// [NOTATTENDING] Boolean NOT NULL
/// );

public class TmPreenter 
{
List<TmPreenter> get(OdbcConnection connection)
{
  var collection = new List<TmPreenter>();
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
      var arg0 = reader.GetInt64(1); /* THEATHLETE */
      var arg1 = reader.GetInt64(2); /* THEMEET */
      var arg2 = reader.GetBoolean(3); /* PREENTERED */
      var arg3 = reader.GetTextReader(4).ToString(); /* SESSION1 */
      var arg4 = reader.GetTextReader(5).ToString(); /* SESSION2 */
      var arg5 = reader.GetTextReader(6).ToString(); /* SESSION3 */
      var arg6 = reader.GetTextReader(7).ToString(); /* SESSION4 */
      var arg7 = reader.GetTextReader(8).ToString(); /* SESSION5 */
      var arg8 = reader.GetTextReader(9).ToString(); /* SESSION6 */
      var arg9 = reader.GetTextReader(10).ToString(); /* SESSION7 */
      var arg10 = reader.GetTextReader(11).ToString(); /* SESSION8 */
      var arg11 = reader.GetTextReader(12).ToString(); /* SESSION9 */
      var arg12 = reader.GetTextReader(13).ToString(); /* SESSION10 */
      var arg13 = reader.GetBoolean(14); /* NOTATTENDING */
      collection.Add( new TmPreenter(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13));
    }
  }
  return collection;
}
  // Properties
  public long Theathlete{ get; }
  public long Themeet{ get; }
  public bool Preentered{ get; }
  public string Session1{ get; }
  public string Session2{ get; }
  public string Session3{ get; }
  public string Session4{ get; }
  public string Session5{ get; }
  public string Session6{ get; }
  public string Session7{ get; }
  public string Session8{ get; }
  public string Session9{ get; }
  public string Session10{ get; }
  public bool Notattending{ get; }
  // Constructor
  TmPreenter(long theathlete, long themeet, bool preentered, string session1, string session2, string session3, string session4, string session5, string session6, string session7, string session8, string session9, string session10, bool notattending )
  {
    Theathlete = theathlete;
    Themeet = themeet;
    Preentered = preentered;
    Session1 = session1;
    Session2 = session2;
    Session3 = session3;
    Session4 = session4;
    Session5 = session5;
    Session6 = session6;
    Session7 = session7;
    Session8 = session8;
    Session9 = session9;
    Session10 = session10;
    Notattending = notattending;
  }
}
