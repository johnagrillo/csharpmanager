using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [CUSTOMRPTS]
/// // (
/// // [Name] Text (60),
/// // [Type] Integer,
/// // [Team] Long Integer,
/// // [Group] Text (6),
/// // [SubGr] Text (6),
/// // [Class] Text (6),
/// // [SortBy] Integer,
/// // [Sex] Integer,
/// // [Prelim] Integer,
/// // [Splits] Integer,
/// // [Stroke] Integer,
/// // [Distance] Integer,
/// // [I_R] Integer,
/// // [LSC] Text (6),
/// // [LoAge] Integer,
/// // [HiAge] Integer,
/// // [chkIncRelayLO] Boolean NOT NULL,
/// // [chkStandards] Boolean NOT NULL,
/// // [chkInactive] Boolean NOT NULL,
/// // [chkSince] Boolean NOT NULL,
/// // [SinceDate] DateTime,
/// // [chkImprove] Integer,
/// // [chkUntil] Boolean NOT NULL,
/// // [UntilDate] DateTime,
/// // [chkRecords] Boolean NOT NULL,
/// // [RECORD] Long Integer,
/// // [chkNamesOnly] Boolean NOT NULL,
/// // [chkBlankLine] Boolean NOT NULL,
/// // [Grouping] Integer,
/// // [AgeGroups] Integer,
/// // [MeetType] Text (6),
/// // [TopN] Integer,
/// // [StanAtLeast] Text (8),
/// // [Course] Integer,
/// // [chkChronological] Boolean NOT NULL,
/// // [Orientation] Integer,
/// // [chkActual] Boolean NOT NULL,
/// // [chkNoTimes] Boolean NOT NULL,
/// // [chkOnlyElig] Boolean NOT NULL,
/// // [chkBest] Integer,
/// // [RelaySwimmers] Integer,
/// // [StdName] Text (16),
/// // [Designator] Text (8),
/// // [chkStrokeRate] Boolean NOT NULL,
/// // [LabelIndex] Integer,
/// // [chkNISCA] Boolean NOT NULL,
/// // [chkNewStd] Boolean NOT NULL,
/// // [ColIndex] Integer,
/// // [chkGoals] Boolean NOT NULL,
/// // [chkIncRelayLegs] Boolean NOT NULL,
/// // [chkShowRegistration] Boolean NOT NULL,
/// // [chkNT] Boolean NOT NULL
/// // );

