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
/// CREATE TABLE [STDNAME]
/// (
/// [StdFile] Text (16),
/// [Year] Text (8),
/// [Descript] Text (50),
/// [D1] Text (8),
/// [D2] Text (8),
/// [D3] Text (8),
/// [D4] Text (8),
/// [D5] Text (8),
/// [D6] Text (8),
/// [D7] Text (8),
/// [D8] Text (8),
/// [D9] Text (8),
/// [D10] Text (8),
/// [D11] Text (8),
/// [D12] Text (8),
/// [D1Des] Text (30),
/// [D2Des] Text (30),
/// [D3Des] Text (30),
/// [D4Des] Text (30),
/// [D5Des] Text (30),
/// [D6Des] Text (30),
/// [D7Des] Text (30),
/// [D8Des] Text (30),
/// [D9Des] Text (30),
/// [D10Des] Text (30),
/// [D11Des] Text (30),
/// [D12Des] Text (30)
/// );

public class TmStdname 
{
List<TmStdname> get(OdbcConnection connection)
{
  var collection = new List<TmStdname>();
  string query = "select * from STDNAME";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetTextReader(1).ToString(); /* StdFile */
      var arg1 = reader.GetTextReader(2).ToString(); /* Year */
      var arg2 = reader.GetTextReader(3).ToString(); /* Descript */
      var arg3 = reader.GetTextReader(4).ToString(); /* D1 */
      var arg4 = reader.GetTextReader(5).ToString(); /* D2 */
      var arg5 = reader.GetTextReader(6).ToString(); /* D3 */
      var arg6 = reader.GetTextReader(7).ToString(); /* D4 */
      var arg7 = reader.GetTextReader(8).ToString(); /* D5 */
      var arg8 = reader.GetTextReader(9).ToString(); /* D6 */
      var arg9 = reader.GetTextReader(10).ToString(); /* D7 */
      var arg10 = reader.GetTextReader(11).ToString(); /* D8 */
      var arg11 = reader.GetTextReader(12).ToString(); /* D9 */
      var arg12 = reader.GetTextReader(13).ToString(); /* D10 */
      var arg13 = reader.GetTextReader(14).ToString(); /* D11 */
      var arg14 = reader.GetTextReader(15).ToString(); /* D12 */
      var arg15 = reader.GetTextReader(16).ToString(); /* D1Des */
      var arg16 = reader.GetTextReader(17).ToString(); /* D2Des */
      var arg17 = reader.GetTextReader(18).ToString(); /* D3Des */
      var arg18 = reader.GetTextReader(19).ToString(); /* D4Des */
      var arg19 = reader.GetTextReader(20).ToString(); /* D5Des */
      var arg20 = reader.GetTextReader(21).ToString(); /* D6Des */
      var arg21 = reader.GetTextReader(22).ToString(); /* D7Des */
      var arg22 = reader.GetTextReader(23).ToString(); /* D8Des */
      var arg23 = reader.GetTextReader(24).ToString(); /* D9Des */
      var arg24 = reader.GetTextReader(25).ToString(); /* D10Des */
      var arg25 = reader.GetTextReader(26).ToString(); /* D11Des */
      var arg26 = reader.GetTextReader(27).ToString(); /* D12Des */
      collection.Add( new TmStdname(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26));
    }
  }
  return collection;
}
  // Properties
  public string StdFile{ get; }
  public string Year{ get; }
  public string Descript{ get; }
  public string D1{ get; }
  public string D2{ get; }
  public string D3{ get; }
  public string D4{ get; }
  public string D5{ get; }
  public string D6{ get; }
  public string D7{ get; }
  public string D8{ get; }
  public string D9{ get; }
  public string D10{ get; }
  public string D11{ get; }
  public string D12{ get; }
  public string D1Des{ get; }
  public string D2Des{ get; }
  public string D3Des{ get; }
  public string D4Des{ get; }
  public string D5Des{ get; }
  public string D6Des{ get; }
  public string D7Des{ get; }
  public string D8Des{ get; }
  public string D9Des{ get; }
  public string D10Des{ get; }
  public string D11Des{ get; }
  public string D12Des{ get; }
  // Constructor
  TmStdname(string stdFile, string year, string descript, string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10, string d11, string d12, string d1Des, string d2Des, string d3Des, string d4Des, string d5Des, string d6Des, string d7Des, string d8Des, string d9Des, string d10Des, string d11Des, string d12Des )
  {
    StdFile = stdFile;
    Year = year;
    Descript = descript;
    D1 = d1;
    D2 = d2;
    D3 = d3;
    D4 = d4;
    D5 = d5;
    D6 = d6;
    D7 = d7;
    D8 = d8;
    D9 = d9;
    D10 = d10;
    D11 = d11;
    D12 = d12;
    D1Des = d1Des;
    D2Des = d2Des;
    D3Des = d3Des;
    D4Des = d4Des;
    D5Des = d5Des;
    D6Des = d6Des;
    D7Des = d7Des;
    D8Des = d8Des;
    D9Des = d9Des;
    D10Des = d10Des;
    D11Des = d11Des;
    D12Des = d12Des;
  }
}
