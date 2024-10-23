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
/// CREATE TABLE [ScoreLanes]
/// (
/// [lane_00] Boolean NOT NULL,
/// [lane_01] Boolean NOT NULL,
/// [lane_02] Boolean NOT NULL,
/// [lane_03] Boolean NOT NULL,
/// [lane_04] Boolean NOT NULL,
/// [lane_05] Boolean NOT NULL,
/// [lane_06] Boolean NOT NULL,
/// [lane_07] Boolean NOT NULL,
/// [lane_08] Boolean NOT NULL,
/// [lane_09] Boolean NOT NULL,
/// [lane_10] Boolean NOT NULL,
/// [lane_11] Boolean NOT NULL,
/// [lane_12] Boolean NOT NULL
/// );

public class MmScorelanes 
{
List<MmScorelanes> get(OdbcConnection connection)
{
  var collection = new List<MmScorelanes>();
  string query = "select * from ScoreLanes";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetBoolean(1); /* lane_00 */
      var arg1 = reader.GetBoolean(2); /* lane_01 */
      var arg2 = reader.GetBoolean(3); /* lane_02 */
      var arg3 = reader.GetBoolean(4); /* lane_03 */
      var arg4 = reader.GetBoolean(5); /* lane_04 */
      var arg5 = reader.GetBoolean(6); /* lane_05 */
      var arg6 = reader.GetBoolean(7); /* lane_06 */
      var arg7 = reader.GetBoolean(8); /* lane_07 */
      var arg8 = reader.GetBoolean(9); /* lane_08 */
      var arg9 = reader.GetBoolean(10); /* lane_09 */
      var arg10 = reader.GetBoolean(11); /* lane_10 */
      var arg11 = reader.GetBoolean(12); /* lane_11 */
      var arg12 = reader.GetBoolean(13); /* lane_12 */
      collection.Add( new MmScorelanes(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
    }
  }
  return collection;
}
  // Properties
  public bool Lane_00{ get; }
  public bool Lane_01{ get; }
  public bool Lane_02{ get; }
  public bool Lane_03{ get; }
  public bool Lane_04{ get; }
  public bool Lane_05{ get; }
  public bool Lane_06{ get; }
  public bool Lane_07{ get; }
  public bool Lane_08{ get; }
  public bool Lane_09{ get; }
  public bool Lane_10{ get; }
  public bool Lane_11{ get; }
  public bool Lane_12{ get; }
  // Constructor
  MmScorelanes(bool lane_00, bool lane_01, bool lane_02, bool lane_03, bool lane_04, bool lane_05, bool lane_06, bool lane_07, bool lane_08, bool lane_09, bool lane_10, bool lane_11, bool lane_12 )
  {
    Lane_00 = lane_00;
    Lane_01 = lane_01;
    Lane_02 = lane_02;
    Lane_03 = lane_03;
    Lane_04 = lane_04;
    Lane_05 = lane_05;
    Lane_06 = lane_06;
    Lane_07 = lane_07;
    Lane_08 = lane_08;
    Lane_09 = lane_09;
    Lane_10 = lane_10;
    Lane_11 = lane_11;
    Lane_12 = lane_12;
  }
}
