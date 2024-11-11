using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [ScoreLanes]
/// // (
/// // [lane_00] Boolean NOT NULL,
/// // [lane_01] Boolean NOT NULL,
/// // [lane_02] Boolean NOT NULL,
/// // [lane_03] Boolean NOT NULL,
/// // [lane_04] Boolean NOT NULL,
/// // [lane_05] Boolean NOT NULL,
/// // [lane_06] Boolean NOT NULL,
/// // [lane_07] Boolean NOT NULL,
/// // [lane_08] Boolean NOT NULL,
/// // [lane_09] Boolean NOT NULL,
/// // [lane_10] Boolean NOT NULL,
/// // [lane_11] Boolean NOT NULL,
/// // [lane_12] Boolean NOT NULL
/// // );

public class Scorelanes(bool lane_00, bool lane_01, bool lane_02, bool lane_03, bool lane_04, bool lane_05, bool lane_06, bool lane_07, bool lane_08, bool lane_09, bool lane_10, bool lane_11, bool lane_12 )
{
static public List<Scorelanes> Get(OdbcConnection connection)
{
  var collection = new List<Scorelanes>();
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
  var arg0 = reader.GetBoolean(0); /* lane_00 nullable false*/
  var arg1 = reader.GetBoolean(1); /* lane_01 nullable false*/
  var arg2 = reader.GetBoolean(2); /* lane_02 nullable false*/
  var arg3 = reader.GetBoolean(3); /* lane_03 nullable false*/
  var arg4 = reader.GetBoolean(4); /* lane_04 nullable false*/
  var arg5 = reader.GetBoolean(5); /* lane_05 nullable false*/
  var arg6 = reader.GetBoolean(6); /* lane_06 nullable false*/
  var arg7 = reader.GetBoolean(7); /* lane_07 nullable false*/
  var arg8 = reader.GetBoolean(8); /* lane_08 nullable false*/
  var arg9 = reader.GetBoolean(9); /* lane_09 nullable false*/
  var arg10 = reader.GetBoolean(10); /* lane_10 nullable false*/
  var arg11 = reader.GetBoolean(11); /* lane_11 nullable false*/
  var arg12 = reader.GetBoolean(12); /* lane_12 nullable false*/
      collection.Add( new Scorelanes(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12));
    }
  }
  return collection;
}
  // Properties
  public bool Lane_00{ get; } = lane_00;
  public bool Lane_01{ get; } = lane_01;
  public bool Lane_02{ get; } = lane_02;
  public bool Lane_03{ get; } = lane_03;
  public bool Lane_04{ get; } = lane_04;
  public bool Lane_05{ get; } = lane_05;
  public bool Lane_06{ get; } = lane_06;
  public bool Lane_07{ get; } = lane_07;
  public bool Lane_08{ get; } = lane_08;
  public bool Lane_09{ get; } = lane_09;
  public bool Lane_10{ get; } = lane_10;
  public bool Lane_11{ get; } = lane_11;
  public bool Lane_12{ get; } = lane_12;
}
}
}
