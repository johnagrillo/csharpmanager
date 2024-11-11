using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [RESULT]
/// // (
/// // [MEET] Long Integer,
/// // [ATHLETE] Long Integer,
/// // [I_R] Text (2),
/// // [TEAM] Long Integer,
/// // [SCORE] Long Integer,
/// // [F_P] Text (2),
/// // [SPLIT] Long Integer,
/// // [EX] Text (2),
/// // [ORIGIN] Text (8),
/// // [NT] Byte,
/// // [RESULT] Long Integer,
/// // [MISC] Text (2),
/// // [AGE] Integer,
/// // [DISTANCE] Integer,
/// // [STROKE] Integer,
/// // [MTEVENT] Long Integer,
/// // [POINTS] Integer,
/// // [PLACE] Integer,
/// // [RANK] Integer,
/// // [TRANK] Integer,
/// // [COURSE] Text (2),
/// // [REACTION] Text (10),
/// // [DQCODE] Text (4),
/// // [DQDESCRIPT] Text (180),
/// // [DQCODESecondary] Text (4),
/// // [DQDESCRIPTSecondary] Text (180)
/// // );

public class Result(long? meet, long? athlete, string i_r, long? team, long? score, string f_p, long? split, string ex, string origin, byte? nt, long result, string misc, short? age, short? distance, short? stroke, long? mtevent, short? points, short? place, short? rank, short? trank, string course, string reaction, string dqcode, string dqdescript, string dQCODESecondary, string dQDESCRIPTSecondary )
{
static public List<Result> Get(OdbcConnection connection)
{
  var collection = new List<Result>();
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
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* MEET nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* ATHLETE nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* I_R nullable false*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* TEAM nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* SCORE nullable true*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* F_P nullable false*/
  var arg6 = reader.IsDBNull(6) ? (long?)null :reader.GetInt32(6); /* SPLIT nullable true*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* EX nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* ORIGIN nullable false*/
  var arg9 = reader.IsDBNull(9) ? (byte?)null :reader.GetByte(9); /* NT nullable true*/
  var arg10 = reader.GetInt32(10); /* RESULT nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* MISC nullable false*/
  var arg12 = reader.IsDBNull(12) ? (short?)null :reader.GetInt16(12); /* AGE nullable true*/
  var arg13 = reader.IsDBNull(13) ? (short?)null :reader.GetInt16(13); /* DISTANCE nullable true*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* STROKE nullable true*/
  var arg15 = reader.IsDBNull(15) ? (long?)null :reader.GetInt32(15); /* MTEVENT nullable true*/
  var arg16 = reader.IsDBNull(16) ? (short?)null :reader.GetInt16(16); /* POINTS nullable true*/
  var arg17 = reader.IsDBNull(17) ? (short?)null :reader.GetInt16(17); /* PLACE nullable true*/
  var arg18 = reader.IsDBNull(18) ? (short?)null :reader.GetInt16(18); /* RANK nullable true*/
  var arg19 = reader.IsDBNull(19) ? (short?)null :reader.GetInt16(19); /* TRANK nullable true*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* COURSE nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* REACTION nullable false*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* DQCODE nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* DQDESCRIPT nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* DQCODESecondary nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* DQDESCRIPTSecondary nullable false*/
      collection.Add( new Result(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25));
    }
  }
  return collection;
}
  // Properties
  public long? Meet{ get; } = meet;
  public long? Athlete{ get; } = athlete;
  public string I_r{ get; } = i_r;
  public long? Team{ get; } = team;
  public long? Score{ get; } = score;
  public string F_p{ get; } = f_p;
  public long? Split{ get; } = split;
  public string Ex{ get; } = ex;
  public string Origin{ get; } = origin;
  public byte? Nt{ get; } = nt;
  public long Result_{ get; } = result;
  public string Misc{ get; } = misc;
  public short? Age{ get; } = age;
  public short? Distance{ get; } = distance;
  public short? Stroke{ get; } = stroke;
  public long? Mtevent{ get; } = mtevent;
  public short? Points{ get; } = points;
  public short? Place{ get; } = place;
  public short? Rank{ get; } = rank;
  public short? Trank{ get; } = trank;
  public string Course{ get; } = course;
  public string Reaction{ get; } = reaction;
  public string Dqcode{ get; } = dqcode;
  public string Dqdescript{ get; } = dqdescript;
  public string DQCODESecondary{ get; } = dQCODESecondary;
  public string DQDESCRIPTSecondary{ get; } = dQDESCRIPTSecondary;
}
}
}
