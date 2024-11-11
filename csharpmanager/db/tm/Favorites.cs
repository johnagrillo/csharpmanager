using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [FAVORITES]
/// // (
/// // [FavName] Text (16),
/// // [FavTeam] Text (10),
/// // [FavGroup] Text (6),
/// // [FavSubGr] Text (6),
/// // [FavClass] Text (6),
/// // [FavMeetType] Text (6),
/// // [FavCourse] Text (10),
/// // [FavWMGroup] Text (6),
/// // [FavWMSubGr] Text (6),
/// // [SinceDate] DateTime,
/// // [UntilDate] DateTime,
/// // [FavTeamDiv] Text (6)
/// // );

public class Favorites(string favName, string favTeam, string favGroup, string favSubGr, string favClass, string favMeetType, string favCourse, string favWMGroup, string favWMSubGr, DateTime? sinceDate, DateTime? untilDate, string favTeamDiv )
{
static public List<Favorites> Get(OdbcConnection connection)
{
  var collection = new List<Favorites>();
  string query = "select * from FAVORITES";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.GetTextReader(0).ReadLine(); /* FavName nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* FavTeam nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* FavGroup nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* FavSubGr nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* FavClass nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* FavMeetType nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* FavCourse nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* FavWMGroup nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* FavWMSubGr nullable false*/
  var arg9 = reader.IsDBNull(9) ? (DateTime?)null :reader.GetDateTime(9); /* SinceDate nullable true*/
  var arg10 = reader.IsDBNull(10) ? (DateTime?)null :reader.GetDateTime(10); /* UntilDate nullable true*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* FavTeamDiv nullable false*/
      collection.Add( new Favorites(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
    }
  }
  return collection;
}
  // Properties
  public string FavName{ get; } = favName;
  public string FavTeam{ get; } = favTeam;
  public string FavGroup{ get; } = favGroup;
  public string FavSubGr{ get; } = favSubGr;
  public string FavClass{ get; } = favClass;
  public string FavMeetType{ get; } = favMeetType;
  public string FavCourse{ get; } = favCourse;
  public string FavWMGroup{ get; } = favWMGroup;
  public string FavWMSubGr{ get; } = favWMSubGr;
  public DateTime? SinceDate{ get; } = sinceDate;
  public DateTime? UntilDate{ get; } = untilDate;
  public string FavTeamDiv{ get; } = favTeamDiv;
}
}
}
