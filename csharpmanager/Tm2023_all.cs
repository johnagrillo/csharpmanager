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
/// CREATE TABLE [2023_ALL]
/// (
/// [Std] Long Integer,
/// [Lo_Age] Integer,
/// [Hi_age] Integer,
/// [F(0)] Long Integer,
/// [F(1)] Long Integer,
/// [F(2)] Long Integer,
/// [F(3)] Long Integer,
/// [F(4)] Long Integer,
/// [F(5)] Long Integer,
/// [F(6)] Long Integer,
/// [F(7)] Long Integer,
/// [F(8)] Long Integer,
/// [F(9)] Long Integer,
/// [F(10)] Long Integer,
/// [F(11)] Long Integer,
/// [F(12)] Long Integer,
/// [F(13)] Long Integer,
/// [F(14)] Long Integer,
/// [F(15)] Long Integer,
/// [F(16)] Long Integer,
/// [F(17)] Long Integer,
/// [F(18)] Long Integer,
/// [F(19)] Long Integer,
/// [F(20)] Long Integer,
/// [F(21)] Long Integer,
/// [F(22)] Long Integer,
/// [F(23)] Long Integer,
/// [F(24)] Long Integer,
/// [F(25)] Long Integer,
/// [F(26)] Long Integer,
/// [F(27)] Long Integer,
/// [F(28)] Long Integer,
/// [F(29)] Long Integer,
/// [F(30)] Long Integer,
/// [F(31)] Long Integer,
/// [F(32)] Long Integer,
/// [F(33)] Long Integer,
/// [F(34)] Long Integer,
/// [F(35)] Long Integer,
/// [S(0)] Long Integer,
/// [S(1)] Long Integer,
/// [S(2)] Long Integer,
/// [S(3)] Long Integer,
/// [S(4)] Long Integer,
/// [S(5)] Long Integer,
/// [S(6)] Long Integer,
/// [S(7)] Long Integer,
/// [S(8)] Long Integer,
/// [S(9)] Long Integer,
/// [S(10)] Long Integer,
/// [S(11)] Long Integer,
/// [S(12)] Long Integer,
/// [S(13)] Long Integer,
/// [S(14)] Long Integer,
/// [S(15)] Long Integer,
/// [S(16)] Long Integer,
/// [S(17)] Long Integer,
/// [S(18)] Long Integer,
/// [S(19)] Long Integer,
/// [S(20)] Long Integer,
/// [S(21)] Long Integer,
/// [S(22)] Long Integer,
/// [S(23)] Long Integer,
/// [S(24)] Long Integer,
/// [S(25)] Long Integer,
/// [S(26)] Long Integer,
/// [S(27)] Long Integer,
/// [S(28)] Long Integer,
/// [S(29)] Long Integer,
/// [S(30)] Long Integer,
/// [S(31)] Long Integer,
/// [S(32)] Long Integer,
/// [S(33)] Long Integer,
/// [S(34)] Long Integer,
/// [S(35)] Long Integer,
/// [Distance] Integer,
/// [Stroke] Integer,
/// [Sex] Text (2),
/// [I_R] Text (2),
/// [Division] Text (4)
/// );

