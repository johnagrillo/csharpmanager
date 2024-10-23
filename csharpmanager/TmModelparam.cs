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
/// CREATE TABLE [ModelParam]
/// (
/// [wk_ptr] Long Integer,
/// [wk_num] Long Integer,
/// [wk_date] DateTime,
/// [start_time] Long Integer,
/// [rest_period] Integer,
/// [group_abbr] Text (6),
/// [subgroup_abbr] Text (6),
/// [course_yls] Text (2),
/// [tot_yards] Long Integer,
/// [tot_stress] Long Integer,
/// [ck_selected] Boolean NOT NULL
/// );

public class TmModelparam 
{
List<TmModelparam> get(OdbcConnection connection)
{
  var collection = new List<TmModelparam>();
  string query = "select * from ModelParam";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* wk_ptr */
      var arg1 = reader.GetInt64(2); /* wk_num */
      var arg2 = reader.GetDateTime(3); /* wk_date */
      var arg3 = reader.GetInt64(4); /* start_time */
      var arg4 = reader.GetInt16(5); /* rest_period */
      var arg5 = reader.GetTextReader(6).ToString(); /* group_abbr */
      var arg6 = reader.GetTextReader(7).ToString(); /* subgroup_abbr */
      var arg7 = reader.GetTextReader(8).ToString(); /* course_yls */
      var arg8 = reader.GetInt64(9); /* tot_yards */
      var arg9 = reader.GetInt64(10); /* tot_stress */
      var arg10 = reader.GetBoolean(11); /* ck_selected */
      collection.Add( new TmModelparam(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10));
    }
  }
  return collection;
}
  // Properties
  public long Wk_ptr{ get; }
  public long Wk_num{ get; }
  public DateTime Wk_date{ get; }
  public long Start_time{ get; }
  public short Rest_period{ get; }
  public string Group_abbr{ get; }
  public string Subgroup_abbr{ get; }
  public string Course_yls{ get; }
  public long Tot_yards{ get; }
  public long Tot_stress{ get; }
  public bool Ck_selected{ get; }
  // Constructor
  TmModelparam(long wk_ptr, long wk_num, DateTime wk_date, long start_time, short rest_period, string group_abbr, string subgroup_abbr, string course_yls, long tot_yards, long tot_stress, bool ck_selected )
  {
    Wk_ptr = wk_ptr;
    Wk_num = wk_num;
    Wk_date = wk_date;
    Start_time = start_time;
    Rest_period = rest_period;
    Group_abbr = group_abbr;
    Subgroup_abbr = subgroup_abbr;
    Course_yls = course_yls;
    Tot_yards = tot_yards;
    Tot_stress = tot_stress;
    Ck_selected = ck_selected;
  }
}
