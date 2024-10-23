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
/// CREATE TABLE [CUSTOMRPTS]
/// (
/// [Name] Text (60),
/// [Type] Integer,
/// [Team] Long Integer,
/// [Group] Text (6),
/// [SubGr] Text (6),
/// [Class] Text (6),
/// [SortBy] Integer,
/// [Sex] Integer,
/// [Prelim] Integer,
/// [Splits] Integer,
/// [Stroke] Integer,
/// [Distance] Integer,
/// [I_R] Integer,
/// [LSC] Text (6),
/// [LoAge] Integer,
/// [HiAge] Integer,
/// [chkIncRelayLO] Boolean NOT NULL,
/// [chkStandards] Boolean NOT NULL,
/// [chkInactive] Boolean NOT NULL,
/// [chkSince] Boolean NOT NULL,
/// [SinceDate] DateTime,
/// [chkImprove] Integer,
/// [chkUntil] Boolean NOT NULL,
/// [UntilDate] DateTime,
/// [chkRecords] Boolean NOT NULL,
/// [RECORD] Long Integer,
/// [chkNamesOnly] Boolean NOT NULL,
/// [chkBlankLine] Boolean NOT NULL,
/// [Grouping] Integer,
/// [AgeGroups] Integer,
/// [MeetType] Text (6),
/// [TopN] Integer,
/// [StanAtLeast] Text (8),
/// [Course] Integer,
/// [chkChronological] Boolean NOT NULL,
/// [Orientation] Integer,
/// [chkActual] Boolean NOT NULL,
/// [chkNoTimes] Boolean NOT NULL,
/// [chkOnlyElig] Boolean NOT NULL,
/// [chkBest] Integer,
/// [RelaySwimmers] Integer,
/// [StdName] Text (16),
/// [Designator] Text (8),
/// [chkStrokeRate] Boolean NOT NULL,
/// [LabelIndex] Integer,
/// [chkNISCA] Boolean NOT NULL,
/// [chkNewStd] Boolean NOT NULL,
/// [ColIndex] Integer,
/// [chkGoals] Boolean NOT NULL,
/// [chkIncRelayLegs] Boolean NOT NULL,
/// [chkShowRegistration] Boolean NOT NULL,
/// [chkNT] Boolean NOT NULL
/// );

