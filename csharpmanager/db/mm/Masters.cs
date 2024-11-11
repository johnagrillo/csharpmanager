using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Masters]
/// // (
/// // [timer_type] Integer,
/// // [pool_name] Text (90),
/// // [pool_city] Text (40),
/// // [pool_state] Text (6),
/// // [pool_lmsc] Text (6),
/// // [Meet_type] Integer,
/// // [ref_name] Text (80),
/// // [sub_name] Text (80),
/// // [sub_address] Text (80),
/// // [sub_city] Text (40),
/// // [sub_state] Text (6),
/// // [sub_zip] Text (20),
/// // [sub_phone] Text (40),
/// // [sub_email] Text (100),
/// // [sendto_name] Text (80),
/// // [sendto_address] Text (80),
/// // [sendto_city] Text (40),
/// // [sendto_state] Text (6),
/// // [sendto_zip] Text (20),
/// // [sendto_email] Text (100),
/// // [record_name] Text (24)
/// // );

public class Masters(short? timer_type, string pool_name, string pool_city, string pool_state, string pool_lmsc, short? meetType, string ref_name, string sub_name, string sub_address, string sub_city, string sub_state, string sub_zip, string sub_phone, string sub_email, string sendto_name, string sendto_address, string sendto_city, string sendto_state, string sendto_zip, string sendto_email, string record_name )
{
static public List<Masters> Get(OdbcConnection connection)
{
  var collection = new List<Masters>();
  string query = "select * from Masters";
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
  var arg1 = reader.GetTextReader(1).ReadLine(); /* pool_name nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* pool_city nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* pool_state nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* pool_lmsc nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* Meet_type nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* ref_name nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* sub_name nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* sub_address nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* sub_city nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* sub_state nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* sub_zip nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* sub_phone nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* sub_email nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* sendto_name nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* sendto_address nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* sendto_city nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* sendto_state nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* sendto_zip nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* sendto_email nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* record_name nullable false*/
      collection.Add( new Masters(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20));
    }
  }
  return collection;
}
  // Properties
  public short? Timer_type{ get; } = timer_type;
  public string Pool_name{ get; } = pool_name;
  public string Pool_city{ get; } = pool_city;
  public string Pool_state{ get; } = pool_state;
  public string Pool_lmsc{ get; } = pool_lmsc;
  public short? MeetType{ get; } = meetType;
  public string Ref_name{ get; } = ref_name;
  public string Sub_name{ get; } = sub_name;
  public string Sub_address{ get; } = sub_address;
  public string Sub_city{ get; } = sub_city;
  public string Sub_state{ get; } = sub_state;
  public string Sub_zip{ get; } = sub_zip;
  public string Sub_phone{ get; } = sub_phone;
  public string Sub_email{ get; } = sub_email;
  public string Sendto_name{ get; } = sendto_name;
  public string Sendto_address{ get; } = sendto_address;
  public string Sendto_city{ get; } = sendto_city;
  public string Sendto_state{ get; } = sendto_state;
  public string Sendto_zip{ get; } = sendto_zip;
  public string Sendto_email{ get; } = sendto_email;
  public string Record_name{ get; } = record_name;
}
}
}
