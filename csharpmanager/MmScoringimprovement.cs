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
/// CREATE TABLE [ScoringImprovement]
/// (
/// [list_no] Integer,
/// [diff_lowtime] Single,
/// [diff_hightime] Single,
/// [pt_score] Single,
/// [swim_score] Single
/// );

public class MmScoringimprovement 
{
List<MmScoringimprovement> get(OdbcConnection connection)
{
  var collection = new List<MmScoringimprovement>();
  string query = "select * from ScoringImprovement";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* list_no */
      var arg1 = reader.GetFloat(2); /* diff_lowtime */
      var arg2 = reader.GetFloat(3); /* diff_hightime */
      var arg3 = reader.GetFloat(4); /* pt_score */
      var arg4 = reader.GetFloat(5); /* swim_score */
      collection.Add( new MmScoringimprovement(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public short List_no{ get; }
  public float Diff_lowtime{ get; }
  public float Diff_hightime{ get; }
  public float Pt_score{ get; }
  public float Swim_score{ get; }
  // Constructor
  MmScoringimprovement(short list_no, float diff_lowtime, float diff_hightime, float pt_score, float swim_score )
  {
    List_no = list_no;
    Diff_lowtime = diff_lowtime;
    Diff_hightime = diff_hightime;
    Pt_score = pt_score;
    Swim_score = swim_score;
  }
}
