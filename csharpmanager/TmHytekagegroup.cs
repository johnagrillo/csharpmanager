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
/// CREATE TABLE [HYTEKAGEGROUP]
/// (
/// [AgType] Integer,
/// [Lo_Hi] Integer,
/// [Course] Text (2),
/// [F125] Boolean NOT NULL,
/// [F150] Boolean NOT NULL,
/// [F1100] Boolean NOT NULL,
/// [F1200] Boolean NOT NULL,
/// [F1400] Boolean NOT NULL,
/// [F1500] Boolean NOT NULL,
/// [F1800] Boolean NOT NULL,
/// [F11000] Boolean NOT NULL,
/// [F11500] Boolean NOT NULL,
/// [F11650] Boolean NOT NULL,
/// [F225] Boolean NOT NULL,
/// [F250] Boolean NOT NULL,
/// [F2100] Boolean NOT NULL,
/// [F2200] Boolean NOT NULL,
/// [F325] Boolean NOT NULL,
/// [F350] Boolean NOT NULL,
/// [F3100] Boolean NOT NULL,
/// [F3200] Boolean NOT NULL,
/// [F425] Boolean NOT NULL,
/// [F450] Boolean NOT NULL,
/// [F4100] Boolean NOT NULL,
/// [F4200] Boolean NOT NULL,
/// [F5100] Boolean NOT NULL,
/// [F5200] Boolean NOT NULL,
/// [F5400] Boolean NOT NULL
/// );

public class TmHytekagegroup 
{
List<TmHytekagegroup> get(OdbcConnection connection)
{
  var collection = new List<TmHytekagegroup>();
  string query = "select * from HYTEKAGEGROUP";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* AgType */
      var arg1 = reader.GetInt16(2); /* Lo_Hi */
      var arg2 = reader.GetTextReader(3).ToString(); /* Course */
      var arg3 = reader.GetBoolean(4); /* F125 */
      var arg4 = reader.GetBoolean(5); /* F150 */
      var arg5 = reader.GetBoolean(6); /* F1100 */
      var arg6 = reader.GetBoolean(7); /* F1200 */
      var arg7 = reader.GetBoolean(8); /* F1400 */
      var arg8 = reader.GetBoolean(9); /* F1500 */
      var arg9 = reader.GetBoolean(10); /* F1800 */
      var arg10 = reader.GetBoolean(11); /* F11000 */
      var arg11 = reader.GetBoolean(12); /* F11500 */
      var arg12 = reader.GetBoolean(13); /* F11650 */
      var arg13 = reader.GetBoolean(14); /* F225 */
      var arg14 = reader.GetBoolean(15); /* F250 */
      var arg15 = reader.GetBoolean(16); /* F2100 */
      var arg16 = reader.GetBoolean(17); /* F2200 */
      var arg17 = reader.GetBoolean(18); /* F325 */
      var arg18 = reader.GetBoolean(19); /* F350 */
      var arg19 = reader.GetBoolean(20); /* F3100 */
      var arg20 = reader.GetBoolean(21); /* F3200 */
      var arg21 = reader.GetBoolean(22); /* F425 */
      var arg22 = reader.GetBoolean(23); /* F450 */
      var arg23 = reader.GetBoolean(24); /* F4100 */
      var arg24 = reader.GetBoolean(25); /* F4200 */
      var arg25 = reader.GetBoolean(26); /* F5100 */
      var arg26 = reader.GetBoolean(27); /* F5200 */
      var arg27 = reader.GetBoolean(28); /* F5400 */
      collection.Add( new TmHytekagegroup(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27));
    }
  }
  return collection;
}
  // Properties
  public short AgType{ get; }
  public short LoHi{ get; }
  public string Course{ get; }
  public bool F125{ get; }
  public bool F150{ get; }
  public bool F1100{ get; }
  public bool F1200{ get; }
  public bool F1400{ get; }
  public bool F1500{ get; }
  public bool F1800{ get; }
  public bool F11000{ get; }
  public bool F11500{ get; }
  public bool F11650{ get; }
  public bool F225{ get; }
  public bool F250{ get; }
  public bool F2100{ get; }
  public bool F2200{ get; }
  public bool F325{ get; }
  public bool F350{ get; }
  public bool F3100{ get; }
  public bool F3200{ get; }
  public bool F425{ get; }
  public bool F450{ get; }
  public bool F4100{ get; }
  public bool F4200{ get; }
  public bool F5100{ get; }
  public bool F5200{ get; }
  public bool F5400{ get; }
  // Constructor
  TmHytekagegroup(short agType, short loHi, string course, bool f125, bool f150, bool f1100, bool f1200, bool f1400, bool f1500, bool f1800, bool f11000, bool f11500, bool f11650, bool f225, bool f250, bool f2100, bool f2200, bool f325, bool f350, bool f3100, bool f3200, bool f425, bool f450, bool f4100, bool f4200, bool f5100, bool f5200, bool f5400 )
  {
    AgType = agType;
    LoHi = loHi;
    Course = course;
    F125 = f125;
    F150 = f150;
    F1100 = f1100;
    F1200 = f1200;
    F1400 = f1400;
    F1500 = f1500;
    F1800 = f1800;
    F11000 = f11000;
    F11500 = f11500;
    F11650 = f11650;
    F225 = f225;
    F250 = f250;
    F2100 = f2100;
    F2200 = f2200;
    F325 = f325;
    F350 = f350;
    F3100 = f3100;
    F3200 = f3200;
    F425 = f425;
    F450 = f450;
    F4100 = f4100;
    F4200 = f4200;
    F5100 = f5100;
    F5200 = f5200;
    F5400 = f5400;
  }
}
