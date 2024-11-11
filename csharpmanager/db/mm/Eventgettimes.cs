using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [EventGetTimes]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Heat_no] Integer,
/// // [Vendor_abbr] Text (10),
/// // [Race_number] Text (12),
/// // [Get_Date] DateTime,
/// // [Get_Time] Long Integer,
/// // [Now_Date] DateTime,
/// // [Now_Time] Long Integer,
/// // [Rnd_ltr] Text (2)
/// // );

public class Eventgettimes(long? eventPtr, short? heatNo, string vendorAbbr, string raceNumber, DateTime? getDate, long? getTime, DateTime? nowDate, long? nowTime, string rndLtr )
{
static public List<Eventgettimes> Get(OdbcConnection connection)
{
  var collection = new List<Eventgettimes>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Event_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Heat_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Vendor_abbr nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Race_number nullable false*/
  var arg4 = reader.IsDBNull(4) ? (DateTime?)null :reader.GetDateTime(4); /* Get_Date nullable true*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* Get_Time nullable true*/
  var arg6 = reader.IsDBNull(6) ? (DateTime?)null :reader.GetDateTime(6); /* Now_Date nullable true*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* Now_Time nullable true*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Rnd_ltr nullable false*/
      collection.Add( new Eventgettimes(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public short? HeatNo{ get; } = heatNo;
  public string VendorAbbr{ get; } = vendorAbbr;
  public string RaceNumber{ get; } = raceNumber;
  public DateTime? GetDate{ get; } = getDate;
  public long? GetTime{ get; } = getTime;
  public DateTime? NowDate{ get; } = nowDate;
  public long? NowTime{ get; } = nowTime;
  public string RndLtr{ get; } = rndLtr;
}
}
}
