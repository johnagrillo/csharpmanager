using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [CCtime]
/// // (
/// // [Event_ptr] Long Integer,
/// // [Ath_no] Long Integer,
/// // [Chute_rank] Long Integer,
/// // [Chute_no] Integer,
/// // [Fin_hand] Boolean NOT NULL,
/// // [Fin_stat] Text (2),
/// // [Fin_Time] Single
/// // );

public class Cctime(long? eventPtr, long? athNo, long? chuteRank, short? chuteNo, bool finHand, string finStat, float? finTime )
{
static public List<Cctime> Get(OdbcConnection connection)
{
  var collection = new List<Cctime>();
  string query = "select * from CCtime";
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
  var arg2 = reader.IsDBNull(2) ? (long?)null :reader.GetInt32(2); /* Chute_rank nullable true*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* Chute_no nullable true*/
  var arg4 = reader.GetBoolean(4); /* Fin_hand nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Fin_stat nullable false*/
  var arg6 = reader.IsDBNull(6) ? (float?)null :reader.GetFloat(6); /* Fin_Time nullable true*/
      collection.Add( new Cctime(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public long? EventPtr{ get; } = eventPtr;
  public long? AthNo{ get; } = athNo;
  public long? ChuteRank{ get; } = chuteRank;
  public short? ChuteNo{ get; } = chuteNo;
  public bool FinHand{ get; } = finHand;
  public string FinStat{ get; } = finStat;
  public float? FinTime{ get; } = finTime;
}
}
}
