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
/// CREATE TABLE [CheckList]
/// (
/// [meet_setup] Boolean NOT NULL,
/// [athlete_pref] Boolean NOT NULL,
/// [seeding_pref] Boolean NOT NULL,
/// [report_pref] Boolean NOT NULL,
/// [printer_setup] Boolean NOT NULL,
/// [entry_pref] Boolean NOT NULL,
/// [scoring_setup] Boolean NOT NULL,
/// [entryfee_surcharges] Boolean NOT NULL,
/// [divreg_names] Boolean NOT NULL,
/// [dir_pref] Boolean NOT NULL,
/// [event_setup] Boolean NOT NULL,
/// [records_setup] Boolean NOT NULL,
/// [timestd_setup] Boolean NOT NULL,
/// [timing_setup] Boolean NOT NULL,
/// [scbd_setup] Boolean NOT NULL,
/// [session_setup] Boolean NOT NULL
/// );

public class MmChecklist 
{
List<MmChecklist> get(OdbcConnection connection)
{
  var collection = new List<MmChecklist>();
  string query = "select * from CheckList";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetBoolean(1); /* meet_setup */
      var arg1 = reader.GetBoolean(2); /* athlete_pref */
      var arg2 = reader.GetBoolean(3); /* seeding_pref */
      var arg3 = reader.GetBoolean(4); /* report_pref */
      var arg4 = reader.GetBoolean(5); /* printer_setup */
      var arg5 = reader.GetBoolean(6); /* entry_pref */
      var arg6 = reader.GetBoolean(7); /* scoring_setup */
      var arg7 = reader.GetBoolean(8); /* entryfee_surcharges */
      var arg8 = reader.GetBoolean(9); /* divreg_names */
      var arg9 = reader.GetBoolean(10); /* dir_pref */
      var arg10 = reader.GetBoolean(11); /* event_setup */
      var arg11 = reader.GetBoolean(12); /* records_setup */
      var arg12 = reader.GetBoolean(13); /* timestd_setup */
      var arg13 = reader.GetBoolean(14); /* timing_setup */
      var arg14 = reader.GetBoolean(15); /* scbd_setup */
      var arg15 = reader.GetBoolean(16); /* session_setup */
      collection.Add( new MmChecklist(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
    }
  }
  return collection;
}
  // Properties
  public bool Meet_setup{ get; }
  public bool Athlete_pref{ get; }
  public bool Seeding_pref{ get; }
  public bool Report_pref{ get; }
  public bool Printer_setup{ get; }
  public bool Entry_pref{ get; }
  public bool Scoring_setup{ get; }
  public bool Entryfee_surcharges{ get; }
  public bool Divreg_names{ get; }
  public bool Dir_pref{ get; }
  public bool Event_setup{ get; }
  public bool Records_setup{ get; }
  public bool Timestd_setup{ get; }
  public bool Timing_setup{ get; }
  public bool Scbd_setup{ get; }
  public bool Session_setup{ get; }
  // Constructor
  MmChecklist(bool meet_setup, bool athlete_pref, bool seeding_pref, bool report_pref, bool printer_setup, bool entry_pref, bool scoring_setup, bool entryfee_surcharges, bool divreg_names, bool dir_pref, bool event_setup, bool records_setup, bool timestd_setup, bool timing_setup, bool scbd_setup, bool session_setup )
  {
    Meet_setup = meet_setup;
    Athlete_pref = athlete_pref;
    Seeding_pref = seeding_pref;
    Report_pref = report_pref;
    Printer_setup = printer_setup;
    Entry_pref = entry_pref;
    Scoring_setup = scoring_setup;
    Entryfee_surcharges = entryfee_surcharges;
    Divreg_names = divreg_names;
    Dir_pref = dir_pref;
    Event_setup = event_setup;
    Records_setup = records_setup;
    Timestd_setup = timestd_setup;
    Timing_setup = timing_setup;
    Scbd_setup = scbd_setup;
    Session_setup = session_setup;
  }
}
