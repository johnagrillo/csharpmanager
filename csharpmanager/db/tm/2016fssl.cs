using System;
using System.Collections.Generic;
using System.Data.Odbc;
namespace db
{
namespace tm
{
/// //
/// //
/// // CREATE TABLE [2016FSSL]
/// // (
/// // [Std] Long Integer,
/// // [Lo_Age] Integer,
/// // [Hi_age] Integer,
/// // [F(0)] Long Integer,
/// // [F(1)] Long Integer,
/// // [F(2)] Long Integer,
/// // [F(3)] Long Integer,
/// // [F(4)] Long Integer,
/// // [F(5)] Long Integer,
/// // [F(6)] Long Integer,
/// // [F(7)] Long Integer,
/// // [F(8)] Long Integer,
/// // [F(9)] Long Integer,
/// // [F(10)] Long Integer,
/// // [F(11)] Long Integer,
/// // [F(12)] Long Integer,
/// // [F(13)] Long Integer,
/// // [F(14)] Long Integer,
/// // [F(15)] Long Integer,
/// // [F(16)] Long Integer,
/// // [F(17)] Long Integer,
/// // [F(18)] Long Integer,
/// // [F(19)] Long Integer,
/// // [F(20)] Long Integer,
/// // [F(21)] Long Integer,
/// // [F(22)] Long Integer,
/// // [F(23)] Long Integer,
/// // [F(24)] Long Integer,
/// // [F(25)] Long Integer,
/// // [F(26)] Long Integer,
/// // [F(27)] Long Integer,
/// // [F(28)] Long Integer,
/// // [F(29)] Long Integer,
/// // [F(30)] Long Integer,
/// // [F(31)] Long Integer,
/// // [F(32)] Long Integer,
/// // [F(33)] Long Integer,
/// // [F(34)] Long Integer,
/// // [F(35)] Long Integer,
/// // [S(0)] Long Integer,
/// // [S(1)] Long Integer,
/// // [S(2)] Long Integer,
/// // [S(3)] Long Integer,
/// // [S(4)] Long Integer,
/// // [S(5)] Long Integer,
/// // [S(6)] Long Integer,
/// // [S(7)] Long Integer,
/// // [S(8)] Long Integer,
/// // [S(9)] Long Integer,
/// // [S(10)] Long Integer,
/// // [S(11)] Long Integer,
/// // [S(12)] Long Integer,
/// // [S(13)] Long Integer,
/// // [S(14)] Long Integer,
/// // [S(15)] Long Integer,
/// // [S(16)] Long Integer,
/// // [S(17)] Long Integer,
/// // [S(18)] Long Integer,
/// // [S(19)] Long Integer,
/// // [S(20)] Long Integer,
/// // [S(21)] Long Integer,
/// // [S(22)] Long Integer,
/// // [S(23)] Long Integer,
/// // [S(24)] Long Integer,
/// // [S(25)] Long Integer,
/// // [S(26)] Long Integer,
/// // [S(27)] Long Integer,
/// // [S(28)] Long Integer,
/// // [S(29)] Long Integer,
/// // [S(30)] Long Integer,
/// // [S(31)] Long Integer,
/// // [S(32)] Long Integer,
/// // [S(33)] Long Integer,
/// // [S(34)] Long Integer,
/// // [S(35)] Long Integer,
/// // [Distance] Integer,
/// // [Stroke] Integer,
/// // [Sex] Text (2),
/// // [I_R] Text (2),
/// // [Division] Text (4)
/// // );

public class T2016fssl(long? std, short? loAge, short? hiAge, long? f_0_, long? f_1_, long? f_2_, long? f_3_, long? f_4_, long? f_5_, long? f_6_, long? f_7_, long? f_8_, long? f_9_, long? f_10_, long? f_11_, long? f_12_, long? f_13_, long? f_14_, long? f_15_, long? f_16_, long? f_17_, long? f_18_, long? f_19_, long? f_20_, long? f_21_, long? f_22_, long? f_23_, long? f_24_, long? f_25_, long? f_26_, long? f_27_, long? f_28_, long? f_29_, long? f_30_, long? f_31_, long? f_32_, long? f_33_, long? f_34_, long? f_35_, long? s_0_, long? s_1_, long? s_2_, long? s_3_, long? s_4_, long? s_5_, long? s_6_, long? s_7_, long? s_8_, long? s_9_, long? s_10_, long? s_11_, long? s_12_, long? s_13_, long? s_14_, long? s_15_, long? s_16_, long? s_17_, long? s_18_, long? s_19_, long? s_20_, long? s_21_, long? s_22_, long? s_23_, long? s_24_, long? s_25_, long? s_26_, long? s_27_, long? s_28_, long? s_29_, long? s_30_, long? s_31_, long? s_32_, long? s_33_, long? s_34_, long? s_35_, short? distance, short? stroke, string sex, string i_r, string division )
{
static public List<T2016fssl> Get(OdbcConnection connection)
{
  var collection = new List<T2016fssl>();
  string query = "select * from 2016FSSL";
  using (OdbcCommand command = new OdbcCommand(query, connection))
  using (OdbcDataReader reader = command.ExecuteReader())
{
  while (reader.Read())
  {
      ///
      /// GetXX has to called in the same order as the sql order.
      /// Cant make these arguments to a constructor, since the order is indeterminate.
      ///
  var arg0 = reader.IsDBNull(0) ? (long?)null :reader.GetInt32(0); /* Std nullable true*/
  var arg1 = reader.IsDBNull(1) ? (short?)null :reader.GetInt16(1); /* Lo_Age nullable true*/
  var arg2 = reader.IsDBNull(2) ? (short?)null :reader.GetInt16(2); /* Hi_age nullable true*/
  var arg3 = reader.IsDBNull(3) ? (long?)null :reader.GetInt32(3); /* F(0) nullable true*/
  var arg4 = reader.IsDBNull(4) ? (long?)null :reader.GetInt32(4); /* F(1) nullable true*/
  var arg5 = reader.IsDBNull(5) ? (long?)null :reader.GetInt32(5); /* F(2) nullable true*/
  var arg6 = reader.IsDBNull(6) ? (long?)null :reader.GetInt32(6); /* F(3) nullable true*/
  var arg7 = reader.IsDBNull(7) ? (long?)null :reader.GetInt32(7); /* F(4) nullable true*/
  var arg8 = reader.IsDBNull(8) ? (long?)null :reader.GetInt32(8); /* F(5) nullable true*/
  var arg9 = reader.IsDBNull(9) ? (long?)null :reader.GetInt32(9); /* F(6) nullable true*/
  var arg10 = reader.IsDBNull(10) ? (long?)null :reader.GetInt32(10); /* F(7) nullable true*/
  var arg11 = reader.IsDBNull(11) ? (long?)null :reader.GetInt32(11); /* F(8) nullable true*/
  var arg12 = reader.IsDBNull(12) ? (long?)null :reader.GetInt32(12); /* F(9) nullable true*/
  var arg13 = reader.IsDBNull(13) ? (long?)null :reader.GetInt32(13); /* F(10) nullable true*/
  var arg14 = reader.IsDBNull(14) ? (long?)null :reader.GetInt32(14); /* F(11) nullable true*/
  var arg15 = reader.IsDBNull(15) ? (long?)null :reader.GetInt32(15); /* F(12) nullable true*/
  var arg16 = reader.IsDBNull(16) ? (long?)null :reader.GetInt32(16); /* F(13) nullable true*/
  var arg17 = reader.IsDBNull(17) ? (long?)null :reader.GetInt32(17); /* F(14) nullable true*/
  var arg18 = reader.IsDBNull(18) ? (long?)null :reader.GetInt32(18); /* F(15) nullable true*/
  var arg19 = reader.IsDBNull(19) ? (long?)null :reader.GetInt32(19); /* F(16) nullable true*/
  var arg20 = reader.IsDBNull(20) ? (long?)null :reader.GetInt32(20); /* F(17) nullable true*/
  var arg21 = reader.IsDBNull(21) ? (long?)null :reader.GetInt32(21); /* F(18) nullable true*/
  var arg22 = reader.IsDBNull(22) ? (long?)null :reader.GetInt32(22); /* F(19) nullable true*/
  var arg23 = reader.IsDBNull(23) ? (long?)null :reader.GetInt32(23); /* F(20) nullable true*/
  var arg24 = reader.IsDBNull(24) ? (long?)null :reader.GetInt32(24); /* F(21) nullable true*/
  var arg25 = reader.IsDBNull(25) ? (long?)null :reader.GetInt32(25); /* F(22) nullable true*/
  var arg26 = reader.IsDBNull(26) ? (long?)null :reader.GetInt32(26); /* F(23) nullable true*/
  var arg27 = reader.IsDBNull(27) ? (long?)null :reader.GetInt32(27); /* F(24) nullable true*/
  var arg28 = reader.IsDBNull(28) ? (long?)null :reader.GetInt32(28); /* F(25) nullable true*/
  var arg29 = reader.IsDBNull(29) ? (long?)null :reader.GetInt32(29); /* F(26) nullable true*/
  var arg30 = reader.IsDBNull(30) ? (long?)null :reader.GetInt32(30); /* F(27) nullable true*/
  var arg31 = reader.IsDBNull(31) ? (long?)null :reader.GetInt32(31); /* F(28) nullable true*/
  var arg32 = reader.IsDBNull(32) ? (long?)null :reader.GetInt32(32); /* F(29) nullable true*/
  var arg33 = reader.IsDBNull(33) ? (long?)null :reader.GetInt32(33); /* F(30) nullable true*/
  var arg34 = reader.IsDBNull(34) ? (long?)null :reader.GetInt32(34); /* F(31) nullable true*/
  var arg35 = reader.IsDBNull(35) ? (long?)null :reader.GetInt32(35); /* F(32) nullable true*/
  var arg36 = reader.IsDBNull(36) ? (long?)null :reader.GetInt32(36); /* F(33) nullable true*/
  var arg37 = reader.IsDBNull(37) ? (long?)null :reader.GetInt32(37); /* F(34) nullable true*/
  var arg38 = reader.IsDBNull(38) ? (long?)null :reader.GetInt32(38); /* F(35) nullable true*/
  var arg39 = reader.IsDBNull(39) ? (long?)null :reader.GetInt32(39); /* S(0) nullable true*/
  var arg40 = reader.IsDBNull(40) ? (long?)null :reader.GetInt32(40); /* S(1) nullable true*/
  var arg41 = reader.IsDBNull(41) ? (long?)null :reader.GetInt32(41); /* S(2) nullable true*/
  var arg42 = reader.IsDBNull(42) ? (long?)null :reader.GetInt32(42); /* S(3) nullable true*/
  var arg43 = reader.IsDBNull(43) ? (long?)null :reader.GetInt32(43); /* S(4) nullable true*/
  var arg44 = reader.IsDBNull(44) ? (long?)null :reader.GetInt32(44); /* S(5) nullable true*/
  var arg45 = reader.IsDBNull(45) ? (long?)null :reader.GetInt32(45); /* S(6) nullable true*/
  var arg46 = reader.IsDBNull(46) ? (long?)null :reader.GetInt32(46); /* S(7) nullable true*/
  var arg47 = reader.IsDBNull(47) ? (long?)null :reader.GetInt32(47); /* S(8) nullable true*/
  var arg48 = reader.IsDBNull(48) ? (long?)null :reader.GetInt32(48); /* S(9) nullable true*/
  var arg49 = reader.IsDBNull(49) ? (long?)null :reader.GetInt32(49); /* S(10) nullable true*/
  var arg50 = reader.IsDBNull(50) ? (long?)null :reader.GetInt32(50); /* S(11) nullable true*/
  var arg51 = reader.IsDBNull(51) ? (long?)null :reader.GetInt32(51); /* S(12) nullable true*/
  var arg52 = reader.IsDBNull(52) ? (long?)null :reader.GetInt32(52); /* S(13) nullable true*/
  var arg53 = reader.IsDBNull(53) ? (long?)null :reader.GetInt32(53); /* S(14) nullable true*/
  var arg54 = reader.IsDBNull(54) ? (long?)null :reader.GetInt32(54); /* S(15) nullable true*/
  var arg55 = reader.IsDBNull(55) ? (long?)null :reader.GetInt32(55); /* S(16) nullable true*/
  var arg56 = reader.IsDBNull(56) ? (long?)null :reader.GetInt32(56); /* S(17) nullable true*/
  var arg57 = reader.IsDBNull(57) ? (long?)null :reader.GetInt32(57); /* S(18) nullable true*/
  var arg58 = reader.IsDBNull(58) ? (long?)null :reader.GetInt32(58); /* S(19) nullable true*/
  var arg59 = reader.IsDBNull(59) ? (long?)null :reader.GetInt32(59); /* S(20) nullable true*/
  var arg60 = reader.IsDBNull(60) ? (long?)null :reader.GetInt32(60); /* S(21) nullable true*/
  var arg61 = reader.IsDBNull(61) ? (long?)null :reader.GetInt32(61); /* S(22) nullable true*/
  var arg62 = reader.IsDBNull(62) ? (long?)null :reader.GetInt32(62); /* S(23) nullable true*/
  var arg63 = reader.IsDBNull(63) ? (long?)null :reader.GetInt32(63); /* S(24) nullable true*/
  var arg64 = reader.IsDBNull(64) ? (long?)null :reader.GetInt32(64); /* S(25) nullable true*/
  var arg65 = reader.IsDBNull(65) ? (long?)null :reader.GetInt32(65); /* S(26) nullable true*/
  var arg66 = reader.IsDBNull(66) ? (long?)null :reader.GetInt32(66); /* S(27) nullable true*/
  var arg67 = reader.IsDBNull(67) ? (long?)null :reader.GetInt32(67); /* S(28) nullable true*/
  var arg68 = reader.IsDBNull(68) ? (long?)null :reader.GetInt32(68); /* S(29) nullable true*/
  var arg69 = reader.IsDBNull(69) ? (long?)null :reader.GetInt32(69); /* S(30) nullable true*/
  var arg70 = reader.IsDBNull(70) ? (long?)null :reader.GetInt32(70); /* S(31) nullable true*/
  var arg71 = reader.IsDBNull(71) ? (long?)null :reader.GetInt32(71); /* S(32) nullable true*/
  var arg72 = reader.IsDBNull(72) ? (long?)null :reader.GetInt32(72); /* S(33) nullable true*/
  var arg73 = reader.IsDBNull(73) ? (long?)null :reader.GetInt32(73); /* S(34) nullable true*/
  var arg74 = reader.IsDBNull(74) ? (long?)null :reader.GetInt32(74); /* S(35) nullable true*/
  var arg75 = reader.IsDBNull(75) ? (short?)null :reader.GetInt16(75); /* Distance nullable true*/
  var arg76 = reader.IsDBNull(76) ? (short?)null :reader.GetInt16(76); /* Stroke nullable true*/
  var arg77 = reader.GetTextReader(77).ReadLine(); /* Sex nullable false*/
  var arg78 = reader.GetTextReader(78).ReadLine(); /* I_R nullable false*/
  var arg79 = reader.GetTextReader(79).ReadLine(); /* Division nullable false*/
      collection.Add( new T2016fssl(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, arg33, arg34, arg35, arg36, arg37, arg38, arg39, arg40, arg41, arg42, arg43, arg44, arg45, arg46, arg47, arg48, arg49, arg50, arg51, arg52, arg53, arg54, arg55, arg56, arg57, arg58, arg59, arg60, arg61, arg62, arg63, arg64, arg65, arg66, arg67, arg68, arg69, arg70, arg71, arg72, arg73, arg74, arg75, arg76, arg77, arg78, arg79));
    }
  }
  return collection;
}
  // Properties
  public long? Std{ get; } = std;
  public short? LoAge{ get; } = loAge;
  public short? HiAge{ get; } = hiAge;
  public long? F_0_{ get; } = f_0_;
  public long? F_1_{ get; } = f_1_;
  public long? F_2_{ get; } = f_2_;
  public long? F_3_{ get; } = f_3_;
  public long? F_4_{ get; } = f_4_;
  public long? F_5_{ get; } = f_5_;
  public long? F_6_{ get; } = f_6_;
  public long? F_7_{ get; } = f_7_;
  public long? F_8_{ get; } = f_8_;
  public long? F_9_{ get; } = f_9_;
  public long? F_10_{ get; } = f_10_;
  public long? F_11_{ get; } = f_11_;
  public long? F_12_{ get; } = f_12_;
  public long? F_13_{ get; } = f_13_;
  public long? F_14_{ get; } = f_14_;
  public long? F_15_{ get; } = f_15_;
  public long? F_16_{ get; } = f_16_;
  public long? F_17_{ get; } = f_17_;
  public long? F_18_{ get; } = f_18_;
  public long? F_19_{ get; } = f_19_;
  public long? F_20_{ get; } = f_20_;
  public long? F_21_{ get; } = f_21_;
  public long? F_22_{ get; } = f_22_;
  public long? F_23_{ get; } = f_23_;
  public long? F_24_{ get; } = f_24_;
  public long? F_25_{ get; } = f_25_;
  public long? F_26_{ get; } = f_26_;
  public long? F_27_{ get; } = f_27_;
  public long? F_28_{ get; } = f_28_;
  public long? F_29_{ get; } = f_29_;
  public long? F_30_{ get; } = f_30_;
  public long? F_31_{ get; } = f_31_;
  public long? F_32_{ get; } = f_32_;
  public long? F_33_{ get; } = f_33_;
  public long? F_34_{ get; } = f_34_;
  public long? F_35_{ get; } = f_35_;
  public long? S_0_{ get; } = s_0_;
  public long? S_1_{ get; } = s_1_;
  public long? S_2_{ get; } = s_2_;
  public long? S_3_{ get; } = s_3_;
  public long? S_4_{ get; } = s_4_;
  public long? S_5_{ get; } = s_5_;
  public long? S_6_{ get; } = s_6_;
  public long? S_7_{ get; } = s_7_;
  public long? S_8_{ get; } = s_8_;
  public long? S_9_{ get; } = s_9_;
  public long? S_10_{ get; } = s_10_;
  public long? S_11_{ get; } = s_11_;
  public long? S_12_{ get; } = s_12_;
  public long? S_13_{ get; } = s_13_;
  public long? S_14_{ get; } = s_14_;
  public long? S_15_{ get; } = s_15_;
  public long? S_16_{ get; } = s_16_;
  public long? S_17_{ get; } = s_17_;
  public long? S_18_{ get; } = s_18_;
  public long? S_19_{ get; } = s_19_;
  public long? S_20_{ get; } = s_20_;
  public long? S_21_{ get; } = s_21_;
  public long? S_22_{ get; } = s_22_;
  public long? S_23_{ get; } = s_23_;
  public long? S_24_{ get; } = s_24_;
  public long? S_25_{ get; } = s_25_;
  public long? S_26_{ get; } = s_26_;
  public long? S_27_{ get; } = s_27_;
  public long? S_28_{ get; } = s_28_;
  public long? S_29_{ get; } = s_29_;
  public long? S_30_{ get; } = s_30_;
  public long? S_31_{ get; } = s_31_;
  public long? S_32_{ get; } = s_32_;
  public long? S_33_{ get; } = s_33_;
  public long? S_34_{ get; } = s_34_;
  public long? S_35_{ get; } = s_35_;
  public short? Distance{ get; } = distance;
  public short? Stroke{ get; } = stroke;
  public string Sex{ get; } = sex;
  public string I_r{ get; } = i_r;
  public string Division{ get; } = division;
}
}
}
