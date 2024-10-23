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
/// CREATE TABLE [StdLanes]
/// (
/// [tot_lanes] Integer,
/// [order_01] Integer,
/// [order_02] Integer,
/// [order_03] Integer,
/// [order_04] Integer,
/// [order_05] Integer,
/// [order_06] Integer,
/// [order_07] Integer,
/// [order_08] Integer,
/// [order_09] Integer,
/// [order_10] Integer,
/// [order_11] Integer,
/// [order_12] Integer
/// );

public class MmStdlanes 
{
List<MmStdlanes> get(OdbcConnection connection)
{
  var collection = new List<MmStdlanes>();
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
      var arg0 = reader.GetInt16(1); /* tot_lanes */
      var arg1 = reader.GetInt16(2); /* order_01 */
      var arg2 = reader.GetInt16(3); /* order_02 */
      var arg3 = reader.GetInt16(4); /* order_03 */
      var arg4 = reader.GetInt16(5); /* order_04 */
      var arg5 = reader.GetInt16(6); /* order_05 */
      var arg6 = reader.GetInt16(7); /* order_06 */
      var arg7 = reader.GetInt16(8); /* order_07 */
      var arg8 = reader.GetInt16(9); /* order_08 */
      var arg9 = reader.GetInt16(10); /* order_09 */
      var arg10 = reader.GetInt16(11); /* order_10 */
      var arg11 = reader.GetInt16(12); /* order_11 */
      var arg12 = reader.GetInt16(13); /* order_12 */
      collection.Add( new MmStdlanes(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
    }
  }
  return collection;
}
  // Properties
  public short Tot_lanes{ get; }
  public short Order_01{ get; }
  public short Order_02{ get; }
  public short Order_03{ get; }
  public short Order_04{ get; }
  public short Order_05{ get; }
  public short Order_06{ get; }
  public short Order_07{ get; }
  public short Order_08{ get; }
  public short Order_09{ get; }
  public short Order_10{ get; }
  public short Order_11{ get; }
  public short Order_12{ get; }
  // Constructor
  MmStdlanes(short tot_lanes, short order_01, short order_02, short order_03, short order_04, short order_05, short order_06, short order_07, short order_08, short order_09, short order_10, short order_11, short order_12 )
  {
    Tot_lanes = tot_lanes;
    Order_01 = order_01;
    Order_02 = order_02;
    Order_03 = order_03;
    Order_04 = order_04;
    Order_05 = order_05;
    Order_06 = order_06;
    Order_07 = order_07;
    Order_08 = order_08;
    Order_09 = order_09;
    Order_10 = order_10;
    Order_11 = order_11;
    Order_12 = order_12;
  }
}
