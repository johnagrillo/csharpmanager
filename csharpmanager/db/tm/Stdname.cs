using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [STDNAME]
/// // (
/// // [StdFile] Text (16),
/// // [Year] Text (8),
/// // [Descript] Text (50),
/// // [D1] Text (8),
/// // [D2] Text (8),
/// // [D3] Text (8),
/// // [D4] Text (8),
/// // [D5] Text (8),
/// // [D6] Text (8),
/// // [D7] Text (8),
/// // [D8] Text (8),
/// // [D9] Text (8),
/// // [D10] Text (8),
/// // [D11] Text (8),
/// // [D12] Text (8),
/// // [D1Des] Text (30),
/// // [D2Des] Text (30),
/// // [D3Des] Text (30),
/// // [D4Des] Text (30),
/// // [D5Des] Text (30),
/// // [D6Des] Text (30),
/// // [D7Des] Text (30),
/// // [D8Des] Text (30),
/// // [D9Des] Text (30),
/// // [D10Des] Text (30),
/// // [D11Des] Text (30),
/// // [D12Des] Text (30)
/// // );

public class Stdname(string stdFile, string year, string descript, string d1, string d2, string d3, string d4, string d5, string d6, string d7, string d8, string d9, string d10, string d11, string d12, string d1Des, string d2Des, string d3Des, string d4Des, string d5Des, string d6Des, string d7Des, string d8Des, string d9Des, string d10Des, string d11Des, string d12Des )
{
static public List<Stdname> Get(OdbcConnection connection)
{
  var collection = new List<Stdname>();
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
  var arg0 = reader.GetTextReader(0).ReadLine(); /* StdFile nullable false*/
  var arg1 = reader.GetTextReader(1).ReadLine(); /* Year nullable false*/
  var arg2 = reader.GetTextReader(2).ReadLine(); /* Descript nullable false*/
  var arg3 = reader.GetTextReader(3).ReadLine(); /* D1 nullable false*/
  var arg4 = reader.GetTextReader(4).ReadLine(); /* D2 nullable false*/
  var arg5 = reader.GetTextReader(5).ReadLine(); /* D3 nullable false*/
  var arg6 = reader.GetTextReader(6).ReadLine(); /* D4 nullable false*/
  var arg7 = reader.GetTextReader(7).ReadLine(); /* D5 nullable false*/
  var arg8 = reader.GetTextReader(8).ReadLine(); /* D6 nullable false*/
  var arg9 = reader.GetTextReader(9).ReadLine(); /* D7 nullable false*/
  var arg10 = reader.GetTextReader(10).ReadLine(); /* D8 nullable false*/
  var arg11 = reader.GetTextReader(11).ReadLine(); /* D9 nullable false*/
  var arg12 = reader.GetTextReader(12).ReadLine(); /* D10 nullable false*/
  var arg13 = reader.GetTextReader(13).ReadLine(); /* D11 nullable false*/
  var arg14 = reader.GetTextReader(14).ReadLine(); /* D12 nullable false*/
  var arg15 = reader.GetTextReader(15).ReadLine(); /* D1Des nullable false*/
  var arg16 = reader.GetTextReader(16).ReadLine(); /* D2Des nullable false*/
  var arg17 = reader.GetTextReader(17).ReadLine(); /* D3Des nullable false*/
  var arg18 = reader.GetTextReader(18).ReadLine(); /* D4Des nullable false*/
  var arg19 = reader.GetTextReader(19).ReadLine(); /* D5Des nullable false*/
  var arg20 = reader.GetTextReader(20).ReadLine(); /* D6Des nullable false*/
  var arg21 = reader.GetTextReader(21).ReadLine(); /* D7Des nullable false*/
  var arg22 = reader.GetTextReader(22).ReadLine(); /* D8Des nullable false*/
  var arg23 = reader.GetTextReader(23).ReadLine(); /* D9Des nullable false*/
  var arg24 = reader.GetTextReader(24).ReadLine(); /* D10Des nullable false*/
  var arg25 = reader.GetTextReader(25).ReadLine(); /* D11Des nullable false*/
  var arg26 = reader.GetTextReader(26).ReadLine(); /* D12Des nullable false*/
      collection.Add( new Stdname(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26));
    }
  }
  return collection;
}
  // Properties
  public string StdFile{ get; } = stdFile;
  public string Year{ get; } = year;
  public string Descript{ get; } = descript;
  public string D1{ get; } = d1;
  public string D2{ get; } = d2;
  public string D3{ get; } = d3;
  public string D4{ get; } = d4;
  public string D5{ get; } = d5;
  public string D6{ get; } = d6;
  public string D7{ get; } = d7;
  public string D8{ get; } = d8;
  public string D9{ get; } = d9;
  public string D10{ get; } = d10;
  public string D11{ get; } = d11;
  public string D12{ get; } = d12;
  public string D1Des{ get; } = d1Des;
  public string D2Des{ get; } = d2Des;
  public string D3Des{ get; } = d3Des;
  public string D4Des{ get; } = d4Des;
  public string D5Des{ get; } = d5Des;
  public string D6Des{ get; } = d6Des;
  public string D7Des{ get; } = d7Des;
  public string D8Des{ get; } = d8Des;
  public string D9Des{ get; } = d9Des;
  public string D10Des{ get; } = d10Des;
  public string D11Des{ get; } = d11Des;
  public string D12Des{ get; } = d12Des;
}
}
}
