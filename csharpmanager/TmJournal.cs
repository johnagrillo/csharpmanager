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
/// CREATE TABLE [JOURNAL]
/// (
/// [JDate] DateTime,
/// [Subject] Text (40),
/// [Comment] Text (510)
/// );

public class TmJournal 
{
List<TmJournal> get(OdbcConnection connection)
{
  var collection = new List<TmJournal>();
  string query = "select * from JOURNAL";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetDateTime(1); /* JDate */
      var arg1 = reader.GetTextReader(2).ToString(); /* Subject */
      var arg2 = reader.GetTextReader(3).ToString(); /* Comment */
      collection.Add( new TmJournal(arg0, arg1, arg2));
    }
  }
  return collection;
}
  // Properties
  public DateTime JDate{ get; }
  public string Subject{ get; }
  public string Comment{ get; }
  // Constructor
  TmJournal(DateTime jDate, string subject, string comment )
  {
    JDate = jDate;
    Subject = subject;
    Comment = comment;
  }
}
