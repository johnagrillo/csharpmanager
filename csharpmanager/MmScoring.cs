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
/// CREATE TABLE [Scoring]
/// (
/// [score_divno] Integer,
/// [score_sex] Text (2),
/// [score_place] Integer,
/// [ind_score] Single,
/// [rel_score] Single
/// );

public class MmScoring 
{
List<MmScoring> get(OdbcConnection connection)
{
  var collection = new List<MmScoring>();
  string query = "select * from Scoring";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt16(1); /* score_divno */
      var arg1 = reader.GetTextReader(2).ToString(); /* score_sex */
      var arg2 = reader.GetInt16(3); /* score_place */
      var arg3 = reader.GetFloat(4); /* ind_score */
      var arg4 = reader.GetFloat(5); /* rel_score */
      collection.Add( new MmScoring(arg0, arg1, arg2, arg3, arg4));
    }
  }
  return collection;
}
  // Properties
  public short Score_divno{ get; }
  public string Score_sex{ get; }
  public short Score_place{ get; }
  public float Ind_score{ get; }
  public float Rel_score{ get; }
  // Constructor
  MmScoring(short score_divno, string score_sex, short score_place, float ind_score, float rel_score )
  {
    Score_divno = score_divno;
    Score_sex = score_sex;
    Score_place = score_place;
    Ind_score = ind_score;
    Rel_score = rel_score;
  }
}
