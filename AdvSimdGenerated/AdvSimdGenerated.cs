
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



private static  Vector64<short> Dummy_AbsSaturateTest(Vector64<short> value)
{
  return AdvSimd.AbsSaturate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> AbsSaturateTest(Vector64<short> value)
{
  return AdvSimd.AbsSaturate(value);
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



private static  Vector64<byte> Dummy_AddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Add(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> AddTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Add(left, right);
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



private static  Vector64<byte> Dummy_CompareTestTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareTest(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> CompareTestTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.CompareTest(left, right);
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



private static  Vector64<float> Dummy_ConvertToSingleTest(Vector64<int> value)
{
  return AdvSimd.ConvertToSingle(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ConvertToSingleTest(Vector64<int> value)
{
  return AdvSimd.ConvertToSingle(value);
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



private static  Vector64<double> Dummy_DivideScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.DivideScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> DivideScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.DivideScalar(left, right);
}



private static  Vector64<byte> Dummy_DuplicateSelectedScalarToVector64Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector64(value, index);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> DuplicateSelectedScalarToVector64Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector64(value, index);
}



private static  Vector128<byte> Dummy_DuplicateSelectedScalarToVector128Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector128(value, index);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> DuplicateSelectedScalarToVector128Test(Vector64<byte> value, byte index)
{
  return AdvSimd.DuplicateSelectedScalarToVector128(value, index);
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



private static  Vector128<byte> Dummy_DuplicateToVector128Test(byte value)
{
  return AdvSimd.DuplicateToVector128(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> DuplicateToVector128Test(byte value)
{
  return AdvSimd.DuplicateToVector128(value);
}



private static  byte Dummy_ExtractTest(Vector64<byte> vector, byte index)
{
  return AdvSimd.Extract(vector, index);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  byte ExtractTest(Vector64<byte> vector, byte index)
{
  return AdvSimd.Extract(vector, index);
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



private static  Vector64<byte> Dummy_ExtractNarrowingSaturateUnsignedLowerTest(Vector128<short> value)
{
  return AdvSimd.ExtractNarrowingSaturateUnsignedLower(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingSaturateUnsignedLowerTest(Vector128<short> value)
{
  return AdvSimd.ExtractNarrowingSaturateUnsignedLower(value);
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



private static  Vector64<byte> Dummy_ExtractVector64Test(Vector64<byte> upper, Vector64<byte> lower, byte index)
{
  return AdvSimd.ExtractVector64(upper, lower, index);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractVector64Test(Vector64<byte> upper, Vector64<byte> lower, byte index)
{
  return AdvSimd.ExtractVector64(upper, lower, index);
}



private static  Vector128<byte> Dummy_ExtractVector128Test(Vector128<byte> upper, Vector128<byte> lower, byte index)
{
  return AdvSimd.ExtractVector128(upper, lower, index);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ExtractVector128Test(Vector128<byte> upper, Vector128<byte> lower, byte index)
{
  return AdvSimd.ExtractVector128(upper, lower, index);
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



private static  Vector64<float> Dummy_FusedMultiplySubtractTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.FusedMultiplySubtract(minuend, left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplySubtractTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.FusedMultiplySubtract(minuend, left, right);
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
  return AdvSimd.Insert(vector, index, data);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> InsertTest(Vector64<byte> vector, byte index, byte data)
{
  return AdvSimd.Insert(vector, index, data);
}



private static  Vector128<double> Dummy_InsertScalarTest(Vector128<double> result, byte resultIndex, Vector64<double> value)
{
  return AdvSimd.InsertScalar(result, resultIndex, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<double> InsertScalarTest(Vector128<double> result, byte resultIndex, Vector64<double> value)
{
  return AdvSimd.InsertScalar(result, resultIndex, value);
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
  return AdvSimd.LoadAndInsertScalar(value, index, address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector64<byte> LoadAndInsertScalarTest(Vector64<byte> value, byte index, byte* address)
{
  return AdvSimd.LoadAndInsertScalar(value, index, address);
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



private static unsafe Vector128<byte> Dummy_LoadAndReplicateToVector128Test(byte* address)
{
  return AdvSimd.LoadAndReplicateToVector128(address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector128<byte> LoadAndReplicateToVector128Test(byte* address)
{
  return AdvSimd.LoadAndReplicateToVector128(address);
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



private static unsafe Vector128<byte> Dummy_LoadVector128Test(byte* address)
{
  return AdvSimd.LoadVector128(address);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe Vector128<byte> LoadVector128Test(byte* address)
{
  return AdvSimd.LoadVector128(address);
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



private static  Vector64<float> Dummy_MaxNumberTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.MaxNumber(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MaxNumberTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.MaxNumber(left, right);
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



private static  Vector64<byte> Dummy_MinTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Min(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MinTest(Vector64<byte> left, Vector64<byte> right)
{
  return AdvSimd.Min(left, right);
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
  return AdvSimd.MultiplyAddBySelectedScalar(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyAddBySelectedScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyAddBySelectedScalar(addend, left, right, rightIndex);
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
  return AdvSimd.MultiplyBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalar(left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningLowerTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLower(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningLowerTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLower(left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndAdd(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndAdd(addend, left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndSubtract(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndSubtract(minuend, left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningUpperTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpper(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningUpperTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpper(left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndAdd(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndAdd(addend, left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndSubtract(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndSubtract(minuend, left, right, rightIndex);
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
  return AdvSimd.MultiplyDoublingBySelectedScalarSaturateHigh(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingBySelectedScalarSaturateHigh(left, right, rightIndex);
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
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
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
  return AdvSimd.MultiplyDoublingWideningSaturateLowerBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerBySelectedScalar(left, right, rightIndex);
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
  return AdvSimd.MultiplyDoublingWideningSaturateUpperBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperBySelectedScalar(left, right, rightIndex);
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
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}



private static  Vector128<int> Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
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
  return AdvSimd.MultiplyRoundedDoublingBySelectedScalarSaturateHigh(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplyRoundedDoublingBySelectedScalarSaturateHigh(left, right, rightIndex);
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
  return AdvSimd.MultiplyScalarBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MultiplyScalarBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.MultiplyScalarBySelectedScalar(left, right, rightIndex);
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
  return AdvSimd.MultiplySubtractBySelectedScalar(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplySubtractBySelectedScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.MultiplySubtractBySelectedScalar(minuend, left, right, rightIndex);
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



private static  Vector64<float> Dummy_ReciprocalSquareRootEstimateTest(Vector64<float> value)
{
  return AdvSimd.ReciprocalSquareRootEstimate(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ReciprocalSquareRootEstimateTest(Vector64<float> value)
{
  return AdvSimd.ReciprocalSquareRootEstimate(value);
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



private static  Vector64<float> Dummy_ReciprocalStepTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.ReciprocalStep(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> ReciprocalStepTest(Vector64<float> left, Vector64<float> right)
{
  return AdvSimd.ReciprocalStep(left, right);
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
  return AdvSimd.ShiftLeftAndInsert(left, right, shift);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLeftAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsert(left, right, shift);
}



private static  Vector64<long> Dummy_ShiftLeftAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsertScalar(left, right, shift);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLeftAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftLeftAndInsertScalar(left, right, shift);
}



private static  Vector64<byte> Dummy_ShiftLeftLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogical(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLeftLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogical(value, count);
}



private static  Vector64<byte> Dummy_ShiftLeftLogicalSaturateTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturate(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftLeftLogicalSaturateTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturate(value, count);
}



private static  Vector64<long> Dummy_ShiftLeftLogicalSaturateScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLeftLogicalSaturateScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateScalar(value, count);
}



private static  Vector64<ushort> Dummy_ShiftLeftLogicalSaturateUnsignedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsigned(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ushort> ShiftLeftLogicalSaturateUnsignedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsigned(value, count);
}



private static  Vector64<ulong> Dummy_ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsignedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalSaturateUnsignedScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftLeftLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftLeftLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalScalar(value, count);
}



private static  Vector128<ushort> Dummy_ShiftLeftLogicalWideningLowerTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> ShiftLeftLogicalWideningLowerTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningLower(value, count);
}



private static  Vector128<ushort> Dummy_ShiftLeftLogicalWideningUpperTest(Vector128<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningUpper(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<ushort> ShiftLeftLogicalWideningUpperTest(Vector128<byte> value, byte count)
{
  return AdvSimd.ShiftLeftLogicalWideningUpper(value, count);
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
  return AdvSimd.ShiftRightAndInsert(left, right, shift);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsert(left, right, shift);
}



private static  Vector64<long> Dummy_ShiftRightAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsertScalar(left, right, shift);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{
  return AdvSimd.ShiftRightAndInsertScalar(left, right, shift);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmetic(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmetic(value, count);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAdd(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAdd(addend, value, count);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAddScalar(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticAddScalar(addend, value, count);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateLower(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedLower(value, count);
}



private static  Vector128<byte> Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedUpper(lower, value, count);
}



private static  Vector128<short> Dummy_ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<short> ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUpper(lower, value, count);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRounded(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedTest(Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRounded(value, count);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAdd(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAdd(addend, value, count);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAddScalar(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedAddScalar(addend, value, count);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateLower(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(value, count);
}



private static  Vector128<byte> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(lower, value, count);
}



private static  Vector128<short> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUpper(lower, value, count);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticRoundedScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftRightArithmeticScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightArithmeticScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightArithmeticScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogical(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogical(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAdd(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAdd(addend, value, count);
}



private static  Vector64<long> Dummy_ShiftRightLogicalAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAddScalar(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalAddScalar(addend, value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingLower(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateLower(value, count);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateUpper(lower, value, count);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalNarrowingUpper(lower, value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRounded(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedTest(Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRounded(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAdd(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAdd(addend, value, count);
}



private static  Vector64<long> Dummy_ShiftRightLogicalRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAddScalar(addend, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedAddScalar(addend, value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedNarrowingLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingLower(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateLower(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateLower(value, count);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateUpper(lower, value, count);
}



private static  Vector128<byte> Dummy_ShiftRightLogicalRoundedNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingUpper(lower, value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<byte> ShiftRightLogicalRoundedNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingUpper(lower, value, count);
}



private static  Vector64<long> Dummy_ShiftRightLogicalRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalRoundedScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalRoundedScalar(value, count);
}



private static  Vector64<long> Dummy_ShiftRightLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<long> ShiftRightLogicalScalarTest(Vector64<long> value, byte count)
{
  return AdvSimd.ShiftRightLogicalScalar(value, count);
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



private static unsafe void Dummy_StoreSelectedScalarTest(byte* address, Vector64<byte> value, byte index)
{
  AdvSimd.StoreSelectedScalar(address, value, index);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static unsafe void StoreSelectedScalarTest(byte* address, Vector64<byte> value, byte index)
{
  AdvSimd.StoreSelectedScalar(address, value, index);
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



private static  Vector64<short> Dummy_AbsSaturateScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.AbsSaturateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> AbsSaturateScalarTest(Vector64<short> value)
{
  return AdvSimd.Arm64.AbsSaturateScalar(value);
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



private static  Vector64<double> Dummy_AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanOrEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanOrEqualScalar(left, right);
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



private static  Vector64<double> Dummy_AbsoluteCompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareLessThanOrEqualScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> AbsoluteCompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.AbsoluteCompareLessThanOrEqualScalar(left, right);
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



private static  Vector64<float> Dummy_AddPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.AddPairwiseScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> AddPairwiseScalarTest(Vector64<float> value)
{
  return AdvSimd.Arm64.AddPairwiseScalar(value);
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



private static  Vector64<double> Dummy_CompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareGreaterThanScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareGreaterThanScalar(left, right);
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



private static  Vector64<double> Dummy_CompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareLessThanScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> CompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.CompareLessThanScalar(left, right);
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



private static  Vector128<float> Dummy_ConvertToSingleUpperTest(Vector64<float> lower, Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleUpper(lower, value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector128<float> ConvertToSingleUpperTest(Vector64<float> lower, Vector128<double> value)
{
  return AdvSimd.Arm64.ConvertToSingleUpper(lower, value);
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



private static  Vector64<byte> Dummy_ExtractNarrowingSaturateScalarTest(Vector64<ushort> value)
{
  return AdvSimd.Arm64.ExtractNarrowingSaturateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ExtractNarrowingSaturateScalarTest(Vector64<ushort> value)
{
  return AdvSimd.Arm64.ExtractNarrowingSaturateScalar(value);
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
  return AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplyAddBySelectedScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(addend, left, right, rightIndex);
}



private static  Vector64<double> Dummy_FusedMultiplyAddScalarBySelectedScalarTest(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddScalarBySelectedScalar(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplyAddScalarBySelectedScalarTest(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplyAddScalarBySelectedScalar(addend, left, right, rightIndex);
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
  return AdvSimd.Arm64.FusedMultiplySubtractBySelectedScalar(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> FusedMultiplySubtractBySelectedScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractBySelectedScalar(minuend, left, right, rightIndex);
}



private static  Vector64<double> Dummy_FusedMultiplySubtractScalarBySelectedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractScalarBySelectedScalar(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> FusedMultiplySubtractScalarBySelectedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.FusedMultiplySubtractScalarBySelectedScalar(minuend, left, right, rightIndex);
}



private static  Vector64<byte> Dummy_InsertSelectedScalarTest(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
{
  return AdvSimd.Arm64.InsertSelectedScalar(result, resultIndex, value, valueIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> InsertSelectedScalarTest(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
{
  return AdvSimd.Arm64.InsertSelectedScalar(result, resultIndex, value, valueIndex);
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



private static  Vector64<byte> Dummy_MinAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.MinAcross(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> MinAcrossTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.MinAcross(value);
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
  return AdvSimd.Arm64.MultiplyDoublingScalarBySelectedScalarSaturateHigh(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingScalarBySelectedScalarSaturateHigh(left, right, rightIndex);
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
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalarBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalarBySelectedScalar(left, right, rightIndex);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}



private static  Vector64<int> Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
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
  return AdvSimd.Arm64.MultiplyExtendedBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<float> MultiplyExtendedBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyExtendedBySelectedScalar(left, right, rightIndex);
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
  return AdvSimd.Arm64.MultiplyExtendedScalarBySelectedScalar(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> MultiplyExtendedScalarBySelectedScalarTest(Vector64<double> left, Vector128<double> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyExtendedScalarBySelectedScalar(left, right, rightIndex);
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
  return AdvSimd.Arm64.MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(left, right, rightIndex);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{
  return AdvSimd.Arm64.MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(left, right, rightIndex);
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



private static  Vector64<double> Dummy_ReciprocalSquareRootEstimateScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalSquareRootEstimateScalar(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalSquareRootEstimateScalarTest(Vector64<double> value)
{
  return AdvSimd.Arm64.ReciprocalSquareRootEstimateScalar(value);
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



private static  Vector64<double> Dummy_ReciprocalStepScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.ReciprocalStepScalar(left, right);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<double> ReciprocalStepScalarTest(Vector64<double> left, Vector64<double> right)
{
  return AdvSimd.Arm64.ReciprocalStepScalar(left, right);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateUnsignedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateUnsignedScalar(value, count);
}



private static  Vector64<short> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalNarrowingSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalNarrowingSaturateScalar(value, count);
}



private static  Vector64<byte> Dummy_ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalRoundedNarrowingSaturateScalar(value, count);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{
  return AdvSimd.Arm64.ShiftRightLogicalRoundedNarrowingSaturateScalar(value, count);
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



private static  Vector64<byte> Dummy_ReverseElementBitsTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.ReverseElementBits(value);
}
[MethodImpl(MethodImplOptions.NoInlining)]
private static  Vector64<byte> ReverseElementBitsTest(Vector64<byte> value)
{
  return AdvSimd.Arm64.ReverseElementBits(value);
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
title: Hardware Intrinsics APIs for ARM64 - Part 1
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

[Abs](#1-abs), [AbsSaturate](#2-abssaturate), [AbsScalar](#3-absscalar), [AbsoluteCompareGreaterThan](#4-absolutecomparegreaterthan), [AbsoluteCompareGreaterThanOrEqual](#5-absolutecomparegreaterthanorequal), [AbsoluteCompareLessThan](#6-absolutecomparelessthan), [AbsoluteCompareLessThanOrEqual](#7-absolutecomparelessthanorequal), [AbsoluteDifference](#8-absolutedifference), [AbsoluteDifferenceAdd](#9-absolutedifferenceadd), [AbsoluteDifferenceWideningLower](#10-absolutedifferencewideninglower), [AbsoluteDifferenceWideningLowerAndAdd](#11-absolutedifferencewideninglowerandadd), [AbsoluteDifferenceWideningUpper](#12-absolutedifferencewideningupper), [AbsoluteDifferenceWideningUpperAndAdd](#13-absolutedifferencewideningupperandadd), [Add](#14-add), [AddHighNarrowingLower](#15-addhighnarrowinglower), [AddHighNarrowingUpper](#16-addhighnarrowingupper), [AddPairwise](#17-addpairwise), [AddPairwiseWidening](#18-addpairwisewidening), [AddPairwiseWideningAndAdd](#19-addpairwisewideningandadd), [AddPairwiseWideningAndAddScalar](#20-addpairwisewideningandaddscalar), [AddPairwiseWideningScalar](#21-addpairwisewideningscalar), [AddRoundedHighNarrowingLower](#22-addroundedhighnarrowinglower), [AddRoundedHighNarrowingUpper](#23-addroundedhighnarrowingupper), [AddSaturate](#24-addsaturate), [AddSaturateScalar](#25-addsaturatescalar), [AddScalar](#26-addscalar), [AddWideningLower](#27-addwideninglower), [AddWideningUpper](#28-addwideningupper), [And](#29-and), [BitwiseClear](#30-bitwiseclear), [BitwiseSelect](#31-bitwiseselect), [Ceiling](#32-ceiling), [CeilingScalar](#33-ceilingscalar), [CompareEqual](#34-compareequal), [CompareGreaterThan](#35-comparegreaterthan), [CompareGreaterThanOrEqual](#36-comparegreaterthanorequal), [CompareLessThan](#37-comparelessthan), [CompareLessThanOrEqual](#38-comparelessthanorequal), [CompareTest](#39-comparetest), [ConvertToInt32RoundAwayFromZero](#40-converttoint32roundawayfromzero), [ConvertToInt32RoundAwayFromZeroScalar](#41-converttoint32roundawayfromzeroscalar), [ConvertToInt32RoundToEven](#42-converttoint32roundtoeven), [ConvertToInt32RoundToEvenScalar](#43-converttoint32roundtoevenscalar), [ConvertToInt32RoundToNegativeInfinity](#44-converttoint32roundtonegativeinfinity), [ConvertToInt32RoundToNegativeInfinityScalar](#45-converttoint32roundtonegativeinfinityscalar), [ConvertToInt32RoundToPositiveInfinity](#46-converttoint32roundtopositiveinfinity), [ConvertToInt32RoundToPositiveInfinityScalar](#47-converttoint32roundtopositiveinfinityscalar), [ConvertToInt32RoundToZero](#48-converttoint32roundtozero), [ConvertToInt32RoundToZeroScalar](#49-converttoint32roundtozeroscalar), [ConvertToSingle](#50-converttosingle), [ConvertToSingleScalar](#51-converttosinglescalar), [ConvertToUInt32RoundAwayFromZero](#52-converttouint32roundawayfromzero), [ConvertToUInt32RoundAwayFromZeroScalar](#53-converttouint32roundawayfromzeroscalar), [ConvertToUInt32RoundToEven](#54-converttouint32roundtoeven), [ConvertToUInt32RoundToEvenScalar](#55-converttouint32roundtoevenscalar), [ConvertToUInt32RoundToNegativeInfinity](#56-converttouint32roundtonegativeinfinity), [ConvertToUInt32RoundToNegativeInfinityScalar](#57-converttouint32roundtonegativeinfinityscalar), [ConvertToUInt32RoundToPositiveInfinity](#58-converttouint32roundtopositiveinfinity), [ConvertToUInt32RoundToPositiveInfinityScalar](#59-converttouint32roundtopositiveinfinityscalar), [ConvertToUInt32RoundToZero](#60-converttouint32roundtozero),[...](Part1.md)


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

Performs 'Abs' operation.

```csharp
private Vector64<ushort> AbsTest(Vector64<short> value)
{{
  return AdvSimd.Abs(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.abs?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.abs?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
AbsTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Abs", "Performs 'Abs' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var AbsSaturateResult = Dummy_AbsSaturateTest(Vector64short_0);
apiResult = AbsSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 2. AbsSaturate

`Vector64<short> AbsSaturate(Vector64<short> value)`

Performs 'AbsSaturate' operation.

```csharp
private Vector64<short> AbsSaturateTest(Vector64<short> value)
{{
  return AdvSimd.AbsSaturate(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.abssaturate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.abssaturate?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
AbsSaturateTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsSaturate", "Performs 'AbsSaturate' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var AbsScalarResult = Dummy_AbsScalarTest(Vector64double_0);
apiResult = AbsScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 3. AbsScalar

`Vector64<double> AbsScalar(Vector64<double> value)`

Performs 'AbsScalar' operation.

```csharp
private Vector64<double> AbsScalarTest(Vector64<double> value)
{{
  return AdvSimd.AbsScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> AbsScalar(Vector64<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ulong> AbsScalar(Vector64<long> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
AbsScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsScalar", "Performs 'AbsScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanResult = Dummy_AbsoluteCompareGreaterThanTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareGreaterThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 4. AbsoluteCompareGreaterThan

`Vector64<float> AbsoluteCompareGreaterThan(Vector64<float> left, Vector64<float> right)`

Performs 'AbsoluteCompareGreaterThan' operation.

```csharp
private Vector64<float> AbsoluteCompareGreaterThanTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareGreaterThan(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareGreaterThan(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareGreaterThan(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparegreaterthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthan?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
AbsoluteCompareGreaterThanTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareGreaterThan", "Performs 'AbsoluteCompareGreaterThan' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanOrEqualResult = Dummy_AbsoluteCompareGreaterThanOrEqualTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareGreaterThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 5. AbsoluteCompareGreaterThanOrEqual

`Vector64<float> AbsoluteCompareGreaterThanOrEqual(Vector64<float> left, Vector64<float> right)`

Performs 'AbsoluteCompareGreaterThanOrEqual' operation.

```csharp
private Vector64<float> AbsoluteCompareGreaterThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareGreaterThanOrEqual(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareGreaterThanOrEqual(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareGreaterThanOrEqual(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparegreaterthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthanorequal?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
AbsoluteCompareGreaterThanOrEqualTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareGreaterThanOrEqual", "Performs 'AbsoluteCompareGreaterThanOrEqual' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanResult = Dummy_AbsoluteCompareLessThanTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareLessThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 6. AbsoluteCompareLessThan

`Vector64<float> AbsoluteCompareLessThan(Vector64<float> left, Vector64<float> right)`

Performs 'AbsoluteCompareLessThan' operation.

```csharp
private Vector64<float> AbsoluteCompareLessThanTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareLessThan(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareLessThan(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareLessThan(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparelessthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthan?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
AbsoluteCompareLessThanTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareLessThan", "Performs 'AbsoluteCompareLessThan' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanOrEqualResult = Dummy_AbsoluteCompareLessThanOrEqualTest(Vector64float_0, Vector64float_1);
apiResult = AbsoluteCompareLessThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 7. AbsoluteCompareLessThanOrEqual

`Vector64<float> AbsoluteCompareLessThanOrEqual(Vector64<float> left, Vector64<float> right)`

Performs 'AbsoluteCompareLessThanOrEqual' operation.

```csharp
private Vector64<float> AbsoluteCompareLessThanOrEqualTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.AbsoluteCompareLessThanOrEqual(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> AbsoluteCompareLessThanOrEqual(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> AbsoluteCompareLessThanOrEqual(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutecomparelessthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthanorequal?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
AbsoluteCompareLessThanOrEqualTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareLessThanOrEqual", "Performs 'AbsoluteCompareLessThanOrEqual' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceResult = Dummy_AbsoluteDifferenceTest(Vector64byte_0, Vector64byte_1);
apiResult = AbsoluteDifferenceResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 8. AbsoluteDifference

`Vector64<byte> AbsoluteDifference(Vector64<byte> left, Vector64<byte> right)`

Performs 'AbsoluteDifference' operation.

```csharp
private Vector64<byte> AbsoluteDifferenceTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifference(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifference?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutedifference?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AbsoluteDifferenceTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifference", "Performs 'AbsoluteDifference' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceAddResult = Dummy_AbsoluteDifferenceAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = AbsoluteDifferenceAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 9. AbsoluteDifferenceAdd

`Vector64<byte> AbsoluteDifferenceAdd(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)`

Performs 'AbsoluteDifferenceAdd' operation.

```csharp
private Vector64<byte> AbsoluteDifferenceAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferenceadd?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);

try {
AbsoluteDifferenceAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifferenceAdd", "Performs 'AbsoluteDifferenceAdd' operation", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningLowerResult = Dummy_AbsoluteDifferenceWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = AbsoluteDifferenceWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 10. AbsoluteDifferenceWideningLower

`Vector128<ushort> AbsoluteDifferenceWideningLower(Vector64<byte> left, Vector64<byte> right)`

Performs 'AbsoluteDifferenceWideningLower' operation.

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AbsoluteDifferenceWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifferenceWideningLower", "Performs 'AbsoluteDifferenceWideningLower' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningLowerAndAddResult = Dummy_AbsoluteDifferenceWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);
apiResult = AbsoluteDifferenceWideningLowerAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 11. AbsoluteDifferenceWideningLowerAndAdd

`Vector128<ushort> AbsoluteDifferenceWideningLowerAndAdd(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)`

Performs 'AbsoluteDifferenceWideningLowerAndAdd' operation.

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningLowerAndAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideninglowerandadd?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector64byte_0, Vector64byte_1, apiResult);

try {
AbsoluteDifferenceWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifferenceWideningLowerAndAdd", "Performs 'AbsoluteDifferenceWideningLowerAndAdd' operation", Vector128ushort_0, Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningUpperResult = Dummy_AbsoluteDifferenceWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = AbsoluteDifferenceWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 12. AbsoluteDifferenceWideningUpper

`Vector128<ushort> AbsoluteDifferenceWideningUpper(Vector128<byte> left, Vector128<byte> right)`

Performs 'AbsoluteDifferenceWideningUpper' operation.

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningUpper(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector128byte_1, apiResult);

try {
AbsoluteDifferenceWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifferenceWideningUpper", "Performs 'AbsoluteDifferenceWideningUpper' operation", Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceWideningUpperAndAddResult = Dummy_AbsoluteDifferenceWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);
apiResult = AbsoluteDifferenceWideningUpperAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 13. AbsoluteDifferenceWideningUpperAndAdd

`Vector128<ushort> AbsoluteDifferenceWideningUpperAndAdd(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)`

Performs 'AbsoluteDifferenceWideningUpperAndAdd' operation.

```csharp
private Vector128<ushort> AbsoluteDifferenceWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.AbsoluteDifferenceWideningUpperAndAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.absolutedifferencewideningupperandadd?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128byte_0, Vector128byte_1, apiResult);

try {
AbsoluteDifferenceWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifferenceWideningUpperAndAdd", "Performs 'AbsoluteDifferenceWideningUpperAndAdd' operation", Vector128ushort_0, Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AddResult = Dummy_AddTest(Vector64byte_0, Vector64byte_1);
apiResult = AddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 14. Add

`Vector64<byte> Add(Vector64<byte> left, Vector64<byte> right)`

Performs 'Add' operation.

```csharp
private Vector64<byte> AddTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Add(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.add?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.add?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AddTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Add", "Performs 'Add' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AddHighNarrowingLowerResult = Dummy_AddHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = AddHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 15. AddHighNarrowingLower

`Vector64<byte> AddHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

Performs 'AddHighNarrowingLower' operation.

```csharp
private Vector64<byte> AddHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddHighNarrowingLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addhighnarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128ushort_1, apiResult);

try {
AddHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddHighNarrowingLower", "Performs 'AddHighNarrowingLower' operation", Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var AddHighNarrowingUpperResult = Dummy_AddHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = AddHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 16. AddHighNarrowingUpper

`Vector128<byte> AddHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

Performs 'AddHighNarrowingUpper' operation.

```csharp
private Vector128<byte> AddHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddHighNarrowingUpper(lower, left, right);
}}
// lower = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addhighnarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);

try {
AddHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddHighNarrowingUpper", "Performs 'AddHighNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var AddPairwiseResult = Dummy_AddPairwiseTest(Vector64byte_0, Vector64byte_1);
apiResult = AddPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 17. AddPairwise

`Vector64<byte> AddPairwise(Vector64<byte> left, Vector64<byte> right)`

Performs 'AddPairwise' operation.

```csharp
private Vector64<byte> AddPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AddPairwise(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwise?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addpairwise?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AddPairwiseTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddPairwise", "Performs 'AddPairwise' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AddPairwiseWideningResult = Dummy_AddPairwiseWideningTest(Vector64byte_0);
apiResult = AddPairwiseWideningResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 18. AddPairwiseWidening

`Vector64<ushort> AddPairwiseWidening(Vector64<byte> value)`

Performs 'AddPairwiseWidening' operation.

```csharp
private Vector64<ushort> AddPairwiseWideningTest(Vector64<byte> value)
{{
  return AdvSimd.AddPairwiseWidening(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewidening?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
AddPairwiseWideningTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddPairwiseWidening", "Performs 'AddPairwiseWidening' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var AddPairwiseWideningAndAddResult = Dummy_AddPairwiseWideningAndAddTest(Vector64ushort_0, Vector64byte_0);
apiResult = AddPairwiseWideningAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 19. AddPairwiseWideningAndAdd

`Vector64<ushort> AddPairwiseWideningAndAdd(Vector64<ushort> addend, Vector64<byte> value)`

Performs 'AddPairwiseWideningAndAdd' operation.

```csharp
private Vector64<ushort> AddPairwiseWideningAndAddTest(Vector64<ushort> addend, Vector64<byte> value)
{{
  return AdvSimd.AddPairwiseWideningAndAdd(addend, value);
}}
// addend = {0}
// value = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewideningandadd?view=net-5.0).

Assembly generated:

```
", Vector64ushort_0, Vector64byte_0, apiResult);

try {
AddPairwiseWideningAndAddTest(Vector64ushort_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddPairwiseWideningAndAdd", "Performs 'AddPairwiseWideningAndAdd' operation", Vector64ushort_0, Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var AddPairwiseWideningAndAddScalarResult = Dummy_AddPairwiseWideningAndAddScalarTest(Vector64long_0, Vector64int_0);
apiResult = AddPairwiseWideningAndAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 20. AddPairwiseWideningAndAddScalar

`Vector64<long> AddPairwiseWideningAndAddScalar(Vector64<long> addend, Vector64<int> value)`

Performs 'AddPairwiseWideningAndAddScalar' operation.

```csharp
private Vector64<long> AddPairwiseWideningAndAddScalarTest(Vector64<long> addend, Vector64<int> value)
{{
  return AdvSimd.AddPairwiseWideningAndAddScalar(addend, value);
}}
// addend = {0}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> AddPairwiseWideningAndAddScalar(Vector64<ulong> addend, Vector64<uint> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewideningandaddscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64int_0, apiResult);

try {
AddPairwiseWideningAndAddScalarTest(Vector64long_0, Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddPairwiseWideningAndAddScalar", "Performs 'AddPairwiseWideningAndAddScalar' operation", Vector64long_0, Vector64int_0, apiResult);
// ----------------------------------------------------------------

try {
var AddPairwiseWideningScalarResult = Dummy_AddPairwiseWideningScalarTest(Vector64int_0);
apiResult = AddPairwiseWideningScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 21. AddPairwiseWideningScalar

`Vector64<long> AddPairwiseWideningScalar(Vector64<int> value)`

Performs 'AddPairwiseWideningScalar' operation.

```csharp
private Vector64<long> AddPairwiseWideningScalarTest(Vector64<int> value)
{{
  return AdvSimd.AddPairwiseWideningScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> AddPairwiseWideningScalar(Vector64<uint> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addpairwisewideningscalar?view=net-5.0).

Assembly generated:

```
", Vector64int_0, apiResult);

try {
AddPairwiseWideningScalarTest(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddPairwiseWideningScalar", "Performs 'AddPairwiseWideningScalar' operation", Vector64int_0, apiResult);
// ----------------------------------------------------------------

try {
var AddRoundedHighNarrowingLowerResult = Dummy_AddRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = AddRoundedHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 22. AddRoundedHighNarrowingLower

`Vector64<byte> AddRoundedHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

Performs 'AddRoundedHighNarrowingLower' operation.

```csharp
private Vector64<byte> AddRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddRoundedHighNarrowingLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addroundedhighnarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128ushort_1, apiResult);

try {
AddRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddRoundedHighNarrowingLower", "Performs 'AddRoundedHighNarrowingLower' operation", Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var AddRoundedHighNarrowingUpperResult = Dummy_AddRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = AddRoundedHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 23. AddRoundedHighNarrowingUpper

`Vector128<byte> AddRoundedHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

Performs 'AddRoundedHighNarrowingUpper' operation.

```csharp
private Vector128<byte> AddRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.AddRoundedHighNarrowingUpper(lower, left, right);
}}
// lower = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addroundedhighnarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);

try {
AddRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddRoundedHighNarrowingUpper", "Performs 'AddRoundedHighNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var AddSaturateResult = Dummy_AddSaturateTest(Vector64byte_0, Vector64byte_1);
apiResult = AddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 24. AddSaturate

`Vector64<byte> AddSaturate(Vector64<byte> left, Vector64<byte> right)`

Performs 'AddSaturate' operation.

```csharp
private Vector64<byte> AddSaturateTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AddSaturate(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addsaturate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addsaturate?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AddSaturateTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddSaturate", "Performs 'AddSaturate' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AddSaturateScalarResult = Dummy_AddSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = AddSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 25. AddSaturateScalar

`Vector64<long> AddSaturateScalar(Vector64<long> left, Vector64<long> right)`

Performs 'AddSaturateScalar' operation.

```csharp
private Vector64<long> AddSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{{
  return AdvSimd.AddSaturateScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
AddSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddSaturateScalar", "Performs 'AddSaturateScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var AddScalarResult = Dummy_AddScalarTest(Vector64double_0, Vector64double_1);
apiResult = AddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 26. AddScalar

`Vector64<double> AddScalar(Vector64<double> left, Vector64<double> right)`

Performs 'AddScalar' operation.

```csharp
private Vector64<double> AddScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.AddScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<long> AddScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> AddScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> AddScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
AddScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddScalar", "Performs 'AddScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var AddWideningLowerResult = Dummy_AddWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = AddWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 27. AddWideningLower

`Vector128<ushort> AddWideningLower(Vector64<byte> left, Vector64<byte> right)`

Performs 'AddWideningLower' operation.

```csharp
private Vector128<ushort> AddWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.AddWideningLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addwideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AddWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddWideningLower", "Performs 'AddWideningLower' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AddWideningUpperResult = Dummy_AddWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = AddWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 28. AddWideningUpper

`Vector128<ushort> AddWideningUpper(Vector128<byte> left, Vector128<byte> right)`

Performs 'AddWideningUpper' operation.

```csharp
private Vector128<ushort> AddWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.AddWideningUpper(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.addwideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector128byte_1, apiResult);

try {
AddWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddWideningUpper", "Performs 'AddWideningUpper' operation", Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var AndResult = Dummy_AndTest(Vector64byte_0, Vector64byte_1);
apiResult = AndResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 29. And

`Vector64<byte> And(Vector64<byte> left, Vector64<byte> right)`

Performs 'And' operation.

```csharp
private Vector64<byte> AndTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.And(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.and?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
AndTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("And", "Performs 'And' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var BitwiseClearResult = Dummy_BitwiseClearTest(Vector64byte_0, Vector64byte_1);
apiResult = BitwiseClearResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 30. BitwiseClear

`Vector64<byte> BitwiseClear(Vector64<byte> value, Vector64<byte> mask)`

Performs 'BitwiseClear' operation.

```csharp
private Vector64<byte> BitwiseClearTest(Vector64<byte> value, Vector64<byte> mask)
{{
  return AdvSimd.BitwiseClear(value, mask);
}}
// value = {0}
// mask = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.bitwiseclear?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
BitwiseClearTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("BitwiseClear", "Performs 'BitwiseClear' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var BitwiseSelectResult = Dummy_BitwiseSelectTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = BitwiseSelectResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 31. BitwiseSelect

`Vector64<byte> BitwiseSelect(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)`

Performs 'BitwiseSelect' operation.

```csharp
private Vector64<byte> BitwiseSelectTest(Vector64<byte> select, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.BitwiseSelect(select, left, right);
}}
// select = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.bitwiseselect?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);

try {
BitwiseSelectTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("BitwiseSelect", "Performs 'BitwiseSelect' operation", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);
// ----------------------------------------------------------------

try {
var CeilingResult = Dummy_CeilingTest(Vector64float_0);
apiResult = CeilingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 32. Ceiling

`Vector64<float> Ceiling(Vector64<float> value)`

Performs 'Ceiling' operation.

```csharp
private Vector64<float> CeilingTest(Vector64<float> value)
{{
  return AdvSimd.Ceiling(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> Ceiling(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Ceiling(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.ceiling?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.ceiling?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
CeilingTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Ceiling", "Performs 'Ceiling' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var CeilingScalarResult = Dummy_CeilingScalarTest(Vector64double_0);
apiResult = CeilingScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 33. CeilingScalar

`Vector64<double> CeilingScalar(Vector64<double> value)`

Performs 'CeilingScalar' operation.

```csharp
private Vector64<double> CeilingScalarTest(Vector64<double> value)
{{
  return AdvSimd.CeilingScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> CeilingScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.ceilingscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
CeilingScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CeilingScalar", "Performs 'CeilingScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var CompareEqualResult = Dummy_CompareEqualTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 34. CompareEqual

`Vector64<byte> CompareEqual(Vector64<byte> left, Vector64<byte> right)`

Performs 'CompareEqual' operation.

```csharp
private Vector64<byte> CompareEqualTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareEqual(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.compareequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.compareequal?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
CompareEqualTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareEqual", "Performs 'CompareEqual' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareGreaterThanResult = Dummy_CompareGreaterThanTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareGreaterThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 35. CompareGreaterThan

`Vector64<byte> CompareGreaterThan(Vector64<byte> left, Vector64<byte> right)`

Performs 'CompareGreaterThan' operation.

```csharp
private Vector64<byte> CompareGreaterThanTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareGreaterThan(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparegreaterthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthan?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
CompareGreaterThanTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareGreaterThan", "Performs 'CompareGreaterThan' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareGreaterThanOrEqualResult = Dummy_CompareGreaterThanOrEqualTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareGreaterThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 36. CompareGreaterThanOrEqual

`Vector64<byte> CompareGreaterThanOrEqual(Vector64<byte> left, Vector64<byte> right)`

Performs 'CompareGreaterThanOrEqual' operation.

```csharp
private Vector64<byte> CompareGreaterThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareGreaterThanOrEqual(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparegreaterthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthanorequal?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
CompareGreaterThanOrEqualTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareGreaterThanOrEqual", "Performs 'CompareGreaterThanOrEqual' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareLessThanResult = Dummy_CompareLessThanTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareLessThanResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 37. CompareLessThan

`Vector64<byte> CompareLessThan(Vector64<byte> left, Vector64<byte> right)`

Performs 'CompareLessThan' operation.

```csharp
private Vector64<byte> CompareLessThanTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareLessThan(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparelessthan?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthan?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
CompareLessThanTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareLessThan", "Performs 'CompareLessThan' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareLessThanOrEqualResult = Dummy_CompareLessThanOrEqualTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareLessThanOrEqualResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 38. CompareLessThanOrEqual

`Vector64<byte> CompareLessThanOrEqual(Vector64<byte> left, Vector64<byte> right)`

Performs 'CompareLessThanOrEqual' operation.

```csharp
private Vector64<byte> CompareLessThanOrEqualTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareLessThanOrEqual(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparelessthanorequal?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthanorequal?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
CompareLessThanOrEqualTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareLessThanOrEqual", "Performs 'CompareLessThanOrEqual' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareTestResult = Dummy_CompareTestTest(Vector64byte_0, Vector64byte_1);
apiResult = CompareTestResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 39. CompareTest

`Vector64<byte> CompareTest(Vector64<byte> left, Vector64<byte> right)`

Performs 'CompareTest' operation.

```csharp
private Vector64<byte> CompareTestTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.CompareTest(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.comparetest?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparetest?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
CompareTestTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareTest", "Performs 'CompareTest' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundAwayFromZeroResult = Dummy_ConvertToInt32RoundAwayFromZeroTest(Vector64float_0);
apiResult = ConvertToInt32RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 40. ConvertToInt32RoundAwayFromZero

`Vector64<int> ConvertToInt32RoundAwayFromZero(Vector64<float> value)`

Performs 'ConvertToInt32RoundAwayFromZero' operation.

```csharp
private Vector64<int> ConvertToInt32RoundAwayFromZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundAwayFromZero(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundAwayFromZero(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundawayfromzero?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundAwayFromZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundAwayFromZero", "Performs 'ConvertToInt32RoundAwayFromZero' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundAwayFromZeroScalarResult = Dummy_ConvertToInt32RoundAwayFromZeroScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 41. ConvertToInt32RoundAwayFromZeroScalar

`Vector64<int> ConvertToInt32RoundAwayFromZeroScalar(Vector64<float> value)`

Performs 'ConvertToInt32RoundAwayFromZeroScalar' operation.

```csharp
private Vector64<int> ConvertToInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundAwayFromZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundawayfromzeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundAwayFromZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundAwayFromZeroScalar", "Performs 'ConvertToInt32RoundAwayFromZeroScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToEvenResult = Dummy_ConvertToInt32RoundToEvenTest(Vector64float_0);
apiResult = ConvertToInt32RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 42. ConvertToInt32RoundToEven

`Vector64<int> ConvertToInt32RoundToEven(Vector64<float> value)`

Performs 'ConvertToInt32RoundToEven' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToEvenTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToEven(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToEven(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtoeven?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToEvenTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToEven", "Performs 'ConvertToInt32RoundToEven' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToEvenScalarResult = Dummy_ConvertToInt32RoundToEvenScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 43. ConvertToInt32RoundToEvenScalar

`Vector64<int> ConvertToInt32RoundToEvenScalar(Vector64<float> value)`

Performs 'ConvertToInt32RoundToEvenScalar' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToEvenScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToEvenScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtoevenscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToEvenScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToEvenScalar", "Performs 'ConvertToInt32RoundToEvenScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToNegativeInfinityResult = Dummy_ConvertToInt32RoundToNegativeInfinityTest(Vector64float_0);
apiResult = ConvertToInt32RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 44. ConvertToInt32RoundToNegativeInfinity

`Vector64<int> ConvertToInt32RoundToNegativeInfinity(Vector64<float> value)`

Performs 'ConvertToInt32RoundToNegativeInfinity' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToNegativeInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinity(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToNegativeInfinity(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtonegativeinfinity?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToNegativeInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToNegativeInfinity", "Performs 'ConvertToInt32RoundToNegativeInfinity' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToNegativeInfinityScalarResult = Dummy_ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 45. ConvertToInt32RoundToNegativeInfinityScalar

`Vector64<int> ConvertToInt32RoundToNegativeInfinityScalar(Vector64<float> value)`

Performs 'ConvertToInt32RoundToNegativeInfinityScalar' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToNegativeInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtonegativeinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToNegativeInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToNegativeInfinityScalar", "Performs 'ConvertToInt32RoundToNegativeInfinityScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToPositiveInfinityResult = Dummy_ConvertToInt32RoundToPositiveInfinityTest(Vector64float_0);
apiResult = ConvertToInt32RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 46. ConvertToInt32RoundToPositiveInfinity

`Vector64<int> ConvertToInt32RoundToPositiveInfinity(Vector64<float> value)`

Performs 'ConvertToInt32RoundToPositiveInfinity' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToPositiveInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinity(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToPositiveInfinity(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtopositiveinfinity?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToPositiveInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToPositiveInfinity", "Performs 'ConvertToInt32RoundToPositiveInfinity' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToPositiveInfinityScalarResult = Dummy_ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 47. ConvertToInt32RoundToPositiveInfinityScalar

`Vector64<int> ConvertToInt32RoundToPositiveInfinityScalar(Vector64<float> value)`

Performs 'ConvertToInt32RoundToPositiveInfinityScalar' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToPositiveInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtopositiveinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToPositiveInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToPositiveInfinityScalar", "Performs 'ConvertToInt32RoundToPositiveInfinityScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToZeroResult = Dummy_ConvertToInt32RoundToZeroTest(Vector64float_0);
apiResult = ConvertToInt32RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 48. ConvertToInt32RoundToZero

`Vector64<int> ConvertToInt32RoundToZero(Vector64<float> value)`

Performs 'ConvertToInt32RoundToZero' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToZero(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ConvertToInt32RoundToZero(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtozero?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToZero", "Performs 'ConvertToInt32RoundToZero' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt32RoundToZeroScalarResult = Dummy_ConvertToInt32RoundToZeroScalarTest(Vector64float_0);
apiResult = ConvertToInt32RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 49. ConvertToInt32RoundToZeroScalar

`Vector64<int> ConvertToInt32RoundToZeroScalar(Vector64<float> value)`

Performs 'ConvertToInt32RoundToZeroScalar' operation.

```csharp
private Vector64<int> ConvertToInt32RoundToZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToInt32RoundToZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttoint32roundtozeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToInt32RoundToZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt32RoundToZeroScalar", "Performs 'ConvertToInt32RoundToZeroScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToSingleResult = Dummy_ConvertToSingleTest(Vector64int_0);
apiResult = ConvertToSingleResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 50. ConvertToSingle

`Vector64<float> ConvertToSingle(Vector64<int> value)`

Performs 'ConvertToSingle' operation.

```csharp
private Vector64<float> ConvertToSingleTest(Vector64<int> value)
{{
  return AdvSimd.ConvertToSingle(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> ConvertToSingle(Vector64<uint> value)
Vector128<float> ConvertToSingle(Vector128<int> value)
Vector128<float> ConvertToSingle(Vector128<uint> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttosingle?view=net-5.0).

Assembly generated:

```
", Vector64int_0, apiResult);

try {
ConvertToSingleTest(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToSingle", "Performs 'ConvertToSingle' operation", Vector64int_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToSingleScalarResult = Dummy_ConvertToSingleScalarTest(Vector64int_0);
apiResult = ConvertToSingleScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 51. ConvertToSingleScalar

`Vector64<float> ConvertToSingleScalar(Vector64<int> value)`

Performs 'ConvertToSingleScalar' operation.

```csharp
private Vector64<float> ConvertToSingleScalarTest(Vector64<int> value)
{{
  return AdvSimd.ConvertToSingleScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> ConvertToSingleScalar(Vector64<uint> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttosinglescalar?view=net-5.0).

Assembly generated:

```
", Vector64int_0, apiResult);

try {
ConvertToSingleScalarTest(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToSingleScalar", "Performs 'ConvertToSingleScalar' operation", Vector64int_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundAwayFromZeroResult = Dummy_ConvertToUInt32RoundAwayFromZeroTest(Vector64float_0);
apiResult = ConvertToUInt32RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 52. ConvertToUInt32RoundAwayFromZero

`Vector64<uint> ConvertToUInt32RoundAwayFromZero(Vector64<float> value)`

Performs 'ConvertToUInt32RoundAwayFromZero' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundAwayFromZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundAwayFromZero(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundAwayFromZero(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundawayfromzero?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundAwayFromZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundAwayFromZero", "Performs 'ConvertToUInt32RoundAwayFromZero' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundAwayFromZeroScalarResult = Dummy_ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 53. ConvertToUInt32RoundAwayFromZeroScalar

`Vector64<uint> ConvertToUInt32RoundAwayFromZeroScalar(Vector64<float> value)`

Performs 'ConvertToUInt32RoundAwayFromZeroScalar' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundAwayFromZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundawayfromzeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundAwayFromZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundAwayFromZeroScalar", "Performs 'ConvertToUInt32RoundAwayFromZeroScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToEvenResult = Dummy_ConvertToUInt32RoundToEvenTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 54. ConvertToUInt32RoundToEven

`Vector64<uint> ConvertToUInt32RoundToEven(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToEven' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToEvenTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToEven(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToEven(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtoeven?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToEvenTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToEven", "Performs 'ConvertToUInt32RoundToEven' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToEvenScalarResult = Dummy_ConvertToUInt32RoundToEvenScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 55. ConvertToUInt32RoundToEvenScalar

`Vector64<uint> ConvertToUInt32RoundToEvenScalar(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToEvenScalar' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToEvenScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToEvenScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtoevenscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToEvenScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToEvenScalar", "Performs 'ConvertToUInt32RoundToEvenScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToNegativeInfinityResult = Dummy_ConvertToUInt32RoundToNegativeInfinityTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 56. ConvertToUInt32RoundToNegativeInfinity

`Vector64<uint> ConvertToUInt32RoundToNegativeInfinity(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToNegativeInfinity' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToNegativeInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinity(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToNegativeInfinity(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtonegativeinfinity?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToNegativeInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToNegativeInfinity", "Performs 'ConvertToUInt32RoundToNegativeInfinity' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToNegativeInfinityScalarResult = Dummy_ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 57. ConvertToUInt32RoundToNegativeInfinityScalar

`Vector64<uint> ConvertToUInt32RoundToNegativeInfinityScalar(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToNegativeInfinityScalar' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToNegativeInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtonegativeinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToNegativeInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToNegativeInfinityScalar", "Performs 'ConvertToUInt32RoundToNegativeInfinityScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToPositiveInfinityResult = Dummy_ConvertToUInt32RoundToPositiveInfinityTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 58. ConvertToUInt32RoundToPositiveInfinity

`Vector64<uint> ConvertToUInt32RoundToPositiveInfinity(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToPositiveInfinity' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToPositiveInfinityTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinity(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToPositiveInfinity(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtopositiveinfinity?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToPositiveInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToPositiveInfinity", "Performs 'ConvertToUInt32RoundToPositiveInfinity' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToPositiveInfinityScalarResult = Dummy_ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 59. ConvertToUInt32RoundToPositiveInfinityScalar

`Vector64<uint> ConvertToUInt32RoundToPositiveInfinityScalar(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToPositiveInfinityScalar' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToPositiveInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtopositiveinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToPositiveInfinityScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToPositiveInfinityScalar", "Performs 'ConvertToUInt32RoundToPositiveInfinityScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt32RoundToZeroResult = Dummy_ConvertToUInt32RoundToZeroTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 60. ConvertToUInt32RoundToZero

`Vector64<uint> ConvertToUInt32RoundToZero(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToZero' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToZeroTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToZero(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<uint> ConvertToUInt32RoundToZero(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtozero?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToZero", "Performs 'ConvertToUInt32RoundToZero' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: Hardware Intrinsics APIs for ARM64 - Part 2
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

[ConvertToUInt32RoundToZeroScalar](#1-converttouint32roundtozeroscalar), [DivideScalar](#2-dividescalar), [DuplicateSelectedScalarToVector64](#3-duplicateselectedscalartovector64), [DuplicateSelectedScalarToVector128](#4-duplicateselectedscalartovector128), [DuplicateToVector64](#5-duplicatetovector64), [DuplicateToVector128](#6-duplicatetovector128), [Extract](#7-extract), [ExtractNarrowingLower](#8-extractnarrowinglower), [ExtractNarrowingSaturateLower](#9-extractnarrowingsaturatelower), [ExtractNarrowingSaturateUnsignedLower](#10-extractnarrowingsaturateunsignedlower), [ExtractNarrowingSaturateUnsignedUpper](#11-extractnarrowingsaturateunsignedupper), [ExtractNarrowingSaturateUpper](#12-extractnarrowingsaturateupper), [ExtractNarrowingUpper](#13-extractnarrowingupper), [ExtractVector64](#14-extractvector64), [ExtractVector128](#15-extractvector128), [Floor](#16-floor), [FloorScalar](#17-floorscalar), [FusedAddHalving](#18-fusedaddhalving), [FusedAddRoundedHalving](#19-fusedaddroundedhalving), [FusedMultiplyAdd](#20-fusedmultiplyadd), [FusedMultiplyAddNegatedScalar](#21-fusedmultiplyaddnegatedscalar), [FusedMultiplyAddScalar](#22-fusedmultiplyaddscalar), [FusedMultiplySubtract](#23-fusedmultiplysubtract), [FusedMultiplySubtractNegatedScalar](#24-fusedmultiplysubtractnegatedscalar), [FusedMultiplySubtractScalar](#25-fusedmultiplysubtractscalar), [FusedSubtractHalving](#26-fusedsubtracthalving), [Insert](#27-insert), [InsertScalar](#28-insertscalar), [LeadingSignCount](#29-leadingsigncount), [LeadingZeroCount](#30-leadingzerocount), [LoadAndInsertScalar](#31-loadandinsertscalar), [LoadAndReplicateToVector64](#32-loadandreplicatetovector64), [LoadAndReplicateToVector128](#33-loadandreplicatetovector128), [LoadVector64](#34-loadvector64), [LoadVector128](#35-loadvector128), [Max](#36-max), [MaxNumber](#37-maxnumber), [MaxNumberScalar](#38-maxnumberscalar), [MaxPairwise](#39-maxpairwise), [Min](#40-min), [MinNumber](#41-minnumber), [MinNumberScalar](#42-minnumberscalar), [MinPairwise](#43-minpairwise), [Multiply](#44-multiply), [MultiplyAdd](#45-multiplyadd), [MultiplyAddByScalar](#46-multiplyaddbyscalar), [MultiplyAddBySelectedScalar](#47-multiplyaddbyselectedscalar), [MultiplyByScalar](#48-multiplybyscalar), [MultiplyBySelectedScalar](#49-multiplybyselectedscalar), [MultiplyBySelectedScalarWideningLower](#50-multiplybyselectedscalarwideninglower), [MultiplyBySelectedScalarWideningLowerAndAdd](#51-multiplybyselectedscalarwideninglowerandadd), [MultiplyBySelectedScalarWideningLowerAndSubtract](#52-multiplybyselectedscalarwideninglowerandsubtract), [MultiplyBySelectedScalarWideningUpper](#53-multiplybyselectedscalarwideningupper), [MultiplyBySelectedScalarWideningUpperAndAdd](#54-multiplybyselectedscalarwideningupperandadd), [MultiplyBySelectedScalarWideningUpperAndSubtract](#55-multiplybyselectedscalarwideningupperandsubtract), [MultiplyDoublingByScalarSaturateHigh](#56-multiplydoublingbyscalarsaturatehigh), [MultiplyDoublingBySelectedScalarSaturateHigh](#57-multiplydoublingbyselectedscalarsaturatehigh), [MultiplyDoublingSaturateHigh](#58-multiplydoublingsaturatehigh), [MultiplyDoublingWideningLowerAndAddSaturate](#59-multiplydoublingwideninglowerandaddsaturate), [MultiplyDoublingWideningLowerAndSubtractSaturate](#60-multiplydoublingwideninglowerandsubtractsaturate),[...](Part2.md)


");

try {
var ConvertToUInt32RoundToZeroScalarResult = Dummy_ConvertToUInt32RoundToZeroScalarTest(Vector64float_0);
apiResult = ConvertToUInt32RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"


### 1. ConvertToUInt32RoundToZeroScalar

`Vector64<uint> ConvertToUInt32RoundToZeroScalar(Vector64<float> value)`

Performs 'ConvertToUInt32RoundToZeroScalar' operation.

```csharp
private Vector64<uint> ConvertToUInt32RoundToZeroScalarTest(Vector64<float> value)
{{
  return AdvSimd.ConvertToUInt32RoundToZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.converttouint32roundtozeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToUInt32RoundToZeroScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt32RoundToZeroScalar", "Performs 'ConvertToUInt32RoundToZeroScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var DivideScalarResult = Dummy_DivideScalarTest(Vector64double_0, Vector64double_1);
apiResult = DivideScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 2. DivideScalar

`Vector64<double> DivideScalar(Vector64<double> left, Vector64<double> right)`

Performs 'DivideScalar' operation.

```csharp
private Vector64<double> DivideScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.DivideScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> DivideScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.dividescalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
DivideScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("DivideScalar", "Performs 'DivideScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var DuplicateSelectedScalarToVector64Result = Dummy_DuplicateSelectedScalarToVector64Test(Vector64byte_0, byte_0);
apiResult = DuplicateSelectedScalarToVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 3. DuplicateSelectedScalarToVector64

`Vector64<byte> DuplicateSelectedScalarToVector64(Vector64<byte> value, byte index)`

Performs 'DuplicateSelectedScalarToVector64' operation.

```csharp
private Vector64<byte> DuplicateSelectedScalarToVector64Test(Vector64<byte> value, byte index)
{{
  return AdvSimd.DuplicateSelectedScalarToVector64(value, index);
}}
// value = {0}
// index = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicateselectedscalartovector64?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
DuplicateSelectedScalarToVector64Test(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("DuplicateSelectedScalarToVector64", "Performs 'DuplicateSelectedScalarToVector64' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var DuplicateSelectedScalarToVector128Result = Dummy_DuplicateSelectedScalarToVector128Test(Vector64byte_0, byte_0);
apiResult = DuplicateSelectedScalarToVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 4. DuplicateSelectedScalarToVector128

`Vector128<byte> DuplicateSelectedScalarToVector128(Vector64<byte> value, byte index)`

Performs 'DuplicateSelectedScalarToVector128' operation.

```csharp
private Vector128<byte> DuplicateSelectedScalarToVector128Test(Vector64<byte> value, byte index)
{{
  return AdvSimd.DuplicateSelectedScalarToVector128(value, index);
}}
// value = {0}
// index = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicateselectedscalartovector128?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.duplicateselectedscalartovector128?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
DuplicateSelectedScalarToVector128Test(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("DuplicateSelectedScalarToVector128", "Performs 'DuplicateSelectedScalarToVector128' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var DuplicateToVector64Result = Dummy_DuplicateToVector64Test(byte_0);
apiResult = DuplicateToVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 5. DuplicateToVector64

`Vector64<byte> DuplicateToVector64(byte value)`

Performs 'DuplicateToVector64' operation.

```csharp
private Vector64<byte> DuplicateToVector64Test(byte value)
{{
  return AdvSimd.DuplicateToVector64(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicatetovector64?view=net-5.0).

Assembly generated:

```
", byte_0, apiResult);

try {
DuplicateToVector64Test(byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("DuplicateToVector64", "Performs 'DuplicateToVector64' operation", byte_0, apiResult);
// ----------------------------------------------------------------

try {
var DuplicateToVector128Result = Dummy_DuplicateToVector128Test(byte_0);
apiResult = DuplicateToVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 6. DuplicateToVector128

`Vector128<byte> DuplicateToVector128(byte value)`

Performs 'DuplicateToVector128' operation.

```csharp
private Vector128<byte> DuplicateToVector128Test(byte value)
{{
  return AdvSimd.DuplicateToVector128(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.duplicatetovector128?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.duplicatetovector128?view=net-5.0).

Assembly generated:

```
", byte_0, apiResult);

try {
DuplicateToVector128Test(byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("DuplicateToVector128", "Performs 'DuplicateToVector128' operation", byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractResult = Dummy_ExtractTest(Vector64byte_0, byte_0);
apiResult = ExtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 7. Extract

`byte Extract(Vector64<byte> vector, byte index)`

Performs 'Extract' operation.

```csharp
private byte ExtractTest(Vector64<byte> vector, byte index)
{{
  return AdvSimd.Extract(vector, index);
}}
// vector = {0}
// index = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extract?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
ExtractTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Extract", "Performs 'Extract' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingLowerResult = Dummy_ExtractNarrowingLowerTest(Vector128ushort_0);
apiResult = ExtractNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 8. ExtractNarrowingLower

`Vector64<byte> ExtractNarrowingLower(Vector128<ushort> value)`

Performs 'ExtractNarrowingLower' operation.

```csharp
private Vector64<byte> ExtractNarrowingLowerTest(Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingLower(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, apiResult);

try {
ExtractNarrowingLowerTest(Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingLower", "Performs 'ExtractNarrowingLower' operation", Vector128ushort_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateLowerResult = Dummy_ExtractNarrowingSaturateLowerTest(Vector128ushort_0);
apiResult = ExtractNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 9. ExtractNarrowingSaturateLower

`Vector64<byte> ExtractNarrowingSaturateLower(Vector128<ushort> value)`

Performs 'ExtractNarrowingSaturateLower' operation.

```csharp
private Vector64<byte> ExtractNarrowingSaturateLowerTest(Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingSaturateLower(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturatelower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, apiResult);

try {
ExtractNarrowingSaturateLowerTest(Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingSaturateLower", "Performs 'ExtractNarrowingSaturateLower' operation", Vector128ushort_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUnsignedLowerResult = Dummy_ExtractNarrowingSaturateUnsignedLowerTest(Vector128short_0);
apiResult = ExtractNarrowingSaturateUnsignedLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 10. ExtractNarrowingSaturateUnsignedLower

`Vector64<byte> ExtractNarrowingSaturateUnsignedLower(Vector128<short> value)`

Performs 'ExtractNarrowingSaturateUnsignedLower' operation.

```csharp
private Vector64<byte> ExtractNarrowingSaturateUnsignedLowerTest(Vector128<short> value)
{{
  return AdvSimd.ExtractNarrowingSaturateUnsignedLower(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> ExtractNarrowingSaturateUnsignedLower(Vector128<int> value)
Vector64<uint> ExtractNarrowingSaturateUnsignedLower(Vector128<long> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturateunsignedlower?view=net-5.0).

Assembly generated:

```
", Vector128short_0, apiResult);

try {
ExtractNarrowingSaturateUnsignedLowerTest(Vector128short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingSaturateUnsignedLower", "Performs 'ExtractNarrowingSaturateUnsignedLower' operation", Vector128short_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUnsignedUpperResult = Dummy_ExtractNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0);
apiResult = ExtractNarrowingSaturateUnsignedUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 11. ExtractNarrowingSaturateUnsignedUpper

`Vector128<byte> ExtractNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value)`

Performs 'ExtractNarrowingSaturateUnsignedUpper' operation.

```csharp
private Vector128<byte> ExtractNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value)
{{
  return AdvSimd.ExtractNarrowingSaturateUnsignedUpper(lower, value);
}}
// lower = {0}
// value = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<ushort> ExtractNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value)
Vector128<uint> ExtractNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturateunsignedupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128short_0, apiResult);

try {
ExtractNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingSaturateUnsignedUpper", "Performs 'ExtractNarrowingSaturateUnsignedUpper' operation", Vector64byte_0, Vector128short_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUpperResult = Dummy_ExtractNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0);
apiResult = ExtractNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 12. ExtractNarrowingSaturateUpper

`Vector128<byte> ExtractNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value)`

Performs 'ExtractNarrowingSaturateUpper' operation.

```csharp
private Vector128<byte> ExtractNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingSaturateUpper(lower, value);
}}
// lower = {0}
// value = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingsaturateupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, apiResult);

try {
ExtractNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingSaturateUpper", "Performs 'ExtractNarrowingSaturateUpper' operation", Vector64byte_0, Vector128ushort_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingUpperResult = Dummy_ExtractNarrowingUpperTest(Vector64byte_0, Vector128ushort_0);
apiResult = ExtractNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 13. ExtractNarrowingUpper

`Vector128<byte> ExtractNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value)`

Performs 'ExtractNarrowingUpper' operation.

```csharp
private Vector128<byte> ExtractNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value)
{{
  return AdvSimd.ExtractNarrowingUpper(lower, value);
}}
// lower = {0}
// value = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractnarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, apiResult);

try {
ExtractNarrowingUpperTest(Vector64byte_0, Vector128ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingUpper", "Performs 'ExtractNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractVector64Result = Dummy_ExtractVector64Test(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ExtractVector64Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 14. ExtractVector64

`Vector64<byte> ExtractVector64(Vector64<byte> upper, Vector64<byte> lower, byte index)`

Performs 'ExtractVector64' operation.

```csharp
private Vector64<byte> ExtractVector64Test(Vector64<byte> upper, Vector64<byte> lower, byte index)
{{
  return AdvSimd.ExtractVector64(upper, lower, index);
}}
// upper = {0}
// lower = {1}
// index = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractvector64?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, byte_0, apiResult);

try {
ExtractVector64Test(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractVector64", "Performs 'ExtractVector64' operation", Vector64byte_0, Vector64byte_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractVector128Result = Dummy_ExtractVector128Test(Vector128byte_0, Vector128byte_1, byte_0);
apiResult = ExtractVector128Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 15. ExtractVector128

`Vector128<byte> ExtractVector128(Vector128<byte> upper, Vector128<byte> lower, byte index)`

Performs 'ExtractVector128' operation.

```csharp
private Vector128<byte> ExtractVector128Test(Vector128<byte> upper, Vector128<byte> lower, byte index)
{{
  return AdvSimd.ExtractVector128(upper, lower, index);
}}
// upper = {0}
// lower = {1}
// index = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.extractvector128?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector128byte_1, byte_0, apiResult);

try {
ExtractVector128Test(Vector128byte_0, Vector128byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractVector128", "Performs 'ExtractVector128' operation", Vector128byte_0, Vector128byte_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var FloorResult = Dummy_FloorTest(Vector64float_0);
apiResult = FloorResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 16. Floor

`Vector64<float> Floor(Vector64<float> value)`

Performs 'Floor' operation.

```csharp
private Vector64<float> FloorTest(Vector64<float> value)
{{
  return AdvSimd.Floor(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> Floor(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Floor(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.floor?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.floor?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
FloorTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Floor", "Performs 'Floor' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var FloorScalarResult = Dummy_FloorScalarTest(Vector64double_0);
apiResult = FloorScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 17. FloorScalar

`Vector64<double> FloorScalar(Vector64<double> value)`

Performs 'FloorScalar' operation.

```csharp
private Vector64<double> FloorScalarTest(Vector64<double> value)
{{
  return AdvSimd.FloorScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FloorScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.floorscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
FloorScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FloorScalar", "Performs 'FloorScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var FusedAddHalvingResult = Dummy_FusedAddHalvingTest(Vector64byte_0, Vector64byte_1);
apiResult = FusedAddHalvingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 18. FusedAddHalving

`Vector64<byte> FusedAddHalving(Vector64<byte> left, Vector64<byte> right)`

Performs 'FusedAddHalving' operation.

```csharp
private Vector64<byte> FusedAddHalvingTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.FusedAddHalving(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedaddhalving?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
FusedAddHalvingTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedAddHalving", "Performs 'FusedAddHalving' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var FusedAddRoundedHalvingResult = Dummy_FusedAddRoundedHalvingTest(Vector64byte_0, Vector64byte_1);
apiResult = FusedAddRoundedHalvingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 19. FusedAddRoundedHalving

`Vector64<byte> FusedAddRoundedHalving(Vector64<byte> left, Vector64<byte> right)`

Performs 'FusedAddRoundedHalving' operation.

```csharp
private Vector64<byte> FusedAddRoundedHalvingTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.FusedAddRoundedHalving(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedaddroundedhalving?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
FusedAddRoundedHalvingTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedAddRoundedHalving", "Performs 'FusedAddRoundedHalving' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplyAddResult = Dummy_FusedMultiplyAddTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplyAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 20. FusedMultiplyAdd

`Vector64<float> FusedMultiplyAdd(Vector64<float> addend, Vector64<float> left, Vector64<float> right)`

Performs 'FusedMultiplyAdd' operation.

```csharp
private Vector64<float> FusedMultiplyAddTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.FusedMultiplyAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> FusedMultiplyAdd(Vector128<float> addend, Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplyAdd(Vector128<double> addend, Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplyadd?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyadd?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);

try {
FusedMultiplyAddTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplyAdd", "Performs 'FusedMultiplyAdd' operation", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplyAddNegatedScalarResult = Dummy_FusedMultiplyAddNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplyAddNegatedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 21. FusedMultiplyAddNegatedScalar

`Vector64<double> FusedMultiplyAddNegatedScalar(Vector64<double> addend, Vector64<double> left, Vector64<double> right)`

Performs 'FusedMultiplyAddNegatedScalar' operation.

```csharp
private Vector64<double> FusedMultiplyAddNegatedScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplyAddNegatedScalar(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplyAddNegatedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplyaddnegatedscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);

try {
FusedMultiplyAddNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplyAddNegatedScalar", "Performs 'FusedMultiplyAddNegatedScalar' operation", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplyAddScalarResult = Dummy_FusedMultiplyAddScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplyAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 22. FusedMultiplyAddScalar

`Vector64<double> FusedMultiplyAddScalar(Vector64<double> addend, Vector64<double> left, Vector64<double> right)`

Performs 'FusedMultiplyAddScalar' operation.

```csharp
private Vector64<double> FusedMultiplyAddScalarTest(Vector64<double> addend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplyAddScalar(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplyAddScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplyaddscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);

try {
FusedMultiplyAddScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplyAddScalar", "Performs 'FusedMultiplyAddScalar' operation", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplySubtractResult = Dummy_FusedMultiplySubtractTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplySubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 23. FusedMultiplySubtract

`Vector64<float> FusedMultiplySubtract(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)`

Performs 'FusedMultiplySubtract' operation.

```csharp
private Vector64<float> FusedMultiplySubtractTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.FusedMultiplySubtract(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> FusedMultiplySubtract(Vector128<float> minuend, Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplySubtract(Vector128<double> minuend, Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplysubtract?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtract?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);

try {
FusedMultiplySubtractTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplySubtract", "Performs 'FusedMultiplySubtract' operation", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplySubtractNegatedScalarResult = Dummy_FusedMultiplySubtractNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplySubtractNegatedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 24. FusedMultiplySubtractNegatedScalar

`Vector64<double> FusedMultiplySubtractNegatedScalar(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)`

Performs 'FusedMultiplySubtractNegatedScalar' operation.

```csharp
private Vector64<double> FusedMultiplySubtractNegatedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplySubtractNegatedScalar(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplySubtractNegatedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplysubtractnegatedscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);

try {
FusedMultiplySubtractNegatedScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplySubtractNegatedScalar", "Performs 'FusedMultiplySubtractNegatedScalar' operation", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplySubtractScalarResult = Dummy_FusedMultiplySubtractScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);
apiResult = FusedMultiplySubtractScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 25. FusedMultiplySubtractScalar

`Vector64<double> FusedMultiplySubtractScalar(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)`

Performs 'FusedMultiplySubtractScalar' operation.

```csharp
private Vector64<double> FusedMultiplySubtractScalarTest(Vector64<double> minuend, Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.FusedMultiplySubtractScalar(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> FusedMultiplySubtractScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedmultiplysubtractscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);

try {
FusedMultiplySubtractScalarTest(Vector64double_0, Vector64double_1, Vector64double_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplySubtractScalar", "Performs 'FusedMultiplySubtractScalar' operation", Vector64double_0, Vector64double_1, Vector64double_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedSubtractHalvingResult = Dummy_FusedSubtractHalvingTest(Vector64byte_0, Vector64byte_1);
apiResult = FusedSubtractHalvingResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 26. FusedSubtractHalving

`Vector64<byte> FusedSubtractHalving(Vector64<byte> left, Vector64<byte> right)`

Performs 'FusedSubtractHalving' operation.

```csharp
private Vector64<byte> FusedSubtractHalvingTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.FusedSubtractHalving(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.fusedsubtracthalving?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
FusedSubtractHalvingTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedSubtractHalving", "Performs 'FusedSubtractHalving' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var InsertResult = Dummy_InsertTest(Vector64byte_0, byte_0, byte_1);
apiResult = InsertResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 27. Insert

`Vector64<byte> Insert(Vector64<byte> vector, byte index, byte data)`

Performs 'Insert' operation.

```csharp
private Vector64<byte> InsertTest(Vector64<byte> vector, byte index, byte data)
{{
  return AdvSimd.Insert(vector, index, data);
}}
// vector = {0}
// index = {1}
// data = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.insert?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, byte_1, apiResult);

try {
InsertTest(Vector64byte_0, byte_0, byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Insert", "Performs 'Insert' operation", Vector64byte_0, byte_0, byte_1, apiResult);
// ----------------------------------------------------------------

try {
var InsertScalarResult = Dummy_InsertScalarTest(Vector128double_0, byte_0, Vector64double_0);
apiResult = InsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 28. InsertScalar

`Vector128<double> InsertScalar(Vector128<double> result, byte resultIndex, Vector64<double> value)`

Performs 'InsertScalar' operation.

```csharp
private Vector128<double> InsertScalarTest(Vector128<double> result, byte resultIndex, Vector64<double> value)
{{
  return AdvSimd.InsertScalar(result, resultIndex, value);
}}
// result = {0}
// resultIndex = {1}
// value = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> InsertScalar(Vector128<long> result, byte resultIndex, Vector64<long> value)
Vector128<ulong> InsertScalar(Vector128<ulong> result, byte resultIndex, Vector64<ulong> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.insertscalar?view=net-5.0).

Assembly generated:

```
", Vector128double_0, byte_0, Vector64double_0, apiResult);

try {
InsertScalarTest(Vector128double_0, byte_0, Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("InsertScalar", "Performs 'InsertScalar' operation", Vector128double_0, byte_0, Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var LeadingSignCountResult = Dummy_LeadingSignCountTest(Vector64short_0);
apiResult = LeadingSignCountResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 29. LeadingSignCount

`Vector64<short> LeadingSignCount(Vector64<short> value)`

Performs 'LeadingSignCount' operation.

```csharp
private Vector64<short> LeadingSignCountTest(Vector64<short> value)
{{
  return AdvSimd.LeadingSignCount(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.leadingsigncount?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
LeadingSignCountTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("LeadingSignCount", "Performs 'LeadingSignCount' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var LeadingZeroCountResult = Dummy_LeadingZeroCountTest(Vector64byte_0);
apiResult = LeadingZeroCountResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 30. LeadingZeroCount

`Vector64<byte> LeadingZeroCount(Vector64<byte> value)`

Performs 'LeadingZeroCount' operation.

```csharp
private Vector64<byte> LeadingZeroCountTest(Vector64<byte> value)
{{
  return AdvSimd.LeadingZeroCount(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.leadingzerocount?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
LeadingZeroCountTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("LeadingZeroCount", "Performs 'LeadingZeroCount' operation", Vector64byte_0, apiResult);
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
@"
```
------------------------------------------------

### 31. LoadAndInsertScalar

`Vector64<byte> LoadAndInsertScalar(Vector64<byte> value, byte index, byte* address)`

Performs 'LoadAndInsertScalar' operation.

```csharp
private Vector64<byte> LoadAndInsertScalarTest(Vector64<byte> value, byte index, byte* address)
{{
  return AdvSimd.LoadAndInsertScalar(value, index, address);
}}
// value = {0}
// index = {1}
// address = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadandinsertscalar?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, "<address>", apiResult);

try {
LoadAndInsertScalarTest(Vector64byte_0, byte_0, bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("LoadAndInsertScalar", "Performs 'LoadAndInsertScalar' operation", Vector64byte_0, byte_0, "<address>", apiResult);
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
@"
```
------------------------------------------------

### 32. LoadAndReplicateToVector64

`Vector64<byte> LoadAndReplicateToVector64(byte* address)`

Performs 'LoadAndReplicateToVector64' operation.

```csharp
private Vector64<byte> LoadAndReplicateToVector64Test(byte* address)
{{
  return AdvSimd.LoadAndReplicateToVector64(address);
}}
// address = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadandreplicatetovector64?view=net-5.0).

Assembly generated:

```
", "<address>", apiResult);

try {
LoadAndReplicateToVector64Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("LoadAndReplicateToVector64", "Performs 'LoadAndReplicateToVector64' operation", "<address>", apiResult);
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
@"
```
------------------------------------------------

### 33. LoadAndReplicateToVector128

`Vector128<byte> LoadAndReplicateToVector128(byte* address)`

Performs 'LoadAndReplicateToVector128' operation.

```csharp
private Vector128<byte> LoadAndReplicateToVector128Test(byte* address)
{{
  return AdvSimd.LoadAndReplicateToVector128(address);
}}
// address = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadandreplicatetovector128?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.loadandreplicatetovector128?view=net-5.0).

Assembly generated:

```
", "<address>", apiResult);

try {
LoadAndReplicateToVector128Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("LoadAndReplicateToVector128", "Performs 'LoadAndReplicateToVector128' operation", "<address>", apiResult);
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
@"
```
------------------------------------------------

### 34. LoadVector64

`Vector64<byte> LoadVector64(byte* address)`

Performs 'LoadVector64' operation.

```csharp
private Vector64<byte> LoadVector64Test(byte* address)
{{
  return AdvSimd.LoadVector64(address);
}}
// address = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadvector64?view=net-5.0).

Assembly generated:

```
", "<address>", apiResult);

try {
LoadVector64Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("LoadVector64", "Performs 'LoadVector64' operation", "<address>", apiResult);
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
@"
```
------------------------------------------------

### 35. LoadVector128

`Vector128<byte> LoadVector128(byte* address)`

Performs 'LoadVector128' operation.

```csharp
private Vector128<byte> LoadVector128Test(byte* address)
{{
  return AdvSimd.LoadVector128(address);
}}
// address = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.loadvector128?view=net-5.0).

Assembly generated:

```
", "<address>", apiResult);

try {
LoadVector128Test(bytePtr_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("LoadVector128", "Performs 'LoadVector128' operation", "<address>", apiResult);
// ----------------------------------------------------------------

try {
var MaxResult = Dummy_MaxTest(Vector64byte_0, Vector64byte_1);
apiResult = MaxResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 36. Max

`Vector64<byte> Max(Vector64<byte> left, Vector64<byte> right)`

Performs 'Max' operation.

```csharp
private Vector64<byte> MaxTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Max(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.max?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.max?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
MaxTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Max", "Performs 'Max' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MaxNumberResult = Dummy_MaxNumberTest(Vector64float_0, Vector64float_1);
apiResult = MaxNumberResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 37. MaxNumber

`Vector64<float> MaxNumber(Vector64<float> left, Vector64<float> right)`

Performs 'MaxNumber' operation.

```csharp
private Vector64<float> MaxNumberTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.MaxNumber(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> MaxNumber(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MaxNumber(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.maxnumber?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumber?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
MaxNumberTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxNumber", "Performs 'MaxNumber' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var MaxNumberScalarResult = Dummy_MaxNumberScalarTest(Vector64double_0, Vector64double_1);
apiResult = MaxNumberScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 38. MaxNumberScalar

`Vector64<double> MaxNumberScalar(Vector64<double> left, Vector64<double> right)`

Performs 'MaxNumberScalar' operation.

```csharp
private Vector64<double> MaxNumberScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.MaxNumberScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MaxNumberScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.maxnumberscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
MaxNumberScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxNumberScalar", "Performs 'MaxNumberScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var MaxPairwiseResult = Dummy_MaxPairwiseTest(Vector64byte_0, Vector64byte_1);
apiResult = MaxPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 39. MaxPairwise

`Vector64<byte> MaxPairwise(Vector64<byte> left, Vector64<byte> right)`

Performs 'MaxPairwise' operation.

```csharp
private Vector64<byte> MaxPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MaxPairwise(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.maxpairwise?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxpairwise?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
MaxPairwiseTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxPairwise", "Performs 'MaxPairwise' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MinResult = Dummy_MinTest(Vector64byte_0, Vector64byte_1);
apiResult = MinResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 40. Min

`Vector64<byte> Min(Vector64<byte> left, Vector64<byte> right)`

Performs 'Min' operation.

```csharp
private Vector64<byte> MinTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Min(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.min?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.min?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
MinTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Min", "Performs 'Min' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MinNumberResult = Dummy_MinNumberTest(Vector64float_0, Vector64float_1);
apiResult = MinNumberResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 41. MinNumber

`Vector64<float> MinNumber(Vector64<float> left, Vector64<float> right)`

Performs 'MinNumber' operation.

```csharp
private Vector64<float> MinNumberTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.MinNumber(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> MinNumber(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MinNumber(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.minnumber?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumber?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
MinNumberTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinNumber", "Performs 'MinNumber' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var MinNumberScalarResult = Dummy_MinNumberScalarTest(Vector64double_0, Vector64double_1);
apiResult = MinNumberScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 42. MinNumberScalar

`Vector64<double> MinNumberScalar(Vector64<double> left, Vector64<double> right)`

Performs 'MinNumberScalar' operation.

```csharp
private Vector64<double> MinNumberScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.MinNumberScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MinNumberScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.minnumberscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
MinNumberScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinNumberScalar", "Performs 'MinNumberScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var MinPairwiseResult = Dummy_MinPairwiseTest(Vector64byte_0, Vector64byte_1);
apiResult = MinPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 43. MinPairwise

`Vector64<byte> MinPairwise(Vector64<byte> left, Vector64<byte> right)`

Performs 'MinPairwise' operation.

```csharp
private Vector64<byte> MinPairwiseTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MinPairwise(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.minpairwise?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minpairwise?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
MinPairwiseTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinPairwise", "Performs 'MinPairwise' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyResult = Dummy_MultiplyTest(Vector64byte_0, Vector64byte_1);
apiResult = MultiplyResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 44. Multiply

`Vector64<byte> Multiply(Vector64<byte> left, Vector64<byte> right)`

Performs 'Multiply' operation.

```csharp
private Vector64<byte> MultiplyTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Multiply(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiply?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiply?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
MultiplyTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Multiply", "Performs 'Multiply' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyAddResult = Dummy_MultiplyAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = MultiplyAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 45. MultiplyAdd

`Vector64<byte> MultiplyAdd(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)`

Performs 'MultiplyAdd' operation.

```csharp
private Vector64<byte> MultiplyAddTest(Vector64<byte> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyadd?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);

try {
MultiplyAddTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyAdd", "Performs 'MultiplyAdd' operation", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyAddByScalarResult = Dummy_MultiplyAddByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);
apiResult = MultiplyAddByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 46. MultiplyAddByScalar

`Vector64<short> MultiplyAddByScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyAddByScalar' operation.

```csharp
private Vector64<short> MultiplyAddByScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyAddByScalar(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyaddbyscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, Vector64short_2, apiResult);

try {
MultiplyAddByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyAddByScalar", "Performs 'MultiplyAddByScalar' operation", Vector64short_0, Vector64short_1, Vector64short_2, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyAddBySelectedScalarResult = Dummy_MultiplyAddBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);
apiResult = MultiplyAddBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 47. MultiplyAddBySelectedScalar

`Vector64<short> MultiplyAddBySelectedScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyAddBySelectedScalar' operation.

```csharp
private Vector64<short> MultiplyAddBySelectedScalarTest(Vector64<short> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyAddBySelectedScalar(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyaddbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, Vector64short_2, byte_0, apiResult);

try {
MultiplyAddBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyAddBySelectedScalar", "Performs 'MultiplyAddBySelectedScalar' operation", Vector64short_0, Vector64short_1, Vector64short_2, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyByScalarResult = Dummy_MultiplyByScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 48. MultiplyByScalar

`Vector64<short> MultiplyByScalar(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyByScalar' operation.

```csharp
private Vector64<short> MultiplyByScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyByScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplybyscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyByScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyByScalar", "Performs 'MultiplyByScalar' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarResult = Dummy_MultiplyBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 49. MultiplyBySelectedScalar

`Vector64<short> MultiplyBySelectedScalar(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalar' operation.

```csharp
private Vector64<short> MultiplyBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplybyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalar", "Performs 'MultiplyBySelectedScalar' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningLowerResult = Dummy_MultiplyBySelectedScalarWideningLowerTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 50. MultiplyBySelectedScalarWideningLower

`Vector128<int> MultiplyBySelectedScalarWideningLower(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalarWideningLower' operation.

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningLowerTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningLower(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideninglower?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyBySelectedScalarWideningLowerTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalarWideningLower", "Performs 'MultiplyBySelectedScalarWideningLower' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningLowerAndAddResult = Dummy_MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarWideningLowerAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 51. MultiplyBySelectedScalarWideningLowerAndAdd

`Vector128<int> MultiplyBySelectedScalarWideningLowerAndAdd(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalarWideningLowerAndAdd' operation.

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndAdd(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideninglowerandadd?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyBySelectedScalarWideningLowerAndAddTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalarWideningLowerAndAdd", "Performs 'MultiplyBySelectedScalarWideningLowerAndAdd' operation", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningLowerAndSubtractResult = Dummy_MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyBySelectedScalarWideningLowerAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 52. MultiplyBySelectedScalarWideningLowerAndSubtract

`Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtract(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalarWideningLowerAndSubtract' operation.

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningLowerAndSubtract(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideninglowerandsubtract?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyBySelectedScalarWideningLowerAndSubtractTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalarWideningLowerAndSubtract", "Performs 'MultiplyBySelectedScalarWideningLowerAndSubtract' operation", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningUpperResult = Dummy_MultiplyBySelectedScalarWideningUpperTest(Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyBySelectedScalarWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 53. MultiplyBySelectedScalarWideningUpper

`Vector128<int> MultiplyBySelectedScalarWideningUpper(Vector128<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalarWideningUpper' operation.

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningUpperTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningUpper(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideningupper?view=net-5.0).

Assembly generated:

```
", Vector128short_0, Vector64short_0, byte_0, apiResult);

try {
MultiplyBySelectedScalarWideningUpperTest(Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalarWideningUpper", "Performs 'MultiplyBySelectedScalarWideningUpper' operation", Vector128short_0, Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningUpperAndAddResult = Dummy_MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyBySelectedScalarWideningUpperAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 54. MultiplyBySelectedScalarWideningUpperAndAdd

`Vector128<int> MultiplyBySelectedScalarWideningUpperAndAdd(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalarWideningUpperAndAdd' operation.

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndAdd(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideningupperandadd?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);

try {
MultiplyBySelectedScalarWideningUpperAndAddTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalarWideningUpperAndAdd", "Performs 'MultiplyBySelectedScalarWideningUpperAndAdd' operation", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyBySelectedScalarWideningUpperAndSubtractResult = Dummy_MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyBySelectedScalarWideningUpperAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 55. MultiplyBySelectedScalarWideningUpperAndSubtract

`Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtract(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyBySelectedScalarWideningUpperAndSubtract' operation.

```csharp
private Vector128<int> MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyBySelectedScalarWideningUpperAndSubtract(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplybyselectedscalarwideningupperandsubtract?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);

try {
MultiplyBySelectedScalarWideningUpperAndSubtractTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyBySelectedScalarWideningUpperAndSubtract", "Performs 'MultiplyBySelectedScalarWideningUpperAndSubtract' operation", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingByScalarSaturateHighResult = Dummy_MultiplyDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingByScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 56. MultiplyDoublingByScalarSaturateHigh

`Vector64<short> MultiplyDoublingByScalarSaturateHigh(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingByScalarSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingByScalarSaturateHigh(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyDoublingByScalarSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyDoublingByScalarSaturateHigh(Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplyDoublingByScalarSaturateHigh(Vector128<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingbyscalarsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingByScalarSaturateHigh", "Performs 'MultiplyDoublingByScalarSaturateHigh' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingBySelectedScalarSaturateHighResult = Dummy_MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 57. MultiplyDoublingBySelectedScalarSaturateHigh

`Vector64<short> MultiplyDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingBySelectedScalarSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingBySelectedScalarSaturateHigh(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingbyselectedscalarsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingBySelectedScalarSaturateHigh", "Performs 'MultiplyDoublingBySelectedScalarSaturateHigh' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingSaturateHighResult = Dummy_MultiplyDoublingSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 58. MultiplyDoublingSaturateHigh

`Vector64<short> MultiplyDoublingSaturateHigh(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingSaturateHigh(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyDoublingSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyDoublingSaturateHigh(Vector128<short> left, Vector128<short> right)
Vector128<int> MultiplyDoublingSaturateHigh(Vector128<int> left, Vector128<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingSaturateHigh", "Performs 'MultiplyDoublingSaturateHigh' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerAndAddSaturateResult = Dummy_MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 59. MultiplyDoublingWideningLowerAndAddSaturate

`Vector128<int> MultiplyDoublingWideningLowerAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningLowerAndAddSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerAndAddSaturate(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningLowerAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningLowerAndAddSaturate", "Performs 'MultiplyDoublingWideningLowerAndAddSaturate' operation", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 60. MultiplyDoublingWideningLowerAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningLowerAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningLowerAndSubtractSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerAndSubtractSaturate(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningLowerAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningLowerAndSubtractSaturate", "Performs 'MultiplyDoublingWideningLowerAndSubtractSaturate' operation", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: Hardware Intrinsics APIs for ARM64 - Part 3
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

[MultiplyDoublingWideningLowerByScalarAndAddSaturate](#1-multiplydoublingwideninglowerbyscalarandaddsaturate), [MultiplyDoublingWideningLowerByScalarAndSubtractSaturate](#2-multiplydoublingwideninglowerbyscalarandsubtractsaturate), [MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate](#3-multiplydoublingwideninglowerbyselectedscalarandaddsaturate), [MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate](#4-multiplydoublingwideninglowerbyselectedscalarandsubtractsaturate), [MultiplyDoublingWideningSaturateLower](#5-multiplydoublingwideningsaturatelower), [MultiplyDoublingWideningSaturateLowerByScalar](#6-multiplydoublingwideningsaturatelowerbyscalar), [MultiplyDoublingWideningSaturateLowerBySelectedScalar](#7-multiplydoublingwideningsaturatelowerbyselectedscalar), [MultiplyDoublingWideningSaturateUpper](#8-multiplydoublingwideningsaturateupper), [MultiplyDoublingWideningSaturateUpperByScalar](#9-multiplydoublingwideningsaturateupperbyscalar), [MultiplyDoublingWideningSaturateUpperBySelectedScalar](#10-multiplydoublingwideningsaturateupperbyselectedscalar), [MultiplyDoublingWideningUpperAndAddSaturate](#11-multiplydoublingwideningupperandaddsaturate), [MultiplyDoublingWideningUpperAndSubtractSaturate](#12-multiplydoublingwideningupperandsubtractsaturate), [MultiplyDoublingWideningUpperByScalarAndAddSaturate](#13-multiplydoublingwideningupperbyscalarandaddsaturate), [MultiplyDoublingWideningUpperByScalarAndSubtractSaturate](#14-multiplydoublingwideningupperbyscalarandsubtractsaturate), [MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate](#15-multiplydoublingwideningupperbyselectedscalarandaddsaturate), [MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate](#16-multiplydoublingwideningupperbyselectedscalarandsubtractsaturate), [MultiplyRoundedDoublingByScalarSaturateHigh](#17-multiplyroundeddoublingbyscalarsaturatehigh), [MultiplyRoundedDoublingBySelectedScalarSaturateHigh](#18-multiplyroundeddoublingbyselectedscalarsaturatehigh), [MultiplyRoundedDoublingSaturateHigh](#19-multiplyroundeddoublingsaturatehigh), [MultiplyScalar](#20-multiplyscalar), [MultiplyScalarBySelectedScalar](#21-multiplyscalarbyselectedscalar), [MultiplySubtract](#22-multiplysubtract), [MultiplySubtractByScalar](#23-multiplysubtractbyscalar), [MultiplySubtractBySelectedScalar](#24-multiplysubtractbyselectedscalar), [MultiplyWideningLower](#25-multiplywideninglower), [MultiplyWideningLowerAndAdd](#26-multiplywideninglowerandadd), [MultiplyWideningLowerAndSubtract](#27-multiplywideninglowerandsubtract), [MultiplyWideningUpper](#28-multiplywideningupper), [MultiplyWideningUpperAndAdd](#29-multiplywideningupperandadd), [MultiplyWideningUpperAndSubtract](#30-multiplywideningupperandsubtract), [Negate](#31-negate), [NegateSaturate](#32-negatesaturate), [NegateScalar](#33-negatescalar), [Not](#34-not), [Or](#35-or), [OrNot](#36-ornot), [PolynomialMultiply](#37-polynomialmultiply), [PolynomialMultiplyWideningLower](#38-polynomialmultiplywideninglower), [PolynomialMultiplyWideningUpper](#39-polynomialmultiplywideningupper), [PopCount](#40-popcount), [ReciprocalEstimate](#41-reciprocalestimate), [ReciprocalSquareRootEstimate](#42-reciprocalsquarerootestimate), [ReciprocalSquareRootStep](#43-reciprocalsquarerootstep), [ReciprocalStep](#44-reciprocalstep), [ReverseElement16](#45-reverseelement16), [ReverseElement32](#46-reverseelement32), [ReverseElement8](#47-reverseelement8), [RoundAwayFromZero](#48-roundawayfromzero), [RoundAwayFromZeroScalar](#49-roundawayfromzeroscalar), [RoundToNearest](#50-roundtonearest), [RoundToNearestScalar](#51-roundtonearestscalar), [RoundToNegativeInfinity](#52-roundtonegativeinfinity), [RoundToNegativeInfinityScalar](#53-roundtonegativeinfinityscalar), [RoundToPositiveInfinity](#54-roundtopositiveinfinity), [RoundToPositiveInfinityScalar](#55-roundtopositiveinfinityscalar), [RoundToZero](#56-roundtozero), [RoundToZeroScalar](#57-roundtozeroscalar), [ShiftArithmetic](#58-shiftarithmetic), [ShiftArithmeticRounded](#59-shiftarithmeticrounded), [ShiftArithmeticRoundedSaturate](#60-shiftarithmeticroundedsaturate),[...](Part3.md)


");

try {
var MultiplyDoublingWideningLowerByScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerByScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"


### 1. MultiplyDoublingWideningLowerByScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningLowerByScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningLowerByScalarAndAddSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndAddSaturate(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerByScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyscalarandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningLowerByScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningLowerByScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningLowerByScalarAndAddSaturate' operation", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerByScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningLowerByScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 2. MultiplyDoublingWideningLowerByScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningLowerByScalarAndSubtractSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningLowerByScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyscalarandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningLowerByScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningLowerByScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningLowerByScalarAndSubtractSaturate' operation", Vector128int_0, Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 3. MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyselectedscalarandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningLowerBySelectedScalarAndAddSaturate' operation", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 4. MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideninglowerbyselectedscalarandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningLowerBySelectedScalarAndSubtractSaturate' operation", Vector128int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateLowerResult = Dummy_MultiplyDoublingWideningSaturateLowerTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 5. MultiplyDoublingWideningSaturateLower

`Vector128<int> MultiplyDoublingWideningSaturateLower(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningSaturateLower' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateLowerTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateLower(Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturatelower?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningSaturateLowerTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateLower", "Performs 'MultiplyDoublingWideningSaturateLower' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateLowerByScalarResult = Dummy_MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningSaturateLowerByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 6. MultiplyDoublingWideningSaturateLowerByScalar

`Vector128<int> MultiplyDoublingWideningSaturateLowerByScalar(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningSaturateLowerByScalar' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerByScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateLowerByScalar(Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturatelowerbyscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningSaturateLowerByScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateLowerByScalar", "Performs 'MultiplyDoublingWideningSaturateLowerByScalar' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateLowerBySelectedScalarResult = Dummy_MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningSaturateLowerBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 7. MultiplyDoublingWideningSaturateLowerBySelectedScalar

`Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningSaturateLowerBySelectedScalar' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateLowerBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateLowerBySelectedScalar(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturatelowerbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingWideningSaturateLowerBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateLowerBySelectedScalar", "Performs 'MultiplyDoublingWideningSaturateLowerBySelectedScalar' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateUpperResult = Dummy_MultiplyDoublingWideningSaturateUpperTest(Vector128short_0, Vector128short_1);
apiResult = MultiplyDoublingWideningSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 8. MultiplyDoublingWideningSaturateUpper

`Vector128<int> MultiplyDoublingWideningSaturateUpper(Vector128<short> left, Vector128<short> right)`

Performs 'MultiplyDoublingWideningSaturateUpper' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateUpperTest(Vector128<short> left, Vector128<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateUpper(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateUpper(Vector128<int> left, Vector128<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturateupper?view=net-5.0).

Assembly generated:

```
", Vector128short_0, Vector128short_1, apiResult);

try {
MultiplyDoublingWideningSaturateUpperTest(Vector128short_0, Vector128short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateUpper", "Performs 'MultiplyDoublingWideningSaturateUpper' operation", Vector128short_0, Vector128short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateUpperByScalarResult = Dummy_MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128short_0, Vector64short_0);
apiResult = MultiplyDoublingWideningSaturateUpperByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 9. MultiplyDoublingWideningSaturateUpperByScalar

`Vector128<int> MultiplyDoublingWideningSaturateUpperByScalar(Vector128<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningSaturateUpperByScalar' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperByScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningSaturateUpperByScalar(Vector128<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturateupperbyscalar?view=net-5.0).

Assembly generated:

```
", Vector128short_0, Vector64short_0, apiResult);

try {
MultiplyDoublingWideningSaturateUpperByScalarTest(Vector128short_0, Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateUpperByScalar", "Performs 'MultiplyDoublingWideningSaturateUpperByScalar' operation", Vector128short_0, Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateUpperBySelectedScalarResult = Dummy_MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyDoublingWideningSaturateUpperBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 10. MultiplyDoublingWideningSaturateUpperBySelectedScalar

`Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningSaturateUpperBySelectedScalar' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningSaturateUpperBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningSaturateUpperBySelectedScalar(Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningsaturateupperbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector128short_0, Vector64short_0, byte_0, apiResult);

try {
MultiplyDoublingWideningSaturateUpperBySelectedScalarTest(Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateUpperBySelectedScalar", "Performs 'MultiplyDoublingWideningSaturateUpperBySelectedScalar' operation", Vector128short_0, Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperAndAddSaturateResult = Dummy_MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);
apiResult = MultiplyDoublingWideningUpperAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 11. MultiplyDoublingWideningUpperAndAddSaturate

`Vector128<int> MultiplyDoublingWideningUpperAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right)`

Performs 'MultiplyDoublingWideningUpperAndAddSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperAndAddSaturate(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector128<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector128short_1, apiResult);

try {
MultiplyDoublingWideningUpperAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningUpperAndAddSaturate", "Performs 'MultiplyDoublingWideningUpperAndAddSaturate' operation", Vector128int_0, Vector128short_0, Vector128short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);
apiResult = MultiplyDoublingWideningUpperAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 12. MultiplyDoublingWideningUpperAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningUpperAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)`

Performs 'MultiplyDoublingWideningUpperAndSubtractSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector128<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperAndSubtractSaturate(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector128<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector128short_1, apiResult);

try {
MultiplyDoublingWideningUpperAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector128short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningUpperAndSubtractSaturate", "Performs 'MultiplyDoublingWideningUpperAndSubtractSaturate' operation", Vector128int_0, Vector128short_0, Vector128short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperByScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);
apiResult = MultiplyDoublingWideningUpperByScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 13. MultiplyDoublingWideningUpperByScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningUpperByScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningUpperByScalarAndAddSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndAddSaturate(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperByScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyscalarandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector64short_0, apiResult);

try {
MultiplyDoublingWideningUpperByScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningUpperByScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningUpperByScalarAndAddSaturate' operation", Vector128int_0, Vector128short_0, Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperByScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);
apiResult = MultiplyDoublingWideningUpperByScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 14. MultiplyDoublingWideningUpperByScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningUpperByScalarAndSubtractSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> MultiplyDoublingWideningUpperByScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyscalarandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector64short_0, apiResult);

try {
MultiplyDoublingWideningUpperByScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningUpperByScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningUpperByScalarAndSubtractSaturate' operation", Vector128int_0, Vector128short_0, Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 15. MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate

`Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128<int> addend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate(Vector128<long> addend, Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyselectedscalarandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);

try {
MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningUpperBySelectedScalarAndAddSaturate' operation", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);
apiResult = MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 16. MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate

`Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate' operation.

```csharp
private Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128<int> minuend, Vector128<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<int> minuend, Vector128<short> left, Vector128<short> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector64<int> right, byte rightIndex)
Vector128<long> MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate(Vector128<long> minuend, Vector128<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplydoublingwideningupperbyselectedscalarandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);

try {
MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturateTest(Vector128int_0, Vector128short_0, Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningUpperBySelectedScalarAndSubtractSaturate' operation", Vector128int_0, Vector128short_0, Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingByScalarSaturateHighResult = Dummy_MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyRoundedDoublingByScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 17. MultiplyRoundedDoublingByScalarSaturateHigh

`Vector64<short> MultiplyRoundedDoublingByScalarSaturateHigh(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyRoundedDoublingByScalarSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyRoundedDoublingByScalarSaturateHigh(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyRoundedDoublingByScalarSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyRoundedDoublingByScalarSaturateHigh(Vector128<short> left, Vector64<short> right)
Vector128<int> MultiplyRoundedDoublingByScalarSaturateHigh(Vector128<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyroundeddoublingbyscalarsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyRoundedDoublingByScalarSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyRoundedDoublingByScalarSaturateHigh", "Performs 'MultiplyRoundedDoublingByScalarSaturateHigh' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingBySelectedScalarSaturateHighResult = Dummy_MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyRoundedDoublingBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 18. MultiplyRoundedDoublingBySelectedScalarSaturateHigh

`Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyRoundedDoublingBySelectedScalarSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplyRoundedDoublingBySelectedScalarSaturateHigh(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyroundeddoublingbyselectedscalarsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyRoundedDoublingBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyRoundedDoublingBySelectedScalarSaturateHigh", "Performs 'MultiplyRoundedDoublingBySelectedScalarSaturateHigh' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingSaturateHighResult = Dummy_MultiplyRoundedDoublingSaturateHighTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyRoundedDoublingSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 19. MultiplyRoundedDoublingSaturateHigh

`Vector64<short> MultiplyRoundedDoublingSaturateHigh(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyRoundedDoublingSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyRoundedDoublingSaturateHighTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplyRoundedDoublingSaturateHigh(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> MultiplyRoundedDoublingSaturateHigh(Vector64<int> left, Vector64<int> right)
Vector128<short> MultiplyRoundedDoublingSaturateHigh(Vector128<short> left, Vector128<short> right)
Vector128<int> MultiplyRoundedDoublingSaturateHigh(Vector128<int> left, Vector128<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyroundeddoublingsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyRoundedDoublingSaturateHighTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyRoundedDoublingSaturateHigh", "Performs 'MultiplyRoundedDoublingSaturateHigh' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyScalarResult = Dummy_MultiplyScalarTest(Vector64double_0, Vector64double_1);
apiResult = MultiplyScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 20. MultiplyScalar

`Vector64<double> MultiplyScalar(Vector64<double> left, Vector64<double> right)`

Performs 'MultiplyScalar' operation.

```csharp
private Vector64<double> MultiplyScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.MultiplyScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MultiplyScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
MultiplyScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyScalar", "Performs 'MultiplyScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyScalarBySelectedScalarResult = Dummy_MultiplyScalarBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);
apiResult = MultiplyScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 21. MultiplyScalarBySelectedScalar

`Vector64<float> MultiplyScalarBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)`

Performs 'MultiplyScalarBySelectedScalar' operation.

```csharp
private Vector64<float> MultiplyScalarBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.MultiplyScalarBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> MultiplyScalarBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MultiplyScalarBySelectedScalar(Vector64<double> left, Vector128<double> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplyscalarbyselectedscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyscalarbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, byte_0, apiResult);

try {
MultiplyScalarBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyScalarBySelectedScalar", "Performs 'MultiplyScalarBySelectedScalar' operation", Vector64float_0, Vector64float_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplySubtractResult = Dummy_MultiplySubtractTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);
apiResult = MultiplySubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 22. MultiplySubtract

`Vector64<byte> MultiplySubtract(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)`

Performs 'MultiplySubtract' operation.

```csharp
private Vector64<byte> MultiplySubtractTest(Vector64<byte> minuend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplySubtract(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplysubtract?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);

try {
MultiplySubtractTest(Vector64byte_0, Vector64byte_1, Vector64byte_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplySubtract", "Performs 'MultiplySubtract' operation", Vector64byte_0, Vector64byte_1, Vector64byte_2, apiResult);
// ----------------------------------------------------------------

try {
var MultiplySubtractByScalarResult = Dummy_MultiplySubtractByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);
apiResult = MultiplySubtractByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 23. MultiplySubtractByScalar

`Vector64<short> MultiplySubtractByScalar(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplySubtractByScalar' operation.

```csharp
private Vector64<short> MultiplySubtractByScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.MultiplySubtractByScalar(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplysubtractbyscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, Vector64short_2, apiResult);

try {
MultiplySubtractByScalarTest(Vector64short_0, Vector64short_1, Vector64short_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplySubtractByScalar", "Performs 'MultiplySubtractByScalar' operation", Vector64short_0, Vector64short_1, Vector64short_2, apiResult);
// ----------------------------------------------------------------

try {
var MultiplySubtractBySelectedScalarResult = Dummy_MultiplySubtractBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);
apiResult = MultiplySubtractBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 24. MultiplySubtractBySelectedScalar

`Vector64<short> MultiplySubtractBySelectedScalar(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplySubtractBySelectedScalar' operation.

```csharp
private Vector64<short> MultiplySubtractBySelectedScalarTest(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.MultiplySubtractBySelectedScalar(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplysubtractbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, Vector64short_2, byte_0, apiResult);

try {
MultiplySubtractBySelectedScalarTest(Vector64short_0, Vector64short_1, Vector64short_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplySubtractBySelectedScalar", "Performs 'MultiplySubtractBySelectedScalar' operation", Vector64short_0, Vector64short_1, Vector64short_2, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyWideningLowerResult = Dummy_MultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = MultiplyWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 25. MultiplyWideningLower

`Vector128<ushort> MultiplyWideningLower(Vector64<byte> left, Vector64<byte> right)`

Performs 'MultiplyWideningLower' operation.

```csharp
private Vector128<ushort> MultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyWideningLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
MultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyWideningLower", "Performs 'MultiplyWideningLower' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyWideningLowerAndAddResult = Dummy_MultiplyWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);
apiResult = MultiplyWideningLowerAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 26. MultiplyWideningLowerAndAdd

`Vector128<ushort> MultiplyWideningLowerAndAdd(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)`

Performs 'MultiplyWideningLowerAndAdd' operation.

```csharp
private Vector128<ushort> MultiplyWideningLowerAndAddTest(Vector128<ushort> addend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyWideningLowerAndAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideninglowerandadd?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector64byte_0, Vector64byte_1, apiResult);

try {
MultiplyWideningLowerAndAddTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyWideningLowerAndAdd", "Performs 'MultiplyWideningLowerAndAdd' operation", Vector128ushort_0, Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyWideningLowerAndSubtractResult = Dummy_MultiplyWideningLowerAndSubtractTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);
apiResult = MultiplyWideningLowerAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 27. MultiplyWideningLowerAndSubtract

`Vector128<ushort> MultiplyWideningLowerAndSubtract(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)`

Performs 'MultiplyWideningLowerAndSubtract' operation.

```csharp
private Vector128<ushort> MultiplyWideningLowerAndSubtractTest(Vector128<ushort> minuend, Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.MultiplyWideningLowerAndSubtract(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideninglowerandsubtract?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector64byte_0, Vector64byte_1, apiResult);

try {
MultiplyWideningLowerAndSubtractTest(Vector128ushort_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyWideningLowerAndSubtract", "Performs 'MultiplyWideningLowerAndSubtract' operation", Vector128ushort_0, Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyWideningUpperResult = Dummy_MultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = MultiplyWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 28. MultiplyWideningUpper

`Vector128<ushort> MultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)`

Performs 'MultiplyWideningUpper' operation.

```csharp
private Vector128<ushort> MultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.MultiplyWideningUpper(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector128byte_1, apiResult);

try {
MultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyWideningUpper", "Performs 'MultiplyWideningUpper' operation", Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyWideningUpperAndAddResult = Dummy_MultiplyWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);
apiResult = MultiplyWideningUpperAndAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 29. MultiplyWideningUpperAndAdd

`Vector128<ushort> MultiplyWideningUpperAndAdd(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)`

Performs 'MultiplyWideningUpperAndAdd' operation.

```csharp
private Vector128<ushort> MultiplyWideningUpperAndAddTest(Vector128<ushort> addend, Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.MultiplyWideningUpperAndAdd(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideningupperandadd?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128byte_0, Vector128byte_1, apiResult);

try {
MultiplyWideningUpperAndAddTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyWideningUpperAndAdd", "Performs 'MultiplyWideningUpperAndAdd' operation", Vector128ushort_0, Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyWideningUpperAndSubtractResult = Dummy_MultiplyWideningUpperAndSubtractTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);
apiResult = MultiplyWideningUpperAndSubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 30. MultiplyWideningUpperAndSubtract

`Vector128<ushort> MultiplyWideningUpperAndSubtract(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)`

Performs 'MultiplyWideningUpperAndSubtract' operation.

```csharp
private Vector128<ushort> MultiplyWideningUpperAndSubtractTest(Vector128<ushort> minuend, Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.MultiplyWideningUpperAndSubtract(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.multiplywideningupperandsubtract?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128byte_0, Vector128byte_1, apiResult);

try {
MultiplyWideningUpperAndSubtractTest(Vector128ushort_0, Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyWideningUpperAndSubtract", "Performs 'MultiplyWideningUpperAndSubtract' operation", Vector128ushort_0, Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var NegateResult = Dummy_NegateTest(Vector64short_0);
apiResult = NegateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 31. Negate

`Vector64<short> Negate(Vector64<short> value)`

Performs 'Negate' operation.

```csharp
private Vector64<short> NegateTest(Vector64<short> value)
{{
  return AdvSimd.Negate(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.negate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negate?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
NegateTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Negate", "Performs 'Negate' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var NegateSaturateResult = Dummy_NegateSaturateTest(Vector64short_0);
apiResult = NegateSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 32. NegateSaturate

`Vector64<short> NegateSaturate(Vector64<short> value)`

Performs 'NegateSaturate' operation.

```csharp
private Vector64<short> NegateSaturateTest(Vector64<short> value)
{{
  return AdvSimd.NegateSaturate(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.negatesaturate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negatesaturate?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
NegateSaturateTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("NegateSaturate", "Performs 'NegateSaturate' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var NegateScalarResult = Dummy_NegateScalarTest(Vector64double_0);
apiResult = NegateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 33. NegateScalar

`Vector64<double> NegateScalar(Vector64<double> value)`

Performs 'NegateScalar' operation.

```csharp
private Vector64<double> NegateScalarTest(Vector64<double> value)
{{
  return AdvSimd.NegateScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> NegateScalar(Vector64<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> NegateScalar(Vector64<long> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.negatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negatescalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
NegateScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("NegateScalar", "Performs 'NegateScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var NotResult = Dummy_NotTest(Vector64byte_0);
apiResult = NotResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 34. Not

`Vector64<byte> Not(Vector64<byte> value)`

Performs 'Not' operation.

```csharp
private Vector64<byte> NotTest(Vector64<byte> value)
{{
  return AdvSimd.Not(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.not?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
NotTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Not", "Performs 'Not' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var OrResult = Dummy_OrTest(Vector64byte_0, Vector64byte_1);
apiResult = OrResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 35. Or

`Vector64<byte> Or(Vector64<byte> left, Vector64<byte> right)`

Performs 'Or' operation.

```csharp
private Vector64<byte> OrTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Or(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.or?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
OrTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Or", "Performs 'Or' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var OrNotResult = Dummy_OrNotTest(Vector64byte_0, Vector64byte_1);
apiResult = OrNotResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 36. OrNot

`Vector64<byte> OrNot(Vector64<byte> left, Vector64<byte> right)`

Performs 'OrNot' operation.

```csharp
private Vector64<byte> OrNotTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.OrNot(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.ornot?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
OrNotTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("OrNot", "Performs 'OrNot' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var PolynomialMultiplyResult = Dummy_PolynomialMultiplyTest(Vector64byte_0, Vector64byte_1);
apiResult = PolynomialMultiplyResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 37. PolynomialMultiply

`Vector64<byte> PolynomialMultiply(Vector64<byte> left, Vector64<byte> right)`

Performs 'PolynomialMultiply' operation.

```csharp
private Vector64<byte> PolynomialMultiplyTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.PolynomialMultiply(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> PolynomialMultiply(Vector64<sbyte> left, Vector64<sbyte> right)
Vector128<byte> PolynomialMultiply(Vector128<byte> left, Vector128<byte> right)
Vector128<sbyte> PolynomialMultiply(Vector128<sbyte> left, Vector128<sbyte> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.polynomialmultiply?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
PolynomialMultiplyTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("PolynomialMultiply", "Performs 'PolynomialMultiply' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var PolynomialMultiplyWideningLowerResult = Dummy_PolynomialMultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = PolynomialMultiplyWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 38. PolynomialMultiplyWideningLower

`Vector128<ushort> PolynomialMultiplyWideningLower(Vector64<byte> left, Vector64<byte> right)`

Performs 'PolynomialMultiplyWideningLower' operation.

```csharp
private Vector128<ushort> PolynomialMultiplyWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.PolynomialMultiplyWideningLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> PolynomialMultiplyWideningLower(Vector64<sbyte> left, Vector64<sbyte> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.polynomialmultiplywideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
PolynomialMultiplyWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("PolynomialMultiplyWideningLower", "Performs 'PolynomialMultiplyWideningLower' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var PolynomialMultiplyWideningUpperResult = Dummy_PolynomialMultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = PolynomialMultiplyWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 39. PolynomialMultiplyWideningUpper

`Vector128<ushort> PolynomialMultiplyWideningUpper(Vector128<byte> left, Vector128<byte> right)`

Performs 'PolynomialMultiplyWideningUpper' operation.

```csharp
private Vector128<ushort> PolynomialMultiplyWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.PolynomialMultiplyWideningUpper(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<short> PolynomialMultiplyWideningUpper(Vector128<sbyte> left, Vector128<sbyte> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.polynomialmultiplywideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector128byte_1, apiResult);

try {
PolynomialMultiplyWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("PolynomialMultiplyWideningUpper", "Performs 'PolynomialMultiplyWideningUpper' operation", Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var PopCountResult = Dummy_PopCountTest(Vector64byte_0);
apiResult = PopCountResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 40. PopCount

`Vector64<byte> PopCount(Vector64<byte> value)`

Performs 'PopCount' operation.

```csharp
private Vector64<byte> PopCountTest(Vector64<byte> value)
{{
  return AdvSimd.PopCount(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> PopCount(Vector64<sbyte> value)
Vector128<byte> PopCount(Vector128<byte> value)
Vector128<sbyte> PopCount(Vector128<sbyte> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.popcount?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
PopCountTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("PopCount", "Performs 'PopCount' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalEstimateResult = Dummy_ReciprocalEstimateTest(Vector64float_0);
apiResult = ReciprocalEstimateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 41. ReciprocalEstimate

`Vector64<float> ReciprocalEstimate(Vector64<float> value)`

Performs 'ReciprocalEstimate' operation.

```csharp
private Vector64<float> ReciprocalEstimateTest(Vector64<float> value)
{{
  return AdvSimd.ReciprocalEstimate(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalestimate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalestimate?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ReciprocalEstimateTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalEstimate", "Performs 'ReciprocalEstimate' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalSquareRootEstimateResult = Dummy_ReciprocalSquareRootEstimateTest(Vector64float_0);
apiResult = ReciprocalSquareRootEstimateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 42. ReciprocalSquareRootEstimate

`Vector64<float> ReciprocalSquareRootEstimate(Vector64<float> value)`

Performs 'ReciprocalSquareRootEstimate' operation.

```csharp
private Vector64<float> ReciprocalSquareRootEstimateTest(Vector64<float> value)
{{
  return AdvSimd.ReciprocalSquareRootEstimate(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalsquarerootestimate?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootestimate?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ReciprocalSquareRootEstimateTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalSquareRootEstimate", "Performs 'ReciprocalSquareRootEstimate' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalSquareRootStepResult = Dummy_ReciprocalSquareRootStepTest(Vector64float_0, Vector64float_1);
apiResult = ReciprocalSquareRootStepResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 43. ReciprocalSquareRootStep

`Vector64<float> ReciprocalSquareRootStep(Vector64<float> left, Vector64<float> right)`

Performs 'ReciprocalSquareRootStep' operation.

```csharp
private Vector64<float> ReciprocalSquareRootStepTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.ReciprocalSquareRootStep(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> ReciprocalSquareRootStep(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ReciprocalSquareRootStep(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalsquarerootstep?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootstep?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
ReciprocalSquareRootStepTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalSquareRootStep", "Performs 'ReciprocalSquareRootStep' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalStepResult = Dummy_ReciprocalStepTest(Vector64float_0, Vector64float_1);
apiResult = ReciprocalStepResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 44. ReciprocalStep

`Vector64<float> ReciprocalStep(Vector64<float> left, Vector64<float> right)`

Performs 'ReciprocalStep' operation.

```csharp
private Vector64<float> ReciprocalStepTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.ReciprocalStep(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> ReciprocalStep(Vector128<float> left, Vector128<float> right)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ReciprocalStep(Vector128<double> left, Vector128<double> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reciprocalstep?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalstep?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
ReciprocalStepTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalStep", "Performs 'ReciprocalStep' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var ReverseElement16Result = Dummy_ReverseElement16Test(Vector64int_0);
apiResult = ReverseElement16Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 45. ReverseElement16

`Vector64<int> ReverseElement16(Vector64<int> value)`

Performs 'ReverseElement16' operation.

```csharp
private Vector64<int> ReverseElement16Test(Vector64<int> value)
{{
  return AdvSimd.ReverseElement16(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reverseelement16?view=net-5.0).

Assembly generated:

```
", Vector64int_0, apiResult);

try {
ReverseElement16Test(Vector64int_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReverseElement16", "Performs 'ReverseElement16' operation", Vector64int_0, apiResult);
// ----------------------------------------------------------------

try {
var ReverseElement32Result = Dummy_ReverseElement32Test(Vector64long_0);
apiResult = ReverseElement32Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 46. ReverseElement32

`Vector64<long> ReverseElement32(Vector64<long> value)`

Performs 'ReverseElement32' operation.

```csharp
private Vector64<long> ReverseElement32Test(Vector64<long> value)
{{
  return AdvSimd.ReverseElement32(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ReverseElement32(Vector64<ulong> value)
Vector128<long> ReverseElement32(Vector128<long> value)
Vector128<ulong> ReverseElement32(Vector128<ulong> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reverseelement32?view=net-5.0).

Assembly generated:

```
", Vector64long_0, apiResult);

try {
ReverseElement32Test(Vector64long_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReverseElement32", "Performs 'ReverseElement32' operation", Vector64long_0, apiResult);
// ----------------------------------------------------------------

try {
var ReverseElement8Result = Dummy_ReverseElement8Test(Vector64short_0);
apiResult = ReverseElement8Result.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 47. ReverseElement8

`Vector64<short> ReverseElement8(Vector64<short> value)`

Performs 'ReverseElement8' operation.

```csharp
private Vector64<short> ReverseElement8Test(Vector64<short> value)
{{
  return AdvSimd.ReverseElement8(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.reverseelement8?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
ReverseElement8Test(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReverseElement8", "Performs 'ReverseElement8' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundAwayFromZeroResult = Dummy_RoundAwayFromZeroTest(Vector64float_0);
apiResult = RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 48. RoundAwayFromZero

`Vector64<float> RoundAwayFromZero(Vector64<float> value)`

Performs 'RoundAwayFromZero' operation.

```csharp
private Vector64<float> RoundAwayFromZeroTest(Vector64<float> value)
{{
  return AdvSimd.RoundAwayFromZero(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundAwayFromZero(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundAwayFromZero(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundawayfromzero?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundawayfromzero?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
RoundAwayFromZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundAwayFromZero", "Performs 'RoundAwayFromZero' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundAwayFromZeroScalarResult = Dummy_RoundAwayFromZeroScalarTest(Vector64double_0);
apiResult = RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 49. RoundAwayFromZeroScalar

`Vector64<double> RoundAwayFromZeroScalar(Vector64<double> value)`

Performs 'RoundAwayFromZeroScalar' operation.

```csharp
private Vector64<double> RoundAwayFromZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundAwayFromZeroScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundAwayFromZeroScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundawayfromzeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
RoundAwayFromZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundAwayFromZeroScalar", "Performs 'RoundAwayFromZeroScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToNearestResult = Dummy_RoundToNearestTest(Vector64float_0);
apiResult = RoundToNearestResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 50. RoundToNearest

`Vector64<float> RoundToNearest(Vector64<float> value)`

Performs 'RoundToNearest' operation.

```csharp
private Vector64<float> RoundToNearestTest(Vector64<float> value)
{{
  return AdvSimd.RoundToNearest(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToNearest(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToNearest(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonearest?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtonearest?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
RoundToNearestTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToNearest", "Performs 'RoundToNearest' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToNearestScalarResult = Dummy_RoundToNearestScalarTest(Vector64double_0);
apiResult = RoundToNearestScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 51. RoundToNearestScalar

`Vector64<double> RoundToNearestScalar(Vector64<double> value)`

Performs 'RoundToNearestScalar' operation.

```csharp
private Vector64<double> RoundToNearestScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToNearestScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToNearestScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonearestscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
RoundToNearestScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToNearestScalar", "Performs 'RoundToNearestScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToNegativeInfinityResult = Dummy_RoundToNegativeInfinityTest(Vector64float_0);
apiResult = RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 52. RoundToNegativeInfinity

`Vector64<float> RoundToNegativeInfinity(Vector64<float> value)`

Performs 'RoundToNegativeInfinity' operation.

```csharp
private Vector64<float> RoundToNegativeInfinityTest(Vector64<float> value)
{{
  return AdvSimd.RoundToNegativeInfinity(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToNegativeInfinity(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToNegativeInfinity(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonegativeinfinity?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtonegativeinfinity?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
RoundToNegativeInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToNegativeInfinity", "Performs 'RoundToNegativeInfinity' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToNegativeInfinityScalarResult = Dummy_RoundToNegativeInfinityScalarTest(Vector64double_0);
apiResult = RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 53. RoundToNegativeInfinityScalar

`Vector64<double> RoundToNegativeInfinityScalar(Vector64<double> value)`

Performs 'RoundToNegativeInfinityScalar' operation.

```csharp
private Vector64<double> RoundToNegativeInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToNegativeInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToNegativeInfinityScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtonegativeinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
RoundToNegativeInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToNegativeInfinityScalar", "Performs 'RoundToNegativeInfinityScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToPositiveInfinityResult = Dummy_RoundToPositiveInfinityTest(Vector64float_0);
apiResult = RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 54. RoundToPositiveInfinity

`Vector64<float> RoundToPositiveInfinity(Vector64<float> value)`

Performs 'RoundToPositiveInfinity' operation.

```csharp
private Vector64<float> RoundToPositiveInfinityTest(Vector64<float> value)
{{
  return AdvSimd.RoundToPositiveInfinity(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToPositiveInfinity(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToPositiveInfinity(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtopositiveinfinity?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtopositiveinfinity?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
RoundToPositiveInfinityTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToPositiveInfinity", "Performs 'RoundToPositiveInfinity' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToPositiveInfinityScalarResult = Dummy_RoundToPositiveInfinityScalarTest(Vector64double_0);
apiResult = RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 55. RoundToPositiveInfinityScalar

`Vector64<double> RoundToPositiveInfinityScalar(Vector64<double> value)`

Performs 'RoundToPositiveInfinityScalar' operation.

```csharp
private Vector64<double> RoundToPositiveInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToPositiveInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToPositiveInfinityScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtopositiveinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
RoundToPositiveInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToPositiveInfinityScalar", "Performs 'RoundToPositiveInfinityScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToZeroResult = Dummy_RoundToZeroTest(Vector64float_0);
apiResult = RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 56. RoundToZero

`Vector64<float> RoundToZero(Vector64<float> value)`

Performs 'RoundToZero' operation.

```csharp
private Vector64<float> RoundToZeroTest(Vector64<float> value)
{{
  return AdvSimd.RoundToZero(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<float> RoundToZero(Vector128<float> value)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> RoundToZero(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtozero?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.roundtozero?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
RoundToZeroTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToZero", "Performs 'RoundToZero' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var RoundToZeroScalarResult = Dummy_RoundToZeroScalarTest(Vector64double_0);
apiResult = RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 57. RoundToZeroScalar

`Vector64<double> RoundToZeroScalar(Vector64<double> value)`

Performs 'RoundToZeroScalar' operation.

```csharp
private Vector64<double> RoundToZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.RoundToZeroScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> RoundToZeroScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.roundtozeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
RoundToZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("RoundToZeroScalar", "Performs 'RoundToZeroScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticResult = Dummy_ShiftArithmeticTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 58. ShiftArithmetic

`Vector64<short> ShiftArithmetic(Vector64<short> value, Vector64<short> count)`

Performs 'ShiftArithmetic' operation.

```csharp
private Vector64<short> ShiftArithmeticTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmetic(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmetic?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
ShiftArithmeticTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmetic", "Performs 'ShiftArithmetic' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedResult = Dummy_ShiftArithmeticRoundedTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 59. ShiftArithmeticRounded

`Vector64<short> ShiftArithmeticRounded(Vector64<short> value, Vector64<short> count)`

Performs 'ShiftArithmeticRounded' operation.

```csharp
private Vector64<short> ShiftArithmeticRoundedTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmeticRounded(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticrounded?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
ShiftArithmeticRoundedTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticRounded", "Performs 'ShiftArithmeticRounded' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedSaturateResult = Dummy_ShiftArithmeticRoundedSaturateTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticRoundedSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 60. ShiftArithmeticRoundedSaturate

`Vector64<short> ShiftArithmeticRoundedSaturate(Vector64<short> value, Vector64<short> count)`

Performs 'ShiftArithmeticRoundedSaturate' operation.

```csharp
private Vector64<short> ShiftArithmeticRoundedSaturateTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmeticRoundedSaturate(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticroundedsaturate?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
ShiftArithmeticRoundedSaturateTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticRoundedSaturate", "Performs 'ShiftArithmeticRoundedSaturate' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: Hardware Intrinsics APIs for ARM64 - Part 4
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

[ShiftArithmeticRoundedSaturateScalar](#1-shiftarithmeticroundedsaturatescalar), [ShiftArithmeticRoundedScalar](#2-shiftarithmeticroundedscalar), [ShiftArithmeticSaturate](#3-shiftarithmeticsaturate), [ShiftArithmeticSaturateScalar](#4-shiftarithmeticsaturatescalar), [ShiftArithmeticScalar](#5-shiftarithmeticscalar), [ShiftLeftAndInsert](#6-shiftleftandinsert), [ShiftLeftAndInsertScalar](#7-shiftleftandinsertscalar), [ShiftLeftLogical](#8-shiftleftlogical), [ShiftLeftLogicalSaturate](#9-shiftleftlogicalsaturate), [ShiftLeftLogicalSaturateScalar](#10-shiftleftlogicalsaturatescalar), [ShiftLeftLogicalSaturateUnsigned](#11-shiftleftlogicalsaturateunsigned), [ShiftLeftLogicalSaturateUnsignedScalar](#12-shiftleftlogicalsaturateunsignedscalar), [ShiftLeftLogicalScalar](#13-shiftleftlogicalscalar), [ShiftLeftLogicalWideningLower](#14-shiftleftlogicalwideninglower), [ShiftLeftLogicalWideningUpper](#15-shiftleftlogicalwideningupper), [ShiftLogical](#16-shiftlogical), [ShiftLogicalRounded](#17-shiftlogicalrounded), [ShiftLogicalRoundedSaturate](#18-shiftlogicalroundedsaturate), [ShiftLogicalRoundedSaturateScalar](#19-shiftlogicalroundedsaturatescalar), [ShiftLogicalRoundedScalar](#20-shiftlogicalroundedscalar), [ShiftLogicalSaturate](#21-shiftlogicalsaturate), [ShiftLogicalSaturateScalar](#22-shiftlogicalsaturatescalar), [ShiftLogicalScalar](#23-shiftlogicalscalar), [ShiftRightAndInsert](#24-shiftrightandinsert), [ShiftRightAndInsertScalar](#25-shiftrightandinsertscalar), [ShiftRightArithmetic](#26-shiftrightarithmetic), [ShiftRightArithmeticAdd](#27-shiftrightarithmeticadd), [ShiftRightArithmeticAddScalar](#28-shiftrightarithmeticaddscalar), [ShiftRightArithmeticNarrowingSaturateLower](#29-shiftrightarithmeticnarrowingsaturatelower), [ShiftRightArithmeticNarrowingSaturateUnsignedLower](#30-shiftrightarithmeticnarrowingsaturateunsignedlower), [ShiftRightArithmeticNarrowingSaturateUnsignedUpper](#31-shiftrightarithmeticnarrowingsaturateunsignedupper), [ShiftRightArithmeticNarrowingSaturateUpper](#32-shiftrightarithmeticnarrowingsaturateupper), [ShiftRightArithmeticRounded](#33-shiftrightarithmeticrounded), [ShiftRightArithmeticRoundedAdd](#34-shiftrightarithmeticroundedadd), [ShiftRightArithmeticRoundedAddScalar](#35-shiftrightarithmeticroundedaddscalar), [ShiftRightArithmeticRoundedNarrowingSaturateLower](#36-shiftrightarithmeticroundednarrowingsaturatelower), [ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower](#37-shiftrightarithmeticroundednarrowingsaturateunsignedlower), [ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper](#38-shiftrightarithmeticroundednarrowingsaturateunsignedupper), [ShiftRightArithmeticRoundedNarrowingSaturateUpper](#39-shiftrightarithmeticroundednarrowingsaturateupper), [ShiftRightArithmeticRoundedScalar](#40-shiftrightarithmeticroundedscalar), [ShiftRightArithmeticScalar](#41-shiftrightarithmeticscalar), [ShiftRightLogical](#42-shiftrightlogical), [ShiftRightLogicalAdd](#43-shiftrightlogicaladd), [ShiftRightLogicalAddScalar](#44-shiftrightlogicaladdscalar), [ShiftRightLogicalNarrowingLower](#45-shiftrightlogicalnarrowinglower), [ShiftRightLogicalNarrowingSaturateLower](#46-shiftrightlogicalnarrowingsaturatelower), [ShiftRightLogicalNarrowingSaturateUpper](#47-shiftrightlogicalnarrowingsaturateupper), [ShiftRightLogicalNarrowingUpper](#48-shiftrightlogicalnarrowingupper), [ShiftRightLogicalRounded](#49-shiftrightlogicalrounded), [ShiftRightLogicalRoundedAdd](#50-shiftrightlogicalroundedadd), [ShiftRightLogicalRoundedAddScalar](#51-shiftrightlogicalroundedaddscalar), [ShiftRightLogicalRoundedNarrowingLower](#52-shiftrightlogicalroundednarrowinglower), [ShiftRightLogicalRoundedNarrowingSaturateLower](#53-shiftrightlogicalroundednarrowingsaturatelower), [ShiftRightLogicalRoundedNarrowingSaturateUpper](#54-shiftrightlogicalroundednarrowingsaturateupper), [ShiftRightLogicalRoundedNarrowingUpper](#55-shiftrightlogicalroundednarrowingupper), [ShiftRightLogicalRoundedScalar](#56-shiftrightlogicalroundedscalar), [ShiftRightLogicalScalar](#57-shiftrightlogicalscalar), [SignExtendWideningLower](#58-signextendwideninglower), [SignExtendWideningUpper](#59-signextendwideningupper), [SqrtScalar](#60-sqrtscalar),[...](Part4.md)


");

try {
var ShiftArithmeticRoundedSaturateScalarResult = Dummy_ShiftArithmeticRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticRoundedSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"


### 1. ShiftArithmeticRoundedSaturateScalar

`Vector64<long> ShiftArithmeticRoundedSaturateScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftArithmeticRoundedSaturateScalar' operation.

```csharp
private Vector64<long> ShiftArithmeticRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticRoundedSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp


// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ShiftArithmeticRoundedSaturateScalar(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftArithmeticRoundedSaturateScalar(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticRoundedSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticroundedsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftarithmeticroundedsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftArithmeticRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticRoundedSaturateScalar", "Performs 'ShiftArithmeticRoundedSaturateScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticRoundedScalarResult = Dummy_ShiftArithmeticRoundedScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 2. ShiftArithmeticRoundedScalar

`Vector64<long> ShiftArithmeticRoundedScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftArithmeticRoundedScalar' operation.

```csharp
private Vector64<long> ShiftArithmeticRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticRoundedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticroundedscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftArithmeticRoundedScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticRoundedScalar", "Performs 'ShiftArithmeticRoundedScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticSaturateResult = Dummy_ShiftArithmeticSaturateTest(Vector64short_0, Vector64short_1);
apiResult = ShiftArithmeticSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 3. ShiftArithmeticSaturate

`Vector64<short> ShiftArithmeticSaturate(Vector64<short> value, Vector64<short> count)`

Performs 'ShiftArithmeticSaturate' operation.

```csharp
private Vector64<short> ShiftArithmeticSaturateTest(Vector64<short> value, Vector64<short> count)
{{
  return AdvSimd.ShiftArithmeticSaturate(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticsaturate?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
ShiftArithmeticSaturateTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticSaturate", "Performs 'ShiftArithmeticSaturate' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticSaturateScalarResult = Dummy_ShiftArithmeticSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 4. ShiftArithmeticSaturateScalar

`Vector64<long> ShiftArithmeticSaturateScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftArithmeticSaturateScalar' operation.

```csharp
private Vector64<long> ShiftArithmeticSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp


// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> ShiftArithmeticSaturateScalar(Vector64<short> value, Vector64<short> count)
Vector64<int> ShiftArithmeticSaturateScalar(Vector64<int> value, Vector64<int> count)
Vector64<sbyte> ShiftArithmeticSaturateScalar(Vector64<sbyte> value, Vector64<sbyte> count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftarithmeticsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftArithmeticSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticSaturateScalar", "Performs 'ShiftArithmeticSaturateScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftArithmeticScalarResult = Dummy_ShiftArithmeticScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftArithmeticScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 5. ShiftArithmeticScalar

`Vector64<long> ShiftArithmeticScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftArithmeticScalar' operation.

```csharp
private Vector64<long> ShiftArithmeticScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftArithmeticScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftarithmeticscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftArithmeticScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftArithmeticScalar", "Performs 'ShiftArithmeticScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftAndInsertResult = Dummy_ShiftLeftAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftLeftAndInsertResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 6. ShiftLeftAndInsert

`Vector64<byte> ShiftLeftAndInsert(Vector64<byte> left, Vector64<byte> right, byte shift)`

Performs 'ShiftLeftAndInsert' operation.

```csharp
private Vector64<byte> ShiftLeftAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{{
  return AdvSimd.ShiftLeftAndInsert(left, right, shift);
}}
// left = {0}
// right = {1}
// shift = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftandinsert?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, byte_0, apiResult);

try {
ShiftLeftAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftAndInsert", "Performs 'ShiftLeftAndInsert' operation", Vector64byte_0, Vector64byte_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftAndInsertScalarResult = Dummy_ShiftLeftAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftLeftAndInsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 7. ShiftLeftAndInsertScalar

`Vector64<long> ShiftLeftAndInsertScalar(Vector64<long> left, Vector64<long> right, byte shift)`

Performs 'ShiftLeftAndInsertScalar' operation.

```csharp
private Vector64<long> ShiftLeftAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{{
  return AdvSimd.ShiftLeftAndInsertScalar(left, right, shift);
}}
// left = {0}
// right = {1}
// shift = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLeftAndInsertScalar(Vector64<ulong> left, Vector64<ulong> right, byte shift)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftandinsertscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, byte_0, apiResult);

try {
ShiftLeftAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftAndInsertScalar", "Performs 'ShiftLeftAndInsertScalar' operation", Vector64long_0, Vector64long_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalResult = Dummy_ShiftLeftLogicalTest(Vector64byte_0, byte_0);
apiResult = ShiftLeftLogicalResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 8. ShiftLeftLogical

`Vector64<byte> ShiftLeftLogical(Vector64<byte> value, byte count)`

Performs 'ShiftLeftLogical' operation.

```csharp
private Vector64<byte> ShiftLeftLogicalTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogical(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogical?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
ShiftLeftLogicalTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogical", "Performs 'ShiftLeftLogical' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateResult = Dummy_ShiftLeftLogicalSaturateTest(Vector64byte_0, byte_0);
apiResult = ShiftLeftLogicalSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 9. ShiftLeftLogicalSaturate

`Vector64<byte> ShiftLeftLogicalSaturate(Vector64<byte> value, byte count)`

Performs 'ShiftLeftLogicalSaturate' operation.

```csharp
private Vector64<byte> ShiftLeftLogicalSaturateTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturate(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturate?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
ShiftLeftLogicalSaturateTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalSaturate", "Performs 'ShiftLeftLogicalSaturate' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateScalarResult = Dummy_ShiftLeftLogicalSaturateScalarTest(Vector64long_0, byte_0);
apiResult = ShiftLeftLogicalSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 10. ShiftLeftLogicalSaturateScalar

`Vector64<long> ShiftLeftLogicalSaturateScalar(Vector64<long> value, byte count)`

Performs 'ShiftLeftLogicalSaturateScalar' operation.

```csharp
private Vector64<long> ShiftLeftLogicalSaturateScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftleftlogicalsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftLeftLogicalSaturateScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalSaturateScalar", "Performs 'ShiftLeftLogicalSaturateScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateUnsignedResult = Dummy_ShiftLeftLogicalSaturateUnsignedTest(Vector64short_0, byte_0);
apiResult = ShiftLeftLogicalSaturateUnsignedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 11. ShiftLeftLogicalSaturateUnsigned

`Vector64<ushort> ShiftLeftLogicalSaturateUnsigned(Vector64<short> value, byte count)`

Performs 'ShiftLeftLogicalSaturateUnsigned' operation.

```csharp
private Vector64<ushort> ShiftLeftLogicalSaturateUnsignedTest(Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturateUnsigned(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturateunsigned?view=net-5.0).

Assembly generated:

```
", Vector64short_0, byte_0, apiResult);

try {
ShiftLeftLogicalSaturateUnsignedTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalSaturateUnsigned", "Performs 'ShiftLeftLogicalSaturateUnsigned' operation", Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalSaturateUnsignedScalarResult = Dummy_ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64long_0, byte_0);
apiResult = ShiftLeftLogicalSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 12. ShiftLeftLogicalSaturateUnsignedScalar

`Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<long> value, byte count)`

Performs 'ShiftLeftLogicalSaturateUnsignedScalar' operation.

```csharp
private Vector64<ulong> ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalSaturateUnsignedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp


// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<short> value, byte count)
Vector64<uint> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<int> value, byte count)
Vector64<byte> ShiftLeftLogicalSaturateUnsignedScalar(Vector64<sbyte> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalsaturateunsignedscalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftleftlogicalsaturateunsignedscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftLeftLogicalSaturateUnsignedScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalSaturateUnsignedScalar", "Performs 'ShiftLeftLogicalSaturateUnsignedScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalScalarResult = Dummy_ShiftLeftLogicalScalarTest(Vector64long_0, byte_0);
apiResult = ShiftLeftLogicalScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 13. ShiftLeftLogicalScalar

`Vector64<long> ShiftLeftLogicalScalar(Vector64<long> value, byte count)`

Performs 'ShiftLeftLogicalScalar' operation.

```csharp
private Vector64<long> ShiftLeftLogicalScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLeftLogicalScalar(Vector64<ulong> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftLeftLogicalScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalScalar", "Performs 'ShiftLeftLogicalScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalWideningLowerResult = Dummy_ShiftLeftLogicalWideningLowerTest(Vector64byte_0, byte_0);
apiResult = ShiftLeftLogicalWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 14. ShiftLeftLogicalWideningLower

`Vector128<ushort> ShiftLeftLogicalWideningLower(Vector64<byte> value, byte count)`

Performs 'ShiftLeftLogicalWideningLower' operation.

```csharp
private Vector128<ushort> ShiftLeftLogicalWideningLowerTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalWideningLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalwideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
ShiftLeftLogicalWideningLowerTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalWideningLower", "Performs 'ShiftLeftLogicalWideningLower' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLeftLogicalWideningUpperResult = Dummy_ShiftLeftLogicalWideningUpperTest(Vector128byte_0, byte_0);
apiResult = ShiftLeftLogicalWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 15. ShiftLeftLogicalWideningUpper

`Vector128<ushort> ShiftLeftLogicalWideningUpper(Vector128<byte> value, byte count)`

Performs 'ShiftLeftLogicalWideningUpper' operation.

```csharp
private Vector128<ushort> ShiftLeftLogicalWideningUpperTest(Vector128<byte> value, byte count)
{{
  return AdvSimd.ShiftLeftLogicalWideningUpper(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftleftlogicalwideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, byte_0, apiResult);

try {
ShiftLeftLogicalWideningUpperTest(Vector128byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLeftLogicalWideningUpper", "Performs 'ShiftLeftLogicalWideningUpper' operation", Vector128byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalResult = Dummy_ShiftLogicalTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 16. ShiftLogical

`Vector64<byte> ShiftLogical(Vector64<byte> value, Vector64<sbyte> count)`

Performs 'ShiftLogical' operation.

```csharp
private Vector64<byte> ShiftLogicalTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogical(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogical?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64sbyte_0, apiResult);

try {
ShiftLogicalTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogical", "Performs 'ShiftLogical' operation", Vector64byte_0, Vector64sbyte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedResult = Dummy_ShiftLogicalRoundedTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 17. ShiftLogicalRounded

`Vector64<byte> ShiftLogicalRounded(Vector64<byte> value, Vector64<sbyte> count)`

Performs 'ShiftLogicalRounded' operation.

```csharp
private Vector64<byte> ShiftLogicalRoundedTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogicalRounded(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalrounded?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64sbyte_0, apiResult);

try {
ShiftLogicalRoundedTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalRounded", "Performs 'ShiftLogicalRounded' operation", Vector64byte_0, Vector64sbyte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedSaturateResult = Dummy_ShiftLogicalRoundedSaturateTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalRoundedSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 18. ShiftLogicalRoundedSaturate

`Vector64<byte> ShiftLogicalRoundedSaturate(Vector64<byte> value, Vector64<sbyte> count)`

Performs 'ShiftLogicalRoundedSaturate' operation.

```csharp
private Vector64<byte> ShiftLogicalRoundedSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogicalRoundedSaturate(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalroundedsaturate?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64sbyte_0, apiResult);

try {
ShiftLogicalRoundedSaturateTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalRoundedSaturate", "Performs 'ShiftLogicalRoundedSaturate' operation", Vector64byte_0, Vector64sbyte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedSaturateScalarResult = Dummy_ShiftLogicalRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalRoundedSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 19. ShiftLogicalRoundedSaturateScalar

`Vector64<long> ShiftLogicalRoundedSaturateScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftLogicalRoundedSaturateScalar' operation.

```csharp
private Vector64<long> ShiftLogicalRoundedSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalRoundedSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalroundedsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftlogicalroundedsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftLogicalRoundedSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalRoundedSaturateScalar", "Performs 'ShiftLogicalRoundedSaturateScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalRoundedScalarResult = Dummy_ShiftLogicalRoundedScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 20. ShiftLogicalRoundedScalar

`Vector64<long> ShiftLogicalRoundedScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftLogicalRoundedScalar' operation.

```csharp
private Vector64<long> ShiftLogicalRoundedScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalRoundedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLogicalRoundedScalar(Vector64<ulong> value, Vector64<long> count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalroundedscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftLogicalRoundedScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalRoundedScalar", "Performs 'ShiftLogicalRoundedScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalSaturateResult = Dummy_ShiftLogicalSaturateTest(Vector64byte_0, Vector64sbyte_0);
apiResult = ShiftLogicalSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 21. ShiftLogicalSaturate

`Vector64<byte> ShiftLogicalSaturate(Vector64<byte> value, Vector64<sbyte> count)`

Performs 'ShiftLogicalSaturate' operation.

```csharp
private Vector64<byte> ShiftLogicalSaturateTest(Vector64<byte> value, Vector64<sbyte> count)
{{
  return AdvSimd.ShiftLogicalSaturate(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalsaturate?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64sbyte_0, apiResult);

try {
ShiftLogicalSaturateTest(Vector64byte_0, Vector64sbyte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalSaturate", "Performs 'ShiftLogicalSaturate' operation", Vector64byte_0, Vector64sbyte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalSaturateScalarResult = Dummy_ShiftLogicalSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 22. ShiftLogicalSaturateScalar

`Vector64<long> ShiftLogicalSaturateScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftLogicalSaturateScalar' operation.

```csharp
private Vector64<long> ShiftLogicalSaturateScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftlogicalsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftLogicalSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalSaturateScalar", "Performs 'ShiftLogicalSaturateScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftLogicalScalarResult = Dummy_ShiftLogicalScalarTest(Vector64long_0, Vector64long_1);
apiResult = ShiftLogicalScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 23. ShiftLogicalScalar

`Vector64<long> ShiftLogicalScalar(Vector64<long> value, Vector64<long> count)`

Performs 'ShiftLogicalScalar' operation.

```csharp
private Vector64<long> ShiftLogicalScalarTest(Vector64<long> value, Vector64<long> count)
{{
  return AdvSimd.ShiftLogicalScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftLogicalScalar(Vector64<ulong> value, Vector64<long> count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftlogicalscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
ShiftLogicalScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftLogicalScalar", "Performs 'ShiftLogicalScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightAndInsertResult = Dummy_ShiftRightAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftRightAndInsertResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 24. ShiftRightAndInsert

`Vector64<byte> ShiftRightAndInsert(Vector64<byte> left, Vector64<byte> right, byte shift)`

Performs 'ShiftRightAndInsert' operation.

```csharp
private Vector64<byte> ShiftRightAndInsertTest(Vector64<byte> left, Vector64<byte> right, byte shift)
{{
  return AdvSimd.ShiftRightAndInsert(left, right, shift);
}}
// left = {0}
// right = {1}
// shift = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightandinsert?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, byte_0, apiResult);

try {
ShiftRightAndInsertTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightAndInsert", "Performs 'ShiftRightAndInsert' operation", Vector64byte_0, Vector64byte_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightAndInsertScalarResult = Dummy_ShiftRightAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightAndInsertScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 25. ShiftRightAndInsertScalar

`Vector64<long> ShiftRightAndInsertScalar(Vector64<long> left, Vector64<long> right, byte shift)`

Performs 'ShiftRightAndInsertScalar' operation.

```csharp
private Vector64<long> ShiftRightAndInsertScalarTest(Vector64<long> left, Vector64<long> right, byte shift)
{{
  return AdvSimd.ShiftRightAndInsertScalar(left, right, shift);
}}
// left = {0}
// right = {1}
// shift = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightAndInsertScalar(Vector64<ulong> left, Vector64<ulong> right, byte shift)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightandinsertscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, byte_0, apiResult);

try {
ShiftRightAndInsertScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightAndInsertScalar", "Performs 'ShiftRightAndInsertScalar' operation", Vector64long_0, Vector64long_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticResult = Dummy_ShiftRightArithmeticTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 26. ShiftRightArithmetic

`Vector64<short> ShiftRightArithmetic(Vector64<short> value, byte count)`

Performs 'ShiftRightArithmetic' operation.

```csharp
private Vector64<short> ShiftRightArithmeticTest(Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmetic(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmetic?view=net-5.0).

Assembly generated:

```
", Vector64short_0, byte_0, apiResult);

try {
ShiftRightArithmeticTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmetic", "Performs 'ShiftRightArithmetic' operation", Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticAddResult = Dummy_ShiftRightArithmeticAddTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = ShiftRightArithmeticAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 27. ShiftRightArithmeticAdd

`Vector64<short> ShiftRightArithmeticAdd(Vector64<short> addend, Vector64<short> value, byte count)`

Performs 'ShiftRightArithmeticAdd' operation.

```csharp
private Vector64<short> ShiftRightArithmeticAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticAdd(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticadd?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
ShiftRightArithmeticAddTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticAdd", "Performs 'ShiftRightArithmeticAdd' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticAddScalarResult = Dummy_ShiftRightArithmeticAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightArithmeticAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 28. ShiftRightArithmeticAddScalar

`Vector64<long> ShiftRightArithmeticAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

Performs 'ShiftRightArithmeticAddScalar' operation.

```csharp
private Vector64<long> ShiftRightArithmeticAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticAddScalar(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticaddscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, byte_0, apiResult);

try {
ShiftRightArithmeticAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticAddScalar", "Performs 'ShiftRightArithmeticAddScalar' operation", Vector64long_0, Vector64long_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateLowerResult = Dummy_ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 29. ShiftRightArithmeticNarrowingSaturateLower

`Vector64<short> ShiftRightArithmeticNarrowingSaturateLower(Vector128<int> value, byte count)`

Performs 'ShiftRightArithmeticNarrowingSaturateLower' operation.

```csharp
private Vector64<short> ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticNarrowingSaturateLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticNarrowingSaturateLower(Vector128<short> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturatelower?view=net-5.0).

Assembly generated:

```
", Vector128int_0, byte_0, apiResult);

try {
ShiftRightArithmeticNarrowingSaturateLowerTest(Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticNarrowingSaturateLower", "Performs 'ShiftRightArithmeticNarrowingSaturateLower' operation", Vector128int_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUnsignedLowerResult = Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUnsignedLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 30. ShiftRightArithmeticNarrowingSaturateUnsignedLower

`Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<short> value, byte count)`

Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedLower' operation.

```csharp
private Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<int> value, byte count)
Vector64<uint> ShiftRightArithmeticNarrowingSaturateUnsignedLower(Vector128<long> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturateunsignedlower?view=net-5.0).

Assembly generated:

```
", Vector128short_0, byte_0, apiResult);

try {
ShiftRightArithmeticNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticNarrowingSaturateUnsignedLower", "Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedLower' operation", Vector128short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUnsignedUpperResult = Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUnsignedUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 31. ShiftRightArithmeticNarrowingSaturateUnsignedUpper

`Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value, byte count)`

Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedUpper' operation.

```csharp
private Vector128<byte> ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUnsignedUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value, byte count)
Vector128<uint> ShiftRightArithmeticNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturateunsignedupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128short_0, byte_0, apiResult);

try {
ShiftRightArithmeticNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticNarrowingSaturateUnsignedUpper", "Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedUpper' operation", Vector64byte_0, Vector128short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUpperResult = Dummy_ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 32. ShiftRightArithmeticNarrowingSaturateUpper

`Vector128<short> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, byte count)`

Performs 'ShiftRightArithmeticNarrowingSaturateUpper' operation.

```csharp
private Vector128<short> ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticNarrowingSaturateUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticnarrowingsaturateupper?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector128int_0, byte_0, apiResult);

try {
ShiftRightArithmeticNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticNarrowingSaturateUpper", "Performs 'ShiftRightArithmeticNarrowingSaturateUpper' operation", Vector64short_0, Vector128int_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedResult = Dummy_ShiftRightArithmeticRoundedTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 33. ShiftRightArithmeticRounded

`Vector64<short> ShiftRightArithmeticRounded(Vector64<short> value, byte count)`

Performs 'ShiftRightArithmeticRounded' operation.

```csharp
private Vector64<short> ShiftRightArithmeticRoundedTest(Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRounded(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticrounded?view=net-5.0).

Assembly generated:

```
", Vector64short_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRounded", "Performs 'ShiftRightArithmeticRounded' operation", Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedAddResult = Dummy_ShiftRightArithmeticRoundedAddTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = ShiftRightArithmeticRoundedAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 34. ShiftRightArithmeticRoundedAdd

`Vector64<short> ShiftRightArithmeticRoundedAdd(Vector64<short> addend, Vector64<short> value, byte count)`

Performs 'ShiftRightArithmeticRoundedAdd' operation.

```csharp
private Vector64<short> ShiftRightArithmeticRoundedAddTest(Vector64<short> addend, Vector64<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedAdd(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundedadd?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedAddTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedAdd", "Performs 'ShiftRightArithmeticRoundedAdd' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedAddScalarResult = Dummy_ShiftRightArithmeticRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightArithmeticRoundedAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 35. ShiftRightArithmeticRoundedAddScalar

`Vector64<long> ShiftRightArithmeticRoundedAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

Performs 'ShiftRightArithmeticRoundedAddScalar' operation.

```csharp
private Vector64<long> ShiftRightArithmeticRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedAddScalar(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundedaddscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedAddScalar", "Performs 'ShiftRightArithmeticRoundedAddScalar' operation", Vector64long_0, Vector64long_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateLowerResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 36. ShiftRightArithmeticRoundedNarrowingSaturateLower

`Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<int> value, byte count)`

Performs 'ShiftRightArithmeticRoundedNarrowingSaturateLower' operation.

```csharp
private Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<int> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateLower(Vector128<short> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturatelower?view=net-5.0).

Assembly generated:

```
", Vector128int_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedNarrowingSaturateLowerTest(Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedNarrowingSaturateLower", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateLower' operation", Vector128int_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 37. ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower

`Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<short> value, byte count)`

Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower' operation.

```csharp
private Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<int> value, byte count)
Vector64<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower(Vector128<long> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturateunsignedlower?view=net-5.0).

Assembly generated:

```
", Vector128short_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLowerTest(Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedLower' operation", Vector128short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 38. ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper

`Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<byte> lower, Vector128<short> value, byte count)`

Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper' operation.

```csharp
private Vector128<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64<byte> lower, Vector128<short> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<ushort> lower, Vector128<int> value, byte count)
Vector128<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper(Vector64<uint> lower, Vector128<long> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturateunsignedupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128short_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpperTest(Vector64byte_0, Vector128short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedUpper' operation", Vector64byte_0, Vector128short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUpperResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 39. ShiftRightArithmeticRoundedNarrowingSaturateUpper

`Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<short> lower, Vector128<int> value, byte count)`

Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUpper' operation.

```csharp
private Vector128<short> ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64<short> lower, Vector128<int> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedNarrowingSaturateUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<int> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<int> lower, Vector128<long> value, byte count)
Vector128<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateUpper(Vector64<sbyte> lower, Vector128<short> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundednarrowingsaturateupper?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector128int_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedNarrowingSaturateUpperTest(Vector64short_0, Vector128int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedNarrowingSaturateUpper", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUpper' operation", Vector64short_0, Vector128int_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedScalarResult = Dummy_ShiftRightArithmeticRoundedScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightArithmeticRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 40. ShiftRightArithmeticRoundedScalar

`Vector64<long> ShiftRightArithmeticRoundedScalar(Vector64<long> value, byte count)`

Performs 'ShiftRightArithmeticRoundedScalar' operation.

```csharp
private Vector64<long> ShiftRightArithmeticRoundedScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticRoundedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticroundedscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedScalar", "Performs 'ShiftRightArithmeticRoundedScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticScalarResult = Dummy_ShiftRightArithmeticScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightArithmeticScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 41. ShiftRightArithmeticScalar

`Vector64<long> ShiftRightArithmeticScalar(Vector64<long> value, byte count)`

Performs 'ShiftRightArithmeticScalar' operation.

```csharp
private Vector64<long> ShiftRightArithmeticScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightArithmeticScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightarithmeticscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftRightArithmeticScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticScalar", "Performs 'ShiftRightArithmeticScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalResult = Dummy_ShiftRightLogicalTest(Vector64byte_0, byte_0);
apiResult = ShiftRightLogicalResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 42. ShiftRightLogical

`Vector64<byte> ShiftRightLogical(Vector64<byte> value, byte count)`

Performs 'ShiftRightLogical' operation.

```csharp
private Vector64<byte> ShiftRightLogicalTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogical(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogical?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
ShiftRightLogicalTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogical", "Performs 'ShiftRightLogical' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalAddResult = Dummy_ShiftRightLogicalAddTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftRightLogicalAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 43. ShiftRightLogicalAdd

`Vector64<byte> ShiftRightLogicalAdd(Vector64<byte> addend, Vector64<byte> value, byte count)`

Performs 'ShiftRightLogicalAdd' operation.

```csharp
private Vector64<byte> ShiftRightLogicalAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalAdd(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicaladd?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, byte_0, apiResult);

try {
ShiftRightLogicalAddTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalAdd", "Performs 'ShiftRightLogicalAdd' operation", Vector64byte_0, Vector64byte_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalAddScalarResult = Dummy_ShiftRightLogicalAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightLogicalAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 44. ShiftRightLogicalAddScalar

`Vector64<long> ShiftRightLogicalAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

Performs 'ShiftRightLogicalAddScalar' operation.

```csharp
private Vector64<long> ShiftRightLogicalAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalAddScalar(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalAddScalar(Vector64<ulong> addend, Vector64<ulong> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicaladdscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, byte_0, apiResult);

try {
ShiftRightLogicalAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalAddScalar", "Performs 'ShiftRightLogicalAddScalar' operation", Vector64long_0, Vector64long_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingLowerResult = Dummy_ShiftRightLogicalNarrowingLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 45. ShiftRightLogicalNarrowingLower

`Vector64<byte> ShiftRightLogicalNarrowingLower(Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalNarrowingLower' operation.

```csharp
private Vector64<byte> ShiftRightLogicalNarrowingLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalNarrowingLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalNarrowingLower", "Performs 'ShiftRightLogicalNarrowingLower' operation", Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingSaturateLowerResult = Dummy_ShiftRightLogicalNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 46. ShiftRightLogicalNarrowingSaturateLower

`Vector64<byte> ShiftRightLogicalNarrowingSaturateLower(Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalNarrowingSaturateLower' operation.

```csharp
private Vector64<byte> ShiftRightLogicalNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowingsaturatelower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalNarrowingSaturateLower", "Performs 'ShiftRightLogicalNarrowingSaturateLower' operation", Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingSaturateUpperResult = Dummy_ShiftRightLogicalNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 47. ShiftRightLogicalNarrowingSaturateUpper

`Vector128<byte> ShiftRightLogicalNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalNarrowingSaturateUpper' operation.

```csharp
private Vector128<byte> ShiftRightLogicalNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingSaturateUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowingsaturateupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalNarrowingSaturateUpper", "Performs 'ShiftRightLogicalNarrowingSaturateUpper' operation", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingUpperResult = Dummy_ShiftRightLogicalNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 48. ShiftRightLogicalNarrowingUpper

`Vector128<byte> ShiftRightLogicalNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalNarrowingUpper' operation.

```csharp
private Vector128<byte> ShiftRightLogicalNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalNarrowingUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalnarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalNarrowingUpper", "Performs 'ShiftRightLogicalNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedResult = Dummy_ShiftRightLogicalRoundedTest(Vector64byte_0, byte_0);
apiResult = ShiftRightLogicalRoundedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 49. ShiftRightLogicalRounded

`Vector64<byte> ShiftRightLogicalRounded(Vector64<byte> value, byte count)`

Performs 'ShiftRightLogicalRounded' operation.

```csharp
private Vector64<byte> ShiftRightLogicalRoundedTest(Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRounded(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalrounded?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedTest(Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRounded", "Performs 'ShiftRightLogicalRounded' operation", Vector64byte_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedAddResult = Dummy_ShiftRightLogicalRoundedAddTest(Vector64byte_0, Vector64byte_1, byte_0);
apiResult = ShiftRightLogicalRoundedAddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 50. ShiftRightLogicalRoundedAdd

`Vector64<byte> ShiftRightLogicalRoundedAdd(Vector64<byte> addend, Vector64<byte> value, byte count)`

Performs 'ShiftRightLogicalRoundedAdd' operation.

```csharp
private Vector64<byte> ShiftRightLogicalRoundedAddTest(Vector64<byte> addend, Vector64<byte> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedAdd(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundedadd?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, byte_0, apiResult);

try {
ShiftRightLogicalRoundedAddTest(Vector64byte_0, Vector64byte_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedAdd", "Performs 'ShiftRightLogicalRoundedAdd' operation", Vector64byte_0, Vector64byte_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedAddScalarResult = Dummy_ShiftRightLogicalRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);
apiResult = ShiftRightLogicalRoundedAddScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 51. ShiftRightLogicalRoundedAddScalar

`Vector64<long> ShiftRightLogicalRoundedAddScalar(Vector64<long> addend, Vector64<long> value, byte count)`

Performs 'ShiftRightLogicalRoundedAddScalar' operation.

```csharp
private Vector64<long> ShiftRightLogicalRoundedAddScalarTest(Vector64<long> addend, Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedAddScalar(addend, value, count);
}}
// addend = {0}
// value = {1}
// count = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalRoundedAddScalar(Vector64<ulong> addend, Vector64<ulong> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundedaddscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, byte_0, apiResult);

try {
ShiftRightLogicalRoundedAddScalarTest(Vector64long_0, Vector64long_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedAddScalar", "Performs 'ShiftRightLogicalRoundedAddScalar' operation", Vector64long_0, Vector64long_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingLowerResult = Dummy_ShiftRightLogicalRoundedNarrowingLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 52. ShiftRightLogicalRoundedNarrowingLower

`Vector64<byte> ShiftRightLogicalRoundedNarrowingLower(Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalRoundedNarrowingLower' operation.

```csharp
private Vector64<byte> ShiftRightLogicalRoundedNarrowingLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedNarrowingLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedNarrowingLower", "Performs 'ShiftRightLogicalRoundedNarrowingLower' operation", Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingSaturateLowerResult = Dummy_ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingSaturateLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 53. ShiftRightLogicalRoundedNarrowingSaturateLower

`Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLower(Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalRoundedNarrowingSaturateLower' operation.

```csharp
private Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateLower(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowingsaturatelower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedNarrowingSaturateLowerTest(Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedNarrowingSaturateLower", "Performs 'ShiftRightLogicalRoundedNarrowingSaturateLower' operation", Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingSaturateUpperResult = Dummy_ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingSaturateUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 54. ShiftRightLogicalRoundedNarrowingSaturateUpper

`Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalRoundedNarrowingSaturateUpper' operation.

```csharp
private Vector128<byte> ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingSaturateUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowingsaturateupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedNarrowingSaturateUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedNarrowingSaturateUpper", "Performs 'ShiftRightLogicalRoundedNarrowingSaturateUpper' operation", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingUpperResult = Dummy_ShiftRightLogicalRoundedNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 55. ShiftRightLogicalRoundedNarrowingUpper

`Vector128<byte> ShiftRightLogicalRoundedNarrowingUpper(Vector64<byte> lower, Vector128<ushort> value, byte count)`

Performs 'ShiftRightLogicalRoundedNarrowingUpper' operation.

```csharp
private Vector128<byte> ShiftRightLogicalRoundedNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedNarrowingUpper(lower, value, count);
}}
// lower = {0}
// value = {1}
// count = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundednarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedNarrowingUpper", "Performs 'ShiftRightLogicalRoundedNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedScalarResult = Dummy_ShiftRightLogicalRoundedScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightLogicalRoundedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 56. ShiftRightLogicalRoundedScalar

`Vector64<long> ShiftRightLogicalRoundedScalar(Vector64<long> value, byte count)`

Performs 'ShiftRightLogicalRoundedScalar' operation.

```csharp
private Vector64<long> ShiftRightLogicalRoundedScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalRoundedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalRoundedScalar(Vector64<ulong> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalroundedscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedScalar", "Performs 'ShiftRightLogicalRoundedScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalScalarResult = Dummy_ShiftRightLogicalScalarTest(Vector64long_0, byte_0);
apiResult = ShiftRightLogicalScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 57. ShiftRightLogicalScalar

`Vector64<long> ShiftRightLogicalScalar(Vector64<long> value, byte count)`

Performs 'ShiftRightLogicalScalar' operation.

```csharp
private Vector64<long> ShiftRightLogicalScalarTest(Vector64<long> value, byte count)
{{
  return AdvSimd.ShiftRightLogicalScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<ulong> ShiftRightLogicalScalar(Vector64<ulong> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.shiftrightlogicalscalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, byte_0, apiResult);

try {
ShiftRightLogicalScalarTest(Vector64long_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalScalar", "Performs 'ShiftRightLogicalScalar' operation", Vector64long_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var SignExtendWideningLowerResult = Dummy_SignExtendWideningLowerTest(Vector64short_0);
apiResult = SignExtendWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 58. SignExtendWideningLower

`Vector128<int> SignExtendWideningLower(Vector64<short> value)`

Performs 'SignExtendWideningLower' operation.

```csharp
private Vector128<int> SignExtendWideningLowerTest(Vector64<short> value)
{{
  return AdvSimd.SignExtendWideningLower(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> SignExtendWideningLower(Vector64<int> value)
Vector128<short> SignExtendWideningLower(Vector64<sbyte> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.signextendwideninglower?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
SignExtendWideningLowerTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SignExtendWideningLower", "Performs 'SignExtendWideningLower' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var SignExtendWideningUpperResult = Dummy_SignExtendWideningUpperTest(Vector128short_0);
apiResult = SignExtendWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 59. SignExtendWideningUpper

`Vector128<int> SignExtendWideningUpper(Vector128<short> value)`

Performs 'SignExtendWideningUpper' operation.

```csharp
private Vector128<int> SignExtendWideningUpperTest(Vector128<short> value)
{{
  return AdvSimd.SignExtendWideningUpper(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector128<long> SignExtendWideningUpper(Vector128<int> value)
Vector128<short> SignExtendWideningUpper(Vector128<sbyte> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.signextendwideningupper?view=net-5.0).

Assembly generated:

```
", Vector128short_0, apiResult);

try {
SignExtendWideningUpperTest(Vector128short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SignExtendWideningUpper", "Performs 'SignExtendWideningUpper' operation", Vector128short_0, apiResult);
// ----------------------------------------------------------------

try {
var SqrtScalarResult = Dummy_SqrtScalarTest(Vector64double_0);
apiResult = SqrtScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 60. SqrtScalar

`Vector64<double> SqrtScalar(Vector64<double> value)`

Performs 'SqrtScalar' operation.

```csharp
private Vector64<double> SqrtScalarTest(Vector64<double> value)
{{
  return AdvSimd.SqrtScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<float> SqrtScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.sqrtscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
SqrtScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SqrtScalar", "Performs 'SqrtScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: Hardware Intrinsics APIs for ARM64 - Part 5
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

[Store](#1-store), [StoreSelectedScalar](#2-storeselectedscalar), [Subtract](#3-subtract), [SubtractHighNarrowingLower](#4-subtracthighnarrowinglower), [SubtractHighNarrowingUpper](#5-subtracthighnarrowingupper), [SubtractRoundedHighNarrowingLower](#6-subtractroundedhighnarrowinglower), [SubtractRoundedHighNarrowingUpper](#7-subtractroundedhighnarrowingupper), [SubtractSaturate](#8-subtractsaturate), [SubtractSaturateScalar](#9-subtractsaturatescalar), [SubtractScalar](#10-subtractscalar), [SubtractWideningLower](#11-subtractwideninglower), [SubtractWideningUpper](#12-subtractwideningupper), [VectorTableLookup](#13-vectortablelookup), [VectorTableLookupExtension](#14-vectortablelookupextension), [Xor](#15-xor), [ZeroExtendWideningLower](#16-zeroextendwideninglower), [ZeroExtendWideningUpper](#17-zeroextendwideningupper), [AbsSaturateScalar](#18-abssaturatescalar), [AbsoluteCompareGreaterThanScalar](#19-absolutecomparegreaterthanscalar), [AbsoluteCompareGreaterThanOrEqualScalar](#20-absolutecomparegreaterthanorequalscalar), [AbsoluteCompareLessThanScalar](#21-absolutecomparelessthanscalar), [AbsoluteCompareLessThanOrEqualScalar](#22-absolutecomparelessthanorequalscalar), [AbsoluteDifferenceScalar](#23-absolutedifferencescalar), [AddAcross](#24-addacross), [AddAcrossWidening](#25-addacrosswidening), [AddPairwiseScalar](#26-addpairwisescalar), [CompareEqualScalar](#27-compareequalscalar), [CompareGreaterThanScalar](#28-comparegreaterthanscalar), [CompareGreaterThanOrEqualScalar](#29-comparegreaterthanorequalscalar), [CompareLessThanScalar](#30-comparelessthanscalar), [CompareLessThanOrEqualScalar](#31-comparelessthanorequalscalar), [CompareTestScalar](#32-comparetestscalar), [ConvertToDouble](#33-converttodouble), [ConvertToDoubleScalar](#34-converttodoublescalar), [ConvertToDoubleUpper](#35-converttodoubleupper), [ConvertToInt64RoundAwayFromZero](#36-converttoint64roundawayfromzero), [ConvertToInt64RoundAwayFromZeroScalar](#37-converttoint64roundawayfromzeroscalar), [ConvertToInt64RoundToEven](#38-converttoint64roundtoeven), [ConvertToInt64RoundToEvenScalar](#39-converttoint64roundtoevenscalar), [ConvertToInt64RoundToNegativeInfinity](#40-converttoint64roundtonegativeinfinity), [ConvertToInt64RoundToNegativeInfinityScalar](#41-converttoint64roundtonegativeinfinityscalar), [ConvertToInt64RoundToPositiveInfinity](#42-converttoint64roundtopositiveinfinity), [ConvertToInt64RoundToPositiveInfinityScalar](#43-converttoint64roundtopositiveinfinityscalar), [ConvertToInt64RoundToZero](#44-converttoint64roundtozero), [ConvertToInt64RoundToZeroScalar](#45-converttoint64roundtozeroscalar), [ConvertToSingleLower](#46-converttosinglelower), [ConvertToSingleRoundToOddLower](#47-converttosingleroundtooddlower), [ConvertToSingleRoundToOddUpper](#48-converttosingleroundtooddupper), [ConvertToSingleUpper](#49-converttosingleupper), [ConvertToUInt64RoundAwayFromZero](#50-converttouint64roundawayfromzero), [ConvertToUInt64RoundAwayFromZeroScalar](#51-converttouint64roundawayfromzeroscalar), [ConvertToUInt64RoundToEven](#52-converttouint64roundtoeven), [ConvertToUInt64RoundToEvenScalar](#53-converttouint64roundtoevenscalar), [ConvertToUInt64RoundToNegativeInfinity](#54-converttouint64roundtonegativeinfinity), [ConvertToUInt64RoundToNegativeInfinityScalar](#55-converttouint64roundtonegativeinfinityscalar), [ConvertToUInt64RoundToPositiveInfinity](#56-converttouint64roundtopositiveinfinity), [ConvertToUInt64RoundToPositiveInfinityScalar](#57-converttouint64roundtopositiveinfinityscalar), [ConvertToUInt64RoundToZero](#58-converttouint64roundtozero), [ConvertToUInt64RoundToZeroScalar](#59-converttouint64roundtozeroscalar), [Divide](#60-divide),[...](Part5.md)


");
fixed (byte* bytePtr_0 = byteArray)
{

try {
StoreTest(bytePtr_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"


### 1. Store

`void Store(byte* address, Vector64<byte> source)`

Performs 'Store' operation.

```csharp
private void StoreTest(byte* address, Vector64<byte> source)
{{
  AdvSimd.Store(address, source);
}}
// address = {0}
// source = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.store?view=net-5.0).

Assembly generated:

```
", "<address>", Vector64byte_0);

try {
StoreTest(bytePtr_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("Store", "Performs 'Store' operation", "<address>", Vector64byte_0);
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
StoreSelectedScalarTest(bytePtr_0, Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 2. StoreSelectedScalar

`void StoreSelectedScalar(byte* address, Vector64<byte> value, byte index)`

Performs 'StoreSelectedScalar' operation.

```csharp
private void StoreSelectedScalarTest(byte* address, Vector64<byte> value, byte index)
{{
  AdvSimd.StoreSelectedScalar(address, value, index);
}}
// address = {0}
// value = {1}
// index = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.storeselectedscalar?view=net-5.0).

Assembly generated:

```
", "<address>", Vector64byte_0, byte_0);

try {
StoreSelectedScalarTest(bytePtr_0, Vector64byte_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("StoreSelectedScalar", "Performs 'StoreSelectedScalar' operation", "<address>", Vector64byte_0, byte_0);
// ----------------------------------------------------------------

try {
var SubtractResult = Dummy_SubtractTest(Vector64byte_0, Vector64byte_1);
apiResult = SubtractResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 3. Subtract

`Vector64<byte> Subtract(Vector64<byte> left, Vector64<byte> right)`

Performs 'Subtract' operation.

```csharp
private Vector64<byte> SubtractTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Subtract(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtract?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.subtract?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
SubtractTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Subtract", "Performs 'Subtract' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractHighNarrowingLowerResult = Dummy_SubtractHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 4. SubtractHighNarrowingLower

`Vector64<byte> SubtractHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

Performs 'SubtractHighNarrowingLower' operation.

```csharp
private Vector64<byte> SubtractHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractHighNarrowingLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtracthighnarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128ushort_1, apiResult);

try {
SubtractHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractHighNarrowingLower", "Performs 'SubtractHighNarrowingLower' operation", Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractHighNarrowingUpperResult = Dummy_SubtractHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 5. SubtractHighNarrowingUpper

`Vector128<byte> SubtractHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

Performs 'SubtractHighNarrowingUpper' operation.

```csharp
private Vector128<byte> SubtractHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractHighNarrowingUpper(lower, left, right);
}}
// lower = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtracthighnarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);

try {
SubtractHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractHighNarrowingUpper", "Performs 'SubtractHighNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractRoundedHighNarrowingLowerResult = Dummy_SubtractRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractRoundedHighNarrowingLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 6. SubtractRoundedHighNarrowingLower

`Vector64<byte> SubtractRoundedHighNarrowingLower(Vector128<ushort> left, Vector128<ushort> right)`

Performs 'SubtractRoundedHighNarrowingLower' operation.

```csharp
private Vector64<byte> SubtractRoundedHighNarrowingLowerTest(Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractRoundedHighNarrowingLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractroundedhighnarrowinglower?view=net-5.0).

Assembly generated:

```
", Vector128ushort_0, Vector128ushort_1, apiResult);

try {
SubtractRoundedHighNarrowingLowerTest(Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractRoundedHighNarrowingLower", "Performs 'SubtractRoundedHighNarrowingLower' operation", Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractRoundedHighNarrowingUpperResult = Dummy_SubtractRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);
apiResult = SubtractRoundedHighNarrowingUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 7. SubtractRoundedHighNarrowingUpper

`Vector128<byte> SubtractRoundedHighNarrowingUpper(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)`

Performs 'SubtractRoundedHighNarrowingUpper' operation.

```csharp
private Vector128<byte> SubtractRoundedHighNarrowingUpperTest(Vector64<byte> lower, Vector128<ushort> left, Vector128<ushort> right)
{{
  return AdvSimd.SubtractRoundedHighNarrowingUpper(lower, left, right);
}}
// lower = {0}
// left = {1}
// right = {2}
// Result = {3}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractroundedhighnarrowingupper?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);

try {
SubtractRoundedHighNarrowingUpperTest(Vector64byte_0, Vector128ushort_0, Vector128ushort_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractRoundedHighNarrowingUpper", "Performs 'SubtractRoundedHighNarrowingUpper' operation", Vector64byte_0, Vector128ushort_0, Vector128ushort_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractSaturateResult = Dummy_SubtractSaturateTest(Vector64byte_0, Vector64byte_1);
apiResult = SubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 8. SubtractSaturate

`Vector64<byte> SubtractSaturate(Vector64<byte> left, Vector64<byte> right)`

Performs 'SubtractSaturate' operation.

```csharp
private Vector64<byte> SubtractSaturateTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.SubtractSaturate(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
SubtractSaturateTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractSaturate", "Performs 'SubtractSaturate' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractSaturateScalarResult = Dummy_SubtractSaturateScalarTest(Vector64long_0, Vector64long_1);
apiResult = SubtractSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 9. SubtractSaturateScalar

`Vector64<long> SubtractSaturateScalar(Vector64<long> left, Vector64<long> right)`

Performs 'SubtractSaturateScalar' operation.

```csharp
private Vector64<long> SubtractSaturateScalarTest(Vector64<long> left, Vector64<long> right)
{{
  return AdvSimd.SubtractSaturateScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractsaturatescalar?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.subtractsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, Vector64long_1, apiResult);

try {
SubtractSaturateScalarTest(Vector64long_0, Vector64long_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractSaturateScalar", "Performs 'SubtractSaturateScalar' operation", Vector64long_0, Vector64long_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractScalarResult = Dummy_SubtractScalarTest(Vector64double_0, Vector64double_1);
apiResult = SubtractScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 10. SubtractScalar

`Vector64<double> SubtractScalar(Vector64<double> left, Vector64<double> right)`

Performs 'SubtractScalar' operation.

```csharp
private Vector64<double> SubtractScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.SubtractScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<long> SubtractScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> SubtractScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> SubtractScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
SubtractScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractScalar", "Performs 'SubtractScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractWideningLowerResult = Dummy_SubtractWideningLowerTest(Vector64byte_0, Vector64byte_1);
apiResult = SubtractWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 11. SubtractWideningLower

`Vector128<ushort> SubtractWideningLower(Vector64<byte> left, Vector64<byte> right)`

Performs 'SubtractWideningLower' operation.

```csharp
private Vector128<ushort> SubtractWideningLowerTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.SubtractWideningLower(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractwideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
SubtractWideningLowerTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractWideningLower", "Performs 'SubtractWideningLower' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var SubtractWideningUpperResult = Dummy_SubtractWideningUpperTest(Vector128byte_0, Vector128byte_1);
apiResult = SubtractWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 12. SubtractWideningUpper

`Vector128<ushort> SubtractWideningUpper(Vector128<byte> left, Vector128<byte> right)`

Performs 'SubtractWideningUpper' operation.

```csharp
private Vector128<ushort> SubtractWideningUpperTest(Vector128<byte> left, Vector128<byte> right)
{{
  return AdvSimd.SubtractWideningUpper(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.subtractwideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector128byte_1, apiResult);

try {
SubtractWideningUpperTest(Vector128byte_0, Vector128byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("SubtractWideningUpper", "Performs 'SubtractWideningUpper' operation", Vector128byte_0, Vector128byte_1, apiResult);
// ----------------------------------------------------------------

try {
var VectorTableLookupResult = Dummy_VectorTableLookupTest(Vector128byte_0, Vector64byte_0);
apiResult = VectorTableLookupResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 13. VectorTableLookup

`Vector64<byte> VectorTableLookup(Vector128<byte> table, Vector64<byte> byteIndexes)`

Performs 'VectorTableLookup' operation.

```csharp
private Vector64<byte> VectorTableLookupTest(Vector128<byte> table, Vector64<byte> byteIndexes)
{{
  return AdvSimd.VectorTableLookup(table, byteIndexes);
}}
// table = {0}
// byteIndexes = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> VectorTableLookup(Vector128<sbyte> table, Vector64<sbyte> byteIndexes)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> VectorTableLookup(Vector128<byte> table, Vector128<byte> byteIndexes)
Vector128<sbyte> VectorTableLookup(Vector128<sbyte> table, Vector128<sbyte> byteIndexes)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.vectortablelookup?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.vectortablelookup?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, Vector64byte_0, apiResult);

try {
VectorTableLookupTest(Vector128byte_0, Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("VectorTableLookup", "Performs 'VectorTableLookup' operation", Vector128byte_0, Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var VectorTableLookupExtensionResult = Dummy_VectorTableLookupExtensionTest(Vector64byte_0, Vector128byte_0, Vector64byte_1);
apiResult = VectorTableLookupExtensionResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 14. VectorTableLookupExtension

`Vector64<byte> VectorTableLookupExtension(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)`

Performs 'VectorTableLookupExtension' operation.

```csharp
private Vector64<byte> VectorTableLookupExtensionTest(Vector64<byte> defaultValues, Vector128<byte> table, Vector64<byte> byteIndexes)
{{
  return AdvSimd.VectorTableLookupExtension(defaultValues, table, byteIndexes);
}}
// defaultValues = {0}
// table = {1}
// byteIndexes = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd
Vector64<sbyte> VectorTableLookupExtension(Vector64<sbyte> defaultValues, Vector128<sbyte> table, Vector64<sbyte> byteIndexes)

// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<byte> VectorTableLookupExtension(Vector128<byte> defaultValues, Vector128<byte> table, Vector128<byte> byteIndexes)
Vector128<sbyte> VectorTableLookupExtension(Vector128<sbyte> defaultValues, Vector128<sbyte> table, Vector128<sbyte> byteIndexes)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.vectortablelookupextension?view=net-5.0) and [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.vectortablelookupextension?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector128byte_0, Vector64byte_1, apiResult);

try {
VectorTableLookupExtensionTest(Vector64byte_0, Vector128byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("VectorTableLookupExtension", "Performs 'VectorTableLookupExtension' operation", Vector64byte_0, Vector128byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var XorResult = Dummy_XorTest(Vector64byte_0, Vector64byte_1);
apiResult = XorResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 15. Xor

`Vector64<byte> Xor(Vector64<byte> left, Vector64<byte> right)`

Performs 'Xor' operation.

```csharp
private Vector64<byte> XorTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Xor(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.xor?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
XorTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Xor", "Performs 'Xor' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var ZeroExtendWideningLowerResult = Dummy_ZeroExtendWideningLowerTest(Vector64byte_0);
apiResult = ZeroExtendWideningLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 16. ZeroExtendWideningLower

`Vector128<ushort> ZeroExtendWideningLower(Vector64<byte> value)`

Performs 'ZeroExtendWideningLower' operation.

```csharp
private Vector128<ushort> ZeroExtendWideningLowerTest(Vector64<byte> value)
{{
  return AdvSimd.ZeroExtendWideningLower(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.zeroextendwideninglower?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
ZeroExtendWideningLowerTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ZeroExtendWideningLower", "Performs 'ZeroExtendWideningLower' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ZeroExtendWideningUpperResult = Dummy_ZeroExtendWideningUpperTest(Vector128byte_0);
apiResult = ZeroExtendWideningUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 17. ZeroExtendWideningUpper

`Vector128<ushort> ZeroExtendWideningUpper(Vector128<byte> value)`

Performs 'ZeroExtendWideningUpper' operation.

```csharp
private Vector128<ushort> ZeroExtendWideningUpperTest(Vector128<byte> value)
{{
  return AdvSimd.ZeroExtendWideningUpper(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.zeroextendwideningupper?view=net-5.0).

Assembly generated:

```
", Vector128byte_0, apiResult);

try {
ZeroExtendWideningUpperTest(Vector128byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ZeroExtendWideningUpper", "Performs 'ZeroExtendWideningUpper' operation", Vector128byte_0, apiResult);
// ----------------------------------------------------------------

try {
var AbsSaturateScalarResult = Dummy_AbsSaturateScalarTest(Vector64short_0);
apiResult = AbsSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 18. AbsSaturateScalar

`Vector64<short> AbsSaturateScalar(Vector64<short> value)`

Performs 'AbsSaturateScalar' operation.

```csharp
private Vector64<short> AbsSaturateScalarTest(Vector64<short> value)
{{
  return AdvSimd.Arm64.AbsSaturateScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> AbsSaturateScalar(Vector64<int> value)
Vector64<long> AbsSaturateScalar(Vector64<long> value)
Vector64<sbyte> AbsSaturateScalar(Vector64<sbyte> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.abssaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
AbsSaturateScalarTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsSaturateScalar", "Performs 'AbsSaturateScalar' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanScalarResult = Dummy_AbsoluteCompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareGreaterThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 19. AbsoluteCompareGreaterThanScalar

`Vector64<double> AbsoluteCompareGreaterThanScalar(Vector64<double> left, Vector64<double> right)`

Performs 'AbsoluteCompareGreaterThanScalar' operation.

```csharp
private Vector64<double> AbsoluteCompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareGreaterThanScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthanscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
AbsoluteCompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareGreaterThanScalar", "Performs 'AbsoluteCompareGreaterThanScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareGreaterThanOrEqualScalarResult = Dummy_AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareGreaterThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 20. AbsoluteCompareGreaterThanOrEqualScalar

`Vector64<double> AbsoluteCompareGreaterThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

Performs 'AbsoluteCompareGreaterThanOrEqualScalar' operation.

```csharp
private Vector64<double> AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareGreaterThanOrEqualScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareGreaterThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparegreaterthanorequalscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
AbsoluteCompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareGreaterThanOrEqualScalar", "Performs 'AbsoluteCompareGreaterThanOrEqualScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanScalarResult = Dummy_AbsoluteCompareLessThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareLessThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 21. AbsoluteCompareLessThanScalar

`Vector64<double> AbsoluteCompareLessThanScalar(Vector64<double> left, Vector64<double> right)`

Performs 'AbsoluteCompareLessThanScalar' operation.

```csharp
private Vector64<double> AbsoluteCompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareLessThanScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareLessThanScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthanscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
AbsoluteCompareLessThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareLessThanScalar", "Performs 'AbsoluteCompareLessThanScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteCompareLessThanOrEqualScalarResult = Dummy_AbsoluteCompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteCompareLessThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 22. AbsoluteCompareLessThanOrEqualScalar

`Vector64<double> AbsoluteCompareLessThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

Performs 'AbsoluteCompareLessThanOrEqualScalar' operation.

```csharp
private Vector64<double> AbsoluteCompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteCompareLessThanOrEqualScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteCompareLessThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutecomparelessthanorequalscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
AbsoluteCompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteCompareLessThanOrEqualScalar", "Performs 'AbsoluteCompareLessThanOrEqualScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var AbsoluteDifferenceScalarResult = Dummy_AbsoluteDifferenceScalarTest(Vector64double_0, Vector64double_1);
apiResult = AbsoluteDifferenceScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 23. AbsoluteDifferenceScalar

`Vector64<double> AbsoluteDifferenceScalar(Vector64<double> left, Vector64<double> right)`

Performs 'AbsoluteDifferenceScalar' operation.

```csharp
private Vector64<double> AbsoluteDifferenceScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.AbsoluteDifferenceScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> AbsoluteDifferenceScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.absolutedifferencescalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
AbsoluteDifferenceScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AbsoluteDifferenceScalar", "Performs 'AbsoluteDifferenceScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var AddAcrossResult = Dummy_AddAcrossTest(Vector64byte_0);
apiResult = AddAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 24. AddAcross

`Vector64<byte> AddAcross(Vector64<byte> value)`

Performs 'AddAcross' operation.

```csharp
private Vector64<byte> AddAcrossTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.AddAcross(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addacross?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
AddAcrossTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddAcross", "Performs 'AddAcross' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var AddAcrossWideningResult = Dummy_AddAcrossWideningTest(Vector64byte_0);
apiResult = AddAcrossWideningResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 25. AddAcrossWidening

`Vector64<ushort> AddAcrossWidening(Vector64<byte> value)`

Performs 'AddAcrossWidening' operation.

```csharp
private Vector64<ushort> AddAcrossWideningTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.AddAcrossWidening(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addacrosswidening?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
AddAcrossWideningTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddAcrossWidening", "Performs 'AddAcrossWidening' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var AddPairwiseScalarResult = Dummy_AddPairwiseScalarTest(Vector64float_0);
apiResult = AddPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 26. AddPairwiseScalar

`Vector64<float> AddPairwiseScalar(Vector64<float> value)`

Performs 'AddPairwiseScalar' operation.

```csharp
private Vector64<float> AddPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.AddPairwiseScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> AddPairwiseScalar(Vector128<double> value)
Vector64<long> AddPairwiseScalar(Vector128<long> value)
Vector64<ulong> AddPairwiseScalar(Vector128<ulong> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.addpairwisescalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
AddPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("AddPairwiseScalar", "Performs 'AddPairwiseScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var CompareEqualScalarResult = Dummy_CompareEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 27. CompareEqualScalar

`Vector64<double> CompareEqualScalar(Vector64<double> left, Vector64<double> right)`

Performs 'CompareEqualScalar' operation.

```csharp
private Vector64<double> CompareEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareEqualScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareEqualScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareEqualScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.compareequalscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
CompareEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareEqualScalar", "Performs 'CompareEqualScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareGreaterThanScalarResult = Dummy_CompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareGreaterThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 28. CompareGreaterThanScalar

`Vector64<double> CompareGreaterThanScalar(Vector64<double> left, Vector64<double> right)`

Performs 'CompareGreaterThanScalar' operation.

```csharp
private Vector64<double> CompareGreaterThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareGreaterThanScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareGreaterThanScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareGreaterThanScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareGreaterThanScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthanscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
CompareGreaterThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareGreaterThanScalar", "Performs 'CompareGreaterThanScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareGreaterThanOrEqualScalarResult = Dummy_CompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareGreaterThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 29. CompareGreaterThanOrEqualScalar

`Vector64<double> CompareGreaterThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

Performs 'CompareGreaterThanOrEqualScalar' operation.

```csharp
private Vector64<double> CompareGreaterThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareGreaterThanOrEqualScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareGreaterThanOrEqualScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareGreaterThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareGreaterThanOrEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparegreaterthanorequalscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
CompareGreaterThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareGreaterThanOrEqualScalar", "Performs 'CompareGreaterThanOrEqualScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareLessThanScalarResult = Dummy_CompareLessThanScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareLessThanScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 30. CompareLessThanScalar

`Vector64<double> CompareLessThanScalar(Vector64<double> left, Vector64<double> right)`

Performs 'CompareLessThanScalar' operation.

```csharp
private Vector64<double> CompareLessThanScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareLessThanScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareLessThanScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareLessThanScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareLessThanScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthanscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
CompareLessThanScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareLessThanScalar", "Performs 'CompareLessThanScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareLessThanOrEqualScalarResult = Dummy_CompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareLessThanOrEqualScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 31. CompareLessThanOrEqualScalar

`Vector64<double> CompareLessThanOrEqualScalar(Vector64<double> left, Vector64<double> right)`

Performs 'CompareLessThanOrEqualScalar' operation.

```csharp
private Vector64<double> CompareLessThanOrEqualScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareLessThanOrEqualScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareLessThanOrEqualScalar(Vector64<long> left, Vector64<long> right)
Vector64<float> CompareLessThanOrEqualScalar(Vector64<float> left, Vector64<float> right)
Vector64<ulong> CompareLessThanOrEqualScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparelessthanorequalscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
CompareLessThanOrEqualScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareLessThanOrEqualScalar", "Performs 'CompareLessThanOrEqualScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var CompareTestScalarResult = Dummy_CompareTestScalarTest(Vector64double_0, Vector64double_1);
apiResult = CompareTestScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 32. CompareTestScalar

`Vector64<double> CompareTestScalar(Vector64<double> left, Vector64<double> right)`

Performs 'CompareTestScalar' operation.

```csharp
private Vector64<double> CompareTestScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.CompareTestScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> CompareTestScalar(Vector64<long> left, Vector64<long> right)
Vector64<ulong> CompareTestScalar(Vector64<ulong> left, Vector64<ulong> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.comparetestscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
CompareTestScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("CompareTestScalar", "Performs 'CompareTestScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToDoubleResult = Dummy_ConvertToDoubleTest(Vector64float_0);
apiResult = ConvertToDoubleResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 33. ConvertToDouble

`Vector128<double> ConvertToDouble(Vector64<float> value)`

Performs 'ConvertToDouble' operation.

```csharp
private Vector128<double> ConvertToDoubleTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.ConvertToDouble(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> ConvertToDouble(Vector128<long> value)
Vector128<double> ConvertToDouble(Vector128<ulong> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttodouble?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
ConvertToDoubleTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToDouble", "Performs 'ConvertToDouble' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToDoubleScalarResult = Dummy_ConvertToDoubleScalarTest(Vector64long_0);
apiResult = ConvertToDoubleScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 34. ConvertToDoubleScalar

`Vector64<double> ConvertToDoubleScalar(Vector64<long> value)`

Performs 'ConvertToDoubleScalar' operation.

```csharp
private Vector64<double> ConvertToDoubleScalarTest(Vector64<long> value)
{{
  return AdvSimd.Arm64.ConvertToDoubleScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> ConvertToDoubleScalar(Vector64<ulong> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttodoublescalar?view=net-5.0).

Assembly generated:

```
", Vector64long_0, apiResult);

try {
ConvertToDoubleScalarTest(Vector64long_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToDoubleScalar", "Performs 'ConvertToDoubleScalar' operation", Vector64long_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToDoubleUpperResult = Dummy_ConvertToDoubleUpperTest(Vector128float_0);
apiResult = ConvertToDoubleUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 35. ConvertToDoubleUpper

`Vector128<double> ConvertToDoubleUpper(Vector128<float> value)`

Performs 'ConvertToDoubleUpper' operation.

```csharp
private Vector128<double> ConvertToDoubleUpperTest(Vector128<float> value)
{{
  return AdvSimd.Arm64.ConvertToDoubleUpper(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttodoubleupper?view=net-5.0).

Assembly generated:

```
", Vector128float_0, apiResult);

try {
ConvertToDoubleUpperTest(Vector128float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToDoubleUpper", "Performs 'ConvertToDoubleUpper' operation", Vector128float_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundAwayFromZeroResult = Dummy_ConvertToInt64RoundAwayFromZeroTest(Vector128double_0);
apiResult = ConvertToInt64RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 36. ConvertToInt64RoundAwayFromZero

`Vector128<long> ConvertToInt64RoundAwayFromZero(Vector128<double> value)`

Performs 'ConvertToInt64RoundAwayFromZero' operation.

```csharp
private Vector128<long> ConvertToInt64RoundAwayFromZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZero(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundawayfromzero?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToInt64RoundAwayFromZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundAwayFromZero", "Performs 'ConvertToInt64RoundAwayFromZero' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundAwayFromZeroScalarResult = Dummy_ConvertToInt64RoundAwayFromZeroScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 37. ConvertToInt64RoundAwayFromZeroScalar

`Vector64<long> ConvertToInt64RoundAwayFromZeroScalar(Vector64<double> value)`

Performs 'ConvertToInt64RoundAwayFromZeroScalar' operation.

```csharp
private Vector64<long> ConvertToInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundAwayFromZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundawayfromzeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToInt64RoundAwayFromZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundAwayFromZeroScalar", "Performs 'ConvertToInt64RoundAwayFromZeroScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToEvenResult = Dummy_ConvertToInt64RoundToEvenTest(Vector128double_0);
apiResult = ConvertToInt64RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 38. ConvertToInt64RoundToEven

`Vector128<long> ConvertToInt64RoundToEven(Vector128<double> value)`

Performs 'ConvertToInt64RoundToEven' operation.

```csharp
private Vector128<long> ConvertToInt64RoundToEvenTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToEven(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtoeven?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToInt64RoundToEvenTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToEven", "Performs 'ConvertToInt64RoundToEven' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToEvenScalarResult = Dummy_ConvertToInt64RoundToEvenScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 39. ConvertToInt64RoundToEvenScalar

`Vector64<long> ConvertToInt64RoundToEvenScalar(Vector64<double> value)`

Performs 'ConvertToInt64RoundToEvenScalar' operation.

```csharp
private Vector64<long> ConvertToInt64RoundToEvenScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToEvenScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtoevenscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToInt64RoundToEvenScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToEvenScalar", "Performs 'ConvertToInt64RoundToEvenScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToNegativeInfinityResult = Dummy_ConvertToInt64RoundToNegativeInfinityTest(Vector128double_0);
apiResult = ConvertToInt64RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 40. ConvertToInt64RoundToNegativeInfinity

`Vector128<long> ConvertToInt64RoundToNegativeInfinity(Vector128<double> value)`

Performs 'ConvertToInt64RoundToNegativeInfinity' operation.

```csharp
private Vector128<long> ConvertToInt64RoundToNegativeInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinity(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtonegativeinfinity?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToInt64RoundToNegativeInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToNegativeInfinity", "Performs 'ConvertToInt64RoundToNegativeInfinity' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToNegativeInfinityScalarResult = Dummy_ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 41. ConvertToInt64RoundToNegativeInfinityScalar

`Vector64<long> ConvertToInt64RoundToNegativeInfinityScalar(Vector64<double> value)`

Performs 'ConvertToInt64RoundToNegativeInfinityScalar' operation.

```csharp
private Vector64<long> ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToNegativeInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtonegativeinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToInt64RoundToNegativeInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToNegativeInfinityScalar", "Performs 'ConvertToInt64RoundToNegativeInfinityScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToPositiveInfinityResult = Dummy_ConvertToInt64RoundToPositiveInfinityTest(Vector128double_0);
apiResult = ConvertToInt64RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 42. ConvertToInt64RoundToPositiveInfinity

`Vector128<long> ConvertToInt64RoundToPositiveInfinity(Vector128<double> value)`

Performs 'ConvertToInt64RoundToPositiveInfinity' operation.

```csharp
private Vector128<long> ConvertToInt64RoundToPositiveInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinity(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtopositiveinfinity?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToInt64RoundToPositiveInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToPositiveInfinity", "Performs 'ConvertToInt64RoundToPositiveInfinity' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToPositiveInfinityScalarResult = Dummy_ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 43. ConvertToInt64RoundToPositiveInfinityScalar

`Vector64<long> ConvertToInt64RoundToPositiveInfinityScalar(Vector64<double> value)`

Performs 'ConvertToInt64RoundToPositiveInfinityScalar' operation.

```csharp
private Vector64<long> ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToPositiveInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtopositiveinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToInt64RoundToPositiveInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToPositiveInfinityScalar", "Performs 'ConvertToInt64RoundToPositiveInfinityScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToZeroResult = Dummy_ConvertToInt64RoundToZeroTest(Vector128double_0);
apiResult = ConvertToInt64RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 44. ConvertToInt64RoundToZero

`Vector128<long> ConvertToInt64RoundToZero(Vector128<double> value)`

Performs 'ConvertToInt64RoundToZero' operation.

```csharp
private Vector128<long> ConvertToInt64RoundToZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToZero(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtozero?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToInt64RoundToZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToZero", "Performs 'ConvertToInt64RoundToZero' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToInt64RoundToZeroScalarResult = Dummy_ConvertToInt64RoundToZeroScalarTest(Vector64double_0);
apiResult = ConvertToInt64RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 45. ConvertToInt64RoundToZeroScalar

`Vector64<long> ConvertToInt64RoundToZeroScalar(Vector64<double> value)`

Performs 'ConvertToInt64RoundToZeroScalar' operation.

```csharp
private Vector64<long> ConvertToInt64RoundToZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToInt64RoundToZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttoint64roundtozeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToInt64RoundToZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToInt64RoundToZeroScalar", "Performs 'ConvertToInt64RoundToZeroScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToSingleLowerResult = Dummy_ConvertToSingleLowerTest(Vector128double_0);
apiResult = ConvertToSingleLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 46. ConvertToSingleLower

`Vector64<float> ConvertToSingleLower(Vector128<double> value)`

Performs 'ConvertToSingleLower' operation.

```csharp
private Vector64<float> ConvertToSingleLowerTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleLower(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosinglelower?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToSingleLowerTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToSingleLower", "Performs 'ConvertToSingleLower' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToSingleRoundToOddLowerResult = Dummy_ConvertToSingleRoundToOddLowerTest(Vector128double_0);
apiResult = ConvertToSingleRoundToOddLowerResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 47. ConvertToSingleRoundToOddLower

`Vector64<float> ConvertToSingleRoundToOddLower(Vector128<double> value)`

Performs 'ConvertToSingleRoundToOddLower' operation.

```csharp
private Vector64<float> ConvertToSingleRoundToOddLowerTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddLower(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosingleroundtooddlower?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToSingleRoundToOddLowerTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToSingleRoundToOddLower", "Performs 'ConvertToSingleRoundToOddLower' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToSingleRoundToOddUpperResult = Dummy_ConvertToSingleRoundToOddUpperTest(Vector64float_0, Vector128double_0);
apiResult = ConvertToSingleRoundToOddUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 48. ConvertToSingleRoundToOddUpper

`Vector128<float> ConvertToSingleRoundToOddUpper(Vector64<float> lower, Vector128<double> value)`

Performs 'ConvertToSingleRoundToOddUpper' operation.

```csharp
private Vector128<float> ConvertToSingleRoundToOddUpperTest(Vector64<float> lower, Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleRoundToOddUpper(lower, value);
}}
// lower = {0}
// value = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosingleroundtooddupper?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector128double_0, apiResult);

try {
ConvertToSingleRoundToOddUpperTest(Vector64float_0, Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToSingleRoundToOddUpper", "Performs 'ConvertToSingleRoundToOddUpper' operation", Vector64float_0, Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToSingleUpperResult = Dummy_ConvertToSingleUpperTest(Vector64float_0, Vector128double_0);
apiResult = ConvertToSingleUpperResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 49. ConvertToSingleUpper

`Vector128<float> ConvertToSingleUpper(Vector64<float> lower, Vector128<double> value)`

Performs 'ConvertToSingleUpper' operation.

```csharp
private Vector128<float> ConvertToSingleUpperTest(Vector64<float> lower, Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToSingleUpper(lower, value);
}}
// lower = {0}
// value = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttosingleupper?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector128double_0, apiResult);

try {
ConvertToSingleUpperTest(Vector64float_0, Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToSingleUpper", "Performs 'ConvertToSingleUpper' operation", Vector64float_0, Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundAwayFromZeroResult = Dummy_ConvertToUInt64RoundAwayFromZeroTest(Vector128double_0);
apiResult = ConvertToUInt64RoundAwayFromZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 50. ConvertToUInt64RoundAwayFromZero

`Vector128<ulong> ConvertToUInt64RoundAwayFromZero(Vector128<double> value)`

Performs 'ConvertToUInt64RoundAwayFromZero' operation.

```csharp
private Vector128<ulong> ConvertToUInt64RoundAwayFromZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZero(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundawayfromzero?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToUInt64RoundAwayFromZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundAwayFromZero", "Performs 'ConvertToUInt64RoundAwayFromZero' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundAwayFromZeroScalarResult = Dummy_ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundAwayFromZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 51. ConvertToUInt64RoundAwayFromZeroScalar

`Vector64<ulong> ConvertToUInt64RoundAwayFromZeroScalar(Vector64<double> value)`

Performs 'ConvertToUInt64RoundAwayFromZeroScalar' operation.

```csharp
private Vector64<ulong> ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundAwayFromZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundawayfromzeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToUInt64RoundAwayFromZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundAwayFromZeroScalar", "Performs 'ConvertToUInt64RoundAwayFromZeroScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToEvenResult = Dummy_ConvertToUInt64RoundToEvenTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 52. ConvertToUInt64RoundToEven

`Vector128<ulong> ConvertToUInt64RoundToEven(Vector128<double> value)`

Performs 'ConvertToUInt64RoundToEven' operation.

```csharp
private Vector128<ulong> ConvertToUInt64RoundToEvenTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEven(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtoeven?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToUInt64RoundToEvenTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToEven", "Performs 'ConvertToUInt64RoundToEven' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToEvenScalarResult = Dummy_ConvertToUInt64RoundToEvenScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToEvenScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 53. ConvertToUInt64RoundToEvenScalar

`Vector64<ulong> ConvertToUInt64RoundToEvenScalar(Vector64<double> value)`

Performs 'ConvertToUInt64RoundToEvenScalar' operation.

```csharp
private Vector64<ulong> ConvertToUInt64RoundToEvenScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToEvenScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtoevenscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToUInt64RoundToEvenScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToEvenScalar", "Performs 'ConvertToUInt64RoundToEvenScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToNegativeInfinityResult = Dummy_ConvertToUInt64RoundToNegativeInfinityTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToNegativeInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 54. ConvertToUInt64RoundToNegativeInfinity

`Vector128<ulong> ConvertToUInt64RoundToNegativeInfinity(Vector128<double> value)`

Performs 'ConvertToUInt64RoundToNegativeInfinity' operation.

```csharp
private Vector128<ulong> ConvertToUInt64RoundToNegativeInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinity(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtonegativeinfinity?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToUInt64RoundToNegativeInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToNegativeInfinity", "Performs 'ConvertToUInt64RoundToNegativeInfinity' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToNegativeInfinityScalarResult = Dummy_ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToNegativeInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 55. ConvertToUInt64RoundToNegativeInfinityScalar

`Vector64<ulong> ConvertToUInt64RoundToNegativeInfinityScalar(Vector64<double> value)`

Performs 'ConvertToUInt64RoundToNegativeInfinityScalar' operation.

```csharp
private Vector64<ulong> ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToNegativeInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtonegativeinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToUInt64RoundToNegativeInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToNegativeInfinityScalar", "Performs 'ConvertToUInt64RoundToNegativeInfinityScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToPositiveInfinityResult = Dummy_ConvertToUInt64RoundToPositiveInfinityTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToPositiveInfinityResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 56. ConvertToUInt64RoundToPositiveInfinity

`Vector128<ulong> ConvertToUInt64RoundToPositiveInfinity(Vector128<double> value)`

Performs 'ConvertToUInt64RoundToPositiveInfinity' operation.

```csharp
private Vector128<ulong> ConvertToUInt64RoundToPositiveInfinityTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinity(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtopositiveinfinity?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToUInt64RoundToPositiveInfinityTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToPositiveInfinity", "Performs 'ConvertToUInt64RoundToPositiveInfinity' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToPositiveInfinityScalarResult = Dummy_ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToPositiveInfinityScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 57. ConvertToUInt64RoundToPositiveInfinityScalar

`Vector64<ulong> ConvertToUInt64RoundToPositiveInfinityScalar(Vector64<double> value)`

Performs 'ConvertToUInt64RoundToPositiveInfinityScalar' operation.

```csharp
private Vector64<ulong> ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToPositiveInfinityScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtopositiveinfinityscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToUInt64RoundToPositiveInfinityScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToPositiveInfinityScalar", "Performs 'ConvertToUInt64RoundToPositiveInfinityScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToZeroResult = Dummy_ConvertToUInt64RoundToZeroTest(Vector128double_0);
apiResult = ConvertToUInt64RoundToZeroResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 58. ConvertToUInt64RoundToZero

`Vector128<ulong> ConvertToUInt64RoundToZero(Vector128<double> value)`

Performs 'ConvertToUInt64RoundToZero' operation.

```csharp
private Vector128<ulong> ConvertToUInt64RoundToZeroTest(Vector128<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZero(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtozero?view=net-5.0).

Assembly generated:

```
", Vector128double_0, apiResult);

try {
ConvertToUInt64RoundToZeroTest(Vector128double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToZero", "Performs 'ConvertToUInt64RoundToZero' operation", Vector128double_0, apiResult);
// ----------------------------------------------------------------

try {
var ConvertToUInt64RoundToZeroScalarResult = Dummy_ConvertToUInt64RoundToZeroScalarTest(Vector64double_0);
apiResult = ConvertToUInt64RoundToZeroScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 59. ConvertToUInt64RoundToZeroScalar

`Vector64<ulong> ConvertToUInt64RoundToZeroScalar(Vector64<double> value)`

Performs 'ConvertToUInt64RoundToZeroScalar' operation.

```csharp
private Vector64<ulong> ConvertToUInt64RoundToZeroScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ConvertToUInt64RoundToZeroScalar(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.converttouint64roundtozeroscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ConvertToUInt64RoundToZeroScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ConvertToUInt64RoundToZeroScalar", "Performs 'ConvertToUInt64RoundToZeroScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var DivideResult = Dummy_DivideTest(Vector64float_0, Vector64float_1);
apiResult = DivideResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 60. Divide

`Vector64<float> Divide(Vector64<float> left, Vector64<float> right)`

Performs 'Divide' operation.

```csharp
private Vector64<float> DivideTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.Divide(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Divide(Vector128<double> left, Vector128<double> right)
Vector128<float> Divide(Vector128<float> left, Vector128<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.divide?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
DivideTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Divide", "Performs 'Divide' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------
Console.WriteLine(
@"```

START---END
layout: post
title: Hardware Intrinsics APIs for ARM64 - Part 6
subtitle: With examples
tags: [work, arm64, intrinsics]
---

### Introduction

In my [last post](../2019-01-01-Vectorization-APIs), I describe SIMD datatypes `Vector64<T>` and `Vector128<T>` that operates on 'hardware intrisic' APIs. In this post I will describe the intrinsic APIs for ARM64 and how you can use them to optimize your code if you are writing a .NET API targetting ARM64. This is 3 post series TODO.


### API list

[ExtractNarrowingSaturateScalar](#1-extractnarrowingsaturatescalar), [ExtractNarrowingSaturateUnsignedScalar](#2-extractnarrowingsaturateunsignedscalar), [FusedMultiplyAddByScalar](#3-fusedmultiplyaddbyscalar), [FusedMultiplyAddBySelectedScalar](#4-fusedmultiplyaddbyselectedscalar), [FusedMultiplyAddScalarBySelectedScalar](#5-fusedmultiplyaddscalarbyselectedscalar), [FusedMultiplySubtractByScalar](#6-fusedmultiplysubtractbyscalar), [FusedMultiplySubtractBySelectedScalar](#7-fusedmultiplysubtractbyselectedscalar), [FusedMultiplySubtractScalarBySelectedScalar](#8-fusedmultiplysubtractscalarbyselectedscalar), [InsertSelectedScalar](#9-insertselectedscalar), [MaxAcross](#10-maxacross), [MaxNumberAcross](#11-maxnumberacross), [MaxNumberPairwise](#12-maxnumberpairwise), [MaxNumberPairwiseScalar](#13-maxnumberpairwisescalar), [MaxPairwiseScalar](#14-maxpairwisescalar), [MaxScalar](#15-maxscalar), [MinAcross](#16-minacross), [MinNumberAcross](#17-minnumberacross), [MinNumberPairwise](#18-minnumberpairwise), [MinNumberPairwiseScalar](#19-minnumberpairwisescalar), [MinPairwiseScalar](#20-minpairwisescalar), [MinScalar](#21-minscalar), [MultiplyDoublingSaturateHighScalar](#22-multiplydoublingsaturatehighscalar), [MultiplyDoublingScalarBySelectedScalarSaturateHigh](#23-multiplydoublingscalarbyselectedscalarsaturatehigh), [MultiplyDoublingWideningAndAddSaturateScalar](#24-multiplydoublingwideningandaddsaturatescalar), [MultiplyDoublingWideningAndSubtractSaturateScalar](#25-multiplydoublingwideningandsubtractsaturatescalar), [MultiplyDoublingWideningSaturateScalar](#26-multiplydoublingwideningsaturatescalar), [MultiplyDoublingWideningSaturateScalarBySelectedScalar](#27-multiplydoublingwideningsaturatescalarbyselectedscalar), [MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate](#28-multiplydoublingwideningscalarbyselectedscalarandaddsaturate), [MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate](#29-multiplydoublingwideningscalarbyselectedscalarandsubtractsaturate), [MultiplyExtended](#30-multiplyextended), [MultiplyExtendedByScalar](#31-multiplyextendedbyscalar), [MultiplyExtendedBySelectedScalar](#32-multiplyextendedbyselectedscalar), [MultiplyExtendedScalar](#33-multiplyextendedscalar), [MultiplyExtendedScalarBySelectedScalar](#34-multiplyextendedscalarbyselectedscalar), [MultiplyRoundedDoublingSaturateHighScalar](#35-multiplyroundeddoublingsaturatehighscalar), [MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh](#36-multiplyroundeddoublingscalarbyselectedscalarsaturatehigh), [NegateSaturateScalar](#37-negatesaturatescalar), [ReciprocalEstimateScalar](#38-reciprocalestimatescalar), [ReciprocalExponentScalar](#39-reciprocalexponentscalar), [ReciprocalSquareRootEstimateScalar](#40-reciprocalsquarerootestimatescalar), [ReciprocalSquareRootStepScalar](#41-reciprocalsquarerootstepscalar), [ReciprocalStepScalar](#42-reciprocalstepscalar), [ShiftRightArithmeticNarrowingSaturateScalar](#43-shiftrightarithmeticnarrowingsaturatescalar), [ShiftRightArithmeticNarrowingSaturateUnsignedScalar](#44-shiftrightarithmeticnarrowingsaturateunsignedscalar), [ShiftRightArithmeticRoundedNarrowingSaturateScalar](#45-shiftrightarithmeticroundednarrowingsaturatescalar), [ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar](#46-shiftrightarithmeticroundednarrowingsaturateunsignedscalar), [ShiftRightLogicalNarrowingSaturateScalar](#47-shiftrightlogicalnarrowingsaturatescalar), [ShiftRightLogicalRoundedNarrowingSaturateScalar](#48-shiftrightlogicalroundednarrowingsaturatescalar), [Sqrt](#49-sqrt), [StorePair](#50-storepair), [StorePairNonTemporal](#51-storepairnontemporal), [StorePairScalar](#52-storepairscalar), [StorePairScalarNonTemporal](#53-storepairscalarnontemporal), [ReverseElementBits](#54-reverseelementbits), [TransposeEven](#55-transposeeven), [TransposeOdd](#56-transposeodd), [UnzipEven](#57-unzipeven), [UnzipOdd](#58-unzipodd), [ZipHigh](#59-ziphigh), [ZipLow](#60-ziplow),[...](Part6.md)


");

try {
var ExtractNarrowingSaturateScalarResult = Dummy_ExtractNarrowingSaturateScalarTest(Vector64ushort_0);
apiResult = ExtractNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"


### 1. ExtractNarrowingSaturateScalar

`Vector64<byte> ExtractNarrowingSaturateScalar(Vector64<ushort> value)`

Performs 'ExtractNarrowingSaturateScalar' operation.

```csharp
private Vector64<byte> ExtractNarrowingSaturateScalarTest(Vector64<ushort> value)
{{
  return AdvSimd.Arm64.ExtractNarrowingSaturateScalar(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.extractnarrowingsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64ushort_0, apiResult);

try {
ExtractNarrowingSaturateScalarTest(Vector64ushort_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingSaturateScalar", "Performs 'ExtractNarrowingSaturateScalar' operation", Vector64ushort_0, apiResult);
// ----------------------------------------------------------------

try {
var ExtractNarrowingSaturateUnsignedScalarResult = Dummy_ExtractNarrowingSaturateUnsignedScalarTest(Vector64short_0);
apiResult = ExtractNarrowingSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 2. ExtractNarrowingSaturateUnsignedScalar

`Vector64<byte> ExtractNarrowingSaturateUnsignedScalar(Vector64<short> value)`

Performs 'ExtractNarrowingSaturateUnsignedScalar' operation.

```csharp
private Vector64<byte> ExtractNarrowingSaturateUnsignedScalarTest(Vector64<short> value)
{{
  return AdvSimd.Arm64.ExtractNarrowingSaturateUnsignedScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ExtractNarrowingSaturateUnsignedScalar(Vector64<int> value)
Vector64<uint> ExtractNarrowingSaturateUnsignedScalar(Vector64<long> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.extractnarrowingsaturateunsignedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
ExtractNarrowingSaturateUnsignedScalarTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ExtractNarrowingSaturateUnsignedScalar", "Performs 'ExtractNarrowingSaturateUnsignedScalar' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplyAddByScalarResult = Dummy_FusedMultiplyAddByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplyAddByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 3. FusedMultiplyAddByScalar

`Vector64<float> FusedMultiplyAddByScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right)`

Performs 'FusedMultiplyAddByScalar' operation.

```csharp
private Vector64<float> FusedMultiplyAddByScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.FusedMultiplyAddByScalar(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplyAddByScalar(Vector128<double> addend, Vector128<double> left, Vector64<double> right)
Vector128<float> FusedMultiplyAddByScalar(Vector128<float> addend, Vector128<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyaddbyscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);

try {
FusedMultiplyAddByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplyAddByScalar", "Performs 'FusedMultiplyAddByScalar' operation", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplyAddBySelectedScalarResult = Dummy_FusedMultiplyAddBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);
apiResult = FusedMultiplyAddBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 4. FusedMultiplyAddBySelectedScalar

`Vector64<float> FusedMultiplyAddBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)`

Performs 'FusedMultiplyAddBySelectedScalar' operation.

```csharp
private Vector64<float> FusedMultiplyAddBySelectedScalarTest(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplyAddBySelectedScalar(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplyAddBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector128<double> FusedMultiplyAddBySelectedScalar(Vector128<double> addend, Vector128<double> left, Vector128<double> right, byte rightIndex)
Vector128<float> FusedMultiplyAddBySelectedScalar(Vector128<float> addend, Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> FusedMultiplyAddBySelectedScalar(Vector128<float> addend, Vector128<float> left, Vector128<float> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyaddbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, Vector64float_2, byte_0, apiResult);

try {
FusedMultiplyAddBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplyAddBySelectedScalar", "Performs 'FusedMultiplyAddBySelectedScalar' operation", Vector64float_0, Vector64float_1, Vector64float_2, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplyAddScalarBySelectedScalarResult = Dummy_FusedMultiplyAddScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);
apiResult = FusedMultiplyAddScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 5. FusedMultiplyAddScalarBySelectedScalar

`Vector64<double> FusedMultiplyAddScalarBySelectedScalar(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)`

Performs 'FusedMultiplyAddScalarBySelectedScalar' operation.

```csharp
private Vector64<double> FusedMultiplyAddScalarBySelectedScalarTest(Vector64<double> addend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplyAddScalarBySelectedScalar(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplyAddScalarBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> FusedMultiplyAddScalarBySelectedScalar(Vector64<float> addend, Vector64<float> left, Vector128<float> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplyaddscalarbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, Vector128double_0, byte_0, apiResult);

try {
FusedMultiplyAddScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplyAddScalarBySelectedScalar", "Performs 'FusedMultiplyAddScalarBySelectedScalar' operation", Vector64double_0, Vector64double_1, Vector128double_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplySubtractByScalarResult = Dummy_FusedMultiplySubtractByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);
apiResult = FusedMultiplySubtractByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 6. FusedMultiplySubtractByScalar

`Vector64<float> FusedMultiplySubtractByScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)`

Performs 'FusedMultiplySubtractByScalar' operation.

```csharp
private Vector64<float> FusedMultiplySubtractByScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.FusedMultiplySubtractByScalar(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> FusedMultiplySubtractByScalar(Vector128<double> minuend, Vector128<double> left, Vector64<double> right)
Vector128<float> FusedMultiplySubtractByScalar(Vector128<float> minuend, Vector128<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtractbyscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);

try {
FusedMultiplySubtractByScalarTest(Vector64float_0, Vector64float_1, Vector64float_2);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplySubtractByScalar", "Performs 'FusedMultiplySubtractByScalar' operation", Vector64float_0, Vector64float_1, Vector64float_2, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplySubtractBySelectedScalarResult = Dummy_FusedMultiplySubtractBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);
apiResult = FusedMultiplySubtractBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 7. FusedMultiplySubtractBySelectedScalar

`Vector64<float> FusedMultiplySubtractBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)`

Performs 'FusedMultiplySubtractBySelectedScalar' operation.

```csharp
private Vector64<float> FusedMultiplySubtractBySelectedScalarTest(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplySubtractBySelectedScalar(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplySubtractBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector128<double> FusedMultiplySubtractBySelectedScalar(Vector128<double> minuend, Vector128<double> left, Vector128<double> right, byte rightIndex)
Vector128<float> FusedMultiplySubtractBySelectedScalar(Vector128<float> minuend, Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> FusedMultiplySubtractBySelectedScalar(Vector128<float> minuend, Vector128<float> left, Vector128<float> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtractbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, Vector64float_2, byte_0, apiResult);

try {
FusedMultiplySubtractBySelectedScalarTest(Vector64float_0, Vector64float_1, Vector64float_2, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplySubtractBySelectedScalar", "Performs 'FusedMultiplySubtractBySelectedScalar' operation", Vector64float_0, Vector64float_1, Vector64float_2, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var FusedMultiplySubtractScalarBySelectedScalarResult = Dummy_FusedMultiplySubtractScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);
apiResult = FusedMultiplySubtractScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 8. FusedMultiplySubtractScalarBySelectedScalar

`Vector64<double> FusedMultiplySubtractScalarBySelectedScalar(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)`

Performs 'FusedMultiplySubtractScalarBySelectedScalar' operation.

```csharp
private Vector64<double> FusedMultiplySubtractScalarBySelectedScalarTest(Vector64<double> minuend, Vector64<double> left, Vector128<double> right, byte rightIndex)
{{
  return AdvSimd.Arm64.FusedMultiplySubtractScalarBySelectedScalar(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> FusedMultiplySubtractScalarBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> FusedMultiplySubtractScalarBySelectedScalar(Vector64<float> minuend, Vector64<float> left, Vector128<float> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.fusedmultiplysubtractscalarbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, Vector128double_0, byte_0, apiResult);

try {
FusedMultiplySubtractScalarBySelectedScalarTest(Vector64double_0, Vector64double_1, Vector128double_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("FusedMultiplySubtractScalarBySelectedScalar", "Performs 'FusedMultiplySubtractScalarBySelectedScalar' operation", Vector64double_0, Vector64double_1, Vector128double_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var InsertSelectedScalarResult = Dummy_InsertSelectedScalarTest(Vector64byte_0, byte_0, Vector64byte_1, byte_1);
apiResult = InsertSelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 9. InsertSelectedScalar

`Vector64<byte> InsertSelectedScalar(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)`

Performs 'InsertSelectedScalar' operation.

```csharp
private Vector64<byte> InsertSelectedScalarTest(Vector64<byte> result, byte resultIndex, Vector64<byte> value, byte valueIndex)
{{
  return AdvSimd.Arm64.InsertSelectedScalar(result, resultIndex, value, valueIndex);
}}
// result = {0}
// resultIndex = {1}
// value = {2}
// valueIndex = {3}
// Result = {4}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.insertselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, byte_0, Vector64byte_1, byte_1, apiResult);

try {
InsertSelectedScalarTest(Vector64byte_0, byte_0, Vector64byte_1, byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("InsertSelectedScalar", "Performs 'InsertSelectedScalar' operation", Vector64byte_0, byte_0, Vector64byte_1, byte_1, apiResult);
// ----------------------------------------------------------------

try {
var MaxAcrossResult = Dummy_MaxAcrossTest(Vector64byte_0);
apiResult = MaxAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 10. MaxAcross

`Vector64<byte> MaxAcross(Vector64<byte> value)`

Performs 'MaxAcross' operation.

```csharp
private Vector64<byte> MaxAcrossTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.MaxAcross(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxacross?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
MaxAcrossTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxAcross", "Performs 'MaxAcross' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MaxNumberAcrossResult = Dummy_MaxNumberAcrossTest(Vector128float_0);
apiResult = MaxNumberAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 11. MaxNumberAcross

`Vector64<float> MaxNumberAcross(Vector128<float> value)`

Performs 'MaxNumberAcross' operation.

```csharp
private Vector64<float> MaxNumberAcrossTest(Vector128<float> value)
{{
  return AdvSimd.Arm64.MaxNumberAcross(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumberacross?view=net-5.0).

Assembly generated:

```
", Vector128float_0, apiResult);

try {
MaxNumberAcrossTest(Vector128float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxNumberAcross", "Performs 'MaxNumberAcross' operation", Vector128float_0, apiResult);
// ----------------------------------------------------------------

try {
var MaxNumberPairwiseResult = Dummy_MaxNumberPairwiseTest(Vector64float_0, Vector64float_1);
apiResult = MaxNumberPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 12. MaxNumberPairwise

`Vector64<float> MaxNumberPairwise(Vector64<float> left, Vector64<float> right)`

Performs 'MaxNumberPairwise' operation.

```csharp
private Vector64<float> MaxNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.MaxNumberPairwise(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MaxNumberPairwise(Vector128<double> left, Vector128<double> right)
Vector128<float> MaxNumberPairwise(Vector128<float> left, Vector128<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumberpairwise?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
MaxNumberPairwiseTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxNumberPairwise", "Performs 'MaxNumberPairwise' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var MaxNumberPairwiseScalarResult = Dummy_MaxNumberPairwiseScalarTest(Vector64float_0);
apiResult = MaxNumberPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 13. MaxNumberPairwiseScalar

`Vector64<float> MaxNumberPairwiseScalar(Vector64<float> value)`

Performs 'MaxNumberPairwiseScalar' operation.

```csharp
private Vector64<float> MaxNumberPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MaxNumberPairwiseScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MaxNumberPairwiseScalar(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxnumberpairwisescalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
MaxNumberPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxNumberPairwiseScalar", "Performs 'MaxNumberPairwiseScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var MaxPairwiseScalarResult = Dummy_MaxPairwiseScalarTest(Vector64float_0);
apiResult = MaxPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 14. MaxPairwiseScalar

`Vector64<float> MaxPairwiseScalar(Vector64<float> value)`

Performs 'MaxPairwiseScalar' operation.

```csharp
private Vector64<float> MaxPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MaxPairwiseScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MaxPairwiseScalar(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxpairwisescalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
MaxPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxPairwiseScalar", "Performs 'MaxPairwiseScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var MaxScalarResult = Dummy_MaxScalarTest(Vector64double_0, Vector64double_1);
apiResult = MaxScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 15. MaxScalar

`Vector64<double> MaxScalar(Vector64<double> left, Vector64<double> right)`

Performs 'MaxScalar' operation.

```csharp
private Vector64<double> MaxScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MaxScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MaxScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.maxscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
MaxScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MaxScalar", "Performs 'MaxScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var MinAcrossResult = Dummy_MinAcrossTest(Vector64byte_0);
apiResult = MinAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 16. MinAcross

`Vector64<byte> MinAcross(Vector64<byte> value)`

Performs 'MinAcross' operation.

```csharp
private Vector64<byte> MinAcrossTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.MinAcross(value);
}}
// value = {0}
// Result = {1}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minacross?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
MinAcrossTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinAcross", "Performs 'MinAcross' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MinNumberAcrossResult = Dummy_MinNumberAcrossTest(Vector128float_0);
apiResult = MinNumberAcrossResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 17. MinNumberAcross

`Vector64<float> MinNumberAcross(Vector128<float> value)`

Performs 'MinNumberAcross' operation.

```csharp
private Vector64<float> MinNumberAcrossTest(Vector128<float> value)
{{
  return AdvSimd.Arm64.MinNumberAcross(value);
}}
// value = {0}
// Result = {1}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumberacross?view=net-5.0).

Assembly generated:

```
", Vector128float_0, apiResult);

try {
MinNumberAcrossTest(Vector128float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinNumberAcross", "Performs 'MinNumberAcross' operation", Vector128float_0, apiResult);
// ----------------------------------------------------------------

try {
var MinNumberPairwiseResult = Dummy_MinNumberPairwiseTest(Vector64float_0, Vector64float_1);
apiResult = MinNumberPairwiseResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 18. MinNumberPairwise

`Vector64<float> MinNumberPairwise(Vector64<float> left, Vector64<float> right)`

Performs 'MinNumberPairwise' operation.

```csharp
private Vector64<float> MinNumberPairwiseTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.MinNumberPairwise(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MinNumberPairwise(Vector128<double> left, Vector128<double> right)
Vector128<float> MinNumberPairwise(Vector128<float> left, Vector128<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumberpairwise?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
MinNumberPairwiseTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinNumberPairwise", "Performs 'MinNumberPairwise' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var MinNumberPairwiseScalarResult = Dummy_MinNumberPairwiseScalarTest(Vector64float_0);
apiResult = MinNumberPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 19. MinNumberPairwiseScalar

`Vector64<float> MinNumberPairwiseScalar(Vector64<float> value)`

Performs 'MinNumberPairwiseScalar' operation.

```csharp
private Vector64<float> MinNumberPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MinNumberPairwiseScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MinNumberPairwiseScalar(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minnumberpairwisescalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
MinNumberPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinNumberPairwiseScalar", "Performs 'MinNumberPairwiseScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var MinPairwiseScalarResult = Dummy_MinPairwiseScalarTest(Vector64float_0);
apiResult = MinPairwiseScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 20. MinPairwiseScalar

`Vector64<float> MinPairwiseScalar(Vector64<float> value)`

Performs 'MinPairwiseScalar' operation.

```csharp
private Vector64<float> MinPairwiseScalarTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.MinPairwiseScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<double> MinPairwiseScalar(Vector128<double> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minpairwisescalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
MinPairwiseScalarTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinPairwiseScalar", "Performs 'MinPairwiseScalar' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------

try {
var MinScalarResult = Dummy_MinScalarTest(Vector64double_0, Vector64double_1);
apiResult = MinScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 21. MinScalar

`Vector64<double> MinScalar(Vector64<double> left, Vector64<double> right)`

Performs 'MinScalar' operation.

```csharp
private Vector64<double> MinScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MinScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MinScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.minscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
MinScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MinScalar", "Performs 'MinScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingSaturateHighScalarResult = Dummy_MultiplyDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingSaturateHighScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 22. MultiplyDoublingSaturateHighScalar

`Vector64<short> MultiplyDoublingSaturateHighScalar(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingSaturateHighScalar' operation.

```csharp
private Vector64<short> MultiplyDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingSaturateHighScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingSaturateHighScalar(Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingsaturatehighscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingSaturateHighScalar", "Performs 'MultiplyDoublingSaturateHighScalar' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingScalarBySelectedScalarSaturateHighResult = Dummy_MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingScalarBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 23. MultiplyDoublingScalarBySelectedScalarSaturateHigh

`Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingScalarBySelectedScalarSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingScalarBySelectedScalarSaturateHigh(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingscalarbyselectedscalarsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingScalarBySelectedScalarSaturateHigh", "Performs 'MultiplyDoublingScalarBySelectedScalarSaturateHigh' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningAndAddSaturateScalarResult = Dummy_MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningAndAddSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 24. MultiplyDoublingWideningAndAddSaturateScalar

`Vector64<int> MultiplyDoublingWideningAndAddSaturateScalar(Vector64<int> addend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningAndAddSaturateScalar' operation.

```csharp
private Vector64<int> MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndAddSaturateScalar(addend, left, right);
}}
// addend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> MultiplyDoublingWideningAndAddSaturateScalar(Vector64<long> addend, Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningandaddsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64int_0, Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningAndAddSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningAndAddSaturateScalar", "Performs 'MultiplyDoublingWideningAndAddSaturateScalar' operation", Vector64int_0, Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningAndSubtractSaturateScalarResult = Dummy_MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningAndSubtractSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 25. MultiplyDoublingWideningAndSubtractSaturateScalar

`Vector64<int> MultiplyDoublingWideningAndSubtractSaturateScalar(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningAndSubtractSaturateScalar' operation.

```csharp
private Vector64<int> MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningAndSubtractSaturateScalar(minuend, left, right);
}}
// minuend = {0}
// left = {1}
// right = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> MultiplyDoublingWideningAndSubtractSaturateScalar(Vector64<long> minuend, Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningandsubtractsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64int_0, Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningAndSubtractSaturateScalarTest(Vector64int_0, Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningAndSubtractSaturateScalar", "Performs 'MultiplyDoublingWideningAndSubtractSaturateScalar' operation", Vector64int_0, Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateScalarResult = Dummy_MultiplyDoublingWideningSaturateScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyDoublingWideningSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 26. MultiplyDoublingWideningSaturateScalar

`Vector64<int> MultiplyDoublingWideningSaturateScalar(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyDoublingWideningSaturateScalar' operation.

```csharp
private Vector64<int> MultiplyDoublingWideningSaturateScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<long> MultiplyDoublingWideningSaturateScalar(Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyDoublingWideningSaturateScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateScalar", "Performs 'MultiplyDoublingWideningSaturateScalar' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningSaturateScalarBySelectedScalarResult = Dummy_MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningSaturateScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 27. MultiplyDoublingWideningSaturateScalarBySelectedScalar

`Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningSaturateScalarBySelectedScalar' operation.

```csharp
private Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningSaturateScalarBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningSaturateScalarBySelectedScalar(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningsaturatescalarbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingWideningSaturateScalarBySelectedScalarTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningSaturateScalarBySelectedScalar", "Performs 'MultiplyDoublingWideningSaturateScalarBySelectedScalar' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateResult = Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 28. MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate

`Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate' operation.

```csharp
private Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64<int> addend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(addend, left, right, rightIndex);
}}
// addend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<int> addend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<long> addend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate(Vector64<long> addend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningscalarbyselectedscalarandaddsaturate?view=net-5.0).

Assembly generated:

```
", Vector64int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate", "Performs 'MultiplyDoublingWideningScalarBySelectedScalarAndAddSaturate' operation", Vector64int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateResult = Dummy_MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 29. MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate

`Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate' operation.

```csharp
private Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64<int> minuend, Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(minuend, left, right, rightIndex);
}}
// minuend = {0}
// left = {1}
// right = {2}
// rightIndex = {3}
// Result = {4}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<int> minuend, Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<long> minuend, Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<long> MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate(Vector64<long> minuend, Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplydoublingwideningscalarbyselectedscalarandsubtractsaturate?view=net-5.0).

Assembly generated:

```
", Vector64int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturateTest(Vector64int_0, Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate", "Performs 'MultiplyDoublingWideningScalarBySelectedScalarAndSubtractSaturate' operation", Vector64int_0, Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyExtendedResult = Dummy_MultiplyExtendedTest(Vector64float_0, Vector64float_1);
apiResult = MultiplyExtendedResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 30. MultiplyExtended

`Vector64<float> MultiplyExtended(Vector64<float> left, Vector64<float> right)`

Performs 'MultiplyExtended' operation.

```csharp
private Vector64<float> MultiplyExtendedTest(Vector64<float> left, Vector64<float> right)
{{
  return AdvSimd.Arm64.MultiplyExtended(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> MultiplyExtended(Vector128<double> left, Vector128<double> right)
Vector128<float> MultiplyExtended(Vector128<float> left, Vector128<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextended?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, apiResult);

try {
MultiplyExtendedTest(Vector64float_0, Vector64float_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyExtended", "Performs 'MultiplyExtended' operation", Vector64float_0, Vector64float_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyExtendedByScalarResult = Dummy_MultiplyExtendedByScalarTest(Vector128double_0, Vector64double_0);
apiResult = MultiplyExtendedByScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 31. MultiplyExtendedByScalar

`Vector128<double> MultiplyExtendedByScalar(Vector128<double> left, Vector64<double> right)`

Performs 'MultiplyExtendedByScalar' operation.

```csharp
private Vector128<double> MultiplyExtendedByScalarTest(Vector128<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MultiplyExtendedByScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```



See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedbyscalar?view=net-5.0).

Assembly generated:

```
", Vector128double_0, Vector64double_0, apiResult);

try {
MultiplyExtendedByScalarTest(Vector128double_0, Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyExtendedByScalar", "Performs 'MultiplyExtendedByScalar' operation", Vector128double_0, Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyExtendedBySelectedScalarResult = Dummy_MultiplyExtendedBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);
apiResult = MultiplyExtendedBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 32. MultiplyExtendedBySelectedScalar

`Vector64<float> MultiplyExtendedBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)`

Performs 'MultiplyExtendedBySelectedScalar' operation.

```csharp
private Vector64<float> MultiplyExtendedBySelectedScalarTest(Vector64<float> left, Vector64<float> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyExtendedBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MultiplyExtendedBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)
Vector128<double> MultiplyExtendedBySelectedScalar(Vector128<double> left, Vector128<double> right, byte rightIndex)
Vector128<float> MultiplyExtendedBySelectedScalar(Vector128<float> left, Vector64<float> right, byte rightIndex)
Vector128<float> MultiplyExtendedBySelectedScalar(Vector128<float> left, Vector128<float> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64float_0, Vector64float_1, byte_0, apiResult);

try {
MultiplyExtendedBySelectedScalarTest(Vector64float_0, Vector64float_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyExtendedBySelectedScalar", "Performs 'MultiplyExtendedBySelectedScalar' operation", Vector64float_0, Vector64float_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyExtendedScalarResult = Dummy_MultiplyExtendedScalarTest(Vector64double_0, Vector64double_1);
apiResult = MultiplyExtendedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 33. MultiplyExtendedScalar

`Vector64<double> MultiplyExtendedScalar(Vector64<double> left, Vector64<double> right)`

Performs 'MultiplyExtendedScalar' operation.

```csharp
private Vector64<double> MultiplyExtendedScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.MultiplyExtendedScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MultiplyExtendedScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
MultiplyExtendedScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyExtendedScalar", "Performs 'MultiplyExtendedScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyExtendedScalarBySelectedScalarResult = Dummy_MultiplyExtendedScalarBySelectedScalarTest(Vector64double_0, Vector128double_0, byte_0);
apiResult = MultiplyExtendedScalarBySelectedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 34. MultiplyExtendedScalarBySelectedScalar

`Vector64<double> MultiplyExtendedScalarBySelectedScalar(Vector64<double> left, Vector128<double> right, byte rightIndex)`

Performs 'MultiplyExtendedScalarBySelectedScalar' operation.

```csharp
private Vector64<double> MultiplyExtendedScalarBySelectedScalarTest(Vector64<double> left, Vector128<double> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyExtendedScalarBySelectedScalar(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> MultiplyExtendedScalarBySelectedScalar(Vector64<float> left, Vector64<float> right, byte rightIndex)
Vector64<float> MultiplyExtendedScalarBySelectedScalar(Vector64<float> left, Vector128<float> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyextendedscalarbyselectedscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector128double_0, byte_0, apiResult);

try {
MultiplyExtendedScalarBySelectedScalarTest(Vector64double_0, Vector128double_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyExtendedScalarBySelectedScalar", "Performs 'MultiplyExtendedScalarBySelectedScalar' operation", Vector64double_0, Vector128double_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingSaturateHighScalarResult = Dummy_MultiplyRoundedDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);
apiResult = MultiplyRoundedDoublingSaturateHighScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 35. MultiplyRoundedDoublingSaturateHighScalar

`Vector64<short> MultiplyRoundedDoublingSaturateHighScalar(Vector64<short> left, Vector64<short> right)`

Performs 'MultiplyRoundedDoublingSaturateHighScalar' operation.

```csharp
private Vector64<short> MultiplyRoundedDoublingSaturateHighScalarTest(Vector64<short> left, Vector64<short> right)
{{
  return AdvSimd.Arm64.MultiplyRoundedDoublingSaturateHighScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> MultiplyRoundedDoublingSaturateHighScalar(Vector64<int> left, Vector64<int> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyroundeddoublingsaturatehighscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, apiResult);

try {
MultiplyRoundedDoublingSaturateHighScalarTest(Vector64short_0, Vector64short_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyRoundedDoublingSaturateHighScalar", "Performs 'MultiplyRoundedDoublingSaturateHighScalar' operation", Vector64short_0, Vector64short_1, apiResult);
// ----------------------------------------------------------------

try {
var MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighResult = Dummy_MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);
apiResult = MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 36. MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh

`Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector64<short> right, byte rightIndex)`

Performs 'MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh' operation.

```csharp
private Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64<short> left, Vector64<short> right, byte rightIndex)
{{
  return AdvSimd.Arm64.MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(left, right, rightIndex);
}}
// left = {0}
// right = {1}
// rightIndex = {2}
// Result = {3}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<short> left, Vector128<short> right, byte rightIndex)
Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector64<int> right, byte rightIndex)
Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh(Vector64<int> left, Vector128<int> right, byte rightIndex)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.multiplyroundeddoublingscalarbyselectedscalarsaturatehigh?view=net-5.0).

Assembly generated:

```
", Vector64short_0, Vector64short_1, byte_0, apiResult);

try {
MultiplyRoundedDoublingScalarBySelectedScalarSaturateHighTest(Vector64short_0, Vector64short_1, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh", "Performs 'MultiplyRoundedDoublingScalarBySelectedScalarSaturateHigh' operation", Vector64short_0, Vector64short_1, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var NegateSaturateScalarResult = Dummy_NegateSaturateScalarTest(Vector64short_0);
apiResult = NegateSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 37. NegateSaturateScalar

`Vector64<short> NegateSaturateScalar(Vector64<short> value)`

Performs 'NegateSaturateScalar' operation.

```csharp
private Vector64<short> NegateSaturateScalarTest(Vector64<short> value)
{{
  return AdvSimd.Arm64.NegateSaturateScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> NegateSaturateScalar(Vector64<int> value)
Vector64<long> NegateSaturateScalar(Vector64<long> value)
Vector64<sbyte> NegateSaturateScalar(Vector64<sbyte> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.negatesaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, apiResult);

try {
NegateSaturateScalarTest(Vector64short_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("NegateSaturateScalar", "Performs 'NegateSaturateScalar' operation", Vector64short_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalEstimateScalarResult = Dummy_ReciprocalEstimateScalarTest(Vector64double_0);
apiResult = ReciprocalEstimateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 38. ReciprocalEstimateScalar

`Vector64<double> ReciprocalEstimateScalar(Vector64<double> value)`

Performs 'ReciprocalEstimateScalar' operation.

```csharp
private Vector64<double> ReciprocalEstimateScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ReciprocalEstimateScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalEstimateScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalestimatescalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ReciprocalEstimateScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalEstimateScalar", "Performs 'ReciprocalEstimateScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalExponentScalarResult = Dummy_ReciprocalExponentScalarTest(Vector64double_0);
apiResult = ReciprocalExponentScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 39. ReciprocalExponentScalar

`Vector64<double> ReciprocalExponentScalar(Vector64<double> value)`

Performs 'ReciprocalExponentScalar' operation.

```csharp
private Vector64<double> ReciprocalExponentScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ReciprocalExponentScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalExponentScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalexponentscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ReciprocalExponentScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalExponentScalar", "Performs 'ReciprocalExponentScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalSquareRootEstimateScalarResult = Dummy_ReciprocalSquareRootEstimateScalarTest(Vector64double_0);
apiResult = ReciprocalSquareRootEstimateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 40. ReciprocalSquareRootEstimateScalar

`Vector64<double> ReciprocalSquareRootEstimateScalar(Vector64<double> value)`

Performs 'ReciprocalSquareRootEstimateScalar' operation.

```csharp
private Vector64<double> ReciprocalSquareRootEstimateScalarTest(Vector64<double> value)
{{
  return AdvSimd.Arm64.ReciprocalSquareRootEstimateScalar(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalSquareRootEstimateScalar(Vector64<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootestimatescalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, apiResult);

try {
ReciprocalSquareRootEstimateScalarTest(Vector64double_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalSquareRootEstimateScalar", "Performs 'ReciprocalSquareRootEstimateScalar' operation", Vector64double_0, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalSquareRootStepScalarResult = Dummy_ReciprocalSquareRootStepScalarTest(Vector64double_0, Vector64double_1);
apiResult = ReciprocalSquareRootStepScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 41. ReciprocalSquareRootStepScalar

`Vector64<double> ReciprocalSquareRootStepScalar(Vector64<double> left, Vector64<double> right)`

Performs 'ReciprocalSquareRootStepScalar' operation.

```csharp
private Vector64<double> ReciprocalSquareRootStepScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.ReciprocalSquareRootStepScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalSquareRootStepScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalsquarerootstepscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
ReciprocalSquareRootStepScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalSquareRootStepScalar", "Performs 'ReciprocalSquareRootStepScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var ReciprocalStepScalarResult = Dummy_ReciprocalStepScalarTest(Vector64double_0, Vector64double_1);
apiResult = ReciprocalStepScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 42. ReciprocalStepScalar

`Vector64<double> ReciprocalStepScalar(Vector64<double> left, Vector64<double> right)`

Performs 'ReciprocalStepScalar' operation.

```csharp
private Vector64<double> ReciprocalStepScalarTest(Vector64<double> left, Vector64<double> right)
{{
  return AdvSimd.Arm64.ReciprocalStepScalar(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<float> ReciprocalStepScalar(Vector64<float> left, Vector64<float> right)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reciprocalstepscalar?view=net-5.0).

Assembly generated:

```
", Vector64double_0, Vector64double_1, apiResult);

try {
ReciprocalStepScalarTest(Vector64double_0, Vector64double_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReciprocalStepScalar", "Performs 'ReciprocalStepScalar' operation", Vector64double_0, Vector64double_1, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateScalarResult = Dummy_ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64int_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 43. ShiftRightArithmeticNarrowingSaturateScalar

`Vector64<short> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<int> value, byte count)`

Performs 'ShiftRightArithmeticNarrowingSaturateScalar' operation.

```csharp
private Vector64<short> ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticNarrowingSaturateScalar(Vector64<short> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticnarrowingsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64int_0, byte_0, apiResult);

try {
ShiftRightArithmeticNarrowingSaturateScalarTest(Vector64int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticNarrowingSaturateScalar", "Performs 'ShiftRightArithmeticNarrowingSaturateScalar' operation", Vector64int_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticNarrowingSaturateUnsignedScalarResult = Dummy_ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticNarrowingSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 44. ShiftRightArithmeticNarrowingSaturateUnsignedScalar

`Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<short> value, byte count)`

Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedScalar' operation.

```csharp
private Vector64<byte> ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticNarrowingSaturateUnsignedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<int> value, byte count)
Vector64<uint> ShiftRightArithmeticNarrowingSaturateUnsignedScalar(Vector64<long> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticnarrowingsaturateunsignedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, byte_0, apiResult);

try {
ShiftRightArithmeticNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticNarrowingSaturateUnsignedScalar", "Performs 'ShiftRightArithmeticNarrowingSaturateUnsignedScalar' operation", Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateScalarResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64int_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 45. ShiftRightArithmeticRoundedNarrowingSaturateScalar

`Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<int> value, byte count)`

Performs 'ShiftRightArithmeticRoundedNarrowingSaturateScalar' operation.

```csharp
private Vector64<short> ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64<int> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<int> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<long> value, byte count)
Vector64<sbyte> ShiftRightArithmeticRoundedNarrowingSaturateScalar(Vector64<short> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticroundednarrowingsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64int_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedNarrowingSaturateScalarTest(Vector64int_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedNarrowingSaturateScalar", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateScalar' operation", Vector64int_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarResult = Dummy_ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);
apiResult = ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 46. ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar

`Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<short> value, byte count)`

Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar' operation.

```csharp
private Vector64<byte> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64<short> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<ushort> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<int> value, byte count)
Vector64<uint> ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar(Vector64<long> value, byte count)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightarithmeticroundednarrowingsaturateunsignedscalar?view=net-5.0).

Assembly generated:

```
", Vector64short_0, byte_0, apiResult);

try {
ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalarTest(Vector64short_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar", "Performs 'ShiftRightArithmeticRoundedNarrowingSaturateUnsignedScalar' operation", Vector64short_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalNarrowingSaturateScalarResult = Dummy_ShiftRightLogicalNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);
apiResult = ShiftRightLogicalNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 47. ShiftRightLogicalNarrowingSaturateScalar

`Vector64<byte> ShiftRightLogicalNarrowingSaturateScalar(Vector64<ushort> value, byte count)`

Performs 'ShiftRightLogicalNarrowingSaturateScalar' operation.

```csharp
private Vector64<byte> ShiftRightLogicalNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightLogicalNarrowingSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightlogicalnarrowingsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalNarrowingSaturateScalar", "Performs 'ShiftRightLogicalNarrowingSaturateScalar' operation", Vector64ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var ShiftRightLogicalRoundedNarrowingSaturateScalarResult = Dummy_ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);
apiResult = ShiftRightLogicalRoundedNarrowingSaturateScalarResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 48. ShiftRightLogicalRoundedNarrowingSaturateScalar

`Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalar(Vector64<ushort> value, byte count)`

Performs 'ShiftRightLogicalRoundedNarrowingSaturateScalar' operation.

```csharp
private Vector64<byte> ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64<ushort> value, byte count)
{{
  return AdvSimd.Arm64.ShiftRightLogicalRoundedNarrowingSaturateScalar(value, count);
}}
// value = {0}
// count = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.shiftrightlogicalroundednarrowingsaturatescalar?view=net-5.0).

Assembly generated:

```
", Vector64ushort_0, byte_0, apiResult);

try {
ShiftRightLogicalRoundedNarrowingSaturateScalarTest(Vector64ushort_0, byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ShiftRightLogicalRoundedNarrowingSaturateScalar", "Performs 'ShiftRightLogicalRoundedNarrowingSaturateScalar' operation", Vector64ushort_0, byte_0, apiResult);
// ----------------------------------------------------------------

try {
var SqrtResult = Dummy_SqrtTest(Vector64float_0);
apiResult = SqrtResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 49. Sqrt

`Vector64<float> Sqrt(Vector64<float> value)`

Performs 'Sqrt' operation.

```csharp
private Vector64<float> SqrtTest(Vector64<float> value)
{{
  return AdvSimd.Arm64.Sqrt(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector128<double> Sqrt(Vector128<double> value)
Vector128<float> Sqrt(Vector128<float> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.sqrt?view=net-5.0).

Assembly generated:

```
", Vector64float_0, apiResult);

try {
SqrtTest(Vector64float_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("Sqrt", "Performs 'Sqrt' operation", Vector64float_0, apiResult);
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
StorePairTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 50. StorePair

`void StorePair(byte* address, Vector64<byte> value1, Vector64<byte> value2)`

Performs 'StorePair' operation.

```csharp
private void StorePairTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{{
  AdvSimd.Arm64.StorePair(address, value1, value2);
}}
// address = {0}
// value1 = {1}
// value2 = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepair?view=net-5.0).

Assembly generated:

```
", "<address>", Vector64byte_0, Vector64byte_1);

try {
StorePairTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("StorePair", "Performs 'StorePair' operation", "<address>", Vector64byte_0, Vector64byte_1);
// ----------------------------------------------------------------
fixed (byte* bytePtr_0 = byteArray)
{

try {
StorePairNonTemporalTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 51. StorePairNonTemporal

`void StorePairNonTemporal(byte* address, Vector64<byte> value1, Vector64<byte> value2)`

Performs 'StorePairNonTemporal' operation.

```csharp
private void StorePairNonTemporalTest(byte* address, Vector64<byte> value1, Vector64<byte> value2)
{{
  AdvSimd.Arm64.StorePairNonTemporal(address, value1, value2);
}}
// address = {0}
// value1 = {1}
// value2 = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepairnontemporal?view=net-5.0).

Assembly generated:

```
", "<address>", Vector64byte_0, Vector64byte_1);

try {
StorePairNonTemporalTest(bytePtr_0, Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("StorePairNonTemporal", "Performs 'StorePairNonTemporal' operation", "<address>", Vector64byte_0, Vector64byte_1);
// ----------------------------------------------------------------
fixed (int* intPtr_0 = intArray)
{

try {
StorePairScalarTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 52. StorePairScalar

`void StorePairScalar(int* address, Vector64<int> value1, Vector64<int> value2)`

Performs 'StorePairScalar' operation.

```csharp
private void StorePairScalarTest(int* address, Vector64<int> value1, Vector64<int> value2)
{{
  AdvSimd.Arm64.StorePairScalar(address, value1, value2);
}}
// address = {0}
// value1 = {1}
// value2 = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
void StorePairScalar(float* address, Vector64<float> value1, Vector64<float> value2)
void StorePairScalar(uint* address, Vector64<uint> value1, Vector64<uint> value2)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepairscalar?view=net-5.0).

Assembly generated:

```
", "<address>", Vector64int_0, Vector64int_1);

try {
StorePairScalarTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("StorePairScalar", "Performs 'StorePairScalar' operation", "<address>", Vector64int_0, Vector64int_1);
// ----------------------------------------------------------------
fixed (int* intPtr_0 = intArray)
{

try {
StorePairScalarNonTemporalTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 53. StorePairScalarNonTemporal

`void StorePairScalarNonTemporal(int* address, Vector64<int> value1, Vector64<int> value2)`

Performs 'StorePairScalarNonTemporal' operation.

```csharp
private void StorePairScalarNonTemporalTest(int* address, Vector64<int> value1, Vector64<int> value2)
{{
  AdvSimd.Arm64.StorePairScalarNonTemporal(address, value1, value2);
}}
// address = {0}
// value1 = {1}
// value2 = {2}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
void StorePairScalarNonTemporal(float* address, Vector64<float> value1, Vector64<float> value2)
void StorePairScalarNonTemporal(uint* address, Vector64<uint> value1, Vector64<uint> value2)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.storepairscalarnontemporal?view=net-5.0).

Assembly generated:

```
", "<address>", Vector64int_0, Vector64int_1);

try {
StorePairScalarNonTemporalTest(intPtr_0, Vector64int_0, Vector64int_1);

} catch (Exception) {
   apiResult = "TODO";
}

}
LogInCsv("StorePairScalarNonTemporal", "Performs 'StorePairScalarNonTemporal' operation", "<address>", Vector64int_0, Vector64int_1);
// ----------------------------------------------------------------

try {
var ReverseElementBitsResult = Dummy_ReverseElementBitsTest(Vector64byte_0);
apiResult = ReverseElementBitsResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 54. ReverseElementBits

`Vector64<byte> ReverseElementBits(Vector64<byte> value)`

Performs 'ReverseElementBits' operation.

```csharp
private Vector64<byte> ReverseElementBitsTest(Vector64<byte> value)
{{
  return AdvSimd.Arm64.ReverseElementBits(value);
}}
// value = {0}
// Result = {1}

```

Similar APIs that operate on different sizes:

```csharp
// class System.Runtime.Intrinisics.AdvSimd.Arm64
Vector64<sbyte> ReverseElementBits(Vector64<sbyte> value)
Vector128<byte> ReverseElementBits(Vector128<byte> value)
Vector128<sbyte> ReverseElementBits(Vector128<sbyte> value)
```


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.reverseelementbits?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, apiResult);

try {
ReverseElementBitsTest(Vector64byte_0);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ReverseElementBits", "Performs 'ReverseElementBits' operation", Vector64byte_0, apiResult);
// ----------------------------------------------------------------

try {
var TransposeEvenResult = Dummy_TransposeEvenTest(Vector64byte_0, Vector64byte_1);
apiResult = TransposeEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 55. TransposeEven

`Vector64<byte> TransposeEven(Vector64<byte> left, Vector64<byte> right)`

Performs 'TransposeEven' operation.

```csharp
private Vector64<byte> TransposeEvenTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.TransposeEven(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.transposeeven?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
TransposeEvenTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("TransposeEven", "Performs 'TransposeEven' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var TransposeOddResult = Dummy_TransposeOddTest(Vector64byte_0, Vector64byte_1);
apiResult = TransposeOddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 56. TransposeOdd

`Vector64<byte> TransposeOdd(Vector64<byte> left, Vector64<byte> right)`

Performs 'TransposeOdd' operation.

```csharp
private Vector64<byte> TransposeOddTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.TransposeOdd(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.transposeodd?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
TransposeOddTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("TransposeOdd", "Performs 'TransposeOdd' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var UnzipEvenResult = Dummy_UnzipEvenTest(Vector64byte_0, Vector64byte_1);
apiResult = UnzipEvenResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 57. UnzipEven

`Vector64<byte> UnzipEven(Vector64<byte> left, Vector64<byte> right)`

Performs 'UnzipEven' operation.

```csharp
private Vector64<byte> UnzipEvenTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.UnzipEven(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.unzipeven?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
UnzipEvenTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("UnzipEven", "Performs 'UnzipEven' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var UnzipOddResult = Dummy_UnzipOddTest(Vector64byte_0, Vector64byte_1);
apiResult = UnzipOddResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 58. UnzipOdd

`Vector64<byte> UnzipOdd(Vector64<byte> left, Vector64<byte> right)`

Performs 'UnzipOdd' operation.

```csharp
private Vector64<byte> UnzipOddTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.UnzipOdd(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.unzipodd?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
UnzipOddTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("UnzipOdd", "Performs 'UnzipOdd' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var ZipHighResult = Dummy_ZipHighTest(Vector64byte_0, Vector64byte_1);
apiResult = ZipHighResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 59. ZipHigh

`Vector64<byte> ZipHigh(Vector64<byte> left, Vector64<byte> right)`

Performs 'ZipHigh' operation.

```csharp
private Vector64<byte> ZipHighTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.ZipHigh(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.ziphigh?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
ZipHighTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ZipHigh", "Performs 'ZipHigh' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

try {
var ZipLowResult = Dummy_ZipLowTest(Vector64byte_0, Vector64byte_1);
apiResult = ZipLowResult.ToString();
} catch (Exception) {
   apiResult = "TODO";
}

Console.WriteLine(
@"
```
------------------------------------------------

### 60. ZipLow

`Vector64<byte> ZipLow(Vector64<byte> left, Vector64<byte> right)`

Performs 'ZipLow' operation.

```csharp
private Vector64<byte> ZipLowTest(Vector64<byte> left, Vector64<byte> right)
{{
  return AdvSimd.Arm64.ZipLow(left, right);
}}
// left = {0}
// right = {1}
// Result = {2}

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


See MSDN reference [here](https://docs.microsoft.com/en-us/dotNet/api/system.runtime.intrinsics.arm.advsimd.arm64.ziplow?view=net-5.0).

Assembly generated:

```
", Vector64byte_0, Vector64byte_1, apiResult);

try {
ZipLowTest(Vector64byte_0, Vector64byte_1);

} catch (Exception) {
   apiResult = "TODO";
}

LogInCsv("ZipLow", "Performs 'ZipLow' operation", Vector64byte_0, Vector64byte_1, apiResult);
// ----------------------------------------------------------------

}
}