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
/// CREATE TABLE [CustomLayoutValues]
/// (
/// [LayoutID] Long Integer,
/// [Line] Byte,
/// [Sequence] Byte,
/// [FieldName] Text (40),
/// [FieldSize] Byte,
/// [Abbr] Text (30),
/// [RJustified] Boolean NOT NULL
/// );

public class TmCustomlayoutvalues 
{
List<TmCustomlayoutvalues> get(OdbcConnection connection)
{
  var collection = new List<TmCustomlayoutvalues>();
  string query = "select * from CustomLayoutValues";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* LayoutID */
      var arg1 = reader.GetByte(2); /* Line */
      var arg2 = reader.GetByte(3); /* Sequence */
      var arg3 = reader.GetTextReader(4).ToString(); /* FieldName */
      var arg4 = reader.GetByte(5); /* FieldSize */
      var arg5 = reader.GetTextReader(6).ToString(); /* Abbr */
      var arg6 = reader.GetBoolean(7); /* RJustified */
      collection.Add( new TmCustomlayoutvalues(arg0, arg1, arg2, arg3, arg4, arg5, arg6));
    }
  }
  return collection;
}
  // Properties
  public long LayoutID{ get; }
  public byte Line{ get; }
  public byte Sequence{ get; }
  public string FieldName{ get; }
  public byte FieldSize{ get; }
  public string Abbr{ get; }
  public bool RJustified{ get; }
  // Constructor
  TmCustomlayoutvalues(long layoutID, byte line, byte sequence, string fieldName, byte fieldSize, string abbr, bool rJustified )
  {
    LayoutID = layoutID;
    Line = line;
    Sequence = sequence;
    FieldName = fieldName;
    FieldSize = fieldSize;
    Abbr = abbr;
    RJustified = rJustified;
  }
}
