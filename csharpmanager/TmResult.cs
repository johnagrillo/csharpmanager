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
/// CREATE TABLE [RESULT]
/// (
/// [MEET] Long Integer,
/// [ATHLETE] Long Integer,
/// [I_R] Text (2),
/// [TEAM] Long Integer,
/// [SCORE] Long Integer,
/// [F_P] Text (2),
/// [SPLIT] Long Integer,
/// [EX] Text (2),
/// [ORIGIN] Text (8),
/// [NT] Byte,
/// [RESULT] Long Integer,
/// [MISC] Text (2),
/// [AGE] Integer,
/// [DISTANCE] Integer,
/// [STROKE] Integer,
/// [MTEVENT] Long Integer,
/// [POINTS] Integer,
/// [PLACE] Integer,
/// [RANK] Integer,
/// [TRANK] Integer,
/// [COURSE] Text (2),
/// [REACTION] Text (10),
/// [DQCODE] Text (4),
/// [DQDESCRIPT] Text (180),
/// [DQCODESecondary] Text (4),
/// [DQDESCRIPTSecondary] Text (180)
/// );

public class TmResult 
{
List<TmResult> get(OdbcConnection connection)
{
  var collection = new List<TmResult>();
  string query = "select * from RESULT";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* MEET */
      var arg1 = reader.GetInt64(2); /* ATHLETE */
      var arg2 = reader.GetTextReader(3).ToString(); /* I_R */
      var arg3 = reader.GetInt64(4); /* TEAM */
      var arg4 = reader.GetInt64(5); /* SCORE */
      var arg5 = reader.GetTextReader(6).ToString(); /* F_P */
      var arg6 = reader.GetInt64(7); /* SPLIT */
      var arg7 = reader.GetTextReader(8).ToString(); /* EX */
      var arg8 = reader.GetTextReader(9).ToString(); /* ORIGIN */
      var arg9 = reader.GetByte(10); /* NT */
      var arg10 = reader.GetInt64(11); /* RESULT */
      var arg11 = reader.GetTextReader(12).ToString(); /* MISC */
      var arg12 = reader.GetInt16(13); /* AGE */
      var arg13 = reader.GetInt16(14); /* DISTANCE */
      var arg14 = reader.GetInt16(15); /* STROKE */
      var arg15 = reader.GetInt64(16); /* MTEVENT */
      var arg16 = reader.GetInt16(17); /* POINTS */
      var arg17 = reader.GetInt16(18); /* PLACE */
      var arg18 = reader.GetInt16(19); /* RANK */
      var arg19 = reader.GetInt16(20); /* TRANK */
      var arg20 = reader.GetTextReader(21).ToString(); /* COURSE */
      var arg21 = reader.GetTextReader(22).ToString(); /* REACTION */
      var arg22 = reader.GetTextReader(23).ToString(); /* DQCODE */
      var arg23 = reader.GetTextReader(24).ToString(); /* DQDESCRIPT */
      var arg24 = reader.GetTextReader(25).ToString(); /* DQCODESecondary */
      var arg25 = reader.GetTextReader(26).ToString(); /* DQDESCRIPTSecondary */
      collection.Add( new TmResult(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25));
    }
  }
  return collection;
}
  // Properties
  public long Meet{ get; }
  public long Athlete{ get; }
  public string I_r{ get; }
  public long Team{ get; }
  public long Score{ get; }
  public string F_p{ get; }
  public long Split{ get; }
  public string Ex{ get; }
  public string Origin{ get; }
  public byte Nt{ get; }
  public long Result{ get; }
  public string Misc{ get; }
  public short Age{ get; }
  public short Distance{ get; }
  public short Stroke{ get; }
  public long Mtevent{ get; }
  public short Points{ get; }
  public short Place{ get; }
  public short Rank{ get; }
  public short Trank{ get; }
  public string Course{ get; }
  public string Reaction{ get; }
  public string Dqcode{ get; }
  public string Dqdescript{ get; }
  public string DQCODESecondary{ get; }
  public string DQDESCRIPTSecondary{ get; }
  // Constructor
  TmResult(long meet, long athlete, string i_r, long team, long score, string f_p, long split, string ex, string origin, byte nt, long result, string misc, short age, short distance, short stroke, long mtevent, short points, short place, short rank, short trank, string course, string reaction, string dqcode, string dqdescript, string dQCODESecondary, string dQDESCRIPTSecondary )
  {
    Meet = meet;
    Athlete = athlete;
    I_r = i_r;
    Team = team;
    Score = score;
    F_p = f_p;
    Split = split;
    Ex = ex;
    Origin = origin;
    Nt = nt;
    Result = result;
    Misc = misc;
    Age = age;
    Distance = distance;
    Stroke = stroke;
    Mtevent = mtevent;
    Points = points;
    Place = place;
    Rank = rank;
    Trank = trank;
    Course = course;
    Reaction = reaction;
    Dqcode = dqcode;
    Dqdescript = dqdescript;
    DQCODESecondary = dQCODESecondary;
    DQDESCRIPTSecondary = dQDESCRIPTSecondary;
  }
}
