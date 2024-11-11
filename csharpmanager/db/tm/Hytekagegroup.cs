using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [HYTEKAGEGROUP]
/// // (
/// // [AgType] Integer,
/// // [Lo_Hi] Integer,
/// // [Course] Text (2),
/// // [F125] Boolean NOT NULL,
/// // [F150] Boolean NOT NULL,
/// // [F1100] Boolean NOT NULL,
/// // [F1200] Boolean NOT NULL,
/// // [F1400] Boolean NOT NULL,
/// // [F1500] Boolean NOT NULL,
/// // [F1800] Boolean NOT NULL,
/// // [F11000] Boolean NOT NULL,
/// // [F11500] Boolean NOT NULL,
/// // [F11650] Boolean NOT NULL,
/// // [F225] Boolean NOT NULL,
/// // [F250] Boolean NOT NULL,
/// // [F2100] Boolean NOT NULL,
/// // [F2200] Boolean NOT NULL,
/// // [F325] Boolean NOT NULL,
/// // [F350] Boolean NOT NULL,
/// // [F3100] Boolean NOT NULL,
/// // [F3200] Boolean NOT NULL,
/// // [F425] Boolean NOT NULL,
/// // [F450] Boolean NOT NULL,
/// // [F4100] Boolean NOT NULL,
/// // [F4200] Boolean NOT NULL,
/// // [F5100] Boolean NOT NULL,
/// // [F5200] Boolean NOT NULL,
/// // [F5400] Boolean NOT NULL
/// // );

public class Hytekagegroup(short? agType, short? loHi, string course, bool f125, bool f150, bool f1100, bool f1200, bool f1400, bool f1500, bool f1800, bool f11000, bool f11500, bool f11650, bool f225, bool f250, bool f2100, bool f2200, bool f325, bool f350, bool f3100, bool f3200, bool f425, bool f450, bool f4100, bool f4200, bool f5100, bool f5200, bool f5400 )
{
static public List<Hytekagegroup> Get(OdbcConnection connection)
{
  var collection = new List<Hytekagegroup>();
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
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* AgType nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Lo_Hi nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Course nullable false*/
  var arg3 = reader.GetBoolean(3); /* F125 nullable false*/
  var arg4 = reader.GetBoolean(4); /* F150 nullable false*/
  var arg5 = reader.GetBoolean(5); /* F1100 nullable false*/
  var arg6 = reader.GetBoolean(6); /* F1200 nullable false*/
  var arg7 = reader.GetBoolean(7); /* F1400 nullable false*/
  var arg8 = reader.GetBoolean(8); /* F1500 nullable false*/
  var arg9 = reader.GetBoolean(9); /* F1800 nullable false*/
  var arg10 = reader.GetBoolean(10); /* F11000 nullable false*/
  var arg11 = reader.GetBoolean(11); /* F11500 nullable false*/
  var arg12 = reader.GetBoolean(12); /* F11650 nullable false*/
  var arg13 = reader.GetBoolean(13); /* F225 nullable false*/
  var arg14 = reader.GetBoolean(14); /* F250 nullable false*/
  var arg15 = reader.GetBoolean(15); /* F2100 nullable false*/
  var arg16 = reader.GetBoolean(16); /* F2200 nullable false*/
  var arg17 = reader.GetBoolean(17); /* F325 nullable false*/
  var arg18 = reader.GetBoolean(18); /* F350 nullable false*/
  var arg19 = reader.GetBoolean(19); /* F3100 nullable false*/
  var arg20 = reader.GetBoolean(20); /* F3200 nullable false*/
  var arg21 = reader.GetBoolean(21); /* F425 nullable false*/
  var arg22 = reader.GetBoolean(22); /* F450 nullable false*/
  var arg23 = reader.GetBoolean(23); /* F4100 nullable false*/
  var arg24 = reader.GetBoolean(24); /* F4200 nullable false*/
  var arg25 = reader.GetBoolean(25); /* F5100 nullable false*/
  var arg26 = reader.GetBoolean(26); /* F5200 nullable false*/
  var arg27 = reader.GetBoolean(27); /* F5400 nullable false*/
      collection.Add( new Hytekagegroup(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27));
    }
  }
  return collection;
}
  // Properties
  public short? AgType{ get; } = agType;
  public short? LoHi{ get; } = loHi;
  public string Course{ get; } = course;
  public bool F125{ get; } = f125;
  public bool F150{ get; } = f150;
  public bool F1100{ get; } = f1100;
  public bool F1200{ get; } = f1200;
  public bool F1400{ get; } = f1400;
  public bool F1500{ get; } = f1500;
  public bool F1800{ get; } = f1800;
  public bool F11000{ get; } = f11000;
  public bool F11500{ get; } = f11500;
  public bool F11650{ get; } = f11650;
  public bool F225{ get; } = f225;
  public bool F250{ get; } = f250;
  public bool F2100{ get; } = f2100;
  public bool F2200{ get; } = f2200;
  public bool F325{ get; } = f325;
  public bool F350{ get; } = f350;
  public bool F3100{ get; } = f3100;
  public bool F3200{ get; } = f3200;
  public bool F425{ get; } = f425;
  public bool F450{ get; } = f450;
  public bool F4100{ get; } = f4100;
  public bool F4200{ get; } = f4200;
  public bool F5100{ get; } = f5100;
  public bool F5200{ get; } = f5200;
  public bool F5400{ get; } = f5400;
}
}
}
