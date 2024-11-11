using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [AltScoring]
/// // (
/// // [score_divno] Integer,
/// // [score_sex] Text (2),
/// // [score_place] Integer,
/// // [ind_score] Single,
/// // [rel_score] Single
/// // );

public class Altscoring(short? score_divno, string score_sex, short? score_place, float? ind_score, float? rel_score )
{
static public List<Altscoring> Get(OdbcConnection connection)
{
  var collection = new List<Altscoring>();
  string query = "select * from AltScoring";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (short?)null :reader.GetInt16(0); /* score_divno nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* score_sex nullable false*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* score_place nullable true*/
  var arg3 = reader.IsDBNull(3) ? (float?)null :reader.GetFloat(3); /* ind_score nullable true*/
  var arg4 = reader.IsDBNull(4) ? (float?)null :reader.GetFloat(4); /* rel_score nullable true*/
      collection.Add( new Altscoring(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public short? Score_divno{ get; } = score_divno;
  public string Score_sex{ get; } = score_sex;
  public short? Score_place{ get; } = score_place;
  public float? Ind_score{ get; } = ind_score;
  public float? Rel_score{ get; } = rel_score;
}
}
}
