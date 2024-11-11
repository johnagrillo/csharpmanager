using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [WkParam]
/// // (
/// // [wk_ptr] Long Integer,
/// // [wk_num] Long Integer,
/// // [wk_date] DateTime,
/// // [start_time] Long Integer,
/// // [rest_period] Integer,
/// // [group_abbr] Text (6),
/// // [subgroup_abbr] Text (6),
/// // [course_yls] Text (2),
/// // [tot_yards] Long Integer,
/// // [tot_stress] Long Integer,
/// // [ck_selected] Boolean NOT NULL
/// // );

public class Wkparam(long? wk_ptr, long? wk_num, DateTime? wk_date, long? start_time, short? rest_period, string group_abbr, string subgroup_abbr, string course_yls, long? tot_yards, long? tot_stress, bool ck_selected )
{
static public List<Wkparam> Get(OdbcConnection connection)
{
  var collection = new List<Wkparam>();
  string query = "select * from WkParam";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* wk_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* wk_num nullable true*/
  var arg2 = reader.IsDBNull(2) ? (DateTime?)null :reader.GetDateTime(2); /* wk_date nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* start_time nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* rest_period nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* group_abbr nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* subgroup_abbr nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* course_yls nullable false*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* tot_yards nullable true*/
  var arg9 = reader.IsDBNull(9) ? (long?)null :reader.GetInt32(9); /* tot_stress nullable true*/
  var arg10 = reader.GetBoolean(10); /* ck_selected nullable false*/
      collection.Add( new Wkparam(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
    }
  }
  return collection;
}
  // Properties
  public long? Wk_ptr{ get; } = wk_ptr;
  public long? Wk_num{ get; } = wk_num;
  public DateTime? Wk_date{ get; } = wk_date;
  public long? Start_time{ get; } = start_time;
  public short? Rest_period{ get; } = rest_period;
  public string Group_abbr{ get; } = group_abbr;
  public string Subgroup_abbr{ get; } = subgroup_abbr;
  public string Course_yls{ get; } = course_yls;
  public long? Tot_yards{ get; } = tot_yards;
  public long? Tot_stress{ get; } = tot_stress;
  public bool Ck_selected{ get; } = ck_selected;
}
}
}
