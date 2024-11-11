using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [StdLanes]
/// // (
/// // [tot_lanes] Integer,
/// // [order_01] Integer,
/// // [order_02] Integer,
/// // [order_03] Integer,
/// // [order_04] Integer,
/// // [order_05] Integer,
/// // [order_06] Integer,
/// // [order_07] Integer,
/// // [order_08] Integer,
/// // [order_09] Integer,
/// // [order_10] Integer,
/// // [order_11] Integer,
/// // [order_12] Integer
/// // );

public class Stdlanes(short? tot_lanes, short? order_01, short? order_02, short? order_03, short? order_04, short? order_05, short? order_06, short? order_07, short? order_08, short? order_09, short? order_10, short? order_11, short? order_12 )
{
static public List<Stdlanes> Get(OdbcConnection connection)
{
  var collection = new List<Stdlanes>();
  string query = "select * from StdLanes";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* tot_lanes nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* order_01 nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* order_02 nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* order_03 nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* order_04 nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* order_05 nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* order_06 nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* order_07 nullable true*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* order_08 nullable true*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* order_09 nullable true*/
  var arg10 = reader.IsDBNull(10) ? (short?)null :reader.GetInt16(10); /* order_10 nullable true*/
  var arg11 = reader.IsDBNull(11) ? (short?)null :reader.GetInt16(11); /* order_11 nullable true*/
  var arg12 = reader.IsDBNull(12) ? (short?)null :reader.GetInt16(12); /* order_12 nullable true*/
      collection.Add( new Stdlanes(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
    }
  }
  return collection;
}
  // Properties
  public short? Tot_lanes{ get; } = tot_lanes;
  public short? Order_01{ get; } = order_01;
  public short? Order_02{ get; } = order_02;
  public short? Order_03{ get; } = order_03;
  public short? Order_04{ get; } = order_04;
  public short? Order_05{ get; } = order_05;
  public short? Order_06{ get; } = order_06;
  public short? Order_07{ get; } = order_07;
  public short? Order_08{ get; } = order_08;
  public short? Order_09{ get; } = order_09;
  public short? Order_10{ get; } = order_10;
  public short? Order_11{ get; } = order_11;
  public short? Order_12{ get; } = order_12;
}
}
}
