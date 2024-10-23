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
/// CREATE TABLE [FAVORITES]
/// (
/// [FavName] Text (16),
/// [FavTeam] Text (10),
/// [FavGroup] Text (6),
/// [FavSubGr] Text (6),
/// [FavClass] Text (6),
/// [FavMeetType] Text (6),
/// [FavCourse] Text (10),
/// [FavWMGroup] Text (6),
/// [FavWMSubGr] Text (6),
/// [SinceDate] DateTime,
/// [UntilDate] DateTime,
/// [FavTeamDiv] Text (6)
/// );

public class TmFavorites 
{
List<TmFavorites> get(OdbcConnection connection)
{
  var collection = new List<TmFavorites>();
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
      var arg0 = reader.GetTextReader(1).ToString(); /* FavName */
      var arg1 = reader.GetTextReader(2).ToString(); /* FavTeam */
      var arg2 = reader.GetTextReader(3).ToString(); /* FavGroup */
      var arg3 = reader.GetTextReader(4).ToString(); /* FavSubGr */
      var arg4 = reader.GetTextReader(5).ToString(); /* FavClass */
      var arg5 = reader.GetTextReader(6).ToString(); /* FavMeetType */
      var arg6 = reader.GetTextReader(7).ToString(); /* FavCourse */
      var arg7 = reader.GetTextReader(8).ToString(); /* FavWMGroup */
      var arg8 = reader.GetTextReader(9).ToString(); /* FavWMSubGr */
      var arg9 = reader.GetDateTime(10); /* SinceDate */
      var arg10 = reader.GetDateTime(11); /* UntilDate */
      var arg11 = reader.GetTextReader(12).ToString(); /* FavTeamDiv */
      collection.Add( new TmFavorites(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11));
    }
  }
  return collection;
}
  // Properties
  public string FavName{ get; }
  public string FavTeam{ get; }
  public string FavGroup{ get; }
  public string FavSubGr{ get; }
  public string FavClass{ get; }
  public string FavMeetType{ get; }
  public string FavCourse{ get; }
  public string FavWMGroup{ get; }
  public string FavWMSubGr{ get; }
  public DateTime SinceDate{ get; }
  public DateTime UntilDate{ get; }
  public string FavTeamDiv{ get; }
  // Constructor
  TmFavorites(string favName, string favTeam, string favGroup, string favSubGr, string favClass, string favMeetType, string favCourse, string favWMGroup, string favWMSubGr, DateTime sinceDate, DateTime untilDate, string favTeamDiv )
  {
    FavName = favName;
    FavTeam = favTeam;
    FavGroup = favGroup;
    FavSubGr = favSubGr;
    FavClass = favClass;
    FavMeetType = favMeetType;
    FavCourse = favCourse;
    FavWMGroup = favWMGroup;
    FavWMSubGr = favWMSubGr;
    SinceDate = sinceDate;
    UntilDate = untilDate;
    FavTeamDiv = favTeamDiv;
  }
}
