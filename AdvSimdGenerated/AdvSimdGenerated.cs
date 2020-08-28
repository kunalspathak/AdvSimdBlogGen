
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;

public partial class AdvSimdMethods
{

private static  Vector64<ushort> Dummy_AbsTest(Vector64<short> value)
{
  return AdvSimd.Abs(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ushort> AbsTest(Vector64<short> value)
{
  return AdvSimd.Abs(value);
}



private static  Vector64<float> Dummy_AbsoluteCompareGreaterThanTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareGreaterThan(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> AbsoluteCompareGreaterThanTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareGreaterThan(left, right);
}



private static  Vector64<float> Dummy_AbsoluteCompareGreaterThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareGreaterThanOrEqual(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> AbsoluteCompareGreaterThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareGreaterThanOrEqual(left, right);
}



private static  Vector64<double> Dummy_AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanOrEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanOrEqualScalar(left, right);
}



private static  Vector64<double> Dummy_AbsoluteCompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteCompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanScalar(left, right);
}



private static  Vector64<float> Dummy_AbsoluteCompareLessThanTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareLessThan(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> AbsoluteCompareLessThanTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareLessThan(left, right);
}



private static  Vector64<float> Dummy_AbsoluteCompareLessThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareLessThanOrEqual(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> AbsoluteCompareLessThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.AbsoluteCompareLessThanOrEqual(left, right);
}



private static  Vector64<double> Dummy_AbsoluteCompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareLessThanOrEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteCompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareLessThanOrEqualScalar(left, right);
}



private static  Vector64<double> Dummy_AbsoluteCompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareLessThanScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteCompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareLessThanScalar(left, right);
}



private static  Vector64<byte> Dummy_AbsoluteDifferenceTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifference(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AbsoluteDifferenceTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifference(left, right);
}



private static  Vector64<byte> Dummy_AbsoluteDifferenceAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifferenceAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AbsoluteDifferenceAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifferenceAdd(addend, left, right);
}



private static  Vector64<double> Dummy_AbsoluteDifferenceScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteDifferenceScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteDifferenceScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteDifferenceScalar(left, right);
}



private static  Vector128<ushort> Dummy_AbsoluteDifferenceWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> AbsoluteDifferenceWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningLower(left, right);
}



private static  Vector128<ushort> Dummy_AbsoluteDifferenceWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningLowerAndAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> AbsoluteDifferenceWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningLowerAndAdd(addend, left, right);
}



private static  Vector128<ushort> Dummy_AbsoluteDifferenceWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningUpper(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> AbsoluteDifferenceWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningUpper(left, right);
}



private static  Vector128<ushort> Dummy_AbsoluteDifferenceWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningUpperAndAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> AbsoluteDifferenceWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.AbsoluteDifferenceWideningUpperAndAdd(addend, left, right);
}



private static  Vector64<short> Dummy_AbsSaturateTest(Vector64<short> value)
{
  return AdvSimd.AbsSaturate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> AbsSaturateTest(Vector64<short> value)
{
  return AdvSimd.AbsSaturate(value);
}



private static  Vector64<short> Dummy_AbsSaturateScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.AbsSaturateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> AbsSaturateScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.AbsSaturateScalar(value);
}



private static  Vector64<double> Dummy_AbsScalarTest(Vector64<double> value)
{
  return AdvSimd.AbsScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsScalarTest(Vector64<double> value)
{
  return AdvSimd.AbsScalar(value);
}



private static  Vector64<byte> Dummy_AddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Add(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Add(left, right);
}



private static  Vector64<byte> Dummy_AddAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.AddAcross(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.AddAcross(value);
}



private static  Vector64<ushort> Dummy_AddAcrossWideningTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.AddAcrossWidening(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ushort> AddAcrossWideningTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.AddAcrossWidening(value);
}



private static  Vector64<byte> Dummy_AddHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddHighNarrowingLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddHighNarrowingLower(left, right);
}



private static  Vector128<byte> Dummy_AddHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddHighNarrowingUpper(lower, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> AddHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddHighNarrowingUpper(lower, left, right);
}



private static  Vector64<byte> Dummy_AddPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AddPairwise(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AddPairwise(left, right);
}



private static  Vector64<float> Dummy_AddPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.AddPairwiseScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> AddPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.AddPairwiseScalar(value);
}



private static  Vector64<ushort> Dummy_AddPairwiseWideningTest(Vector64<byte> value)
{
  return AdvSimd.AddPairwiseWidening(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ushort> AddPairwiseWideningTest(Vector64<byte> value)
{
  return AdvSimd.AddPairwiseWidening(value);
}



private static  Vector64<ushort> Dummy_AddPairwiseWideningAndAddTest(Vector64<ushort> addend, Vector64<byte> value)
{
  return AdvSimd.AddPairwiseWideningAndAdd(addend, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ushort> AddPairwiseWideningAndAddTest(Vector64<ushort> addend, Vector64<byte> value)
{
  return AdvSimd.AddPairwiseWideningAndAdd(addend, value);
}



private static  Vector64<long> Dummy_AddPairwiseWideningAndAddScalarTest(Vector64<long> addend, Vector64<int> value)
{
  return AdvSimd.AddPairwiseWideningAndAddScalar(addend, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> AddPairwiseWideningAndAddScalarTest(Vector64<long> addend, Vector64<int> value)
{
  return AdvSimd.AddPairwiseWideningAndAddScalar(addend, value);
}



private static  Vector64<long> Dummy_AddPairwiseWideningScalarTest(Vector64<int> value)
{
  return AdvSimd.AddPairwiseWideningScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> AddPairwiseWideningScalarTest(Vector64<int> value)
{
  return AdvSimd.AddPairwiseWideningScalar(value);
}



private static  Vector64<byte> Dummy_AddRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddRoundedHighNarrowingLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddRoundedHighNarrowingLower(left, right);
}



private static  Vector128<byte> Dummy_AddRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddRoundedHighNarrowingUpper(lower, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> AddRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.AddRoundedHighNarrowingUpper(lower, left, right);
}



private static  Vector64<byte> Dummy_AddSaturateTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AddSaturate(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddSaturateTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AddSaturate(left, right);
}



private static  Vector64<long> Dummy_AddSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{
  return AdvSimd.AddSaturateScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> AddSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{
  return AdvSimd.AddSaturateScalar(left, right);
}



private static  Vector64<double> Dummy_AddScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.AddScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AddScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.AddScalar(left, right);
}



private static  Vector128<ushort> Dummy_AddWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AddWideningLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> AddWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.AddWideningLower(left, right);
}



private static  Vector128<ushort> Dummy_AddWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.AddWideningUpper(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> AddWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.AddWideningUpper(left, right);
}



private static  Vector64<byte> Dummy_AndTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.And(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AndTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.And(left, right);
}



private static  Vector64<byte> Dummy_BitwiseClearTest(Vector64<byte> value, Vector64<byte> mask)
{
  return AdvSimd.BitwiseClear(value, mask);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> BitwiseClearTest(Vector64<byte> value, Vector64<byte> mask)
{
  return AdvSimd.BitwiseClear(value, mask);
}



private static  Vector64<byte> Dummy_BitwiseSelectTest(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.BitwiseSelect(select, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> BitwiseSelectTest(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.BitwiseSelect(select, left, right);
}



private static  Vector64<float> Dummy_CeilingTest(Vector64<float> value)
{
  return AdvSimd.Ceiling(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> CeilingTest(Vector64<float> value)
{
  return AdvSimd.Ceiling(value);
}



private static  Vector64<double> Dummy_CeilingScalarTest(Vector64<double> value)
{
  return AdvSimd.CeilingScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CeilingScalarTest(Vector64<double> value)
{
  return AdvSimd.CeilingScalar(value);
}



private static  Vector64<byte> Dummy_CompareEqualTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareEqual(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareEqualTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareEqual(left, right);
}



private static  Vector64<double> Dummy_CompareEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareEqualScalar(left, right);
}



private static  Vector64<byte> Dummy_CompareGreaterThanTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareGreaterThan(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareGreaterThanTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareGreaterThan(left, right);
}



private static  Vector64<byte> Dummy_CompareGreaterThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareGreaterThanOrEqual(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareGreaterThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareGreaterThanOrEqual(left, right);
}



private static  Vector64<double> Dummy_CompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareGreaterThanOrEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareGreaterThanOrEqualScalar(left, right);
}



private static  Vector64<double> Dummy_CompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareGreaterThanScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareGreaterThanScalar(left, right);
}



private static  Vector64<byte> Dummy_CompareLessThanTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareLessThan(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareLessThanTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareLessThan(left, right);
}



private static  Vector64<byte> Dummy_CompareLessThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareLessThanOrEqual(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareLessThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareLessThanOrEqual(left, right);
}



private static  Vector64<double> Dummy_CompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareLessThanOrEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareLessThanOrEqualScalar(left, right);
}



private static  Vector64<double> Dummy_CompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareLessThanScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareLessThanScalar(left, right);
}



private static  Vector64<byte> Dummy_CompareTestTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareTest(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareTestTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareTest(left, right);
}



private static  Vector64<double> Dummy_CompareTestScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareTestScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareTestScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareTestScalar(left, right);
}



private static  Vector128<double> Dummy_ConvertToDoubleTest(Vector64<float> value)
{
  return AdvSimd.Arm64.ConvertToDouble(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<double> ConvertToDoubleTest(Vector64<float> value)
{
  return AdvSimd.Arm64.ConvertToDouble(value);
}



private static  Vector64<double> Dummy_ConvertToDoubleScalarTest(Vector64<long> value)
{
  return AdvSimd.Arm64.ConvertToDoubleScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ConvertToDoubleScalarTest(Vector64<long> value)
{
  return AdvSimd.Arm64.ConvertToDoubleScalar(value);
}



private static  Vector128<double> Dummy_ConvertToDoubleUpperTest(Vector128<float> value)
{
  return AdvSimd.Arm64.ConvertToDoubleUpper(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<double> ConvertToDoubleUpperTest(Vector128<float> value)
{
  return AdvSimd.Arm64.ConvertToDoubleUpper(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundAwayFromZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundAwayFromZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundAwayFromZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundAwayFromZero(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundAwayFromZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundAwayFromZeroScalar(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToEvenTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToEven(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToEvenTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToEven(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToEvenScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToEvenScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToEvenScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToEvenScalar(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToNegativeInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToNegativeInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinity(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinityScalar(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToPositiveInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToPositiveInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinity(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinityScalar(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToZero(value);
}



private static  Vector64<int> Dummy_ConvertToInt32RoundToZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ConvertToInt32RoundToZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToInt32RoundToZeroScalar(value);
}



private static  Vector128<long> Dummy_ConvertToInt64RoundAwayFromZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<long> ConvertToInt64RoundAwayFromZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZero(value);
}



private static  Vector64<long> Dummy_ConvertToInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ConvertToInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZeroScalar(value);
}



private static  Vector128<long> Dummy_ConvertToInt64RoundToEvenTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToEven(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<long> ConvertToInt64RoundToEvenTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToEven(value);
}



private static  Vector64<long> Dummy_ConvertToInt64RoundToEvenScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToEvenScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ConvertToInt64RoundToEvenScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToEvenScalar(value);
}



private static  Vector128<long> Dummy_ConvertToInt64RoundToNegativeInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<long> ConvertToInt64RoundToNegativeInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinity(value);
}



private static  Vector64<long> Dummy_ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinityScalar(value);
}



private static  Vector128<long> Dummy_ConvertToInt64RoundToPositiveInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<long> ConvertToInt64RoundToPositiveInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinity(value);
}



private static  Vector64<long> Dummy_ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinityScalar(value);
}



private static  Vector128<long> Dummy_ConvertToInt64RoundToZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<long> ConvertToInt64RoundToZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToZero(value);
}



private static  Vector64<long> Dummy_ConvertToInt64RoundToZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ConvertToInt64RoundToZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToInt64RoundToZeroScalar(value);
}



private static  Vector64<float> Dummy_ConvertToSingleTest(Vector64<int> value)
{
  return AdvSimd.ConvertToSingle(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ConvertToSingleTest(Vector64<int> value)
{
  return AdvSimd.ConvertToSingle(value);
}



private static  Vector64<float> Dummy_ConvertToSingleLowerTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ConvertToSingleLowerTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleLower(value);
}



private static  Vector64<float> Dummy_ConvertToSingleRoundToOddLowerTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ConvertToSingleRoundToOddLowerTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddLower(value);
}



private static  Vector128<float> Dummy_ConvertToSingleRoundToOddUpperTest(Vector64<float> lower, Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddUpper(lower, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<float> ConvertToSingleRoundToOddUpperTest(Vector64<float> lower, Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddUpper(lower, value);
}



private static  Vector64<float> Dummy_ConvertToSingleScalarTest(Vector64<int> value)
{
  return AdvSimd.ConvertToSingleScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ConvertToSingleScalarTest(Vector64<int> value)
{
  return AdvSimd.ConvertToSingleScalar(value);
}



private static  Vector128<float> Dummy_ConvertToSingleUpperTest(Vector64<float> lower, Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleUpper(lower, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<float> ConvertToSingleUpperTest(Vector64<float> lower, Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleUpper(lower, value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundAwayFromZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundAwayFromZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundAwayFromZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundAwayFromZero(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundAwayFromZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundAwayFromZeroScalar(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToEvenTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToEven(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToEvenTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToEven(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToEvenScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToEvenScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToEvenScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToEvenScalar(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToNegativeInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToNegativeInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinity(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinityScalar(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToPositiveInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToPositiveInfinityTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinity(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinityScalar(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToZeroTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToZero(value);
}



private static  Vector64<uint> Dummy_ConvertToUInt32RoundToZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<uint> ConvertToUInt32RoundToZeroScalarTest(Vector64<float> value)
{
  return AdvSimd.ConvertToUInt32RoundToZeroScalar(value);
}



private static  Vector128<ulong> Dummy_ConvertToUInt64RoundAwayFromZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ulong> ConvertToUInt64RoundAwayFromZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZero(value);
}



private static  Vector64<ulong> Dummy_ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZeroScalar(value);
}



private static  Vector128<ulong> Dummy_ConvertToUInt64RoundToEvenTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEven(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ulong> ConvertToUInt64RoundToEvenTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEven(value);
}



private static  Vector64<ulong> Dummy_ConvertToUInt64RoundToEvenScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEvenScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ConvertToUInt64RoundToEvenScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEvenScalar(value);
}



private static  Vector128<ulong> Dummy_ConvertToUInt64RoundToNegativeInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ulong> ConvertToUInt64RoundToNegativeInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinity(value);
}



private static  Vector64<ulong> Dummy_ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinityScalar(value);
}



private static  Vector128<ulong> Dummy_ConvertToUInt64RoundToPositiveInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ulong> ConvertToUInt64RoundToPositiveInfinityTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinity(value);
}



private static  Vector64<ulong> Dummy_ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinityScalar(value);
}



private static  Vector128<ulong> Dummy_ConvertToUInt64RoundToZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ulong> ConvertToUInt64RoundToZeroTest(Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZero(value);
}



private static  Vector64<ulong> Dummy_ConvertToUInt64RoundToZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ConvertToUInt64RoundToZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZeroScalar(value);
}



private static  Vector64<float> Dummy_DivideTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.Divide(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> DivideTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.Divide(left, right);
}



private static  Vector64<double> Dummy_DivideScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.DivideScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> DivideScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.DivideScalar(left, right);
}



private static  Vector128<byte> Dummy_DuplicateSelectedScalarToVector128Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector128(value, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> DuplicateSelectedScalarToVector128Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector128(value, 3);
}



private static  Vector64<byte> Dummy_DuplicateSelectedScalarToVector64Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector64(value, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> DuplicateSelectedScalarToVector64Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector64(value, 3);
}



private static  Vector128<byte> Dummy_DuplicateToVector128Test(byte value)
{
  return AdvSimd.DuplicateToVector128(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> DuplicateToVector128Test(byte value)
{
  return AdvSimd.DuplicateToVector128(value);
}



private static  Vector64<byte> Dummy_DuplicateToVector64Test(byte value)
{
  return AdvSimd.DuplicateToVector64(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> DuplicateToVector64Test(byte value)
{
  return AdvSimd.DuplicateToVector64(value);
}



private static  byte Dummy_ExtractTest(Vector64<byte> vector, byte index)
{
  return AdvSimd.Extract(vector, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  byte ExtractTest(Vector64<byte> vector, byte index)
{
  return AdvSimd.Extract(vector, 3);
}



private static  Vector64<byte> Dummy_ExtractNarrowingLowerTest(Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingLowerTest(Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingLower(value);
}



private static  Vector64<byte> Dummy_ExtractNarrowingSaturateLowerTest(Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingSaturateLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingSaturateLowerTest(Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingSaturateLower(value);
}



private static  Vector64<byte> Dummy_ExtractNarrowingSaturateScalarTest(Vector64<ushort> value)
{
  return AdvSimd.Arm64.ExtractNarrowingSaturateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingSaturateScalarTest(Vector64<ushort> value)
{
  return AdvSimd.Arm64.ExtractNarrowingSaturateScalar(value);
}



private static  Vector64<byte> Dummy_ExtractNarrowingSaturateUnsignedLowerTest(Vector128<short> value)
{
  return AdvSimd.ExtractNarrowingSaturateUnsignedLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingSaturateUnsignedLowerTest(Vector128<short> value)
{
  return AdvSimd.ExtractNarrowingSaturateUnsignedLower(value);
}



private static  Vector64<byte> Dummy_ExtractNarrowingSaturateUnsignedScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.ExtractNarrowingSaturateUnsignedScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingSaturateUnsignedScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.ExtractNarrowingSaturateUnsignedScalar(value);
}



private static  Vector128<byte> Dummy_ExtractNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value)
{
  return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(lower, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ExtractNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value)
{
  return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(lower, value);
}



private static  Vector128<byte> Dummy_ExtractNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingSaturateUpper(lower, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ExtractNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingSaturateUpper(lower, value);
}



private static  Vector128<byte> Dummy_ExtractNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingUpper(lower, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ExtractNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{
  return AdvSimd.ExtractNarrowingUpper(lower, value);
}



private static  Vector128<byte> Dummy_ExtractVector128Test(Vector128<byte> upper, Vector128<byte> lower, byte index)
{
  return AdvSimd.ExtractVector128(upper, lower, 5);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ExtractVector128Test(Vector128<byte> upper, Vector128<byte> lower, byte index)
{
  return AdvSimd.ExtractVector128(upper, lower, 5);
}



private static  Vector64<byte> Dummy_ExtractVector64Test(Vector64<byte> upper, Vector64<byte> lower, byte index)
{
  return AdvSimd.ExtractVector64(upper, lower, 5);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractVector64Test(Vector64<byte> upper, Vector64<byte> lower, byte index)
{
  return AdvSimd.ExtractVector64(upper, lower, 5);
}



private static  Vector64<float> Dummy_FloorTest(Vector64<float> value)
{
  return AdvSimd.Floor(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FloorTest(Vector64<float> value)
{
  return AdvSimd.Floor(value);
}



private static  Vector64<double> Dummy_FloorScalarTest(Vector64<double> value)
{
  return AdvSimd.FloorScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FloorScalarTest(Vector64<double> value)
{
  return AdvSimd.FloorScalar(value);
}



private static  Vector64<byte> Dummy_FusedAddHalvingTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.FusedAddHalving(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> FusedAddHalvingTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.FusedAddHalving(left, right);
}



private static  Vector64<byte> Dummy_FusedAddRoundedHalvingTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.FusedAddRoundedHalving(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> FusedAddRoundedHalvingTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.FusedAddRoundedHalving(left, right);
}



private static  Vector64<float> Dummy_FusedMultiplyAddTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.FusedMultiplyAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplyAddTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.FusedMultiplyAdd(addend, left, right);
}



private static  Vector64<float> Dummy_FusedMultiplyAddByScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.FusedMultiplyAddByScalar(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplyAddByScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.FusedMultiplyAddByScalar(addend, left, right);
}



private static  Vector64<float> Dummy_FusedMultiplyAddBySelectedScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(addend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplyAddBySelectedScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(addend, left, right, 0);
}



private static  Vector64<double> Dummy_FusedMultiplyAddNegatedScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplyAddNegatedScalar(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplyAddNegatedScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplyAddNegatedScalar(addend, left, right);
}



private static  Vector64<double> Dummy_FusedMultiplyAddScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplyAddScalar(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplyAddScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplyAddScalar(addend, left, right);
}



private static  Vector64<double> Dummy_FusedMultiplyAddScalarBySelectedScalarTest(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddScalarBySelectedScalar(addend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplyAddScalarBySelectedScalarTest(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddScalarBySelectedScalar(addend, left, right, 0);
}



private static  Vector64<float> Dummy_FusedMultiplySubtractTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.FusedMultiplySubtract(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplySubtractTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.FusedMultiplySubtract(minuend, left, right);
}



private static  Vector64<float> Dummy_FusedMultiplySubtractByScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.FusedMultiplySubtractByScalar(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplySubtractByScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.FusedMultiplySubtractByScalar(minuend, left, right);
}



private static  Vector64<float> Dummy_FusedMultiplySubtractBySelectedScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractBySelectedScalar(minuend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplySubtractBySelectedScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractBySelectedScalar(minuend, left, right, 0);
}



private static  Vector64<double> Dummy_FusedMultiplySubtractNegatedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplySubtractNegatedScalar(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplySubtractNegatedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplySubtractNegatedScalar(minuend, left, right);
}



private static  Vector64<double> Dummy_FusedMultiplySubtractScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplySubtractScalar(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplySubtractScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.FusedMultiplySubtractScalar(minuend, left, right);
}



private static  Vector64<double> Dummy_FusedMultiplySubtractScalarBySelectedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractScalarBySelectedScalar(minuend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplySubtractScalarBySelectedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractScalarBySelectedScalar(minuend, left, right, 0);
}



private static  Vector64<byte> Dummy_FusedSubtractHalvingTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.FusedSubtractHalving(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> FusedSubtractHalvingTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.FusedSubtractHalving(left, right);
}



private static  Vector64<byte> Dummy_InsertTest(Vector64<byte> vector, byte index, byte data)
{
  return AdvSimd.Insert(vector, 4, 200);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> InsertTest(Vector64<byte> vector, byte index, byte data)
{
  return AdvSimd.Insert(vector, 4, 200);
}



private static  Vector128<double> Dummy_InsertScalarTest(Vector128<double> result, byte resultIndex, Vector64<double> value)
{
  return AdvSimd.InsertScalar(result, 1, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<double> InsertScalarTest(Vector128<double> result, byte resultIndex, Vector64<double> value)
{
  return AdvSimd.InsertScalar(result, 1, value);
}



private static  Vector64<byte> Dummy_InsertSelectedScalarTest(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
{
  return AdvSimd.Arm64.InsertSelectedScalar(result, 0, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> InsertSelectedScalarTest(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
{
  return AdvSimd.Arm64.InsertSelectedScalar(result, 0, value, 1);
}



private static  Vector64<short> Dummy_LeadingSignCountTest(Vector64<short> value)
{
  return AdvSimd.LeadingSignCount(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> LeadingSignCountTest(Vector64<short> value)
{
  return AdvSimd.LeadingSignCount(value);
}



private static  Vector64<byte> Dummy_LeadingZeroCountTest(Vector64<byte> value)
{
  return AdvSimd.LeadingZeroCount(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> LeadingZeroCountTest(Vector64<byte> value)
{
  return AdvSimd.LeadingZeroCount(value);
}



private static unsafe Vector64<byte> Dummy_LoadAndInsertScalarTest(Vector64<byte> value, byte index, byte* address)
{
  return AdvSimd.LoadAndInsertScalar(value, 2, address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector64<byte> LoadAndInsertScalarTest(Vector64<byte> value, byte index, byte* address)
{
  return AdvSimd.LoadAndInsertScalar(value, 2, address);
}



private static unsafe Vector128<byte> Dummy_LoadAndReplicateToVector128Test(byte* address)
{
  return AdvSimd.LoadAndReplicateToVector128(address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector128<byte> LoadAndReplicateToVector128Test(byte* address)
{
  return AdvSimd.LoadAndReplicateToVector128(address);
}



private static unsafe Vector64<byte> Dummy_LoadAndReplicateToVector64Test(byte* address)
{
  return AdvSimd.LoadAndReplicateToVector64(address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector64<byte> LoadAndReplicateToVector64Test(byte* address)
{
  return AdvSimd.LoadAndReplicateToVector64(address);
}



private static unsafe Vector128<byte> Dummy_LoadVector128Test(byte* address)
{
  return AdvSimd.LoadVector128(address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector128<byte> LoadVector128Test(byte* address)
{
  return AdvSimd.LoadVector128(address);
}



private static unsafe Vector64<byte> Dummy_LoadVector64Test(byte* address)
{
  return AdvSimd.LoadVector64(address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector64<byte> LoadVector64Test(byte* address)
{
  return AdvSimd.LoadVector64(address);
}



private static  Vector64<byte> Dummy_MaxTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Max(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MaxTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Max(left, right);
}



private static  Vector64<byte> Dummy_MaxAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.MaxAcross(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MaxAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.MaxAcross(value);
}



private static  Vector64<float> Dummy_MaxNumberTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.MaxNumber(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MaxNumberTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.MaxNumber(left, right);
}



private static  Vector64<float> Dummy_MaxNumberAcrossTest(Vector128<float> value)
{
  return AdvSimd.Arm64.MaxNumberAcross(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MaxNumberAcrossTest(Vector128<float> value)
{
  return AdvSimd.Arm64.MaxNumberAcross(value);
}



private static  Vector64<float> Dummy_MaxNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.MaxNumberPairwise(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MaxNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.MaxNumberPairwise(left, right);
}



private static  Vector64<float> Dummy_MaxNumberPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MaxNumberPairwiseScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MaxNumberPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MaxNumberPairwiseScalar(value);
}



private static  Vector64<double> Dummy_MaxNumberScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.MaxNumberScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MaxNumberScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.MaxNumberScalar(left, right);
}



private static  Vector64<byte> Dummy_MaxPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MaxPairwise(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MaxPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MaxPairwise(left, right);
}



private static  Vector64<float> Dummy_MaxPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MaxPairwiseScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MaxPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MaxPairwiseScalar(value);
}



private static  Vector64<double> Dummy_MaxScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MaxScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MaxScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MaxScalar(left, right);
}



private static  Vector64<byte> Dummy_MinTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Min(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MinTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Min(left, right);
}



private static  Vector64<byte> Dummy_MinAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.MinAcross(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MinAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.MinAcross(value);
}



private static  Vector64<float> Dummy_MinNumberTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.MinNumber(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MinNumberTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.MinNumber(left, right);
}



private static  Vector64<float> Dummy_MinNumberAcrossTest(Vector128<float> value)
{
  return AdvSimd.Arm64.MinNumberAcross(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MinNumberAcrossTest(Vector128<float> value)
{
  return AdvSimd.Arm64.MinNumberAcross(value);
}



private static  Vector64<float> Dummy_MinNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.MinNumberPairwise(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MinNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.MinNumberPairwise(left, right);
}



private static  Vector64<float> Dummy_MinNumberPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MinNumberPairwiseScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MinNumberPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MinNumberPairwiseScalar(value);
}



private static  Vector64<double> Dummy_MinNumberScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.MinNumberScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MinNumberScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.MinNumberScalar(left, right);
}



private static  Vector64<byte> Dummy_MinPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MinPairwise(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MinPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MinPairwise(left, right);
}



private static  Vector64<float> Dummy_MinPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MinPairwiseScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MinPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.MinPairwiseScalar(value);
}



private static  Vector64<double> Dummy_MinScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MinScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MinScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MinScalar(left, right);
}



private static  Vector64<byte> Dummy_MultiplyTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Multiply(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MultiplyTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Multiply(left, right);
}



private static  Vector64<byte> Dummy_MultiplyAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MultiplyAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyAdd(addend, left, right);
}



private static  Vector64<short> Dummy_MultiplyAddByScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyAddByScalar(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyAddByScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyAddByScalar(addend, left, right);
}



private static  Vector64<short> Dummy_MultiplyAddBySelectedScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyAddBySelectedScalar(addend, left, right, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyAddBySelectedScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyAddBySelectedScalar(addend, left, right, 3);
}



private static  Vector64<short> Dummy_MultiplyByScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyByScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyByScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyByScalar(left, right);
}



private static  Vector64<short> Dummy_MultiplyBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalar(left, right, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalar(left, right, 3);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningLowerTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLower(left, right, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningLowerTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLower(left, right, 3);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndAdd(addend, left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndAdd(addend, left, right, 2);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndSubtract(minuend, left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndSubtract(minuend, left, right, 2);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningUpperTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpper(left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningUpperTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpper(left, right, 2);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndAdd(addend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndAdd(addend, left, right, 0);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndSubtract(minuend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndSubtract(minuend, left, right, 0);
}



private static  Vector64<short> Dummy_MultiplyDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingByScalarSaturateHigh(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingByScalarSaturateHigh(left, right);
}



private static  Vector64<short> Dummy_MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingBySelectedScalarSaturateHigh(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingBySelectedScalarSaturateHigh(left, right, 0);
}



private static  Vector64<short> Dummy_MultiplyDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingSaturateHigh(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingSaturateHigh(left, right);
}



private static  Vector64<short> Dummy_MultiplyDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingSaturateHighScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingSaturateHighScalar(left, right);
}



private static  Vector64<short> Dummy_MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingScalarBySelectedScalarSaturateHigh(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingScalarBySelectedScalarSaturateHigh(left, right, 0);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndAddSaturateScalar(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndAddSaturateScalar(addend, left, right);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndSubtractSaturateScalar(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndSubtractSaturateScalar(minuend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerAndAddSaturate(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerAndAddSaturate(addend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerAndSubtractSaturate(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerAndSubtractSaturate(minuend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndAddSaturate(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndAddSaturate(addend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(minuend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(addend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(addend, left, right, 0);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(minuend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(minuend, left, right, 0);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningSaturateLowerTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateLowerTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLower(left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerByScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerByScalar(left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerBySelectedScalar(left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerBySelectedScalar(left, right, 2);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningSaturateScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningSaturateScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalar(left, right);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalarBySelectedScalar(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalarBySelectedScalar(left, right, 0);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningSaturateUpperTest(Vector128<short> left, Vector128<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpper(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateUpperTest(Vector128<short> left, Vector128<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpper(left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperByScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperByScalar(left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperBySelectedScalar(left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperBySelectedScalar(left, right, 2);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(addend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(addend, left, right, 0);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(minuend, left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(minuend, left, right, 0);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperAndAddSaturate(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperAndAddSaturate(addend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperAndSubtractSaturate(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperAndSubtractSaturate(minuend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndAddSaturate(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndAddSaturate(addend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(minuend, left, right);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(addend, left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(addend, left, right, 2);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(minuend, left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(minuend, left, right, 2);
}



private static  Vector64<float> Dummy_MultiplyExtendedTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.MultiplyExtended(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MultiplyExtendedTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.Arm64.MultiplyExtended(left, right);
}



private static  Vector128<double> Dummy_MultiplyExtendedByScalarTest(Vector128<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MultiplyExtendedByScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<double> MultiplyExtendedByScalarTest(Vector128<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MultiplyExtendedByScalar(left, right);
}



private static  Vector64<float> Dummy_MultiplyExtendedBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyExtendedBySelectedScalar(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MultiplyExtendedBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyExtendedBySelectedScalar(left, right, 0);
}



private static  Vector64<double> Dummy_MultiplyExtendedScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MultiplyExtendedScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MultiplyExtendedScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.MultiplyExtendedScalar(left, right);
}



private static  Vector64<double> Dummy_MultiplyExtendedScalarBySelectedScalarTest(Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyExtendedScalarBySelectedScalar(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MultiplyExtendedScalarBySelectedScalarTest(Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyExtendedScalarBySelectedScalar(left, right, 0);
}



private static  Vector64<short> Dummy_MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyRoundedDoublingByScalarSaturateHigh(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyRoundedDoublingByScalarSaturateHigh(left, right);
}



private static  Vector64<short> Dummy_MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyRoundedDoublingBySelectedScalarSaturateHigh(left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyRoundedDoublingBySelectedScalarSaturateHigh(left, right, 2);
}



private static  Vector64<short> Dummy_MultiplyRoundedDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyRoundedDoublingSaturateHigh(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplyRoundedDoublingSaturateHigh(left, right);
}



private static  Vector64<short> Dummy_MultiplyRoundedDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyRoundedDoublingSaturateHighScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.Arm64.MultiplyRoundedDoublingSaturateHighScalar(left, right);
}



private static  Vector64<short> Dummy_MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(left, right, 0);
}



private static  Vector64<double> Dummy_MultiplyScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.MultiplyScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MultiplyScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.MultiplyScalar(left, right);
}



private static  Vector64<float> Dummy_MultiplyScalarBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.MultiplyScalarBySelectedScalar(left, right, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MultiplyScalarBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.MultiplyScalarBySelectedScalar(left, right, 0);
}



private static  Vector64<byte> Dummy_MultiplySubtractTest(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplySubtract(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MultiplySubtractTest(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplySubtract(minuend, left, right);
}



private static  Vector64<short> Dummy_MultiplySubtractByScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplySubtractByScalar(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplySubtractByScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
{
  return AdvSimd.MultiplySubtractByScalar(minuend, left, right);
}



private static  Vector64<short> Dummy_MultiplySubtractBySelectedScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplySubtractBySelectedScalar(minuend, left, right, 2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplySubtractBySelectedScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplySubtractBySelectedScalar(minuend, left, right, 2);
}



private static  Vector128<ushort> Dummy_MultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyWideningLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> MultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyWideningLower(left, right);
}



private static  Vector128<ushort> Dummy_MultiplyWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyWideningLowerAndAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> MultiplyWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyWideningLowerAndAdd(addend, left, right);
}



private static  Vector128<ushort> Dummy_MultiplyWideningLowerAndSubtractTest(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyWideningLowerAndSubtract(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> MultiplyWideningLowerAndSubtractTest(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.MultiplyWideningLowerAndSubtract(minuend, left, right);
}



private static  Vector128<ushort> Dummy_MultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.MultiplyWideningUpper(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> MultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.MultiplyWideningUpper(left, right);
}



private static  Vector128<ushort> Dummy_MultiplyWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.MultiplyWideningUpperAndAdd(addend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> MultiplyWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.MultiplyWideningUpperAndAdd(addend, left, right);
}



private static  Vector128<ushort> Dummy_MultiplyWideningUpperAndSubtractTest(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.MultiplyWideningUpperAndSubtract(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> MultiplyWideningUpperAndSubtractTest(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.MultiplyWideningUpperAndSubtract(minuend, left, right);
}



private static  Vector64<short> Dummy_NegateTest(Vector64<short> value)
{
  return AdvSimd.Negate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> NegateTest(Vector64<short> value)
{
  return AdvSimd.Negate(value);
}



private static  Vector64<short> Dummy_NegateSaturateTest(Vector64<short> value)
{
  return AdvSimd.NegateSaturate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> NegateSaturateTest(Vector64<short> value)
{
  return AdvSimd.NegateSaturate(value);
}



private static  Vector64<short> Dummy_NegateSaturateScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.NegateSaturateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> NegateSaturateScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.NegateSaturateScalar(value);
}



private static  Vector64<double> Dummy_NegateScalarTest(Vector64<double> value)
{
  return AdvSimd.NegateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> NegateScalarTest(Vector64<double> value)
{
  return AdvSimd.NegateScalar(value);
}



private static  Vector64<byte> Dummy_NotTest(Vector64<byte> value)
{
  return AdvSimd.Not(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> NotTest(Vector64<byte> value)
{
  return AdvSimd.Not(value);
}



private static  Vector64<byte> Dummy_OrTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Or(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> OrTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Or(left, right);
}



private static  Vector64<byte> Dummy_OrNotTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.OrNot(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> OrNotTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.OrNot(left, right);
}



private static  Vector64<byte> Dummy_PolynomialMultiplyTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.PolynomialMultiply(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> PolynomialMultiplyTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.PolynomialMultiply(left, right);
}



private static  Vector128<ushort> Dummy_PolynomialMultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.PolynomialMultiplyWideningLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> PolynomialMultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.PolynomialMultiplyWideningLower(left, right);
}



private static  Vector128<ushort> Dummy_PolynomialMultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.PolynomialMultiplyWideningUpper(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> PolynomialMultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.PolynomialMultiplyWideningUpper(left, right);
}



private static  Vector64<byte> Dummy_PopCountTest(Vector64<byte> value)
{
  return AdvSimd.PopCount(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> PopCountTest(Vector64<byte> value)
{
  return AdvSimd.PopCount(value);
}



private static  Vector64<float> Dummy_ReciprocalEstimateTest(Vector64<float> value)
{
  return AdvSimd.ReciprocalEstimate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ReciprocalEstimateTest(Vector64<float> value)
{
  return AdvSimd.ReciprocalEstimate(value);
}



private static  Vector64<double> Dummy_ReciprocalEstimateScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalEstimateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalEstimateScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalEstimateScalar(value);
}



private static  Vector64<double> Dummy_ReciprocalExponentScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalExponentScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalExponentScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalExponentScalar(value);
}



private static  Vector64<float> Dummy_ReciprocalSquareRootEstimateTest(Vector64<float> value)
{
  return AdvSimd.ReciprocalSquareRootEstimate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ReciprocalSquareRootEstimateTest(Vector64<float> value)
{
  return AdvSimd.ReciprocalSquareRootEstimate(value);
}



private static  Vector64<double> Dummy_ReciprocalSquareRootEstimateScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalSquareRootEstimateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalSquareRootEstimateScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalSquareRootEstimateScalar(value);
}



private static  Vector64<float> Dummy_ReciprocalSquareRootStepTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.ReciprocalSquareRootStep(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ReciprocalSquareRootStepTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.ReciprocalSquareRootStep(left, right);
}



private static  Vector64<double> Dummy_ReciprocalSquareRootStepScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.ReciprocalSquareRootStepScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalSquareRootStepScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.ReciprocalSquareRootStepScalar(left, right);
}



private static  Vector64<float> Dummy_ReciprocalStepTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.ReciprocalStep(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ReciprocalStepTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.ReciprocalStep(left, right);
}



private static  Vector64<double> Dummy_ReciprocalStepScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.ReciprocalStepScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalStepScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.ReciprocalStepScalar(left, right);
}



private static  Vector64<int> Dummy_ReverseElement16Test(Vector64<int> value)
{
  return AdvSimd.ReverseElement16(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> ReverseElement16Test(Vector64<int> value)
{
  return AdvSimd.ReverseElement16(value);
}



private static  Vector64<long> Dummy_ReverseElement32Test(Vector64<long> value)
{
  return AdvSimd.ReverseElement32(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ReverseElement32Test(Vector64<long> value)
{
  return AdvSimd.ReverseElement32(value);
}



private static  Vector64<short> Dummy_ReverseElement8Test(Vector64<short> value)
{
  return AdvSimd.ReverseElement8(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ReverseElement8Test(Vector64<short> value)
{
  return AdvSimd.ReverseElement8(value);
}



private static  Vector64<byte> Dummy_ReverseElementBitsTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.ReverseElementBits(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ReverseElementBitsTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.ReverseElementBits(value);
}



private static  Vector64<float> Dummy_RoundAwayFromZeroTest(Vector64<float> value)
{
  return AdvSimd.RoundAwayFromZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> RoundAwayFromZeroTest(Vector64<float> value)
{
  return AdvSimd.RoundAwayFromZero(value);
}



private static  Vector64<double> Dummy_RoundAwayFromZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundAwayFromZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> RoundAwayFromZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundAwayFromZeroScalar(value);
}



private static  Vector64<float> Dummy_RoundToNearestTest(Vector64<float> value)
{
  return AdvSimd.RoundToNearest(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> RoundToNearestTest(Vector64<float> value)
{
  return AdvSimd.RoundToNearest(value);
}



private static  Vector64<double> Dummy_RoundToNearestScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToNearestScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> RoundToNearestScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToNearestScalar(value);
}



private static  Vector64<float> Dummy_RoundToNegativeInfinityTest(Vector64<float> value)
{
  return AdvSimd.RoundToNegativeInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> RoundToNegativeInfinityTest(Vector64<float> value)
{
  return AdvSimd.RoundToNegativeInfinity(value);
}



private static  Vector64<double> Dummy_RoundToNegativeInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToNegativeInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> RoundToNegativeInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToNegativeInfinityScalar(value);
}



private static  Vector64<float> Dummy_RoundToPositiveInfinityTest(Vector64<float> value)
{
  return AdvSimd.RoundToPositiveInfinity(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> RoundToPositiveInfinityTest(Vector64<float> value)
{
  return AdvSimd.RoundToPositiveInfinity(value);
}



private static  Vector64<double> Dummy_RoundToPositiveInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToPositiveInfinityScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> RoundToPositiveInfinityScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToPositiveInfinityScalar(value);
}



private static  Vector64<float> Dummy_RoundToZeroTest(Vector64<float> value)
{
  return AdvSimd.RoundToZero(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> RoundToZeroTest(Vector64<float> value)
{
  return AdvSimd.RoundToZero(value);
}



private static  Vector64<double> Dummy_RoundToZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToZeroScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> RoundToZeroScalarTest(Vector64<double> value)
{
  return AdvSimd.RoundToZeroScalar(value);
}



private static  Vector64<short> Dummy_ShiftArithmeticTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmetic(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftArithmeticTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmetic(value, count);
}



private static  Vector64<short> Dummy_ShiftArithmeticRoundedTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmeticRounded(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftArithmeticRoundedTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmeticRounded(value, count);
}



private static  Vector64<short> Dummy_ShiftArithmeticRoundedSaturateTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmeticRoundedSaturate(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftArithmeticRoundedSaturateTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmeticRoundedSaturate(value, count);
}



private static  Vector64<long> Dummy_ShiftArithmeticRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticRoundedSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftArithmeticRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticRoundedSaturateScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftArithmeticRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticRoundedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftArithmeticRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticRoundedScalar(value, count);
}



private static  Vector64<short> Dummy_ShiftArithmeticSaturateTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmeticSaturate(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftArithmeticSaturateTest(Vector64<short> value, Vector64<short> count)
{
  return AdvSimd.ShiftArithmeticSaturate(value, count);
}



private static  Vector64<long> Dummy_ShiftArithmeticSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftArithmeticSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticSaturateScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftArithmeticScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftArithmeticScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftArithmeticScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftLeftAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsert(left, right, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLeftAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsert(left, right, 1);
}



private static  Vector64<long> Dummy_ShiftLeftAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsertScalar(left, right, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLeftAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsertScalar(left, right, 1);
}



private static  Vector64<byte> Dummy_ShiftLeftLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogical(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLeftLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogical(value, 1);
}



private static  Vector64<byte> Dummy_ShiftLeftLogicalSaturateTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturate(value, 6);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLeftLogicalSaturateTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturate(value, 6);
}



private static  Vector64<long> Dummy_ShiftLeftLogicalSaturateScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateScalar(value, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLeftLogicalSaturateScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateScalar(value, 0);
}



private static  Vector64<ushort> Dummy_ShiftLeftLogicalSaturateUnsignedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsigned(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ushort> ShiftLeftLogicalSaturateUnsignedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsigned(value, 1);
}



private static  Vector64<ulong> Dummy_ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsignedScalar(value, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsignedScalar(value, 0);
}



private static  Vector64<long> Dummy_ShiftLeftLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLeftLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalScalar(value, 1);
}



private static  Vector128<ushort> Dummy_ShiftLeftLogicalWideningLowerTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningLower(value, 0);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> ShiftLeftLogicalWideningLowerTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningLower(value, 0);
}



private static  Vector128<ushort> Dummy_ShiftLeftLogicalWideningUpperTest(Vector128<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningUpper(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> ShiftLeftLogicalWideningUpperTest(Vector128<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningUpper(value, 1);
}



private static  Vector64<byte> Dummy_ShiftLogicalTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogical(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLogicalTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogical(value, count);
}



private static  Vector64<byte> Dummy_ShiftLogicalRoundedTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogicalRounded(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLogicalRoundedTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogicalRounded(value, count);
}



private static  Vector64<byte> Dummy_ShiftLogicalRoundedSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogicalRoundedSaturate(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLogicalRoundedSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogicalRoundedSaturate(value, count);
}



private static  Vector64<long> Dummy_ShiftLogicalRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalRoundedSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLogicalRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalRoundedSaturateScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftLogicalRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalRoundedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLogicalRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalRoundedScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftLogicalSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogicalSaturate(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLogicalSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{
  return AdvSimd.ShiftLogicalSaturate(value, count);
}



private static  Vector64<long> Dummy_ShiftLogicalSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLogicalSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalSaturateScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftLogicalScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLogicalScalarTest(Vector64<long> value, Vector64<long> count)
{
  return AdvSimd.ShiftLogicalScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsert(left, right, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsert(left, right, 1);
}



private static  Vector64<long> Dummy_ShiftRightAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsertScalar(left, right, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsertScalar(left, right, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmetic(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmetic(value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAdd(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAdd(addend, value, 1);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAddScalar(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAddScalar(addend, value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateLower(value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateScalar(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedLower(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateUnsignedScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateUnsignedScalar(value, 1);
}



private static  Vector128<byte> Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedUpper(lower, value, 1);
}



private static  Vector128<short> Dummy_ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<short> ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUpper(lower, value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRounded(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRounded(value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAdd(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAdd(addend, value, 1);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAddScalar(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAddScalar(addend, value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateLower(value, 1);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateScalar(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(value, 1);
}



private static  Vector128<byte> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(lower, value, 1);
}



private static  Vector128<short> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUpper(lower, value, 1);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedScalar(value, 1);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticScalar(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogical(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogical(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAdd(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAdd(addend, value, 1);
}



private static  Vector64<long> Dummy_ShiftRightLogicalAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAddScalar(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAddScalar(addend, value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingLower(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateLower(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalNarrowingSaturateScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalNarrowingSaturateScalar(value, 1);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateUpper(lower, value, 1);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingUpper(lower, value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRounded(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRounded(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAdd(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAdd(addend, value, 1);
}



private static  Vector64<long> Dummy_ShiftRightLogicalRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAddScalar(addend, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAddScalar(addend, value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingLower(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateLower(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateLower(value, 1);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalRoundedNarrowingSaturateScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalRoundedNarrowingSaturateScalar(value, 1);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateUpper(lower, value, 1);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalRoundedNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingUpper(lower, value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalRoundedNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingUpper(lower, value, 1);
}



private static  Vector64<long> Dummy_ShiftRightLogicalRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedScalar(value, 1);
}



private static  Vector64<long> Dummy_ShiftRightLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalScalar(value, 1);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalScalar(value, 1);
}



private static  Vector128<int> Dummy_SignExtendWideningLowerTest(Vector64<short> value)
{
  return AdvSimd.SignExtendWideningLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> SignExtendWideningLowerTest(Vector64<short> value)
{
  return AdvSimd.SignExtendWideningLower(value);
}



private static  Vector128<int> Dummy_SignExtendWideningUpperTest(Vector128<short> value)
{
  return AdvSimd.SignExtendWideningUpper(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> SignExtendWideningUpperTest(Vector128<short> value)
{
  return AdvSimd.SignExtendWideningUpper(value);
}



private static  Vector64<float> Dummy_SqrtTest(Vector64<float> value)
{
  return AdvSimd.Arm64.Sqrt(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> SqrtTest(Vector64<float> value)
{
  return AdvSimd.Arm64.Sqrt(value);
}



private static  Vector64<double> Dummy_SqrtScalarTest(Vector64<double> value)
{
  return AdvSimd.SqrtScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> SqrtScalarTest(Vector64<double> value)
{
  return AdvSimd.SqrtScalar(value);
}



private static unsafe void Dummy_StoreTest(byte* address, Vector64<byte> source)
{
  AdvSimd.Store(address, source);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StoreTest(byte* address, Vector64<byte> source)
{
  AdvSimd.Store(address, source);
}



private static unsafe void Dummy_StorePairTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{
  AdvSimd.Arm64.StorePair(address, value1, value2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StorePairTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{
  AdvSimd.Arm64.StorePair(address, value1, value2);
}



private static unsafe void Dummy_StorePairNonTemporalTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{
  AdvSimd.Arm64.StorePairNonTemporal(address, value1, value2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StorePairNonTemporalTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{
  AdvSimd.Arm64.StorePairNonTemporal(address, value1, value2);
}



private static unsafe void Dummy_StorePairScalarTest(int* address, Vector64<int> value1, Vector64<int> value2)
{
  AdvSimd.Arm64.StorePairScalar(address, value1, value2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StorePairScalarTest(int* address, Vector64<int> value1, Vector64<int> value2)
{
  AdvSimd.Arm64.StorePairScalar(address, value1, value2);
}



private static unsafe void Dummy_StorePairScalarNonTemporalTest(int* address, Vector64<int> value1, Vector64<int> value2)
{
  AdvSimd.Arm64.StorePairScalarNonTemporal(address, value1, value2);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StorePairScalarNonTemporalTest(int* address, Vector64<int> value1, Vector64<int> value2)
{
  AdvSimd.Arm64.StorePairScalarNonTemporal(address, value1, value2);
}



private static unsafe void Dummy_StoreSelectedScalarTest(byte* address, Vector64<byte> value, byte index)
{
  AdvSimd.StoreSelectedScalar(address, value, 3);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StoreSelectedScalarTest(byte* address, Vector64<byte> value, byte index)
{
  AdvSimd.StoreSelectedScalar(address, value, 3);
}



private static  Vector64<byte> Dummy_SubtractTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Subtract(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> SubtractTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Subtract(left, right);
}



private static  Vector64<byte> Dummy_SubtractHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractHighNarrowingLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> SubtractHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractHighNarrowingLower(left, right);
}



private static  Vector128<byte> Dummy_SubtractHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractHighNarrowingUpper(lower, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> SubtractHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractHighNarrowingUpper(lower, left, right);
}



private static  Vector64<byte> Dummy_SubtractRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractRoundedHighNarrowingLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> SubtractRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractRoundedHighNarrowingLower(left, right);
}



private static  Vector128<byte> Dummy_SubtractRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractRoundedHighNarrowingUpper(lower, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> SubtractRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{
  return AdvSimd.SubtractRoundedHighNarrowingUpper(lower, left, right);
}



private static  Vector64<byte> Dummy_SubtractSaturateTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.SubtractSaturate(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> SubtractSaturateTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.SubtractSaturate(left, right);
}



private static  Vector64<long> Dummy_SubtractSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{
  return AdvSimd.SubtractSaturateScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> SubtractSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{
  return AdvSimd.SubtractSaturateScalar(left, right);
}



private static  Vector64<double> Dummy_SubtractScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.SubtractScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> SubtractScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.SubtractScalar(left, right);
}



private static  Vector128<ushort> Dummy_SubtractWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.SubtractWideningLower(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> SubtractWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.SubtractWideningLower(left, right);
}



private static  Vector128<ushort> Dummy_SubtractWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.SubtractWideningUpper(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> SubtractWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{
  return AdvSimd.SubtractWideningUpper(left, right);
}



private static  Vector64<byte> Dummy_TransposeEvenTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.TransposeEven(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> TransposeEvenTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.TransposeEven(left, right);
}



private static  Vector64<byte> Dummy_TransposeOddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.TransposeOdd(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> TransposeOddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.TransposeOdd(left, right);
}



private static  Vector64<byte> Dummy_UnzipEvenTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.UnzipEven(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> UnzipEvenTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.UnzipEven(left, right);
}



private static  Vector64<byte> Dummy_UnzipOddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.UnzipOdd(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> UnzipOddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.UnzipOdd(left, right);
}



private static  Vector64<byte> Dummy_VectorTableLookupTest(Vector128<byte> table, Vector64<byte> byteIndexes)
{
  return AdvSimd.VectorTableLookup(table, byteIndexes);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> VectorTableLookupTest(Vector128<byte> table, Vector64<byte> byteIndexes)
{
  return AdvSimd.VectorTableLookup(table, byteIndexes);
}



private static  Vector64<byte> Dummy_VectorTableLookupExtensionTest(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)
{
  return AdvSimd.VectorTableLookupExtension(defaultValues, table, byteIndexes);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> VectorTableLookupExtensionTest(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)
{
  return AdvSimd.VectorTableLookupExtension(defaultValues, table, byteIndexes);
}



private static  Vector64<byte> Dummy_XorTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Xor(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> XorTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Xor(left, right);
}



private static  Vector128<ushort> Dummy_ZeroExtendWideningLowerTest(Vector64<byte> value)
{
  return AdvSimd.ZeroExtendWideningLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> ZeroExtendWideningLowerTest(Vector64<byte> value)
{
  return AdvSimd.ZeroExtendWideningLower(value);
}



private static  Vector128<ushort> Dummy_ZeroExtendWideningUpperTest(Vector128<byte> value)
{
  return AdvSimd.ZeroExtendWideningUpper(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> ZeroExtendWideningUpperTest(Vector128<byte> value)
{
  return AdvSimd.ZeroExtendWideningUpper(value);
}



private static  Vector64<byte> Dummy_ZipHighTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.ZipHigh(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ZipHighTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.ZipHigh(left, right);
}



private static  Vector64<byte> Dummy_ZipLowTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.ZipLow(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ZipLowTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Arm64.ZipLow(left, right);
}




public static unsafe void Run()
{
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 1
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 1 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[Abs](#1-abs), [AbsoluteCompareGreaterThan](#2-absolutecomparegreaterthan), [AbsoluteCompareGreaterThanOrEqual](#3-absolutecomparegreaterthanorequal), [AbsoluteCompareGreaterThanOrEqualScalar](#4-absolutecomparegreaterthanorequalscalar), [AbsoluteCompareGreaterThanScalar](#5-absolutecomparegreaterthanscalar), [AbsoluteCompareLessThan](#6-absolutecomparelessthan), [AbsoluteCompareLessThanOrEqual](#7-absolutecomparelessthanorequal), [AbsoluteCompareLessThanOrEqualScalar](#8-absolutecomparelessthanorequalscalar), [AbsoluteCompareLessThanScalar](#9-absolutecomparelessthanscalar), [AbsoluteDifference](#10-absolutedifference), [AbsoluteDifferenceAdd](#11-absolutedifferenceadd), [AbsoluteDifferenceScalar](#12-absolutedifferencescalar), [AbsoluteDifferenceWideningLower](#13-absolutedifferencewideninglower), [AbsoluteDifferenceWideningLowerAndAdd](#14-absolutedifferencewideninglowerandadd), [AbsoluteDifferenceWideningUpper](#15-absolutedifferencewideningupper), [AbsoluteDifferenceWideningUpperAndAdd](#16-absolutedifferencewideningupperandadd), [AbsSaturate](#17-abssaturate), [AbsSaturateScalar](#18-abssaturatescalar), [AbsScalar](#19-absscalar), [Add](#20-add), [AddAcross](#21-addacross), [AddAcrossWidening](#22-addacrosswidening), [AddHighNarrowingLower](#23-addhighnarrowinglower), [AddHighNarrowingUpper](#24-addhighnarrowingupper), [AddPairwise](#25-addpairwise), [AddPairwiseScalar](#26-addpairwisescalar), [AddPairwiseWidening](#27-addpairwisewidening), [AddPairwiseWideningAndAdd](#28-addpairwisewideningandadd), [AddPairwiseWideningAndAddScalar](#29-addpairwisewideningandaddscalar), [AddPairwiseWideningScalar](#30-addpairwisewideningscalar), [AddRoundedHighNarrowingLower](#31-addroundedhighnarrowinglower), [AddRoundedHighNarrowingUpper](#32-addroundedhighnarrowingupper), [AddSaturate](#33-addsaturate), [AddSaturateScalar](#34-addsaturatescalar), [AddScalar](#35-addscalar), [AddWideningLower](#36-addwideninglower), [AddWideningUpper](#37-addwideningupper), [And](#38-and), [BitwiseClear](#39-bitwiseclear), [BitwiseSelect](#40-bitwiseselect), [Ceiling](#41-ceiling), [CeilingScalar](#42-ceilingscalar), [CompareEqual](#43-compareequal), [CompareEqualScalar](#44-compareequalscalar), [CompareGreaterThan](#45-comparegreaterthan)


");

try {
var AbsResult = Dummy_AbsTest(Vector64short_0);
apiResult = AbsResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. Abs

`Vector64<ushort> Abs(Vector64<short> value)`

{0}

```csharp
private Vector64<ushort> AbsTest(Vector64<short> value)
{{
  return AdvSimd.Abs(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<uint> Abs(Vector64<int> value)
Vector64<byte> Abs(Vector64<sbyte> value)
Vector64<float> Abs(Vector64<float> value)
Vector128<ushort> Abs(Vector128<short> value)
Vector128<uint> Abs(Vector128<int> value)
Vector128<byte> Abs(Vector128<sbyte> value)
Vector128<float> Abs(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Abs(Vector128<double> value)
Vector128<ulong> Abs(Vector128<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.abs?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.abs?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabs_s16).

Assembly generated:

```armasm", GetValue("Abs", "Performs 'Abs' operation.", 0), GetValue("Abs", Vector64short_0.ToString(), 1), GetValue("Abs", apiResult.ToString(), 2));

try {
AbsTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanResult = Dummy_AbsoluteCompareGreaterThanTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareGreaterThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. AbsoluteCompareGreaterThan

`Vector64<float> AbsoluteCompareGreaterThan(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> AbsoluteCompareGreaterThanTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareGreaterThan(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareGreaterThan(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareGreaterThan(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparegreaterthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthan?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcagt_f32).

Assembly generated:

```armasm", GetValue("AbsoluteCompareGreaterThan", "Performs 'AbsoluteCompareGreaterThan' operation.", 0), GetValue("AbsoluteCompareGreaterThan", Vector64float_0.ToString(), 1), GetValue("AbsoluteCompareGreaterThan", Vector64float_1.ToString(), 2), GetValue("AbsoluteCompareGreaterThan", apiResult.ToString(), 3));

try {
AbsoluteCompareGreaterThanTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanOrEqualResult = Dummy_AbsoluteCompareGreaterThanOrEqualTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareGreaterThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. AbsoluteCompareGreaterThanOrEqual

`Vector64<float> AbsoluteCompareGreaterThanOrEqual(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> AbsoluteCompareGreaterThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareGreaterThanOrEqual(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparegreaterthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthanorequal?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcage_f32).

Assembly generated:

```armasm", GetValue("AbsoluteCompareGreaterThanOrEqual", "Performs 'AbsoluteCompareGreaterThanOrEqual' operation.", 0), GetValue("AbsoluteCompareGreaterThanOrEqual", Vector64float_0.ToString(), 1), GetValue("AbsoluteCompareGreaterThanOrEqual", Vector64float_1.ToString(), 2), GetValue("AbsoluteCompareGreaterThanOrEqual", apiResult.ToString(), 3));

try {
AbsoluteCompareGreaterThanOrEqualTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanOrEqualScalarResult = Dummy_AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareGreaterThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. AbsoluteCompareGreaterThanOrEqualScalar

`Vector64<double> AbsoluteCompareGreaterThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanOrEqualScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareGreaterThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthanorequalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcage_f64).

Assembly generated:

```armasm", GetValue("AbsoluteCompareGreaterThanOrEqualScalar", "Performs 'AbsoluteCompareGreaterThanOrEqualScalar' operation.", 0), GetValue("AbsoluteCompareGreaterThanOrEqualScalar", Vector64double_0.ToString(), 1), GetValue("AbsoluteCompareGreaterThanOrEqualScalar", Vector64double_1.ToString(), 2), GetValue("AbsoluteCompareGreaterThanOrEqualScalar", apiResult.ToString(), 3));

try {
AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanScalarResult = Dummy_AbsoluteCompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareGreaterThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. AbsoluteCompareGreaterThanScalar

`Vector64<double> AbsoluteCompareGreaterThanScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> AbsoluteCompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareGreaterThanScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthanscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcagt_f64).

Assembly generated:

```armasm", GetValue("AbsoluteCompareGreaterThanScalar", "Performs 'AbsoluteCompareGreaterThanScalar' operation.", 0), GetValue("AbsoluteCompareGreaterThanScalar", Vector64double_0.ToString(), 1), GetValue("AbsoluteCompareGreaterThanScalar", Vector64double_1.ToString(), 2), GetValue("AbsoluteCompareGreaterThanScalar", apiResult.ToString(), 3));

try {
AbsoluteCompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanResult = Dummy_AbsoluteCompareLessThanTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareLessThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. AbsoluteCompareLessThan

`Vector64<float> AbsoluteCompareLessThan(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> AbsoluteCompareLessThanTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareLessThan(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareLessThan(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareLessThan(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparelessthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthan?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcalt_f32).

Assembly generated:

```armasm", GetValue("AbsoluteCompareLessThan", "Performs 'AbsoluteCompareLessThan' operation.", 0), GetValue("AbsoluteCompareLessThan", Vector64float_0.ToString(), 1), GetValue("AbsoluteCompareLessThan", Vector64float_1.ToString(), 2), GetValue("AbsoluteCompareLessThan", apiResult.ToString(), 3));

try {
AbsoluteCompareLessThanTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanOrEqualResult = Dummy_AbsoluteCompareLessThanOrEqualTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareLessThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. AbsoluteCompareLessThanOrEqual

`Vector64<float> AbsoluteCompareLessThanOrEqual(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> AbsoluteCompareLessThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareLessThanOrEqual(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparelessthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthanorequal?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcale_f32).

Assembly generated:

```armasm", GetValue("AbsoluteCompareLessThanOrEqual", "Performs 'AbsoluteCompareLessThanOrEqual' operation.", 0), GetValue("AbsoluteCompareLessThanOrEqual", Vector64float_0.ToString(), 1), GetValue("AbsoluteCompareLessThanOrEqual", Vector64float_1.ToString(), 2), GetValue("AbsoluteCompareLessThanOrEqual", apiResult.ToString(), 3));

try {
AbsoluteCompareLessThanOrEqualTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanOrEqualScalarResult = Dummy_AbsoluteCompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareLessThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. AbsoluteCompareLessThanOrEqualScalar

`Vector64<double> AbsoluteCompareLessThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> AbsoluteCompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareLessThanOrEqualScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareLessThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthanorequalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcale_f64).

Assembly generated:

```armasm", GetValue("AbsoluteCompareLessThanOrEqualScalar", "Performs 'AbsoluteCompareLessThanOrEqualScalar' operation.", 0), GetValue("AbsoluteCompareLessThanOrEqualScalar", Vector64double_0.ToString(), 1), GetValue("AbsoluteCompareLessThanOrEqualScalar", Vector64double_1.ToString(), 2), GetValue("AbsoluteCompareLessThanOrEqualScalar", apiResult.ToString(), 3));

try {
AbsoluteCompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanScalarResult = Dummy_AbsoluteCompareLessThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareLessThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. AbsoluteCompareLessThanScalar

`Vector64<double> AbsoluteCompareLessThanScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> AbsoluteCompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareLessThanScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareLessThanScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthanscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcalt_f64).

Assembly generated:

```armasm", GetValue("AbsoluteCompareLessThanScalar", "Performs 'AbsoluteCompareLessThanScalar' operation.", 0), GetValue("AbsoluteCompareLessThanScalar", Vector64double_0.ToString(), 1), GetValue("AbsoluteCompareLessThanScalar", Vector64double_1.ToString(), 2), GetValue("AbsoluteCompareLessThanScalar", apiResult.ToString(), 3));

try {
AbsoluteCompareLessThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceResult = Dummy_AbsoluteDifferenceTest(Vector64byte_0, Vector64byte_1);
apiResult = AbsoluteDifferenceResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. AbsoluteDifference

`Vector64<byte> AbsoluteDifference(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> AbsoluteDifferenceTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifference(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> AbsoluteDifference(Vector64<short> left, Vector64<short> right)
Vector64<uint> AbsoluteDifference(Vector64<int> left, Vector64<int> right)
Vector64<byte> AbsoluteDifference(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> AbsoluteDifference(Vector64<float> left, Vector64<float> right)
Vector64<ushort> AbsoluteDifference(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> AbsoluteDifference(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> AbsoluteDifference(Vector128<byte> left, Vector128<byte> right)
Vector128<ushort> AbsoluteDifference(Vector128<short> left, Vector128<short> right)
Vector128<uint> AbsoluteDifference(Vector128<int> left, Vector128<int> right)
Vector128<byte> AbsoluteDifference(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> AbsoluteDifference(Vector128<float> left, Vector128<float> right)
Vector128<ushort> AbsoluteDifference(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> AbsoluteDifference(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteDifference(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifference?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutedifference?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabd_u8).

Assembly generated:

```armasm", GetValue("AbsoluteDifference", "Performs 'AbsoluteDifference' operation.", 0), GetValue("AbsoluteDifference", Vector64byte_0.ToString(), 1), GetValue("AbsoluteDifference", Vector64byte_1.ToString(), 2), GetValue("AbsoluteDifference", apiResult.ToString(), 3));

try {
AbsoluteDifferenceTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceAddResult = Dummy_AbsoluteDifferenceAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = AbsoluteDifferenceAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. AbsoluteDifferenceAdd

`Vector64<byte> AbsoluteDifferenceAdd(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> AbsoluteDifferenceAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> AbsoluteDifferenceAdd(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
Vector64<int> AbsoluteDifferenceAdd(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
Vector64<sbyte> AbsoluteDifferenceAdd(Vector64<sbyte> addend, Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> AbsoluteDifferenceAdd(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> AbsoluteDifferenceAdd(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right)
Vector128<byte> AbsoluteDifferenceAdd(Vector128<byte> addend, Vector128<byte> left, Vector128<byte> right)
Vector128<short> AbsoluteDifferenceAdd(Vector128<short> addend, Vector128<short> left, Vector128<short> right)
Vector128<int> AbsoluteDifferenceAdd(Vector128<int> addend, Vector128<int> left, Vector128<int> right)
Vector128<sbyte> AbsoluteDifferenceAdd(Vector128<sbyte> addend, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> AbsoluteDifferenceAdd(Vector128<ushort> addend, Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> AbsoluteDifferenceAdd(Vector128<uint> addend, Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferenceadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaba_u8).

Assembly generated:

```armasm", GetValue("AbsoluteDifferenceAdd", "Performs 'AbsoluteDifferenceAdd' operation.", 0), GetValue("AbsoluteDifferenceAdd", Vector64byte_0.ToString(), 1), GetValue("AbsoluteDifferenceAdd", Vector64byte_1.ToString(), 2), GetValue("AbsoluteDifferenceAdd", Vector64byte_2.ToString(), 3), GetValue("AbsoluteDifferenceAdd", apiResult.ToString(), 4));

try {
AbsoluteDifferenceAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceScalarResult = Dummy_AbsoluteDifferenceScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteDifferenceScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. AbsoluteDifferenceScalar

`Vector64<double> AbsoluteDifferenceScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> AbsoluteDifferenceScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteDifferenceScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteDifferenceScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutedifferencescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabd_f64).

Assembly generated:

```armasm", GetValue("AbsoluteDifferenceScalar", "Performs 'AbsoluteDifferenceScalar' operation.", 0), GetValue("AbsoluteDifferenceScalar", Vector64double_0.ToString(), 1), GetValue("AbsoluteDifferenceScalar", Vector64double_1.ToString(), 2), GetValue("AbsoluteDifferenceScalar", apiResult.ToString(), 3));

try {
AbsoluteDifferenceScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningLowerResult = Dummy_AbsoluteDifferenceWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = AbsoluteDifferenceWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. AbsoluteDifferenceWideningLower

`Vector128<ushort> AbsoluteDifferenceWideningLower(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> AbsoluteDifferenceWideningLower(Vector64<short> left, Vector64<short> right)
Vector128<ulong> AbsoluteDifferenceWideningLower(Vector64<int> left, Vector64<int> right)
Vector128<ushort> AbsoluteDifferenceWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> AbsoluteDifferenceWideningLower(Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> AbsoluteDifferenceWideningLower(Vector64<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabdl_u8).

Assembly generated:

```armasm", GetValue("AbsoluteDifferenceWideningLower", "Performs 'AbsoluteDifferenceWideningLower' operation.", 0), GetValue("AbsoluteDifferenceWideningLower", Vector64byte_0.ToString(), 1), GetValue("AbsoluteDifferenceWideningLower", Vector64byte_1.ToString(), 2), GetValue("AbsoluteDifferenceWideningLower", apiResult.ToString(), 3));

try {
AbsoluteDifferenceWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningLowerAndAddResult = Dummy_AbsoluteDifferenceWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);
apiResult = AbsoluteDifferenceWideningLowerAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. AbsoluteDifferenceWideningLowerAndAdd

`Vector128<ushort> AbsoluteDifferenceWideningLowerAndAdd(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningLowerAndAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> AbsoluteDifferenceWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
Vector128<long> AbsoluteDifferenceWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
Vector128<short> AbsoluteDifferenceWideningLowerAndAdd(Vector128<short> addend, Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> AbsoluteDifferenceWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> AbsoluteDifferenceWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideninglowerandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabal_u8).

Assembly generated:

```armasm", GetValue("AbsoluteDifferenceWideningLowerAndAdd", "Performs 'AbsoluteDifferenceWideningLowerAndAdd' operation.", 0), GetValue("AbsoluteDifferenceWideningLowerAndAdd", Vector128ushort_0.ToString(), 1), GetValue("AbsoluteDifferenceWideningLowerAndAdd", Vector64byte_0.ToString(), 2), GetValue("AbsoluteDifferenceWideningLowerAndAdd", Vector64byte_1.ToString(), 3), GetValue("AbsoluteDifferenceWideningLowerAndAdd", apiResult.ToString(), 4));

try {
AbsoluteDifferenceWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningUpperResult = Dummy_AbsoluteDifferenceWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = AbsoluteDifferenceWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. AbsoluteDifferenceWideningUpper

`Vector128<ushort> AbsoluteDifferenceWideningUpper(Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningUpper(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> AbsoluteDifferenceWideningUpper(Vector128<short> left, Vector128<short> right)
Vector128<ulong> AbsoluteDifferenceWideningUpper(Vector128<int> left, Vector128<int> right)
Vector128<ushort> AbsoluteDifferenceWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<uint> AbsoluteDifferenceWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
Vector128<ulong> AbsoluteDifferenceWideningUpper(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabdl_high_u8).

Assembly generated:

```armasm", GetValue("AbsoluteDifferenceWideningUpper", "Performs 'AbsoluteDifferenceWideningUpper' operation.", 0), GetValue("AbsoluteDifferenceWideningUpper", Vector128byte_0.ToString(), 1), GetValue("AbsoluteDifferenceWideningUpper", Vector128byte_1.ToString(), 2), GetValue("AbsoluteDifferenceWideningUpper", apiResult.ToString(), 3));

try {
AbsoluteDifferenceWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningUpperAndAddResult = Dummy_AbsoluteDifferenceWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);
apiResult = AbsoluteDifferenceWideningUpperAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. AbsoluteDifferenceWideningUpperAndAdd

`Vector128<ushort> AbsoluteDifferenceWideningUpperAndAdd(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningUpperAndAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> AbsoluteDifferenceWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
Vector128<long> AbsoluteDifferenceWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
Vector128<short> AbsoluteDifferenceWideningUpperAndAdd(Vector128<short> addend, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<uint> AbsoluteDifferenceWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector128<ushort> right)
Vector128<ulong> AbsoluteDifferenceWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideningupperandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabal_high_u8).

Assembly generated:

```armasm", GetValue("AbsoluteDifferenceWideningUpperAndAdd", "Performs 'AbsoluteDifferenceWideningUpperAndAdd' operation.", 0), GetValue("AbsoluteDifferenceWideningUpperAndAdd", Vector128ushort_0.ToString(), 1), GetValue("AbsoluteDifferenceWideningUpperAndAdd", Vector128byte_0.ToString(), 2), GetValue("AbsoluteDifferenceWideningUpperAndAdd", Vector128byte_1.ToString(), 3), GetValue("AbsoluteDifferenceWideningUpperAndAdd", apiResult.ToString(), 4));

try {
AbsoluteDifferenceWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsSaturateResult = Dummy_AbsSaturateTest(Vector64short_0);
apiResult = AbsSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. AbsSaturate

`Vector64<short> AbsSaturate(Vector64<short> value)`

{0}

```csharp
private Vector64<short> AbsSaturateTest(Vector64<short> value)
{{
  return AdvSimd.AbsSaturate(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> AbsSaturate(Vector64<int> value)
Vector64<sbyte> AbsSaturate(Vector64<sbyte> value)
Vector128<short> AbsSaturate(Vector128<short> value)
Vector128<int> AbsSaturate(Vector128<int> value)
Vector128<sbyte> AbsSaturate(Vector128<sbyte> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<long> AbsSaturate(Vector128<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.abssaturate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.abssaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqabs_s16).

Assembly generated:

```armasm", GetValue("AbsSaturate", "Performs 'AbsSaturate' operation.", 0), GetValue("AbsSaturate", Vector64short_0.ToString(), 1), GetValue("AbsSaturate", apiResult.ToString(), 2));

try {
AbsSaturateTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsSaturateScalarResult = Dummy_AbsSaturateScalarTest(Vector64short_0);
apiResult = AbsSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. AbsSaturateScalar

`Vector64<short> AbsSaturateScalar(Vector64<short> value)`

{0}

```csharp
private Vector64<short> AbsSaturateScalarTest(Vector64<short> value)
{{
  return AdvSimd.Arm64.AbsSaturateScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> AbsSaturateScalar(Vector64<int> value)
Vector64<long> AbsSaturateScalar(Vector64<long> value)
Vector64<sbyte> AbsSaturateScalar(Vector64<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.abssaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqabsh_s16).

Assembly generated:

```armasm", GetValue("AbsSaturateScalar", "Performs 'AbsSaturateScalar' operation.", 0), GetValue("AbsSaturateScalar", Vector64short_0.ToString(), 1), GetValue("AbsSaturateScalar", apiResult.ToString(), 2));

try {
AbsSaturateScalarTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AbsScalarResult = Dummy_AbsScalarTest(Vector64double_0);
apiResult = AbsScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. AbsScalar

`Vector64<double> AbsScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> AbsScalarTest(Vector64<double> value)
{{
  return AdvSimd.AbsScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> AbsScalar(Vector64<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ulong> AbsScalar(Vector64<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vabs_f64).

Assembly generated:

```armasm", GetValue("AbsScalar", "Performs 'AbsScalar' operation.", 0), GetValue("AbsScalar", Vector64double_0.ToString(), 1), GetValue("AbsScalar", apiResult.ToString(), 2));

try {
AbsScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddResult = Dummy_AddTest(Vector64byte_0, Vector64byte_1);
apiResult = AddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. Add

`Vector64<byte> Add(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> AddTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Add(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> Add(Vector64<short> left, Vector64<short> right)
Vector64<int> Add(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> Add(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Add(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Add(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Add(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right)
Vector128<short> Add(Vector128<short> left, Vector128<short> right)
Vector128<int> Add(Vector128<int> left, Vector128<int> right)
Vector128<long> Add(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Add(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Add(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.add?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.add?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vadd_u8).

Assembly generated:

```armasm", GetValue("Add", "Performs 'Add' operation.", 0), GetValue("Add", Vector64byte_0.ToString(), 1), GetValue("Add", Vector64byte_1.ToString(), 2), GetValue("Add", apiResult.ToString(), 3));

try {
AddTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddAcrossResult = Dummy_AddAcrossTest(Vector64byte_0);
apiResult = AddAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. AddAcross

`Vector64<byte> AddAcross(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> AddAcrossTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.AddAcross(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> AddAcross(Vector64<short> value)
Vector64<sbyte> AddAcross(Vector64<sbyte> value)
Vector64<ushort> AddAcross(Vector64<ushort> value)
Vector64<byte> AddAcross(Vector128<byte> value)
Vector64<short> AddAcross(Vector128<short> value)
Vector64<int> AddAcross(Vector128<int> value)
Vector64<sbyte> AddAcross(Vector128<sbyte> value)
Vector64<ushort> AddAcross(Vector128<ushort> value)
Vector64<uint> AddAcross(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addacross?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaddv_u8).

Assembly generated:

```armasm", GetValue("AddAcross", "Performs 'AddAcross' operation.", 0), GetValue("AddAcross", Vector64byte_0.ToString(), 1), GetValue("AddAcross", apiResult.ToString(), 2));

try {
AddAcrossTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddAcrossWideningResult = Dummy_AddAcrossWideningTest(Vector64byte_0);
apiResult = AddAcrossWideningResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. AddAcrossWidening

`Vector64<ushort> AddAcrossWidening(Vector64<byte> value)`

{0}

```csharp
private Vector64<ushort> AddAcrossWideningTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.AddAcrossWidening(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> AddAcrossWidening(Vector64<short> value)
Vector64<short> AddAcrossWidening(Vector64<sbyte> value)
Vector64<uint> AddAcrossWidening(Vector64<ushort> value)
Vector64<ushort> AddAcrossWidening(Vector128<byte> value)
Vector64<int> AddAcrossWidening(Vector128<short> value)
Vector64<long> AddAcrossWidening(Vector128<int> value)
Vector64<short> AddAcrossWidening(Vector128<sbyte> value)
Vector64<uint> AddAcrossWidening(Vector128<ushort> value)
Vector64<ulong> AddAcrossWidening(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addacrosswidening?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaddlv_u8).

Assembly generated:

```armasm", GetValue("AddAcrossWidening", "Performs 'AddAcrossWidening' operation.", 0), GetValue("AddAcrossWidening", Vector64byte_0.ToString(), 1), GetValue("AddAcrossWidening", apiResult.ToString(), 2));

try {
AddAcrossWideningTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddHighNarrowingLowerResult = Dummy_AddHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = AddHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. AddHighNarrowingLower

`Vector64<byte> AddHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector64<byte> AddHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddHighNarrowingLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> AddHighNarrowingLower(Vector128<int> left, Vector128<int> right)
Vector64<int> AddHighNarrowingLower(Vector128<long> left, Vector128<long> right)
Vector64<sbyte> AddHighNarrowingLower(Vector128<short> left, Vector128<short> right)
Vector64<ushort> AddHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
Vector64<uint> AddHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addhighnarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaddhn_u16).

Assembly generated:

```armasm", GetValue("AddHighNarrowingLower", "Performs 'AddHighNarrowingLower' operation.", 0), GetValue("AddHighNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("AddHighNarrowingLower", Vector128ushort_1.ToString(), 2), GetValue("AddHighNarrowingLower", apiResult.ToString(), 3));

try {
AddHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddHighNarrowingUpperResult = Dummy_AddHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = AddHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. AddHighNarrowingUpper

`Vector128<byte> AddHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector128<byte> AddHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddHighNarrowingUpper(lower, left, right);
}}
// lower = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> AddHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
Vector128<int> AddHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
Vector128<sbyte> AddHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
Vector128<ushort> AddHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
Vector128<uint> AddHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addhighnarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaddhn_high_u16).

Assembly generated:

```armasm", GetValue("AddHighNarrowingUpper", "Performs 'AddHighNarrowingUpper' operation.", 0), GetValue("AddHighNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("AddHighNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("AddHighNarrowingUpper", Vector128ushort_1.ToString(), 3), GetValue("AddHighNarrowingUpper", apiResult.ToString(), 4));

try {
AddHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddPairwiseResult = Dummy_AddPairwiseTest(Vector64byte_0, Vector64byte_1);
apiResult = AddPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. AddPairwise

`Vector64<byte> AddPairwise(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> AddPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AddPairwise(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> AddPairwise(Vector64<short> left, Vector64<short> right)
Vector64<int> AddPairwise(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> AddPairwise(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> AddPairwise(Vector64<float> left, Vector64<float> right)
Vector64<ushort> AddPairwise(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> AddPairwise(Vector64<uint> left, Vector64<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> AddPairwise(Vector128<byte> left, Vector128<byte> right)
Vector128<double> AddPairwise(Vector128<double> left, Vector128<double> right)
Vector128<short> AddPairwise(Vector128<short> left, Vector128<short> right)
Vector128<int> AddPairwise(Vector128<int> left, Vector128<int> right)
Vector128<long> AddPairwise(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> AddPairwise(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> AddPairwise(Vector128<float> left, Vector128<float> right)
Vector128<ushort> AddPairwise(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> AddPairwise(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> AddPairwise(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwise?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addpairwise?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpadd_u8).

Assembly generated:

```armasm", GetValue("AddPairwise", "Performs 'AddPairwise' operation.", 0), GetValue("AddPairwise", Vector64byte_0.ToString(), 1), GetValue("AddPairwise", Vector64byte_1.ToString(), 2), GetValue("AddPairwise", apiResult.ToString(), 3));

try {
AddPairwiseTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddPairwiseScalarResult = Dummy_AddPairwiseScalarTest(Vector64float_0);
apiResult = AddPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. AddPairwiseScalar

`Vector64<float> AddPairwiseScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<float> AddPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.AddPairwiseScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> AddPairwiseScalar(Vector128<double> value)
Vector64<long> AddPairwiseScalar(Vector128<long> value)
Vector64<ulong> AddPairwiseScalar(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addpairwisescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpadds_f32).

Assembly generated:

```armasm", GetValue("AddPairwiseScalar", "Performs 'AddPairwiseScalar' operation.", 0), GetValue("AddPairwiseScalar", Vector64float_0.ToString(), 1), GetValue("AddPairwiseScalar", apiResult.ToString(), 2));

try {
AddPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddPairwiseWideningResult = Dummy_AddPairwiseWideningTest(Vector64byte_0);
apiResult = AddPairwiseWideningResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. AddPairwiseWidening

`Vector64<ushort> AddPairwiseWidening(Vector64<byte> value)`

{0}

```csharp
private Vector64<ushort> AddPairwiseWideningTest(Vector64<byte> value)
{{
  return AdvSimd.AddPairwiseWidening(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> AddPairwiseWidening(Vector64<short> value)
Vector64<short> AddPairwiseWidening(Vector64<sbyte> value)
Vector64<uint> AddPairwiseWidening(Vector64<ushort> value)
Vector128<ushort> AddPairwiseWidening(Vector128<byte> value)
Vector128<int> AddPairwiseWidening(Vector128<short> value)
Vector128<long> AddPairwiseWidening(Vector128<int> value)
Vector128<short> AddPairwiseWidening(Vector128<sbyte> value)
Vector128<uint> AddPairwiseWidening(Vector128<ushort> value)
Vector128<ulong> AddPairwiseWidening(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewidening?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpaddl_u8).

Assembly generated:

```armasm", GetValue("AddPairwiseWidening", "Performs 'AddPairwiseWidening' operation.", 0), GetValue("AddPairwiseWidening", Vector64byte_0.ToString(), 1), GetValue("AddPairwiseWidening", apiResult.ToString(), 2));

try {
AddPairwiseWideningTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddPairwiseWideningAndAddResult = Dummy_AddPairwiseWideningAndAddTest(Vector64ushort_0, Vector64byte_0);
apiResult = AddPairwiseWideningAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. AddPairwiseWideningAndAdd

`Vector64<ushort> AddPairwiseWideningAndAdd(Vector64<ushort> addend, Vector64<byte> value)`

{0}

```csharp
private Vector64<ushort> AddPairwiseWideningAndAddTest(Vector64<ushort> addend, Vector64<byte> value)
{{
  return AdvSimd.AddPairwiseWideningAndAdd(addend, value);
}}
// addend = {1}
// value = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> AddPairwiseWideningAndAdd(Vector64<int> addend, Vector64<short> value)
Vector64<short> AddPairwiseWideningAndAdd(Vector64<short> addend, Vector64<sbyte> value)
Vector64<uint> AddPairwiseWideningAndAdd(Vector64<uint> addend, Vector64<ushort> value)
Vector128<ushort> AddPairwiseWideningAndAdd(Vector128<ushort> addend, Vector128<byte> value)
Vector128<int> AddPairwiseWideningAndAdd(Vector128<int> addend, Vector128<short> value)
Vector128<long> AddPairwiseWideningAndAdd(Vector128<long> addend, Vector128<int> value)
Vector128<short> AddPairwiseWideningAndAdd(Vector128<short> addend, Vector128<sbyte> value)
Vector128<uint> AddPairwiseWideningAndAdd(Vector128<uint> addend, Vector128<ushort> value)
Vector128<ulong> AddPairwiseWideningAndAdd(Vector128<ulong> addend, Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewideningandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpadal_u8).

Assembly generated:

```armasm", GetValue("AddPairwiseWideningAndAdd", "Performs 'AddPairwiseWideningAndAdd' operation.", 0), GetValue("AddPairwiseWideningAndAdd", Vector64ushort_0.ToString(), 1), GetValue("AddPairwiseWideningAndAdd", Vector64byte_0.ToString(), 2), GetValue("AddPairwiseWideningAndAdd", apiResult.ToString(), 3));

try {
AddPairwiseWideningAndAddTest(Vector64ushort_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddPairwiseWideningAndAddScalarResult = Dummy_AddPairwiseWideningAndAddScalarTest(Vector64long_0, Vector64int_0);
apiResult = AddPairwiseWideningAndAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. AddPairwiseWideningAndAddScalar

`Vector64<long> AddPairwiseWideningAndAddScalar(Vector64<long> addend, Vector64<int> value)`

{0}

```csharp
private Vector64<long> AddPairwiseWideningAndAddScalarTest(Vector64<long> addend, Vector64<int> value)
{{
  return AdvSimd.AddPairwiseWideningAndAddScalar(addend, value);
}}
// addend = {1}
// value = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> AddPairwiseWideningAndAddScalar(Vector64<ulong> addend, Vector64<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewideningandaddscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpadal_s32).

Assembly generated:

```armasm", GetValue("AddPairwiseWideningAndAddScalar", "Performs 'AddPairwiseWideningAndAddScalar' operation.", 0), GetValue("AddPairwiseWideningAndAddScalar", Vector64long_0.ToString(), 1), GetValue("AddPairwiseWideningAndAddScalar", Vector64int_0.ToString(), 2), GetValue("AddPairwiseWideningAndAddScalar", apiResult.ToString(), 3));

try {
AddPairwiseWideningAndAddScalarTest(Vector64long_0, Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddPairwiseWideningScalarResult = Dummy_AddPairwiseWideningScalarTest(Vector64int_0);
apiResult = AddPairwiseWideningScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. AddPairwiseWideningScalar

`Vector64<long> AddPairwiseWideningScalar(Vector64<int> value)`

{0}

```csharp
private Vector64<long> AddPairwiseWideningScalarTest(Vector64<int> value)
{{
  return AdvSimd.AddPairwiseWideningScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> AddPairwiseWideningScalar(Vector64<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewideningscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpaddl_s32).

Assembly generated:

```armasm", GetValue("AddPairwiseWideningScalar", "Performs 'AddPairwiseWideningScalar' operation.", 0), GetValue("AddPairwiseWideningScalar", Vector64int_0.ToString(), 1), GetValue("AddPairwiseWideningScalar", apiResult.ToString(), 2));

try {
AddPairwiseWideningScalarTest(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddRoundedHighNarrowingLowerResult = Dummy_AddRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = AddRoundedHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. AddRoundedHighNarrowingLower

`Vector64<byte> AddRoundedHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector64<byte> AddRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddRoundedHighNarrowingLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> AddRoundedHighNarrowingLower(Vector128<int> left, Vector128<int> right)
Vector64<int> AddRoundedHighNarrowingLower(Vector128<long> left, Vector128<long> right)
Vector64<sbyte> AddRoundedHighNarrowingLower(Vector128<short> left, Vector128<short> right)
Vector64<ushort> AddRoundedHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
Vector64<uint> AddRoundedHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addroundedhighnarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vraddhn_u16).

Assembly generated:

```armasm", GetValue("AddRoundedHighNarrowingLower", "Performs 'AddRoundedHighNarrowingLower' operation.", 0), GetValue("AddRoundedHighNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("AddRoundedHighNarrowingLower", Vector128ushort_1.ToString(), 2), GetValue("AddRoundedHighNarrowingLower", apiResult.ToString(), 3));

try {
AddRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddRoundedHighNarrowingUpperResult = Dummy_AddRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = AddRoundedHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. AddRoundedHighNarrowingUpper

`Vector128<byte> AddRoundedHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector128<byte> AddRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddRoundedHighNarrowingUpper(lower, left, right);
}}
// lower = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> AddRoundedHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
Vector128<int> AddRoundedHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
Vector128<sbyte> AddRoundedHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
Vector128<ushort> AddRoundedHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
Vector128<uint> AddRoundedHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addroundedhighnarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vraddhn_high_u16).

Assembly generated:

```armasm", GetValue("AddRoundedHighNarrowingUpper", "Performs 'AddRoundedHighNarrowingUpper' operation.", 0), GetValue("AddRoundedHighNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("AddRoundedHighNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("AddRoundedHighNarrowingUpper", Vector128ushort_1.ToString(), 3), GetValue("AddRoundedHighNarrowingUpper", apiResult.ToString(), 4));

try {
AddRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddSaturateResult = Dummy_AddSaturateTest(Vector64byte_0, Vector64byte_1);
apiResult = AddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. AddSaturate

`Vector64<byte> AddSaturate(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> AddSaturateTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AddSaturate(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> AddSaturate(Vector64<short> left, Vector64<short> right)
Vector64<int> AddSaturate(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> AddSaturate(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> AddSaturate(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> AddSaturate(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<byte> right)
Vector128<short> AddSaturate(Vector128<short> left, Vector128<short> right)
Vector128<int> AddSaturate(Vector128<int> left, Vector128<int> right)
Vector128<long> AddSaturate(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> AddSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> AddSaturate(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> AddSaturate(Vector128<ulong> left, Vector128<ulong> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> AddSaturate(Vector64<byte> left, Vector64<sbyte> right)
Vector64<short> AddSaturate(Vector64<short> left, Vector64<ushort> right)
Vector64<int> AddSaturate(Vector64<int> left, Vector64<uint> right)
Vector64<sbyte> AddSaturate(Vector64<sbyte> left, Vector64<byte> right)
Vector64<ushort> AddSaturate(Vector64<ushort> left, Vector64<short> right)
Vector64<uint> AddSaturate(Vector64<uint> left, Vector64<int> right)
Vector128<byte> AddSaturate(Vector128<byte> left, Vector128<sbyte> right)
Vector128<short> AddSaturate(Vector128<short> left, Vector128<ushort> right)
Vector128<int> AddSaturate(Vector128<int> left, Vector128<uint> right)
Vector128<long> AddSaturate(Vector128<long> left, Vector128<ulong> right)
Vector128<sbyte> AddSaturate(Vector128<sbyte> left, Vector128<byte> right)
Vector128<ushort> AddSaturate(Vector128<ushort> left, Vector128<short> right)
Vector128<uint> AddSaturate(Vector128<uint> left, Vector128<int> right)
Vector128<ulong> AddSaturate(Vector128<ulong> left, Vector128<long> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addsaturate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqadd_u8).

Assembly generated:

```armasm", GetValue("AddSaturate", "Performs 'AddSaturate' operation.", 0), GetValue("AddSaturate", Vector64byte_0.ToString(), 1), GetValue("AddSaturate", Vector64byte_1.ToString(), 2), GetValue("AddSaturate", apiResult.ToString(), 3));

try {
AddSaturateTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddSaturateScalarResult = Dummy_AddSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = AddSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. AddSaturateScalar

`Vector64<long> AddSaturateScalar(Vector64<long> left, Vector64<long> right)`

{0}

```csharp
private Vector64<long> AddSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{{
  return AdvSimd.AddSaturateScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> AddSaturateScalar(Vector64<ulong> left, Vector64<ulong> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> AddSaturateScalar(Vector64<byte> left, Vector64<byte> right)
Vector64<byte> AddSaturateScalar(Vector64<byte> left, Vector64<sbyte> right)
Vector64<short> AddSaturateScalar(Vector64<short> left, Vector64<short> right)
Vector64<short> AddSaturateScalar(Vector64<short> left, Vector64<ushort> right)
Vector64<int> AddSaturateScalar(Vector64<int> left, Vector64<int> right)
Vector64<int> AddSaturateScalar(Vector64<int> left, Vector64<uint> right)
Vector64<long> AddSaturateScalar(Vector64<long> left, Vector64<ulong> right)
Vector64<sbyte> AddSaturateScalar(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<sbyte> AddSaturateScalar(Vector64<sbyte> left, Vector64<byte> right)
Vector64<ushort> AddSaturateScalar(Vector64<ushort> left, Vector64<ushort> right)
Vector64<ushort> AddSaturateScalar(Vector64<ushort> left, Vector64<short> right)
Vector64<uint> AddSaturateScalar(Vector64<uint> left, Vector64<uint> right)
Vector64<uint> AddSaturateScalar(Vector64<uint> left, Vector64<int> right)
Vector64<ulong> AddSaturateScalar(Vector64<ulong> left, Vector64<long> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqadd_s64).

Assembly generated:

```armasm", GetValue("AddSaturateScalar", "Performs 'AddSaturateScalar' operation.", 0), GetValue("AddSaturateScalar", Vector64long_0.ToString(), 1), GetValue("AddSaturateScalar", Vector64long_1.ToString(), 2), GetValue("AddSaturateScalar", apiResult.ToString(), 3));

try {
AddSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddScalarResult = Dummy_AddScalarTest(Vector64double_0, Vector64double_1);
apiResult = AddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. AddScalar

`Vector64<double> AddScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> AddScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.AddScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<long> AddScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> AddScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> AddScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vadd_f64).

Assembly generated:

```armasm", GetValue("AddScalar", "Performs 'AddScalar' operation.", 0), GetValue("AddScalar", Vector64double_0.ToString(), 1), GetValue("AddScalar", Vector64double_1.ToString(), 2), GetValue("AddScalar", apiResult.ToString(), 3));

try {
AddScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddWideningLowerResult = Dummy_AddWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = AddWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. AddWideningLower

`Vector128<ushort> AddWideningLower(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> AddWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AddWideningLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> AddWideningLower(Vector64<short> left, Vector64<short> right)
Vector128<long> AddWideningLower(Vector64<int> left, Vector64<int> right)
Vector128<short> AddWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> AddWideningLower(Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> AddWideningLower(Vector64<uint> left, Vector64<uint> right)
Vector128<short> AddWideningLower(Vector128<short> left, Vector64<sbyte> right)
Vector128<int> AddWideningLower(Vector128<int> left, Vector64<short> right)
Vector128<long> AddWideningLower(Vector128<long> left, Vector64<int> right)
Vector128<ushort> AddWideningLower(Vector128<ushort> left, Vector64<byte> right)
Vector128<uint> AddWideningLower(Vector128<uint> left, Vector64<ushort> right)
Vector128<ulong> AddWideningLower(Vector128<ulong> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addwideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaddl_u8).

Assembly generated:

```armasm", GetValue("AddWideningLower", "Performs 'AddWideningLower' operation.", 0), GetValue("AddWideningLower", Vector64byte_0.ToString(), 1), GetValue("AddWideningLower", Vector64byte_1.ToString(), 2), GetValue("AddWideningLower", apiResult.ToString(), 3));

try {
AddWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AddWideningUpperResult = Dummy_AddWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = AddWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. AddWideningUpper

`Vector128<ushort> AddWideningUpper(Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> AddWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.AddWideningUpper(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> AddWideningUpper(Vector128<short> left, Vector128<short> right)
Vector128<short> AddWideningUpper(Vector128<short> left, Vector128<sbyte> right)
Vector128<int> AddWideningUpper(Vector128<int> left, Vector128<short> right)
Vector128<long> AddWideningUpper(Vector128<int> left, Vector128<int> right)
Vector128<long> AddWideningUpper(Vector128<long> left, Vector128<int> right)
Vector128<short> AddWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> AddWideningUpper(Vector128<ushort> left, Vector128<byte> right)
Vector128<uint> AddWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> AddWideningUpper(Vector128<uint> left, Vector128<ushort> right)
Vector128<ulong> AddWideningUpper(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> AddWideningUpper(Vector128<ulong> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addwideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vaddl_high_u8).

Assembly generated:

```armasm", GetValue("AddWideningUpper", "Performs 'AddWideningUpper' operation.", 0), GetValue("AddWideningUpper", Vector128byte_0.ToString(), 1), GetValue("AddWideningUpper", Vector128byte_1.ToString(), 2), GetValue("AddWideningUpper", apiResult.ToString(), 3));

try {
AddWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var AndResult = Dummy_AndTest(Vector64byte_0, Vector64byte_1);
apiResult = AndResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. And

`Vector64<byte> And(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> AndTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.And(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> And(Vector64<double> left, Vector64<double> right)
Vector64<short> And(Vector64<short> left, Vector64<short> right)
Vector64<int> And(Vector64<int> left, Vector64<int> right)
Vector64<long> And(Vector64<long> left, Vector64<long> right)
Vector64<sbyte> And(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> And(Vector64<float> left, Vector64<float> right)
Vector64<ushort> And(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> And(Vector64<uint> left, Vector64<uint> right)
Vector64<ulong> And(Vector64<ulong> left, Vector64<ulong> right)
Vector128<byte> And(Vector128<byte> left, Vector128<byte> right)
Vector128<double> And(Vector128<double> left, Vector128<double> right)
Vector128<short> And(Vector128<short> left, Vector128<short> right)
Vector128<int> And(Vector128<int> left, Vector128<int> right)
Vector128<long> And(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> And(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> And(Vector128<float> left, Vector128<float> right)
Vector128<ushort> And(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> And(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> And(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.and?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vand_u8).

Assembly generated:

```armasm", GetValue("And", "Performs 'And' operation.", 0), GetValue("And", Vector64byte_0.ToString(), 1), GetValue("And", Vector64byte_1.ToString(), 2), GetValue("And", apiResult.ToString(), 3));

try {
AndTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var BitwiseClearResult = Dummy_BitwiseClearTest(Vector64byte_0, Vector64byte_1);
apiResult = BitwiseClearResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. BitwiseClear

`Vector64<byte> BitwiseClear(Vector64<byte> value, Vector64<byte> mask)`

{0}

```csharp
private Vector64<byte> BitwiseClearTest(Vector64<byte> value, Vector64<byte> mask)
{{
  return AdvSimd.BitwiseClear(value, mask);
}}
// value = {1}
// mask = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> BitwiseClear(Vector64<double> value, Vector64<double> mask)
Vector64<short> BitwiseClear(Vector64<short> value, Vector64<short> mask)
Vector64<int> BitwiseClear(Vector64<int> value, Vector64<int> mask)
Vector64<long> BitwiseClear(Vector64<long> value, Vector64<long> mask)
Vector64<sbyte> BitwiseClear(Vector64<sbyte> value, Vector64<sbyte> mask)
Vector64<float> BitwiseClear(Vector64<float> value, Vector64<float> mask)
Vector64<ushort> BitwiseClear(Vector64<ushort> value, Vector64<ushort> mask)
Vector64<uint> BitwiseClear(Vector64<uint> value, Vector64<uint> mask)
Vector64<ulong> BitwiseClear(Vector64<ulong> value, Vector64<ulong> mask)
Vector128<byte> BitwiseClear(Vector128<byte> value, Vector128<byte> mask)
Vector128<double> BitwiseClear(Vector128<double> value, Vector128<double> mask)
Vector128<short> BitwiseClear(Vector128<short> value, Vector128<short> mask)
Vector128<int> BitwiseClear(Vector128<int> value, Vector128<int> mask)
Vector128<long> BitwiseClear(Vector128<long> value, Vector128<long> mask)
Vector128<sbyte> BitwiseClear(Vector128<sbyte> value, Vector128<sbyte> mask)
Vector128<float> BitwiseClear(Vector128<float> value, Vector128<float> mask)
Vector128<ushort> BitwiseClear(Vector128<ushort> value, Vector128<ushort> mask)
Vector128<uint> BitwiseClear(Vector128<uint> value, Vector128<uint> mask)
Vector128<ulong> BitwiseClear(Vector128<ulong> value, Vector128<ulong> mask)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.bitwiseclear?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vbic_u8).

Assembly generated:

```armasm", GetValue("BitwiseClear", "Performs 'BitwiseClear' operation.", 0), GetValue("BitwiseClear", Vector64byte_0.ToString(), 1), GetValue("BitwiseClear", Vector64byte_1.ToString(), 2), GetValue("BitwiseClear", apiResult.ToString(), 3));

try {
BitwiseClearTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var BitwiseSelectResult = Dummy_BitwiseSelectTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = BitwiseSelectResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. BitwiseSelect

`Vector64<byte> BitwiseSelect(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> BitwiseSelectTest(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.BitwiseSelect(select, left, right);
}}
// select = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> BitwiseSelect(Vector64<double> select, Vector64<double> left, Vector64<double> right)
Vector64<short> BitwiseSelect(Vector64<short> select, Vector64<short> left, Vector64<short> right)
Vector64<int> BitwiseSelect(Vector64<int> select, Vector64<int> left, Vector64<int> right)
Vector64<long> BitwiseSelect(Vector64<long> select, Vector64<long> left, Vector64<long> right)
Vector64<sbyte> BitwiseSelect(Vector64<sbyte> select, Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> BitwiseSelect(Vector64<float> select, Vector64<float> left, Vector64<float> right)
Vector64<ushort> BitwiseSelect(Vector64<ushort> select, Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> BitwiseSelect(Vector64<uint> select, Vector64<uint> left, Vector64<uint> right)
Vector64<ulong> BitwiseSelect(Vector64<ulong> select, Vector64<ulong> left, Vector64<ulong> right)
Vector128<byte> BitwiseSelect(Vector128<byte> select, Vector128<byte> left, Vector128<byte> right)
Vector128<double> BitwiseSelect(Vector128<double> select, Vector128<double> left, Vector128<double> right)
Vector128<short> BitwiseSelect(Vector128<short> select, Vector128<short> left, Vector128<short> right)
Vector128<int> BitwiseSelect(Vector128<int> select, Vector128<int> left, Vector128<int> right)
Vector128<long> BitwiseSelect(Vector128<long> select, Vector128<long> left, Vector128<long> right)
Vector128<sbyte> BitwiseSelect(Vector128<sbyte> select, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> BitwiseSelect(Vector128<float> select, Vector128<float> left, Vector128<float> right)
Vector128<ushort> BitwiseSelect(Vector128<ushort> select, Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> BitwiseSelect(Vector128<uint> select, Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> BitwiseSelect(Vector128<ulong> select, Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.bitwiseselect?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vbsl_u8).

Assembly generated:

```armasm", GetValue("BitwiseSelect", "Performs 'BitwiseSelect' operation.", 0), GetValue("BitwiseSelect", Vector64byte_0.ToString(), 1), GetValue("BitwiseSelect", Vector64byte_1.ToString(), 2), GetValue("BitwiseSelect", Vector64byte_2.ToString(), 3), GetValue("BitwiseSelect", apiResult.ToString(), 4));

try {
BitwiseSelectTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CeilingResult = Dummy_CeilingTest(Vector64float_0);
apiResult = CeilingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. Ceiling

`Vector64<float> Ceiling(Vector64<float> value)`

{0}

```csharp
private Vector64<float> CeilingTest(Vector64<float> value)
{{
  return AdvSimd.Ceiling(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> Ceiling(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Ceiling(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.ceiling?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.ceiling?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndp_f32).

Assembly generated:

```armasm", GetValue("Ceiling", "Performs 'Ceiling' operation.", 0), GetValue("Ceiling", Vector64float_0.ToString(), 1), GetValue("Ceiling", apiResult.ToString(), 2));

try {
CeilingTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CeilingScalarResult = Dummy_CeilingScalarTest(Vector64double_0);
apiResult = CeilingScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. CeilingScalar

`Vector64<double> CeilingScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> CeilingScalarTest(Vector64<double> value)
{{
  return AdvSimd.CeilingScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> CeilingScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.ceilingscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndp_f64).

Assembly generated:

```armasm", GetValue("CeilingScalar", "Performs 'CeilingScalar' operation.", 0), GetValue("CeilingScalar", Vector64double_0.ToString(), 1), GetValue("CeilingScalar", apiResult.ToString(), 2));

try {
CeilingScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareEqualResult = Dummy_CompareEqualTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. CompareEqual

`Vector64<byte> CompareEqual(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> CompareEqualTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareEqual(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> CompareEqual(Vector64<short> left, Vector64<short> right)
Vector64<int> CompareEqual(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> CompareEqual(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> CompareEqual(Vector64<float> left, Vector64<float> right)
Vector64<ushort> CompareEqual(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> CompareEqual(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> CompareEqual(Vector128<byte> left, Vector128<byte> right)
Vector128<short> CompareEqual(Vector128<short> left, Vector128<short> right)
Vector128<int> CompareEqual(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> CompareEqual(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> CompareEqual(Vector128<float> left, Vector128<float> right)
Vector128<ushort> CompareEqual(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> CompareEqual(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> CompareEqual(Vector128<double> left, Vector128<double> right)
Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right)
Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.compareequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.compareequal?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vceq_u8).

Assembly generated:

```armasm", GetValue("CompareEqual", "Performs 'CompareEqual' operation.", 0), GetValue("CompareEqual", Vector64byte_0.ToString(), 1), GetValue("CompareEqual", Vector64byte_1.ToString(), 2), GetValue("CompareEqual", apiResult.ToString(), 3));

try {
CompareEqualTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareEqualScalarResult = Dummy_CompareEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. CompareEqualScalar

`Vector64<double> CompareEqualScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> CompareEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareEqualScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareEqualScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareEqualScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.compareequalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vceq_f64).

Assembly generated:

```armasm", GetValue("CompareEqualScalar", "Performs 'CompareEqualScalar' operation.", 0), GetValue("CompareEqualScalar", Vector64double_0.ToString(), 1), GetValue("CompareEqualScalar", Vector64double_1.ToString(), 2), GetValue("CompareEqualScalar", apiResult.ToString(), 3));

try {
CompareEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareGreaterThanResult = Dummy_CompareGreaterThanTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareGreaterThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. CompareGreaterThan

`Vector64<byte> CompareGreaterThan(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> CompareGreaterThanTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareGreaterThan(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> CompareGreaterThan(Vector64<short> left, Vector64<short> right)
Vector64<int> CompareGreaterThan(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> CompareGreaterThan(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> CompareGreaterThan(Vector64<float> left, Vector64<float> right)
Vector64<ushort> CompareGreaterThan(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> CompareGreaterThan(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> CompareGreaterThan(Vector128<byte> left, Vector128<byte> right)
Vector128<short> CompareGreaterThan(Vector128<short> left, Vector128<short> right)
Vector128<int> CompareGreaterThan(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> CompareGreaterThan(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> CompareGreaterThan(Vector128<float> left, Vector128<float> right)
Vector128<ushort> CompareGreaterThan(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> CompareGreaterThan(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> CompareGreaterThan(Vector128<double> left, Vector128<double> right)
Vector128<long> CompareGreaterThan(Vector128<long> left, Vector128<long> right)
Vector128<ulong> CompareGreaterThan(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparegreaterthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthan?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcgt_u8).

Assembly generated:

```armasm", GetValue("CompareGreaterThan", "Performs 'CompareGreaterThan' operation.", 0), GetValue("CompareGreaterThan", Vector64byte_0.ToString(), 1), GetValue("CompareGreaterThan", Vector64byte_1.ToString(), 2), GetValue("CompareGreaterThan", apiResult.ToString(), 3));

try {
CompareGreaterThanTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 2
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 2 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[CompareGreaterThanOrEqual](#1-comparegreaterthanorequal), [CompareGreaterThanOrEqualScalar](#2-comparegreaterthanorequalscalar), [CompareGreaterThanScalar](#3-comparegreaterthanscalar), [CompareLessThan](#4-comparelessthan), [CompareLessThanOrEqual](#5-comparelessthanorequal), [CompareLessThanOrEqualScalar](#6-comparelessthanorequalscalar), [CompareLessThanScalar](#7-comparelessthanscalar), [CompareTest](#8-comparetest), [CompareTestScalar](#9-comparetestscalar), [ConvertToDouble](#10-converttodouble), [ConvertToDoubleScalar](#11-converttodoublescalar), [ConvertToDoubleUpper](#12-converttodoubleupper), [ConvertToInt32RoundAwayFromZero](#13-converttoint32roundawayfromzero), [ConvertToInt32RoundAwayFromZeroScalar](#14-converttoint32roundawayfromzeroscalar), [ConvertToInt32RoundToEven](#15-converttoint32roundtoeven), [ConvertToInt32RoundToEvenScalar](#16-converttoint32roundtoevenscalar), [ConvertToInt32RoundToNegativeInfinity](#17-converttoint32roundtonegativeinfinity), [ConvertToInt32RoundToNegativeInfinityScalar](#18-converttoint32roundtonegativeinfinityscalar), [ConvertToInt32RoundToPositiveInfinity](#19-converttoint32roundtopositiveinfinity), [ConvertToInt32RoundToPositiveInfinityScalar](#20-converttoint32roundtopositiveinfinityscalar), [ConvertToInt32RoundToZero](#21-converttoint32roundtozero), [ConvertToInt32RoundToZeroScalar](#22-converttoint32roundtozeroscalar), [ConvertToInt64RoundAwayFromZero](#23-converttoint64roundawayfromzero), [ConvertToInt64RoundAwayFromZeroScalar](#24-converttoint64roundawayfromzeroscalar), [ConvertToInt64RoundToEven](#25-converttoint64roundtoeven), [ConvertToInt64RoundToEvenScalar](#26-converttoint64roundtoevenscalar), [ConvertToInt64RoundToNegativeInfinity](#27-converttoint64roundtonegativeinfinity), [ConvertToInt64RoundToNegativeInfinityScalar](#28-converttoint64roundtonegativeinfinityscalar), [ConvertToInt64RoundToPositiveInfinity](#29-converttoint64roundtopositiveinfinity), [ConvertToInt64RoundToPositiveInfinityScalar](#30-converttoint64roundtopositiveinfinityscalar), [ConvertToInt64RoundToZero](#31-converttoint64roundtozero), [ConvertToInt64RoundToZeroScalar](#32-converttoint64roundtozeroscalar), [ConvertToSingle](#33-converttosingle), [ConvertToSingleLower](#34-converttosinglelower), [ConvertToSingleRoundToOddLower](#35-converttosingleroundtooddlower), [ConvertToSingleRoundToOddUpper](#36-converttosingleroundtooddupper), [ConvertToSingleScalar](#37-converttosinglescalar), [ConvertToSingleUpper](#38-converttosingleupper), [ConvertToUInt32RoundAwayFromZero](#39-converttouint32roundawayfromzero), [ConvertToUInt32RoundAwayFromZeroScalar](#40-converttouint32roundawayfromzeroscalar), [ConvertToUInt32RoundToEven](#41-converttouint32roundtoeven), [ConvertToUInt32RoundToEvenScalar](#42-converttouint32roundtoevenscalar), [ConvertToUInt32RoundToNegativeInfinity](#43-converttouint32roundtonegativeinfinity), [ConvertToUInt32RoundToNegativeInfinityScalar](#44-converttouint32roundtonegativeinfinityscalar), [ConvertToUInt32RoundToPositiveInfinity](#45-converttouint32roundtopositiveinfinity)


");

try {
var CompareGreaterThanOrEqualResult = Dummy_CompareGreaterThanOrEqualTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareGreaterThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. CompareGreaterThanOrEqual

`Vector64<byte> CompareGreaterThanOrEqual(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> CompareGreaterThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareGreaterThanOrEqual(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> CompareGreaterThanOrEqual(Vector64<short> left, Vector64<short> right)
Vector64<int> CompareGreaterThanOrEqual(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> CompareGreaterThanOrEqual(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> CompareGreaterThanOrEqual(Vector64<float> left, Vector64<float> right)
Vector64<ushort> CompareGreaterThanOrEqual(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> CompareGreaterThanOrEqual(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> CompareGreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right)
Vector128<short> CompareGreaterThanOrEqual(Vector128<short> left, Vector128<short> right)
Vector128<int> CompareGreaterThanOrEqual(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> CompareGreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> CompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)
Vector128<ushort> CompareGreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> CompareGreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> CompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
Vector128<long> CompareGreaterThanOrEqual(Vector128<long> left, Vector128<long> right)
Vector128<ulong> CompareGreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparegreaterthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthanorequal?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcge_u8).

Assembly generated:

```armasm", GetValue("CompareGreaterThanOrEqual", "Performs 'CompareGreaterThanOrEqual' operation.", 0), GetValue("CompareGreaterThanOrEqual", Vector64byte_0.ToString(), 1), GetValue("CompareGreaterThanOrEqual", Vector64byte_1.ToString(), 2), GetValue("CompareGreaterThanOrEqual", apiResult.ToString(), 3));

try {
CompareGreaterThanOrEqualTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareGreaterThanOrEqualScalarResult = Dummy_CompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareGreaterThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. CompareGreaterThanOrEqualScalar

`Vector64<double> CompareGreaterThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> CompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareGreaterThanOrEqualScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareGreaterThanOrEqualScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareGreaterThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareGreaterThanOrEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthanorequalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcge_f64).

Assembly generated:

```armasm", GetValue("CompareGreaterThanOrEqualScalar", "Performs 'CompareGreaterThanOrEqualScalar' operation.", 0), GetValue("CompareGreaterThanOrEqualScalar", Vector64double_0.ToString(), 1), GetValue("CompareGreaterThanOrEqualScalar", Vector64double_1.ToString(), 2), GetValue("CompareGreaterThanOrEqualScalar", apiResult.ToString(), 3));

try {
CompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareGreaterThanScalarResult = Dummy_CompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareGreaterThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. CompareGreaterThanScalar

`Vector64<double> CompareGreaterThanScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> CompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareGreaterThanScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareGreaterThanScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareGreaterThanScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareGreaterThanScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthanscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcgt_f64).

Assembly generated:

```armasm", GetValue("CompareGreaterThanScalar", "Performs 'CompareGreaterThanScalar' operation.", 0), GetValue("CompareGreaterThanScalar", Vector64double_0.ToString(), 1), GetValue("CompareGreaterThanScalar", Vector64double_1.ToString(), 2), GetValue("CompareGreaterThanScalar", apiResult.ToString(), 3));

try {
CompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareLessThanResult = Dummy_CompareLessThanTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareLessThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. CompareLessThan

`Vector64<byte> CompareLessThan(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> CompareLessThanTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareLessThan(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> CompareLessThan(Vector64<short> left, Vector64<short> right)
Vector64<int> CompareLessThan(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> CompareLessThan(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> CompareLessThan(Vector64<float> left, Vector64<float> right)
Vector64<ushort> CompareLessThan(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> CompareLessThan(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> CompareLessThan(Vector128<byte> left, Vector128<byte> right)
Vector128<short> CompareLessThan(Vector128<short> left, Vector128<short> right)
Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> CompareLessThan(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> CompareLessThan(Vector128<float> left, Vector128<float> right)
Vector128<ushort> CompareLessThan(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> CompareLessThan(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> CompareLessThan(Vector128<double> left, Vector128<double> right)
Vector128<long> CompareLessThan(Vector128<long> left, Vector128<long> right)
Vector128<ulong> CompareLessThan(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparelessthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthan?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vclt_u8).

Assembly generated:

```armasm", GetValue("CompareLessThan", "Performs 'CompareLessThan' operation.", 0), GetValue("CompareLessThan", Vector64byte_0.ToString(), 1), GetValue("CompareLessThan", Vector64byte_1.ToString(), 2), GetValue("CompareLessThan", apiResult.ToString(), 3));

try {
CompareLessThanTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareLessThanOrEqualResult = Dummy_CompareLessThanOrEqualTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareLessThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. CompareLessThanOrEqual

`Vector64<byte> CompareLessThanOrEqual(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> CompareLessThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareLessThanOrEqual(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> CompareLessThanOrEqual(Vector64<short> left, Vector64<short> right)
Vector64<int> CompareLessThanOrEqual(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> CompareLessThanOrEqual(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> CompareLessThanOrEqual(Vector64<float> left, Vector64<float> right)
Vector64<ushort> CompareLessThanOrEqual(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> CompareLessThanOrEqual(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> CompareLessThanOrEqual(Vector128<byte> left, Vector128<byte> right)
Vector128<short> CompareLessThanOrEqual(Vector128<short> left, Vector128<short> right)
Vector128<int> CompareLessThanOrEqual(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> CompareLessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> CompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)
Vector128<ushort> CompareLessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> CompareLessThanOrEqual(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> CompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
Vector128<long> CompareLessThanOrEqual(Vector128<long> left, Vector128<long> right)
Vector128<ulong> CompareLessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparelessthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthanorequal?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcle_u8).

Assembly generated:

```armasm", GetValue("CompareLessThanOrEqual", "Performs 'CompareLessThanOrEqual' operation.", 0), GetValue("CompareLessThanOrEqual", Vector64byte_0.ToString(), 1), GetValue("CompareLessThanOrEqual", Vector64byte_1.ToString(), 2), GetValue("CompareLessThanOrEqual", apiResult.ToString(), 3));

try {
CompareLessThanOrEqualTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareLessThanOrEqualScalarResult = Dummy_CompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareLessThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. CompareLessThanOrEqualScalar

`Vector64<double> CompareLessThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> CompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareLessThanOrEqualScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareLessThanOrEqualScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareLessThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareLessThanOrEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthanorequalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcle_f64).

Assembly generated:

```armasm", GetValue("CompareLessThanOrEqualScalar", "Performs 'CompareLessThanOrEqualScalar' operation.", 0), GetValue("CompareLessThanOrEqualScalar", Vector64double_0.ToString(), 1), GetValue("CompareLessThanOrEqualScalar", Vector64double_1.ToString(), 2), GetValue("CompareLessThanOrEqualScalar", apiResult.ToString(), 3));

try {
CompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareLessThanScalarResult = Dummy_CompareLessThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareLessThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. CompareLessThanScalar

`Vector64<double> CompareLessThanScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> CompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareLessThanScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareLessThanScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareLessThanScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareLessThanScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthanscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vclt_f64).

Assembly generated:

```armasm", GetValue("CompareLessThanScalar", "Performs 'CompareLessThanScalar' operation.", 0), GetValue("CompareLessThanScalar", Vector64double_0.ToString(), 1), GetValue("CompareLessThanScalar", Vector64double_1.ToString(), 2), GetValue("CompareLessThanScalar", apiResult.ToString(), 3));

try {
CompareLessThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareTestResult = Dummy_CompareTestTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareTestResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. CompareTest

`Vector64<byte> CompareTest(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> CompareTestTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareTest(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> CompareTest(Vector64<short> left, Vector64<short> right)
Vector64<int> CompareTest(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> CompareTest(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> CompareTest(Vector64<float> left, Vector64<float> right)
Vector64<ushort> CompareTest(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> CompareTest(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> CompareTest(Vector128<byte> left, Vector128<byte> right)
Vector128<short> CompareTest(Vector128<short> left, Vector128<short> right)
Vector128<int> CompareTest(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> CompareTest(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> CompareTest(Vector128<float> left, Vector128<float> right)
Vector128<ushort> CompareTest(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> CompareTest(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> CompareTest(Vector128<double> left, Vector128<double> right)
Vector128<long> CompareTest(Vector128<long> left, Vector128<long> right)
Vector128<ulong> CompareTest(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparetest?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparetest?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vtst_u8).

Assembly generated:

```armasm", GetValue("CompareTest", "Performs 'CompareTest' operation.", 0), GetValue("CompareTest", Vector64byte_0.ToString(), 1), GetValue("CompareTest", Vector64byte_1.ToString(), 2), GetValue("CompareTest", apiResult.ToString(), 3));

try {
CompareTestTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var CompareTestScalarResult = Dummy_CompareTestScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareTestScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. CompareTestScalar

`Vector64<double> CompareTestScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> CompareTestScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareTestScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareTestScalar(Vector64<long> left, Vector64<long> right)
Vector64<ulong> CompareTestScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparetestscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vtst_f64).

Assembly generated:

```armasm", GetValue("CompareTestScalar", "Performs 'CompareTestScalar' operation.", 0), GetValue("CompareTestScalar", Vector64double_0.ToString(), 1), GetValue("CompareTestScalar", Vector64double_1.ToString(), 2), GetValue("CompareTestScalar", apiResult.ToString(), 3));

try {
CompareTestScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToDoubleResult = Dummy_ConvertToDoubleTest(Vector64float_0);
apiResult = ConvertToDoubleResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. ConvertToDouble

`Vector128<double> ConvertToDouble(Vector64<float> value)`

{0}

```csharp
private Vector128<double> ConvertToDoubleTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.ConvertToDouble(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ConvertToDouble(Vector128<long> value)
Vector128<double> ConvertToDouble(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttodouble?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_f64_f32).

Assembly generated:

```armasm", GetValue("ConvertToDouble", "Performs 'ConvertToDouble' operation.", 0), GetValue("ConvertToDouble", Vector64float_0.ToString(), 1), GetValue("ConvertToDouble", apiResult.ToString(), 2));

try {
ConvertToDoubleTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToDoubleScalarResult = Dummy_ConvertToDoubleScalarTest(Vector64long_0);
apiResult = ConvertToDoubleScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. ConvertToDoubleScalar

`Vector64<double> ConvertToDoubleScalar(Vector64<long> value)`

{0}

```csharp
private Vector64<double> ConvertToDoubleScalarTest(Vector64<long> value)
{{
  return AdvSimd.Arm64.ConvertToDoubleScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> ConvertToDoubleScalar(Vector64<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttodoublescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_f64_s64).

Assembly generated:

```armasm", GetValue("ConvertToDoubleScalar", "Performs 'ConvertToDoubleScalar' operation.", 0), GetValue("ConvertToDoubleScalar", Vector64long_0.ToString(), 1), GetValue("ConvertToDoubleScalar", apiResult.ToString(), 2));

try {
ConvertToDoubleScalarTest(Vector64long_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToDoubleUpperResult = Dummy_ConvertToDoubleUpperTest(Vector128float_0);
apiResult = ConvertToDoubleUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. ConvertToDoubleUpper

`Vector128<double> ConvertToDoubleUpper(Vector128<float> value)`

{0}

```csharp
private Vector128<double> ConvertToDoubleUpperTest(Vector128<float> value)
{{
  return AdvSimd.Arm64.ConvertToDoubleUpper(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttodoubleupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_high_f64_f32).

Assembly generated:

```armasm", GetValue("ConvertToDoubleUpper", "Performs 'ConvertToDoubleUpper' operation.", 0), GetValue("ConvertToDoubleUpper", Vector128float_0.ToString(), 1), GetValue("ConvertToDoubleUpper", apiResult.ToString(), 2));

try {
ConvertToDoubleUpperTest(Vector128float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundAwayFromZeroResult = Dummy_ConvertToInt32RoundAwayFromZeroTest(Vector64float_0);
apiResult = ConvertToInt32RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. ConvertToInt32RoundAwayFromZero

`Vector64<int> ConvertToInt32RoundAwayFromZero(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundAwayFromZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundAwayFromZero(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundAwayFromZero(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundawayfromzero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvta_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundAwayFromZero", "Performs 'ConvertToInt32RoundAwayFromZero' operation.", 0), GetValue("ConvertToInt32RoundAwayFromZero", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundAwayFromZero", apiResult.ToString(), 2));

try {
ConvertToInt32RoundAwayFromZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundAwayFromZeroScalarResult = Dummy_ConvertToInt32RoundAwayFromZeroScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. ConvertToInt32RoundAwayFromZeroScalar

`Vector64<int> ConvertToInt32RoundAwayFromZeroScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundAwayFromZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundawayfromzeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtas_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundAwayFromZeroScalar", "Performs 'ConvertToInt32RoundAwayFromZeroScalar' operation.", 0), GetValue("ConvertToInt32RoundAwayFromZeroScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundAwayFromZeroScalar", apiResult.ToString(), 2));

try {
ConvertToInt32RoundAwayFromZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToEvenResult = Dummy_ConvertToInt32RoundToEvenTest(Vector64float_0);
apiResult = ConvertToInt32RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. ConvertToInt32RoundToEven

`Vector64<int> ConvertToInt32RoundToEven(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToEvenTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToEven(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToEven(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtoeven?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtn_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToEven", "Performs 'ConvertToInt32RoundToEven' operation.", 0), GetValue("ConvertToInt32RoundToEven", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToEven", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToEvenTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToEvenScalarResult = Dummy_ConvertToInt32RoundToEvenScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. ConvertToInt32RoundToEvenScalar

`Vector64<int> ConvertToInt32RoundToEvenScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToEvenScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToEvenScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtoevenscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtns_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToEvenScalar", "Performs 'ConvertToInt32RoundToEvenScalar' operation.", 0), GetValue("ConvertToInt32RoundToEvenScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToEvenScalar", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToEvenScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToNegativeInfinityResult = Dummy_ConvertToInt32RoundToNegativeInfinityTest(Vector64float_0);
apiResult = ConvertToInt32RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. ConvertToInt32RoundToNegativeInfinity

`Vector64<int> ConvertToInt32RoundToNegativeInfinity(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToNegativeInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinity(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToNegativeInfinity(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtonegativeinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtm_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToNegativeInfinity", "Performs 'ConvertToInt32RoundToNegativeInfinity' operation.", 0), GetValue("ConvertToInt32RoundToNegativeInfinity", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToNegativeInfinity", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToNegativeInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToNegativeInfinityScalarResult = Dummy_ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. ConvertToInt32RoundToNegativeInfinityScalar

`Vector64<int> ConvertToInt32RoundToNegativeInfinityScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtonegativeinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtms_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToNegativeInfinityScalar", "Performs 'ConvertToInt32RoundToNegativeInfinityScalar' operation.", 0), GetValue("ConvertToInt32RoundToNegativeInfinityScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToNegativeInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToPositiveInfinityResult = Dummy_ConvertToInt32RoundToPositiveInfinityTest(Vector64float_0);
apiResult = ConvertToInt32RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. ConvertToInt32RoundToPositiveInfinity

`Vector64<int> ConvertToInt32RoundToPositiveInfinity(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToPositiveInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinity(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToPositiveInfinity(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtopositiveinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtp_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToPositiveInfinity", "Performs 'ConvertToInt32RoundToPositiveInfinity' operation.", 0), GetValue("ConvertToInt32RoundToPositiveInfinity", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToPositiveInfinity", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToPositiveInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToPositiveInfinityScalarResult = Dummy_ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. ConvertToInt32RoundToPositiveInfinityScalar

`Vector64<int> ConvertToInt32RoundToPositiveInfinityScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtopositiveinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtps_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToPositiveInfinityScalar", "Performs 'ConvertToInt32RoundToPositiveInfinityScalar' operation.", 0), GetValue("ConvertToInt32RoundToPositiveInfinityScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToPositiveInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToZeroResult = Dummy_ConvertToInt32RoundToZeroTest(Vector64float_0);
apiResult = ConvertToInt32RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. ConvertToInt32RoundToZero

`Vector64<int> ConvertToInt32RoundToZero(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToZero(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToZero(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtozero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToZero", "Performs 'ConvertToInt32RoundToZero' operation.", 0), GetValue("ConvertToInt32RoundToZero", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToZero", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToZeroScalarResult = Dummy_ConvertToInt32RoundToZeroScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. ConvertToInt32RoundToZeroScalar

`Vector64<int> ConvertToInt32RoundToZeroScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<int> ConvertToInt32RoundToZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtozeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvts_s32_f32).

Assembly generated:

```armasm", GetValue("ConvertToInt32RoundToZeroScalar", "Performs 'ConvertToInt32RoundToZeroScalar' operation.", 0), GetValue("ConvertToInt32RoundToZeroScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToInt32RoundToZeroScalar", apiResult.ToString(), 2));

try {
ConvertToInt32RoundToZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundAwayFromZeroResult = Dummy_ConvertToInt64RoundAwayFromZeroTest(Vector128double_0);
apiResult = ConvertToInt64RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. ConvertToInt64RoundAwayFromZero

`Vector128<long> ConvertToInt64RoundAwayFromZero(Vector128<double> value)`

{0}

```csharp
private Vector128<long> ConvertToInt64RoundAwayFromZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZero(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundawayfromzero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtaq_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundAwayFromZero", "Performs 'ConvertToInt64RoundAwayFromZero' operation.", 0), GetValue("ConvertToInt64RoundAwayFromZero", Vector128double_0.ToString(), 1), GetValue("ConvertToInt64RoundAwayFromZero", apiResult.ToString(), 2));

try {
ConvertToInt64RoundAwayFromZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundAwayFromZeroScalarResult = Dummy_ConvertToInt64RoundAwayFromZeroScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. ConvertToInt64RoundAwayFromZeroScalar

`Vector64<long> ConvertToInt64RoundAwayFromZeroScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<long> ConvertToInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundawayfromzeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvta_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundAwayFromZeroScalar", "Performs 'ConvertToInt64RoundAwayFromZeroScalar' operation.", 0), GetValue("ConvertToInt64RoundAwayFromZeroScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToInt64RoundAwayFromZeroScalar", apiResult.ToString(), 2));

try {
ConvertToInt64RoundAwayFromZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToEvenResult = Dummy_ConvertToInt64RoundToEvenTest(Vector128double_0);
apiResult = ConvertToInt64RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. ConvertToInt64RoundToEven

`Vector128<long> ConvertToInt64RoundToEven(Vector128<double> value)`

{0}

```csharp
private Vector128<long> ConvertToInt64RoundToEvenTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToEven(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtoeven?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtnq_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToEven", "Performs 'ConvertToInt64RoundToEven' operation.", 0), GetValue("ConvertToInt64RoundToEven", Vector128double_0.ToString(), 1), GetValue("ConvertToInt64RoundToEven", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToEvenTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToEvenScalarResult = Dummy_ConvertToInt64RoundToEvenScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. ConvertToInt64RoundToEvenScalar

`Vector64<long> ConvertToInt64RoundToEvenScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<long> ConvertToInt64RoundToEvenScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToEvenScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtoevenscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtn_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToEvenScalar", "Performs 'ConvertToInt64RoundToEvenScalar' operation.", 0), GetValue("ConvertToInt64RoundToEvenScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToInt64RoundToEvenScalar", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToEvenScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToNegativeInfinityResult = Dummy_ConvertToInt64RoundToNegativeInfinityTest(Vector128double_0);
apiResult = ConvertToInt64RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. ConvertToInt64RoundToNegativeInfinity

`Vector128<long> ConvertToInt64RoundToNegativeInfinity(Vector128<double> value)`

{0}

```csharp
private Vector128<long> ConvertToInt64RoundToNegativeInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinity(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtonegativeinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtmq_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToNegativeInfinity", "Performs 'ConvertToInt64RoundToNegativeInfinity' operation.", 0), GetValue("ConvertToInt64RoundToNegativeInfinity", Vector128double_0.ToString(), 1), GetValue("ConvertToInt64RoundToNegativeInfinity", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToNegativeInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToNegativeInfinityScalarResult = Dummy_ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. ConvertToInt64RoundToNegativeInfinityScalar

`Vector64<long> ConvertToInt64RoundToNegativeInfinityScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<long> ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtonegativeinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtm_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToNegativeInfinityScalar", "Performs 'ConvertToInt64RoundToNegativeInfinityScalar' operation.", 0), GetValue("ConvertToInt64RoundToNegativeInfinityScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToInt64RoundToNegativeInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToPositiveInfinityResult = Dummy_ConvertToInt64RoundToPositiveInfinityTest(Vector128double_0);
apiResult = ConvertToInt64RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. ConvertToInt64RoundToPositiveInfinity

`Vector128<long> ConvertToInt64RoundToPositiveInfinity(Vector128<double> value)`

{0}

```csharp
private Vector128<long> ConvertToInt64RoundToPositiveInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinity(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtopositiveinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtpq_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToPositiveInfinity", "Performs 'ConvertToInt64RoundToPositiveInfinity' operation.", 0), GetValue("ConvertToInt64RoundToPositiveInfinity", Vector128double_0.ToString(), 1), GetValue("ConvertToInt64RoundToPositiveInfinity", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToPositiveInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToPositiveInfinityScalarResult = Dummy_ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. ConvertToInt64RoundToPositiveInfinityScalar

`Vector64<long> ConvertToInt64RoundToPositiveInfinityScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<long> ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtopositiveinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtp_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToPositiveInfinityScalar", "Performs 'ConvertToInt64RoundToPositiveInfinityScalar' operation.", 0), GetValue("ConvertToInt64RoundToPositiveInfinityScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToInt64RoundToPositiveInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToZeroResult = Dummy_ConvertToInt64RoundToZeroTest(Vector128double_0);
apiResult = ConvertToInt64RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. ConvertToInt64RoundToZero

`Vector128<long> ConvertToInt64RoundToZero(Vector128<double> value)`

{0}

```csharp
private Vector128<long> ConvertToInt64RoundToZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToZero(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtozero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtq_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToZero", "Performs 'ConvertToInt64RoundToZero' operation.", 0), GetValue("ConvertToInt64RoundToZero", Vector128double_0.ToString(), 1), GetValue("ConvertToInt64RoundToZero", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToZeroScalarResult = Dummy_ConvertToInt64RoundToZeroScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. ConvertToInt64RoundToZeroScalar

`Vector64<long> ConvertToInt64RoundToZeroScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<long> ConvertToInt64RoundToZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtozeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_s64_f64).

Assembly generated:

```armasm", GetValue("ConvertToInt64RoundToZeroScalar", "Performs 'ConvertToInt64RoundToZeroScalar' operation.", 0), GetValue("ConvertToInt64RoundToZeroScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToInt64RoundToZeroScalar", apiResult.ToString(), 2));

try {
ConvertToInt64RoundToZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToSingleResult = Dummy_ConvertToSingleTest(Vector64int_0);
apiResult = ConvertToSingleResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. ConvertToSingle

`Vector64<float> ConvertToSingle(Vector64<int> value)`

{0}

```csharp
private Vector64<float> ConvertToSingleTest(Vector64<int> value)
{{
  return AdvSimd.ConvertToSingle(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> ConvertToSingle(Vector64<uint> value)
Vector128<float> ConvertToSingle(Vector128<int> value)
Vector128<float> ConvertToSingle(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttosingle?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_f32_s32).

Assembly generated:

```armasm", GetValue("ConvertToSingle", "Performs 'ConvertToSingle' operation.", 0), GetValue("ConvertToSingle", Vector64int_0.ToString(), 1), GetValue("ConvertToSingle", apiResult.ToString(), 2));

try {
ConvertToSingleTest(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToSingleLowerResult = Dummy_ConvertToSingleLowerTest(Vector128double_0);
apiResult = ConvertToSingleLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. ConvertToSingleLower

`Vector64<float> ConvertToSingleLower(Vector128<double> value)`

{0}

```csharp
private Vector64<float> ConvertToSingleLowerTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleLower(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosinglelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_f32_f64).

Assembly generated:

```armasm", GetValue("ConvertToSingleLower", "Performs 'ConvertToSingleLower' operation.", 0), GetValue("ConvertToSingleLower", Vector128double_0.ToString(), 1), GetValue("ConvertToSingleLower", apiResult.ToString(), 2));

try {
ConvertToSingleLowerTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToSingleRoundToOddLowerResult = Dummy_ConvertToSingleRoundToOddLowerTest(Vector128double_0);
apiResult = ConvertToSingleRoundToOddLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. ConvertToSingleRoundToOddLower

`Vector64<float> ConvertToSingleRoundToOddLower(Vector128<double> value)`

{0}

```csharp
private Vector64<float> ConvertToSingleRoundToOddLowerTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddLower(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosingleroundtooddlower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtx_f32_f64).

Assembly generated:

```armasm", GetValue("ConvertToSingleRoundToOddLower", "Performs 'ConvertToSingleRoundToOddLower' operation.", 0), GetValue("ConvertToSingleRoundToOddLower", Vector128double_0.ToString(), 1), GetValue("ConvertToSingleRoundToOddLower", apiResult.ToString(), 2));

try {
ConvertToSingleRoundToOddLowerTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToSingleRoundToOddUpperResult = Dummy_ConvertToSingleRoundToOddUpperTest(Vector64float_0, Vector128double_0);
apiResult = ConvertToSingleRoundToOddUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. ConvertToSingleRoundToOddUpper

`Vector128<float> ConvertToSingleRoundToOddUpper(Vector64<float> lower, Vector128<double> value)`

{0}

```csharp
private Vector128<float> ConvertToSingleRoundToOddUpperTest(Vector64<float> lower, Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddUpper(lower, value);
}}
// lower = {1}
// value = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosingleroundtooddupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtx_high_f32_f64).

Assembly generated:

```armasm", GetValue("ConvertToSingleRoundToOddUpper", "Performs 'ConvertToSingleRoundToOddUpper' operation.", 0), GetValue("ConvertToSingleRoundToOddUpper", Vector64float_0.ToString(), 1), GetValue("ConvertToSingleRoundToOddUpper", Vector128double_0.ToString(), 2), GetValue("ConvertToSingleRoundToOddUpper", apiResult.ToString(), 3));

try {
ConvertToSingleRoundToOddUpperTest(Vector64float_0, Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToSingleScalarResult = Dummy_ConvertToSingleScalarTest(Vector64int_0);
apiResult = ConvertToSingleScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. ConvertToSingleScalar

`Vector64<float> ConvertToSingleScalar(Vector64<int> value)`

{0}

```csharp
private Vector64<float> ConvertToSingleScalarTest(Vector64<int> value)
{{
  return AdvSimd.ConvertToSingleScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> ConvertToSingleScalar(Vector64<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttosinglescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvts_f32_s32).

Assembly generated:

```armasm", GetValue("ConvertToSingleScalar", "Performs 'ConvertToSingleScalar' operation.", 0), GetValue("ConvertToSingleScalar", Vector64int_0.ToString(), 1), GetValue("ConvertToSingleScalar", apiResult.ToString(), 2));

try {
ConvertToSingleScalarTest(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToSingleUpperResult = Dummy_ConvertToSingleUpperTest(Vector64float_0, Vector128double_0);
apiResult = ConvertToSingleUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. ConvertToSingleUpper

`Vector128<float> ConvertToSingleUpper(Vector64<float> lower, Vector128<double> value)`

{0}

```csharp
private Vector128<float> ConvertToSingleUpperTest(Vector64<float> lower, Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleUpper(lower, value);
}}
// lower = {1}
// value = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosingleupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_high_f32_f64).

Assembly generated:

```armasm", GetValue("ConvertToSingleUpper", "Performs 'ConvertToSingleUpper' operation.", 0), GetValue("ConvertToSingleUpper", Vector64float_0.ToString(), 1), GetValue("ConvertToSingleUpper", Vector128double_0.ToString(), 2), GetValue("ConvertToSingleUpper", apiResult.ToString(), 3));

try {
ConvertToSingleUpperTest(Vector64float_0, Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundAwayFromZeroResult = Dummy_ConvertToUInt32RoundAwayFromZeroTest(Vector64float_0);
apiResult = ConvertToUInt32RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. ConvertToUInt32RoundAwayFromZero

`Vector64<uint> ConvertToUInt32RoundAwayFromZero(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundAwayFromZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundAwayFromZero(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundAwayFromZero(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundawayfromzero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvta_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundAwayFromZero", "Performs 'ConvertToUInt32RoundAwayFromZero' operation.", 0), GetValue("ConvertToUInt32RoundAwayFromZero", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundAwayFromZero", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundAwayFromZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundAwayFromZeroScalarResult = Dummy_ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. ConvertToUInt32RoundAwayFromZeroScalar

`Vector64<uint> ConvertToUInt32RoundAwayFromZeroScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundAwayFromZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundawayfromzeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtas_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundAwayFromZeroScalar", "Performs 'ConvertToUInt32RoundAwayFromZeroScalar' operation.", 0), GetValue("ConvertToUInt32RoundAwayFromZeroScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundAwayFromZeroScalar", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToEvenResult = Dummy_ConvertToUInt32RoundToEvenTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. ConvertToUInt32RoundToEven

`Vector64<uint> ConvertToUInt32RoundToEven(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToEvenTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToEven(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToEven(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtoeven?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtn_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToEven", "Performs 'ConvertToUInt32RoundToEven' operation.", 0), GetValue("ConvertToUInt32RoundToEven", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToEven", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToEvenTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToEvenScalarResult = Dummy_ConvertToUInt32RoundToEvenScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. ConvertToUInt32RoundToEvenScalar

`Vector64<uint> ConvertToUInt32RoundToEvenScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToEvenScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToEvenScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtoevenscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtns_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToEvenScalar", "Performs 'ConvertToUInt32RoundToEvenScalar' operation.", 0), GetValue("ConvertToUInt32RoundToEvenScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToEvenScalar", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToEvenScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToNegativeInfinityResult = Dummy_ConvertToUInt32RoundToNegativeInfinityTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. ConvertToUInt32RoundToNegativeInfinity

`Vector64<uint> ConvertToUInt32RoundToNegativeInfinity(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToNegativeInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinity(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToNegativeInfinity(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtonegativeinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtm_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToNegativeInfinity", "Performs 'ConvertToUInt32RoundToNegativeInfinity' operation.", 0), GetValue("ConvertToUInt32RoundToNegativeInfinity", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToNegativeInfinity", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToNegativeInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToNegativeInfinityScalarResult = Dummy_ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. ConvertToUInt32RoundToNegativeInfinityScalar

`Vector64<uint> ConvertToUInt32RoundToNegativeInfinityScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtonegativeinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtms_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToNegativeInfinityScalar", "Performs 'ConvertToUInt32RoundToNegativeInfinityScalar' operation.", 0), GetValue("ConvertToUInt32RoundToNegativeInfinityScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToNegativeInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToPositiveInfinityResult = Dummy_ConvertToUInt32RoundToPositiveInfinityTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. ConvertToUInt32RoundToPositiveInfinity

`Vector64<uint> ConvertToUInt32RoundToPositiveInfinity(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToPositiveInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinity(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToPositiveInfinity(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtopositiveinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtp_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToPositiveInfinity", "Performs 'ConvertToUInt32RoundToPositiveInfinity' operation.", 0), GetValue("ConvertToUInt32RoundToPositiveInfinity", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToPositiveInfinity", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToPositiveInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 3
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 3 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[ConvertToUInt32RoundToPositiveInfinityScalar](#1-converttouint32roundtopositiveinfinityscalar), [ConvertToUInt32RoundToZero](#2-converttouint32roundtozero), [ConvertToUInt32RoundToZeroScalar](#3-converttouint32roundtozeroscalar), [ConvertToUInt64RoundAwayFromZero](#4-converttouint64roundawayfromzero), [ConvertToUInt64RoundAwayFromZeroScalar](#5-converttouint64roundawayfromzeroscalar), [ConvertToUInt64RoundToEven](#6-converttouint64roundtoeven), [ConvertToUInt64RoundToEvenScalar](#7-converttouint64roundtoevenscalar), [ConvertToUInt64RoundToNegativeInfinity](#8-converttouint64roundtonegativeinfinity), [ConvertToUInt64RoundToNegativeInfinityScalar](#9-converttouint64roundtonegativeinfinityscalar), [ConvertToUInt64RoundToPositiveInfinity](#10-converttouint64roundtopositiveinfinity), [ConvertToUInt64RoundToPositiveInfinityScalar](#11-converttouint64roundtopositiveinfinityscalar), [ConvertToUInt64RoundToZero](#12-converttouint64roundtozero), [ConvertToUInt64RoundToZeroScalar](#13-converttouint64roundtozeroscalar), [Divide](#14-divide), [DivideScalar](#15-dividescalar), [DuplicateSelectedScalarToVector128](#16-duplicateselectedscalartovector128), [DuplicateSelectedScalarToVector64](#17-duplicateselectedscalartovector64), [DuplicateToVector128](#18-duplicatetovector128), [DuplicateToVector64](#19-duplicatetovector64), [Extract](#20-extract), [ExtractNarrowingLower](#21-extractnarrowinglower), [ExtractNarrowingSaturateLower](#22-extractnarrowingsaturatelower), [ExtractNarrowingSaturateScalar](#23-extractnarrowingsaturatescalar), [ExtractNarrowingSaturateUnsignedLower](#24-extractnarrowingsaturateunsignedlower), [ExtractNarrowingSaturateUnsignedScalar](#25-extractnarrowingsaturateunsignedscalar), [ExtractNarrowingSaturateUnsignedUpper](#26-extractnarrowingsaturateunsignedupper), [ExtractNarrowingSaturateUpper](#27-extractnarrowingsaturateupper), [ExtractNarrowingUpper](#28-extractnarrowingupper), [ExtractVector128](#29-extractvector128), [ExtractVector64](#30-extractvector64), [Floor](#31-floor), [FloorScalar](#32-floorscalar), [FusedAddHalving](#33-fusedaddhalving), [FusedAddRoundedHalving](#34-fusedaddroundedhalving), [FusedMultiplyAdd](#35-fusedmultiplyadd), [FusedMultiplyAddByScalar](#36-fusedmultiplyaddbyscalar), [FusedMultiplyAddBySelectedScalar](#37-fusedmultiplyaddbyselectedscalar), [FusedMultiplyAddNegatedScalar](#38-fusedmultiplyaddnegatedscalar), [FusedMultiplyAddScalar](#39-fusedmultiplyaddscalar), [FusedMultiplyAddScalarBySelectedScalar](#40-fusedmultiplyaddscalarbyselectedscalar), [FusedMultiplySubtract](#41-fusedmultiplysubtract), [FusedMultiplySubtractByScalar](#42-fusedmultiplysubtractbyscalar), [FusedMultiplySubtractBySelectedScalar](#43-fusedmultiplysubtractbyselectedscalar), [FusedMultiplySubtractNegatedScalar](#44-fusedmultiplysubtractnegatedscalar), [FusedMultiplySubtractScalar](#45-fusedmultiplysubtractscalar)


");

try {
var ConvertToUInt32RoundToPositiveInfinityScalarResult = Dummy_ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. ConvertToUInt32RoundToPositiveInfinityScalar

`Vector64<uint> ConvertToUInt32RoundToPositiveInfinityScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtopositiveinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtps_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToPositiveInfinityScalar", "Performs 'ConvertToUInt32RoundToPositiveInfinityScalar' operation.", 0), GetValue("ConvertToUInt32RoundToPositiveInfinityScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToPositiveInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToZeroResult = Dummy_ConvertToUInt32RoundToZeroTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. ConvertToUInt32RoundToZero

`Vector64<uint> ConvertToUInt32RoundToZero(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToZero(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToZero(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtozero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToZero", "Performs 'ConvertToUInt32RoundToZero' operation.", 0), GetValue("ConvertToUInt32RoundToZero", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToZero", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToZeroScalarResult = Dummy_ConvertToUInt32RoundToZeroScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. ConvertToUInt32RoundToZeroScalar

`Vector64<uint> ConvertToUInt32RoundToZeroScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<uint> ConvertToUInt32RoundToZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtozeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvts_u32_f32).

Assembly generated:

```armasm", GetValue("ConvertToUInt32RoundToZeroScalar", "Performs 'ConvertToUInt32RoundToZeroScalar' operation.", 0), GetValue("ConvertToUInt32RoundToZeroScalar", Vector64float_0.ToString(), 1), GetValue("ConvertToUInt32RoundToZeroScalar", apiResult.ToString(), 2));

try {
ConvertToUInt32RoundToZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundAwayFromZeroResult = Dummy_ConvertToUInt64RoundAwayFromZeroTest(Vector128double_0);
apiResult = ConvertToUInt64RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. ConvertToUInt64RoundAwayFromZero

`Vector128<ulong> ConvertToUInt64RoundAwayFromZero(Vector128<double> value)`

{0}

```csharp
private Vector128<ulong> ConvertToUInt64RoundAwayFromZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZero(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundawayfromzero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtaq_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundAwayFromZero", "Performs 'ConvertToUInt64RoundAwayFromZero' operation.", 0), GetValue("ConvertToUInt64RoundAwayFromZero", Vector128double_0.ToString(), 1), GetValue("ConvertToUInt64RoundAwayFromZero", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundAwayFromZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundAwayFromZeroScalarResult = Dummy_ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. ConvertToUInt64RoundAwayFromZeroScalar

`Vector64<ulong> ConvertToUInt64RoundAwayFromZeroScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<ulong> ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundawayfromzeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvta_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundAwayFromZeroScalar", "Performs 'ConvertToUInt64RoundAwayFromZeroScalar' operation.", 0), GetValue("ConvertToUInt64RoundAwayFromZeroScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToUInt64RoundAwayFromZeroScalar", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToEvenResult = Dummy_ConvertToUInt64RoundToEvenTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. ConvertToUInt64RoundToEven

`Vector128<ulong> ConvertToUInt64RoundToEven(Vector128<double> value)`

{0}

```csharp
private Vector128<ulong> ConvertToUInt64RoundToEvenTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEven(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtoeven?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtnq_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToEven", "Performs 'ConvertToUInt64RoundToEven' operation.", 0), GetValue("ConvertToUInt64RoundToEven", Vector128double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToEven", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToEvenTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToEvenScalarResult = Dummy_ConvertToUInt64RoundToEvenScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. ConvertToUInt64RoundToEvenScalar

`Vector64<ulong> ConvertToUInt64RoundToEvenScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<ulong> ConvertToUInt64RoundToEvenScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEvenScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtoevenscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtn_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToEvenScalar", "Performs 'ConvertToUInt64RoundToEvenScalar' operation.", 0), GetValue("ConvertToUInt64RoundToEvenScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToEvenScalar", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToEvenScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToNegativeInfinityResult = Dummy_ConvertToUInt64RoundToNegativeInfinityTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. ConvertToUInt64RoundToNegativeInfinity

`Vector128<ulong> ConvertToUInt64RoundToNegativeInfinity(Vector128<double> value)`

{0}

```csharp
private Vector128<ulong> ConvertToUInt64RoundToNegativeInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinity(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtonegativeinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtmq_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToNegativeInfinity", "Performs 'ConvertToUInt64RoundToNegativeInfinity' operation.", 0), GetValue("ConvertToUInt64RoundToNegativeInfinity", Vector128double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToNegativeInfinity", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToNegativeInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToNegativeInfinityScalarResult = Dummy_ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. ConvertToUInt64RoundToNegativeInfinityScalar

`Vector64<ulong> ConvertToUInt64RoundToNegativeInfinityScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<ulong> ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtonegativeinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtm_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToNegativeInfinityScalar", "Performs 'ConvertToUInt64RoundToNegativeInfinityScalar' operation.", 0), GetValue("ConvertToUInt64RoundToNegativeInfinityScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToNegativeInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToPositiveInfinityResult = Dummy_ConvertToUInt64RoundToPositiveInfinityTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. ConvertToUInt64RoundToPositiveInfinity

`Vector128<ulong> ConvertToUInt64RoundToPositiveInfinity(Vector128<double> value)`

{0}

```csharp
private Vector128<ulong> ConvertToUInt64RoundToPositiveInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinity(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtopositiveinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtpq_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToPositiveInfinity", "Performs 'ConvertToUInt64RoundToPositiveInfinity' operation.", 0), GetValue("ConvertToUInt64RoundToPositiveInfinity", Vector128double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToPositiveInfinity", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToPositiveInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToPositiveInfinityScalarResult = Dummy_ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. ConvertToUInt64RoundToPositiveInfinityScalar

`Vector64<ulong> ConvertToUInt64RoundToPositiveInfinityScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<ulong> ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtopositiveinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtp_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToPositiveInfinityScalar", "Performs 'ConvertToUInt64RoundToPositiveInfinityScalar' operation.", 0), GetValue("ConvertToUInt64RoundToPositiveInfinityScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToPositiveInfinityScalar", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToZeroResult = Dummy_ConvertToUInt64RoundToZeroTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. ConvertToUInt64RoundToZero

`Vector128<ulong> ConvertToUInt64RoundToZero(Vector128<double> value)`

{0}

```csharp
private Vector128<ulong> ConvertToUInt64RoundToZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZero(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtozero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvtq_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToZero", "Performs 'ConvertToUInt64RoundToZero' operation.", 0), GetValue("ConvertToUInt64RoundToZero", Vector128double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToZero", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToZeroScalarResult = Dummy_ConvertToUInt64RoundToZeroScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. ConvertToUInt64RoundToZeroScalar

`Vector64<ulong> ConvertToUInt64RoundToZeroScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<ulong> ConvertToUInt64RoundToZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZeroScalar(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtozeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcvt_u64_f64).

Assembly generated:

```armasm", GetValue("ConvertToUInt64RoundToZeroScalar", "Performs 'ConvertToUInt64RoundToZeroScalar' operation.", 0), GetValue("ConvertToUInt64RoundToZeroScalar", Vector64double_0.ToString(), 1), GetValue("ConvertToUInt64RoundToZeroScalar", apiResult.ToString(), 2));

try {
ConvertToUInt64RoundToZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var DivideResult = Dummy_DivideTest(Vector64float_0, Vector64float_1);
apiResult = DivideResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. Divide

`Vector64<float> Divide(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> DivideTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.Divide(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Divide(Vector128<double> left, Vector128<double> right)
Vector128<float> Divide(Vector128<float> left, Vector128<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.divide?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vdiv_f32).

Assembly generated:

```armasm", GetValue("Divide", "Performs 'Divide' operation.", 0), GetValue("Divide", Vector64float_0.ToString(), 1), GetValue("Divide", Vector64float_1.ToString(), 2), GetValue("Divide", apiResult.ToString(), 3));

try {
DivideTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var DivideScalarResult = Dummy_DivideScalarTest(Vector64double_0, Vector64double_1);
apiResult = DivideScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. DivideScalar

`Vector64<double> DivideScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> DivideScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.DivideScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> DivideScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.dividescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vdiv_f64).

Assembly generated:

```armasm", GetValue("DivideScalar", "Performs 'DivideScalar' operation.", 0), GetValue("DivideScalar", Vector64double_0.ToString(), 1), GetValue("DivideScalar", Vector64double_1.ToString(), 2), GetValue("DivideScalar", apiResult.ToString(), 3));

try {
DivideScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var DuplicateSelectedScalarToVector128Result = Dummy_DuplicateSelectedScalarToVector128Test(Vector64byte_0, byte_0);
apiResult = DuplicateSelectedScalarToVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. DuplicateSelectedScalarToVector128

`Vector128<byte> DuplicateSelectedScalarToVector128(Vector64<byte> value, byte index)`

{0}

```csharp
private Vector128<byte> DuplicateSelectedScalarToVector128Test(Vector64<byte> value, byte index)
{{
  return AdvSimd.DuplicateSelectedScalarToVector128(value, 3);
}}
// value = {1}
// index = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> DuplicateSelectedScalarToVector128(Vector64<short> value, byte index)
Vector128<int> DuplicateSelectedScalarToVector128(Vector64<int> value, byte index)
Vector128<float> DuplicateSelectedScalarToVector128(Vector64<float> value, byte index)
Vector128<sbyte> DuplicateSelectedScalarToVector128(Vector64<sbyte> value, byte index)
Vector128<ushort> DuplicateSelectedScalarToVector128(Vector64<ushort> value, byte index)
Vector128<uint> DuplicateSelectedScalarToVector128(Vector64<uint> value, byte index)
Vector128<byte> DuplicateSelectedScalarToVector128(Vector128<byte> value, byte index)
Vector128<short> DuplicateSelectedScalarToVector128(Vector128<short> value, byte index)
Vector128<int> DuplicateSelectedScalarToVector128(Vector128<int> value, byte index)
Vector128<float> DuplicateSelectedScalarToVector128(Vector128<float> value, byte index)
Vector128<sbyte> DuplicateSelectedScalarToVector128(Vector128<sbyte> value, byte index)
Vector128<ushort> DuplicateSelectedScalarToVector128(Vector128<ushort> value, byte index)
Vector128<uint> DuplicateSelectedScalarToVector128(Vector128<uint> value, byte index)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> DuplicateSelectedScalarToVector128(Vector128<double> value, byte index)
Vector128<long> DuplicateSelectedScalarToVector128(Vector128<long> value, byte index)
Vector128<ulong> DuplicateSelectedScalarToVector128(Vector128<ulong> value, byte index)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicateselectedscalartovector128?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.duplicateselectedscalartovector128?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vdupq_lane_u8).

Assembly generated:

```armasm", GetValue("DuplicateSelectedScalarToVector128", "Performs 'DuplicateSelectedScalarToVector128' operation.", 0), GetValue("DuplicateSelectedScalarToVector128", Vector64byte_0.ToString(), 1), GetValue("DuplicateSelectedScalarToVector128", byte_0.ToString(), 2), GetValue("DuplicateSelectedScalarToVector128", apiResult.ToString(), 3));

try {
DuplicateSelectedScalarToVector128Test(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var DuplicateSelectedScalarToVector64Result = Dummy_DuplicateSelectedScalarToVector64Test(Vector64byte_0, byte_0);
apiResult = DuplicateSelectedScalarToVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. DuplicateSelectedScalarToVector64

`Vector64<byte> DuplicateSelectedScalarToVector64(Vector64<byte> value, byte index)`

{0}

```csharp
private Vector64<byte> DuplicateSelectedScalarToVector64Test(Vector64<byte> value, byte index)
{{
  return AdvSimd.DuplicateSelectedScalarToVector64(value, 3);
}}
// value = {1}
// index = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> DuplicateSelectedScalarToVector64(Vector64<short> value, byte index)
Vector64<int> DuplicateSelectedScalarToVector64(Vector64<int> value, byte index)
Vector64<float> DuplicateSelectedScalarToVector64(Vector64<float> value, byte index)
Vector64<sbyte> DuplicateSelectedScalarToVector64(Vector64<sbyte> value, byte index)
Vector64<ushort> DuplicateSelectedScalarToVector64(Vector64<ushort> value, byte index)
Vector64<uint> DuplicateSelectedScalarToVector64(Vector64<uint> value, byte index)
Vector64<byte> DuplicateSelectedScalarToVector64(Vector128<byte> value, byte index)
Vector64<short> DuplicateSelectedScalarToVector64(Vector128<short> value, byte index)
Vector64<int> DuplicateSelectedScalarToVector64(Vector128<int> value, byte index)
Vector64<float> DuplicateSelectedScalarToVector64(Vector128<float> value, byte index)
Vector64<sbyte> DuplicateSelectedScalarToVector64(Vector128<sbyte> value, byte index)
Vector64<ushort> DuplicateSelectedScalarToVector64(Vector128<ushort> value, byte index)
Vector64<uint> DuplicateSelectedScalarToVector64(Vector128<uint> value, byte index)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicateselectedscalartovector64?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vdup_lane_u8).

Assembly generated:

```armasm", GetValue("DuplicateSelectedScalarToVector64", "Performs 'DuplicateSelectedScalarToVector64' operation.", 0), GetValue("DuplicateSelectedScalarToVector64", Vector64byte_0.ToString(), 1), GetValue("DuplicateSelectedScalarToVector64", byte_0.ToString(), 2), GetValue("DuplicateSelectedScalarToVector64", apiResult.ToString(), 3));

try {
DuplicateSelectedScalarToVector64Test(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var DuplicateToVector128Result = Dummy_DuplicateToVector128Test(byte_0);
apiResult = DuplicateToVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. DuplicateToVector128

`Vector128<byte> DuplicateToVector128(byte value)`

{0}

```csharp
private Vector128<byte> DuplicateToVector128Test(byte value)
{{
  return AdvSimd.DuplicateToVector128(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> DuplicateToVector128(short value)
Vector128<int> DuplicateToVector128(int value)
Vector128<sbyte> DuplicateToVector128(sbyte value)
Vector128<float> DuplicateToVector128(float value)
Vector128<ushort> DuplicateToVector128(ushort value)
Vector128<uint> DuplicateToVector128(uint value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> DuplicateToVector128(double value)
Vector128<long> DuplicateToVector128(long value)
Vector128<ulong> DuplicateToVector128(ulong value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicatetovector128?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.duplicatetovector128?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vdupq_n_u8).

Assembly generated:

```armasm", GetValue("DuplicateToVector128", "Performs 'DuplicateToVector128' operation.", 0), GetValue("DuplicateToVector128", byte_0.ToString(), 1), GetValue("DuplicateToVector128", apiResult.ToString(), 2));

try {
DuplicateToVector128Test(byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var DuplicateToVector64Result = Dummy_DuplicateToVector64Test(byte_0);
apiResult = DuplicateToVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. DuplicateToVector64

`Vector64<byte> DuplicateToVector64(byte value)`

{0}

```csharp
private Vector64<byte> DuplicateToVector64Test(byte value)
{{
  return AdvSimd.DuplicateToVector64(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> DuplicateToVector64(short value)
Vector64<int> DuplicateToVector64(int value)
Vector64<sbyte> DuplicateToVector64(sbyte value)
Vector64<float> DuplicateToVector64(float value)
Vector64<ushort> DuplicateToVector64(ushort value)
Vector64<uint> DuplicateToVector64(uint value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicatetovector64?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vdup_n_u8).

Assembly generated:

```armasm", GetValue("DuplicateToVector64", "Performs 'DuplicateToVector64' operation.", 0), GetValue("DuplicateToVector64", byte_0.ToString(), 1), GetValue("DuplicateToVector64", apiResult.ToString(), 2));

try {
DuplicateToVector64Test(byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractResult = Dummy_ExtractTest(Vector64byte_0, byte_0);
apiResult = ExtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. Extract

`byte Extract(Vector64<byte> vector, byte index)`

{0}

```csharp
private byte ExtractTest(Vector64<byte> vector, byte index)
{{
  return AdvSimd.Extract(vector, 3);
}}
// vector = {1}
// index = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
short Extract(Vector64<short> vector, byte index)
int Extract(Vector64<int> vector, byte index)
sbyte Extract(Vector64<sbyte> vector, byte index)
float Extract(Vector64<float> vector, byte index)
ushort Extract(Vector64<ushort> vector, byte index)
uint Extract(Vector64<uint> vector, byte index)
byte Extract(Vector128<byte> vector, byte index)
double Extract(Vector128<double> vector, byte index)
short Extract(Vector128<short> vector, byte index)
int Extract(Vector128<int> vector, byte index)
long Extract(Vector128<long> vector, byte index)
sbyte Extract(Vector128<sbyte> vector, byte index)
float Extract(Vector128<float> vector, byte index)
ushort Extract(Vector128<ushort> vector, byte index)
uint Extract(Vector128<uint> vector, byte index)
ulong Extract(Vector128<ulong> vector, byte index)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vget_lane_u8).

Assembly generated:

```armasm", GetValue("Extract", "Performs 'Extract' operation.", 0), GetValue("Extract", Vector64byte_0.ToString(), 1), GetValue("Extract", byte_0.ToString(), 2), GetValue("Extract", apiResult.ToString(), 3));

try {
ExtractTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingLowerResult = Dummy_ExtractNarrowingLowerTest(Vector128ushort_0);
apiResult = ExtractNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. ExtractNarrowingLower

`Vector64<byte> ExtractNarrowingLower(Vector128<ushort> value)`

{0}

```csharp
private Vector64<byte> ExtractNarrowingLowerTest(Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingLower(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ExtractNarrowingLower(Vector128<int> value)
Vector64<int> ExtractNarrowingLower(Vector128<long> value)
Vector64<sbyte> ExtractNarrowingLower(Vector128<short> value)
Vector64<ushort> ExtractNarrowingLower(Vector128<uint> value)
Vector64<uint> ExtractNarrowingLower(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmovn_u16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingLower", "Performs 'ExtractNarrowingLower' operation.", 0), GetValue("ExtractNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("ExtractNarrowingLower", apiResult.ToString(), 2));

try {
ExtractNarrowingLowerTest(Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateLowerResult = Dummy_ExtractNarrowingSaturateLowerTest(Vector128ushort_0);
apiResult = ExtractNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. ExtractNarrowingSaturateLower

`Vector64<byte> ExtractNarrowingSaturateLower(Vector128<ushort> value)`

{0}

```csharp
private Vector64<byte> ExtractNarrowingSaturateLowerTest(Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingSaturateLower(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ExtractNarrowingSaturateLower(Vector128<int> value)
Vector64<int> ExtractNarrowingSaturateLower(Vector128<long> value)
Vector64<sbyte> ExtractNarrowingSaturateLower(Vector128<short> value)
Vector64<ushort> ExtractNarrowingSaturateLower(Vector128<uint> value)
Vector64<uint> ExtractNarrowingSaturateLower(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturatelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqmovn_u16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingSaturateLower", "Performs 'ExtractNarrowingSaturateLower' operation.", 0), GetValue("ExtractNarrowingSaturateLower", Vector128ushort_0.ToString(), 1), GetValue("ExtractNarrowingSaturateLower", apiResult.ToString(), 2));

try {
ExtractNarrowingSaturateLowerTest(Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateScalarResult = Dummy_ExtractNarrowingSaturateScalarTest(Vector64ushort_0);
apiResult = ExtractNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. ExtractNarrowingSaturateScalar

`Vector64<byte> ExtractNarrowingSaturateScalar(Vector64<ushort> value)`

{0}

```csharp
private Vector64<byte> ExtractNarrowingSaturateScalarTest(Vector64<ushort> value)
{{
  return AdvSimd.Arm64.ExtractNarrowingSaturateScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ExtractNarrowingSaturateScalar(Vector64<int> value)
Vector64<int> ExtractNarrowingSaturateScalar(Vector64<long> value)
Vector64<sbyte> ExtractNarrowingSaturateScalar(Vector64<short> value)
Vector64<ushort> ExtractNarrowingSaturateScalar(Vector64<uint> value)
Vector64<uint> ExtractNarrowingSaturateScalar(Vector64<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.extractnarrowingsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqmovnh_u16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingSaturateScalar", "Performs 'ExtractNarrowingSaturateScalar' operation.", 0), GetValue("ExtractNarrowingSaturateScalar", Vector64ushort_0.ToString(), 1), GetValue("ExtractNarrowingSaturateScalar", apiResult.ToString(), 2));

try {
ExtractNarrowingSaturateScalarTest(Vector64ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUnsignedLowerResult = Dummy_ExtractNarrowingSaturateUnsignedLowerTest(Vector128short_0);
apiResult = ExtractNarrowingSaturateUnsignedLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. ExtractNarrowingSaturateUnsignedLower

`Vector64<byte> ExtractNarrowingSaturateUnsignedLower(Vector128<short> value)`

{0}

```csharp
private Vector64<byte> ExtractNarrowingSaturateUnsignedLowerTest(Vector128<short> value)
{{
  return AdvSimd.ExtractNarrowingSaturateUnsignedLower(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> ExtractNarrowingSaturateUnsignedLower(Vector128<int> value)
Vector64<uint> ExtractNarrowingSaturateUnsignedLower(Vector128<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturateunsignedlower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqmovun_s16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingSaturateUnsignedLower", "Performs 'ExtractNarrowingSaturateUnsignedLower' operation.", 0), GetValue("ExtractNarrowingSaturateUnsignedLower", Vector128short_0.ToString(), 1), GetValue("ExtractNarrowingSaturateUnsignedLower", apiResult.ToString(), 2));

try {
ExtractNarrowingSaturateUnsignedLowerTest(Vector128short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUnsignedScalarResult = Dummy_ExtractNarrowingSaturateUnsignedScalarTest(Vector64short_0);
apiResult = ExtractNarrowingSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. ExtractNarrowingSaturateUnsignedScalar

`Vector64<byte> ExtractNarrowingSaturateUnsignedScalar(Vector64<short> value)`

{0}

```csharp
private Vector64<byte> ExtractNarrowingSaturateUnsignedScalarTest(Vector64<short> value)
{{
  return AdvSimd.Arm64.ExtractNarrowingSaturateUnsignedScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ExtractNarrowingSaturateUnsignedScalar(Vector64<int> value)
Vector64<uint> ExtractNarrowingSaturateUnsignedScalar(Vector64<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.extractnarrowingsaturateunsignedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqmovunh_s16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingSaturateUnsignedScalar", "Performs 'ExtractNarrowingSaturateUnsignedScalar' operation.", 0), GetValue("ExtractNarrowingSaturateUnsignedScalar", Vector64short_0.ToString(), 1), GetValue("ExtractNarrowingSaturateUnsignedScalar", apiResult.ToString(), 2));

try {
ExtractNarrowingSaturateUnsignedScalarTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUnsignedUpperResult = Dummy_ExtractNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0);
apiResult = ExtractNarrowingSaturateUnsignedUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. ExtractNarrowingSaturateUnsignedUpper

`Vector128<byte> ExtractNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value)`

{0}

```csharp
private Vector128<byte> ExtractNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value)
{{
  return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(lower, value);
}}
// lower = {1}
// value = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<ushort> ExtractNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value)
Vector128<uint> ExtractNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturateunsignedupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqmovun_high_s16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingSaturateUnsignedUpper", "Performs 'ExtractNarrowingSaturateUnsignedUpper' operation.", 0), GetValue("ExtractNarrowingSaturateUnsignedUpper", Vector64byte_0.ToString(), 1), GetValue("ExtractNarrowingSaturateUnsignedUpper", Vector128short_0.ToString(), 2), GetValue("ExtractNarrowingSaturateUnsignedUpper", apiResult.ToString(), 3));

try {
ExtractNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUpperResult = Dummy_ExtractNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0);
apiResult = ExtractNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. ExtractNarrowingSaturateUpper

`Vector128<byte> ExtractNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value)`

{0}

```csharp
private Vector128<byte> ExtractNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingSaturateUpper(lower, value);
}}
// lower = {1}
// value = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> ExtractNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value)
Vector128<int> ExtractNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value)
Vector128<sbyte> ExtractNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value)
Vector128<ushort> ExtractNarrowingSaturateUpper(Vector64<ushort> lower, Vector128<uint> value)
Vector128<uint> ExtractNarrowingSaturateUpper(Vector64<uint> lower, Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturateupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqmovn_high_u16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingSaturateUpper", "Performs 'ExtractNarrowingSaturateUpper' operation.", 0), GetValue("ExtractNarrowingSaturateUpper", Vector64byte_0.ToString(), 1), GetValue("ExtractNarrowingSaturateUpper", Vector128ushort_0.ToString(), 2), GetValue("ExtractNarrowingSaturateUpper", apiResult.ToString(), 3));

try {
ExtractNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractNarrowingUpperResult = Dummy_ExtractNarrowingUpperTest(Vector64byte_0, Vector128ushort_0);
apiResult = ExtractNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. ExtractNarrowingUpper

`Vector128<byte> ExtractNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value)`

{0}

```csharp
private Vector128<byte> ExtractNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingUpper(lower, value);
}}
// lower = {1}
// value = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> ExtractNarrowingUpper(Vector64<short> lower, Vector128<int> value)
Vector128<int> ExtractNarrowingUpper(Vector64<int> lower, Vector128<long> value)
Vector128<sbyte> ExtractNarrowingUpper(Vector64<sbyte> lower, Vector128<short> value)
Vector128<ushort> ExtractNarrowingUpper(Vector64<ushort> lower, Vector128<uint> value)
Vector128<uint> ExtractNarrowingUpper(Vector64<uint> lower, Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmovn_high_u16).

Assembly generated:

```armasm", GetValue("ExtractNarrowingUpper", "Performs 'ExtractNarrowingUpper' operation.", 0), GetValue("ExtractNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("ExtractNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("ExtractNarrowingUpper", apiResult.ToString(), 3));

try {
ExtractNarrowingUpperTest(Vector64byte_0, Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractVector128Result = Dummy_ExtractVector128Test(Vector128byte_0, Vector128byte_1, byte_0);
apiResult = ExtractVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. ExtractVector128

`Vector128<byte> ExtractVector128(Vector128<byte> upper, Vector128<byte> lower, byte index)`

{0}

```csharp
private Vector128<byte> ExtractVector128Test(Vector128<byte> upper, Vector128<byte> lower, byte index)
{{
  return AdvSimd.ExtractVector128(upper, lower, 5);
}}
// upper = {1}
// lower = {2}
// index = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<double> ExtractVector128(Vector128<double> upper, Vector128<double> lower, byte index)
Vector128<short> ExtractVector128(Vector128<short> upper, Vector128<short> lower, byte index)
Vector128<int> ExtractVector128(Vector128<int> upper, Vector128<int> lower, byte index)
Vector128<long> ExtractVector128(Vector128<long> upper, Vector128<long> lower, byte index)
Vector128<sbyte> ExtractVector128(Vector128<sbyte> upper, Vector128<sbyte> lower, byte index)
Vector128<float> ExtractVector128(Vector128<float> upper, Vector128<float> lower, byte index)
Vector128<ushort> ExtractVector128(Vector128<ushort> upper, Vector128<ushort> lower, byte index)
Vector128<uint> ExtractVector128(Vector128<uint> upper, Vector128<uint> lower, byte index)
Vector128<ulong> ExtractVector128(Vector128<ulong> upper, Vector128<ulong> lower, byte index)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractvector128?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vextq_s8).

Assembly generated:

```armasm", GetValue("ExtractVector128", "Performs 'ExtractVector128' operation.", 0), GetValue("ExtractVector128", Vector128byte_0.ToString(), 1), GetValue("ExtractVector128", Vector128byte_1.ToString(), 2), GetValue("ExtractVector128", byte_0.ToString(), 3), GetValue("ExtractVector128", apiResult.ToString(), 4));

try {
ExtractVector128Test(Vector128byte_0, Vector128byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ExtractVector64Result = Dummy_ExtractVector64Test(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ExtractVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. ExtractVector64

`Vector64<byte> ExtractVector64(Vector64<byte> upper, Vector64<byte> lower, byte index)`

{0}

```csharp
private Vector64<byte> ExtractVector64Test(Vector64<byte> upper, Vector64<byte> lower, byte index)
{{
  return AdvSimd.ExtractVector64(upper, lower, 5);
}}
// upper = {1}
// lower = {2}
// index = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ExtractVector64(Vector64<short> upper, Vector64<short> lower, byte index)
Vector64<int> ExtractVector64(Vector64<int> upper, Vector64<int> lower, byte index)
Vector64<sbyte> ExtractVector64(Vector64<sbyte> upper, Vector64<sbyte> lower, byte index)
Vector64<float> ExtractVector64(Vector64<float> upper, Vector64<float> lower, byte index)
Vector64<ushort> ExtractVector64(Vector64<ushort> upper, Vector64<ushort> lower, byte index)
Vector64<uint> ExtractVector64(Vector64<uint> upper, Vector64<uint> lower, byte index)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractvector64?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vext_s8).

Assembly generated:

```armasm", GetValue("ExtractVector64", "Performs 'ExtractVector64' operation.", 0), GetValue("ExtractVector64", Vector64byte_0.ToString(), 1), GetValue("ExtractVector64", Vector64byte_1.ToString(), 2), GetValue("ExtractVector64", byte_0.ToString(), 3), GetValue("ExtractVector64", apiResult.ToString(), 4));

try {
ExtractVector64Test(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FloorResult = Dummy_FloorTest(Vector64float_0);
apiResult = FloorResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. Floor

`Vector64<float> Floor(Vector64<float> value)`

{0}

```csharp
private Vector64<float> FloorTest(Vector64<float> value)
{{
  return AdvSimd.Floor(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> Floor(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Floor(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.floor?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.floor?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndm_f32).

Assembly generated:

```armasm", GetValue("Floor", "Performs 'Floor' operation.", 0), GetValue("Floor", Vector64float_0.ToString(), 1), GetValue("Floor", apiResult.ToString(), 2));

try {
FloorTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FloorScalarResult = Dummy_FloorScalarTest(Vector64double_0);
apiResult = FloorScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. FloorScalar

`Vector64<double> FloorScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> FloorScalarTest(Vector64<double> value)
{{
  return AdvSimd.FloorScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FloorScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.floorscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndm_f64).

Assembly generated:

```armasm", GetValue("FloorScalar", "Performs 'FloorScalar' operation.", 0), GetValue("FloorScalar", Vector64double_0.ToString(), 1), GetValue("FloorScalar", apiResult.ToString(), 2));

try {
FloorScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedAddHalvingResult = Dummy_FusedAddHalvingTest(Vector64byte_0, Vector64byte_1);
apiResult = FusedAddHalvingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. FusedAddHalving

`Vector64<byte> FusedAddHalving(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> FusedAddHalvingTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.FusedAddHalving(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> FusedAddHalving(Vector64<short> left, Vector64<short> right)
Vector64<int> FusedAddHalving(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> FusedAddHalving(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> FusedAddHalving(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> FusedAddHalving(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> FusedAddHalving(Vector128<byte> left, Vector128<byte> right)
Vector128<short> FusedAddHalving(Vector128<short> left, Vector128<short> right)
Vector128<int> FusedAddHalving(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> FusedAddHalving(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> FusedAddHalving(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> FusedAddHalving(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedaddhalving?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vhadd_u8).

Assembly generated:

```armasm", GetValue("FusedAddHalving", "Performs 'FusedAddHalving' operation.", 0), GetValue("FusedAddHalving", Vector64byte_0.ToString(), 1), GetValue("FusedAddHalving", Vector64byte_1.ToString(), 2), GetValue("FusedAddHalving", apiResult.ToString(), 3));

try {
FusedAddHalvingTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedAddRoundedHalvingResult = Dummy_FusedAddRoundedHalvingTest(Vector64byte_0, Vector64byte_1);
apiResult = FusedAddRoundedHalvingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. FusedAddRoundedHalving

`Vector64<byte> FusedAddRoundedHalving(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> FusedAddRoundedHalvingTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.FusedAddRoundedHalving(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> FusedAddRoundedHalving(Vector64<short> left, Vector64<short> right)
Vector64<int> FusedAddRoundedHalving(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> FusedAddRoundedHalving(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> FusedAddRoundedHalving(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> FusedAddRoundedHalving(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> FusedAddRoundedHalving(Vector128<byte> left, Vector128<byte> right)
Vector128<short> FusedAddRoundedHalving(Vector128<short> left, Vector128<short> right)
Vector128<int> FusedAddRoundedHalving(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> FusedAddRoundedHalving(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> FusedAddRoundedHalving(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> FusedAddRoundedHalving(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedaddroundedhalving?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrhadd_u8).

Assembly generated:

```armasm", GetValue("FusedAddRoundedHalving", "Performs 'FusedAddRoundedHalving' operation.", 0), GetValue("FusedAddRoundedHalving", Vector64byte_0.ToString(), 1), GetValue("FusedAddRoundedHalving", Vector64byte_1.ToString(), 2), GetValue("FusedAddRoundedHalving", apiResult.ToString(), 3));

try {
FusedAddRoundedHalvingTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplyAddResult = Dummy_FusedMultiplyAddTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplyAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. FusedMultiplyAdd

`Vector64<float> FusedMultiplyAdd(Vector64<float> addend, Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> FusedMultiplyAddTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.FusedMultiplyAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> FusedMultiplyAdd(Vector128<float> addend, Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplyAdd(Vector128<double> addend, Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplyadd?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfma_f32).

Assembly generated:

```armasm", GetValue("FusedMultiplyAdd", "Performs 'FusedMultiplyAdd' operation.", 0), GetValue("FusedMultiplyAdd", Vector64float_0.ToString(), 1), GetValue("FusedMultiplyAdd", Vector64float_1.ToString(), 2), GetValue("FusedMultiplyAdd", Vector64float_2.ToString(), 3), GetValue("FusedMultiplyAdd", apiResult.ToString(), 4));

try {
FusedMultiplyAddTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplyAddByScalarResult = Dummy_FusedMultiplyAddByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplyAddByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. FusedMultiplyAddByScalar

`Vector64<float> FusedMultiplyAddByScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> FusedMultiplyAddByScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.FusedMultiplyAddByScalar(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplyAddByScalar(Vector128<double> addend, Vector128<double> left, Vector64<double> right)
Vector128<float> FusedMultiplyAddByScalar(Vector128<float> addend, Vector128<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyaddbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfma_n_f32).

Assembly generated:

```armasm", GetValue("FusedMultiplyAddByScalar", "Performs 'FusedMultiplyAddByScalar' operation.", 0), GetValue("FusedMultiplyAddByScalar", Vector64float_0.ToString(), 1), GetValue("FusedMultiplyAddByScalar", Vector64float_1.ToString(), 2), GetValue("FusedMultiplyAddByScalar", Vector64float_2.ToString(), 3), GetValue("FusedMultiplyAddByScalar", apiResult.ToString(), 4));

try {
FusedMultiplyAddByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplyAddBySelectedScalarResult = Dummy_FusedMultiplyAddBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);
apiResult = FusedMultiplyAddBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. FusedMultiplyAddBySelectedScalar

`Vector64<float> FusedMultiplyAddBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)`

{0}

```csharp
private Vector64<float> FusedMultiplyAddBySelectedScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(addend, left, right, 0);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplyAddBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector128<double> FusedMultiplyAddBySelectedScalar(Vector128<double> addend, Vector128<double> left, Vector128<double> right, byte rightIndex)
Vector128<float> FusedMultiplyAddBySelectedScalar(Vector128<float> addend, Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> FusedMultiplyAddBySelectedScalar(Vector128<float> addend, Vector128<float> left, Vector128<float> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyaddbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfma_lane_f32).

Assembly generated:

```armasm", GetValue("FusedMultiplyAddBySelectedScalar", "Performs 'FusedMultiplyAddBySelectedScalar' operation.", 0), GetValue("FusedMultiplyAddBySelectedScalar", Vector64float_0.ToString(), 1), GetValue("FusedMultiplyAddBySelectedScalar", Vector64float_1.ToString(), 2), GetValue("FusedMultiplyAddBySelectedScalar", Vector64float_2.ToString(), 3), GetValue("FusedMultiplyAddBySelectedScalar", byte_0.ToString(), 4), GetValue("FusedMultiplyAddBySelectedScalar", apiResult.ToString(), 5));

try {
FusedMultiplyAddBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplyAddNegatedScalarResult = Dummy_FusedMultiplyAddNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplyAddNegatedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. FusedMultiplyAddNegatedScalar

`Vector64<double> FusedMultiplyAddNegatedScalar(Vector64<double> addend, Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> FusedMultiplyAddNegatedScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplyAddNegatedScalar(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplyAddNegatedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplyaddnegatedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfnma_f64).

Assembly generated:

```armasm", GetValue("FusedMultiplyAddNegatedScalar", "Performs 'FusedMultiplyAddNegatedScalar' operation.", 0), GetValue("FusedMultiplyAddNegatedScalar", Vector64double_0.ToString(), 1), GetValue("FusedMultiplyAddNegatedScalar", Vector64double_1.ToString(), 2), GetValue("FusedMultiplyAddNegatedScalar", Vector64double_2.ToString(), 3), GetValue("FusedMultiplyAddNegatedScalar", apiResult.ToString(), 4));

try {
FusedMultiplyAddNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplyAddScalarResult = Dummy_FusedMultiplyAddScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplyAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. FusedMultiplyAddScalar

`Vector64<double> FusedMultiplyAddScalar(Vector64<double> addend, Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> FusedMultiplyAddScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplyAddScalar(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplyAddScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplyaddscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfma_f64).

Assembly generated:

```armasm", GetValue("FusedMultiplyAddScalar", "Performs 'FusedMultiplyAddScalar' operation.", 0), GetValue("FusedMultiplyAddScalar", Vector64double_0.ToString(), 1), GetValue("FusedMultiplyAddScalar", Vector64double_1.ToString(), 2), GetValue("FusedMultiplyAddScalar", Vector64double_2.ToString(), 3), GetValue("FusedMultiplyAddScalar", apiResult.ToString(), 4));

try {
FusedMultiplyAddScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplyAddScalarBySelectedScalarResult = Dummy_FusedMultiplyAddScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);
apiResult = FusedMultiplyAddScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. FusedMultiplyAddScalarBySelectedScalar

`Vector64<double> FusedMultiplyAddScalarBySelectedScalar(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)`

{0}

```csharp
private Vector64<double> FusedMultiplyAddScalarBySelectedScalarTest(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplyAddScalarBySelectedScalar(addend, left, right, 0);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplyAddScalarBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> FusedMultiplyAddScalarBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector128<float> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyaddscalarbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfmad_laneq_f64).

Assembly generated:

```armasm", GetValue("FusedMultiplyAddScalarBySelectedScalar", "Performs 'FusedMultiplyAddScalarBySelectedScalar' operation.", 0), GetValue("FusedMultiplyAddScalarBySelectedScalar", Vector64double_0.ToString(), 1), GetValue("FusedMultiplyAddScalarBySelectedScalar", Vector64double_1.ToString(), 2), GetValue("FusedMultiplyAddScalarBySelectedScalar", Vector128double_0.ToString(), 3), GetValue("FusedMultiplyAddScalarBySelectedScalar", byte_0.ToString(), 4), GetValue("FusedMultiplyAddScalarBySelectedScalar", apiResult.ToString(), 5));

try {
FusedMultiplyAddScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplySubtractResult = Dummy_FusedMultiplySubtractTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplySubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. FusedMultiplySubtract

`Vector64<float> FusedMultiplySubtract(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> FusedMultiplySubtractTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.FusedMultiplySubtract(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> FusedMultiplySubtract(Vector128<float> minuend, Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplySubtract(Vector128<double> minuend, Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplysubtract?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfms_f32).

Assembly generated:

```armasm", GetValue("FusedMultiplySubtract", "Performs 'FusedMultiplySubtract' operation.", 0), GetValue("FusedMultiplySubtract", Vector64float_0.ToString(), 1), GetValue("FusedMultiplySubtract", Vector64float_1.ToString(), 2), GetValue("FusedMultiplySubtract", Vector64float_2.ToString(), 3), GetValue("FusedMultiplySubtract", apiResult.ToString(), 4));

try {
FusedMultiplySubtractTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplySubtractByScalarResult = Dummy_FusedMultiplySubtractByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplySubtractByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. FusedMultiplySubtractByScalar

`Vector64<float> FusedMultiplySubtractByScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> FusedMultiplySubtractByScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.FusedMultiplySubtractByScalar(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplySubtractByScalar(Vector128<double> minuend, Vector128<double> left, Vector64<double> right)
Vector128<float> FusedMultiplySubtractByScalar(Vector128<float> minuend, Vector128<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtractbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfms_n_f32).

Assembly generated:

```armasm", GetValue("FusedMultiplySubtractByScalar", "Performs 'FusedMultiplySubtractByScalar' operation.", 0), GetValue("FusedMultiplySubtractByScalar", Vector64float_0.ToString(), 1), GetValue("FusedMultiplySubtractByScalar", Vector64float_1.ToString(), 2), GetValue("FusedMultiplySubtractByScalar", Vector64float_2.ToString(), 3), GetValue("FusedMultiplySubtractByScalar", apiResult.ToString(), 4));

try {
FusedMultiplySubtractByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplySubtractBySelectedScalarResult = Dummy_FusedMultiplySubtractBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);
apiResult = FusedMultiplySubtractBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. FusedMultiplySubtractBySelectedScalar

`Vector64<float> FusedMultiplySubtractBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)`

{0}

```csharp
private Vector64<float> FusedMultiplySubtractBySelectedScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplySubtractBySelectedScalar(minuend, left, right, 0);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplySubtractBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector128<double> FusedMultiplySubtractBySelectedScalar(Vector128<double> minuend, Vector128<double> left, Vector128<double> right, byte rightIndex)
Vector128<float> FusedMultiplySubtractBySelectedScalar(Vector128<float> minuend, Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> FusedMultiplySubtractBySelectedScalar(Vector128<float> minuend, Vector128<float> left, Vector128<float> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtractbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfms_lane_f32).

Assembly generated:

```armasm", GetValue("FusedMultiplySubtractBySelectedScalar", "Performs 'FusedMultiplySubtractBySelectedScalar' operation.", 0), GetValue("FusedMultiplySubtractBySelectedScalar", Vector64float_0.ToString(), 1), GetValue("FusedMultiplySubtractBySelectedScalar", Vector64float_1.ToString(), 2), GetValue("FusedMultiplySubtractBySelectedScalar", Vector64float_2.ToString(), 3), GetValue("FusedMultiplySubtractBySelectedScalar", byte_0.ToString(), 4), GetValue("FusedMultiplySubtractBySelectedScalar", apiResult.ToString(), 5));

try {
FusedMultiplySubtractBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplySubtractNegatedScalarResult = Dummy_FusedMultiplySubtractNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplySubtractNegatedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. FusedMultiplySubtractNegatedScalar

`Vector64<double> FusedMultiplySubtractNegatedScalar(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> FusedMultiplySubtractNegatedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplySubtractNegatedScalar(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplySubtractNegatedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplysubtractnegatedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfnms_f64).

Assembly generated:

```armasm", GetValue("FusedMultiplySubtractNegatedScalar", "Performs 'FusedMultiplySubtractNegatedScalar' operation.", 0), GetValue("FusedMultiplySubtractNegatedScalar", Vector64double_0.ToString(), 1), GetValue("FusedMultiplySubtractNegatedScalar", Vector64double_1.ToString(), 2), GetValue("FusedMultiplySubtractNegatedScalar", Vector64double_2.ToString(), 3), GetValue("FusedMultiplySubtractNegatedScalar", apiResult.ToString(), 4));

try {
FusedMultiplySubtractNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedMultiplySubtractScalarResult = Dummy_FusedMultiplySubtractScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplySubtractScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. FusedMultiplySubtractScalar

`Vector64<double> FusedMultiplySubtractScalar(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> FusedMultiplySubtractScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplySubtractScalar(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplySubtractScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplysubtractscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfms_f64).

Assembly generated:

```armasm", GetValue("FusedMultiplySubtractScalar", "Performs 'FusedMultiplySubtractScalar' operation.", 0), GetValue("FusedMultiplySubtractScalar", Vector64double_0.ToString(), 1), GetValue("FusedMultiplySubtractScalar", Vector64double_1.ToString(), 2), GetValue("FusedMultiplySubtractScalar", Vector64double_2.ToString(), 3), GetValue("FusedMultiplySubtractScalar", apiResult.ToString(), 4));

try {
FusedMultiplySubtractScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 4
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 4 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[FusedMultiplySubtractScalarBySelectedScalar](#1-fusedmultiplysubtractscalarbyselectedscalar), [FusedSubtractHalving](#2-fusedsubtracthalving), [Insert](#3-insert), [InsertScalar](#4-insertscalar), [InsertSelectedScalar](#5-insertselectedscalar), [LeadingSignCount](#6-leadingsigncount), [LeadingZeroCount](#7-leadingzerocount), [LoadAndInsertScalar](#8-loadandinsertscalar), [LoadAndReplicateToVector128](#9-loadandreplicatetovector128), [LoadAndReplicateToVector64](#10-loadandreplicatetovector64), [LoadVector128](#11-loadvector128), [LoadVector64](#12-loadvector64), [Max](#13-max), [MaxAcross](#14-maxacross), [MaxNumber](#15-maxnumber), [MaxNumberAcross](#16-maxnumberacross), [MaxNumberPairwise](#17-maxnumberpairwise), [MaxNumberPairwiseScalar](#18-maxnumberpairwisescalar), [MaxNumberScalar](#19-maxnumberscalar), [MaxPairwise](#20-maxpairwise), [MaxPairwiseScalar](#21-maxpairwisescalar), [MaxScalar](#22-maxscalar), [Min](#23-min), [MinAcross](#24-minacross), [MinNumber](#25-minnumber), [MinNumberAcross](#26-minnumberacross), [MinNumberPairwise](#27-minnumberpairwise), [MinNumberPairwiseScalar](#28-minnumberpairwisescalar), [MinNumberScalar](#29-minnumberscalar), [MinPairwise](#30-minpairwise), [MinPairwiseScalar](#31-minpairwisescalar), [MinScalar](#32-minscalar), [Multiply](#33-multiply), [MultiplyAdd](#34-multiplyadd), [MultiplyAddByScalar](#35-multiplyaddbyscalar), [MultiplyAddBySelectedScalar](#36-multiplyaddbyselectedscalar), [MultiplyByScalar](#37-multiplybyscalar), [MultiplyBySelectedScalar](#38-multiplybyselectedscalar), [MultiplyBySelectedScalarWideningLower](#39-multiplybyselectedscalarwideninglower), [MultiplyBySelectedScalarWideningLowerAndAdd](#40-multiplybyselectedscalarwideninglowerandadd), [MultiplyBySelectedScalarWideningLowerAndSubtract](#41-multiplybyselectedscalarwideninglowerandsubtract), [MultiplyBySelectedScalarWideningUpper](#42-multiplybyselectedscalarwideningupper), [MultiplyBySelectedScalarWideningUpperAndAdd](#43-multiplybyselectedscalarwideningupperandadd), [MultiplyBySelectedScalarWideningUpperAndSubtract](#44-multiplybyselectedscalarwideningupperandsubtract), [MultiplyDoublingByScalarSaturateHigh](#45-multiplydoublingbyscalarsaturatehigh)


");

try {
var FusedMultiplySubtractScalarBySelectedScalarResult = Dummy_FusedMultiplySubtractScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);
apiResult = FusedMultiplySubtractScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. FusedMultiplySubtractScalarBySelectedScalar

`Vector64<double> FusedMultiplySubtractScalarBySelectedScalar(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)`

{0}

```csharp
private Vector64<double> FusedMultiplySubtractScalarBySelectedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplySubtractScalarBySelectedScalar(minuend, left, right, 0);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplySubtractScalarBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> FusedMultiplySubtractScalarBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector128<float> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtractscalarbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vfmsd_laneq_f64).

Assembly generated:

```armasm", GetValue("FusedMultiplySubtractScalarBySelectedScalar", "Performs 'FusedMultiplySubtractScalarBySelectedScalar' operation.", 0), GetValue("FusedMultiplySubtractScalarBySelectedScalar", Vector64double_0.ToString(), 1), GetValue("FusedMultiplySubtractScalarBySelectedScalar", Vector64double_1.ToString(), 2), GetValue("FusedMultiplySubtractScalarBySelectedScalar", Vector128double_0.ToString(), 3), GetValue("FusedMultiplySubtractScalarBySelectedScalar", byte_0.ToString(), 4), GetValue("FusedMultiplySubtractScalarBySelectedScalar", apiResult.ToString(), 5));

try {
FusedMultiplySubtractScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var FusedSubtractHalvingResult = Dummy_FusedSubtractHalvingTest(Vector64byte_0, Vector64byte_1);
apiResult = FusedSubtractHalvingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. FusedSubtractHalving

`Vector64<byte> FusedSubtractHalving(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> FusedSubtractHalvingTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.FusedSubtractHalving(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> FusedSubtractHalving(Vector64<short> left, Vector64<short> right)
Vector64<int> FusedSubtractHalving(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> FusedSubtractHalving(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> FusedSubtractHalving(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> FusedSubtractHalving(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> FusedSubtractHalving(Vector128<byte> left, Vector128<byte> right)
Vector128<short> FusedSubtractHalving(Vector128<short> left, Vector128<short> right)
Vector128<int> FusedSubtractHalving(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> FusedSubtractHalving(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> FusedSubtractHalving(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> FusedSubtractHalving(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedsubtracthalving?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vhsub_u8).

Assembly generated:

```armasm", GetValue("FusedSubtractHalving", "Performs 'FusedSubtractHalving' operation.", 0), GetValue("FusedSubtractHalving", Vector64byte_0.ToString(), 1), GetValue("FusedSubtractHalving", Vector64byte_1.ToString(), 2), GetValue("FusedSubtractHalving", apiResult.ToString(), 3));

try {
FusedSubtractHalvingTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var InsertResult = Dummy_InsertTest(Vector64byte_0, byte_0, byte_1);
apiResult = InsertResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. Insert

`Vector64<byte> Insert(Vector64<byte> vector, byte index, byte data)`

{0}

```csharp
private Vector64<byte> InsertTest(Vector64<byte> vector, byte index, byte data)
{{
  return AdvSimd.Insert(vector, 4, 200);
}}
// vector = {1}
// index = {2}
// data = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> Insert(Vector64<short> vector, byte index, short data)
Vector64<int> Insert(Vector64<int> vector, byte index, int data)
Vector64<sbyte> Insert(Vector64<sbyte> vector, byte index, sbyte data)
Vector64<float> Insert(Vector64<float> vector, byte index, float data)
Vector64<ushort> Insert(Vector64<ushort> vector, byte index, ushort data)
Vector64<uint> Insert(Vector64<uint> vector, byte index, uint data)
Vector128<byte> Insert(Vector128<byte> vector, byte index, byte data)
Vector128<double> Insert(Vector128<double> vector, byte index, double data)
Vector128<short> Insert(Vector128<short> vector, byte index, short data)
Vector128<int> Insert(Vector128<int> vector, byte index, int data)
Vector128<long> Insert(Vector128<long> vector, byte index, long data)
Vector128<sbyte> Insert(Vector128<sbyte> vector, byte index, sbyte data)
Vector128<float> Insert(Vector128<float> vector, byte index, float data)
Vector128<ushort> Insert(Vector128<ushort> vector, byte index, ushort data)
Vector128<uint> Insert(Vector128<uint> vector, byte index, uint data)
Vector128<ulong> Insert(Vector128<ulong> vector, byte index, ulong data)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.insert?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vset_lane_u8).

Assembly generated:

```armasm", GetValue("Insert", "Performs 'Insert' operation.", 0), GetValue("Insert", Vector64byte_0.ToString(), 1), GetValue("Insert", byte_0.ToString(), 2), GetValue("Insert", byte_1.ToString(), 3), GetValue("Insert", apiResult.ToString(), 4));

try {
InsertTest(Vector64byte_0, byte_0, byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var InsertScalarResult = Dummy_InsertScalarTest(Vector128double_0, byte_0, Vector64double_0);
apiResult = InsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. InsertScalar

`Vector128<double> InsertScalar(Vector128<double> result, byte resultIndex, Vector64<double> value)`

{0}

```csharp
private Vector128<double> InsertScalarTest(Vector128<double> result, byte resultIndex, Vector64<double> value)
{{
  return AdvSimd.InsertScalar(result, 1, value);
}}
// result = {1}
// resultIndex = {2}
// value = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> InsertScalar(Vector128<long> result, byte resultIndex, Vector64<long> value)
Vector128<ulong> InsertScalar(Vector128<ulong> result, byte resultIndex, Vector64<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.insertscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcopyq_lane_f64).

Assembly generated:

```armasm", GetValue("InsertScalar", "Performs 'InsertScalar' operation.", 0), GetValue("InsertScalar", Vector128double_0.ToString(), 1), GetValue("InsertScalar", byte_0.ToString(), 2), GetValue("InsertScalar", Vector64double_0.ToString(), 3), GetValue("InsertScalar", apiResult.ToString(), 4));

try {
InsertScalarTest(Vector128double_0, byte_0, Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var InsertSelectedScalarResult = Dummy_InsertSelectedScalarTest(Vector64byte_0, byte_0, Vector64byte_1, byte_1);
apiResult = InsertSelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. InsertSelectedScalar

`Vector64<byte> InsertSelectedScalar(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)`

{0}

```csharp
private Vector64<byte> InsertSelectedScalarTest(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
{{
  return AdvSimd.Arm64.InsertSelectedScalar(result, 0, value, 1);
}}
// result = {1}
// resultIndex = {2}
// value = {3}
// valueIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> InsertSelectedScalar(Vector64<byte> result, byte resultIndex, Vector128<byte> value, byte valueIndex)
Vector64<short> InsertSelectedScalar(Vector64<short> result, byte resultIndex, Vector64<short> value, byte valueIndex)
Vector64<short> InsertSelectedScalar(Vector64<short> result, byte resultIndex, Vector128<short> value, byte valueIndex)
Vector64<int> InsertSelectedScalar(Vector64<int> result, byte resultIndex, Vector64<int> value, byte valueIndex)
Vector64<int> InsertSelectedScalar(Vector64<int> result, byte resultIndex, Vector128<int> value, byte valueIndex)
Vector64<sbyte> InsertSelectedScalar(Vector64<sbyte> result, byte resultIndex, Vector64<sbyte> value, byte valueIndex)
Vector64<sbyte> InsertSelectedScalar(Vector64<sbyte> result, byte resultIndex, Vector128<sbyte> value, byte valueIndex)
Vector64<float> InsertSelectedScalar(Vector64<float> result, byte resultIndex, Vector64<float> value, byte valueIndex)
Vector64<float> InsertSelectedScalar(Vector64<float> result, byte resultIndex, Vector128<float> value, byte valueIndex)
Vector64<ushort> InsertSelectedScalar(Vector64<ushort> result, byte resultIndex, Vector64<ushort> value, byte valueIndex)
Vector64<ushort> InsertSelectedScalar(Vector64<ushort> result, byte resultIndex, Vector128<ushort> value, byte valueIndex)
Vector64<uint> InsertSelectedScalar(Vector64<uint> result, byte resultIndex, Vector64<uint> value, byte valueIndex)
Vector64<uint> InsertSelectedScalar(Vector64<uint> result, byte resultIndex, Vector128<uint> value, byte valueIndex)
Vector128<byte> InsertSelectedScalar(Vector128<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
Vector128<byte> InsertSelectedScalar(Vector128<byte> result, byte resultIndex, Vector128<byte> value, byte valueIndex)
Vector128<double> InsertSelectedScalar(Vector128<double> result, byte resultIndex, Vector128<double> value, byte valueIndex)
Vector128<short> InsertSelectedScalar(Vector128<short> result, byte resultIndex, Vector64<short> value, byte valueIndex)
Vector128<short> InsertSelectedScalar(Vector128<short> result, byte resultIndex, Vector128<short> value, byte valueIndex)
Vector128<int> InsertSelectedScalar(Vector128<int> result, byte resultIndex, Vector64<int> value, byte valueIndex)
Vector128<int> InsertSelectedScalar(Vector128<int> result, byte resultIndex, Vector128<int> value, byte valueIndex)
Vector128<long> InsertSelectedScalar(Vector128<long> result, byte resultIndex, Vector128<long> value, byte valueIndex)
Vector128<sbyte> InsertSelectedScalar(Vector128<sbyte> result, byte resultIndex, Vector64<sbyte> value, byte valueIndex)
Vector128<sbyte> InsertSelectedScalar(Vector128<sbyte> result, byte resultIndex, Vector128<sbyte> value, byte valueIndex)
Vector128<float> InsertSelectedScalar(Vector128<float> result, byte resultIndex, Vector64<float> value, byte valueIndex)
Vector128<float> InsertSelectedScalar(Vector128<float> result, byte resultIndex, Vector128<float> value, byte valueIndex)
Vector128<ushort> InsertSelectedScalar(Vector128<ushort> result, byte resultIndex, Vector64<ushort> value, byte valueIndex)
Vector128<ushort> InsertSelectedScalar(Vector128<ushort> result, byte resultIndex, Vector128<ushort> value, byte valueIndex)
Vector128<uint> InsertSelectedScalar(Vector128<uint> result, byte resultIndex, Vector64<uint> value, byte valueIndex)
Vector128<uint> InsertSelectedScalar(Vector128<uint> result, byte resultIndex, Vector128<uint> value, byte valueIndex)
Vector128<ulong> InsertSelectedScalar(Vector128<ulong> result, byte resultIndex, Vector128<ulong> value, byte valueIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.insertselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcopy_lane_u8).

Assembly generated:

```armasm", GetValue("InsertSelectedScalar", "Performs 'InsertSelectedScalar' operation.", 0), GetValue("InsertSelectedScalar", Vector64byte_0.ToString(), 1), GetValue("InsertSelectedScalar", byte_0.ToString(), 2), GetValue("InsertSelectedScalar", Vector64byte_1.ToString(), 3), GetValue("InsertSelectedScalar", byte_1.ToString(), 4), GetValue("InsertSelectedScalar", apiResult.ToString(), 5));

try {
InsertSelectedScalarTest(Vector64byte_0, byte_0, Vector64byte_1, byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var LeadingSignCountResult = Dummy_LeadingSignCountTest(Vector64short_0);
apiResult = LeadingSignCountResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. LeadingSignCount

`Vector64<short> LeadingSignCount(Vector64<short> value)`

{0}

```csharp
private Vector64<short> LeadingSignCountTest(Vector64<short> value)
{{
  return AdvSimd.LeadingSignCount(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> LeadingSignCount(Vector64<int> value)
Vector64<sbyte> LeadingSignCount(Vector64<sbyte> value)
Vector128<short> LeadingSignCount(Vector128<short> value)
Vector128<int> LeadingSignCount(Vector128<int> value)
Vector128<sbyte> LeadingSignCount(Vector128<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.leadingsigncount?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcls_s16).

Assembly generated:

```armasm", GetValue("LeadingSignCount", "Performs 'LeadingSignCount' operation.", 0), GetValue("LeadingSignCount", Vector64short_0.ToString(), 1), GetValue("LeadingSignCount", apiResult.ToString(), 2));

try {
LeadingSignCountTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var LeadingZeroCountResult = Dummy_LeadingZeroCountTest(Vector64byte_0);
apiResult = LeadingZeroCountResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. LeadingZeroCount

`Vector64<byte> LeadingZeroCount(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> LeadingZeroCountTest(Vector64<byte> value)
{{
  return AdvSimd.LeadingZeroCount(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> LeadingZeroCount(Vector64<short> value)
Vector64<int> LeadingZeroCount(Vector64<int> value)
Vector64<sbyte> LeadingZeroCount(Vector64<sbyte> value)
Vector64<ushort> LeadingZeroCount(Vector64<ushort> value)
Vector64<uint> LeadingZeroCount(Vector64<uint> value)
Vector128<byte> LeadingZeroCount(Vector128<byte> value)
Vector128<short> LeadingZeroCount(Vector128<short> value)
Vector128<int> LeadingZeroCount(Vector128<int> value)
Vector128<sbyte> LeadingZeroCount(Vector128<sbyte> value)
Vector128<ushort> LeadingZeroCount(Vector128<ushort> value)
Vector128<uint> LeadingZeroCount(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.leadingzerocount?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vclz_u8).

Assembly generated:

```armasm", GetValue("LeadingZeroCount", "Performs 'LeadingZeroCount' operation.", 0), GetValue("LeadingZeroCount", Vector64byte_0.ToString(), 1), GetValue("LeadingZeroCount", apiResult.ToString(), 2));

try {
LeadingZeroCountTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
var LoadAndInsertScalarResult = Dummy_LoadAndInsertScalarTest(Vector64byte_0, byte_0, bytePtr_0);
apiResult = LoadAndInsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. LoadAndInsertScalar

`Vector64<byte> LoadAndInsertScalar(Vector64<byte> value, byte index, byte* address)`

{0}

```csharp
private Vector64<byte> LoadAndInsertScalarTest(Vector64<byte> value, byte index, byte* address)
{{
  return AdvSimd.LoadAndInsertScalar(value, 2, address);
}}
// value = {1}
// index = {2}
// address = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> LoadAndInsertScalar(Vector64<short> value, byte index, short* address)
Vector64<int> LoadAndInsertScalar(Vector64<int> value, byte index, int* address)
Vector64<sbyte> LoadAndInsertScalar(Vector64<sbyte> value, byte index, sbyte* address)
Vector64<float> LoadAndInsertScalar(Vector64<float> value, byte index, float* address)
Vector64<ushort> LoadAndInsertScalar(Vector64<ushort> value, byte index, ushort* address)
Vector64<uint> LoadAndInsertScalar(Vector64<uint> value, byte index, uint* address)
Vector128<byte> LoadAndInsertScalar(Vector128<byte> value, byte index, byte* address)
Vector128<double> LoadAndInsertScalar(Vector128<double> value, byte index, double* address)
Vector128<short> LoadAndInsertScalar(Vector128<short> value, byte index, short* address)
Vector128<int> LoadAndInsertScalar(Vector128<int> value, byte index, int* address)
Vector128<long> LoadAndInsertScalar(Vector128<long> value, byte index, long* address)
Vector128<sbyte> LoadAndInsertScalar(Vector128<sbyte> value, byte index, sbyte* address)
Vector128<float> LoadAndInsertScalar(Vector128<float> value, byte index, float* address)
Vector128<ushort> LoadAndInsertScalar(Vector128<ushort> value, byte index, ushort* address)
Vector128<uint> LoadAndInsertScalar(Vector128<uint> value, byte index, uint* address)
Vector128<ulong> LoadAndInsertScalar(Vector128<ulong> value, byte index, ulong* address)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadandinsertscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vld1_lane_u8).

Assembly generated:

```armasm", GetValue("LoadAndInsertScalar", "Performs 'LoadAndInsertScalar' operation.", 0), GetValue("LoadAndInsertScalar", Vector64byte_0.ToString(), 1), GetValue("LoadAndInsertScalar", byte_0.ToString(), 2), GetValue("LoadAndInsertScalar", "<address>".ToString(), 3), GetValue("LoadAndInsertScalar", apiResult.ToString(), 4));

try {
LoadAndInsertScalarTest(Vector64byte_0, byte_0, bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
var LoadAndReplicateToVector128Result = Dummy_LoadAndReplicateToVector128Test(bytePtr_0);
apiResult = LoadAndReplicateToVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. LoadAndReplicateToVector128

`Vector128<byte> LoadAndReplicateToVector128(byte* address)`

{0}

```csharp
private Vector128<byte> LoadAndReplicateToVector128Test(byte* address)
{{
  return AdvSimd.LoadAndReplicateToVector128(address);
}}
// address = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> LoadAndReplicateToVector128(short* address)
Vector128<int> LoadAndReplicateToVector128(int* address)
Vector128<sbyte> LoadAndReplicateToVector128(sbyte* address)
Vector128<float> LoadAndReplicateToVector128(float* address)
Vector128<ushort> LoadAndReplicateToVector128(ushort* address)
Vector128<uint> LoadAndReplicateToVector128(uint* address)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> LoadAndReplicateToVector128(double* address)
Vector128<long> LoadAndReplicateToVector128(long* address)
Vector128<ulong> LoadAndReplicateToVector128(ulong* address)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadandreplicatetovector128?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.loadandreplicatetovector128?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vld1q_dup_u8).

Assembly generated:

```armasm", GetValue("LoadAndReplicateToVector128", "Performs 'LoadAndReplicateToVector128' operation.", 0), GetValue("LoadAndReplicateToVector128", "<address>".ToString(), 1), GetValue("LoadAndReplicateToVector128", apiResult.ToString(), 2));

try {
LoadAndReplicateToVector128Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
var LoadAndReplicateToVector64Result = Dummy_LoadAndReplicateToVector64Test(bytePtr_0);
apiResult = LoadAndReplicateToVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. LoadAndReplicateToVector64

`Vector64<byte> LoadAndReplicateToVector64(byte* address)`

{0}

```csharp
private Vector64<byte> LoadAndReplicateToVector64Test(byte* address)
{{
  return AdvSimd.LoadAndReplicateToVector64(address);
}}
// address = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> LoadAndReplicateToVector64(short* address)
Vector64<int> LoadAndReplicateToVector64(int* address)
Vector64<sbyte> LoadAndReplicateToVector64(sbyte* address)
Vector64<float> LoadAndReplicateToVector64(float* address)
Vector64<ushort> LoadAndReplicateToVector64(ushort* address)
Vector64<uint> LoadAndReplicateToVector64(uint* address)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadandreplicatetovector64?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vld1_dup_u8).

Assembly generated:

```armasm", GetValue("LoadAndReplicateToVector64", "Performs 'LoadAndReplicateToVector64' operation.", 0), GetValue("LoadAndReplicateToVector64", "<address>".ToString(), 1), GetValue("LoadAndReplicateToVector64", apiResult.ToString(), 2));

try {
LoadAndReplicateToVector64Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
var LoadVector128Result = Dummy_LoadVector128Test(bytePtr_0);
apiResult = LoadVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. LoadVector128

`Vector128<byte> LoadVector128(byte* address)`

{0}

```csharp
private Vector128<byte> LoadVector128Test(byte* address)
{{
  return AdvSimd.LoadVector128(address);
}}
// address = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<double> LoadVector128(double* address)
Vector128<short> LoadVector128(short* address)
Vector128<int> LoadVector128(int* address)
Vector128<long> LoadVector128(long* address)
Vector128<sbyte> LoadVector128(sbyte* address)
Vector128<float> LoadVector128(float* address)
Vector128<ushort> LoadVector128(ushort* address)
Vector128<uint> LoadVector128(uint* address)
Vector128<ulong> LoadVector128(ulong* address)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadvector128?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vld1q_u8).

Assembly generated:

```armasm", GetValue("LoadVector128", "Performs 'LoadVector128' operation.", 0), GetValue("LoadVector128", "<address>".ToString(), 1), GetValue("LoadVector128", apiResult.ToString(), 2));

try {
LoadVector128Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
var LoadVector64Result = Dummy_LoadVector64Test(bytePtr_0);
apiResult = LoadVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. LoadVector64

`Vector64<byte> LoadVector64(byte* address)`

{0}

```csharp
private Vector64<byte> LoadVector64Test(byte* address)
{{
  return AdvSimd.LoadVector64(address);
}}
// address = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> LoadVector64(double* address)
Vector64<short> LoadVector64(short* address)
Vector64<int> LoadVector64(int* address)
Vector64<long> LoadVector64(long* address)
Vector64<sbyte> LoadVector64(sbyte* address)
Vector64<float> LoadVector64(float* address)
Vector64<ushort> LoadVector64(ushort* address)
Vector64<uint> LoadVector64(uint* address)
Vector64<ulong> LoadVector64(ulong* address)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadvector64?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vld1_u8).

Assembly generated:

```armasm", GetValue("LoadVector64", "Performs 'LoadVector64' operation.", 0), GetValue("LoadVector64", "<address>".ToString(), 1), GetValue("LoadVector64", apiResult.ToString(), 2));

try {
LoadVector64Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------

try {
var MaxResult = Dummy_MaxTest(Vector64byte_0, Vector64byte_1);
apiResult = MaxResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. Max

`Vector64<byte> Max(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MaxTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Max(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> Max(Vector64<short> left, Vector64<short> right)
Vector64<int> Max(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> Max(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Max(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Max(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Max(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right)
Vector128<short> Max(Vector128<short> left, Vector128<short> right)
Vector128<int> Max(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Max(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Max(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.max?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.max?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmax_u8).

Assembly generated:

```armasm", GetValue("Max", "Performs 'Max' operation.", 0), GetValue("Max", Vector64byte_0.ToString(), 1), GetValue("Max", Vector64byte_1.ToString(), 2), GetValue("Max", apiResult.ToString(), 3));

try {
MaxTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxAcrossResult = Dummy_MaxAcrossTest(Vector64byte_0);
apiResult = MaxAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. MaxAcross

`Vector64<byte> MaxAcross(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> MaxAcrossTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.MaxAcross(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> MaxAcross(Vector64<short> value)
Vector64<sbyte> MaxAcross(Vector64<sbyte> value)
Vector64<ushort> MaxAcross(Vector64<ushort> value)
Vector64<byte> MaxAcross(Vector128<byte> value)
Vector64<short> MaxAcross(Vector128<short> value)
Vector64<int> MaxAcross(Vector128<int> value)
Vector64<sbyte> MaxAcross(Vector128<sbyte> value)
Vector64<float> MaxAcross(Vector128<float> value)
Vector64<ushort> MaxAcross(Vector128<ushort> value)
Vector64<uint> MaxAcross(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxacross?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmaxv_u8).

Assembly generated:

```armasm", GetValue("MaxAcross", "Performs 'MaxAcross' operation.", 0), GetValue("MaxAcross", Vector64byte_0.ToString(), 1), GetValue("MaxAcross", apiResult.ToString(), 2));

try {
MaxAcrossTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxNumberResult = Dummy_MaxNumberTest(Vector64float_0, Vector64float_1);
apiResult = MaxNumberResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. MaxNumber

`Vector64<float> MaxNumber(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> MaxNumberTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.MaxNumber(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> MaxNumber(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MaxNumber(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.maxnumber?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumber?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmaxnm_f32).

Assembly generated:

```armasm", GetValue("MaxNumber", "Performs 'MaxNumber' operation.", 0), GetValue("MaxNumber", Vector64float_0.ToString(), 1), GetValue("MaxNumber", Vector64float_1.ToString(), 2), GetValue("MaxNumber", apiResult.ToString(), 3));

try {
MaxNumberTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxNumberAcrossResult = Dummy_MaxNumberAcrossTest(Vector128float_0);
apiResult = MaxNumberAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. MaxNumberAcross

`Vector64<float> MaxNumberAcross(Vector128<float> value)`

{0}

```csharp
private Vector64<float> MaxNumberAcrossTest(Vector128<float> value)
{{
  return AdvSimd.Arm64.MaxNumberAcross(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumberacross?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmaxnmvq_f32).

Assembly generated:

```armasm", GetValue("MaxNumberAcross", "Performs 'MaxNumberAcross' operation.", 0), GetValue("MaxNumberAcross", Vector128float_0.ToString(), 1), GetValue("MaxNumberAcross", apiResult.ToString(), 2));

try {
MaxNumberAcrossTest(Vector128float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxNumberPairwiseResult = Dummy_MaxNumberPairwiseTest(Vector64float_0, Vector64float_1);
apiResult = MaxNumberPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. MaxNumberPairwise

`Vector64<float> MaxNumberPairwise(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> MaxNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.MaxNumberPairwise(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MaxNumberPairwise(Vector128<double> left, Vector128<double> right)
Vector128<float> MaxNumberPairwise(Vector128<float> left, Vector128<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumberpairwise?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpmaxnm_f32).

Assembly generated:

```armasm", GetValue("MaxNumberPairwise", "Performs 'MaxNumberPairwise' operation.", 0), GetValue("MaxNumberPairwise", Vector64float_0.ToString(), 1), GetValue("MaxNumberPairwise", Vector64float_1.ToString(), 2), GetValue("MaxNumberPairwise", apiResult.ToString(), 3));

try {
MaxNumberPairwiseTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxNumberPairwiseScalarResult = Dummy_MaxNumberPairwiseScalarTest(Vector64float_0);
apiResult = MaxNumberPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. MaxNumberPairwiseScalar

`Vector64<float> MaxNumberPairwiseScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<float> MaxNumberPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MaxNumberPairwiseScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MaxNumberPairwiseScalar(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumberpairwisescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpmaxnms_f32).

Assembly generated:

```armasm", GetValue("MaxNumberPairwiseScalar", "Performs 'MaxNumberPairwiseScalar' operation.", 0), GetValue("MaxNumberPairwiseScalar", Vector64float_0.ToString(), 1), GetValue("MaxNumberPairwiseScalar", apiResult.ToString(), 2));

try {
MaxNumberPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxNumberScalarResult = Dummy_MaxNumberScalarTest(Vector64double_0, Vector64double_1);
apiResult = MaxNumberScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. MaxNumberScalar

`Vector64<double> MaxNumberScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> MaxNumberScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.MaxNumberScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MaxNumberScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.maxnumberscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmaxnm_f64).

Assembly generated:

```armasm", GetValue("MaxNumberScalar", "Performs 'MaxNumberScalar' operation.", 0), GetValue("MaxNumberScalar", Vector64double_0.ToString(), 1), GetValue("MaxNumberScalar", Vector64double_1.ToString(), 2), GetValue("MaxNumberScalar", apiResult.ToString(), 3));

try {
MaxNumberScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxPairwiseResult = Dummy_MaxPairwiseTest(Vector64byte_0, Vector64byte_1);
apiResult = MaxPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. MaxPairwise

`Vector64<byte> MaxPairwise(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MaxPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MaxPairwise(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MaxPairwise(Vector64<short> left, Vector64<short> right)
Vector64<int> MaxPairwise(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> MaxPairwise(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> MaxPairwise(Vector64<float> left, Vector64<float> right)
Vector64<ushort> MaxPairwise(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MaxPairwise(Vector64<uint> left, Vector64<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> MaxPairwise(Vector128<byte> left, Vector128<byte> right)
Vector128<double> MaxPairwise(Vector128<double> left, Vector128<double> right)
Vector128<short> MaxPairwise(Vector128<short> left, Vector128<short> right)
Vector128<int> MaxPairwise(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> MaxPairwise(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> MaxPairwise(Vector128<float> left, Vector128<float> right)
Vector128<ushort> MaxPairwise(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> MaxPairwise(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.maxpairwise?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxpairwise?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpmax_u8).

Assembly generated:

```armasm", GetValue("MaxPairwise", "Performs 'MaxPairwise' operation.", 0), GetValue("MaxPairwise", Vector64byte_0.ToString(), 1), GetValue("MaxPairwise", Vector64byte_1.ToString(), 2), GetValue("MaxPairwise", apiResult.ToString(), 3));

try {
MaxPairwiseTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxPairwiseScalarResult = Dummy_MaxPairwiseScalarTest(Vector64float_0);
apiResult = MaxPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. MaxPairwiseScalar

`Vector64<float> MaxPairwiseScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<float> MaxPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MaxPairwiseScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MaxPairwiseScalar(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxpairwisescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpmaxs_f32).

Assembly generated:

```armasm", GetValue("MaxPairwiseScalar", "Performs 'MaxPairwiseScalar' operation.", 0), GetValue("MaxPairwiseScalar", Vector64float_0.ToString(), 1), GetValue("MaxPairwiseScalar", apiResult.ToString(), 2));

try {
MaxPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MaxScalarResult = Dummy_MaxScalarTest(Vector64double_0, Vector64double_1);
apiResult = MaxScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. MaxScalar

`Vector64<double> MaxScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> MaxScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MaxScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MaxScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmax_f64).

Assembly generated:

```armasm", GetValue("MaxScalar", "Performs 'MaxScalar' operation.", 0), GetValue("MaxScalar", Vector64double_0.ToString(), 1), GetValue("MaxScalar", Vector64double_1.ToString(), 2), GetValue("MaxScalar", apiResult.ToString(), 3));

try {
MaxScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinResult = Dummy_MinTest(Vector64byte_0, Vector64byte_1);
apiResult = MinResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. Min

`Vector64<byte> Min(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MinTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Min(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> Min(Vector64<short> left, Vector64<short> right)
Vector64<int> Min(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> Min(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Min(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Min(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Min(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right)
Vector128<short> Min(Vector128<short> left, Vector128<short> right)
Vector128<int> Min(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Min(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Min(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.min?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.min?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmin_u8).

Assembly generated:

```armasm", GetValue("Min", "Performs 'Min' operation.", 0), GetValue("Min", Vector64byte_0.ToString(), 1), GetValue("Min", Vector64byte_1.ToString(), 2), GetValue("Min", apiResult.ToString(), 3));

try {
MinTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinAcrossResult = Dummy_MinAcrossTest(Vector64byte_0);
apiResult = MinAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. MinAcross

`Vector64<byte> MinAcross(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> MinAcrossTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.MinAcross(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> MinAcross(Vector64<short> value)
Vector64<sbyte> MinAcross(Vector64<sbyte> value)
Vector64<ushort> MinAcross(Vector64<ushort> value)
Vector64<byte> MinAcross(Vector128<byte> value)
Vector64<short> MinAcross(Vector128<short> value)
Vector64<int> MinAcross(Vector128<int> value)
Vector64<sbyte> MinAcross(Vector128<sbyte> value)
Vector64<float> MinAcross(Vector128<float> value)
Vector64<ushort> MinAcross(Vector128<ushort> value)
Vector64<uint> MinAcross(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minacross?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vminv_u8).

Assembly generated:

```armasm", GetValue("MinAcross", "Performs 'MinAcross' operation.", 0), GetValue("MinAcross", Vector64byte_0.ToString(), 1), GetValue("MinAcross", apiResult.ToString(), 2));

try {
MinAcrossTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinNumberResult = Dummy_MinNumberTest(Vector64float_0, Vector64float_1);
apiResult = MinNumberResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. MinNumber

`Vector64<float> MinNumber(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> MinNumberTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.MinNumber(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> MinNumber(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MinNumber(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.minnumber?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumber?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vminnm_f32).

Assembly generated:

```armasm", GetValue("MinNumber", "Performs 'MinNumber' operation.", 0), GetValue("MinNumber", Vector64float_0.ToString(), 1), GetValue("MinNumber", Vector64float_1.ToString(), 2), GetValue("MinNumber", apiResult.ToString(), 3));

try {
MinNumberTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinNumberAcrossResult = Dummy_MinNumberAcrossTest(Vector128float_0);
apiResult = MinNumberAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. MinNumberAcross

`Vector64<float> MinNumberAcross(Vector128<float> value)`

{0}

```csharp
private Vector64<float> MinNumberAcrossTest(Vector128<float> value)
{{
  return AdvSimd.Arm64.MinNumberAcross(value);
}}
// value = {1}
// Result = {2}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumberacross?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vminnmvq_f32).

Assembly generated:

```armasm", GetValue("MinNumberAcross", "Performs 'MinNumberAcross' operation.", 0), GetValue("MinNumberAcross", Vector128float_0.ToString(), 1), GetValue("MinNumberAcross", apiResult.ToString(), 2));

try {
MinNumberAcrossTest(Vector128float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinNumberPairwiseResult = Dummy_MinNumberPairwiseTest(Vector64float_0, Vector64float_1);
apiResult = MinNumberPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. MinNumberPairwise

`Vector64<float> MinNumberPairwise(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> MinNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.MinNumberPairwise(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MinNumberPairwise(Vector128<double> left, Vector128<double> right)
Vector128<float> MinNumberPairwise(Vector128<float> left, Vector128<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumberpairwise?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpminnm_f32).

Assembly generated:

```armasm", GetValue("MinNumberPairwise", "Performs 'MinNumberPairwise' operation.", 0), GetValue("MinNumberPairwise", Vector64float_0.ToString(), 1), GetValue("MinNumberPairwise", Vector64float_1.ToString(), 2), GetValue("MinNumberPairwise", apiResult.ToString(), 3));

try {
MinNumberPairwiseTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinNumberPairwiseScalarResult = Dummy_MinNumberPairwiseScalarTest(Vector64float_0);
apiResult = MinNumberPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. MinNumberPairwiseScalar

`Vector64<float> MinNumberPairwiseScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<float> MinNumberPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MinNumberPairwiseScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MinNumberPairwiseScalar(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumberpairwisescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpminnms_f32).

Assembly generated:

```armasm", GetValue("MinNumberPairwiseScalar", "Performs 'MinNumberPairwiseScalar' operation.", 0), GetValue("MinNumberPairwiseScalar", Vector64float_0.ToString(), 1), GetValue("MinNumberPairwiseScalar", apiResult.ToString(), 2));

try {
MinNumberPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinNumberScalarResult = Dummy_MinNumberScalarTest(Vector64double_0, Vector64double_1);
apiResult = MinNumberScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. MinNumberScalar

`Vector64<double> MinNumberScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> MinNumberScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.MinNumberScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MinNumberScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.minnumberscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vminnm_f64).

Assembly generated:

```armasm", GetValue("MinNumberScalar", "Performs 'MinNumberScalar' operation.", 0), GetValue("MinNumberScalar", Vector64double_0.ToString(), 1), GetValue("MinNumberScalar", Vector64double_1.ToString(), 2), GetValue("MinNumberScalar", apiResult.ToString(), 3));

try {
MinNumberScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinPairwiseResult = Dummy_MinPairwiseTest(Vector64byte_0, Vector64byte_1);
apiResult = MinPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. MinPairwise

`Vector64<byte> MinPairwise(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MinPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MinPairwise(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MinPairwise(Vector64<short> left, Vector64<short> right)
Vector64<int> MinPairwise(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> MinPairwise(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> MinPairwise(Vector64<float> left, Vector64<float> right)
Vector64<ushort> MinPairwise(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MinPairwise(Vector64<uint> left, Vector64<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> MinPairwise(Vector128<byte> left, Vector128<byte> right)
Vector128<double> MinPairwise(Vector128<double> left, Vector128<double> right)
Vector128<short> MinPairwise(Vector128<short> left, Vector128<short> right)
Vector128<int> MinPairwise(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> MinPairwise(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> MinPairwise(Vector128<float> left, Vector128<float> right)
Vector128<ushort> MinPairwise(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> MinPairwise(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.minpairwise?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minpairwise?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpmin_u8).

Assembly generated:

```armasm", GetValue("MinPairwise", "Performs 'MinPairwise' operation.", 0), GetValue("MinPairwise", Vector64byte_0.ToString(), 1), GetValue("MinPairwise", Vector64byte_1.ToString(), 2), GetValue("MinPairwise", apiResult.ToString(), 3));

try {
MinPairwiseTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinPairwiseScalarResult = Dummy_MinPairwiseScalarTest(Vector64float_0);
apiResult = MinPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. MinPairwiseScalar

`Vector64<float> MinPairwiseScalar(Vector64<float> value)`

{0}

```csharp
private Vector64<float> MinPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MinPairwiseScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MinPairwiseScalar(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minpairwisescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vpmins_f32).

Assembly generated:

```armasm", GetValue("MinPairwiseScalar", "Performs 'MinPairwiseScalar' operation.", 0), GetValue("MinPairwiseScalar", Vector64float_0.ToString(), 1), GetValue("MinPairwiseScalar", apiResult.ToString(), 2));

try {
MinPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MinScalarResult = Dummy_MinScalarTest(Vector64double_0, Vector64double_1);
apiResult = MinScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. MinScalar

`Vector64<double> MinScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> MinScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MinScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MinScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmin_f64).

Assembly generated:

```armasm", GetValue("MinScalar", "Performs 'MinScalar' operation.", 0), GetValue("MinScalar", Vector64double_0.ToString(), 1), GetValue("MinScalar", Vector64double_1.ToString(), 2), GetValue("MinScalar", apiResult.ToString(), 3));

try {
MinScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyResult = Dummy_MultiplyTest(Vector64byte_0, Vector64byte_1);
apiResult = MultiplyResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. Multiply

`Vector64<byte> Multiply(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MultiplyTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Multiply(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> Multiply(Vector64<short> left, Vector64<short> right)
Vector64<int> Multiply(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> Multiply(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Multiply(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Multiply(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Multiply(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right)
Vector128<short> Multiply(Vector128<short> left, Vector128<short> right)
Vector128<int> Multiply(Vector128<int> left, Vector128<int> right)
Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Multiply(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Multiply(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiply?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiply?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmul_u8).

Assembly generated:

```armasm", GetValue("Multiply", "Performs 'Multiply' operation.", 0), GetValue("Multiply", Vector64byte_0.ToString(), 1), GetValue("Multiply", Vector64byte_1.ToString(), 2), GetValue("Multiply", apiResult.ToString(), 3));

try {
MultiplyTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyAddResult = Dummy_MultiplyAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = MultiplyAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. MultiplyAdd

`Vector64<byte> MultiplyAdd(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MultiplyAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplyAdd(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
Vector64<int> MultiplyAdd(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
Vector64<sbyte> MultiplyAdd(Vector64<sbyte> addend, Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> MultiplyAdd(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MultiplyAdd(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right)
Vector128<byte> MultiplyAdd(Vector128<byte> addend, Vector128<byte> left, Vector128<byte> right)
Vector128<short> MultiplyAdd(Vector128<short> addend, Vector128<short> left, Vector128<short> right)
Vector128<int> MultiplyAdd(Vector128<int> addend, Vector128<int> left, Vector128<int> right)
Vector128<sbyte> MultiplyAdd(Vector128<sbyte> addend, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> MultiplyAdd(Vector128<ushort> addend, Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> MultiplyAdd(Vector128<uint> addend, Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmla_u8).

Assembly generated:

```armasm", GetValue("MultiplyAdd", "Performs 'MultiplyAdd' operation.", 0), GetValue("MultiplyAdd", Vector64byte_0.ToString(), 1), GetValue("MultiplyAdd", Vector64byte_1.ToString(), 2), GetValue("MultiplyAdd", Vector64byte_2.ToString(), 3), GetValue("MultiplyAdd", apiResult.ToString(), 4));

try {
MultiplyAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyAddByScalarResult = Dummy_MultiplyAddByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);
apiResult = MultiplyAddByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. MultiplyAddByScalar

`Vector64<short> MultiplyAddByScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyAddByScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyAddByScalar(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyAddByScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
Vector64<ushort> MultiplyAddByScalar(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MultiplyAddByScalar(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right)
Vector128<short> MultiplyAddByScalar(Vector128<short> addend, Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplyAddByScalar(Vector128<int> addend, Vector128<int> left, Vector64<int> right)
Vector128<ushort> MultiplyAddByScalar(Vector128<ushort> addend, Vector128<ushort> left, Vector64<ushort> right)
Vector128<uint> MultiplyAddByScalar(Vector128<uint> addend, Vector128<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyaddbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmla_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyAddByScalar", "Performs 'MultiplyAddByScalar' operation.", 0), GetValue("MultiplyAddByScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyAddByScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyAddByScalar", Vector64short_2.ToString(), 3), GetValue("MultiplyAddByScalar", apiResult.ToString(), 4));

try {
MultiplyAddByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyAddBySelectedScalarResult = Dummy_MultiplyAddBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);
apiResult = MultiplyAddBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. MultiplyAddBySelectedScalar

`Vector64<short> MultiplyAddBySelectedScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplyAddBySelectedScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyAddBySelectedScalar(addend, left, right, 3);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplyAddBySelectedScalar(Vector64<short> addend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyAddBySelectedScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyAddBySelectedScalar(Vector64<int> addend, Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector64<ushort> MultiplyAddBySelectedScalar(Vector64<ushort> addend, Vector64<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector64<ushort> MultiplyAddBySelectedScalar(Vector64<ushort> addend, Vector64<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector64<uint> MultiplyAddBySelectedScalar(Vector64<uint> addend, Vector64<uint> left, Vector64<uint> right, byte rightIndex)
Vector64<uint> MultiplyAddBySelectedScalar(Vector64<uint> addend, Vector64<uint> left, Vector128<uint> right, byte rightIndex)
Vector128<short> MultiplyAddBySelectedScalar(Vector128<short> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
Vector128<short> MultiplyAddBySelectedScalar(Vector128<short> addend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<int> MultiplyAddBySelectedScalar(Vector128<int> addend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<int> MultiplyAddBySelectedScalar(Vector128<int> addend, Vector128<int> left, Vector128<int> right, byte rightIndex)
Vector128<ushort> MultiplyAddBySelectedScalar(Vector128<ushort> addend, Vector128<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<ushort> MultiplyAddBySelectedScalar(Vector128<ushort> addend, Vector128<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<uint> MultiplyAddBySelectedScalar(Vector128<uint> addend, Vector128<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<uint> MultiplyAddBySelectedScalar(Vector128<uint> addend, Vector128<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyaddbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmla_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyAddBySelectedScalar", "Performs 'MultiplyAddBySelectedScalar' operation.", 0), GetValue("MultiplyAddBySelectedScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyAddBySelectedScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyAddBySelectedScalar", Vector64short_2.ToString(), 3), GetValue("MultiplyAddBySelectedScalar", byte_0.ToString(), 4), GetValue("MultiplyAddBySelectedScalar", apiResult.ToString(), 5));

try {
MultiplyAddBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyByScalarResult = Dummy_MultiplyByScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. MultiplyByScalar

`Vector64<short> MultiplyByScalar(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyByScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyByScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyByScalar(Vector64<int> left, Vector64<int> right)
Vector64<float> MultiplyByScalar(Vector64<float> left, Vector64<float> right)
Vector64<ushort> MultiplyByScalar(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MultiplyByScalar(Vector64<uint> left, Vector64<uint> right)
Vector128<short> MultiplyByScalar(Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplyByScalar(Vector128<int> left, Vector64<int> right)
Vector128<float> MultiplyByScalar(Vector128<float> left, Vector64<float> right)
Vector128<ushort> MultiplyByScalar(Vector128<ushort> left, Vector64<ushort> right)
Vector128<uint> MultiplyByScalar(Vector128<uint> left, Vector64<uint> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MultiplyByScalar(Vector128<double> left, Vector64<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplybyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmul_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyByScalar", "Performs 'MultiplyByScalar' operation.", 0), GetValue("MultiplyByScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyByScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyByScalar", apiResult.ToString(), 3));

try {
MultiplyByScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarResult = Dummy_MultiplyBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. MultiplyBySelectedScalar

`Vector64<short> MultiplyBySelectedScalar(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplyBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalar(left, right, 3);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplyBySelectedScalar(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyBySelectedScalar(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyBySelectedScalar(Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector64<float> MultiplyBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> MultiplyBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector64<ushort> MultiplyBySelectedScalar(Vector64<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector64<ushort> MultiplyBySelectedScalar(Vector64<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector64<uint> MultiplyBySelectedScalar(Vector64<uint> left, Vector64<uint> right, byte rightIndex)
Vector64<uint> MultiplyBySelectedScalar(Vector64<uint> left, Vector128<uint> right, byte rightIndex)
Vector128<short> MultiplyBySelectedScalar(Vector128<short> left, Vector64<short> right, byte rightIndex)
Vector128<short> MultiplyBySelectedScalar(Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<int> MultiplyBySelectedScalar(Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<int> MultiplyBySelectedScalar(Vector128<int> left, Vector128<int> right, byte rightIndex)
Vector128<float> MultiplyBySelectedScalar(Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> MultiplyBySelectedScalar(Vector128<float> left, Vector128<float> right, byte rightIndex)
Vector128<ushort> MultiplyBySelectedScalar(Vector128<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<ushort> MultiplyBySelectedScalar(Vector128<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalar(Vector128<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalar(Vector128<uint> left, Vector128<uint> right, byte rightIndex)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MultiplyBySelectedScalar(Vector128<double> left, Vector128<double> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplybyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmul_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalar", "Performs 'MultiplyBySelectedScalar' operation.", 0), GetValue("MultiplyBySelectedScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyBySelectedScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningLowerResult = Dummy_MultiplyBySelectedScalarWideningLowerTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. MultiplyBySelectedScalarWideningLower

`Vector128<int> MultiplyBySelectedScalarWideningLower(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningLowerTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningLower(left, right, 3);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyBySelectedScalarWideningLower(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningLower(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningLower(Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningLower(Vector64<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningLower(Vector64<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningLower(Vector64<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningLower(Vector64<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmull_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalarWideningLower", "Performs 'MultiplyBySelectedScalarWideningLower' operation.", 0), GetValue("MultiplyBySelectedScalarWideningLower", Vector64short_0.ToString(), 1), GetValue("MultiplyBySelectedScalarWideningLower", Vector64short_1.ToString(), 2), GetValue("MultiplyBySelectedScalarWideningLower", byte_0.ToString(), 3), GetValue("MultiplyBySelectedScalarWideningLower", apiResult.ToString(), 4));

try {
MultiplyBySelectedScalarWideningLowerTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningLowerAndAddResult = Dummy_MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarWideningLowerAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. MultiplyBySelectedScalarWideningLowerAndAdd

`Vector128<int> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndAdd(addend, left, right, 2);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideninglowerandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlal_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalarWideningLowerAndAdd", "Performs 'MultiplyBySelectedScalarWideningLowerAndAdd' operation.", 0), GetValue("MultiplyBySelectedScalarWideningLowerAndAdd", Vector128int_0.ToString(), 1), GetValue("MultiplyBySelectedScalarWideningLowerAndAdd", Vector64short_0.ToString(), 2), GetValue("MultiplyBySelectedScalarWideningLowerAndAdd", Vector64short_1.ToString(), 3), GetValue("MultiplyBySelectedScalarWideningLowerAndAdd", byte_0.ToString(), 4), GetValue("MultiplyBySelectedScalarWideningLowerAndAdd", apiResult.ToString(), 5));

try {
MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningLowerAndSubtractResult = Dummy_MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarWideningLowerAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. MultiplyBySelectedScalarWideningLowerAndSubtract

`Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndSubtract(minuend, left, right, 2);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<long> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<long> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<uint> minuend, Vector64<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<uint> minuend, Vector64<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<ulong> minuend, Vector64<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<ulong> minuend, Vector64<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideninglowerandsubtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlsl_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalarWideningLowerAndSubtract", "Performs 'MultiplyBySelectedScalarWideningLowerAndSubtract' operation.", 0), GetValue("MultiplyBySelectedScalarWideningLowerAndSubtract", Vector128int_0.ToString(), 1), GetValue("MultiplyBySelectedScalarWideningLowerAndSubtract", Vector64short_0.ToString(), 2), GetValue("MultiplyBySelectedScalarWideningLowerAndSubtract", Vector64short_1.ToString(), 3), GetValue("MultiplyBySelectedScalarWideningLowerAndSubtract", byte_0.ToString(), 4), GetValue("MultiplyBySelectedScalarWideningLowerAndSubtract", apiResult.ToString(), 5));

try {
MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningUpperResult = Dummy_MultiplyBySelectedScalarWideningUpperTest(Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyBySelectedScalarWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. MultiplyBySelectedScalarWideningUpper

`Vector128<int> MultiplyBySelectedScalarWideningUpper(Vector128<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningUpperTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningUpper(left, right, 2);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyBySelectedScalarWideningUpper(Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningUpper(Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningUpper(Vector128<int> left, Vector128<int> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningUpper(Vector128<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningUpper(Vector128<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningUpper(Vector128<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningUpper(Vector128<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmull_high_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalarWideningUpper", "Performs 'MultiplyBySelectedScalarWideningUpper' operation.", 0), GetValue("MultiplyBySelectedScalarWideningUpper", Vector128short_0.ToString(), 1), GetValue("MultiplyBySelectedScalarWideningUpper", Vector64short_0.ToString(), 2), GetValue("MultiplyBySelectedScalarWideningUpper", byte_0.ToString(), 3), GetValue("MultiplyBySelectedScalarWideningUpper", apiResult.ToString(), 4));

try {
MultiplyBySelectedScalarWideningUpperTest(Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningUpperAndAddResult = Dummy_MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyBySelectedScalarWideningUpperAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. MultiplyBySelectedScalarWideningUpperAndAdd

`Vector128<int> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndAdd(addend, left, right, 0);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector128<int> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideningupperandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlal_high_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalarWideningUpperAndAdd", "Performs 'MultiplyBySelectedScalarWideningUpperAndAdd' operation.", 0), GetValue("MultiplyBySelectedScalarWideningUpperAndAdd", Vector128int_0.ToString(), 1), GetValue("MultiplyBySelectedScalarWideningUpperAndAdd", Vector128short_0.ToString(), 2), GetValue("MultiplyBySelectedScalarWideningUpperAndAdd", Vector64short_0.ToString(), 3), GetValue("MultiplyBySelectedScalarWideningUpperAndAdd", byte_0.ToString(), 4), GetValue("MultiplyBySelectedScalarWideningUpperAndAdd", apiResult.ToString(), 5));

try {
MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningUpperAndSubtractResult = Dummy_MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyBySelectedScalarWideningUpperAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. MultiplyBySelectedScalarWideningUpperAndSubtract

`Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndSubtract(minuend, left, right, 0);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<long> minuend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<long> minuend, Vector128<int> left, Vector128<int> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<uint> minuend, Vector128<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<uint> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<uint> minuend, Vector128<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<ulong> minuend, Vector128<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<ulong> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<ulong> minuend, Vector128<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideningupperandsubtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlsl_high_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyBySelectedScalarWideningUpperAndSubtract", "Performs 'MultiplyBySelectedScalarWideningUpperAndSubtract' operation.", 0), GetValue("MultiplyBySelectedScalarWideningUpperAndSubtract", Vector128int_0.ToString(), 1), GetValue("MultiplyBySelectedScalarWideningUpperAndSubtract", Vector128short_0.ToString(), 2), GetValue("MultiplyBySelectedScalarWideningUpperAndSubtract", Vector64short_0.ToString(), 3), GetValue("MultiplyBySelectedScalarWideningUpperAndSubtract", byte_0.ToString(), 4), GetValue("MultiplyBySelectedScalarWideningUpperAndSubtract", apiResult.ToString(), 5));

try {
MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingByScalarSaturateHighResult = Dummy_MultiplyDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingByScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. MultiplyDoublingByScalarSaturateHigh

`Vector64<short> MultiplyDoublingByScalarSaturateHigh(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingByScalarSaturateHigh(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyDoublingByScalarSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyDoublingByScalarSaturateHigh(Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplyDoublingByScalarSaturateHigh(Vector128<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingbyscalarsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmulh_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingByScalarSaturateHigh", "Performs 'MultiplyDoublingByScalarSaturateHigh' operation.", 0), GetValue("MultiplyDoublingByScalarSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingByScalarSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingByScalarSaturateHigh", apiResult.ToString(), 3));

try {
MultiplyDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 5
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 5 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[MultiplyDoublingBySelectedScalarSaturateHigh](#1-multiplydoublingbyselectedscalarsaturatehigh), [MultiplyDoublingSaturateHigh](#2-multiplydoublingsaturatehigh), [MultiplyDoublingSaturateHighScalar](#3-multiplydoublingsaturatehighscalar), [MultiplyDoublingScalarBySelectedScalarSaturateHigh](#4-multiplydoublingscalarbyselectedscalarsaturatehigh), [MultiplyDoublingWideningAndAddSaturateScalar](#5-multiplydoublingwideningandaddsaturatescalar), [MultiplyDoublingWideningAndSubtractSaturateScalar](#6-multiplydoublingwideningandsubtractsaturatescalar), [MultiplyDoublingWideningLowerAndAddSaturate](#7-multiplydoublingwideninglowerandaddsaturate), [MultiplyDoublingWideningLowerAndSubtractSaturate](#8-multiplydoublingwideninglowerandsubtractsaturate), [MultiplyDoublingWideningLowerByScalarAndAddSaturate](#9-multiplydoublingwideninglowerbyscalarandaddsaturate), [MultiplyDoublingWideningLowerByScalarAndSubtractSaturate](#10-multiplydoublingwideninglowerbyscalarandsubtractsaturate), [MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate](#11-multiplydoublingwideninglowerbyselectedscalarandaddsaturate), [MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate](#12-multiplydoublingwideninglowerbyselectedscalarandsubtractsaturate), [MultiplyDoublingWideningSaturateLower](#13-multiplydoublingwideningsaturatelower), [MultiplyDoublingWideningSaturateLowerByScalar](#14-multiplydoublingwideningsaturatelowerbyscalar), [MultiplyDoublingWideningSaturateLowerBySelectedScalar](#15-multiplydoublingwideningsaturatelowerbyselectedscalar), [MultiplyDoublingWideningSaturateScalar](#16-multiplydoublingwideningsaturatescalar), [MultiplyDoublingWideningSaturateScalarBySelectedScalar](#17-multiplydoublingwideningsaturatescalarbyselectedscalar), [MultiplyDoublingWideningSaturateUpper](#18-multiplydoublingwideningsaturateupper), [MultiplyDoublingWideningSaturateUpperByScalar](#19-multiplydoublingwideningsaturateupperbyscalar), [MultiplyDoublingWideningSaturateUpperBySelectedScalar](#20-multiplydoublingwideningsaturateupperbyselectedscalar), [MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate](#21-multiplydoublingwideningscalarbyselectedscalarandaddsaturate), [MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate](#22-multiplydoublingwideningscalarbyselectedscalarandsubtractsaturate), [MultiplyDoublingWideningUpperAndAddSaturate](#23-multiplydoublingwideningupperandaddsaturate), [MultiplyDoublingWideningUpperAndSubtractSaturate](#24-multiplydoublingwideningupperandsubtractsaturate), [MultiplyDoublingWideningUpperByScalarAndAddSaturate](#25-multiplydoublingwideningupperbyscalarandaddsaturate), [MultiplyDoublingWideningUpperByScalarAndSubtractSaturate](#26-multiplydoublingwideningupperbyscalarandsubtractsaturate), [MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate](#27-multiplydoublingwideningupperbyselectedscalarandaddsaturate), [MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate](#28-multiplydoublingwideningupperbyselectedscalarandsubtractsaturate), [MultiplyExtended](#29-multiplyextended), [MultiplyExtendedByScalar](#30-multiplyextendedbyscalar), [MultiplyExtendedBySelectedScalar](#31-multiplyextendedbyselectedscalar), [MultiplyExtendedScalar](#32-multiplyextendedscalar), [MultiplyExtendedScalarBySelectedScalar](#33-multiplyextendedscalarbyselectedscalar), [MultiplyRoundedDoublingByScalarSaturateHigh](#34-multiplyroundeddoublingbyscalarsaturatehigh), [MultiplyRoundedDoublingBySelectedScalarSaturateHigh](#35-multiplyroundeddoublingbyselectedscalarsaturatehigh), [MultiplyRoundedDoublingSaturateHigh](#36-multiplyroundeddoublingsaturatehigh), [MultiplyRoundedDoublingSaturateHighScalar](#37-multiplyroundeddoublingsaturatehighscalar), [MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh](#38-multiplyroundeddoublingscalarbyselectedscalarsaturatehigh), [MultiplyScalar](#39-multiplyscalar), [MultiplyScalarBySelectedScalar](#40-multiplyscalarbyselectedscalar), [MultiplySubtract](#41-multiplysubtract), [MultiplySubtractByScalar](#42-multiplysubtractbyscalar), [MultiplySubtractBySelectedScalar](#43-multiplysubtractbyselectedscalar), [MultiplyWideningLower](#44-multiplywideninglower), [MultiplyWideningLowerAndAdd](#45-multiplywideninglowerandadd)


");

try {
var MultiplyDoublingBySelectedScalarSaturateHighResult = Dummy_MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. MultiplyDoublingBySelectedScalarSaturateHigh

`Vector64<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingBySelectedScalarSaturateHigh(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector128<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector64<short> right, byte rightIndex)
Vector128<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<int> MultiplyDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingbyselectedscalarsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmulh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingBySelectedScalarSaturateHigh", "Performs 'MultiplyDoublingBySelectedScalarSaturateHigh' operation.", 0), GetValue("MultiplyDoublingBySelectedScalarSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingBySelectedScalarSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingBySelectedScalarSaturateHigh", byte_0.ToString(), 3), GetValue("MultiplyDoublingBySelectedScalarSaturateHigh", apiResult.ToString(), 4));

try {
MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingSaturateHighResult = Dummy_MultiplyDoublingSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. MultiplyDoublingSaturateHigh

`Vector64<short> MultiplyDoublingSaturateHigh(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingSaturateHigh(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyDoublingSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyDoublingSaturateHigh(Vector128<short> left, Vector128<short> right)
Vector128<int> MultiplyDoublingSaturateHigh(Vector128<int> left, Vector128<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmulh_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingSaturateHigh", "Performs 'MultiplyDoublingSaturateHigh' operation.", 0), GetValue("MultiplyDoublingSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingSaturateHigh", apiResult.ToString(), 3));

try {
MultiplyDoublingSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingSaturateHighScalarResult = Dummy_MultiplyDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingSaturateHighScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. MultiplyDoublingSaturateHighScalar

`Vector64<short> MultiplyDoublingSaturateHighScalar(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingSaturateHighScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingSaturateHighScalar(Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingsaturatehighscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmulhh_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingSaturateHighScalar", "Performs 'MultiplyDoublingSaturateHighScalar' operation.", 0), GetValue("MultiplyDoublingSaturateHighScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingSaturateHighScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingSaturateHighScalar", apiResult.ToString(), 3));

try {
MultiplyDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingScalarBySelectedScalarSaturateHighResult = Dummy_MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingScalarBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. MultiplyDoublingScalarBySelectedScalarSaturateHigh

`Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingScalarBySelectedScalarSaturateHigh(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingscalarbyselectedscalarsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmulhh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingScalarBySelectedScalarSaturateHigh", "Performs 'MultiplyDoublingScalarBySelectedScalarSaturateHigh' operation.", 0), GetValue("MultiplyDoublingScalarBySelectedScalarSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingScalarBySelectedScalarSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingScalarBySelectedScalarSaturateHigh", byte_0.ToString(), 3), GetValue("MultiplyDoublingScalarBySelectedScalarSaturateHigh", apiResult.ToString(), 4));

try {
MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningAndAddSaturateScalarResult = Dummy_MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningAndAddSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. MultiplyDoublingWideningAndAddSaturateScalar

`Vector64<int> MultiplyDoublingWideningAndAddSaturateScalar(Vector64<int> addend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<int> MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndAddSaturateScalar(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> MultiplyDoublingWideningAndAddSaturateScalar(Vector64<long> addend, Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningandaddsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlalh_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningAndAddSaturateScalar", "Performs 'MultiplyDoublingWideningAndAddSaturateScalar' operation.", 0), GetValue("MultiplyDoublingWideningAndAddSaturateScalar", Vector64int_0.ToString(), 1), GetValue("MultiplyDoublingWideningAndAddSaturateScalar", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningAndAddSaturateScalar", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningAndAddSaturateScalar", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningAndSubtractSaturateScalarResult = Dummy_MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningAndSubtractSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. MultiplyDoublingWideningAndSubtractSaturateScalar

`Vector64<int> MultiplyDoublingWideningAndSubtractSaturateScalar(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<int> MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndSubtractSaturateScalar(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> MultiplyDoublingWideningAndSubtractSaturateScalar(Vector64<long> minuend, Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningandsubtractsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlslh_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningAndSubtractSaturateScalar", "Performs 'MultiplyDoublingWideningAndSubtractSaturateScalar' operation.", 0), GetValue("MultiplyDoublingWideningAndSubtractSaturateScalar", Vector64int_0.ToString(), 1), GetValue("MultiplyDoublingWideningAndSubtractSaturateScalar", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningAndSubtractSaturateScalar", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningAndSubtractSaturateScalar", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerAndAddSaturateResult = Dummy_MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. MultiplyDoublingWideningLowerAndAddSaturate

`Vector128<int> MultiplyDoublingWideningLowerAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerAndAddSaturate(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlal_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningLowerAndAddSaturate", "Performs 'MultiplyDoublingWideningLowerAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningLowerAndAddSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningLowerAndAddSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningLowerAndAddSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningLowerAndAddSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. MultiplyDoublingWideningLowerAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningLowerAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerAndSubtractSaturate(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlsl_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningLowerAndSubtractSaturate", "Performs 'MultiplyDoublingWideningLowerAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningLowerAndSubtractSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningLowerAndSubtractSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningLowerAndSubtractSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningLowerAndSubtractSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerByScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerByScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. MultiplyDoublingWideningLowerByScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningLowerByScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndAddSaturate(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerByScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyscalarandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlal_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningLowerByScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningLowerByScalarAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningLowerByScalarAndAddSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningLowerByScalarAndAddSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningLowerByScalarAndAddSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningLowerByScalarAndAddSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerByScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerByScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. MultiplyDoublingWideningLowerByScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyscalarandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlsl_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningLowerByScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningLowerByScalarAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningLowerByScalarAndSubtractSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningLowerByScalarAndSubtractSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningLowerByScalarAndSubtractSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningLowerByScalarAndSubtractSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(addend, left, right, 0);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyselectedscalarandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlal_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", byte_0.ToString(), 4), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", apiResult.ToString(), 5));

try {
MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(minuend, left, right, 0);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyselectedscalarandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlsl_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", byte_0.ToString(), 4), GetValue("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", apiResult.ToString(), 5));

try {
MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateLowerResult = Dummy_MultiplyDoublingWideningSaturateLowerTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. MultiplyDoublingWideningSaturateLower

`Vector128<int> MultiplyDoublingWideningSaturateLower(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateLowerTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateLower(Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturatelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmull_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateLower", "Performs 'MultiplyDoublingWideningSaturateLower' operation.", 0), GetValue("MultiplyDoublingWideningSaturateLower", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateLower", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateLower", apiResult.ToString(), 3));

try {
MultiplyDoublingWideningSaturateLowerTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateLowerByScalarResult = Dummy_MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningSaturateLowerByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. MultiplyDoublingWideningSaturateLowerByScalar

`Vector128<int> MultiplyDoublingWideningSaturateLowerByScalar(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerByScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateLowerByScalar(Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturatelowerbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmull_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateLowerByScalar", "Performs 'MultiplyDoublingWideningSaturateLowerByScalar' operation.", 0), GetValue("MultiplyDoublingWideningSaturateLowerByScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateLowerByScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateLowerByScalar", apiResult.ToString(), 3));

try {
MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateLowerBySelectedScalarResult = Dummy_MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningSaturateLowerBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. MultiplyDoublingWideningSaturateLowerBySelectedScalar

`Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerBySelectedScalar(left, right, 2);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturatelowerbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmull_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateLowerBySelectedScalar", "Performs 'MultiplyDoublingWideningSaturateLowerBySelectedScalar' operation.", 0), GetValue("MultiplyDoublingWideningSaturateLowerBySelectedScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateLowerBySelectedScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateLowerBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyDoublingWideningSaturateLowerBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateScalarResult = Dummy_MultiplyDoublingWideningSaturateScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. MultiplyDoublingWideningSaturateScalar

`Vector64<int> MultiplyDoublingWideningSaturateScalar(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<int> MultiplyDoublingWideningSaturateScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> MultiplyDoublingWideningSaturateScalar(Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmullh_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateScalar", "Performs 'MultiplyDoublingWideningSaturateScalar' operation.", 0), GetValue("MultiplyDoublingWideningSaturateScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateScalar", apiResult.ToString(), 3));

try {
MultiplyDoublingWideningSaturateScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateScalarBySelectedScalarResult = Dummy_MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningSaturateScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. MultiplyDoublingWideningSaturateScalarBySelectedScalar

`Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalarBySelectedScalar(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningsaturatescalarbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmullh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateScalarBySelectedScalar", "Performs 'MultiplyDoublingWideningSaturateScalarBySelectedScalar' operation.", 0), GetValue("MultiplyDoublingWideningSaturateScalarBySelectedScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateScalarBySelectedScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateScalarBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyDoublingWideningSaturateScalarBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateUpperResult = Dummy_MultiplyDoublingWideningSaturateUpperTest(Vector128short_0, Vector128short_1);
apiResult = MultiplyDoublingWideningSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. MultiplyDoublingWideningSaturateUpper

`Vector128<int> MultiplyDoublingWideningSaturateUpper(Vector128<short> left, Vector128<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateUpperTest(Vector128<short> left, Vector128<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateUpper(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateUpper(Vector128<int> left, Vector128<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturateupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmull_high_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateUpper", "Performs 'MultiplyDoublingWideningSaturateUpper' operation.", 0), GetValue("MultiplyDoublingWideningSaturateUpper", Vector128short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateUpper", Vector128short_1.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateUpper", apiResult.ToString(), 3));

try {
MultiplyDoublingWideningSaturateUpperTest(Vector128short_0, Vector128short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateUpperByScalarResult = Dummy_MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128short_0, Vector64short_0);
apiResult = MultiplyDoublingWideningSaturateUpperByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. MultiplyDoublingWideningSaturateUpperByScalar

`Vector128<int> MultiplyDoublingWideningSaturateUpperByScalar(Vector128<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperByScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateUpperByScalar(Vector128<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturateupperbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmull_high_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateUpperByScalar", "Performs 'MultiplyDoublingWideningSaturateUpperByScalar' operation.", 0), GetValue("MultiplyDoublingWideningSaturateUpperByScalar", Vector128short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateUpperByScalar", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateUpperByScalar", apiResult.ToString(), 3));

try {
MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128short_0, Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateUpperBySelectedScalarResult = Dummy_MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyDoublingWideningSaturateUpperBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. MultiplyDoublingWideningSaturateUpperBySelectedScalar

`Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperBySelectedScalar(left, right, 2);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturateupperbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmull_high_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningSaturateUpperBySelectedScalar", "Performs 'MultiplyDoublingWideningSaturateUpperBySelectedScalar' operation.", 0), GetValue("MultiplyDoublingWideningSaturateUpperBySelectedScalar", Vector128short_0.ToString(), 1), GetValue("MultiplyDoublingWideningSaturateUpperBySelectedScalar", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningSaturateUpperBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyDoublingWideningSaturateUpperBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate

`Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(addend, left, right, 0);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<int> addend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<long> addend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<long> addend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningscalarbyselectedscalarandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlalh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", Vector64int_0.ToString(), 1), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", byte_0.ToString(), 4), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", apiResult.ToString(), 5));

try {
MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate

`Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(minuend, left, right, 0);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<int> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<long> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<long> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningscalarbyselectedscalarandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlslh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", Vector64int_0.ToString(), 1), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", Vector64short_0.ToString(), 2), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", Vector64short_1.ToString(), 3), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", byte_0.ToString(), 4), GetValue("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", apiResult.ToString(), 5));

try {
MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperAndAddSaturateResult = Dummy_MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);
apiResult = MultiplyDoublingWideningUpperAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. MultiplyDoublingWideningUpperAndAddSaturate

`Vector128<int> MultiplyDoublingWideningUpperAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperAndAddSaturate(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlal_high_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningUpperAndAddSaturate", "Performs 'MultiplyDoublingWideningUpperAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningUpperAndAddSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningUpperAndAddSaturate", Vector128short_0.ToString(), 2), GetValue("MultiplyDoublingWideningUpperAndAddSaturate", Vector128short_1.ToString(), 3), GetValue("MultiplyDoublingWideningUpperAndAddSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);
apiResult = MultiplyDoublingWideningUpperAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. MultiplyDoublingWideningUpperAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningUpperAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperAndSubtractSaturate(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector128<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlsl_high_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningUpperAndSubtractSaturate", "Performs 'MultiplyDoublingWideningUpperAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningUpperAndSubtractSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningUpperAndSubtractSaturate", Vector128short_0.ToString(), 2), GetValue("MultiplyDoublingWideningUpperAndSubtractSaturate", Vector128short_1.ToString(), 3), GetValue("MultiplyDoublingWideningUpperAndSubtractSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperByScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);
apiResult = MultiplyDoublingWideningUpperByScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. MultiplyDoublingWideningUpperByScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningUpperByScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndAddSaturate(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperByScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyscalarandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlal_high_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningUpperByScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningUpperByScalarAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningUpperByScalarAndAddSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningUpperByScalarAndAddSaturate", Vector128short_0.ToString(), 2), GetValue("MultiplyDoublingWideningUpperByScalarAndAddSaturate", Vector64short_0.ToString(), 3), GetValue("MultiplyDoublingWideningUpperByScalarAndAddSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperByScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);
apiResult = MultiplyDoublingWideningUpperByScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. MultiplyDoublingWideningUpperByScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyscalarandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlsl_high_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningUpperByScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningUpperByScalarAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningUpperByScalarAndSubtractSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningUpperByScalarAndSubtractSaturate", Vector128short_0.ToString(), 2), GetValue("MultiplyDoublingWideningUpperByScalarAndSubtractSaturate", Vector64short_0.ToString(), 3), GetValue("MultiplyDoublingWideningUpperByScalarAndSubtractSaturate", apiResult.ToString(), 4));

try {
MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(addend, left, right, 2);
}}
// addend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyselectedscalarandaddsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlal_high_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate' operation.", 0), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", Vector128short_0.ToString(), 2), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", Vector64short_0.ToString(), 3), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", byte_0.ToString(), 4), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", apiResult.ToString(), 5));

try {
MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(minuend, left, right, 2);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyselectedscalarandsubtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqdmlsl_high_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate' operation.", 0), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", Vector128int_0.ToString(), 1), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", Vector128short_0.ToString(), 2), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", Vector64short_0.ToString(), 3), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", byte_0.ToString(), 4), GetValue("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", apiResult.ToString(), 5));

try {
MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyExtendedResult = Dummy_MultiplyExtendedTest(Vector64float_0, Vector64float_1);
apiResult = MultiplyExtendedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. MultiplyExtended

`Vector64<float> MultiplyExtended(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> MultiplyExtendedTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.MultiplyExtended(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MultiplyExtended(Vector128<double> left, Vector128<double> right)
Vector128<float> MultiplyExtended(Vector128<float> left, Vector128<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextended?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmulx_f32).

Assembly generated:

```armasm", GetValue("MultiplyExtended", "Performs 'MultiplyExtended' operation.", 0), GetValue("MultiplyExtended", Vector64float_0.ToString(), 1), GetValue("MultiplyExtended", Vector64float_1.ToString(), 2), GetValue("MultiplyExtended", apiResult.ToString(), 3));

try {
MultiplyExtendedTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyExtendedByScalarResult = Dummy_MultiplyExtendedByScalarTest(Vector128double_0, Vector64double_0);
apiResult = MultiplyExtendedByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. MultiplyExtendedByScalar

`Vector128<double> MultiplyExtendedByScalar(Vector128<double> left, Vector64<double> right)`

{0}

```csharp
private Vector128<double> MultiplyExtendedByScalarTest(Vector128<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MultiplyExtendedByScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmulxq_lane_f64).

Assembly generated:

```armasm", GetValue("MultiplyExtendedByScalar", "Performs 'MultiplyExtendedByScalar' operation.", 0), GetValue("MultiplyExtendedByScalar", Vector128double_0.ToString(), 1), GetValue("MultiplyExtendedByScalar", Vector64double_0.ToString(), 2), GetValue("MultiplyExtendedByScalar", apiResult.ToString(), 3));

try {
MultiplyExtendedByScalarTest(Vector128double_0, Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyExtendedBySelectedScalarResult = Dummy_MultiplyExtendedBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);
apiResult = MultiplyExtendedBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. MultiplyExtendedBySelectedScalar

`Vector64<float> MultiplyExtendedBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)`

{0}

```csharp
private Vector64<float> MultiplyExtendedBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyExtendedBySelectedScalar(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MultiplyExtendedBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector128<double> MultiplyExtendedBySelectedScalar(Vector128<double> left, Vector128<double> right, byte rightIndex)
Vector128<float> MultiplyExtendedBySelectedScalar(Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> MultiplyExtendedBySelectedScalar(Vector128<float> left, Vector128<float> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmulx_lane_f32).

Assembly generated:

```armasm", GetValue("MultiplyExtendedBySelectedScalar", "Performs 'MultiplyExtendedBySelectedScalar' operation.", 0), GetValue("MultiplyExtendedBySelectedScalar", Vector64float_0.ToString(), 1), GetValue("MultiplyExtendedBySelectedScalar", Vector64float_1.ToString(), 2), GetValue("MultiplyExtendedBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyExtendedBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyExtendedBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyExtendedScalarResult = Dummy_MultiplyExtendedScalarTest(Vector64double_0, Vector64double_1);
apiResult = MultiplyExtendedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. MultiplyExtendedScalar

`Vector64<double> MultiplyExtendedScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> MultiplyExtendedScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MultiplyExtendedScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MultiplyExtendedScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmulx_f64).

Assembly generated:

```armasm", GetValue("MultiplyExtendedScalar", "Performs 'MultiplyExtendedScalar' operation.", 0), GetValue("MultiplyExtendedScalar", Vector64double_0.ToString(), 1), GetValue("MultiplyExtendedScalar", Vector64double_1.ToString(), 2), GetValue("MultiplyExtendedScalar", apiResult.ToString(), 3));

try {
MultiplyExtendedScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyExtendedScalarBySelectedScalarResult = Dummy_MultiplyExtendedScalarBySelectedScalarTest(Vector64double_0, Vector128double_0, byte_0);
apiResult = MultiplyExtendedScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. MultiplyExtendedScalarBySelectedScalar

`Vector64<double> MultiplyExtendedScalarBySelectedScalar(Vector64<double> left, Vector128<double> right, byte rightIndex)`

{0}

```csharp
private Vector64<double> MultiplyExtendedScalarBySelectedScalarTest(Vector64<double> left, Vector128<double> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyExtendedScalarBySelectedScalar(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MultiplyExtendedScalarBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> MultiplyExtendedScalarBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedscalarbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmulxd_laneq_f64).

Assembly generated:

```armasm", GetValue("MultiplyExtendedScalarBySelectedScalar", "Performs 'MultiplyExtendedScalarBySelectedScalar' operation.", 0), GetValue("MultiplyExtendedScalarBySelectedScalar", Vector64double_0.ToString(), 1), GetValue("MultiplyExtendedScalarBySelectedScalar", Vector128double_0.ToString(), 2), GetValue("MultiplyExtendedScalarBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyExtendedScalarBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyExtendedScalarBySelectedScalarTest(Vector64double_0, Vector128double_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingByScalarSaturateHighResult = Dummy_MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyRoundedDoublingByScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. MultiplyRoundedDoublingByScalarSaturateHigh

`Vector64<short> MultiplyRoundedDoublingByScalarSaturateHigh(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyRoundedDoublingByScalarSaturateHigh(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyRoundedDoublingByScalarSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyRoundedDoublingByScalarSaturateHigh(Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplyRoundedDoublingByScalarSaturateHigh(Vector128<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyroundeddoublingbyscalarsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrdmulh_n_s16).

Assembly generated:

```armasm", GetValue("MultiplyRoundedDoublingByScalarSaturateHigh", "Performs 'MultiplyRoundedDoublingByScalarSaturateHigh' operation.", 0), GetValue("MultiplyRoundedDoublingByScalarSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyRoundedDoublingByScalarSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyRoundedDoublingByScalarSaturateHigh", apiResult.ToString(), 3));

try {
MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingBySelectedScalarSaturateHighResult = Dummy_MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyRoundedDoublingBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. MultiplyRoundedDoublingBySelectedScalarSaturateHigh

`Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyRoundedDoublingBySelectedScalarSaturateHigh(left, right, 2);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector128<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector64<short> right, byte rightIndex)
Vector128<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<int> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyroundeddoublingbyselectedscalarsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrdmulh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyRoundedDoublingBySelectedScalarSaturateHigh", "Performs 'MultiplyRoundedDoublingBySelectedScalarSaturateHigh' operation.", 0), GetValue("MultiplyRoundedDoublingBySelectedScalarSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyRoundedDoublingBySelectedScalarSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyRoundedDoublingBySelectedScalarSaturateHigh", byte_0.ToString(), 3), GetValue("MultiplyRoundedDoublingBySelectedScalarSaturateHigh", apiResult.ToString(), 4));

try {
MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingSaturateHighResult = Dummy_MultiplyRoundedDoublingSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyRoundedDoublingSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. MultiplyRoundedDoublingSaturateHigh

`Vector64<short> MultiplyRoundedDoublingSaturateHigh(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyRoundedDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyRoundedDoublingSaturateHigh(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyRoundedDoublingSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyRoundedDoublingSaturateHigh(Vector128<short> left, Vector128<short> right)
Vector128<int> MultiplyRoundedDoublingSaturateHigh(Vector128<int> left, Vector128<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyroundeddoublingsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrdmulh_s16).

Assembly generated:

```armasm", GetValue("MultiplyRoundedDoublingSaturateHigh", "Performs 'MultiplyRoundedDoublingSaturateHigh' operation.", 0), GetValue("MultiplyRoundedDoublingSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyRoundedDoublingSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyRoundedDoublingSaturateHigh", apiResult.ToString(), 3));

try {
MultiplyRoundedDoublingSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingSaturateHighScalarResult = Dummy_MultiplyRoundedDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyRoundedDoublingSaturateHighScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. MultiplyRoundedDoublingSaturateHighScalar

`Vector64<short> MultiplyRoundedDoublingSaturateHighScalar(Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplyRoundedDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyRoundedDoublingSaturateHighScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyRoundedDoublingSaturateHighScalar(Vector64<int> left, Vector64<int> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyroundeddoublingsaturatehighscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrdmulhh_s16).

Assembly generated:

```armasm", GetValue("MultiplyRoundedDoublingSaturateHighScalar", "Performs 'MultiplyRoundedDoublingSaturateHighScalar' operation.", 0), GetValue("MultiplyRoundedDoublingSaturateHighScalar", Vector64short_0.ToString(), 1), GetValue("MultiplyRoundedDoublingSaturateHighScalar", Vector64short_1.ToString(), 2), GetValue("MultiplyRoundedDoublingSaturateHighScalar", apiResult.ToString(), 3));

try {
MultiplyRoundedDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighResult = Dummy_MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh

`Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyroundeddoublingscalarbyselectedscalarsaturatehigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrdmulhh_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh", "Performs 'MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh' operation.", 0), GetValue("MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh", Vector64short_0.ToString(), 1), GetValue("MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh", Vector64short_1.ToString(), 2), GetValue("MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh", byte_0.ToString(), 3), GetValue("MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh", apiResult.ToString(), 4));

try {
MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyScalarResult = Dummy_MultiplyScalarTest(Vector64double_0, Vector64double_1);
apiResult = MultiplyScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. MultiplyScalar

`Vector64<double> MultiplyScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> MultiplyScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.MultiplyScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MultiplyScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmul_f64).

Assembly generated:

```armasm", GetValue("MultiplyScalar", "Performs 'MultiplyScalar' operation.", 0), GetValue("MultiplyScalar", Vector64double_0.ToString(), 1), GetValue("MultiplyScalar", Vector64double_1.ToString(), 2), GetValue("MultiplyScalar", apiResult.ToString(), 3));

try {
MultiplyScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyScalarBySelectedScalarResult = Dummy_MultiplyScalarBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);
apiResult = MultiplyScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. MultiplyScalarBySelectedScalar

`Vector64<float> MultiplyScalarBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)`

{0}

```csharp
private Vector64<float> MultiplyScalarBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.MultiplyScalarBySelectedScalar(left, right, 0);
}}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MultiplyScalarBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MultiplyScalarBySelectedScalar(Vector64<double> left, Vector128<double> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyscalarbyselectedscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyscalarbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmuls_lane_f32).

Assembly generated:

```armasm", GetValue("MultiplyScalarBySelectedScalar", "Performs 'MultiplyScalarBySelectedScalar' operation.", 0), GetValue("MultiplyScalarBySelectedScalar", Vector64float_0.ToString(), 1), GetValue("MultiplyScalarBySelectedScalar", Vector64float_1.ToString(), 2), GetValue("MultiplyScalarBySelectedScalar", byte_0.ToString(), 3), GetValue("MultiplyScalarBySelectedScalar", apiResult.ToString(), 4));

try {
MultiplyScalarBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplySubtractResult = Dummy_MultiplySubtractTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = MultiplySubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. MultiplySubtract

`Vector64<byte> MultiplySubtract(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> MultiplySubtractTest(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplySubtract(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplySubtract(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
Vector64<int> MultiplySubtract(Vector64<int> minuend, Vector64<int> left, Vector64<int> right)
Vector64<sbyte> MultiplySubtract(Vector64<sbyte> minuend, Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> MultiplySubtract(Vector64<ushort> minuend, Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MultiplySubtract(Vector64<uint> minuend, Vector64<uint> left, Vector64<uint> right)
Vector128<byte> MultiplySubtract(Vector128<byte> minuend, Vector128<byte> left, Vector128<byte> right)
Vector128<short> MultiplySubtract(Vector128<short> minuend, Vector128<short> left, Vector128<short> right)
Vector128<int> MultiplySubtract(Vector128<int> minuend, Vector128<int> left, Vector128<int> right)
Vector128<sbyte> MultiplySubtract(Vector128<sbyte> minuend, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> MultiplySubtract(Vector128<ushort> minuend, Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> MultiplySubtract(Vector128<uint> minuend, Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplysubtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmls_u8).

Assembly generated:

```armasm", GetValue("MultiplySubtract", "Performs 'MultiplySubtract' operation.", 0), GetValue("MultiplySubtract", Vector64byte_0.ToString(), 1), GetValue("MultiplySubtract", Vector64byte_1.ToString(), 2), GetValue("MultiplySubtract", Vector64byte_2.ToString(), 3), GetValue("MultiplySubtract", apiResult.ToString(), 4));

try {
MultiplySubtractTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplySubtractByScalarResult = Dummy_MultiplySubtractByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);
apiResult = MultiplySubtractByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. MultiplySubtractByScalar

`Vector64<short> MultiplySubtractByScalar(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)`

{0}

```csharp
private Vector64<short> MultiplySubtractByScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplySubtractByScalar(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplySubtractByScalar(Vector64<int> minuend, Vector64<int> left, Vector64<int> right)
Vector64<ushort> MultiplySubtractByScalar(Vector64<ushort> minuend, Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> MultiplySubtractByScalar(Vector64<uint> minuend, Vector64<uint> left, Vector64<uint> right)
Vector128<short> MultiplySubtractByScalar(Vector128<short> minuend, Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplySubtractByScalar(Vector128<int> minuend, Vector128<int> left, Vector64<int> right)
Vector128<ushort> MultiplySubtractByScalar(Vector128<ushort> minuend, Vector128<ushort> left, Vector64<ushort> right)
Vector128<uint> MultiplySubtractByScalar(Vector128<uint> minuend, Vector128<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplysubtractbyscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmls_n_s16).

Assembly generated:

```armasm", GetValue("MultiplySubtractByScalar", "Performs 'MultiplySubtractByScalar' operation.", 0), GetValue("MultiplySubtractByScalar", Vector64short_0.ToString(), 1), GetValue("MultiplySubtractByScalar", Vector64short_1.ToString(), 2), GetValue("MultiplySubtractByScalar", Vector64short_2.ToString(), 3), GetValue("MultiplySubtractByScalar", apiResult.ToString(), 4));

try {
MultiplySubtractByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplySubtractBySelectedScalarResult = Dummy_MultiplySubtractBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);
apiResult = MultiplySubtractBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. MultiplySubtractBySelectedScalar

`Vector64<short> MultiplySubtractBySelectedScalar(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

{0}

```csharp
private Vector64<short> MultiplySubtractBySelectedScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplySubtractBySelectedScalar(minuend, left, right, 2);
}}
// minuend = {1}
// left = {2}
// right = {3}
// rightIndex = {4}
// Result = {5}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> MultiplySubtractBySelectedScalar(Vector64<short> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplySubtractBySelectedScalar(Vector64<int> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplySubtractBySelectedScalar(Vector64<int> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex)
Vector64<ushort> MultiplySubtractBySelectedScalar(Vector64<ushort> minuend, Vector64<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector64<ushort> MultiplySubtractBySelectedScalar(Vector64<ushort> minuend, Vector64<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector64<uint> MultiplySubtractBySelectedScalar(Vector64<uint> minuend, Vector64<uint> left, Vector64<uint> right, byte rightIndex)
Vector64<uint> MultiplySubtractBySelectedScalar(Vector64<uint> minuend, Vector64<uint> left, Vector128<uint> right, byte rightIndex)
Vector128<short> MultiplySubtractBySelectedScalar(Vector128<short> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
Vector128<short> MultiplySubtractBySelectedScalar(Vector128<short> minuend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<int> MultiplySubtractBySelectedScalar(Vector128<int> minuend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<int> MultiplySubtractBySelectedScalar(Vector128<int> minuend, Vector128<int> left, Vector128<int> right, byte rightIndex)
Vector128<ushort> MultiplySubtractBySelectedScalar(Vector128<ushort> minuend, Vector128<ushort> left, Vector64<ushort> right, byte rightIndex)
Vector128<ushort> MultiplySubtractBySelectedScalar(Vector128<ushort> minuend, Vector128<ushort> left, Vector128<ushort> right, byte rightIndex)
Vector128<uint> MultiplySubtractBySelectedScalar(Vector128<uint> minuend, Vector128<uint> left, Vector64<uint> right, byte rightIndex)
Vector128<uint> MultiplySubtractBySelectedScalar(Vector128<uint> minuend, Vector128<uint> left, Vector128<uint> right, byte rightIndex)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplysubtractbyselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmls_lane_s16).

Assembly generated:

```armasm", GetValue("MultiplySubtractBySelectedScalar", "Performs 'MultiplySubtractBySelectedScalar' operation.", 0), GetValue("MultiplySubtractBySelectedScalar", Vector64short_0.ToString(), 1), GetValue("MultiplySubtractBySelectedScalar", Vector64short_1.ToString(), 2), GetValue("MultiplySubtractBySelectedScalar", Vector64short_2.ToString(), 3), GetValue("MultiplySubtractBySelectedScalar", byte_0.ToString(), 4), GetValue("MultiplySubtractBySelectedScalar", apiResult.ToString(), 5));

try {
MultiplySubtractBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyWideningLowerResult = Dummy_MultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = MultiplyWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. MultiplyWideningLower

`Vector128<ushort> MultiplyWideningLower(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> MultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyWideningLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyWideningLower(Vector64<short> left, Vector64<short> right)
Vector128<long> MultiplyWideningLower(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> MultiplyWideningLower(Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> MultiplyWideningLower(Vector64<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmull_u8).

Assembly generated:

```armasm", GetValue("MultiplyWideningLower", "Performs 'MultiplyWideningLower' operation.", 0), GetValue("MultiplyWideningLower", Vector64byte_0.ToString(), 1), GetValue("MultiplyWideningLower", Vector64byte_1.ToString(), 2), GetValue("MultiplyWideningLower", apiResult.ToString(), 3));

try {
MultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyWideningLowerAndAddResult = Dummy_MultiplyWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);
apiResult = MultiplyWideningLowerAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. MultiplyWideningLowerAndAdd

`Vector128<ushort> MultiplyWideningLowerAndAdd(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> MultiplyWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyWideningLowerAndAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
Vector128<long> MultiplyWideningLowerAndAdd(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyWideningLowerAndAdd(Vector128<short> addend, Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> MultiplyWideningLowerAndAdd(Vector128<uint> addend, Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> MultiplyWideningLowerAndAdd(Vector128<ulong> addend, Vector64<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideninglowerandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlal_u8).

Assembly generated:

```armasm", GetValue("MultiplyWideningLowerAndAdd", "Performs 'MultiplyWideningLowerAndAdd' operation.", 0), GetValue("MultiplyWideningLowerAndAdd", Vector128ushort_0.ToString(), 1), GetValue("MultiplyWideningLowerAndAdd", Vector64byte_0.ToString(), 2), GetValue("MultiplyWideningLowerAndAdd", Vector64byte_1.ToString(), 3), GetValue("MultiplyWideningLowerAndAdd", apiResult.ToString(), 4));

try {
MultiplyWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 6
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 6 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[MultiplyWideningLowerAndSubtract](#1-multiplywideninglowerandsubtract), [MultiplyWideningUpper](#2-multiplywideningupper), [MultiplyWideningUpperAndAdd](#3-multiplywideningupperandadd), [MultiplyWideningUpperAndSubtract](#4-multiplywideningupperandsubtract), [Negate](#5-negate), [NegateSaturate](#6-negatesaturate), [NegateSaturateScalar](#7-negatesaturatescalar), [NegateScalar](#8-negatescalar), [Not](#9-not), [Or](#10-or), [OrNot](#11-ornot), [PolynomialMultiply](#12-polynomialmultiply), [PolynomialMultiplyWideningLower](#13-polynomialmultiplywideninglower), [PolynomialMultiplyWideningUpper](#14-polynomialmultiplywideningupper), [PopCount](#15-popcount), [ReciprocalEstimate](#16-reciprocalestimate), [ReciprocalEstimateScalar](#17-reciprocalestimatescalar), [ReciprocalExponentScalar](#18-reciprocalexponentscalar), [ReciprocalSquareRootEstimate](#19-reciprocalsquarerootestimate), [ReciprocalSquareRootEstimateScalar](#20-reciprocalsquarerootestimatescalar), [ReciprocalSquareRootStep](#21-reciprocalsquarerootstep), [ReciprocalSquareRootStepScalar](#22-reciprocalsquarerootstepscalar), [ReciprocalStep](#23-reciprocalstep), [ReciprocalStepScalar](#24-reciprocalstepscalar), [ReverseElement16](#25-reverseelement16), [ReverseElement32](#26-reverseelement32), [ReverseElement8](#27-reverseelement8), [ReverseElementBits](#28-reverseelementbits), [RoundAwayFromZero](#29-roundawayfromzero), [RoundAwayFromZeroScalar](#30-roundawayfromzeroscalar), [RoundToNearest](#31-roundtonearest), [RoundToNearestScalar](#32-roundtonearestscalar), [RoundToNegativeInfinity](#33-roundtonegativeinfinity), [RoundToNegativeInfinityScalar](#34-roundtonegativeinfinityscalar), [RoundToPositiveInfinity](#35-roundtopositiveinfinity), [RoundToPositiveInfinityScalar](#36-roundtopositiveinfinityscalar), [RoundToZero](#37-roundtozero), [RoundToZeroScalar](#38-roundtozeroscalar), [ShiftArithmetic](#39-shiftarithmetic), [ShiftArithmeticRounded](#40-shiftarithmeticrounded), [ShiftArithmeticRoundedSaturate](#41-shiftarithmeticroundedsaturate), [ShiftArithmeticRoundedSaturateScalar](#42-shiftarithmeticroundedsaturatescalar), [ShiftArithmeticRoundedScalar](#43-shiftarithmeticroundedscalar), [ShiftArithmeticSaturate](#44-shiftarithmeticsaturate), [ShiftArithmeticSaturateScalar](#45-shiftarithmeticsaturatescalar)


");

try {
var MultiplyWideningLowerAndSubtractResult = Dummy_MultiplyWideningLowerAndSubtractTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);
apiResult = MultiplyWideningLowerAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. MultiplyWideningLowerAndSubtract

`Vector128<ushort> MultiplyWideningLowerAndSubtract(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> MultiplyWideningLowerAndSubtractTest(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyWideningLowerAndSubtract(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
Vector128<long> MultiplyWideningLowerAndSubtract(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyWideningLowerAndSubtract(Vector128<short> minuend, Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> MultiplyWideningLowerAndSubtract(Vector128<uint> minuend, Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> MultiplyWideningLowerAndSubtract(Vector128<ulong> minuend, Vector64<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideninglowerandsubtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlsl_u8).

Assembly generated:

```armasm", GetValue("MultiplyWideningLowerAndSubtract", "Performs 'MultiplyWideningLowerAndSubtract' operation.", 0), GetValue("MultiplyWideningLowerAndSubtract", Vector128ushort_0.ToString(), 1), GetValue("MultiplyWideningLowerAndSubtract", Vector64byte_0.ToString(), 2), GetValue("MultiplyWideningLowerAndSubtract", Vector64byte_1.ToString(), 3), GetValue("MultiplyWideningLowerAndSubtract", apiResult.ToString(), 4));

try {
MultiplyWideningLowerAndSubtractTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyWideningUpperResult = Dummy_MultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = MultiplyWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. MultiplyWideningUpper

`Vector128<ushort> MultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> MultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.MultiplyWideningUpper(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyWideningUpper(Vector128<short> left, Vector128<short> right)
Vector128<long> MultiplyWideningUpper(Vector128<int> left, Vector128<int> right)
Vector128<short> MultiplyWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<uint> MultiplyWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
Vector128<ulong> MultiplyWideningUpper(Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmull_high_u8).

Assembly generated:

```armasm", GetValue("MultiplyWideningUpper", "Performs 'MultiplyWideningUpper' operation.", 0), GetValue("MultiplyWideningUpper", Vector128byte_0.ToString(), 1), GetValue("MultiplyWideningUpper", Vector128byte_1.ToString(), 2), GetValue("MultiplyWideningUpper", apiResult.ToString(), 3));

try {
MultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyWideningUpperAndAddResult = Dummy_MultiplyWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);
apiResult = MultiplyWideningUpperAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. MultiplyWideningUpperAndAdd

`Vector128<ushort> MultiplyWideningUpperAndAdd(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> MultiplyWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.MultiplyWideningUpperAndAdd(addend, left, right);
}}
// addend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
Vector128<long> MultiplyWideningUpperAndAdd(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
Vector128<short> MultiplyWideningUpperAndAdd(Vector128<short> addend, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<uint> MultiplyWideningUpperAndAdd(Vector128<uint> addend, Vector128<ushort> left, Vector128<ushort> right)
Vector128<ulong> MultiplyWideningUpperAndAdd(Vector128<ulong> addend, Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideningupperandadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlal_high_u8).

Assembly generated:

```armasm", GetValue("MultiplyWideningUpperAndAdd", "Performs 'MultiplyWideningUpperAndAdd' operation.", 0), GetValue("MultiplyWideningUpperAndAdd", Vector128ushort_0.ToString(), 1), GetValue("MultiplyWideningUpperAndAdd", Vector128byte_0.ToString(), 2), GetValue("MultiplyWideningUpperAndAdd", Vector128byte_1.ToString(), 3), GetValue("MultiplyWideningUpperAndAdd", apiResult.ToString(), 4));

try {
MultiplyWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var MultiplyWideningUpperAndSubtractResult = Dummy_MultiplyWideningUpperAndSubtractTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);
apiResult = MultiplyWideningUpperAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. MultiplyWideningUpperAndSubtract

`Vector128<ushort> MultiplyWideningUpperAndSubtract(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> MultiplyWideningUpperAndSubtractTest(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.MultiplyWideningUpperAndSubtract(minuend, left, right);
}}
// minuend = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
Vector128<long> MultiplyWideningUpperAndSubtract(Vector128<long> minuend, Vector128<int> left, Vector128<int> right)
Vector128<short> MultiplyWideningUpperAndSubtract(Vector128<short> minuend, Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<uint> MultiplyWideningUpperAndSubtract(Vector128<uint> minuend, Vector128<ushort> left, Vector128<ushort> right)
Vector128<ulong> MultiplyWideningUpperAndSubtract(Vector128<ulong> minuend, Vector128<uint> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideningupperandsubtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmlsl_high_u8).

Assembly generated:

```armasm", GetValue("MultiplyWideningUpperAndSubtract", "Performs 'MultiplyWideningUpperAndSubtract' operation.", 0), GetValue("MultiplyWideningUpperAndSubtract", Vector128ushort_0.ToString(), 1), GetValue("MultiplyWideningUpperAndSubtract", Vector128byte_0.ToString(), 2), GetValue("MultiplyWideningUpperAndSubtract", Vector128byte_1.ToString(), 3), GetValue("MultiplyWideningUpperAndSubtract", apiResult.ToString(), 4));

try {
MultiplyWideningUpperAndSubtractTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var NegateResult = Dummy_NegateTest(Vector64short_0);
apiResult = NegateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. Negate

`Vector64<short> Negate(Vector64<short> value)`

{0}

```csharp
private Vector64<short> NegateTest(Vector64<short> value)
{{
  return AdvSimd.Negate(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> Negate(Vector64<int> value)
Vector64<sbyte> Negate(Vector64<sbyte> value)
Vector64<float> Negate(Vector64<float> value)
Vector128<short> Negate(Vector128<short> value)
Vector128<int> Negate(Vector128<int> value)
Vector128<sbyte> Negate(Vector128<sbyte> value)
Vector128<float> Negate(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Negate(Vector128<double> value)
Vector128<long> Negate(Vector128<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.negate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vneg_s16).

Assembly generated:

```armasm", GetValue("Negate", "Performs 'Negate' operation.", 0), GetValue("Negate", Vector64short_0.ToString(), 1), GetValue("Negate", apiResult.ToString(), 2));

try {
NegateTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var NegateSaturateResult = Dummy_NegateSaturateTest(Vector64short_0);
apiResult = NegateSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. NegateSaturate

`Vector64<short> NegateSaturate(Vector64<short> value)`

{0}

```csharp
private Vector64<short> NegateSaturateTest(Vector64<short> value)
{{
  return AdvSimd.NegateSaturate(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> NegateSaturate(Vector64<int> value)
Vector64<sbyte> NegateSaturate(Vector64<sbyte> value)
Vector128<short> NegateSaturate(Vector128<short> value)
Vector128<int> NegateSaturate(Vector128<int> value)
Vector128<sbyte> NegateSaturate(Vector128<sbyte> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<long> NegateSaturate(Vector128<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.negatesaturate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negatesaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqneg_s16).

Assembly generated:

```armasm", GetValue("NegateSaturate", "Performs 'NegateSaturate' operation.", 0), GetValue("NegateSaturate", Vector64short_0.ToString(), 1), GetValue("NegateSaturate", apiResult.ToString(), 2));

try {
NegateSaturateTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var NegateSaturateScalarResult = Dummy_NegateSaturateScalarTest(Vector64short_0);
apiResult = NegateSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. NegateSaturateScalar

`Vector64<short> NegateSaturateScalar(Vector64<short> value)`

{0}

```csharp
private Vector64<short> NegateSaturateScalarTest(Vector64<short> value)
{{
  return AdvSimd.Arm64.NegateSaturateScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> NegateSaturateScalar(Vector64<int> value)
Vector64<long> NegateSaturateScalar(Vector64<long> value)
Vector64<sbyte> NegateSaturateScalar(Vector64<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negatesaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqnegh_s16).

Assembly generated:

```armasm", GetValue("NegateSaturateScalar", "Performs 'NegateSaturateScalar' operation.", 0), GetValue("NegateSaturateScalar", Vector64short_0.ToString(), 1), GetValue("NegateSaturateScalar", apiResult.ToString(), 2));

try {
NegateSaturateScalarTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var NegateScalarResult = Dummy_NegateScalarTest(Vector64double_0);
apiResult = NegateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. NegateScalar

`Vector64<double> NegateScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> NegateScalarTest(Vector64<double> value)
{{
  return AdvSimd.NegateScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> NegateScalar(Vector64<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> NegateScalar(Vector64<long> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.negatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vneg_f64).

Assembly generated:

```armasm", GetValue("NegateScalar", "Performs 'NegateScalar' operation.", 0), GetValue("NegateScalar", Vector64double_0.ToString(), 1), GetValue("NegateScalar", apiResult.ToString(), 2));

try {
NegateScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var NotResult = Dummy_NotTest(Vector64byte_0);
apiResult = NotResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. Not

`Vector64<byte> Not(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> NotTest(Vector64<byte> value)
{{
  return AdvSimd.Not(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> Not(Vector64<double> value)
Vector64<short> Not(Vector64<short> value)
Vector64<int> Not(Vector64<int> value)
Vector64<long> Not(Vector64<long> value)
Vector64<sbyte> Not(Vector64<sbyte> value)
Vector64<float> Not(Vector64<float> value)
Vector64<ushort> Not(Vector64<ushort> value)
Vector64<uint> Not(Vector64<uint> value)
Vector64<ulong> Not(Vector64<ulong> value)
Vector128<byte> Not(Vector128<byte> value)
Vector128<double> Not(Vector128<double> value)
Vector128<short> Not(Vector128<short> value)
Vector128<int> Not(Vector128<int> value)
Vector128<long> Not(Vector128<long> value)
Vector128<sbyte> Not(Vector128<sbyte> value)
Vector128<float> Not(Vector128<float> value)
Vector128<ushort> Not(Vector128<ushort> value)
Vector128<uint> Not(Vector128<uint> value)
Vector128<ulong> Not(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.not?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmvn_u8).

Assembly generated:

```armasm", GetValue("Not", "Performs 'Not' operation.", 0), GetValue("Not", Vector64byte_0.ToString(), 1), GetValue("Not", apiResult.ToString(), 2));

try {
NotTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var OrResult = Dummy_OrTest(Vector64byte_0, Vector64byte_1);
apiResult = OrResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. Or

`Vector64<byte> Or(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> OrTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Or(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> Or(Vector64<double> left, Vector64<double> right)
Vector64<short> Or(Vector64<short> left, Vector64<short> right)
Vector64<int> Or(Vector64<int> left, Vector64<int> right)
Vector64<long> Or(Vector64<long> left, Vector64<long> right)
Vector64<sbyte> Or(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Or(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Or(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Or(Vector64<uint> left, Vector64<uint> right)
Vector64<ulong> Or(Vector64<ulong> left, Vector64<ulong> right)
Vector128<byte> Or(Vector128<byte> left, Vector128<byte> right)
Vector128<double> Or(Vector128<double> left, Vector128<double> right)
Vector128<short> Or(Vector128<short> left, Vector128<short> right)
Vector128<int> Or(Vector128<int> left, Vector128<int> right)
Vector128<long> Or(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> Or(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Or(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Or(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Or(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> Or(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.or?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vorr_u8).

Assembly generated:

```armasm", GetValue("Or", "Performs 'Or' operation.", 0), GetValue("Or", Vector64byte_0.ToString(), 1), GetValue("Or", Vector64byte_1.ToString(), 2), GetValue("Or", apiResult.ToString(), 3));

try {
OrTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var OrNotResult = Dummy_OrNotTest(Vector64byte_0, Vector64byte_1);
apiResult = OrNotResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. OrNot

`Vector64<byte> OrNot(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> OrNotTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.OrNot(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> OrNot(Vector64<double> left, Vector64<double> right)
Vector64<short> OrNot(Vector64<short> left, Vector64<short> right)
Vector64<int> OrNot(Vector64<int> left, Vector64<int> right)
Vector64<long> OrNot(Vector64<long> left, Vector64<long> right)
Vector64<sbyte> OrNot(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> OrNot(Vector64<float> left, Vector64<float> right)
Vector64<ushort> OrNot(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> OrNot(Vector64<uint> left, Vector64<uint> right)
Vector64<ulong> OrNot(Vector64<ulong> left, Vector64<ulong> right)
Vector128<byte> OrNot(Vector128<byte> left, Vector128<byte> right)
Vector128<double> OrNot(Vector128<double> left, Vector128<double> right)
Vector128<short> OrNot(Vector128<short> left, Vector128<short> right)
Vector128<int> OrNot(Vector128<int> left, Vector128<int> right)
Vector128<long> OrNot(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> OrNot(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> OrNot(Vector128<float> left, Vector128<float> right)
Vector128<ushort> OrNot(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> OrNot(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> OrNot(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.ornot?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vorn_u8).

Assembly generated:

```armasm", GetValue("OrNot", "Performs 'OrNot' operation.", 0), GetValue("OrNot", Vector64byte_0.ToString(), 1), GetValue("OrNot", Vector64byte_1.ToString(), 2), GetValue("OrNot", apiResult.ToString(), 3));

try {
OrNotTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var PolynomialMultiplyResult = Dummy_PolynomialMultiplyTest(Vector64byte_0, Vector64byte_1);
apiResult = PolynomialMultiplyResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. PolynomialMultiply

`Vector64<byte> PolynomialMultiply(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> PolynomialMultiplyTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.PolynomialMultiply(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> PolynomialMultiply(Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<byte> PolynomialMultiply(Vector128<byte> left, Vector128<byte> right)
Vector128<sbyte> PolynomialMultiply(Vector128<sbyte> left, Vector128<sbyte> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.polynomialmultiply?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmul_p8).

Assembly generated:

```armasm", GetValue("PolynomialMultiply", "Performs 'PolynomialMultiply' operation.", 0), GetValue("PolynomialMultiply", Vector64byte_0.ToString(), 1), GetValue("PolynomialMultiply", Vector64byte_1.ToString(), 2), GetValue("PolynomialMultiply", apiResult.ToString(), 3));

try {
PolynomialMultiplyTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var PolynomialMultiplyWideningLowerResult = Dummy_PolynomialMultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = PolynomialMultiplyWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. PolynomialMultiplyWideningLower

`Vector128<ushort> PolynomialMultiplyWideningLower(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> PolynomialMultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.PolynomialMultiplyWideningLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> PolynomialMultiplyWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.polynomialmultiplywideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmull_p8).

Assembly generated:

```armasm", GetValue("PolynomialMultiplyWideningLower", "Performs 'PolynomialMultiplyWideningLower' operation.", 0), GetValue("PolynomialMultiplyWideningLower", Vector64byte_0.ToString(), 1), GetValue("PolynomialMultiplyWideningLower", Vector64byte_1.ToString(), 2), GetValue("PolynomialMultiplyWideningLower", apiResult.ToString(), 3));

try {
PolynomialMultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var PolynomialMultiplyWideningUpperResult = Dummy_PolynomialMultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = PolynomialMultiplyWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. PolynomialMultiplyWideningUpper

`Vector128<ushort> PolynomialMultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> PolynomialMultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.PolynomialMultiplyWideningUpper(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> PolynomialMultiplyWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.polynomialmultiplywideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmull_high_p8).

Assembly generated:

```armasm", GetValue("PolynomialMultiplyWideningUpper", "Performs 'PolynomialMultiplyWideningUpper' operation.", 0), GetValue("PolynomialMultiplyWideningUpper", Vector128byte_0.ToString(), 1), GetValue("PolynomialMultiplyWideningUpper", Vector128byte_1.ToString(), 2), GetValue("PolynomialMultiplyWideningUpper", apiResult.ToString(), 3));

try {
PolynomialMultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var PopCountResult = Dummy_PopCountTest(Vector64byte_0);
apiResult = PopCountResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. PopCount

`Vector64<byte> PopCount(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> PopCountTest(Vector64<byte> value)
{{
  return AdvSimd.PopCount(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> PopCount(Vector64<sbyte> value)
Vector128<byte> PopCount(Vector128<byte> value)
Vector128<sbyte> PopCount(Vector128<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.popcount?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vcnt_u8).

Assembly generated:

```armasm", GetValue("PopCount", "Performs 'PopCount' operation.", 0), GetValue("PopCount", Vector64byte_0.ToString(), 1), GetValue("PopCount", apiResult.ToString(), 2));

try {
PopCountTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalEstimateResult = Dummy_ReciprocalEstimateTest(Vector64float_0);
apiResult = ReciprocalEstimateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. ReciprocalEstimate

`Vector64<float> ReciprocalEstimate(Vector64<float> value)`

{0}

```csharp
private Vector64<float> ReciprocalEstimateTest(Vector64<float> value)
{{
  return AdvSimd.ReciprocalEstimate(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<uint> ReciprocalEstimate(Vector64<uint> value)
Vector128<float> ReciprocalEstimate(Vector128<float> value)
Vector128<uint> ReciprocalEstimate(Vector128<uint> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ReciprocalEstimate(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalestimate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalestimate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrecpe_f32).

Assembly generated:

```armasm", GetValue("ReciprocalEstimate", "Performs 'ReciprocalEstimate' operation.", 0), GetValue("ReciprocalEstimate", Vector64float_0.ToString(), 1), GetValue("ReciprocalEstimate", apiResult.ToString(), 2));

try {
ReciprocalEstimateTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalEstimateScalarResult = Dummy_ReciprocalEstimateScalarTest(Vector64double_0);
apiResult = ReciprocalEstimateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. ReciprocalEstimateScalar

`Vector64<double> ReciprocalEstimateScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> ReciprocalEstimateScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ReciprocalEstimateScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalEstimateScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalestimatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrecpe_f64).

Assembly generated:

```armasm", GetValue("ReciprocalEstimateScalar", "Performs 'ReciprocalEstimateScalar' operation.", 0), GetValue("ReciprocalEstimateScalar", Vector64double_0.ToString(), 1), GetValue("ReciprocalEstimateScalar", apiResult.ToString(), 2));

try {
ReciprocalEstimateScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalExponentScalarResult = Dummy_ReciprocalExponentScalarTest(Vector64double_0);
apiResult = ReciprocalExponentScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. ReciprocalExponentScalar

`Vector64<double> ReciprocalExponentScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> ReciprocalExponentScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ReciprocalExponentScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalExponentScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalexponentscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrecpxd_f64).

Assembly generated:

```armasm", GetValue("ReciprocalExponentScalar", "Performs 'ReciprocalExponentScalar' operation.", 0), GetValue("ReciprocalExponentScalar", Vector64double_0.ToString(), 1), GetValue("ReciprocalExponentScalar", apiResult.ToString(), 2));

try {
ReciprocalExponentScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalSquareRootEstimateResult = Dummy_ReciprocalSquareRootEstimateTest(Vector64float_0);
apiResult = ReciprocalSquareRootEstimateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. ReciprocalSquareRootEstimate

`Vector64<float> ReciprocalSquareRootEstimate(Vector64<float> value)`

{0}

```csharp
private Vector64<float> ReciprocalSquareRootEstimateTest(Vector64<float> value)
{{
  return AdvSimd.ReciprocalSquareRootEstimate(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<uint> ReciprocalSquareRootEstimate(Vector64<uint> value)
Vector128<float> ReciprocalSquareRootEstimate(Vector128<float> value)
Vector128<uint> ReciprocalSquareRootEstimate(Vector128<uint> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ReciprocalSquareRootEstimate(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalsquarerootestimate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootestimate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsqrte_f32).

Assembly generated:

```armasm", GetValue("ReciprocalSquareRootEstimate", "Performs 'ReciprocalSquareRootEstimate' operation.", 0), GetValue("ReciprocalSquareRootEstimate", Vector64float_0.ToString(), 1), GetValue("ReciprocalSquareRootEstimate", apiResult.ToString(), 2));

try {
ReciprocalSquareRootEstimateTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalSquareRootEstimateScalarResult = Dummy_ReciprocalSquareRootEstimateScalarTest(Vector64double_0);
apiResult = ReciprocalSquareRootEstimateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. ReciprocalSquareRootEstimateScalar

`Vector64<double> ReciprocalSquareRootEstimateScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> ReciprocalSquareRootEstimateScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ReciprocalSquareRootEstimateScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalSquareRootEstimateScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootestimatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsqrte_f64).

Assembly generated:

```armasm", GetValue("ReciprocalSquareRootEstimateScalar", "Performs 'ReciprocalSquareRootEstimateScalar' operation.", 0), GetValue("ReciprocalSquareRootEstimateScalar", Vector64double_0.ToString(), 1), GetValue("ReciprocalSquareRootEstimateScalar", apiResult.ToString(), 2));

try {
ReciprocalSquareRootEstimateScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalSquareRootStepResult = Dummy_ReciprocalSquareRootStepTest(Vector64float_0, Vector64float_1);
apiResult = ReciprocalSquareRootStepResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. ReciprocalSquareRootStep

`Vector64<float> ReciprocalSquareRootStep(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> ReciprocalSquareRootStepTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.ReciprocalSquareRootStep(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> ReciprocalSquareRootStep(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ReciprocalSquareRootStep(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalsquarerootstep?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootstep?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsqrts_f32).

Assembly generated:

```armasm", GetValue("ReciprocalSquareRootStep", "Performs 'ReciprocalSquareRootStep' operation.", 0), GetValue("ReciprocalSquareRootStep", Vector64float_0.ToString(), 1), GetValue("ReciprocalSquareRootStep", Vector64float_1.ToString(), 2), GetValue("ReciprocalSquareRootStep", apiResult.ToString(), 3));

try {
ReciprocalSquareRootStepTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalSquareRootStepScalarResult = Dummy_ReciprocalSquareRootStepScalarTest(Vector64double_0, Vector64double_1);
apiResult = ReciprocalSquareRootStepScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. ReciprocalSquareRootStepScalar

`Vector64<double> ReciprocalSquareRootStepScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> ReciprocalSquareRootStepScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.ReciprocalSquareRootStepScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalSquareRootStepScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootstepscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsqrts_f64).

Assembly generated:

```armasm", GetValue("ReciprocalSquareRootStepScalar", "Performs 'ReciprocalSquareRootStepScalar' operation.", 0), GetValue("ReciprocalSquareRootStepScalar", Vector64double_0.ToString(), 1), GetValue("ReciprocalSquareRootStepScalar", Vector64double_1.ToString(), 2), GetValue("ReciprocalSquareRootStepScalar", apiResult.ToString(), 3));

try {
ReciprocalSquareRootStepScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalStepResult = Dummy_ReciprocalStepTest(Vector64float_0, Vector64float_1);
apiResult = ReciprocalStepResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. ReciprocalStep

`Vector64<float> ReciprocalStep(Vector64<float> left, Vector64<float> right)`

{0}

```csharp
private Vector64<float> ReciprocalStepTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.ReciprocalStep(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> ReciprocalStep(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ReciprocalStep(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalstep?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalstep?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrecps_f32).

Assembly generated:

```armasm", GetValue("ReciprocalStep", "Performs 'ReciprocalStep' operation.", 0), GetValue("ReciprocalStep", Vector64float_0.ToString(), 1), GetValue("ReciprocalStep", Vector64float_1.ToString(), 2), GetValue("ReciprocalStep", apiResult.ToString(), 3));

try {
ReciprocalStepTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReciprocalStepScalarResult = Dummy_ReciprocalStepScalarTest(Vector64double_0, Vector64double_1);
apiResult = ReciprocalStepScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. ReciprocalStepScalar

`Vector64<double> ReciprocalStepScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> ReciprocalStepScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.ReciprocalStepScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalStepScalar(Vector64<float> left, Vector64<float> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalstepscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrecps_f64).

Assembly generated:

```armasm", GetValue("ReciprocalStepScalar", "Performs 'ReciprocalStepScalar' operation.", 0), GetValue("ReciprocalStepScalar", Vector64double_0.ToString(), 1), GetValue("ReciprocalStepScalar", Vector64double_1.ToString(), 2), GetValue("ReciprocalStepScalar", apiResult.ToString(), 3));

try {
ReciprocalStepScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReverseElement16Result = Dummy_ReverseElement16Test(Vector64int_0);
apiResult = ReverseElement16Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. ReverseElement16

`Vector64<int> ReverseElement16(Vector64<int> value)`

{0}

```csharp
private Vector64<int> ReverseElement16Test(Vector64<int> value)
{{
  return AdvSimd.ReverseElement16(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<long> ReverseElement16(Vector64<long> value)
Vector64<uint> ReverseElement16(Vector64<uint> value)
Vector64<ulong> ReverseElement16(Vector64<ulong> value)
Vector128<int> ReverseElement16(Vector128<int> value)
Vector128<long> ReverseElement16(Vector128<long> value)
Vector128<uint> ReverseElement16(Vector128<uint> value)
Vector128<ulong> ReverseElement16(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reverseelement16?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrev32_s16).

Assembly generated:

```armasm", GetValue("ReverseElement16", "Performs 'ReverseElement16' operation.", 0), GetValue("ReverseElement16", Vector64int_0.ToString(), 1), GetValue("ReverseElement16", apiResult.ToString(), 2));

try {
ReverseElement16Test(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReverseElement32Result = Dummy_ReverseElement32Test(Vector64long_0);
apiResult = ReverseElement32Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. ReverseElement32

`Vector64<long> ReverseElement32(Vector64<long> value)`

{0}

```csharp
private Vector64<long> ReverseElement32Test(Vector64<long> value)
{{
  return AdvSimd.ReverseElement32(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ReverseElement32(Vector64<ulong> value)
Vector128<long> ReverseElement32(Vector128<long> value)
Vector128<ulong> ReverseElement32(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reverseelement32?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrev64_s32).

Assembly generated:

```armasm", GetValue("ReverseElement32", "Performs 'ReverseElement32' operation.", 0), GetValue("ReverseElement32", Vector64long_0.ToString(), 1), GetValue("ReverseElement32", apiResult.ToString(), 2));

try {
ReverseElement32Test(Vector64long_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReverseElement8Result = Dummy_ReverseElement8Test(Vector64short_0);
apiResult = ReverseElement8Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. ReverseElement8

`Vector64<short> ReverseElement8(Vector64<short> value)`

{0}

```csharp
private Vector64<short> ReverseElement8Test(Vector64<short> value)
{{
  return AdvSimd.ReverseElement8(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ReverseElement8(Vector64<int> value)
Vector64<long> ReverseElement8(Vector64<long> value)
Vector64<ushort> ReverseElement8(Vector64<ushort> value)
Vector64<uint> ReverseElement8(Vector64<uint> value)
Vector64<ulong> ReverseElement8(Vector64<ulong> value)
Vector128<short> ReverseElement8(Vector128<short> value)
Vector128<int> ReverseElement8(Vector128<int> value)
Vector128<long> ReverseElement8(Vector128<long> value)
Vector128<ushort> ReverseElement8(Vector128<ushort> value)
Vector128<uint> ReverseElement8(Vector128<uint> value)
Vector128<ulong> ReverseElement8(Vector128<ulong> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reverseelement8?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrev16_s8).

Assembly generated:

```armasm", GetValue("ReverseElement8", "Performs 'ReverseElement8' operation.", 0), GetValue("ReverseElement8", Vector64short_0.ToString(), 1), GetValue("ReverseElement8", apiResult.ToString(), 2));

try {
ReverseElement8Test(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ReverseElementBitsResult = Dummy_ReverseElementBitsTest(Vector64byte_0);
apiResult = ReverseElementBitsResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. ReverseElementBits

`Vector64<byte> ReverseElementBits(Vector64<byte> value)`

{0}

```csharp
private Vector64<byte> ReverseElementBitsTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.ReverseElementBits(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<sbyte> ReverseElementBits(Vector64<sbyte> value)
Vector128<byte> ReverseElementBits(Vector128<byte> value)
Vector128<sbyte> ReverseElementBits(Vector128<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reverseelementbits?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrbit_u8).

Assembly generated:

```armasm", GetValue("ReverseElementBits", "Performs 'ReverseElementBits' operation.", 0), GetValue("ReverseElementBits", Vector64byte_0.ToString(), 1), GetValue("ReverseElementBits", apiResult.ToString(), 2));

try {
ReverseElementBitsTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundAwayFromZeroResult = Dummy_RoundAwayFromZeroTest(Vector64float_0);
apiResult = RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. RoundAwayFromZero

`Vector64<float> RoundAwayFromZero(Vector64<float> value)`

{0}

```csharp
private Vector64<float> RoundAwayFromZeroTest(Vector64<float> value)
{{
  return AdvSimd.RoundAwayFromZero(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundAwayFromZero(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundAwayFromZero(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundawayfromzero?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundawayfromzero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrnda_f32).

Assembly generated:

```armasm", GetValue("RoundAwayFromZero", "Performs 'RoundAwayFromZero' operation.", 0), GetValue("RoundAwayFromZero", Vector64float_0.ToString(), 1), GetValue("RoundAwayFromZero", apiResult.ToString(), 2));

try {
RoundAwayFromZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundAwayFromZeroScalarResult = Dummy_RoundAwayFromZeroScalarTest(Vector64double_0);
apiResult = RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. RoundAwayFromZeroScalar

`Vector64<double> RoundAwayFromZeroScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> RoundAwayFromZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundAwayFromZeroScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundAwayFromZeroScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundawayfromzeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrnda_f64).

Assembly generated:

```armasm", GetValue("RoundAwayFromZeroScalar", "Performs 'RoundAwayFromZeroScalar' operation.", 0), GetValue("RoundAwayFromZeroScalar", Vector64double_0.ToString(), 1), GetValue("RoundAwayFromZeroScalar", apiResult.ToString(), 2));

try {
RoundAwayFromZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToNearestResult = Dummy_RoundToNearestTest(Vector64float_0);
apiResult = RoundToNearestResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. RoundToNearest

`Vector64<float> RoundToNearest(Vector64<float> value)`

{0}

```csharp
private Vector64<float> RoundToNearestTest(Vector64<float> value)
{{
  return AdvSimd.RoundToNearest(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToNearest(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToNearest(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonearest?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtonearest?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndn_f32).

Assembly generated:

```armasm", GetValue("RoundToNearest", "Performs 'RoundToNearest' operation.", 0), GetValue("RoundToNearest", Vector64float_0.ToString(), 1), GetValue("RoundToNearest", apiResult.ToString(), 2));

try {
RoundToNearestTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToNearestScalarResult = Dummy_RoundToNearestScalarTest(Vector64double_0);
apiResult = RoundToNearestScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. RoundToNearestScalar

`Vector64<double> RoundToNearestScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> RoundToNearestScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToNearestScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToNearestScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonearestscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndn_f64).

Assembly generated:

```armasm", GetValue("RoundToNearestScalar", "Performs 'RoundToNearestScalar' operation.", 0), GetValue("RoundToNearestScalar", Vector64double_0.ToString(), 1), GetValue("RoundToNearestScalar", apiResult.ToString(), 2));

try {
RoundToNearestScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToNegativeInfinityResult = Dummy_RoundToNegativeInfinityTest(Vector64float_0);
apiResult = RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. RoundToNegativeInfinity

`Vector64<float> RoundToNegativeInfinity(Vector64<float> value)`

{0}

```csharp
private Vector64<float> RoundToNegativeInfinityTest(Vector64<float> value)
{{
  return AdvSimd.RoundToNegativeInfinity(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToNegativeInfinity(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToNegativeInfinity(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonegativeinfinity?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtonegativeinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndm_f32).

Assembly generated:

```armasm", GetValue("RoundToNegativeInfinity", "Performs 'RoundToNegativeInfinity' operation.", 0), GetValue("RoundToNegativeInfinity", Vector64float_0.ToString(), 1), GetValue("RoundToNegativeInfinity", apiResult.ToString(), 2));

try {
RoundToNegativeInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToNegativeInfinityScalarResult = Dummy_RoundToNegativeInfinityScalarTest(Vector64double_0);
apiResult = RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. RoundToNegativeInfinityScalar

`Vector64<double> RoundToNegativeInfinityScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> RoundToNegativeInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToNegativeInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToNegativeInfinityScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonegativeinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndm_f64).

Assembly generated:

```armasm", GetValue("RoundToNegativeInfinityScalar", "Performs 'RoundToNegativeInfinityScalar' operation.", 0), GetValue("RoundToNegativeInfinityScalar", Vector64double_0.ToString(), 1), GetValue("RoundToNegativeInfinityScalar", apiResult.ToString(), 2));

try {
RoundToNegativeInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToPositiveInfinityResult = Dummy_RoundToPositiveInfinityTest(Vector64float_0);
apiResult = RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. RoundToPositiveInfinity

`Vector64<float> RoundToPositiveInfinity(Vector64<float> value)`

{0}

```csharp
private Vector64<float> RoundToPositiveInfinityTest(Vector64<float> value)
{{
  return AdvSimd.RoundToPositiveInfinity(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToPositiveInfinity(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToPositiveInfinity(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtopositiveinfinity?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtopositiveinfinity?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndp_f32).

Assembly generated:

```armasm", GetValue("RoundToPositiveInfinity", "Performs 'RoundToPositiveInfinity' operation.", 0), GetValue("RoundToPositiveInfinity", Vector64float_0.ToString(), 1), GetValue("RoundToPositiveInfinity", apiResult.ToString(), 2));

try {
RoundToPositiveInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToPositiveInfinityScalarResult = Dummy_RoundToPositiveInfinityScalarTest(Vector64double_0);
apiResult = RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. RoundToPositiveInfinityScalar

`Vector64<double> RoundToPositiveInfinityScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> RoundToPositiveInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToPositiveInfinityScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToPositiveInfinityScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtopositiveinfinityscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrndp_f64).

Assembly generated:

```armasm", GetValue("RoundToPositiveInfinityScalar", "Performs 'RoundToPositiveInfinityScalar' operation.", 0), GetValue("RoundToPositiveInfinityScalar", Vector64double_0.ToString(), 1), GetValue("RoundToPositiveInfinityScalar", apiResult.ToString(), 2));

try {
RoundToPositiveInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToZeroResult = Dummy_RoundToZeroTest(Vector64float_0);
apiResult = RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. RoundToZero

`Vector64<float> RoundToZero(Vector64<float> value)`

{0}

```csharp
private Vector64<float> RoundToZeroTest(Vector64<float> value)
{{
  return AdvSimd.RoundToZero(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToZero(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToZero(Vector128<double> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtozero?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtozero?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrnd_f32).

Assembly generated:

```armasm", GetValue("RoundToZero", "Performs 'RoundToZero' operation.", 0), GetValue("RoundToZero", Vector64float_0.ToString(), 1), GetValue("RoundToZero", apiResult.ToString(), 2));

try {
RoundToZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var RoundToZeroScalarResult = Dummy_RoundToZeroScalarTest(Vector64double_0);
apiResult = RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. RoundToZeroScalar

`Vector64<double> RoundToZeroScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> RoundToZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToZeroScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToZeroScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtozeroscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrnd_f64).

Assembly generated:

```armasm", GetValue("RoundToZeroScalar", "Performs 'RoundToZeroScalar' operation.", 0), GetValue("RoundToZeroScalar", Vector64double_0.ToString(), 1), GetValue("RoundToZeroScalar", apiResult.ToString(), 2));

try {
RoundToZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticResult = Dummy_ShiftArithmeticTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. ShiftArithmetic

`Vector64<short> ShiftArithmetic(Vector64<short> value, Vector64<short> count)`

{0}

```csharp
private Vector64<short> ShiftArithmeticTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmetic(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftArithmetic(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmetic(Vector64<sbyte> value, Vector64<sbyte> count)
Vector128<short> ShiftArithmetic(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftArithmetic(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftArithmetic(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftArithmetic(Vector128<sbyte> value, Vector128<sbyte> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmetic?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshl_s16).

Assembly generated:

```armasm", GetValue("ShiftArithmetic", "Performs 'ShiftArithmetic' operation.", 0), GetValue("ShiftArithmetic", Vector64short_0.ToString(), 1), GetValue("ShiftArithmetic", Vector64short_1.ToString(), 2), GetValue("ShiftArithmetic", apiResult.ToString(), 3));

try {
ShiftArithmeticTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedResult = Dummy_ShiftArithmeticRoundedTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. ShiftArithmeticRounded

`Vector64<short> ShiftArithmeticRounded(Vector64<short> value, Vector64<short> count)`

{0}

```csharp
private Vector64<short> ShiftArithmeticRoundedTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmeticRounded(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftArithmeticRounded(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticRounded(Vector64<sbyte> value, Vector64<sbyte> count)
Vector128<short> ShiftArithmeticRounded(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftArithmeticRounded(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftArithmeticRounded(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftArithmeticRounded(Vector128<sbyte> value, Vector128<sbyte> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticrounded?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshl_s16).

Assembly generated:

```armasm", GetValue("ShiftArithmeticRounded", "Performs 'ShiftArithmeticRounded' operation.", 0), GetValue("ShiftArithmeticRounded", Vector64short_0.ToString(), 1), GetValue("ShiftArithmeticRounded", Vector64short_1.ToString(), 2), GetValue("ShiftArithmeticRounded", apiResult.ToString(), 3));

try {
ShiftArithmeticRoundedTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedSaturateResult = Dummy_ShiftArithmeticRoundedSaturateTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticRoundedSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. ShiftArithmeticRoundedSaturate

`Vector64<short> ShiftArithmeticRoundedSaturate(Vector64<short> value, Vector64<short> count)`

{0}

```csharp
private Vector64<short> ShiftArithmeticRoundedSaturateTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmeticRoundedSaturate(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftArithmeticRoundedSaturate(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticRoundedSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
Vector128<short> ShiftArithmeticRoundedSaturate(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftArithmeticRoundedSaturate(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftArithmeticRoundedSaturate(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftArithmeticRoundedSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticroundedsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshl_s16).

Assembly generated:

```armasm", GetValue("ShiftArithmeticRoundedSaturate", "Performs 'ShiftArithmeticRoundedSaturate' operation.", 0), GetValue("ShiftArithmeticRoundedSaturate", Vector64short_0.ToString(), 1), GetValue("ShiftArithmeticRoundedSaturate", Vector64short_1.ToString(), 2), GetValue("ShiftArithmeticRoundedSaturate", apiResult.ToString(), 3));

try {
ShiftArithmeticRoundedSaturateTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedSaturateScalarResult = Dummy_ShiftArithmeticRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticRoundedSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. ShiftArithmeticRoundedSaturateScalar

`Vector64<long> ShiftArithmeticRoundedSaturateScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftArithmeticRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticRoundedSaturateScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ShiftArithmeticRoundedSaturateScalar(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftArithmeticRoundedSaturateScalar(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticRoundedSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticroundedsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftarithmeticroundedsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshl_s64).

Assembly generated:

```armasm", GetValue("ShiftArithmeticRoundedSaturateScalar", "Performs 'ShiftArithmeticRoundedSaturateScalar' operation.", 0), GetValue("ShiftArithmeticRoundedSaturateScalar", Vector64long_0.ToString(), 1), GetValue("ShiftArithmeticRoundedSaturateScalar", Vector64long_1.ToString(), 2), GetValue("ShiftArithmeticRoundedSaturateScalar", apiResult.ToString(), 3));

try {
ShiftArithmeticRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedScalarResult = Dummy_ShiftArithmeticRoundedScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. ShiftArithmeticRoundedScalar

`Vector64<long> ShiftArithmeticRoundedScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftArithmeticRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticRoundedScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticroundedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshl_s64).

Assembly generated:

```armasm", GetValue("ShiftArithmeticRoundedScalar", "Performs 'ShiftArithmeticRoundedScalar' operation.", 0), GetValue("ShiftArithmeticRoundedScalar", Vector64long_0.ToString(), 1), GetValue("ShiftArithmeticRoundedScalar", Vector64long_1.ToString(), 2), GetValue("ShiftArithmeticRoundedScalar", apiResult.ToString(), 3));

try {
ShiftArithmeticRoundedScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticSaturateResult = Dummy_ShiftArithmeticSaturateTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. ShiftArithmeticSaturate

`Vector64<short> ShiftArithmeticSaturate(Vector64<short> value, Vector64<short> count)`

{0}

```csharp
private Vector64<short> ShiftArithmeticSaturateTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmeticSaturate(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftArithmeticSaturate(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
Vector128<short> ShiftArithmeticSaturate(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftArithmeticSaturate(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftArithmeticSaturate(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftArithmeticSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshl_s16).

Assembly generated:

```armasm", GetValue("ShiftArithmeticSaturate", "Performs 'ShiftArithmeticSaturate' operation.", 0), GetValue("ShiftArithmeticSaturate", Vector64short_0.ToString(), 1), GetValue("ShiftArithmeticSaturate", Vector64short_1.ToString(), 2), GetValue("ShiftArithmeticSaturate", apiResult.ToString(), 3));

try {
ShiftArithmeticSaturateTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftArithmeticSaturateScalarResult = Dummy_ShiftArithmeticSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. ShiftArithmeticSaturateScalar

`Vector64<long> ShiftArithmeticSaturateScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftArithmeticSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticSaturateScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ShiftArithmeticSaturateScalar(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftArithmeticSaturateScalar(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftarithmeticsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshl_s64).

Assembly generated:

```armasm", GetValue("ShiftArithmeticSaturateScalar", "Performs 'ShiftArithmeticSaturateScalar' operation.", 0), GetValue("ShiftArithmeticSaturateScalar", Vector64long_0.ToString(), 1), GetValue("ShiftArithmeticSaturateScalar", Vector64long_1.ToString(), 2), GetValue("ShiftArithmeticSaturateScalar", apiResult.ToString(), 3));

try {
ShiftArithmeticSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 7
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 7 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[ShiftArithmeticScalar](#1-shiftarithmeticscalar), [ShiftLeftAndInsert](#2-shiftleftandinsert), [ShiftLeftAndInsertScalar](#3-shiftleftandinsertscalar), [ShiftLeftLogical](#4-shiftleftlogical), [ShiftLeftLogicalSaturate](#5-shiftleftlogicalsaturate), [ShiftLeftLogicalSaturateScalar](#6-shiftleftlogicalsaturatescalar), [ShiftLeftLogicalSaturateUnsigned](#7-shiftleftlogicalsaturateunsigned), [ShiftLeftLogicalSaturateUnsignedScalar](#8-shiftleftlogicalsaturateunsignedscalar), [ShiftLeftLogicalScalar](#9-shiftleftlogicalscalar), [ShiftLeftLogicalWideningLower](#10-shiftleftlogicalwideninglower), [ShiftLeftLogicalWideningUpper](#11-shiftleftlogicalwideningupper), [ShiftLogical](#12-shiftlogical), [ShiftLogicalRounded](#13-shiftlogicalrounded), [ShiftLogicalRoundedSaturate](#14-shiftlogicalroundedsaturate), [ShiftLogicalRoundedSaturateScalar](#15-shiftlogicalroundedsaturatescalar), [ShiftLogicalRoundedScalar](#16-shiftlogicalroundedscalar), [ShiftLogicalSaturate](#17-shiftlogicalsaturate), [ShiftLogicalSaturateScalar](#18-shiftlogicalsaturatescalar), [ShiftLogicalScalar](#19-shiftlogicalscalar), [ShiftRightAndInsert](#20-shiftrightandinsert), [ShiftRightAndInsertScalar](#21-shiftrightandinsertscalar), [ShiftRightArithmetic](#22-shiftrightarithmetic), [ShiftRightArithmeticAdd](#23-shiftrightarithmeticadd), [ShiftRightArithmeticAddScalar](#24-shiftrightarithmeticaddscalar), [ShiftRightArithmeticNarrowingSaturateLower](#25-shiftrightarithmeticnarrowingsaturatelower), [ShiftRightArithmeticNarrowingSaturateScalar](#26-shiftrightarithmeticnarrowingsaturatescalar), [ShiftRightArithmeticNarrowingSaturateUnsignedLower](#27-shiftrightarithmeticnarrowingsaturateunsignedlower), [ShiftRightArithmeticNarrowingSaturateUnsignedScalar](#28-shiftrightarithmeticnarrowingsaturateunsignedscalar), [ShiftRightArithmeticNarrowingSaturateUnsignedUpper](#29-shiftrightarithmeticnarrowingsaturateunsignedupper), [ShiftRightArithmeticNarrowingSaturateUpper](#30-shiftrightarithmeticnarrowingsaturateupper), [ShiftRightArithmeticRounded](#31-shiftrightarithmeticrounded), [ShiftRightArithmeticRoundedAdd](#32-shiftrightarithmeticroundedadd), [ShiftRightArithmeticRoundedAddScalar](#33-shiftrightarithmeticroundedaddscalar), [ShiftRightArithmeticRoundedNarrowingSaturateLower](#34-shiftrightarithmeticroundednarrowingsaturatelower), [ShiftRightArithmeticRoundedNarrowingSaturateScalar](#35-shiftrightarithmeticroundednarrowingsaturatescalar), [ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower](#36-shiftrightarithmeticroundednarrowingsaturateunsignedlower), [ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar](#37-shiftrightarithmeticroundednarrowingsaturateunsignedscalar), [ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper](#38-shiftrightarithmeticroundednarrowingsaturateunsignedupper), [ShiftRightArithmeticRoundedNarrowingSaturateUpper](#39-shiftrightarithmeticroundednarrowingsaturateupper), [ShiftRightArithmeticRoundedScalar](#40-shiftrightarithmeticroundedscalar), [ShiftRightArithmeticScalar](#41-shiftrightarithmeticscalar), [ShiftRightLogical](#42-shiftrightlogical), [ShiftRightLogicalAdd](#43-shiftrightlogicaladd), [ShiftRightLogicalAddScalar](#44-shiftrightlogicaladdscalar), [ShiftRightLogicalNarrowingLower](#45-shiftrightlogicalnarrowinglower)


");

try {
var ShiftArithmeticScalarResult = Dummy_ShiftArithmeticScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. ShiftArithmeticScalar

`Vector64<long> ShiftArithmeticScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftArithmeticScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshl_s64).

Assembly generated:

```armasm", GetValue("ShiftArithmeticScalar", "Performs 'ShiftArithmeticScalar' operation.", 0), GetValue("ShiftArithmeticScalar", Vector64long_0.ToString(), 1), GetValue("ShiftArithmeticScalar", Vector64long_1.ToString(), 2), GetValue("ShiftArithmeticScalar", apiResult.ToString(), 3));

try {
ShiftArithmeticScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftAndInsertResult = Dummy_ShiftLeftAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftLeftAndInsertResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. ShiftLeftAndInsert

`Vector64<byte> ShiftLeftAndInsert(Vector64<byte> left, Vector64<byte> right, byte shift)`

{0}

```csharp
private Vector64<byte> ShiftLeftAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{{
  return AdvSimd.ShiftLeftAndInsert(left, right, 1);
}}
// left = {1}
// right = {2}
// shift = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLeftAndInsert(Vector64<short> left, Vector64<short> right, byte shift)
Vector64<int> ShiftLeftAndInsert(Vector64<int> left, Vector64<int> right, byte shift)
Vector64<sbyte> ShiftLeftAndInsert(Vector64<sbyte> left, Vector64<sbyte> right, byte shift)
Vector64<ushort> ShiftLeftAndInsert(Vector64<ushort> left, Vector64<ushort> right, byte shift)
Vector64<uint> ShiftLeftAndInsert(Vector64<uint> left, Vector64<uint> right, byte shift)
Vector128<byte> ShiftLeftAndInsert(Vector128<byte> left, Vector128<byte> right, byte shift)
Vector128<short> ShiftLeftAndInsert(Vector128<short> left, Vector128<short> right, byte shift)
Vector128<int> ShiftLeftAndInsert(Vector128<int> left, Vector128<int> right, byte shift)
Vector128<long> ShiftLeftAndInsert(Vector128<long> left, Vector128<long> right, byte shift)
Vector128<sbyte> ShiftLeftAndInsert(Vector128<sbyte> left, Vector128<sbyte> right, byte shift)
Vector128<ushort> ShiftLeftAndInsert(Vector128<ushort> left, Vector128<ushort> right, byte shift)
Vector128<uint> ShiftLeftAndInsert(Vector128<uint> left, Vector128<uint> right, byte shift)
Vector128<ulong> ShiftLeftAndInsert(Vector128<ulong> left, Vector128<ulong> right, byte shift)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftandinsert?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsli_n_u8).

Assembly generated:

```armasm", GetValue("ShiftLeftAndInsert", "Performs 'ShiftLeftAndInsert' operation.", 0), GetValue("ShiftLeftAndInsert", Vector64byte_0.ToString(), 1), GetValue("ShiftLeftAndInsert", Vector64byte_1.ToString(), 2), GetValue("ShiftLeftAndInsert", byte_0.ToString(), 3), GetValue("ShiftLeftAndInsert", apiResult.ToString(), 4));

try {
ShiftLeftAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftAndInsertScalarResult = Dummy_ShiftLeftAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftLeftAndInsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. ShiftLeftAndInsertScalar

`Vector64<long> ShiftLeftAndInsertScalar(Vector64<long> left, Vector64<long> right, byte shift)`

{0}

```csharp
private Vector64<long> ShiftLeftAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{{
  return AdvSimd.ShiftLeftAndInsertScalar(left, right, 1);
}}
// left = {1}
// right = {2}
// shift = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLeftAndInsertScalar(Vector64<ulong> left, Vector64<ulong> right, byte shift)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftandinsertscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vslid_n_s64).

Assembly generated:

```armasm", GetValue("ShiftLeftAndInsertScalar", "Performs 'ShiftLeftAndInsertScalar' operation.", 0), GetValue("ShiftLeftAndInsertScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLeftAndInsertScalar", Vector64long_1.ToString(), 2), GetValue("ShiftLeftAndInsertScalar", byte_0.ToString(), 3), GetValue("ShiftLeftAndInsertScalar", apiResult.ToString(), 4));

try {
ShiftLeftAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalResult = Dummy_ShiftLeftLogicalTest(Vector64byte_0, byte_0);
apiResult = ShiftLeftLogicalResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. ShiftLeftLogical

`Vector64<byte> ShiftLeftLogical(Vector64<byte> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftLeftLogicalTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogical(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLeftLogical(Vector64<short> value, byte count)
Vector64<int> ShiftLeftLogical(Vector64<int> value, byte count)
Vector64<sbyte> ShiftLeftLogical(Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftLeftLogical(Vector64<ushort> value, byte count)
Vector64<uint> ShiftLeftLogical(Vector64<uint> value, byte count)
Vector128<byte> ShiftLeftLogical(Vector128<byte> value, byte count)
Vector128<short> ShiftLeftLogical(Vector128<short> value, byte count)
Vector128<long> ShiftLeftLogical(Vector128<long> value, byte count)
Vector128<sbyte> ShiftLeftLogical(Vector128<sbyte> value, byte count)
Vector128<ushort> ShiftLeftLogical(Vector128<ushort> value, byte count)
Vector128<uint> ShiftLeftLogical(Vector128<uint> value, byte count)
Vector128<ulong> ShiftLeftLogical(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogical?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshl_n_u8).

Assembly generated:

```armasm", GetValue("ShiftLeftLogical", "Performs 'ShiftLeftLogical' operation.", 0), GetValue("ShiftLeftLogical", Vector64byte_0.ToString(), 1), GetValue("ShiftLeftLogical", byte_0.ToString(), 2), GetValue("ShiftLeftLogical", apiResult.ToString(), 3));

try {
ShiftLeftLogicalTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateResult = Dummy_ShiftLeftLogicalSaturateTest(Vector64byte_0, byte_0);
apiResult = ShiftLeftLogicalSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. ShiftLeftLogicalSaturate

`Vector64<byte> ShiftLeftLogicalSaturate(Vector64<byte> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftLeftLogicalSaturateTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturate(value, 6);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLeftLogicalSaturate(Vector64<short> value, byte count)
Vector64<int> ShiftLeftLogicalSaturate(Vector64<int> value, byte count)
Vector64<sbyte> ShiftLeftLogicalSaturate(Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftLeftLogicalSaturate(Vector64<ushort> value, byte count)
Vector64<uint> ShiftLeftLogicalSaturate(Vector64<uint> value, byte count)
Vector128<byte> ShiftLeftLogicalSaturate(Vector128<byte> value, byte count)
Vector128<short> ShiftLeftLogicalSaturate(Vector128<short> value, byte count)
Vector128<int> ShiftLeftLogicalSaturate(Vector128<int> value, byte count)
Vector128<long> ShiftLeftLogicalSaturate(Vector128<long> value, byte count)
Vector128<sbyte> ShiftLeftLogicalSaturate(Vector128<sbyte> value, byte count)
Vector128<ushort> ShiftLeftLogicalSaturate(Vector128<ushort> value, byte count)
Vector128<uint> ShiftLeftLogicalSaturate(Vector128<uint> value, byte count)
Vector128<ulong> ShiftLeftLogicalSaturate(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshl_n_u8).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalSaturate", "Performs 'ShiftLeftLogicalSaturate' operation.", 0), GetValue("ShiftLeftLogicalSaturate", Vector64byte_0.ToString(), 1), GetValue("ShiftLeftLogicalSaturate", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalSaturate", apiResult.ToString(), 3));

try {
ShiftLeftLogicalSaturateTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateScalarResult = Dummy_ShiftLeftLogicalSaturateScalarTest(Vector64long_0, byte_0);
apiResult = ShiftLeftLogicalSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. ShiftLeftLogicalSaturateScalar

`Vector64<long> ShiftLeftLogicalSaturateScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftLeftLogicalSaturateScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturateScalar(value, 0);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLeftLogicalSaturateScalar(Vector64<ulong> value, byte count)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> ShiftLeftLogicalSaturateScalar(Vector64<byte> value, byte count)
Vector64<short> ShiftLeftLogicalSaturateScalar(Vector64<short> value, byte count)
Vector64<int> ShiftLeftLogicalSaturateScalar(Vector64<int> value, byte count)
Vector64<sbyte> ShiftLeftLogicalSaturateScalar(Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftLeftLogicalSaturateScalar(Vector64<ushort> value, byte count)
Vector64<uint> ShiftLeftLogicalSaturateScalar(Vector64<uint> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftleftlogicalsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshl_n_s64).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalSaturateScalar", "Performs 'ShiftLeftLogicalSaturateScalar' operation.", 0), GetValue("ShiftLeftLogicalSaturateScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLeftLogicalSaturateScalar", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalSaturateScalar", apiResult.ToString(), 3));

try {
ShiftLeftLogicalSaturateScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateUnsignedResult = Dummy_ShiftLeftLogicalSaturateUnsignedTest(Vector64short_0, byte_0);
apiResult = ShiftLeftLogicalSaturateUnsignedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. ShiftLeftLogicalSaturateUnsigned

`Vector64<ushort> ShiftLeftLogicalSaturateUnsigned(Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<ushort> ShiftLeftLogicalSaturateUnsignedTest(Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturateUnsigned(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<uint> ShiftLeftLogicalSaturateUnsigned(Vector64<int> value, byte count)
Vector64<byte> ShiftLeftLogicalSaturateUnsigned(Vector64<sbyte> value, byte count)
Vector128<ushort> ShiftLeftLogicalSaturateUnsigned(Vector128<short> value, byte count)
Vector128<uint> ShiftLeftLogicalSaturateUnsigned(Vector128<int> value, byte count)
Vector128<ulong> ShiftLeftLogicalSaturateUnsigned(Vector128<long> value, byte count)
Vector128<byte> ShiftLeftLogicalSaturateUnsigned(Vector128<sbyte> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturateunsigned?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshlu_n_s16).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalSaturateUnsigned", "Performs 'ShiftLeftLogicalSaturateUnsigned' operation.", 0), GetValue("ShiftLeftLogicalSaturateUnsigned", Vector64short_0.ToString(), 1), GetValue("ShiftLeftLogicalSaturateUnsigned", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalSaturateUnsigned", apiResult.ToString(), 3));

try {
ShiftLeftLogicalSaturateUnsignedTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateUnsignedScalarResult = Dummy_ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64long_0, byte_0);
apiResult = ShiftLeftLogicalSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. ShiftLeftLogicalSaturateUnsignedScalar

`Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturateUnsignedScalar(value, 0);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<short> value, byte count)
Vector64<uint> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<int> value, byte count)
Vector64<byte> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<sbyte> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturateunsignedscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftleftlogicalsaturateunsignedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshlu_n_s64).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalSaturateUnsignedScalar", "Performs 'ShiftLeftLogicalSaturateUnsignedScalar' operation.", 0), GetValue("ShiftLeftLogicalSaturateUnsignedScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLeftLogicalSaturateUnsignedScalar", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalSaturateUnsignedScalar", apiResult.ToString(), 3));

try {
ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalScalarResult = Dummy_ShiftLeftLogicalScalarTest(Vector64long_0, byte_0);
apiResult = ShiftLeftLogicalScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. ShiftLeftLogicalScalar

`Vector64<long> ShiftLeftLogicalScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftLeftLogicalScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLeftLogicalScalar(Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshl_n_s64).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalScalar", "Performs 'ShiftLeftLogicalScalar' operation.", 0), GetValue("ShiftLeftLogicalScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLeftLogicalScalar", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalScalar", apiResult.ToString(), 3));

try {
ShiftLeftLogicalScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalWideningLowerResult = Dummy_ShiftLeftLogicalWideningLowerTest(Vector64byte_0, byte_0);
apiResult = ShiftLeftLogicalWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. ShiftLeftLogicalWideningLower

`Vector128<ushort> ShiftLeftLogicalWideningLower(Vector64<byte> value, byte count)`

{0}

```csharp
private Vector128<ushort> ShiftLeftLogicalWideningLowerTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalWideningLower(value, 0);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ShiftLeftLogicalWideningLower(Vector64<short> value, byte count)
Vector128<long> ShiftLeftLogicalWideningLower(Vector64<int> value, byte count)
Vector128<short> ShiftLeftLogicalWideningLower(Vector64<sbyte> value, byte count)
Vector128<uint> ShiftLeftLogicalWideningLower(Vector64<ushort> value, byte count)
Vector128<ulong> ShiftLeftLogicalWideningLower(Vector64<uint> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalwideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshll_n_u8).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalWideningLower", "Performs 'ShiftLeftLogicalWideningLower' operation.", 0), GetValue("ShiftLeftLogicalWideningLower", Vector64byte_0.ToString(), 1), GetValue("ShiftLeftLogicalWideningLower", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalWideningLower", apiResult.ToString(), 3));

try {
ShiftLeftLogicalWideningLowerTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLeftLogicalWideningUpperResult = Dummy_ShiftLeftLogicalWideningUpperTest(Vector128byte_0, byte_0);
apiResult = ShiftLeftLogicalWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. ShiftLeftLogicalWideningUpper

`Vector128<ushort> ShiftLeftLogicalWideningUpper(Vector128<byte> value, byte count)`

{0}

```csharp
private Vector128<ushort> ShiftLeftLogicalWideningUpperTest(Vector128<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalWideningUpper(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ShiftLeftLogicalWideningUpper(Vector128<short> value, byte count)
Vector128<long> ShiftLeftLogicalWideningUpper(Vector128<int> value, byte count)
Vector128<short> ShiftLeftLogicalWideningUpper(Vector128<sbyte> value, byte count)
Vector128<uint> ShiftLeftLogicalWideningUpper(Vector128<ushort> value, byte count)
Vector128<ulong> ShiftLeftLogicalWideningUpper(Vector128<uint> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalwideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshll_high_n_u8).

Assembly generated:

```armasm", GetValue("ShiftLeftLogicalWideningUpper", "Performs 'ShiftLeftLogicalWideningUpper' operation.", 0), GetValue("ShiftLeftLogicalWideningUpper", Vector128byte_0.ToString(), 1), GetValue("ShiftLeftLogicalWideningUpper", byte_0.ToString(), 2), GetValue("ShiftLeftLogicalWideningUpper", apiResult.ToString(), 3));

try {
ShiftLeftLogicalWideningUpperTest(Vector128byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalResult = Dummy_ShiftLogicalTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. ShiftLogical

`Vector64<byte> ShiftLogical(Vector64<byte> value, Vector64<sbyte> count)`

{0}

```csharp
private Vector64<byte> ShiftLogicalTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogical(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLogical(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftLogical(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftLogical(Vector64<sbyte> value, Vector64<sbyte> count)
Vector64<ushort> ShiftLogical(Vector64<ushort> value, Vector64<short> count)
Vector64<uint> ShiftLogical(Vector64<uint> value, Vector64<int> count)
Vector128<byte> ShiftLogical(Vector128<byte> value, Vector128<sbyte> count)
Vector128<short> ShiftLogical(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftLogical(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftLogical(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftLogical(Vector128<sbyte> value, Vector128<sbyte> count)
Vector128<ushort> ShiftLogical(Vector128<ushort> value, Vector128<short> count)
Vector128<uint> ShiftLogical(Vector128<uint> value, Vector128<int> count)
Vector128<ulong> ShiftLogical(Vector128<ulong> value, Vector128<long> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogical?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshl_u8).

Assembly generated:

```armasm", GetValue("ShiftLogical", "Performs 'ShiftLogical' operation.", 0), GetValue("ShiftLogical", Vector64byte_0.ToString(), 1), GetValue("ShiftLogical", Vector64sbyte_0.ToString(), 2), GetValue("ShiftLogical", apiResult.ToString(), 3));

try {
ShiftLogicalTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedResult = Dummy_ShiftLogicalRoundedTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. ShiftLogicalRounded

`Vector64<byte> ShiftLogicalRounded(Vector64<byte> value, Vector64<sbyte> count)`

{0}

```csharp
private Vector64<byte> ShiftLogicalRoundedTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogicalRounded(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLogicalRounded(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftLogicalRounded(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftLogicalRounded(Vector64<sbyte> value, Vector64<sbyte> count)
Vector64<ushort> ShiftLogicalRounded(Vector64<ushort> value, Vector64<short> count)
Vector64<uint> ShiftLogicalRounded(Vector64<uint> value, Vector64<int> count)
Vector128<byte> ShiftLogicalRounded(Vector128<byte> value, Vector128<sbyte> count)
Vector128<short> ShiftLogicalRounded(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftLogicalRounded(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftLogicalRounded(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftLogicalRounded(Vector128<sbyte> value, Vector128<sbyte> count)
Vector128<ushort> ShiftLogicalRounded(Vector128<ushort> value, Vector128<short> count)
Vector128<uint> ShiftLogicalRounded(Vector128<uint> value, Vector128<int> count)
Vector128<ulong> ShiftLogicalRounded(Vector128<ulong> value, Vector128<long> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalrounded?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshl_u8).

Assembly generated:

```armasm", GetValue("ShiftLogicalRounded", "Performs 'ShiftLogicalRounded' operation.", 0), GetValue("ShiftLogicalRounded", Vector64byte_0.ToString(), 1), GetValue("ShiftLogicalRounded", Vector64sbyte_0.ToString(), 2), GetValue("ShiftLogicalRounded", apiResult.ToString(), 3));

try {
ShiftLogicalRoundedTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedSaturateResult = Dummy_ShiftLogicalRoundedSaturateTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalRoundedSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. ShiftLogicalRoundedSaturate

`Vector64<byte> ShiftLogicalRoundedSaturate(Vector64<byte> value, Vector64<sbyte> count)`

{0}

```csharp
private Vector64<byte> ShiftLogicalRoundedSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogicalRoundedSaturate(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLogicalRoundedSaturate(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftLogicalRoundedSaturate(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftLogicalRoundedSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
Vector64<ushort> ShiftLogicalRoundedSaturate(Vector64<ushort> value, Vector64<short> count)
Vector64<uint> ShiftLogicalRoundedSaturate(Vector64<uint> value, Vector64<int> count)
Vector128<byte> ShiftLogicalRoundedSaturate(Vector128<byte> value, Vector128<sbyte> count)
Vector128<short> ShiftLogicalRoundedSaturate(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftLogicalRoundedSaturate(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftLogicalRoundedSaturate(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftLogicalRoundedSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
Vector128<ushort> ShiftLogicalRoundedSaturate(Vector128<ushort> value, Vector128<short> count)
Vector128<uint> ShiftLogicalRoundedSaturate(Vector128<uint> value, Vector128<int> count)
Vector128<ulong> ShiftLogicalRoundedSaturate(Vector128<ulong> value, Vector128<long> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalroundedsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshl_u8).

Assembly generated:

```armasm", GetValue("ShiftLogicalRoundedSaturate", "Performs 'ShiftLogicalRoundedSaturate' operation.", 0), GetValue("ShiftLogicalRoundedSaturate", Vector64byte_0.ToString(), 1), GetValue("ShiftLogicalRoundedSaturate", Vector64sbyte_0.ToString(), 2), GetValue("ShiftLogicalRoundedSaturate", apiResult.ToString(), 3));

try {
ShiftLogicalRoundedSaturateTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedSaturateScalarResult = Dummy_ShiftLogicalRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalRoundedSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. ShiftLogicalRoundedSaturateScalar

`Vector64<long> ShiftLogicalRoundedSaturateScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftLogicalRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalRoundedSaturateScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLogicalRoundedSaturateScalar(Vector64<ulong> value, Vector64<long> count)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> ShiftLogicalRoundedSaturateScalar(Vector64<byte> value, Vector64<sbyte> count)
Vector64<short> ShiftLogicalRoundedSaturateScalar(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftLogicalRoundedSaturateScalar(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftLogicalRoundedSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
Vector64<ushort> ShiftLogicalRoundedSaturateScalar(Vector64<ushort> value, Vector64<short> count)
Vector64<uint> ShiftLogicalRoundedSaturateScalar(Vector64<uint> value, Vector64<int> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalroundedsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftlogicalroundedsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshl_u64).

Assembly generated:

```armasm", GetValue("ShiftLogicalRoundedSaturateScalar", "Performs 'ShiftLogicalRoundedSaturateScalar' operation.", 0), GetValue("ShiftLogicalRoundedSaturateScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLogicalRoundedSaturateScalar", Vector64long_1.ToString(), 2), GetValue("ShiftLogicalRoundedSaturateScalar", apiResult.ToString(), 3));

try {
ShiftLogicalRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedScalarResult = Dummy_ShiftLogicalRoundedScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. ShiftLogicalRoundedScalar

`Vector64<long> ShiftLogicalRoundedScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftLogicalRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalRoundedScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLogicalRoundedScalar(Vector64<ulong> value, Vector64<long> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalroundedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshl_u64).

Assembly generated:

```armasm", GetValue("ShiftLogicalRoundedScalar", "Performs 'ShiftLogicalRoundedScalar' operation.", 0), GetValue("ShiftLogicalRoundedScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLogicalRoundedScalar", Vector64long_1.ToString(), 2), GetValue("ShiftLogicalRoundedScalar", apiResult.ToString(), 3));

try {
ShiftLogicalRoundedScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalSaturateResult = Dummy_ShiftLogicalSaturateTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. ShiftLogicalSaturate

`Vector64<byte> ShiftLogicalSaturate(Vector64<byte> value, Vector64<sbyte> count)`

{0}

```csharp
private Vector64<byte> ShiftLogicalSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogicalSaturate(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftLogicalSaturate(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftLogicalSaturate(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftLogicalSaturate(Vector64<sbyte> value, Vector64<sbyte> count)
Vector64<ushort> ShiftLogicalSaturate(Vector64<ushort> value, Vector64<short> count)
Vector64<uint> ShiftLogicalSaturate(Vector64<uint> value, Vector64<int> count)
Vector128<byte> ShiftLogicalSaturate(Vector128<byte> value, Vector128<sbyte> count)
Vector128<short> ShiftLogicalSaturate(Vector128<short> value, Vector128<short> count)
Vector128<int> ShiftLogicalSaturate(Vector128<int> value, Vector128<int> count)
Vector128<long> ShiftLogicalSaturate(Vector128<long> value, Vector128<long> count)
Vector128<sbyte> ShiftLogicalSaturate(Vector128<sbyte> value, Vector128<sbyte> count)
Vector128<ushort> ShiftLogicalSaturate(Vector128<ushort> value, Vector128<short> count)
Vector128<uint> ShiftLogicalSaturate(Vector128<uint> value, Vector128<int> count)
Vector128<ulong> ShiftLogicalSaturate(Vector128<ulong> value, Vector128<long> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshl_u8).

Assembly generated:

```armasm", GetValue("ShiftLogicalSaturate", "Performs 'ShiftLogicalSaturate' operation.", 0), GetValue("ShiftLogicalSaturate", Vector64byte_0.ToString(), 1), GetValue("ShiftLogicalSaturate", Vector64sbyte_0.ToString(), 2), GetValue("ShiftLogicalSaturate", apiResult.ToString(), 3));

try {
ShiftLogicalSaturateTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalSaturateScalarResult = Dummy_ShiftLogicalSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. ShiftLogicalSaturateScalar

`Vector64<long> ShiftLogicalSaturateScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftLogicalSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalSaturateScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLogicalSaturateScalar(Vector64<ulong> value, Vector64<long> count)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> ShiftLogicalSaturateScalar(Vector64<byte> value, Vector64<sbyte> count)
Vector64<short> ShiftLogicalSaturateScalar(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftLogicalSaturateScalar(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftLogicalSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
Vector64<ushort> ShiftLogicalSaturateScalar(Vector64<ushort> value, Vector64<short> count)
Vector64<uint> ShiftLogicalSaturateScalar(Vector64<uint> value, Vector64<int> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftlogicalsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshl_u64).

Assembly generated:

```armasm", GetValue("ShiftLogicalSaturateScalar", "Performs 'ShiftLogicalSaturateScalar' operation.", 0), GetValue("ShiftLogicalSaturateScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLogicalSaturateScalar", Vector64long_1.ToString(), 2), GetValue("ShiftLogicalSaturateScalar", apiResult.ToString(), 3));

try {
ShiftLogicalSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftLogicalScalarResult = Dummy_ShiftLogicalScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. ShiftLogicalScalar

`Vector64<long> ShiftLogicalScalar(Vector64<long> value, Vector64<long> count)`

{0}

```csharp
private Vector64<long> ShiftLogicalScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalScalar(value, count);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLogicalScalar(Vector64<ulong> value, Vector64<long> count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshl_u64).

Assembly generated:

```armasm", GetValue("ShiftLogicalScalar", "Performs 'ShiftLogicalScalar' operation.", 0), GetValue("ShiftLogicalScalar", Vector64long_0.ToString(), 1), GetValue("ShiftLogicalScalar", Vector64long_1.ToString(), 2), GetValue("ShiftLogicalScalar", apiResult.ToString(), 3));

try {
ShiftLogicalScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightAndInsertResult = Dummy_ShiftRightAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftRightAndInsertResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. ShiftRightAndInsert

`Vector64<byte> ShiftRightAndInsert(Vector64<byte> left, Vector64<byte> right, byte shift)`

{0}

```csharp
private Vector64<byte> ShiftRightAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{{
  return AdvSimd.ShiftRightAndInsert(left, right, 1);
}}
// left = {1}
// right = {2}
// shift = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightAndInsert(Vector64<short> left, Vector64<short> right, byte shift)
Vector64<int> ShiftRightAndInsert(Vector64<int> left, Vector64<int> right, byte shift)
Vector64<sbyte> ShiftRightAndInsert(Vector64<sbyte> left, Vector64<sbyte> right, byte shift)
Vector64<ushort> ShiftRightAndInsert(Vector64<ushort> left, Vector64<ushort> right, byte shift)
Vector64<uint> ShiftRightAndInsert(Vector64<uint> left, Vector64<uint> right, byte shift)
Vector128<byte> ShiftRightAndInsert(Vector128<byte> left, Vector128<byte> right, byte shift)
Vector128<short> ShiftRightAndInsert(Vector128<short> left, Vector128<short> right, byte shift)
Vector128<int> ShiftRightAndInsert(Vector128<int> left, Vector128<int> right, byte shift)
Vector128<long> ShiftRightAndInsert(Vector128<long> left, Vector128<long> right, byte shift)
Vector128<sbyte> ShiftRightAndInsert(Vector128<sbyte> left, Vector128<sbyte> right, byte shift)
Vector128<ushort> ShiftRightAndInsert(Vector128<ushort> left, Vector128<ushort> right, byte shift)
Vector128<uint> ShiftRightAndInsert(Vector128<uint> left, Vector128<uint> right, byte shift)
Vector128<ulong> ShiftRightAndInsert(Vector128<ulong> left, Vector128<ulong> right, byte shift)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightandinsert?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsri_n_u8).

Assembly generated:

```armasm", GetValue("ShiftRightAndInsert", "Performs 'ShiftRightAndInsert' operation.", 0), GetValue("ShiftRightAndInsert", Vector64byte_0.ToString(), 1), GetValue("ShiftRightAndInsert", Vector64byte_1.ToString(), 2), GetValue("ShiftRightAndInsert", byte_0.ToString(), 3), GetValue("ShiftRightAndInsert", apiResult.ToString(), 4));

try {
ShiftRightAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightAndInsertScalarResult = Dummy_ShiftRightAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightAndInsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. ShiftRightAndInsertScalar

`Vector64<long> ShiftRightAndInsertScalar(Vector64<long> left, Vector64<long> right, byte shift)`

{0}

```csharp
private Vector64<long> ShiftRightAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{{
  return AdvSimd.ShiftRightAndInsertScalar(left, right, 1);
}}
// left = {1}
// right = {2}
// shift = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightAndInsertScalar(Vector64<ulong> left, Vector64<ulong> right, byte shift)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightandinsertscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsrid_n_s64).

Assembly generated:

```armasm", GetValue("ShiftRightAndInsertScalar", "Performs 'ShiftRightAndInsertScalar' operation.", 0), GetValue("ShiftRightAndInsertScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightAndInsertScalar", Vector64long_1.ToString(), 2), GetValue("ShiftRightAndInsertScalar", byte_0.ToString(), 3), GetValue("ShiftRightAndInsertScalar", apiResult.ToString(), 4));

try {
ShiftRightAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticResult = Dummy_ShiftRightArithmeticTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. ShiftRightArithmetic

`Vector64<short> ShiftRightArithmetic(Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticTest(Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmetic(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmetic(Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightArithmetic(Vector64<sbyte> value, byte count)
Vector128<short> ShiftRightArithmetic(Vector128<short> value, byte count)
Vector128<int> ShiftRightArithmetic(Vector128<int> value, byte count)
Vector128<long> ShiftRightArithmetic(Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmetic?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshr_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmetic", "Performs 'ShiftRightArithmetic' operation.", 0), GetValue("ShiftRightArithmetic", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmetic", byte_0.ToString(), 2), GetValue("ShiftRightArithmetic", apiResult.ToString(), 3));

try {
ShiftRightArithmeticTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticAddResult = Dummy_ShiftRightArithmeticAddTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = ShiftRightArithmeticAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. ShiftRightArithmeticAdd

`Vector64<short> ShiftRightArithmeticAdd(Vector64<short> addend, Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticAdd(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticAdd(Vector64<int> addend, Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightArithmeticAdd(Vector64<sbyte> addend, Vector64<sbyte> value, byte count)
Vector128<short> ShiftRightArithmeticAdd(Vector128<short> addend, Vector128<short> value, byte count)
Vector128<int> ShiftRightArithmeticAdd(Vector128<int> addend, Vector128<int> value, byte count)
Vector128<long> ShiftRightArithmeticAdd(Vector128<long> addend, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticAdd(Vector128<sbyte> addend, Vector128<sbyte> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsra_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticAdd", "Performs 'ShiftRightArithmeticAdd' operation.", 0), GetValue("ShiftRightArithmeticAdd", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticAdd", Vector64short_1.ToString(), 2), GetValue("ShiftRightArithmeticAdd", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticAdd", apiResult.ToString(), 4));

try {
ShiftRightArithmeticAddTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticAddScalarResult = Dummy_ShiftRightArithmeticAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightArithmeticAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. ShiftRightArithmeticAddScalar

`Vector64<long> ShiftRightArithmeticAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightArithmeticAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticAddScalar(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticaddscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsra_n_s64).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticAddScalar", "Performs 'ShiftRightArithmeticAddScalar' operation.", 0), GetValue("ShiftRightArithmeticAddScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightArithmeticAddScalar", Vector64long_1.ToString(), 2), GetValue("ShiftRightArithmeticAddScalar", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticAddScalar", apiResult.ToString(), 4));

try {
ShiftRightArithmeticAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateLowerResult = Dummy_ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. ShiftRightArithmeticNarrowingSaturateLower

`Vector64<short> ShiftRightArithmeticNarrowingSaturateLower(Vector128<int> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticNarrowingSaturateLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticNarrowingSaturateLower(Vector128<short> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturatelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrn_n_s32).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticNarrowingSaturateLower", "Performs 'ShiftRightArithmeticNarrowingSaturateLower' operation.", 0), GetValue("ShiftRightArithmeticNarrowingSaturateLower", Vector128int_0.ToString(), 1), GetValue("ShiftRightArithmeticNarrowingSaturateLower", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticNarrowingSaturateLower", apiResult.ToString(), 3));

try {
ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateScalarResult = Dummy_ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64int_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. ShiftRightArithmeticNarrowingSaturateScalar

`Vector64<short> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<int> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<short> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticnarrowingsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrns_n_s32).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticNarrowingSaturateScalar", "Performs 'ShiftRightArithmeticNarrowingSaturateScalar' operation.", 0), GetValue("ShiftRightArithmeticNarrowingSaturateScalar", Vector64int_0.ToString(), 1), GetValue("ShiftRightArithmeticNarrowingSaturateScalar", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticNarrowingSaturateScalar", apiResult.ToString(), 3));

try {
ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUnsignedLowerResult = Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUnsignedLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. ShiftRightArithmeticNarrowingSaturateUnsignedLower

`Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<short> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<int> value, byte count)
Vector64<uint> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<long> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturateunsignedlower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrun_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedLower", "Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedLower' operation.", 0), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedLower", Vector128short_0.ToString(), 1), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedLower", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedLower", apiResult.ToString(), 3));

try {
ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUnsignedScalarResult = Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. ShiftRightArithmeticNarrowingSaturateUnsignedScalar

`Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateUnsignedScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<int> value, byte count)
Vector64<uint> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<long> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticnarrowingsaturateunsignedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrunh_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedScalar", "Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedScalar' operation.", 0), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedScalar", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedScalar", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedScalar", apiResult.ToString(), 3));

try {
ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUnsignedUpperResult = Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUnsignedUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. ShiftRightArithmeticNarrowingSaturateUnsignedUpper

`Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value, byte count)`

{0}

```csharp
private Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value, byte count)
Vector128<uint> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturateunsignedupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrun_high_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedUpper", "Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedUpper' operation.", 0), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedUpper", Vector64byte_0.ToString(), 1), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedUpper", Vector128short_0.ToString(), 2), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedUpper", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticNarrowingSaturateUnsignedUpper", apiResult.ToString(), 4));

try {
ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUpperResult = Dummy_ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. ShiftRightArithmeticNarrowingSaturateUpper

`Vector128<short> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, byte count)`

{0}

```csharp
private Vector128<short> ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturateupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrn_high_n_s32).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticNarrowingSaturateUpper", "Performs 'ShiftRightArithmeticNarrowingSaturateUpper' operation.", 0), GetValue("ShiftRightArithmeticNarrowingSaturateUpper", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticNarrowingSaturateUpper", Vector128int_0.ToString(), 2), GetValue("ShiftRightArithmeticNarrowingSaturateUpper", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticNarrowingSaturateUpper", apiResult.ToString(), 4));

try {
ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedResult = Dummy_ShiftRightArithmeticRoundedTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. ShiftRightArithmeticRounded

`Vector64<short> ShiftRightArithmeticRounded(Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticRoundedTest(Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRounded(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticRounded(Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightArithmeticRounded(Vector64<sbyte> value, byte count)
Vector128<short> ShiftRightArithmeticRounded(Vector128<short> value, byte count)
Vector128<int> ShiftRightArithmeticRounded(Vector128<int> value, byte count)
Vector128<long> ShiftRightArithmeticRounded(Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticRounded(Vector128<sbyte> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticrounded?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshr_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRounded", "Performs 'ShiftRightArithmeticRounded' operation.", 0), GetValue("ShiftRightArithmeticRounded", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticRounded", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticRounded", apiResult.ToString(), 3));

try {
ShiftRightArithmeticRoundedTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedAddResult = Dummy_ShiftRightArithmeticRoundedAddTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = ShiftRightArithmeticRoundedAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. ShiftRightArithmeticRoundedAdd

`Vector64<short> ShiftRightArithmeticRoundedAdd(Vector64<short> addend, Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticRoundedAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedAdd(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticRoundedAdd(Vector64<int> addend, Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightArithmeticRoundedAdd(Vector64<sbyte> addend, Vector64<sbyte> value, byte count)
Vector128<short> ShiftRightArithmeticRoundedAdd(Vector128<short> addend, Vector128<short> value, byte count)
Vector128<int> ShiftRightArithmeticRoundedAdd(Vector128<int> addend, Vector128<int> value, byte count)
Vector128<long> ShiftRightArithmeticRoundedAdd(Vector128<long> addend, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticRoundedAdd(Vector128<sbyte> addend, Vector128<sbyte> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundedadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsra_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedAdd", "Performs 'ShiftRightArithmeticRoundedAdd' operation.", 0), GetValue("ShiftRightArithmeticRoundedAdd", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedAdd", Vector64short_1.ToString(), 2), GetValue("ShiftRightArithmeticRoundedAdd", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticRoundedAdd", apiResult.ToString(), 4));

try {
ShiftRightArithmeticRoundedAddTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedAddScalarResult = Dummy_ShiftRightArithmeticRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightArithmeticRoundedAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. ShiftRightArithmeticRoundedAddScalar

`Vector64<long> ShiftRightArithmeticRoundedAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightArithmeticRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedAddScalar(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundedaddscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsra_n_s64).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedAddScalar", "Performs 'ShiftRightArithmeticRoundedAddScalar' operation.", 0), GetValue("ShiftRightArithmeticRoundedAddScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedAddScalar", Vector64long_1.ToString(), 2), GetValue("ShiftRightArithmeticRoundedAddScalar", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticRoundedAddScalar", apiResult.ToString(), 4));

try {
ShiftRightArithmeticRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateLowerResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. ShiftRightArithmeticRoundedNarrowingSaturateLower

`Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<int> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<short> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturatelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrn_n_s32).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedNarrowingSaturateLower", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateLower' operation.", 0), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateLower", Vector128int_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateLower", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateLower", apiResult.ToString(), 3));

try {
ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateScalarResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64int_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. ShiftRightArithmeticRoundedNarrowingSaturateScalar

`Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<int> value, byte count)`

{0}

```csharp
private Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<short> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticroundednarrowingsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrns_n_s32).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedNarrowingSaturateScalar", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateScalar' operation.", 0), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateScalar", Vector64int_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateScalar", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateScalar", apiResult.ToString(), 3));

try {
ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower

`Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<short> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<int> value, byte count)
Vector64<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<long> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturateunsignedlower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrun_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower' operation.", 0), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower", Vector128short_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower", apiResult.ToString(), 3));

try {
ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar

`Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<short> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<int> value, byte count)
Vector64<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<long> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticroundednarrowingsaturateunsignedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrunh_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar' operation.", 0), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar", apiResult.ToString(), 3));

try {
ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper

`Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value, byte count)`

{0}

```csharp
private Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value, byte count)
Vector128<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturateunsignedupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrun_high_n_s16).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper' operation.", 0), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper", Vector64byte_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper", Vector128short_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper", apiResult.ToString(), 4));

try {
ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUpperResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. ShiftRightArithmeticRoundedNarrowingSaturateUpper

`Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, byte count)`

{0}

```csharp
private Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturateupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrn_high_n_s32).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUpper", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUpper' operation.", 0), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUpper", Vector64short_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUpper", Vector128int_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUpper", byte_0.ToString(), 3), GetValue("ShiftRightArithmeticRoundedNarrowingSaturateUpper", apiResult.ToString(), 4));

try {
ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedScalarResult = Dummy_ShiftRightArithmeticRoundedScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightArithmeticRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. ShiftRightArithmeticRoundedScalar

`Vector64<long> ShiftRightArithmeticRoundedScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightArithmeticRoundedScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshr_n_s64).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticRoundedScalar", "Performs 'ShiftRightArithmeticRoundedScalar' operation.", 0), GetValue("ShiftRightArithmeticRoundedScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightArithmeticRoundedScalar", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticRoundedScalar", apiResult.ToString(), 3));

try {
ShiftRightArithmeticRoundedScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightArithmeticScalarResult = Dummy_ShiftRightArithmeticScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightArithmeticScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. ShiftRightArithmeticScalar

`Vector64<long> ShiftRightArithmeticScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightArithmeticScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```



See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshr_n_s64).

Assembly generated:

```armasm", GetValue("ShiftRightArithmeticScalar", "Performs 'ShiftRightArithmeticScalar' operation.", 0), GetValue("ShiftRightArithmeticScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightArithmeticScalar", byte_0.ToString(), 2), GetValue("ShiftRightArithmeticScalar", apiResult.ToString(), 3));

try {
ShiftRightArithmeticScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalResult = Dummy_ShiftRightLogicalTest(Vector64byte_0, byte_0);
apiResult = ShiftRightLogicalResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. ShiftRightLogical

`Vector64<byte> ShiftRightLogical(Vector64<byte> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogical(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogical(Vector64<short> value, byte count)
Vector64<int> ShiftRightLogical(Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightLogical(Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftRightLogical(Vector64<ushort> value, byte count)
Vector64<uint> ShiftRightLogical(Vector64<uint> value, byte count)
Vector128<byte> ShiftRightLogical(Vector128<byte> value, byte count)
Vector128<short> ShiftRightLogical(Vector128<short> value, byte count)
Vector128<int> ShiftRightLogical(Vector128<int> value, byte count)
Vector128<long> ShiftRightLogical(Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, byte count)
Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, byte count)
Vector128<uint> ShiftRightLogical(Vector128<uint> value, byte count)
Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogical?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshr_n_u8).

Assembly generated:

```armasm", GetValue("ShiftRightLogical", "Performs 'ShiftRightLogical' operation.", 0), GetValue("ShiftRightLogical", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogical", byte_0.ToString(), 2), GetValue("ShiftRightLogical", apiResult.ToString(), 3));

try {
ShiftRightLogicalTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalAddResult = Dummy_ShiftRightLogicalAddTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftRightLogicalAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. ShiftRightLogicalAdd

`Vector64<byte> ShiftRightLogicalAdd(Vector64<byte> addend, Vector64<byte> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalAdd(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalAdd(Vector64<short> addend, Vector64<short> value, byte count)
Vector64<int> ShiftRightLogicalAdd(Vector64<int> addend, Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightLogicalAdd(Vector64<sbyte> addend, Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftRightLogicalAdd(Vector64<ushort> addend, Vector64<ushort> value, byte count)
Vector64<uint> ShiftRightLogicalAdd(Vector64<uint> addend, Vector64<uint> value, byte count)
Vector128<byte> ShiftRightLogicalAdd(Vector128<byte> addend, Vector128<byte> value, byte count)
Vector128<short> ShiftRightLogicalAdd(Vector128<short> addend, Vector128<short> value, byte count)
Vector128<int> ShiftRightLogicalAdd(Vector128<int> addend, Vector128<int> value, byte count)
Vector128<long> ShiftRightLogicalAdd(Vector128<long> addend, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalAdd(Vector128<sbyte> addend, Vector128<sbyte> value, byte count)
Vector128<ushort> ShiftRightLogicalAdd(Vector128<ushort> addend, Vector128<ushort> value, byte count)
Vector128<uint> ShiftRightLogicalAdd(Vector128<uint> addend, Vector128<uint> value, byte count)
Vector128<ulong> ShiftRightLogicalAdd(Vector128<ulong> addend, Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicaladd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsra_n_u8).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalAdd", "Performs 'ShiftRightLogicalAdd' operation.", 0), GetValue("ShiftRightLogicalAdd", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalAdd", Vector64byte_1.ToString(), 2), GetValue("ShiftRightLogicalAdd", byte_0.ToString(), 3), GetValue("ShiftRightLogicalAdd", apiResult.ToString(), 4));

try {
ShiftRightLogicalAddTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalAddScalarResult = Dummy_ShiftRightLogicalAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightLogicalAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. ShiftRightLogicalAddScalar

`Vector64<long> ShiftRightLogicalAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightLogicalAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalAddScalar(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalAddScalar(Vector64<ulong> addend, Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicaladdscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsra_n_u64).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalAddScalar", "Performs 'ShiftRightLogicalAddScalar' operation.", 0), GetValue("ShiftRightLogicalAddScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightLogicalAddScalar", Vector64long_1.ToString(), 2), GetValue("ShiftRightLogicalAddScalar", byte_0.ToString(), 3), GetValue("ShiftRightLogicalAddScalar", apiResult.ToString(), 4));

try {
ShiftRightLogicalAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingLowerResult = Dummy_ShiftRightLogicalNarrowingLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. ShiftRightLogicalNarrowingLower

`Vector64<byte> ShiftRightLogicalNarrowingLower(Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalNarrowingLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalNarrowingLower(Vector128<int> value, byte count)
Vector64<int> ShiftRightLogicalNarrowingLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightLogicalNarrowingLower(Vector128<short> value, byte count)
Vector64<ushort> ShiftRightLogicalNarrowingLower(Vector128<uint> value, byte count)
Vector64<uint> ShiftRightLogicalNarrowingLower(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshrn_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalNarrowingLower", "Performs 'ShiftRightLogicalNarrowingLower' operation.", 0), GetValue("ShiftRightLogicalNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("ShiftRightLogicalNarrowingLower", byte_0.ToString(), 2), GetValue("ShiftRightLogicalNarrowingLower", apiResult.ToString(), 3));

try {
ShiftRightLogicalNarrowingLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: ARM64 Hardware Intrinsics APIs in .NET - Part 8
subtitle: Sample code usage, examples and generated assembly code
tags: [work, arm64, intrinsics]
---

### Introduction

In my [vectorization using .NET APIs](../2020-08-01-Vectorization-APIs) blog, I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'ARM64 hardware intrinsic' APIs present under [System.Runtime.Intrinsics.Arm.AdvSimd](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd?view=net-5.0) and [System.Runtime.Intrinsics.Arm.AdvSimd.Arm64](https://docs.microsoft.com/en-us/dotnet/api/system.runtime.intrinsics.arm.advsimd.arm64?view=net-5.0) class. In this post I will describe those hardware intrinsic APIs by showing sample code usage along with examples and generated ARM64 code. This will help people in understanding these APIs so they can use them to optimize their .NET code written to target ARM64. Since there are 360 APIs, describing all of them in a single post will be overwhelming. So I have divided these APIs among 8 blogs and will demonstrate 45 APIs in each blog. This is part 8 of that blog series.

Most of the description of these APIs is adapted and referenced from [Arm Architecture Reference Manual Armv8, for Armv8-A architecture profile document](https://developer.arm.com/documentation/ddi0487/fc/). You can also refer to the description of SIMD and Floating-point instructions description at [Arm developer docs page](https://developer.arm.com/docs/ddi0596/h/simd-and-floating-point-instructions-alphabetic-order).

### APIs covered

[ShiftRightLogicalNarrowingSaturateLower](#1-shiftrightlogicalnarrowingsaturatelower), [ShiftRightLogicalNarrowingSaturateScalar](#2-shiftrightlogicalnarrowingsaturatescalar), [ShiftRightLogicalNarrowingSaturateUpper](#3-shiftrightlogicalnarrowingsaturateupper), [ShiftRightLogicalNarrowingUpper](#4-shiftrightlogicalnarrowingupper), [ShiftRightLogicalRounded](#5-shiftrightlogicalrounded), [ShiftRightLogicalRoundedAdd](#6-shiftrightlogicalroundedadd), [ShiftRightLogicalRoundedAddScalar](#7-shiftrightlogicalroundedaddscalar), [ShiftRightLogicalRoundedNarrowingLower](#8-shiftrightlogicalroundednarrowinglower), [ShiftRightLogicalRoundedNarrowingSaturateLower](#9-shiftrightlogicalroundednarrowingsaturatelower), [ShiftRightLogicalRoundedNarrowingSaturateScalar](#10-shiftrightlogicalroundednarrowingsaturatescalar), [ShiftRightLogicalRoundedNarrowingSaturateUpper](#11-shiftrightlogicalroundednarrowingsaturateupper), [ShiftRightLogicalRoundedNarrowingUpper](#12-shiftrightlogicalroundednarrowingupper), [ShiftRightLogicalRoundedScalar](#13-shiftrightlogicalroundedscalar), [ShiftRightLogicalScalar](#14-shiftrightlogicalscalar), [SignExtendWideningLower](#15-signextendwideninglower), [SignExtendWideningUpper](#16-signextendwideningupper), [Sqrt](#17-sqrt), [SqrtScalar](#18-sqrtscalar), [Store](#19-store), [StorePair](#20-storepair), [StorePairNonTemporal](#21-storepairnontemporal), [StorePairScalar](#22-storepairscalar), [StorePairScalarNonTemporal](#23-storepairscalarnontemporal), [StoreSelectedScalar](#24-storeselectedscalar), [Subtract](#25-subtract), [SubtractHighNarrowingLower](#26-subtracthighnarrowinglower), [SubtractHighNarrowingUpper](#27-subtracthighnarrowingupper), [SubtractRoundedHighNarrowingLower](#28-subtractroundedhighnarrowinglower), [SubtractRoundedHighNarrowingUpper](#29-subtractroundedhighnarrowingupper), [SubtractSaturate](#30-subtractsaturate), [SubtractSaturateScalar](#31-subtractsaturatescalar), [SubtractScalar](#32-subtractscalar), [SubtractWideningLower](#33-subtractwideninglower), [SubtractWideningUpper](#34-subtractwideningupper), [TransposeEven](#35-transposeeven), [TransposeOdd](#36-transposeodd), [UnzipEven](#37-unzipeven), [UnzipOdd](#38-unzipodd), [VectorTableLookup](#39-vectortablelookup), [VectorTableLookupExtension](#40-vectortablelookupextension), [Xor](#41-xor), [ZeroExtendWideningLower](#42-zeroextendwideninglower), [ZeroExtendWideningUpper](#43-zeroextendwideningupper), [ZipHigh](#44-ziphigh), [ZipLow](#45-ziplow)


");

try {
var ShiftRightLogicalNarrowingSaturateLowerResult = Dummy_ShiftRightLogicalNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"

### 1. ShiftRightLogicalNarrowingSaturateLower

`Vector64<byte> ShiftRightLogicalNarrowingSaturateLower(Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalNarrowingSaturateLower(Vector128<int> value, byte count)
Vector64<int> ShiftRightLogicalNarrowingSaturateLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightLogicalNarrowingSaturateLower(Vector128<short> value, byte count)
Vector64<ushort> ShiftRightLogicalNarrowingSaturateLower(Vector128<uint> value, byte count)
Vector64<uint> ShiftRightLogicalNarrowingSaturateLower(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowingsaturatelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrn_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalNarrowingSaturateLower", "Performs 'ShiftRightLogicalNarrowingSaturateLower' operation.", 0), GetValue("ShiftRightLogicalNarrowingSaturateLower", Vector128ushort_0.ToString(), 1), GetValue("ShiftRightLogicalNarrowingSaturateLower", byte_0.ToString(), 2), GetValue("ShiftRightLogicalNarrowingSaturateLower", apiResult.ToString(), 3));

try {
ShiftRightLogicalNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingSaturateScalarResult = Dummy_ShiftRightLogicalNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 2. ShiftRightLogicalNarrowingSaturateScalar

`Vector64<byte> ShiftRightLogicalNarrowingSaturateScalar(Vector64<ushort> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightLogicalNarrowingSaturateScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ShiftRightLogicalNarrowingSaturateScalar(Vector64<int> value, byte count)
Vector64<int> ShiftRightLogicalNarrowingSaturateScalar(Vector64<long> value, byte count)
Vector64<sbyte> ShiftRightLogicalNarrowingSaturateScalar(Vector64<short> value, byte count)
Vector64<ushort> ShiftRightLogicalNarrowingSaturateScalar(Vector64<uint> value, byte count)
Vector64<uint> ShiftRightLogicalNarrowingSaturateScalar(Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightlogicalnarrowingsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrnh_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalNarrowingSaturateScalar", "Performs 'ShiftRightLogicalNarrowingSaturateScalar' operation.", 0), GetValue("ShiftRightLogicalNarrowingSaturateScalar", Vector64ushort_0.ToString(), 1), GetValue("ShiftRightLogicalNarrowingSaturateScalar", byte_0.ToString(), 2), GetValue("ShiftRightLogicalNarrowingSaturateScalar", apiResult.ToString(), 3));

try {
ShiftRightLogicalNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingSaturateUpperResult = Dummy_ShiftRightLogicalNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 3. ShiftRightLogicalNarrowingSaturateUpper

`Vector128<byte> ShiftRightLogicalNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector128<byte> ShiftRightLogicalNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> ShiftRightLogicalNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, byte count)
Vector128<int> ShiftRightLogicalNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
Vector128<ushort> ShiftRightLogicalNarrowingSaturateUpper(Vector64<ushort> lower, Vector128<uint> value, byte count)
Vector128<uint> ShiftRightLogicalNarrowingSaturateUpper(Vector64<uint> lower, Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowingsaturateupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqshrn_high_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalNarrowingSaturateUpper", "Performs 'ShiftRightLogicalNarrowingSaturateUpper' operation.", 0), GetValue("ShiftRightLogicalNarrowingSaturateUpper", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalNarrowingSaturateUpper", Vector128ushort_0.ToString(), 2), GetValue("ShiftRightLogicalNarrowingSaturateUpper", byte_0.ToString(), 3), GetValue("ShiftRightLogicalNarrowingSaturateUpper", apiResult.ToString(), 4));

try {
ShiftRightLogicalNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingUpperResult = Dummy_ShiftRightLogicalNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 4. ShiftRightLogicalNarrowingUpper

`Vector128<byte> ShiftRightLogicalNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector128<byte> ShiftRightLogicalNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> ShiftRightLogicalNarrowingUpper(Vector64<short> lower, Vector128<int> value, byte count)
Vector128<int> ShiftRightLogicalNarrowingUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalNarrowingUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
Vector128<ushort> ShiftRightLogicalNarrowingUpper(Vector64<ushort> lower, Vector128<uint> value, byte count)
Vector128<uint> ShiftRightLogicalNarrowingUpper(Vector64<uint> lower, Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshrn_high_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalNarrowingUpper", "Performs 'ShiftRightLogicalNarrowingUpper' operation.", 0), GetValue("ShiftRightLogicalNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("ShiftRightLogicalNarrowingUpper", byte_0.ToString(), 3), GetValue("ShiftRightLogicalNarrowingUpper", apiResult.ToString(), 4));

try {
ShiftRightLogicalNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedResult = Dummy_ShiftRightLogicalRoundedTest(Vector64byte_0, byte_0);
apiResult = ShiftRightLogicalRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 5. ShiftRightLogicalRounded

`Vector64<byte> ShiftRightLogicalRounded(Vector64<byte> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalRoundedTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRounded(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalRounded(Vector64<short> value, byte count)
Vector64<int> ShiftRightLogicalRounded(Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightLogicalRounded(Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftRightLogicalRounded(Vector64<ushort> value, byte count)
Vector64<uint> ShiftRightLogicalRounded(Vector64<uint> value, byte count)
Vector128<byte> ShiftRightLogicalRounded(Vector128<byte> value, byte count)
Vector128<short> ShiftRightLogicalRounded(Vector128<short> value, byte count)
Vector128<int> ShiftRightLogicalRounded(Vector128<int> value, byte count)
Vector128<long> ShiftRightLogicalRounded(Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalRounded(Vector128<sbyte> value, byte count)
Vector128<ushort> ShiftRightLogicalRounded(Vector128<ushort> value, byte count)
Vector128<uint> ShiftRightLogicalRounded(Vector128<uint> value, byte count)
Vector128<ulong> ShiftRightLogicalRounded(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalrounded?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshr_n_u8).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRounded", "Performs 'ShiftRightLogicalRounded' operation.", 0), GetValue("ShiftRightLogicalRounded", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalRounded", byte_0.ToString(), 2), GetValue("ShiftRightLogicalRounded", apiResult.ToString(), 3));

try {
ShiftRightLogicalRoundedTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedAddResult = Dummy_ShiftRightLogicalRoundedAddTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftRightLogicalRoundedAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 6. ShiftRightLogicalRoundedAdd

`Vector64<byte> ShiftRightLogicalRoundedAdd(Vector64<byte> addend, Vector64<byte> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalRoundedAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedAdd(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalRoundedAdd(Vector64<short> addend, Vector64<short> value, byte count)
Vector64<int> ShiftRightLogicalRoundedAdd(Vector64<int> addend, Vector64<int> value, byte count)
Vector64<sbyte> ShiftRightLogicalRoundedAdd(Vector64<sbyte> addend, Vector64<sbyte> value, byte count)
Vector64<ushort> ShiftRightLogicalRoundedAdd(Vector64<ushort> addend, Vector64<ushort> value, byte count)
Vector64<uint> ShiftRightLogicalRoundedAdd(Vector64<uint> addend, Vector64<uint> value, byte count)
Vector128<byte> ShiftRightLogicalRoundedAdd(Vector128<byte> addend, Vector128<byte> value, byte count)
Vector128<short> ShiftRightLogicalRoundedAdd(Vector128<short> addend, Vector128<short> value, byte count)
Vector128<int> ShiftRightLogicalRoundedAdd(Vector128<int> addend, Vector128<int> value, byte count)
Vector128<long> ShiftRightLogicalRoundedAdd(Vector128<long> addend, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalRoundedAdd(Vector128<sbyte> addend, Vector128<sbyte> value, byte count)
Vector128<ushort> ShiftRightLogicalRoundedAdd(Vector128<ushort> addend, Vector128<ushort> value, byte count)
Vector128<uint> ShiftRightLogicalRoundedAdd(Vector128<uint> addend, Vector128<uint> value, byte count)
Vector128<ulong> ShiftRightLogicalRoundedAdd(Vector128<ulong> addend, Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundedadd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsra_n_u8).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedAdd", "Performs 'ShiftRightLogicalRoundedAdd' operation.", 0), GetValue("ShiftRightLogicalRoundedAdd", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedAdd", Vector64byte_1.ToString(), 2), GetValue("ShiftRightLogicalRoundedAdd", byte_0.ToString(), 3), GetValue("ShiftRightLogicalRoundedAdd", apiResult.ToString(), 4));

try {
ShiftRightLogicalRoundedAddTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedAddScalarResult = Dummy_ShiftRightLogicalRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightLogicalRoundedAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 7. ShiftRightLogicalRoundedAddScalar

`Vector64<long> ShiftRightLogicalRoundedAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightLogicalRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedAddScalar(addend, value, 1);
}}
// addend = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalRoundedAddScalar(Vector64<ulong> addend, Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundedaddscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsra_n_u64).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedAddScalar", "Performs 'ShiftRightLogicalRoundedAddScalar' operation.", 0), GetValue("ShiftRightLogicalRoundedAddScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedAddScalar", Vector64long_1.ToString(), 2), GetValue("ShiftRightLogicalRoundedAddScalar", byte_0.ToString(), 3), GetValue("ShiftRightLogicalRoundedAddScalar", apiResult.ToString(), 4));

try {
ShiftRightLogicalRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingLowerResult = Dummy_ShiftRightLogicalRoundedNarrowingLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 8. ShiftRightLogicalRoundedNarrowingLower

`Vector64<byte> ShiftRightLogicalRoundedNarrowingLower(Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalRoundedNarrowingLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalRoundedNarrowingLower(Vector128<int> value, byte count)
Vector64<int> ShiftRightLogicalRoundedNarrowingLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightLogicalRoundedNarrowingLower(Vector128<short> value, byte count)
Vector64<ushort> ShiftRightLogicalRoundedNarrowingLower(Vector128<uint> value, byte count)
Vector64<uint> ShiftRightLogicalRoundedNarrowingLower(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshrn_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedNarrowingLower", "Performs 'ShiftRightLogicalRoundedNarrowingLower' operation.", 0), GetValue("ShiftRightLogicalRoundedNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedNarrowingLower", byte_0.ToString(), 2), GetValue("ShiftRightLogicalRoundedNarrowingLower", apiResult.ToString(), 3));

try {
ShiftRightLogicalRoundedNarrowingLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingSaturateLowerResult = Dummy_ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 9. ShiftRightLogicalRoundedNarrowingSaturateLower

`Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateLower(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<int> value, byte count)
Vector64<int> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<short> value, byte count)
Vector64<ushort> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<uint> value, byte count)
Vector64<uint> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowingsaturatelower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrn_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedNarrowingSaturateLower", "Performs 'ShiftRightLogicalRoundedNarrowingSaturateLower' operation.", 0), GetValue("ShiftRightLogicalRoundedNarrowingSaturateLower", Vector128ushort_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedNarrowingSaturateLower", byte_0.ToString(), 2), GetValue("ShiftRightLogicalRoundedNarrowingSaturateLower", apiResult.ToString(), 3));

try {
ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingSaturateScalarResult = Dummy_ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 10. ShiftRightLogicalRoundedNarrowingSaturateScalar

`Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<ushort> value, byte count)`

{0}

```csharp
private Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightLogicalRoundedNarrowingSaturateScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<int> value, byte count)
Vector64<int> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<long> value, byte count)
Vector64<sbyte> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<short> value, byte count)
Vector64<ushort> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<uint> value, byte count)
Vector64<uint> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightlogicalroundednarrowingsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrnh_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedNarrowingSaturateScalar", "Performs 'ShiftRightLogicalRoundedNarrowingSaturateScalar' operation.", 0), GetValue("ShiftRightLogicalRoundedNarrowingSaturateScalar", Vector64ushort_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedNarrowingSaturateScalar", byte_0.ToString(), 2), GetValue("ShiftRightLogicalRoundedNarrowingSaturateScalar", apiResult.ToString(), 3));

try {
ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingSaturateUpperResult = Dummy_ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 11. ShiftRightLogicalRoundedNarrowingSaturateUpper

`Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, byte count)
Vector128<int> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
Vector128<ushort> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<ushort> lower, Vector128<uint> value, byte count)
Vector128<uint> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<uint> lower, Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowingsaturateupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqrshrn_high_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedNarrowingSaturateUpper", "Performs 'ShiftRightLogicalRoundedNarrowingSaturateUpper' operation.", 0), GetValue("ShiftRightLogicalRoundedNarrowingSaturateUpper", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedNarrowingSaturateUpper", Vector128ushort_0.ToString(), 2), GetValue("ShiftRightLogicalRoundedNarrowingSaturateUpper", byte_0.ToString(), 3), GetValue("ShiftRightLogicalRoundedNarrowingSaturateUpper", apiResult.ToString(), 4));

try {
ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingUpperResult = Dummy_ShiftRightLogicalRoundedNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 12. ShiftRightLogicalRoundedNarrowingUpper

`Vector128<byte> ShiftRightLogicalRoundedNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

{0}

```csharp
private Vector128<byte> ShiftRightLogicalRoundedNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingUpper(lower, value, 1);
}}
// lower = {1}
// value = {2}
// count = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> ShiftRightLogicalRoundedNarrowingUpper(Vector64<short> lower, Vector128<int> value, byte count)
Vector128<int> ShiftRightLogicalRoundedNarrowingUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightLogicalRoundedNarrowingUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
Vector128<ushort> ShiftRightLogicalRoundedNarrowingUpper(Vector64<ushort> lower, Vector128<uint> value, byte count)
Vector128<uint> ShiftRightLogicalRoundedNarrowingUpper(Vector64<uint> lower, Vector128<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshrn_high_n_u16).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedNarrowingUpper", "Performs 'ShiftRightLogicalRoundedNarrowingUpper' operation.", 0), GetValue("ShiftRightLogicalRoundedNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("ShiftRightLogicalRoundedNarrowingUpper", byte_0.ToString(), 3), GetValue("ShiftRightLogicalRoundedNarrowingUpper", apiResult.ToString(), 4));

try {
ShiftRightLogicalRoundedNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedScalarResult = Dummy_ShiftRightLogicalRoundedScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightLogicalRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 13. ShiftRightLogicalRoundedScalar

`Vector64<long> ShiftRightLogicalRoundedScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightLogicalRoundedScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalRoundedScalar(Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrshr_n_u64).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalRoundedScalar", "Performs 'ShiftRightLogicalRoundedScalar' operation.", 0), GetValue("ShiftRightLogicalRoundedScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightLogicalRoundedScalar", byte_0.ToString(), 2), GetValue("ShiftRightLogicalRoundedScalar", apiResult.ToString(), 3));

try {
ShiftRightLogicalRoundedScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ShiftRightLogicalScalarResult = Dummy_ShiftRightLogicalScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightLogicalScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 14. ShiftRightLogicalScalar

`Vector64<long> ShiftRightLogicalScalar(Vector64<long> value, byte count)`

{0}

```csharp
private Vector64<long> ShiftRightLogicalScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalScalar(value, 1);
}}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalScalar(Vector64<ulong> value, byte count)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vshr_n_u64).

Assembly generated:

```armasm", GetValue("ShiftRightLogicalScalar", "Performs 'ShiftRightLogicalScalar' operation.", 0), GetValue("ShiftRightLogicalScalar", Vector64long_0.ToString(), 1), GetValue("ShiftRightLogicalScalar", byte_0.ToString(), 2), GetValue("ShiftRightLogicalScalar", apiResult.ToString(), 3));

try {
ShiftRightLogicalScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SignExtendWideningLowerResult = Dummy_SignExtendWideningLowerTest(Vector64short_0);
apiResult = SignExtendWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 15. SignExtendWideningLower

`Vector128<int> SignExtendWideningLower(Vector64<short> value)`

{0}

```csharp
private Vector128<int> SignExtendWideningLowerTest(Vector64<short> value)
{{
  return AdvSimd.SignExtendWideningLower(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> SignExtendWideningLower(Vector64<int> value)
Vector128<short> SignExtendWideningLower(Vector64<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.signextendwideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmovl_s16).

Assembly generated:

```armasm", GetValue("SignExtendWideningLower", "Performs 'SignExtendWideningLower' operation.", 0), GetValue("SignExtendWideningLower", Vector64short_0.ToString(), 1), GetValue("SignExtendWideningLower", apiResult.ToString(), 2));

try {
SignExtendWideningLowerTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SignExtendWideningUpperResult = Dummy_SignExtendWideningUpperTest(Vector128short_0);
apiResult = SignExtendWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 16. SignExtendWideningUpper

`Vector128<int> SignExtendWideningUpper(Vector128<short> value)`

{0}

```csharp
private Vector128<int> SignExtendWideningUpperTest(Vector128<short> value)
{{
  return AdvSimd.SignExtendWideningUpper(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> SignExtendWideningUpper(Vector128<int> value)
Vector128<short> SignExtendWideningUpper(Vector128<sbyte> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.signextendwideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmovl_high_s16).

Assembly generated:

```armasm", GetValue("SignExtendWideningUpper", "Performs 'SignExtendWideningUpper' operation.", 0), GetValue("SignExtendWideningUpper", Vector128short_0.ToString(), 1), GetValue("SignExtendWideningUpper", apiResult.ToString(), 2));

try {
SignExtendWideningUpperTest(Vector128short_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SqrtResult = Dummy_SqrtTest(Vector64float_0);
apiResult = SqrtResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 17. Sqrt

`Vector64<float> Sqrt(Vector64<float> value)`

{0}

```csharp
private Vector64<float> SqrtTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.Sqrt(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Sqrt(Vector128<double> value)
Vector128<float> Sqrt(Vector128<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.sqrt?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsqrt_f32).

Assembly generated:

```armasm", GetValue("Sqrt", "Performs 'Sqrt' operation.", 0), GetValue("Sqrt", Vector64float_0.ToString(), 1), GetValue("Sqrt", apiResult.ToString(), 2));

try {
SqrtTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SqrtScalarResult = Dummy_SqrtScalarTest(Vector64double_0);
apiResult = SqrtScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 18. SqrtScalar

`Vector64<double> SqrtScalar(Vector64<double> value)`

{0}

```csharp
private Vector64<double> SqrtScalarTest(Vector64<double> value)
{{
  return AdvSimd.SqrtScalar(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> SqrtScalar(Vector64<float> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.sqrtscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsqrt_f64).

Assembly generated:

```armasm", GetValue("SqrtScalar", "Performs 'SqrtScalar' operation.", 0), GetValue("SqrtScalar", Vector64double_0.ToString(), 1), GetValue("SqrtScalar", apiResult.ToString(), 2));

try {
SqrtScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
Dummy_StoreTest(bytePtr_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 19. Store

`void Store(byte* address, Vector64<byte> source)`

{0}

```csharp
private void StoreTest(byte* address, Vector64<byte> source)
{{
  AdvSimd.Store(address, source);
}}
// address = {1}
// source = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
void Store(double* address, Vector64<double> source)
void Store(short* address, Vector64<short> source)
void Store(int* address, Vector64<int> source)
void Store(long* address, Vector64<long> source)
void Store(sbyte* address, Vector64<sbyte> source)
void Store(float* address, Vector64<float> source)
void Store(ushort* address, Vector64<ushort> source)
void Store(uint* address, Vector64<uint> source)
void Store(ulong* address, Vector64<ulong> source)
void Store(byte* address, Vector128<byte> source)
void Store(double* address, Vector128<double> source)
void Store(short* address, Vector128<short> source)
void Store(int* address, Vector128<int> source)
void Store(long* address, Vector128<long> source)
void Store(sbyte* address, Vector128<sbyte> source)
void Store(float* address, Vector128<float> source)
void Store(ushort* address, Vector128<ushort> source)
void Store(uint* address, Vector128<uint> source)
void Store(ulong* address, Vector128<ulong> source)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.store?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vst1_u8).

Assembly generated:

```armasm", GetValue("Store", "Performs 'Store' operation.", 0), GetValue("Store", "<address>".ToString(), 1), GetValue("Store", Vector64byte_0.ToString(), 2));

try {
StoreTest(bytePtr_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
Dummy_StorePairTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 20. StorePair

`void StorePair(byte* address, Vector64<byte> value1, Vector64<byte> value2)`

{0}

```csharp
private void StorePairTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{{
  AdvSimd.Arm64.StorePair(address, value1, value2);
}}
// address = {1}
// value1 = {2}
// value2 = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
void StorePair(double* address, Vector64<double> value1, Vector64<double> value2)
void StorePair(short* address, Vector64<short> value1, Vector64<short> value2)
void StorePair(int* address, Vector64<int> value1, Vector64<int> value2)
void StorePair(long* address, Vector64<long> value1, Vector64<long> value2)
void StorePair(sbyte* address, Vector64<sbyte> value1, Vector64<sbyte> value2)
void StorePair(float* address, Vector64<float> value1, Vector64<float> value2)
void StorePair(ushort* address, Vector64<ushort> value1, Vector64<ushort> value2)
void StorePair(uint* address, Vector64<uint> value1, Vector64<uint> value2)
void StorePair(ulong* address, Vector64<ulong> value1, Vector64<ulong> value2)
void StorePair(byte* address, Vector128<byte> value1, Vector128<byte> value2)
void StorePair(double* address, Vector128<double> value1, Vector128<double> value2)
void StorePair(short* address, Vector128<short> value1, Vector128<short> value2)
void StorePair(int* address, Vector128<int> value1, Vector128<int> value2)
void StorePair(long* address, Vector128<long> value1, Vector128<long> value2)
void StorePair(sbyte* address, Vector128<sbyte> value1, Vector128<sbyte> value2)
void StorePair(float* address, Vector128<float> value1, Vector128<float> value2)
void StorePair(ushort* address, Vector128<ushort> value1, Vector128<ushort> value2)
void StorePair(uint* address, Vector128<uint> value1, Vector128<uint> value2)
void StorePair(ulong* address, Vector128<ulong> value1, Vector128<ulong> value2)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepair?view=net-5.0).

Assembly generated:

```armasm", GetValue("StorePair", "Performs 'StorePair' operation.", 0), GetValue("StorePair", "<address>".ToString(), 1), GetValue("StorePair", Vector64byte_0.ToString(), 2), GetValue("StorePair", Vector64byte_1.ToString(), 3));

try {
StorePairTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
Dummy_StorePairNonTemporalTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 21. StorePairNonTemporal

`void StorePairNonTemporal(byte* address, Vector64<byte> value1, Vector64<byte> value2)`

{0}

```csharp
private void StorePairNonTemporalTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{{
  AdvSimd.Arm64.StorePairNonTemporal(address, value1, value2);
}}
// address = {1}
// value1 = {2}
// value2 = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
void StorePairNonTemporal(double* address, Vector64<double> value1, Vector64<double> value2)
void StorePairNonTemporal(short* address, Vector64<short> value1, Vector64<short> value2)
void StorePairNonTemporal(int* address, Vector64<int> value1, Vector64<int> value2)
void StorePairNonTemporal(long* address, Vector64<long> value1, Vector64<long> value2)
void StorePairNonTemporal(sbyte* address, Vector64<sbyte> value1, Vector64<sbyte> value2)
void StorePairNonTemporal(float* address, Vector64<float> value1, Vector64<float> value2)
void StorePairNonTemporal(ushort* address, Vector64<ushort> value1, Vector64<ushort> value2)
void StorePairNonTemporal(uint* address, Vector64<uint> value1, Vector64<uint> value2)
void StorePairNonTemporal(ulong* address, Vector64<ulong> value1, Vector64<ulong> value2)
void StorePairNonTemporal(byte* address, Vector128<byte> value1, Vector128<byte> value2)
void StorePairNonTemporal(double* address, Vector128<double> value1, Vector128<double> value2)
void StorePairNonTemporal(short* address, Vector128<short> value1, Vector128<short> value2)
void StorePairNonTemporal(int* address, Vector128<int> value1, Vector128<int> value2)
void StorePairNonTemporal(long* address, Vector128<long> value1, Vector128<long> value2)
void StorePairNonTemporal(sbyte* address, Vector128<sbyte> value1, Vector128<sbyte> value2)
void StorePairNonTemporal(float* address, Vector128<float> value1, Vector128<float> value2)
void StorePairNonTemporal(ushort* address, Vector128<ushort> value1, Vector128<ushort> value2)
void StorePairNonTemporal(uint* address, Vector128<uint> value1, Vector128<uint> value2)
void StorePairNonTemporal(ulong* address, Vector128<ulong> value1, Vector128<ulong> value2)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepairnontemporal?view=net-5.0).

Assembly generated:

```armasm", GetValue("StorePairNonTemporal", "Performs 'StorePairNonTemporal' operation.", 0), GetValue("StorePairNonTemporal", "<address>".ToString(), 1), GetValue("StorePairNonTemporal", Vector64byte_0.ToString(), 2), GetValue("StorePairNonTemporal", Vector64byte_1.ToString(), 3));

try {
StorePairNonTemporalTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (int* intPtr_0 = intArray)
{

try {
Dummy_StorePairScalarTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 22. StorePairScalar

`void StorePairScalar(int* address, Vector64<int> value1, Vector64<int> value2)`

{0}

```csharp
private void StorePairScalarTest(int* address, Vector64<int> value1, Vector64<int> value2)
{{
  AdvSimd.Arm64.StorePairScalar(address, value1, value2);
}}
// address = {1}
// value1 = {2}
// value2 = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
void StorePairScalar(float* address, Vector64<float> value1, Vector64<float> value2)
void StorePairScalar(uint* address, Vector64<uint> value1, Vector64<uint> value2)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepairscalar?view=net-5.0).

Assembly generated:

```armasm", GetValue("StorePairScalar", "Performs 'StorePairScalar' operation.", 0), GetValue("StorePairScalar", "<address>".ToString(), 1), GetValue("StorePairScalar", Vector64int_0.ToString(), 2), GetValue("StorePairScalar", Vector64int_1.ToString(), 3));

try {
StorePairScalarTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (int* intPtr_0 = intArray)
{

try {
Dummy_StorePairScalarNonTemporalTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 23. StorePairScalarNonTemporal

`void StorePairScalarNonTemporal(int* address, Vector64<int> value1, Vector64<int> value2)`

{0}

```csharp
private void StorePairScalarNonTemporalTest(int* address, Vector64<int> value1, Vector64<int> value2)
{{
  AdvSimd.Arm64.StorePairScalarNonTemporal(address, value1, value2);
}}
// address = {1}
// value1 = {2}
// value2 = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
void StorePairScalarNonTemporal(float* address, Vector64<float> value1, Vector64<float> value2)
void StorePairScalarNonTemporal(uint* address, Vector64<uint> value1, Vector64<uint> value2)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepairscalarnontemporal?view=net-5.0).

Assembly generated:

```armasm", GetValue("StorePairScalarNonTemporal", "Performs 'StorePairScalarNonTemporal' operation.", 0), GetValue("StorePairScalarNonTemporal", "<address>".ToString(), 1), GetValue("StorePairScalarNonTemporal", Vector64int_0.ToString(), 2), GetValue("StorePairScalarNonTemporal", Vector64int_1.ToString(), 3));

try {
StorePairScalarNonTemporalTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
Dummy_StoreSelectedScalarTest(bytePtr_0, Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 24. StoreSelectedScalar

`void StoreSelectedScalar(byte* address, Vector64<byte> value, byte index)`

{0}

```csharp
private void StoreSelectedScalarTest(byte* address, Vector64<byte> value, byte index)
{{
  AdvSimd.StoreSelectedScalar(address, value, 3);
}}
// address = {1}
// value = {2}
// index = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
void StoreSelectedScalar(short* address, Vector64<short> value, byte index)
void StoreSelectedScalar(int* address, Vector64<int> value, byte index)
void StoreSelectedScalar(sbyte* address, Vector64<sbyte> value, byte index)
void StoreSelectedScalar(float* address, Vector64<float> value, byte index)
void StoreSelectedScalar(ushort* address, Vector64<ushort> value, byte index)
void StoreSelectedScalar(uint* address, Vector64<uint> value, byte index)
void StoreSelectedScalar(byte* address, Vector128<byte> value, byte index)
void StoreSelectedScalar(double* address, Vector128<double> value, byte index)
void StoreSelectedScalar(short* address, Vector128<short> value, byte index)
void StoreSelectedScalar(int* address, Vector128<int> value, byte index)
void StoreSelectedScalar(long* address, Vector128<long> value, byte index)
void StoreSelectedScalar(sbyte* address, Vector128<sbyte> value, byte index)
void StoreSelectedScalar(float* address, Vector128<float> value, byte index)
void StoreSelectedScalar(ushort* address, Vector128<ushort> value, byte index)
void StoreSelectedScalar(uint* address, Vector128<uint> value, byte index)
void StoreSelectedScalar(ulong* address, Vector128<ulong> value, byte index)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.storeselectedscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vst1_lane_u8).

Assembly generated:

```armasm", GetValue("StoreSelectedScalar", "Performs 'StoreSelectedScalar' operation.", 0), GetValue("StoreSelectedScalar", "<address>".ToString(), 1), GetValue("StoreSelectedScalar", Vector64byte_0.ToString(), 2), GetValue("StoreSelectedScalar", byte_0.ToString(), 3));

try {
StoreSelectedScalarTest(bytePtr_0, Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
// ----------------------------------------------------------------

try {
var SubtractResult = Dummy_SubtractTest(Vector64byte_0, Vector64byte_1);
apiResult = SubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 25. Subtract

`Vector64<byte> Subtract(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> SubtractTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Subtract(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> Subtract(Vector64<short> left, Vector64<short> right)
Vector64<int> Subtract(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> Subtract(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Subtract(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Subtract(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Subtract(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right)
Vector128<short> Subtract(Vector128<short> left, Vector128<short> right)
Vector128<int> Subtract(Vector128<int> left, Vector128<int> right)
Vector128<long> Subtract(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Subtract(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Subtract(Vector128<double> left, Vector128<double> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtract?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.subtract?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsub_u8).

Assembly generated:

```armasm", GetValue("Subtract", "Performs 'Subtract' operation.", 0), GetValue("Subtract", Vector64byte_0.ToString(), 1), GetValue("Subtract", Vector64byte_1.ToString(), 2), GetValue("Subtract", apiResult.ToString(), 3));

try {
SubtractTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractHighNarrowingLowerResult = Dummy_SubtractHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 26. SubtractHighNarrowingLower

`Vector64<byte> SubtractHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector64<byte> SubtractHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractHighNarrowingLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> SubtractHighNarrowingLower(Vector128<int> left, Vector128<int> right)
Vector64<int> SubtractHighNarrowingLower(Vector128<long> left, Vector128<long> right)
Vector64<sbyte> SubtractHighNarrowingLower(Vector128<short> left, Vector128<short> right)
Vector64<ushort> SubtractHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
Vector64<uint> SubtractHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtracthighnarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsubhn_u16).

Assembly generated:

```armasm", GetValue("SubtractHighNarrowingLower", "Performs 'SubtractHighNarrowingLower' operation.", 0), GetValue("SubtractHighNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("SubtractHighNarrowingLower", Vector128ushort_1.ToString(), 2), GetValue("SubtractHighNarrowingLower", apiResult.ToString(), 3));

try {
SubtractHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractHighNarrowingUpperResult = Dummy_SubtractHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 27. SubtractHighNarrowingUpper

`Vector128<byte> SubtractHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector128<byte> SubtractHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractHighNarrowingUpper(lower, left, right);
}}
// lower = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> SubtractHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
Vector128<int> SubtractHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
Vector128<sbyte> SubtractHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
Vector128<ushort> SubtractHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
Vector128<uint> SubtractHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtracthighnarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsubhn_high_u16).

Assembly generated:

```armasm", GetValue("SubtractHighNarrowingUpper", "Performs 'SubtractHighNarrowingUpper' operation.", 0), GetValue("SubtractHighNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("SubtractHighNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("SubtractHighNarrowingUpper", Vector128ushort_1.ToString(), 3), GetValue("SubtractHighNarrowingUpper", apiResult.ToString(), 4));

try {
SubtractHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractRoundedHighNarrowingLowerResult = Dummy_SubtractRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractRoundedHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 28. SubtractRoundedHighNarrowingLower

`Vector64<byte> SubtractRoundedHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector64<byte> SubtractRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractRoundedHighNarrowingLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> SubtractRoundedHighNarrowingLower(Vector128<int> left, Vector128<int> right)
Vector64<int> SubtractRoundedHighNarrowingLower(Vector128<long> left, Vector128<long> right)
Vector64<sbyte> SubtractRoundedHighNarrowingLower(Vector128<short> left, Vector128<short> right)
Vector64<ushort> SubtractRoundedHighNarrowingLower(Vector128<uint> left, Vector128<uint> right)
Vector64<uint> SubtractRoundedHighNarrowingLower(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractroundedhighnarrowinglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsubhn_u16).

Assembly generated:

```armasm", GetValue("SubtractRoundedHighNarrowingLower", "Performs 'SubtractRoundedHighNarrowingLower' operation.", 0), GetValue("SubtractRoundedHighNarrowingLower", Vector128ushort_0.ToString(), 1), GetValue("SubtractRoundedHighNarrowingLower", Vector128ushort_1.ToString(), 2), GetValue("SubtractRoundedHighNarrowingLower", apiResult.ToString(), 3));

try {
SubtractRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractRoundedHighNarrowingUpperResult = Dummy_SubtractRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractRoundedHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 29. SubtractRoundedHighNarrowingUpper

`Vector128<byte> SubtractRoundedHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

{0}

```csharp
private Vector128<byte> SubtractRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractRoundedHighNarrowingUpper(lower, left, right);
}}
// lower = {1}
// left = {2}
// right = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> SubtractRoundedHighNarrowingUpper(Vector64<short> lower, Vector128<int> left, Vector128<int> right)
Vector128<int> SubtractRoundedHighNarrowingUpper(Vector64<int> lower, Vector128<long> left, Vector128<long> right)
Vector128<sbyte> SubtractRoundedHighNarrowingUpper(Vector64<sbyte> lower, Vector128<short> left, Vector128<short> right)
Vector128<ushort> SubtractRoundedHighNarrowingUpper(Vector64<ushort> lower, Vector128<uint> left, Vector128<uint> right)
Vector128<uint> SubtractRoundedHighNarrowingUpper(Vector64<uint> lower, Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractroundedhighnarrowingupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vrsubhn_high_u16).

Assembly generated:

```armasm", GetValue("SubtractRoundedHighNarrowingUpper", "Performs 'SubtractRoundedHighNarrowingUpper' operation.", 0), GetValue("SubtractRoundedHighNarrowingUpper", Vector64byte_0.ToString(), 1), GetValue("SubtractRoundedHighNarrowingUpper", Vector128ushort_0.ToString(), 2), GetValue("SubtractRoundedHighNarrowingUpper", Vector128ushort_1.ToString(), 3), GetValue("SubtractRoundedHighNarrowingUpper", apiResult.ToString(), 4));

try {
SubtractRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractSaturateResult = Dummy_SubtractSaturateTest(Vector64byte_0, Vector64byte_1);
apiResult = SubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 30. SubtractSaturate

`Vector64<byte> SubtractSaturate(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> SubtractSaturateTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.SubtractSaturate(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<short> SubtractSaturate(Vector64<short> left, Vector64<short> right)
Vector64<int> SubtractSaturate(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> SubtractSaturate(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> SubtractSaturate(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> SubtractSaturate(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> SubtractSaturate(Vector128<byte> left, Vector128<byte> right)
Vector128<short> SubtractSaturate(Vector128<short> left, Vector128<short> right)
Vector128<int> SubtractSaturate(Vector128<int> left, Vector128<int> right)
Vector128<long> SubtractSaturate(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> SubtractSaturate(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> SubtractSaturate(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> SubtractSaturate(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> SubtractSaturate(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractsaturate?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqsub_u8).

Assembly generated:

```armasm", GetValue("SubtractSaturate", "Performs 'SubtractSaturate' operation.", 0), GetValue("SubtractSaturate", Vector64byte_0.ToString(), 1), GetValue("SubtractSaturate", Vector64byte_1.ToString(), 2), GetValue("SubtractSaturate", apiResult.ToString(), 3));

try {
SubtractSaturateTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractSaturateScalarResult = Dummy_SubtractSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = SubtractSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 31. SubtractSaturateScalar

`Vector64<long> SubtractSaturateScalar(Vector64<long> left, Vector64<long> right)`

{0}

```csharp
private Vector64<long> SubtractSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{{
  return AdvSimd.SubtractSaturateScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> SubtractSaturateScalar(Vector64<ulong> left, Vector64<ulong> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<byte> SubtractSaturateScalar(Vector64<byte> left, Vector64<byte> right)
Vector64<short> SubtractSaturateScalar(Vector64<short> left, Vector64<short> right)
Vector64<int> SubtractSaturateScalar(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> SubtractSaturateScalar(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<ushort> SubtractSaturateScalar(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> SubtractSaturateScalar(Vector64<uint> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.subtractsaturatescalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqsub_s64).

Assembly generated:

```armasm", GetValue("SubtractSaturateScalar", "Performs 'SubtractSaturateScalar' operation.", 0), GetValue("SubtractSaturateScalar", Vector64long_0.ToString(), 1), GetValue("SubtractSaturateScalar", Vector64long_1.ToString(), 2), GetValue("SubtractSaturateScalar", apiResult.ToString(), 3));

try {
SubtractSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractScalarResult = Dummy_SubtractScalarTest(Vector64double_0, Vector64double_1);
apiResult = SubtractScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 32. SubtractScalar

`Vector64<double> SubtractScalar(Vector64<double> left, Vector64<double> right)`

{0}

```csharp
private Vector64<double> SubtractScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.SubtractScalar(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<long> SubtractScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> SubtractScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> SubtractScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractscalar?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsub_f64).

Assembly generated:

```armasm", GetValue("SubtractScalar", "Performs 'SubtractScalar' operation.", 0), GetValue("SubtractScalar", Vector64double_0.ToString(), 1), GetValue("SubtractScalar", Vector64double_1.ToString(), 2), GetValue("SubtractScalar", apiResult.ToString(), 3));

try {
SubtractScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractWideningLowerResult = Dummy_SubtractWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = SubtractWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 33. SubtractWideningLower

`Vector128<ushort> SubtractWideningLower(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector128<ushort> SubtractWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.SubtractWideningLower(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> SubtractWideningLower(Vector64<short> left, Vector64<short> right)
Vector128<long> SubtractWideningLower(Vector64<int> left, Vector64<int> right)
Vector128<short> SubtractWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<uint> SubtractWideningLower(Vector64<ushort> left, Vector64<ushort> right)
Vector128<ulong> SubtractWideningLower(Vector64<uint> left, Vector64<uint> right)
Vector128<short> SubtractWideningLower(Vector128<short> left, Vector64<sbyte> right)
Vector128<int> SubtractWideningLower(Vector128<int> left, Vector64<short> right)
Vector128<long> SubtractWideningLower(Vector128<long> left, Vector64<int> right)
Vector128<ushort> SubtractWideningLower(Vector128<ushort> left, Vector64<byte> right)
Vector128<uint> SubtractWideningLower(Vector128<uint> left, Vector64<ushort> right)
Vector128<ulong> SubtractWideningLower(Vector128<ulong> left, Vector64<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractwideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsubl_u8).

Assembly generated:

```armasm", GetValue("SubtractWideningLower", "Performs 'SubtractWideningLower' operation.", 0), GetValue("SubtractWideningLower", Vector64byte_0.ToString(), 1), GetValue("SubtractWideningLower", Vector64byte_1.ToString(), 2), GetValue("SubtractWideningLower", apiResult.ToString(), 3));

try {
SubtractWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var SubtractWideningUpperResult = Dummy_SubtractWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = SubtractWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 34. SubtractWideningUpper

`Vector128<ushort> SubtractWideningUpper(Vector128<byte> left, Vector128<byte> right)`

{0}

```csharp
private Vector128<ushort> SubtractWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.SubtractWideningUpper(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> SubtractWideningUpper(Vector128<short> left, Vector128<short> right)
Vector128<short> SubtractWideningUpper(Vector128<short> left, Vector128<sbyte> right)
Vector128<int> SubtractWideningUpper(Vector128<int> left, Vector128<short> right)
Vector128<long> SubtractWideningUpper(Vector128<int> left, Vector128<int> right)
Vector128<long> SubtractWideningUpper(Vector128<long> left, Vector128<int> right)
Vector128<short> SubtractWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<ushort> SubtractWideningUpper(Vector128<ushort> left, Vector128<byte> right)
Vector128<uint> SubtractWideningUpper(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> SubtractWideningUpper(Vector128<uint> left, Vector128<ushort> right)
Vector128<ulong> SubtractWideningUpper(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> SubtractWideningUpper(Vector128<ulong> left, Vector128<uint> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractwideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vsubl_high_u8).

Assembly generated:

```armasm", GetValue("SubtractWideningUpper", "Performs 'SubtractWideningUpper' operation.", 0), GetValue("SubtractWideningUpper", Vector128byte_0.ToString(), 1), GetValue("SubtractWideningUpper", Vector128byte_1.ToString(), 2), GetValue("SubtractWideningUpper", apiResult.ToString(), 3));

try {
SubtractWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var TransposeEvenResult = Dummy_TransposeEvenTest(Vector64byte_0, Vector64byte_1);
apiResult = TransposeEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 35. TransposeEven

`Vector64<byte> TransposeEven(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> TransposeEvenTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.TransposeEven(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> TransposeEven(Vector64<short> left, Vector64<short> right)
Vector64<int> TransposeEven(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> TransposeEven(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> TransposeEven(Vector64<float> left, Vector64<float> right)
Vector64<ushort> TransposeEven(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> TransposeEven(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> TransposeEven(Vector128<byte> left, Vector128<byte> right)
Vector128<double> TransposeEven(Vector128<double> left, Vector128<double> right)
Vector128<short> TransposeEven(Vector128<short> left, Vector128<short> right)
Vector128<int> TransposeEven(Vector128<int> left, Vector128<int> right)
Vector128<long> TransposeEven(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> TransposeEven(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> TransposeEven(Vector128<float> left, Vector128<float> right)
Vector128<ushort> TransposeEven(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> TransposeEven(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> TransposeEven(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.transposeeven?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vtrn1_u8).

Assembly generated:

```armasm", GetValue("TransposeEven", "Performs 'TransposeEven' operation.", 0), GetValue("TransposeEven", Vector64byte_0.ToString(), 1), GetValue("TransposeEven", Vector64byte_1.ToString(), 2), GetValue("TransposeEven", apiResult.ToString(), 3));

try {
TransposeEvenTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var TransposeOddResult = Dummy_TransposeOddTest(Vector64byte_0, Vector64byte_1);
apiResult = TransposeOddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 36. TransposeOdd

`Vector64<byte> TransposeOdd(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> TransposeOddTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.TransposeOdd(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> TransposeOdd(Vector64<short> left, Vector64<short> right)
Vector64<int> TransposeOdd(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> TransposeOdd(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> TransposeOdd(Vector64<float> left, Vector64<float> right)
Vector64<ushort> TransposeOdd(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> TransposeOdd(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> TransposeOdd(Vector128<byte> left, Vector128<byte> right)
Vector128<double> TransposeOdd(Vector128<double> left, Vector128<double> right)
Vector128<short> TransposeOdd(Vector128<short> left, Vector128<short> right)
Vector128<int> TransposeOdd(Vector128<int> left, Vector128<int> right)
Vector128<long> TransposeOdd(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> TransposeOdd(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> TransposeOdd(Vector128<float> left, Vector128<float> right)
Vector128<ushort> TransposeOdd(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> TransposeOdd(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> TransposeOdd(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.transposeodd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vtrn2_u8).

Assembly generated:

```armasm", GetValue("TransposeOdd", "Performs 'TransposeOdd' operation.", 0), GetValue("TransposeOdd", Vector64byte_0.ToString(), 1), GetValue("TransposeOdd", Vector64byte_1.ToString(), 2), GetValue("TransposeOdd", apiResult.ToString(), 3));

try {
TransposeOddTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var UnzipEvenResult = Dummy_UnzipEvenTest(Vector64byte_0, Vector64byte_1);
apiResult = UnzipEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 37. UnzipEven

`Vector64<byte> UnzipEven(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> UnzipEvenTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.UnzipEven(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> UnzipEven(Vector64<short> left, Vector64<short> right)
Vector64<int> UnzipEven(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> UnzipEven(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> UnzipEven(Vector64<float> left, Vector64<float> right)
Vector64<ushort> UnzipEven(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> UnzipEven(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> UnzipEven(Vector128<byte> left, Vector128<byte> right)
Vector128<double> UnzipEven(Vector128<double> left, Vector128<double> right)
Vector128<short> UnzipEven(Vector128<short> left, Vector128<short> right)
Vector128<int> UnzipEven(Vector128<int> left, Vector128<int> right)
Vector128<long> UnzipEven(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> UnzipEven(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> UnzipEven(Vector128<float> left, Vector128<float> right)
Vector128<ushort> UnzipEven(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> UnzipEven(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> UnzipEven(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.unzipeven?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vuzp1_u8).

Assembly generated:

```armasm", GetValue("UnzipEven", "Performs 'UnzipEven' operation.", 0), GetValue("UnzipEven", Vector64byte_0.ToString(), 1), GetValue("UnzipEven", Vector64byte_1.ToString(), 2), GetValue("UnzipEven", apiResult.ToString(), 3));

try {
UnzipEvenTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var UnzipOddResult = Dummy_UnzipOddTest(Vector64byte_0, Vector64byte_1);
apiResult = UnzipOddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 38. UnzipOdd

`Vector64<byte> UnzipOdd(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> UnzipOddTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.UnzipOdd(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> UnzipOdd(Vector64<short> left, Vector64<short> right)
Vector64<int> UnzipOdd(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> UnzipOdd(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> UnzipOdd(Vector64<float> left, Vector64<float> right)
Vector64<ushort> UnzipOdd(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> UnzipOdd(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> UnzipOdd(Vector128<byte> left, Vector128<byte> right)
Vector128<double> UnzipOdd(Vector128<double> left, Vector128<double> right)
Vector128<short> UnzipOdd(Vector128<short> left, Vector128<short> right)
Vector128<int> UnzipOdd(Vector128<int> left, Vector128<int> right)
Vector128<long> UnzipOdd(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> UnzipOdd(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> UnzipOdd(Vector128<float> left, Vector128<float> right)
Vector128<ushort> UnzipOdd(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> UnzipOdd(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> UnzipOdd(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.unzipodd?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vuzp2_u8).

Assembly generated:

```armasm", GetValue("UnzipOdd", "Performs 'UnzipOdd' operation.", 0), GetValue("UnzipOdd", Vector64byte_0.ToString(), 1), GetValue("UnzipOdd", Vector64byte_1.ToString(), 2), GetValue("UnzipOdd", apiResult.ToString(), 3));

try {
UnzipOddTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var VectorTableLookupResult = Dummy_VectorTableLookupTest(Vector128byte_0, Vector64byte_0);
apiResult = VectorTableLookupResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 39. VectorTableLookup

`Vector64<byte> VectorTableLookup(Vector128<byte> table, Vector64<byte> byteIndexes)`

{0}

```csharp
private Vector64<byte> VectorTableLookupTest(Vector128<byte> table, Vector64<byte> byteIndexes)
{{
  return AdvSimd.VectorTableLookup(table, byteIndexes);
}}
// table = {1}
// byteIndexes = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> VectorTableLookup(Vector128<sbyte> table, Vector64<sbyte> byteIndexes)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> VectorTableLookup(Vector128<byte> table, Vector128<byte> byteIndexes)
Vector128<sbyte> VectorTableLookup(Vector128<sbyte> table, Vector128<sbyte> byteIndexes)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.vectortablelookup?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.vectortablelookup?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqvtbl1_u8).

Assembly generated:

```armasm", GetValue("VectorTableLookup", "Performs 'VectorTableLookup' operation.", 0), GetValue("VectorTableLookup", Vector128byte_0.ToString(), 1), GetValue("VectorTableLookup", Vector64byte_0.ToString(), 2), GetValue("VectorTableLookup", apiResult.ToString(), 3));

try {
VectorTableLookupTest(Vector128byte_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var VectorTableLookupExtensionResult = Dummy_VectorTableLookupExtensionTest(Vector64byte_0, Vector128byte_0, Vector64byte_1);
apiResult = VectorTableLookupExtensionResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 40. VectorTableLookupExtension

`Vector64<byte> VectorTableLookupExtension(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)`

{0}

```csharp
private Vector64<byte> VectorTableLookupExtensionTest(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)
{{
  return AdvSimd.VectorTableLookupExtension(defaultValues, table, byteIndexes);
}}
// defaultValues = {1}
// table = {2}
// byteIndexes = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> VectorTableLookupExtension(Vector64<sbyte> defaultValues, Vector128<sbyte> table, Vector64<sbyte> byteIndexes)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> VectorTableLookupExtension(Vector128<byte> defaultValues, Vector128<byte> table, Vector128<byte> byteIndexes)
Vector128<sbyte> VectorTableLookupExtension(Vector128<sbyte> defaultValues, Vector128<sbyte> table, Vector128<sbyte> byteIndexes)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.vectortablelookupextension?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.vectortablelookupextension?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vqvtbx1_u8).

Assembly generated:

```armasm", GetValue("VectorTableLookupExtension", "Performs 'VectorTableLookupExtension' operation.", 0), GetValue("VectorTableLookupExtension", Vector64byte_0.ToString(), 1), GetValue("VectorTableLookupExtension", Vector128byte_0.ToString(), 2), GetValue("VectorTableLookupExtension", Vector64byte_1.ToString(), 3), GetValue("VectorTableLookupExtension", apiResult.ToString(), 4));

try {
VectorTableLookupExtensionTest(Vector64byte_0, Vector128byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var XorResult = Dummy_XorTest(Vector64byte_0, Vector64byte_1);
apiResult = XorResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 41. Xor

`Vector64<byte> Xor(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> XorTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Xor(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<double> Xor(Vector64<double> left, Vector64<double> right)
Vector64<short> Xor(Vector64<short> left, Vector64<short> right)
Vector64<int> Xor(Vector64<int> left, Vector64<int> right)
Vector64<long> Xor(Vector64<long> left, Vector64<long> right)
Vector64<sbyte> Xor(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> Xor(Vector64<float> left, Vector64<float> right)
Vector64<ushort> Xor(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> Xor(Vector64<uint> left, Vector64<uint> right)
Vector64<ulong> Xor(Vector64<ulong> left, Vector64<ulong> right)
Vector128<byte> Xor(Vector128<byte> left, Vector128<byte> right)
Vector128<double> Xor(Vector128<double> left, Vector128<double> right)
Vector128<short> Xor(Vector128<short> left, Vector128<short> right)
Vector128<int> Xor(Vector128<int> left, Vector128<int> right)
Vector128<long> Xor(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> Xor(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> Xor(Vector128<float> left, Vector128<float> right)
Vector128<ushort> Xor(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> Xor(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> Xor(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.xor?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=veor_u8).

Assembly generated:

```armasm", GetValue("Xor", "Performs 'Xor' operation.", 0), GetValue("Xor", Vector64byte_0.ToString(), 1), GetValue("Xor", Vector64byte_1.ToString(), 2), GetValue("Xor", apiResult.ToString(), 3));

try {
XorTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ZeroExtendWideningLowerResult = Dummy_ZeroExtendWideningLowerTest(Vector64byte_0);
apiResult = ZeroExtendWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 42. ZeroExtendWideningLower

`Vector128<ushort> ZeroExtendWideningLower(Vector64<byte> value)`

{0}

```csharp
private Vector128<ushort> ZeroExtendWideningLowerTest(Vector64<byte> value)
{{
  return AdvSimd.ZeroExtendWideningLower(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ZeroExtendWideningLower(Vector64<short> value)
Vector128<long> ZeroExtendWideningLower(Vector64<int> value)
Vector128<short> ZeroExtendWideningLower(Vector64<sbyte> value)
Vector128<uint> ZeroExtendWideningLower(Vector64<ushort> value)
Vector128<ulong> ZeroExtendWideningLower(Vector64<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.zeroextendwideninglower?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmovl_u8).

Assembly generated:

```armasm", GetValue("ZeroExtendWideningLower", "Performs 'ZeroExtendWideningLower' operation.", 0), GetValue("ZeroExtendWideningLower", Vector64byte_0.ToString(), 1), GetValue("ZeroExtendWideningLower", apiResult.ToString(), 2));

try {
ZeroExtendWideningLowerTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ZeroExtendWideningUpperResult = Dummy_ZeroExtendWideningUpperTest(Vector128byte_0);
apiResult = ZeroExtendWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 43. ZeroExtendWideningUpper

`Vector128<ushort> ZeroExtendWideningUpper(Vector128<byte> value)`

{0}

```csharp
private Vector128<ushort> ZeroExtendWideningUpperTest(Vector128<byte> value)
{{
  return AdvSimd.ZeroExtendWideningUpper(value);
}}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ZeroExtendWideningUpper(Vector128<short> value)
Vector128<long> ZeroExtendWideningUpper(Vector128<int> value)
Vector128<short> ZeroExtendWideningUpper(Vector128<sbyte> value)
Vector128<uint> ZeroExtendWideningUpper(Vector128<ushort> value)
Vector128<ulong> ZeroExtendWideningUpper(Vector128<uint> value)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.zeroextendwideningupper?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vmovl_high_u8).

Assembly generated:

```armasm", GetValue("ZeroExtendWideningUpper", "Performs 'ZeroExtendWideningUpper' operation.", 0), GetValue("ZeroExtendWideningUpper", Vector128byte_0.ToString(), 1), GetValue("ZeroExtendWideningUpper", apiResult.ToString(), 2));

try {
ZeroExtendWideningUpperTest(Vector128byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ZipHighResult = Dummy_ZipHighTest(Vector64byte_0, Vector64byte_1);
apiResult = ZipHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 44. ZipHigh

`Vector64<byte> ZipHigh(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> ZipHighTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.ZipHigh(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ZipHigh(Vector64<short> left, Vector64<short> right)
Vector64<int> ZipHigh(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> ZipHigh(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> ZipHigh(Vector64<float> left, Vector64<float> right)
Vector64<ushort> ZipHigh(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> ZipHigh(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> ZipHigh(Vector128<byte> left, Vector128<byte> right)
Vector128<double> ZipHigh(Vector128<double> left, Vector128<double> right)
Vector128<short> ZipHigh(Vector128<short> left, Vector128<short> right)
Vector128<int> ZipHigh(Vector128<int> left, Vector128<int> right)
Vector128<long> ZipHigh(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> ZipHigh(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> ZipHigh(Vector128<float> left, Vector128<float> right)
Vector128<ushort> ZipHigh(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> ZipHigh(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> ZipHigh(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.ziphigh?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vzip2_u8).

Assembly generated:

```armasm", GetValue("ZipHigh", "Performs 'ZipHigh' operation.", 0), GetValue("ZipHigh", Vector64byte_0.ToString(), 1), GetValue("ZipHigh", Vector64byte_1.ToString(), 2), GetValue("ZipHigh", apiResult.ToString(), 3));

try {
ZipHighTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

try {
var ZipLowResult = Dummy_ZipLowTest(Vector64byte_0, Vector64byte_1);
apiResult = ZipLowResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"```
------------------------------------------------

### 45. ZipLow

`Vector64<byte> ZipLow(Vector64<byte> left, Vector64<byte> right)`

{0}

```csharp
private Vector64<byte> ZipLowTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.ZipLow(left, right);
}}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ZipLow(Vector64<short> left, Vector64<short> right)
Vector64<int> ZipLow(Vector64<int> left, Vector64<int> right)
Vector64<sbyte> ZipLow(Vector64<sbyte> left, Vector64<sbyte> right)
Vector64<float> ZipLow(Vector64<float> left, Vector64<float> right)
Vector64<ushort> ZipLow(Vector64<ushort> left, Vector64<ushort> right)
Vector64<uint> ZipLow(Vector64<uint> left, Vector64<uint> right)
Vector128<byte> ZipLow(Vector128<byte> left, Vector128<byte> right)
Vector128<double> ZipLow(Vector128<double> left, Vector128<double> right)
Vector128<short> ZipLow(Vector128<short> left, Vector128<short> right)
Vector128<int> ZipLow(Vector128<int> left, Vector128<int> right)
Vector128<long> ZipLow(Vector128<long> left, Vector128<long> right)
Vector128<sbyte> ZipLow(Vector128<sbyte> left, Vector128<sbyte> right)
Vector128<float> ZipLow(Vector128<float> left, Vector128<float> right)
Vector128<ushort> ZipLow(Vector128<ushort> left, Vector128<ushort> right)
Vector128<uint> ZipLow(Vector128<uint> left, Vector128<uint> right)
Vector128<ulong> ZipLow(Vector128<ulong> left, Vector128<ulong> right)
```


See Microsoft docs [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.ziplow?view=net-5.0), ARM docs [here](https://developer.arm.com/architectures/instruction-sets/simd-isas/neon/intrinsics?search=vzip1_u8).

Assembly generated:

```armasm", GetValue("ZipLow", "Performs 'ZipLow' operation.", 0), GetValue("ZipLow", Vector64byte_0.ToString(), 1), GetValue("ZipLow", Vector64byte_1.ToString(), 2), GetValue("ZipLow", apiResult.ToString(), 3));

try {
ZipLowTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

// ----------------------------------------------------------------

}
}