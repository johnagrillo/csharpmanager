using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [RECORDS]
/// // (
/// // [Record] Long Integer,
/// // [Lo_Age] Integer,
/// // [Hi_Age] Integer,
/// // [RecText] Text (160),
/// // [RecDate] DateTime,
/// // [RecTime] Long Integer,
/// // [RecLSC] Text (6),
/// // [RecTeam] Text (10),
/// // [Ex] Text (2),
/// // [Distance] Integer,
/// // [Stroke] Integer,
/// // [Sex] Text (2),
/// // [I_R] Text (2),
/// // [Rec] Long Integer,
/// // [Course] Text (2),
/// // [Division] Text (4)
/// // );

public class Records(long? record, short? loAge, short? hiAge, string recText, DateTime? recDate, long? recTime, string recLSC, string recTeam, string ex, short? distance, short? stroke, string sex, string i_r, long? rec, string course, string division )
{
static public List<Records> Get(OdbcConnection connection)
{
  var collection = new List<Records>();
  string query = "select * from RECORDS";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Record nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Lo_Age nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* Hi_Age nullable true*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* RecText nullable false*/
  var arg4 = reader.IsDBNull(4) ? (DateTime?)null :reader.GetDateTime(4); /* RecDate nullable true*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* RecTime nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* RecLSC nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* RecTeam nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* Ex nullable false*/
  var arg9 = reader.IsDBNull(9) ? (short?)null :reader.GetInt16(9); /* Distance nullable true*/
  var arg10 = reader.IsDBNull(10) ? (short?)null :reader.GetInt16(10); /* Stroke nullable true*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* Sex nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* I_R nullable false*/
  var arg13 = reader.IsDBNull(13) ? (long?)null :reader.GetInt32(13); /* Rec nullable true*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* Course nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* Division nullable false*/
      collection.Add( new Records(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
    }
  }
  return collection;
}
  // Properties
  public long? Record{ get; } = record;
  public short? LoAge{ get; } = loAge;
  public short? HiAge{ get; } = hiAge;
  public string RecText{ get; } = recText;
  public DateTime? RecDate{ get; } = recDate;
  public long? RecTime{ get; } = recTime;
  public string RecLSC{ get; } = recLSC;
  public string RecTeam{ get; } = recTeam;
  public string Ex{ get; } = ex;
  public short? Distance{ get; } = distance;
  public short? Stroke{ get; } = stroke;
  public string Sex{ get; } = sex;
  public string I_r{ get; } = i_r;
  public long? Rec{ get; } = rec;
  public string Course{ get; } = course;
  public string Division{ get; } = division;
}
}
}
