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
/// CREATE TABLE [RecordsApp]
/// (
/// [timer_type] Integer,
/// [app_title] Text (180),
/// [app_date] Text (22),
/// [sendto_name] Text (80),
/// [sendto_address1] Text (80),
/// [sendto_address2] Text (80),
/// [sendto_city] Text (40),
/// [sendto_state] Text (6),
/// [sendto_zip] Text (20),
/// [sendto_email] Text (100),
/// [record_name] Text (24),
/// [app_topnote1] Text (220),
/// [app_bottomnote1] Text (220),
/// [app_topnote2] Text (220),
/// [app_bottomnote2] Text (220),
/// [app_topnote3] Text (220),
/// [app_bottomnote3] Text (220),
/// [app_topnote4] Text (220),
/// [app_bottomnote4] Text (220),
/// [referree_name] Text (80),
/// [adminref_name] Text (80)
/// );

public class MmRecordsapp 
{
List<MmRecordsapp> get(OdbcConnection connection)
{
  var collection = new List<MmRecordsapp>();
  string query = "select * from RecordsApp";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* timer_type */
      var arg1 = reader.GetTextReader(2).ToString(); /* app_title */
      var arg2 = reader.GetTextReader(3).ToString(); /* app_date */
      var arg3 = reader.GetTextReader(4).ToString(); /* sendto_name */
      var arg4 = reader.GetTextReader(5).ToString(); /* sendto_address1 */
      var arg5 = reader.GetTextReader(6).ToString(); /* sendto_address2 */
      var arg6 = reader.GetTextReader(7).ToString(); /* sendto_city */
      var arg7 = reader.GetTextReader(8).ToString(); /* sendto_state */
      var arg8 = reader.GetTextReader(9).ToString(); /* sendto_zip */
      var arg9 = reader.GetTextReader(10).ToString(); /* sendto_email */
      var arg10 = reader.GetTextReader(11).ToString(); /* record_name */
      var arg11 = reader.GetTextReader(12).ToString(); /* app_topnote1 */
      var arg12 = reader.GetTextReader(13).ToString(); /* app_bottomnote1 */
      var arg13 = reader.GetTextReader(14).ToString(); /* app_topnote2 */
      var arg14 = reader.GetTextReader(15).ToString(); /* app_bottomnote2 */
      var arg15 = reader.GetTextReader(16).ToString(); /* app_topnote3 */
      var arg16 = reader.GetTextReader(17).ToString(); /* app_bottomnote3 */
      var arg17 = reader.GetTextReader(18).ToString(); /* app_topnote4 */
      var arg18 = reader.GetTextReader(19).ToString(); /* app_bottomnote4 */
      var arg19 = reader.GetTextReader(20).ToString(); /* referree_name */
      var arg20 = reader.GetTextReader(21).ToString(); /* adminref_name */
      collection.Add( new MmRecordsapp(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20));
    }
  }
  return collection;
}
  // Properties
  public short Timer_type{ get; }
  public string App_title{ get; }
  public string App_date{ get; }
  public string Sendto_name{ get; }
  public string Sendto_address1{ get; }
  public string Sendto_address2{ get; }
  public string Sendto_city{ get; }
  public string Sendto_state{ get; }
  public string Sendto_zip{ get; }
  public string Sendto_email{ get; }
  public string Record_name{ get; }
  public string App_topnote1{ get; }
  public string App_bottomnote1{ get; }
  public string App_topnote2{ get; }
  public string App_bottomnote2{ get; }
  public string App_topnote3{ get; }
  public string App_bottomnote3{ get; }
  public string App_topnote4{ get; }
  public string App_bottomnote4{ get; }
  public string Referree_name{ get; }
  public string Adminref_name{ get; }
  // Constructor
  MmRecordsapp(short timer_type, string app_title, string app_date, string sendto_name, string sendto_address1, string sendto_address2, string sendto_city, string sendto_state, string sendto_zip, string sendto_email, string record_name, string app_topnote1, string app_bottomnote1, string app_topnote2, string app_bottomnote2, string app_topnote3, string app_bottomnote3, string app_topnote4, string app_bottomnote4, string referree_name, string adminref_name )
  {
    Timer_type = timer_type;
    App_title = app_title;
    App_date = app_date;
    Sendto_name = sendto_name;
    Sendto_address1 = sendto_address1;
    Sendto_address2 = sendto_address2;
    Sendto_city = sendto_city;
    Sendto_state = sendto_state;
    Sendto_zip = sendto_zip;
    Sendto_email = sendto_email;
    Record_name = record_name;
    App_topnote1 = app_topnote1;
    App_bottomnote1 = app_bottomnote1;
    App_topnote2 = app_topnote2;
    App_bottomnote2 = app_bottomnote2;
    App_topnote3 = app_topnote3;
    App_bottomnote3 = app_bottomnote3;
    App_topnote4 = app_topnote4;
    App_bottomnote4 = app_bottomnote4;
    Referree_name = referree_name;
    Adminref_name = adminref_name;
  }
}
