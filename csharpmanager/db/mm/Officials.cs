using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Officials]
/// // (
/// // [Official_no] Long Integer,
/// // [Last_name] Text (40),
/// // [First_name] Text (40),
/// // [Initial] Text (2),
/// // [Pref_name] Text (40),
/// // [Home_email] Text (100)
/// // );

public class Officials(long? officialNo, string lastName, string firstName, string initial, string prefName, string homeEmail )
{
static public List<Officials> Get(OdbcConnection connection)
{
  var collection = new List<Officials>();
  string query = "select * from Officials";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Official_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Last_name nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* First_name nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* Initial nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* Pref_name nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* Home_email nullable false*/
      collection.Add( new Officials(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long? OfficialNo{ get; } = officialNo;
  public string LastName{ get; } = lastName;
  public string FirstName{ get; } = firstName;
  public string Initial{ get; } = initial;
  public string PrefName{ get; } = prefName;
  public string HomeEmail{ get; } = homeEmail;
}
}
}
