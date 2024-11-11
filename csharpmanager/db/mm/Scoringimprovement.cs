using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [ScoringImprovement]
/// // (
/// // [list_no] Integer,
/// // [diff_lowtime] Single,
/// // [diff_hightime] Single,
/// // [pt_score] Single,
/// // [swim_score] Single
/// // );

public class Scoringimprovement(short? list_no, float? diff_lowtime, float? diff_hightime, float? pt_score, float? swim_score )
{
static public List<Scoringimprovement> Get(OdbcConnection connection)
{
  var collection = new List<Scoringimprovement>();
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
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* list_no nullable true*/
  var arg1 = reader.IsDBNull(1) ? (float?)null :reader.GetFloat(1); /* diff_lowtime nullable true*/
  var arg2 = reader.IsDBNull(2) ? (float?)null :reader.GetFloat(2); /* diff_hightime nullable true*/
  var arg3 = reader.IsDBNull(3) ? (float?)null :reader.GetFloat(3); /* pt_score nullable true*/
  var arg4 = reader.IsDBNull(4) ? (float?)null :reader.GetFloat(4); /* swim_score nullable true*/
      collection.Add( new Scoringimprovement(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public short? List_no{ get; } = list_no;
  public float? Diff_lowtime{ get; } = diff_lowtime;
  public float? Diff_hightime{ get; } = diff_hightime;
  public float? Pt_score{ get; } = pt_score;
  public float? Swim_score{ get; } = swim_score;
}
}
}
