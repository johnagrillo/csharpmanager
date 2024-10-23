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
/// CREATE TABLE [EventGetTimes]
/// (
/// [Event_ptr] Long Integer,
/// [Heat_no] Integer,
/// [Vendor_abbr] Text (10),
/// [Race_number] Text (12),
/// [Get_Date] DateTime,
/// [Get_Time] Long Integer,
/// [Now_Date] DateTime,
/// [Now_Time] Long Integer,
/// [Rnd_ltr] Text (2)
/// );

public class MmEventgettimes 
{
List<MmEventgettimes> get(OdbcConnection connection)
{
  var collection = new List<MmEventgettimes>();
  string query = "select * from EventGetTimes";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt16(2); /* Heat_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* Vendor_abbr */
      var arg3 = reader.GetTextReader(4).ToString(); /* Race_number */
      var arg4 = reader.GetDateTime(5); /* Get_Date */
      var arg5 = reader.GetInt64(6); /* Get_Time */
      var arg6 = reader.GetDateTime(7); /* Now_Date */
      var arg7 = reader.GetInt64(8); /* Now_Time */
      var arg8 = reader.GetTextReader(9).ToString(); /* Rnd_ltr */
      collection.Add( new MmEventgettimes(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public short HeatNo{ get; }
  public string VendorAbbr{ get; }
  public string RaceNumber{ get; }
  public DateTime GetDate{ get; }
  public long GetTime{ get; }
  public DateTime NowDate{ get; }
  public long NowTime{ get; }
  public string RndLtr{ get; }
  // Constructor
  MmEventgettimes(long eventPtr, short heatNo, string vendorAbbr, string raceNumber, DateTime getDate, long getTime, DateTime nowDate, long nowTime, string rndLtr )
  {
    EventPtr = eventPtr;
    HeatNo = heatNo;
    VendorAbbr = vendorAbbr;
    RaceNumber = raceNumber;
    GetDate = getDate;
    GetTime = getTime;
    NowDate = nowDate;
    NowTime = nowTime;
    RndLtr = rndLtr;
  }
}
