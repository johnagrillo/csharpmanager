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
/// CREATE TABLE [TagNames]
/// (
/// [tag_ptr] Long Integer,
/// [tag_name] Text (8),
/// [for_scoring] Boolean NOT NULL,
/// [for_entryqual] Boolean NOT NULL,
/// [for_timestd] Boolean NOT NULL,
/// [tag_desc] Text (40)
/// );

public class MmTagnames 
{
List<MmTagnames> get(OdbcConnection connection)
{
  var collection = new List<MmTagnames>();
  string query = "select * from TagNames";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* tag_ptr */
      var arg1 = reader.GetTextReader(2).ToString(); /* tag_name */
      var arg2 = reader.GetBoolean(3); /* for_scoring */
      var arg3 = reader.GetBoolean(4); /* for_entryqual */
      var arg4 = reader.GetBoolean(5); /* for_timestd */
      var arg5 = reader.GetTextReader(6).ToString(); /* tag_desc */
      collection.Add( new MmTagnames(arg0, arg1, arg2, arg3, arg4, arg5));
    }
  }
  return collection;
}
  // Properties
  public long Tag_ptr{ get; }
  public string Tag_name{ get; }
  public bool For_scoring{ get; }
  public bool For_entryqual{ get; }
  public bool For_timestd{ get; }
  public string Tag_desc{ get; }
  // Constructor
  MmTagnames(long tag_ptr, string tag_name, bool for_scoring, bool for_entryqual, bool for_timestd, string tag_desc )
  {
    Tag_ptr = tag_ptr;
    Tag_name = tag_name;
    For_scoring = for_scoring;
    For_entryqual = for_entryqual;
    For_timestd = for_timestd;
    Tag_desc = tag_desc;
  }
}
