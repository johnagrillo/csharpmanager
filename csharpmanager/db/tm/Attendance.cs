using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [Attendance]
/// // (
/// // [athlete] Long Integer,
/// // [attend_date] DateTime,
/// // [morn_aft] Text (2),
/// // [attn_stat] Text (2),
/// // [actual_dist] Long Integer,
/// // [yd_mtr] Text (2)
/// // );

public class Attendance(long? athlete, DateTime? attend_date, string morn_aft, string attn_stat, long? actual_dist, string yd_mtr )
{
static public List<Attendance> Get(OdbcConnection connection)
{
  var collection = new List<Attendance>();
  string query = "select * from Attendance";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* athlete nullable true*/
  var arg1 = reader.IsDBNull(1) ? (DateTime?)null :reader.GetDateTime(1); /* attend_date nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* morn_aft nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* attn_stat nullable false*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* actual_dist nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* yd_mtr nullable false*/
      collection.Add( new Attendance(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long? Athlete{ get; } = athlete;
  public DateTime? Attend_date{ get; } = attend_date;
  public string Morn_aft{ get; } = morn_aft;
  public string Attn_stat{ get; } = attn_stat;
  public long? Actual_dist{ get; } = actual_dist;
  public string Yd_mtr{ get; } = yd_mtr;
}
}
}
