using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [OMEINVITE]
/// // (
/// // [IMEET] Long Integer,
/// // [IATHLETE] Long Integer,
/// // [INVITEDATE] DateTime,
/// // [NEWADD] Boolean NOT NULL,
/// // [DELETED] Boolean NOT NULL,
/// // [ITEAM] Long Integer,
/// // [ITEAMCODE] Text (10),
/// // [INVITEEMAILSENT] DateTime
/// // );

public class Omeinvite(long? imeet, long? iathlete, DateTime? invitedate, bool newadd, bool deleted, long? iteam, string iteamcode, DateTime? inviteemailsent )
{
static public List<Omeinvite> Get(OdbcConnection connection)
{
  var collection = new List<Omeinvite>();
  string query = "select * from OMEINVITE";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* IMEET nullable true*/
  var arg1 = reader.IsDBNull(1) ? (long?)null :reader.GetInt32(1); /* IATHLETE nullable true*/
  var arg2 = reader.IsDBNull(2) ? (DateTime?)null :reader.GetDateTime(2); /* INVITEDATE nullable true*/
  var arg3 = reader.GetBoolean(3); /* NEWADD nullable false*/
  var arg4 = reader.GetBoolean(4); /* DELETED nullable false*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* ITEAM nullable true*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* ITEAMCODE nullable false*/
  var arg7 = reader.IsDBNull(7) ? (DateTime?)null :reader.GetDateTime(7); /* INVITEEMAILSENT nullable true*/
      collection.Add( new Omeinvite(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7));
    }
  }
  return collection;
}
  // Properties
  public long? Imeet{ get; } = imeet;
  public long? Iathlete{ get; } = iathlete;
  public DateTime? Invitedate{ get; } = invitedate;
  public bool Newadd{ get; } = newadd;
  public bool Deleted{ get; } = deleted;
  public long? Iteam{ get; } = iteam;
  public string Iteamcode{ get; } = iteamcode;
  public DateTime? Inviteemailsent{ get; } = inviteemailsent;
}
}
}
