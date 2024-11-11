using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [RecordsApp]
/// // (
/// // [timer_type] Integer,
/// // [app_title] Text (180),
/// // [app_date] Text (22),
/// // [sendto_name] Text (80),
/// // [sendto_address1] Text (80),
/// // [sendto_address2] Text (80),
/// // [sendto_city] Text (40),
/// // [sendto_state] Text (6),
/// // [sendto_zip] Text (20),
/// // [sendto_email] Text (100),
/// // [record_name] Text (24),
/// // [app_topnote1] Text (220),
/// // [app_bottomnote1] Text (220),
/// // [app_topnote2] Text (220),
/// // [app_bottomnote2] Text (220),
/// // [app_topnote3] Text (220),
/// // [app_bottomnote3] Text (220),
/// // [app_topnote4] Text (220),
/// // [app_bottomnote4] Text (220),
/// // [referree_name] Text (80),
/// // [adminref_name] Text (80)
/// // );

public class Recordsapp(short? timer_type, string app_title, string app_date, string sendto_name, string sendto_address1, string sendto_address2, string sendto_city, string sendto_state, string sendto_zip, string sendto_email, string record_name, string app_topnote1, string app_bottomnote1, string app_topnote2, string app_bottomnote2, string app_topnote3, string app_bottomnote3, string app_topnote4, string app_bottomnote4, string referree_name, string adminref_name )
{
static public List<Recordsapp> Get(OdbcConnection connection)
{
  var collection = new List<Recordsapp>();
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
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* timer_type nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* app_title nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* app_date nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* sendto_name nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* sendto_address1 nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* sendto_address2 nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* sendto_city nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* sendto_state nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* sendto_zip nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* sendto_email nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* record_name nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* app_topnote1 nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* app_bottomnote1 nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* app_topnote2 nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* app_bottomnote2 nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* app_topnote3 nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* app_bottomnote3 nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* app_topnote4 nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* app_bottomnote4 nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* referree_name nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* adminref_name nullable false*/
      collection.Add( new Recordsapp(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20));
    }
  }
  return collection;
}
  // Properties
  public short? Timer_type{ get; } = timer_type;
  public string App_title{ get; } = app_title;
  public string App_date{ get; } = app_date;
  public string Sendto_name{ get; } = sendto_name;
  public string Sendto_address1{ get; } = sendto_address1;
  public string Sendto_address2{ get; } = sendto_address2;
  public string Sendto_city{ get; } = sendto_city;
  public string Sendto_state{ get; } = sendto_state;
  public string Sendto_zip{ get; } = sendto_zip;
  public string Sendto_email{ get; } = sendto_email;
  public string Record_name{ get; } = record_name;
  public string App_topnote1{ get; } = app_topnote1;
  public string App_bottomnote1{ get; } = app_bottomnote1;
  public string App_topnote2{ get; } = app_topnote2;
  public string App_bottomnote2{ get; } = app_bottomnote2;
  public string App_topnote3{ get; } = app_topnote3;
  public string App_bottomnote3{ get; } = app_bottomnote3;
  public string App_topnote4{ get; } = app_topnote4;
  public string App_bottomnote4{ get; } = app_bottomnote4;
  public string Referree_name{ get; } = referree_name;
  public string Adminref_name{ get; } = adminref_name;
}
}
}
