using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [Regions]
/// // (
/// // [Reg_no] Long Integer,
/// // [Reg_abbr] Text (4),
/// // [Reg_name] Text (40),
/// // [fem_size] Integer,
/// // [male_size] Integer,
/// // [combined_size] Integer
/// // );

public class Regions(long? regNo, string regAbbr, string regName, short? fem_size, short? male_size, short? combined_size )
{
static public List<Regions> Get(OdbcConnection connection)
{
  var collection = new List<Regions>();
  string query = "select * from Regions";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Reg_no nullable true*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Reg_abbr nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Reg_name nullable false*/
  var arg3 = reader.IsDBNull(3) ? (short?)null :reader.GetInt16(3); /* fem_size nullable true*/
  var arg4 = reader.IsDBNull(4) ? (short?)null :reader.GetInt16(4); /* male_size nullable true*/
  var arg5 = reader.IsDBNull(5) ? (short?)null :reader.GetInt16(5); /* combined_size nullable true*/
      collection.Add( new Regions(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long? RegNo{ get; } = regNo;
  public string RegAbbr{ get; } = regAbbr;
  public string RegName{ get; } = regName;
  public short? Fem_size{ get; } = fem_size;
  public short? Male_size{ get; } = male_size;
  public short? Combined_size{ get; } = combined_size;
}
}
}