public class Customrpts(string name, short? type, long? team, string group, string subGr, string cclass, short? sortBy, short? sex, short? prelim, short? splits, short? stroke, short? distance, short? i_r, string lsc, short? loAge, short? hiAge, bool chkIncRelayLO, bool chkStandards, bool chkInactive, bool chkSince, DateTime? sinceDate, short? chkImprove, bool chkUntil, DateTime? untilDate, bool chkRecords, long? record, bool chkNamesOnly, bool chkBlankLine, short? grouping, short? ageGroups, string meetType, short? topN, string stanAtLeast, short? course, bool chkChronological, short? orientation, bool chkActual, bool chkNoTimes, bool chkOnlyElig, short? chkBest, short? relaySwimmers, string stdName, string designator, bool chkStrokeRate, short? labelIndex, bool chkNISCA, bool chkNewStd, short? colIndex, bool chkGoals, bool chkIncRelayLegs, bool chkShowRegistration, bool chkNT )
{
static public List<Customrpts> Get(OdbcConnection connection)
{
  var collection = new List<Customrpts>();
  string query = "select * from CUSTOMRPTS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* Name nullable false*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Type nullable true*/
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Team nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Group nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* SubGr nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Class nullable false*/
  var arg6 = reader.IsDBNull(6) ? (short?)null :reader.GetInt16(6); /* SortBy nullable true*/
  var arg7 = reader.IsDBNull(7) ? (short?)null :reader.GetInt16(7); /* Sex nullable true*/
  var arg8 = reader.IsDBNull(8) ? (short?)null :reader.GetInt16(8); /* Prelim nullable true*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* Splits nullable true*/
  var arg10 = reader.IsDBNull(10) ? (short?)null :reader.GetInt16(10); /* Stroke nullable true*/
  var arg11 = reader.IsDBNull(11) ? (short?)null :reader.GetInt16(11); /* Distance nullable true*/
  var arg12 = reader.IsDBNull(12) ? (short?)null :reader.GetInt16(12); /* I_R nullable true*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* LSC nullable false*/
  var arg14 = reader.IsDBNull(14) ? (short?)null :reader.GetInt16(14); /* LoAge nullable true*/
  var arg15 = reader.IsDBNull(15) ? (short?)null :reader.GetInt16(15); /* HiAge nullable true*/
  var arg16 = reader.GetBoolean(16); /* chkIncRelayLO nullable false*/
  var arg17 = reader.GetBoolean(17); /* chkStandards nullable false*/
  var arg18 = reader.GetBoolean(18); /* chkInactive nullable false*/
  var arg19 = reader.GetBoolean(19); /* chkSince nullable false*/
  var arg20 = reader.IsDBNull(20) ? (DateTime?)null :reader.GetDateTime(20); /* SinceDate nullable true*/
  var arg21 = reader.IsDBNull(21) ? (short?)null :reader.GetInt16(21); /* chkImprove nullable true*/
  var arg22 = reader.GetBoolean(22); /* chkUntil nullable false*/
  var arg23 = reader.IsDBNull(23) ? (DateTime?)null :reader.GetDateTime(23); /* UntilDate nullable true*/
  var arg24 = reader.GetBoolean(24); /* chkRecords nullable false*/
  var arg25 = reader.IsDBNull(25) ? (long?)null :reader.GetInt32(25); /* RECORD nullable true*/
  var arg26 = reader.GetBoolean(26); /* chkNamesOnly nullable false*/
  var arg27 = reader.GetBoolean(27); /* chkBlankLine nullable false*/
  var arg28 = reader.IsDBNull(28) ? (short?)null :reader.GetInt16(28); /* Grouping nullable true*/
  var arg29 = reader.IsDBNull(29) ? (short?)null :reader.GetInt16(29); /* AgeGroups nullable true*/
  var arg30 = reader.GetTextReader(30).ReadLine(); /* MeetType nullable false*/
  var arg31 = reader.IsDBNull(31) ? (short?)null :reader.GetInt16(31); /* TopN nullable true*/
  var arg32 = reader.GetTextReader(32).ReadLine(); /* StanAtLeast nullable false*/
  var arg33 = reader.IsDBNull(33) ? (short?)null :reader.GetInt16(33); /* Course nullable true*/
  var arg34 = reader.GetBoolean(34); /* chkChronological nullable false*/
  var arg35 = reader.IsDBNull(35) ? (short?)null :reader.GetInt16(35); /* Orientation nullable true*/
  var arg36 = reader.GetBoolean(36); /* chkActual nullable false*/
  var arg37 = reader.GetBoolean(37); /* chkNoTimes nullable false*/
  var arg38 = reader.GetBoolean(38); /* chkOnlyElig nullable false*/
  var arg39 = reader.IsDBNull(39) ? (short?)null :reader.GetInt16(39); /* chkBest nullable true*/
  var arg40 = reader.IsDBNull(40) ? (short?)null :reader.GetInt16(40); /* RelaySwimmers nullable true*/
  var arg41 = reader.GetTextReader(41).ReadLine(); /* StdName nullable false*/
  var arg42 = reader.GetTextReader(42).ReadLine(); /* Designator nullable false*/
  var arg43 = reader.GetBoolean(43); /* chkStrokeRate nullable false*/
  var arg44 = reader.IsDBNull(44) ? (short?)null :reader.GetInt16(44); /* LabelIndex nullable true*/
  var arg45 = reader.GetBoolean(45); /* chkNISCA nullable false*/
  var arg46 = reader.GetBoolean(46); /* chkNewStd nullable false*/
  var arg47 = reader.IsDBNull(47) ? (short?)null :reader.GetInt16(47); /* ColIndex nullable true*/
  var arg48 = reader.GetBoolean(48); /* chkGoals nullable false*/
  var arg49 = reader.GetBoolean(49); /* chkIncRelayLegs nullable false*/
  var arg50 = reader.GetBoolean(50); /* chkShowRegistration nullable false*/
  var arg51 = reader.GetBoolean(51); /* chkNT nullable false*/
      collection.Add( new Customrpts(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51));
    }
  }
  return collection;
}
  // Properties
  public string Name{ get; } = name;
  public short? Type{ get; } = type;
  public long? Team{ get; } = team;
  public string Group{ get; } = group;
  public string SubGr{ get; } = subGr;
  public string Cclass{ get; } = cclass;
  public short? SortBy{ get; } = sortBy;
  public short? Sex{ get; } = sex;
  public short? Prelim{ get; } = prelim;
  public short? Splits{ get; } = splits;
  public short? Stroke{ get; } = stroke;
  public short? Distance{ get; } = distance;
  public short? I_r{ get; } = i_r;
  public string Lsc{ get; } = lsc;
  public short? LoAge{ get; } = loAge;
  public short? HiAge{ get; } = hiAge;
  public bool ChkIncRelayLO{ get; } = chkIncRelayLO;
  public bool ChkStandards{ get; } = chkStandards;
  public bool ChkInactive{ get; } = chkInactive;
  public bool ChkSince{ get; } = chkSince;
  public DateTime? SinceDate{ get; } = sinceDate;
  public short? ChkImprove{ get; } = chkImprove;
  public bool ChkUntil{ get; } = chkUntil;
  public DateTime? UntilDate{ get; } = untilDate;
  public bool ChkRecords{ get; } = chkRecords;
  public long? Record{ get; } = record;
  public bool ChkNamesOnly{ get; } = chkNamesOnly;
  public bool ChkBlankLine{ get; } = chkBlankLine;
  public short? Grouping{ get; } = grouping;
  public short? AgeGroups{ get; } = ageGroups;
  public string MeetType{ get; } = meetType;
  public short? TopN{ get; } = topN;
  public string StanAtLeast{ get; } = stanAtLeast;
  public short? Course{ get; } = course;
  public bool ChkChronological{ get; } = chkChronological;
  public short? Orientation{ get; } = orientation;
  public bool ChkActual{ get; } = chkActual;
  public bool ChkNoTimes{ get; } = chkNoTimes;
  public bool ChkOnlyElig{ get; } = chkOnlyElig;
  public short? ChkBest{ get; } = chkBest;
  public short? RelaySwimmers{ get; } = relaySwimmers;
  public string StdName{ get; } = stdName;
  public string Designator{ get; } = designator;
  public bool ChkStrokeRate{ get; } = chkStrokeRate;
  public short? LabelIndex{ get; } = labelIndex;
  public bool ChkNISCA{ get; } = chkNISCA;
  public bool ChkNewStd{ get; } = chkNewStd;
  public short? ColIndex{ get; } = colIndex;
  public bool ChkGoals{ get; } = chkGoals;
  public bool ChkIncRelayLegs{ get; } = chkIncRelayLegs;
  public bool ChkShowRegistration{ get; } = chkShowRegistration;
  public bool ChkNT{ get; } = chkNT;
}
}
}