public class TmCustomrpts 
{
List<TmCustomrpts> get(OdbcConnection connection)
{
  var collection = new List<TmCustomrpts>();
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
      var arg0 = reader.GetTextReader(1).ToString(); /* Name */
      var arg1 = reader.GetInt16(2); /* Type */
      var arg2 = reader.GetInt64(3); /* Team */
      var arg3 = reader.GetTextReader(4).ToString(); /* Group */
      var arg4 = reader.GetTextReader(5).ToString(); /* SubGr */
      var arg5 = reader.GetTextReader(6).ToString(); /* Class */
      var arg6 = reader.GetInt16(7); /* SortBy */
      var arg7 = reader.GetInt16(8); /* Sex */
      var arg8 = reader.GetInt16(9); /* Prelim */
      var arg9 = reader.GetInt16(10); /* Splits */
      var arg10 = reader.GetInt16(11); /* Stroke */
      var arg11 = reader.GetInt16(12); /* Distance */
      var arg12 = reader.GetInt16(13); /* I_R */
      var arg13 = reader.GetTextReader(14).ToString(); /* LSC */
      var arg14 = reader.GetInt16(15); /* LoAge */
      var arg15 = reader.GetInt16(16); /* HiAge */
      var arg16 = reader.GetBoolean(17); /* chkIncRelayLO */
      var arg17 = reader.GetBoolean(18); /* chkStandards */
      var arg18 = reader.GetBoolean(19); /* chkInactive */
      var arg19 = reader.GetBoolean(20); /* chkSince */
      var arg20 = reader.GetDateTime(21); /* SinceDate */
      var arg21 = reader.GetInt16(22); /* chkImprove */
      var arg22 = reader.GetBoolean(23); /* chkUntil */
      var arg23 = reader.GetDateTime(24); /* UntilDate */
      var arg24 = reader.GetBoolean(25); /* chkRecords */
      var arg25 = reader.GetInt64(26); /* RECORD */
      var arg26 = reader.GetBoolean(27); /* chkNamesOnly */
      var arg27 = reader.GetBoolean(28); /* chkBlankLine */
      var arg28 = reader.GetInt16(29); /* Grouping */
      var arg29 = reader.GetInt16(30); /* AgeGroups */
      var arg30 = reader.GetTextReader(31).ToString(); /* MeetType */
      var arg31 = reader.GetInt16(32); /* TopN */
      var arg32 = reader.GetTextReader(33).ToString(); /* StanAtLeast */
      var arg33 = reader.GetInt16(34); /* Course */
      var arg34 = reader.GetBoolean(35); /* chkChronological */
      var arg35 = reader.GetInt16(36); /* Orientation */
      var arg36 = reader.GetBoolean(37); /* chkActual */
      var arg37 = reader.GetBoolean(38); /* chkNoTimes */
      var arg38 = reader.GetBoolean(39); /* chkOnlyElig */
      var arg39 = reader.GetInt16(40); /* chkBest */
      var arg40 = reader.GetInt16(41); /* RelaySwimmers */
      var arg41 = reader.GetTextReader(42).ToString(); /* StdName */
      var arg42 = reader.GetTextReader(43).ToString(); /* Designator */
      var arg43 = reader.GetBoolean(44); /* chkStrokeRate */
      var arg44 = reader.GetInt16(45); /* LabelIndex */
      var arg45 = reader.GetBoolean(46); /* chkNISCA */
      var arg46 = reader.GetBoolean(47); /* chkNewStd */
      var arg47 = reader.GetInt16(48); /* ColIndex */
      var arg48 = reader.GetBoolean(49); /* chkGoals */
      var arg49 = reader.GetBoolean(50); /* chkIncRelayLegs */
      var arg50 = reader.GetBoolean(51); /* chkShowRegistration */
      var arg51 = reader.GetBoolean(52); /* chkNT */
      collection.Add( new TmCustomrpts(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51));
    }
  }
  return collection;
}
  // Properties
  public string Name{ get; }
  public short Type{ get; }
  public long Team{ get; }
  public string Group{ get; }
  public string SubGr{ get; }
  public string Cclass{ get; }
  public short SortBy{ get; }
  public short Sex{ get; }
  public short Prelim{ get; }
  public short Splits{ get; }
  public short Stroke{ get; }
  public short Distance{ get; }
  public short I_r{ get; }
  public string Lsc{ get; }
  public short LoAge{ get; }
  public short HiAge{ get; }
  public bool ChkIncRelayLO{ get; }
  public bool ChkStandards{ get; }
  public bool ChkInactive{ get; }
  public bool ChkSince{ get; }
  public DateTime SinceDate{ get; }
  public short ChkImprove{ get; }
  public bool ChkUntil{ get; }
  public DateTime UntilDate{ get; }
  public bool ChkRecords{ get; }
  public long Record{ get; }
  public bool ChkNamesOnly{ get; }
  public bool ChkBlankLine{ get; }
  public short Grouping{ get; }
  public short AgeGroups{ get; }
  public string MeetType{ get; }
  public short TopN{ get; }
  public string StanAtLeast{ get; }
  public short Course{ get; }
  public bool ChkChronological{ get; }
  public short Orientation{ get; }
  public bool ChkActual{ get; }
  public bool ChkNoTimes{ get; }
  public bool ChkOnlyElig{ get; }
  public short ChkBest{ get; }
  public short RelaySwimmers{ get; }
  public string StdName{ get; }
  public string Designator{ get; }
  public bool ChkStrokeRate{ get; }
  public short LabelIndex{ get; }
  public bool ChkNISCA{ get; }
  public bool ChkNewStd{ get; }
  public short ColIndex{ get; }
  public bool ChkGoals{ get; }
  public bool ChkIncRelayLegs{ get; }
  public bool ChkShowRegistration{ get; }
  public bool ChkNT{ get; }
  // Constructor
  TmCustomrpts(string name, short type, long team, string group, string subGr, string cclass, short sortBy, short sex, short prelim, short splits, short stroke, short distance, short i_r, string lsc, short loAge, short hiAge, bool chkIncRelayLO, bool chkStandards, bool chkInactive, bool chkSince, DateTime sinceDate, short chkImprove, bool chkUntil, DateTime untilDate, bool chkRecords, long record, bool chkNamesOnly, bool chkBlankLine, short grouping, short ageGroups, string meetType, short topN, string stanAtLeast, short course, bool chkChronological, short orientation, bool chkActual, bool chkNoTimes, bool chkOnlyElig, short chkBest, short relaySwimmers, string stdName, string designator, bool chkStrokeRate, short labelIndex, bool chkNISCA, bool chkNewStd, short colIndex, bool chkGoals, bool chkIncRelayLegs, bool chkShowRegistration, bool chkNT )
  {
    Name = name;
    Type = type;
    Team = team;
    Group = group;
    SubGr = subGr;
    Cclass = cclass;
    SortBy = sortBy;
    Sex = sex;
    Prelim = prelim;
    Splits = splits;
    Stroke = stroke;
    Distance = distance;
    I_r = i_r;
    Lsc = lsc;
    LoAge = loAge;
    HiAge = hiAge;
    ChkIncRelayLO = chkIncRelayLO;
    ChkStandards = chkStandards;
    ChkInactive = chkInactive;
    ChkSince = chkSince;
    SinceDate = sinceDate;
    ChkImprove = chkImprove;
    ChkUntil = chkUntil;
    UntilDate = untilDate;
    ChkRecords = chkRecords;
    Record = record;
    ChkNamesOnly = chkNamesOnly;
    ChkBlankLine = chkBlankLine;
    Grouping = grouping;
    AgeGroups = ageGroups;
    MeetType = meetType;
    TopN = topN;
    StanAtLeast = stanAtLeast;
    Course = course;
    ChkChronological = chkChronological;
    Orientation = orientation;
    ChkActual = chkActual;
    ChkNoTimes = chkNoTimes;
    ChkOnlyElig = chkOnlyElig;
    ChkBest = chkBest;
    RelaySwimmers = relaySwimmers;
    StdName = stdName;
    Designator = designator;
    ChkStrokeRate = chkStrokeRate;
    LabelIndex = labelIndex;
    ChkNISCA = chkNISCA;
    ChkNewStd = chkNewStd;
    ColIndex = colIndex;
    ChkGoals = chkGoals;
    ChkIncRelayLegs = chkIncRelayLegs;
    ChkShowRegistration = chkShowRegistration;
    ChkNT = chkNT;
  }
}
