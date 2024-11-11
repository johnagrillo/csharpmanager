using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [CCrank]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Ath_no] Long Integer,
/// // [Ath_sex] Text (2),
/// // [Ath_stat] Text (2),
/// // [Team_no] Long Integer,
/// // [Chute_rank] Long Integer,
/// // [Chute_no] Integer,
/// // [Div_no] Long Integer,
/// // [Ev_score] Long Integer,
/// // [JDEv_score] Long Integer,
/// // [score_stat] Text (2),
/// // [multi_age] Integer,
/// // [Fin_hand] Boolean NOT NULL,
/// // [Fin_stat] Text (2),
/// // [Fin_Time] Single,
/// // [Fin_course] Text (2),
/// // [Fin_place] Integer,
/// // [Fin_jdplace] Integer,
/// // [Fin_award] Integer,
/// // [Fin_exh] Text (2),
/// // [Team_ltr] Text (2)
/// // );

public class Ccrank(long? eventPtr, long? athNo, string athSex, string athStat, long? teamNo, long? chuteRank, short? chuteNo, long? divNo, long? evScore, long? jDEvScore, string score_stat, short? multi_age, bool finHand, string finStat, float? finTime, string finCourse, short? finPlace, short? finJdplace, short? finAward, string finExh, string teamLtr )
{
static public List<Ccrank> Get(OdbcConnection connection)
{
  var collection = new List<Ccrank>();
  string query = "select * from CCrank";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Event_ptr nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* Ath_no nullable true*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Ath_sex nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Ath_stat nullable false*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* Team_no nullable true*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* Chute_rank nullable true*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* Chute_no nullable true*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* Div_no nullable true*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* Ev_score nullable true*/
  var arg9 = reader.IsDBNull(9) ? (long?)null :reader.GetInt32(9); /* JDEv_score nullable true*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* score_stat nullable false*/
  var arg11 = reader.IsDBNull(11) ? (short?)null :reader.GetInt16(11); /* multi_age nullable true*/
  var arg12 = reader.GetBoolean(12); /* Fin_hand nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* Fin_stat nullable false*/
  var arg14 = reader.IsDBNull(14) ? (float?)null :reader.GetFloat(14); /* Fin_Time nullable true*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Fin_course nullable false*/
  var arg16 = reader.IsDBNull(16) ? (short?)null :reader.GetInt16(16); /* Fin_place nullable true*/
  var arg17 = reader.IsDBNull(17) ? (short?)null :reader.GetInt16(17); /* Fin_jdplace nullable true*/
  var arg18 = reader.IsDBNull(18) ? (short?)null :reader.GetInt16(18); /* Fin_award nullable true*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* Fin_exh nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* Team_ltr nullable false*/
      collection.Add( new Ccrank(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public long? AthNo{ get; } = athNo;
  public string AthSex{ get; } = athSex;
  public string AthStat{ get; } = athStat;
  public long? TeamNo{ get; } = teamNo;
  public long? ChuteRank{ get; } = chuteRank;
  public short? ChuteNo{ get; } = chuteNo;
  public long? DivNo{ get; } = divNo;
  public long? EvScore{ get; } = evScore;
  public long? JDEvScore{ get; } = jDEvScore;
  public string Score_stat{ get; } = score_stat;
  public short? Multi_age{ get; } = multi_age;
  public bool FinHand{ get; } = finHand;
  public string FinStat{ get; } = finStat;
  public float? FinTime{ get; } = finTime;
  public string FinCourse{ get; } = finCourse;
  public short? FinPlace{ get; } = finPlace;
  public short? FinJdplace{ get; } = finJdplace;
  public short? FinAward{ get; } = finAward;
  public string FinExh{ get; } = finExh;
  public string TeamLtr{ get; } = teamLtr;
}
}
}
