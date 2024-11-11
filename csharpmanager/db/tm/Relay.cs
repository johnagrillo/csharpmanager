using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [RELAY]
/// // (
/// // [RELAY] Long Integer,
/// // [MEET] Long Integer,
/// // [LO_HI] Integer,
/// // [TEAM] Long Integer,
/// // [LETTER] Text (2),
/// // [AGE_RANGE] Integer,
/// // [SEX] Text (2),
/// // [ATH(1)] Long Integer,
/// // [ATH(2)] Long Integer,
/// // [ATH(3)] Long Integer,
/// // [ATH(4)] Long Integer,
/// // [ATH(5)] Long Integer,
/// // [ATH(6)] Long Integer,
/// // [ATH(7)] Long Integer,
/// // [ATH(8)] Long Integer,
/// // [DISTANCE] Integer,
/// // [STROKE] Integer,
/// // [RELAYAGE] Text (6),
/// // [REACTION1] Text (10),
/// // [REACTION2] Text (10),
/// // [REACTION3] Text (10),
/// // [REACTION4] Text (10)
/// // );

public class Relay(long relay, long? meet, short? lo_hi, long? team, string letter, short? age_range, string sex, long? ath_1_, long? ath_2_, long? ath_3_, long? ath_4_, long? ath_5_, long? ath_6_, long? ath_7_, long? ath_8_, short? distance, short? stroke, string relayage, string reaction1, string reaction2, string reaction3, string reaction4 )
{
static public List<Relay> Get(OdbcConnection connection)
{
  var collection = new List<Relay>();
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
  var arg0 = reader.GetInt32(0); /* RELAY nullable false*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* MEET nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* LO_HI nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* TEAM nullable true*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* LETTER nullable false*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* AGE_RANGE nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* SEX nullable false*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* ATH(1) nullable true*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* ATH(2) nullable true*/
  var arg9 = reader.IsDBNull(9) ? (long?)null :reader.GetInt32(9); /* ATH(3) nullable true*/
  var arg10 = reader.IsDBNull(10) ? (long?)null :reader.GetInt32(10); /* ATH(4) nullable true*/
  var arg11 = reader.IsDBNull(11) ? (long?)null :reader.GetInt32(11); /* ATH(5) nullable true*/
  var arg12 = reader.IsDBNull(12) ? (long?)null :reader.GetInt32(12); /* ATH(6) nullable true*/
  var arg13 = reader.IsDBNull(13) ? (long?)null :reader.GetInt32(13); /* ATH(7) nullable true*/
  var arg14 = reader.IsDBNull(14) ? (long?)null :reader.GetInt32(14); /* ATH(8) nullable true*/
  var arg15 = reader.IsDBNull(15) ? (short?)null :reader.GetInt16(15); /* DISTANCE nullable true*/
  var arg16 = reader.IsDBNull(16) ? (short?)null :reader.GetInt16(16); /* STROKE nullable true*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* RELAYAGE nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* REACTION1 nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* REACTION2 nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* REACTION3 nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* REACTION4 nullable false*/
      collection.Add( new Relay(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21));
    }
  }
  return collection;
}
  // Properties
  public long Relay_{ get; } = relay;
  public long? Meet{ get; } = meet;
  public short? Lo_hi{ get; } = lo_hi;
  public long? Team{ get; } = team;
  public string Letter{ get; } = letter;
  public short? Age_range{ get; } = age_range;
  public string Sex{ get; } = sex;
  public long? Ath_1_{ get; } = ath_1_;
  public long? Ath_2_{ get; } = ath_2_;
  public long? Ath_3_{ get; } = ath_3_;
  public long? Ath_4_{ get; } = ath_4_;
  public long? Ath_5_{ get; } = ath_5_;
  public long? Ath_6_{ get; } = ath_6_;
  public long? Ath_7_{ get; } = ath_7_;
  public long? Ath_8_{ get; } = ath_8_;
  public short? Distance{ get; } = distance;
  public short? Stroke{ get; } = stroke;
  public string Relayage{ get; } = relayage;
  public string Reaction1{ get; } = reaction1;
  public string Reaction2{ get; } = reaction2;
  public string Reaction3{ get; } = reaction3;
  public string Reaction4{ get; } = reaction4;
}
}
}
