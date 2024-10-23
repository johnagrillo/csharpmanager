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
/// CREATE TABLE [RELAY]
/// (
/// [RELAY] Long Integer,
/// [MEET] Long Integer,
/// [LO_HI] Integer,
/// [TEAM] Long Integer,
/// [LETTER] Text (2),
/// [AGE_RANGE] Integer,
/// [SEX] Text (2),
/// [ATH(1)] Long Integer,
/// [ATH(2)] Long Integer,
/// [ATH(3)] Long Integer,
/// [ATH(4)] Long Integer,
/// [ATH(5)] Long Integer,
/// [ATH(6)] Long Integer,
/// [ATH(7)] Long Integer,
/// [ATH(8)] Long Integer,
/// [DISTANCE] Integer,
/// [STROKE] Integer,
/// [RELAYAGE] Text (6),
/// [REACTION1] Text (10),
/// [REACTION2] Text (10),
/// [REACTION3] Text (10),
/// [REACTION4] Text (10)
/// );

public class TmRelay 
{
Dictionary<long,TmRelay> get(OdbcConnection connection)
{
  var collection = new Dictionary<long,TmRelay>();
  string query = "select * from RELAY";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* RELAY */
      var arg1 = reader.GetInt64(2); /* MEET */
      var arg2 = reader.GetInt16(3); /* LO_HI */
      var arg3 = reader.GetInt64(4); /* TEAM */
      var arg4 = reader.GetTextReader(5).ToString(); /* LETTER */
      var arg5 = reader.GetInt16(6); /* AGE_RANGE */
      var arg6 = reader.GetTextReader(7).ToString(); /* SEX */
      var arg7 = reader.GetInt64(8); /* ATH(1) */
      var arg8 = reader.GetInt64(9); /* ATH(2) */
      var arg9 = reader.GetInt64(10); /* ATH(3) */
      var arg10 = reader.GetInt64(11); /* ATH(4) */
      var arg11 = reader.GetInt64(12); /* ATH(5) */
      var arg12 = reader.GetInt64(13); /* ATH(6) */
      var arg13 = reader.GetInt64(14); /* ATH(7) */
      var arg14 = reader.GetInt64(15); /* ATH(8) */
      var arg15 = reader.GetInt16(16); /* DISTANCE */
      var arg16 = reader.GetInt16(17); /* STROKE */
      var arg17 = reader.GetTextReader(18).ToString(); /* RELAYAGE */
      var arg18 = reader.GetTextReader(19).ToString(); /* REACTION1 */
      var arg19 = reader.GetTextReader(20).ToString(); /* REACTION2 */
      var arg20 = reader.GetTextReader(21).ToString(); /* REACTION3 */
      var arg21 = reader.GetTextReader(22).ToString(); /* REACTION4 */
      var obj = new TmRelay(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
      collection[obj.Relay] = obj;
    }
  }
  return collection;
}
  // Properties
  public long Relay{ get; }
  public long Meet{ get; }
  public short Lo_hi{ get; }
  public long Team{ get; }
  public string Letter{ get; }
  public short Age_range{ get; }
  public string Sex{ get; }
  public long Ath_1_{ get; }
  public long Ath_2_{ get; }
  public long Ath_3_{ get; }
  public long Ath_4_{ get; }
  public long Ath_5_{ get; }
  public long Ath_6_{ get; }
  public long Ath_7_{ get; }
  public long Ath_8_{ get; }
  public short Distance{ get; }
  public short Stroke{ get; }
  public string Relayage{ get; }
  public string Reaction1{ get; }
  public string Reaction2{ get; }
  public string Reaction3{ get; }
  public string Reaction4{ get; }
  // Constructor
  TmRelay(long relay, long meet, short lo_hi, long team, string letter, short age_range, string sex, long ath_1_, long ath_2_, long ath_3_, long ath_4_, long ath_5_, long ath_6_, long ath_7_, long ath_8_, short distance, short stroke, string relayage, string reaction1, string reaction2, string reaction3, string reaction4 )
  {
    Relay = relay;
    Meet = meet;
    Lo_hi = lo_hi;
    Team = team;
    Letter = letter;
    Age_range = age_range;
    Sex = sex;
    Ath_1_ = ath_1_;
    Ath_2_ = ath_2_;
    Ath_3_ = ath_3_;
    Ath_4_ = ath_4_;
    Ath_5_ = ath_5_;
    Ath_6_ = ath_6_;
    Ath_7_ = ath_7_;
    Ath_8_ = ath_8_;
    Distance = distance;
    Stroke = stroke;
    Relayage = relayage;
    Reaction1 = reaction1;
    Reaction2 = reaction2;
    Reaction3 = reaction3;
    Reaction4 = reaction4;
  }
}
