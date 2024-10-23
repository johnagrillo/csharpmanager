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
/// CREATE TABLE [CCrank]
/// (
/// [Event_ptr] Long Integer,
/// [Ath_no] Long Integer,
/// [Ath_sex] Text (2),
/// [Ath_stat] Text (2),
/// [Team_no] Long Integer,
/// [Chute_rank] Long Integer,
/// [Chute_no] Integer,
/// [Div_no] Long Integer,
/// [Ev_score] Long Integer,
/// [JDEv_score] Long Integer,
/// [score_stat] Text (2),
/// [multi_age] Integer,
/// [Fin_hand] Boolean NOT NULL,
/// [Fin_stat] Text (2),
/// [Fin_Time] Single,
/// [Fin_course] Text (2),
/// [Fin_place] Integer,
/// [Fin_jdplace] Integer,
/// [Fin_award] Integer,
/// [Fin_exh] Text (2),
/// [Team_ltr] Text (2)
/// );

public class MmCcrank 
{
List<MmCcrank> get(OdbcConnection connection)
{
  var collection = new List<MmCcrank>();
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
      var arg0 = reader.GetInt64(1); /* Event_ptr */
      var arg1 = reader.GetInt64(2); /* Ath_no */
      var arg2 = reader.GetTextReader(3).ToString(); /* Ath_sex */
      var arg3 = reader.GetTextReader(4).ToString(); /* Ath_stat */
      var arg4 = reader.GetInt64(5); /* Team_no */
      var arg5 = reader.GetInt64(6); /* Chute_rank */
      var arg6 = reader.GetInt16(7); /* Chute_no */
      var arg7 = reader.GetInt64(8); /* Div_no */
      var arg8 = reader.GetInt64(9); /* Ev_score */
      var arg9 = reader.GetInt64(10); /* JDEv_score */
      var arg10 = reader.GetTextReader(11).ToString(); /* score_stat */
      var arg11 = reader.GetInt16(12); /* multi_age */
      var arg12 = reader.GetBoolean(13); /* Fin_hand */
      var arg13 = reader.GetTextReader(14).ToString(); /* Fin_stat */
      var arg14 = reader.GetFloat(15); /* Fin_Time */
      var arg15 = reader.GetTextReader(16).ToString(); /* Fin_course */
      var arg16 = reader.GetInt16(17); /* Fin_place */
      var arg17 = reader.GetInt16(18); /* Fin_jdplace */
      var arg18 = reader.GetInt16(19); /* Fin_award */
      var arg19 = reader.GetTextReader(20).ToString(); /* Fin_exh */
      var arg20 = reader.GetTextReader(21).ToString(); /* Team_ltr */
      collection.Add( new MmCcrank(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20));
    }
  }
  return collection;
}
  // Properties
  public long EventPtr{ get; }
  public long AthNo{ get; }
  public string AthSex{ get; }
  public string AthStat{ get; }
  public long TeamNo{ get; }
  public long ChuteRank{ get; }
  public short ChuteNo{ get; }
  public long DivNo{ get; }
  public long EvScore{ get; }
  public long JDEvScore{ get; }
  public string Score_stat{ get; }
  public short Multi_age{ get; }
  public bool FinHand{ get; }
  public string FinStat{ get; }
  public float FinTime{ get; }
  public string FinCourse{ get; }
  public short FinPlace{ get; }
  public short FinJdplace{ get; }
  public short FinAward{ get; }
  public string FinExh{ get; }
  public string TeamLtr{ get; }
  // Constructor
  MmCcrank(long eventPtr, long athNo, string athSex, string athStat, long teamNo, long chuteRank, short chuteNo, long divNo, long evScore, long jDEvScore, string score_stat, short multi_age, bool finHand, string finStat, float finTime, string finCourse, short finPlace, short finJdplace, short finAward, string finExh, string teamLtr )
  {
    EventPtr = eventPtr;
    AthNo = athNo;
    AthSex = athSex;
    AthStat = athStat;
    TeamNo = teamNo;
    ChuteRank = chuteRank;
    ChuteNo = chuteNo;
    DivNo = divNo;
    EvScore = evScore;
    JDEvScore = jDEvScore;
    Score_stat = score_stat;
    Multi_age = multi_age;
    FinHand = finHand;
    FinStat = finStat;
    FinTime = finTime;
    FinCourse = finCourse;
    FinPlace = finPlace;
    FinJdplace = finJdplace;
    FinAward = finAward;
    FinExh = finExh;
    TeamLtr = teamLtr;
  }
}
