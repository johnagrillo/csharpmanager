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
/// CREATE TABLE [Masters]
/// (
/// [timer_type] Integer,
/// [pool_name] Text (90),
/// [pool_city] Text (40),
/// [pool_state] Text (6),
/// [pool_lmsc] Text (6),
/// [Meet_type] Integer,
/// [ref_name] Text (80),
/// [sub_name] Text (80),
/// [sub_address] Text (80),
/// [sub_city] Text (40),
/// [sub_state] Text (6),
/// [sub_zip] Text (20),
/// [sub_phone] Text (40),
/// [sub_email] Text (100),
/// [sendto_name] Text (80),
/// [sendto_address] Text (80),
/// [sendto_city] Text (40),
/// [sendto_state] Text (6),
/// [sendto_zip] Text (20),
/// [sendto_email] Text (100),
/// [record_name] Text (24)
/// );

public class MmMasters 
{
List<MmMasters> get(OdbcConnection connection)
{
  var collection = new List<MmMasters>();
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
      var arg0 = reader.GetInt16(1); /* timer_type */
      var arg1 = reader.GetTextReader(2).ToString(); /* pool_name */
      var arg2 = reader.GetTextReader(3).ToString(); /* pool_city */
      var arg3 = reader.GetTextReader(4).ToString(); /* pool_state */
      var arg4 = reader.GetTextReader(5).ToString(); /* pool_lmsc */
      var arg5 = reader.GetInt16(6); /* Meet_type */
      var arg6 = reader.GetTextReader(7).ToString(); /* ref_name */
      var arg7 = reader.GetTextReader(8).ToString(); /* sub_name */
      var arg8 = reader.GetTextReader(9).ToString(); /* sub_address */
      var arg9 = reader.GetTextReader(10).ToString(); /* sub_city */
      var arg10 = reader.GetTextReader(11).ToString(); /* sub_state */
      var arg11 = reader.GetTextReader(12).ToString(); /* sub_zip */
      var arg12 = reader.GetTextReader(13).ToString(); /* sub_phone */
      var arg13 = reader.GetTextReader(14).ToString(); /* sub_email */
      var arg14 = reader.GetTextReader(15).ToString(); /* sendto_name */
      var arg15 = reader.GetTextReader(16).ToString(); /* sendto_address */
      var arg16 = reader.GetTextReader(17).ToString(); /* sendto_city */
      var arg17 = reader.GetTextReader(18).ToString(); /* sendto_state */
      var arg18 = reader.GetTextReader(19).ToString(); /* sendto_zip */
      var arg19 = reader.GetTextReader(20).ToString(); /* sendto_email */
      var arg20 = reader.GetTextReader(21).ToString(); /* record_name */
      collection.Add( new MmMasters(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20));
    }
  }
  return collection;
}
  // Properties
  public short Timer_type{ get; }
  public string Pool_name{ get; }
  public string Pool_city{ get; }
  public string Pool_state{ get; }
  public string Pool_lmsc{ get; }
  public short MeetType{ get; }
  public string Ref_name{ get; }
  public string Sub_name{ get; }
  public string Sub_address{ get; }
  public string Sub_city{ get; }
  public string Sub_state{ get; }
  public string Sub_zip{ get; }
  public string Sub_phone{ get; }
  public string Sub_email{ get; }
  public string Sendto_name{ get; }
  public string Sendto_address{ get; }
  public string Sendto_city{ get; }
  public string Sendto_state{ get; }
  public string Sendto_zip{ get; }
  public string Sendto_email{ get; }
  public string Record_name{ get; }
  // Constructor
  MmMasters(short timer_type, string pool_name, string pool_city, string pool_state, string pool_lmsc, short meetType, string ref_name, string sub_name, string sub_address, string sub_city, string sub_state, string sub_zip, string sub_phone, string sub_email, string sendto_name, string sendto_address, string sendto_city, string sendto_state, string sendto_zip, string sendto_email, string record_name )
  {
    Timer_type = timer_type;
    Pool_name = pool_name;
    Pool_city = pool_city;
    Pool_state = pool_state;
    Pool_lmsc = pool_lmsc;
    MeetType = meetType;
    Ref_name = ref_name;
    Sub_name = sub_name;
    Sub_address = sub_address;
    Sub_city = sub_city;
    Sub_state = sub_state;
    Sub_zip = sub_zip;
    Sub_phone = sub_phone;
    Sub_email = sub_email;
    Sendto_name = sendto_name;
    Sendto_address = sendto_address;
    Sendto_city = sendto_city;
    Sendto_state = sendto_state;
    Sendto_zip = sendto_zip;
    Sendto_email = sendto_email;
    Record_name = record_name;
  }
}
