using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace mm
{
/// //
/// //
/// // CREATE TABLE [CheckList]
/// // (
/// // [meet_setup] Boolean NOT NULL,
/// // [athlete_pref] Boolean NOT NULL,
/// // [seeding_pref] Boolean NOT NULL,
/// // [report_pref] Boolean NOT NULL,
/// // [printer_setup] Boolean NOT NULL,
/// // [entry_pref] Boolean NOT NULL,
/// // [scoring_setup] Boolean NOT NULL,
/// // [entryfee_surcharges] Boolean NOT NULL,
/// // [divreg_names] Boolean NOT NULL,
/// // [dir_pref] Boolean NOT NULL,
/// // [event_setup] Boolean NOT NULL,
/// // [records_setup] Boolean NOT NULL,
/// // [timestd_setup] Boolean NOT NULL,
/// // [timing_setup] Boolean NOT NULL,
/// // [scbd_setup] Boolean NOT NULL,
/// // [session_setup] Boolean NOT NULL
/// // );

public class Checklist(bool meet_setup, bool athlete_pref, bool seeding_pref, bool report_pref, bool printer_setup, bool entry_pref, bool scoring_setup, bool entryfee_surcharges, bool divreg_names, bool dir_pref, bool event_setup, bool records_setup, bool timestd_setup, bool timing_setup, bool scbd_setup, bool session_setup )
{
static public List<Checklist> Get(OdbcConnection connection)
{
  var collection = new List<Checklist>();
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
  var arg0 = reader.GetBoolean(0); /* meet_setup nullable false*/
  var arg1 = reader.GetBoolean(1); /* athlete_pref nullable false*/
  var arg2 = reader.GetBoolean(2); /* seeding_pref nullable false*/
  var arg3 = reader.GetBoolean(3); /* report_pref nullable false*/
  var arg4 = reader.GetBoolean(4); /* printer_setup nullable false*/
  var arg5 = reader.GetBoolean(5); /* entry_pref nullable false*/
  var arg6 = reader.GetBoolean(6); /* scoring_setup nullable false*/
  var arg7 = reader.GetBoolean(7); /* entryfee_surcharges nullable false*/
  var arg8 = reader.GetBoolean(8); /* divreg_names nullable false*/
  var arg9 = reader.GetBoolean(9); /* dir_pref nullable false*/
  var arg10 = reader.GetBoolean(10); /* event_setup nullable false*/
  var arg11 = reader.GetBoolean(11); /* records_setup nullable false*/
  var arg12 = reader.GetBoolean(12); /* timestd_setup nullable false*/
  var arg13 = reader.GetBoolean(13); /* timing_setup nullable false*/
  var arg14 = reader.GetBoolean(14); /* scbd_setup nullable false*/
  var arg15 = reader.GetBoolean(15); /* session_setup nullable false*/
      collection.Add( new Checklist(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15));
    }
  }
  return collection;
}
  // Properties
  public bool Meet_setup{ get; } = meet_setup;
  public bool Athlete_pref{ get; } = athlete_pref;
  public bool Seeding_pref{ get; } = seeding_pref;
  public bool Report_pref{ get; } = report_pref;
  public bool Printer_setup{ get; } = printer_setup;
  public bool Entry_pref{ get; } = entry_pref;
  public bool Scoring_setup{ get; } = scoring_setup;
  public bool Entryfee_surcharges{ get; } = entryfee_surcharges;
  public bool Divreg_names{ get; } = divreg_names;
  public bool Dir_pref{ get; } = dir_pref;
  public bool Event_setup{ get; } = event_setup;
  public bool Records_setup{ get; } = records_setup;
  public bool Timestd_setup{ get; } = timestd_setup;
  public bool Timing_setup{ get; } = timing_setup;
  public bool Scbd_setup{ get; } = scbd_setup;
  public bool Session_setup{ get; } = session_setup;
}
}
}