public class Tm2023_all 
{
List<Tm2023_all> get(OdbcConnection connection)
{
  var collection = new List<Tm2023_all>();
  string query = "select * from 2023_ALL";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
      var arg0 = reader.GetInt64(1); /* Std */
      var arg1 = reader.GetInt16(2); /* Lo_Age */
      var arg2 = reader.GetInt16(3); /* Hi_age */
      var arg3 = reader.GetInt64(4); /* F(0) */
      var arg4 = reader.GetInt64(5); /* F(1) */
      var arg5 = reader.GetInt64(6); /* F(2) */
      var arg6 = reader.GetInt64(7); /* F(3) */
      var arg7 = reader.GetInt64(8); /* F(4) */
      var arg8 = reader.GetInt64(9); /* F(5) */
      var arg9 = reader.GetInt64(10); /* F(6) */
      var arg10 = reader.GetInt64(11); /* F(7) */
      var arg11 = reader.GetInt64(12); /* F(8) */
      var arg12 = reader.GetInt64(13); /* F(9) */
      var arg13 = reader.GetInt64(14); /* F(10) */
      var arg14 = reader.GetInt64(15); /* F(11) */
      var arg15 = reader.GetInt64(16); /* F(12) */
      var arg16 = reader.GetInt64(17); /* F(13) */
      var arg17 = reader.GetInt64(18); /* F(14) */
      var arg18 = reader.GetInt64(19); /* F(15) */
      var arg19 = reader.GetInt64(20); /* F(16) */
      var arg20 = reader.GetInt64(21); /* F(17) */
      var arg21 = reader.GetInt64(22); /* F(18) */
      var arg22 = reader.GetInt64(23); /* F(19) */
      var arg23 = reader.GetInt64(24); /* F(20) */
      var arg24 = reader.GetInt64(25); /* F(21) */
      var arg25 = reader.GetInt64(26); /* F(22) */
      var arg26 = reader.GetInt64(27); /* F(23) */
      var arg27 = reader.GetInt64(28); /* F(24) */
      var arg28 = reader.GetInt64(29); /* F(25) */
      var arg29 = reader.GetInt64(30); /* F(26) */
      var arg30 = reader.GetInt64(31); /* F(27) */
      var arg31 = reader.GetInt64(32); /* F(28) */
      var arg32 = reader.GetInt64(33); /* F(29) */
      var arg33 = reader.GetInt64(34); /* F(30) */
      var arg34 = reader.GetInt64(35); /* F(31) */
      var arg35 = reader.GetInt64(36); /* F(32) */
      var arg36 = reader.GetInt64(37); /* F(33) */
      var arg37 = reader.GetInt64(38); /* F(34) */
      var arg38 = reader.GetInt64(39); /* F(35) */
      var arg39 = reader.GetInt64(40); /* S(0) */
      var arg40 = reader.GetInt64(41); /* S(1) */
      var arg41 = reader.GetInt64(42); /* S(2) */
      var arg42 = reader.GetInt64(43); /* S(3) */
      var arg43 = reader.GetInt64(44); /* S(4) */
      var arg44 = reader.GetInt64(45); /* S(5) */
      var arg45 = reader.GetInt64(46); /* S(6) */
      var arg46 = reader.GetInt64(47); /* S(7) */
      var arg47 = reader.GetInt64(48); /* S(8) */
      var arg48 = reader.GetInt64(49); /* S(9) */
      var arg49 = reader.GetInt64(50); /* S(10) */
      var arg50 = reader.GetInt64(51); /* S(11) */
      var arg51 = reader.GetInt64(52); /* S(12) */
      var arg52 = reader.GetInt64(53); /* S(13) */
      var arg53 = reader.GetInt64(54); /* S(14) */
      var arg54 = reader.GetInt64(55); /* S(15) */
      var arg55 = reader.GetInt64(56); /* S(16) */
      var arg56 = reader.GetInt64(57); /* S(17) */
      var arg57 = reader.GetInt64(58); /* S(18) */
      var arg58 = reader.GetInt64(59); /* S(19) */
      var arg59 = reader.GetInt64(60); /* S(20) */
      var arg60 = reader.GetInt64(61); /* S(21) */
      var arg61 = reader.GetInt64(62); /* S(22) */
      var arg62 = reader.GetInt64(63); /* S(23) */
      var arg63 = reader.GetInt64(64); /* S(24) */
      var arg64 = reader.GetInt64(65); /* S(25) */
      var arg65 = reader.GetInt64(66); /* S(26) */
      var arg66 = reader.GetInt64(67); /* S(27) */
      var arg67 = reader.GetInt64(68); /* S(28) */
      var arg68 = reader.GetInt64(69); /* S(29) */
      var arg69 = reader.GetInt64(70); /* S(30) */
      var arg70 = reader.GetInt64(71); /* S(31) */
      var arg71 = reader.GetInt64(72); /* S(32) */
      var arg72 = reader.GetInt64(73); /* S(33) */
      var arg73 = reader.GetInt64(74); /* S(34) */
      var arg74 = reader.GetInt64(75); /* S(35) */
      var arg75 = reader.GetInt16(76); /* Distance */
      var arg76 = reader.GetInt16(77); /* Stroke */
      var arg77 = reader.GetTextReader(78).ToString(); /* Sex */
      var arg78 = reader.GetTextReader(79).ToString(); /* I_R */
      var arg79 = reader.GetTextReader(80).ToString(); /* Division */
      collection.Add( new Tm2023_all(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79));
    }
  }
  return collection;
}
  // Properties
  public long Std{ get; }
  public short LoAge{ get; }
  public short HiAge{ get; }
  public long F_0_{ get; }
  public long F_1_{ get; }
  public long F_2_{ get; }
  public long F_3_{ get; }
  public long F_4_{ get; }
  public long F_5_{ get; }
  public long F_6_{ get; }
  public long F_7_{ get; }
  public long F_8_{ get; }
  public long F_9_{ get; }
  public long F_10_{ get; }
  public long F_11_{ get; }
  public long F_12_{ get; }
  public long F_13_{ get; }
  public long F_14_{ get; }
  public long F_15_{ get; }
  public long F_16_{ get; }
  public long F_17_{ get; }
  public long F_18_{ get; }
  public long F_19_{ get; }
  public long F_20_{ get; }
  public long F_21_{ get; }
  public long F_22_{ get; }
  public long F_23_{ get; }
  public long F_24_{ get; }
  public long F_25_{ get; }
  public long F_26_{ get; }
  public long F_27_{ get; }
  public long F_28_{ get; }
  public long F_29_{ get; }
  public long F_30_{ get; }
  public long F_31_{ get; }
  public long F_32_{ get; }
  public long F_33_{ get; }
  public long F_34_{ get; }
  public long F_35_{ get; }
  public long S_0_{ get; }
  public long S_1_{ get; }
  public long S_2_{ get; }
  public long S_3_{ get; }
  public long S_4_{ get; }
  public long S_5_{ get; }
  public long S_6_{ get; }
  public long S_7_{ get; }
  public long S_8_{ get; }
  public long S_9_{ get; }
  public long S_10_{ get; }
  public long S_11_{ get; }
  public long S_12_{ get; }
  public long S_13_{ get; }
  public long S_14_{ get; }
  public long S_15_{ get; }
  public long S_16_{ get; }
  public long S_17_{ get; }
  public long S_18_{ get; }
  public long S_19_{ get; }
  public long S_20_{ get; }
  public long S_21_{ get; }
  public long S_22_{ get; }
  public long S_23_{ get; }
  public long S_24_{ get; }
  public long S_25_{ get; }
  public long S_26_{ get; }
  public long S_27_{ get; }
  public long S_28_{ get; }
  public long S_29_{ get; }
  public long S_30_{ get; }
  public long S_31_{ get; }
  public long S_32_{ get; }
  public long S_33_{ get; }
  public long S_34_{ get; }
  public long S_35_{ get; }
  public short Distance{ get; }
  public short Stroke{ get; }
  public string Sex{ get; }
  public string I_r{ get; }
  public string Division{ get; }
  // Constructor
  Tm2023_all(long std, short loAge, short hiAge, long f_0_, long f_1_, long f_2_, long f_3_, long f_4_, long f_5_, long f_6_, long f_7_, long f_8_, long f_9_, long f_10_, long f_11_, long f_12_, long f_13_, long f_14_, long f_15_, long f_16_, long f_17_, long f_18_, long f_19_, long f_20_, long f_21_, long f_22_, long f_23_, long f_24_, long f_25_, long f_26_, long f_27_, long f_28_, long f_29_, long f_30_, long f_31_, long f_32_, long f_33_, long f_34_, long f_35_, long s_0_, long s_1_, long s_2_, long s_3_, long s_4_, long s_5_, long s_6_, long s_7_, long s_8_, long s_9_, long s_10_, long s_11_, long s_12_, long s_13_, long s_14_, long s_15_, long s_16_, long s_17_, long s_18_, long s_19_, long s_20_, long s_21_, long s_22_, long s_23_, long s_24_, long s_25_, long s_26_, long s_27_, long s_28_, long s_29_, long s_30_, long s_31_, long s_32_, long s_33_, long s_34_, long s_35_, short distance, short stroke, string sex, string i_r, string division )
  {
    Std = std;
    LoAge = loAge;
    HiAge = hiAge;
    F_0_ = f_0_;
    F_1_ = f_1_;
    F_2_ = f_2_;
    F_3_ = f_3_;
    F_4_ = f_4_;
    F_5_ = f_5_;
    F_6_ = f_6_;
    F_7_ = f_7_;
    F_8_ = f_8_;
    F_9_ = f_9_;
    F_10_ = f_10_;
    F_11_ = f_11_;
    F_12_ = f_12_;
    F_13_ = f_13_;
    F_14_ = f_14_;
    F_15_ = f_15_;
    F_16_ = f_16_;
    F_17_ = f_17_;
    F_18_ = f_18_;
    F_19_ = f_19_;
    F_20_ = f_20_;
    F_21_ = f_21_;
    F_22_ = f_22_;
    F_23_ = f_23_;
    F_24_ = f_24_;
    F_25_ = f_25_;
    F_26_ = f_26_;
    F_27_ = f_27_;
    F_28_ = f_28_;
    F_29_ = f_29_;
    F_30_ = f_30_;
    F_31_ = f_31_;
    F_32_ = f_32_;
    F_33_ = f_33_;
    F_34_ = f_34_;
    F_35_ = f_35_;
    S_0_ = s_0_;
    S_1_ = s_1_;
    S_2_ = s_2_;
    S_3_ = s_3_;
    S_4_ = s_4_;
    S_5_ = s_5_;
    S_6_ = s_6_;
    S_7_ = s_7_;
    S_8_ = s_8_;
    S_9_ = s_9_;
    S_10_ = s_10_;
    S_11_ = s_11_;
    S_12_ = s_12_;
    S_13_ = s_13_;
    S_14_ = s_14_;
    S_15_ = s_15_;
    S_16_ = s_16_;
    S_17_ = s_17_;
    S_18_ = s_18_;
    S_19_ = s_19_;
    S_20_ = s_20_;
    S_21_ = s_21_;
    S_22_ = s_22_;
    S_23_ = s_23_;
    S_24_ = s_24_;
    S_25_ = s_25_;
    S_26_ = s_26_;
    S_27_ = s_27_;
    S_28_ = s_28_;
    S_29_ = s_29_;
    S_30_ = s_30_;
    S_31_ = s_31_;
    S_32_ = s_32_;
    S_33_ = s_33_;
    S_34_ = s_34_;
    S_35_ = s_35_;
    Distance = distance;
    Stroke = stroke;
    Sex = sex;
    I_r = i_r;
    Division = division;
  }
}
