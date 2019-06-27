using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for EqualityTestingExtension</summary>
    [TestClass]
    [PexClass(typeof(EqualityTestingExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EqualityTestingExtensionTest
    {

		/// <summary>Test stub for HasNoValue(String)</summary>
		[PexMethod]
		public bool HasNoValueTest(string value)
		{
			bool result = EqualityTestingExtension.HasNoValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.HasNoValueTest(String)
		}

		/// <summary>Test stub for HasNonwhiteSpaceValue(String)</summary>
		[PexMethod]
		public bool HasNonwhiteSpaceValueTest(string value)
		{
			bool result = EqualityTestingExtension.HasNonwhiteSpaceValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.HasNonwhiteSpaceValueTest(String)
		}

		/// <summary>Test stub for HasNullOrWhiteSpaceValue(String)</summary>
		[PexMethod]
		public bool HasNullOrWhiteSpaceValueTest(string value)
		{
			bool result = EqualityTestingExtension.HasNullOrWhiteSpaceValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.HasNullOrWhiteSpaceValueTest(String)
		}

		/// <summary>Test stub for HasValue(String)</summary>
		[PexMethod]
		public bool HasValueTest(string value)
		{
			bool result = EqualityTestingExtension.HasValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.HasValueTest(String)
		}

		/// <summary>Test stub for IsApproximatelyDefaultValue(Double)</summary>
		[PexMethod]
		public bool IsApproximatelyDefaultValueTest(double value)
		{
			bool result = EqualityTestingExtension.IsApproximatelyDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyDefaultValueTest(Double)
		}

		/// <summary>Test stub for IsApproximatelyDefaultValue(Single)</summary>
		[PexMethod]
		public bool IsApproximatelyDefaultValueTest01(float value)
		{
			bool result = EqualityTestingExtension.IsApproximatelyDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyDefaultValueTest01(Single)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest(double valueA, double valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest(Double, Double)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest01(double? valueA, double valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest01(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest02(double valueA, double? valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest02(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest03(double? valueA, double? valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest03(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest04(float valueA, float valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest04(Single, Single)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest05(float? valueA, float valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest05(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest06(float valueA, float? valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest06(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsApproximatelyEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsApproximatelyEqualTest07(float? valueA, float? valueB)
		{
			bool result = EqualityTestingExtension.IsApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsApproximatelyEqualTest07(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsDefault(!!0)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public bool IsDefaultTest<T>(T value)
			where T : class
		{
			bool result = EqualityTestingExtension.IsDefault<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultTest(!!0)
		}

		/// <summary>Test stub for IsDefaultValue(DateTime)</summary>
		[PexMethod]
		public bool IsDefaultValueTest(DateTime value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest(DateTime)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest01(DateTime? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest01(Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsDefaultValue(Guid)</summary>
		[PexMethod]
		public bool IsDefaultValueTest02(Guid value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest02(Guid)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Guid&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest03(Guid? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest03(Nullable`1<Guid>)
		}

		/// <summary>Test stub for IsDefaultValue(Byte)</summary>
		[PexMethod]
		public bool IsDefaultValueTest04(byte value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest04(Byte)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest05(byte? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest05(Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsDefaultValue(Char)</summary>
		[PexMethod]
		public bool IsDefaultValueTest06(char value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest06(Char)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Char&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest07(char? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest07(Nullable`1<Char>)
		}

		/// <summary>Test stub for IsDefaultValue(Decimal)</summary>
		[PexMethod]
		public bool IsDefaultValueTest08(decimal value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest08(Decimal)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest09(decimal? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest09(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest10(double? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest10(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest11(float? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest11(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsDefaultValue(Int32)</summary>
		[PexMethod]
		public bool IsDefaultValueTest12(int value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest12(Int32)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest13(int? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest13(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsDefaultValue(Int64)</summary>
		[PexMethod]
		public bool IsDefaultValueTest14(long value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest14(Int64)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest15(long? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest15(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsDefaultValue(SByte)</summary>
		[PexMethod]
		public bool IsDefaultValueTest16(sbyte value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest16(SByte)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest17(sbyte? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest17(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsDefaultValue(Int16)</summary>
		[PexMethod]
		public bool IsDefaultValueTest18(short value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest18(Int16)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest19(short? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest19(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsDefaultValue(UInt32)</summary>
		[PexMethod]
		public bool IsDefaultValueTest20(uint value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest20(UInt32)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest21(uint? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest21(Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsDefaultValue(UInt64)</summary>
		[PexMethod]
		public bool IsDefaultValueTest22(ulong value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest22(UInt64)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest23(ulong? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest23(Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsDefaultValue(UInt16)</summary>
		[PexMethod]
		public bool IsDefaultValueTest24(ushort value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest24(UInt16)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsDefaultValueTest25(ushort? value)
		{
			bool result = EqualityTestingExtension.IsDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest25(Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsDefaultValue(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsDefaultValueTest26<T>(T value)
			where T : struct
		{
			bool result = EqualityTestingExtension.IsDefaultValue<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest26(!!0)
		}

		/// <summary>Test stub for IsDefaultValue(Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsDefaultValueTest27<T>(T? value)
			where T : struct
		{
			bool result = EqualityTestingExtension.IsDefaultValue<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsDefaultValueTest27(Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsNotApproximatelyDefaultValue(Double)</summary>
		[PexMethod]
		public bool IsNotApproximatelyDefaultValueTest(double value)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyDefaultValueTest(Double)
		}

		/// <summary>Test stub for IsNotApproximatelyDefaultValue(Single)</summary>
		[PexMethod]
		public bool IsNotApproximatelyDefaultValueTest01(float value)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyDefaultValueTest01(Single)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest(double valueA, double valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest(Double, Double)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest01(double? valueA, double valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest01(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest02(double valueA, double? valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest02(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest03(double? valueA, double? valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest03(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest04(float valueA, float valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest04(Single, Single)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest05(float? valueA, float valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest05(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest06(float valueA, float? valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest06(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsNotApproximatelyEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsNotApproximatelyEqualTest07(float? valueA, float? valueB)
		{
			bool result = EqualityTestingExtension.IsNotApproximatelyEqual(valueA, valueB);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotApproximatelyEqualTest07(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsNotDefault(!!0)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public bool IsNotDefaultTest<T>(T value)
			where T : class
		{
			bool result = EqualityTestingExtension.IsNotDefault<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultTest(!!0)
		}

		/// <summary>Test stub for IsNotDefaultValue(DateTime)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest(DateTime value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest(DateTime)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest01(DateTime? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest01(Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Guid)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest02(Guid value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest02(Guid)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Guid&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest03(Guid? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest03(Nullable`1<Guid>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Byte)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest04(byte value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest04(Byte)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest05(byte? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest05(Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Char)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest06(char value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest06(Char)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Char&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest07(char? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest07(Nullable`1<Char>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Decimal)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest08(decimal value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest08(Decimal)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest09(decimal? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest09(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest10(double? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest10(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest11(float? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest11(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Int32)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest12(int value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest12(Int32)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest13(int? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest13(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Int64)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest14(long value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest14(Int64)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest15(long? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest15(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsNotDefaultValue(SByte)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest16(sbyte value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest16(SByte)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest17(sbyte? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest17(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsNotDefaultValue(Int16)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest18(short value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest18(Int16)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest19(short? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest19(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsNotDefaultValue(UInt32)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest20(uint value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest20(UInt32)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest21(uint? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest21(Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsNotDefaultValue(UInt64)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest22(ulong value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest22(UInt64)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest23(ulong? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest23(Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsNotDefaultValue(UInt16)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest24(ushort value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest24(UInt16)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsNotDefaultValueTest25(ushort? value)
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest25(Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsNotDefaultValue(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotDefaultValueTest26<T>(T value)
			where T : struct
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest26(!!0)
		}

		/// <summary>Test stub for IsNotDefaultValue(Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotDefaultValueTest27<T>(T? value)
			where T : struct
		{
			bool result = EqualityTestingExtension.IsNotDefaultValue<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotDefaultValueTest27(Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsNotNull(!!0)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public bool IsNotNullTest<T>(T value)
		{
			bool result = EqualityTestingExtension.IsNotNull<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotNullTest(!!0)
		}

		/// <summary>Test stub for IsNotNull(Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotNullTest01<T>(T? value)
			where T : struct
		{
			bool result = EqualityTestingExtension.IsNotNull<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNotNullTest01(Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsNull(!!0)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public bool IsNullTest<T>(T value)
		{
			bool result = EqualityTestingExtension.IsNull<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNullTest(!!0)
		}

		/// <summary>Test stub for IsNull(Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNullTest01<T>(T? value)
			where T : struct
		{
			bool result = EqualityTestingExtension.IsNull<T>(value);
			return result;
			// TODO: add assertions to method EqualityTestingExtensionTest.IsNullTest01(Nullable`1<!!0>)
		}

		/// <summary>Test stub for RequireIsNotNull(!!0)</summary>
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public void RequireIsNotNullTest<T>(T value)
		{
			EqualityTestingExtension.RequireIsNotNull<T>(value);
			// TODO: add assertions to method EqualityTestingExtensionTest.RequireIsNotNullTest(!!0)
		}

		/// <summary>Test stub for RequireIsNull(Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public void RequireIsNullTest<T>(T? value)
			where T : struct
		{
			EqualityTestingExtension.RequireIsNull<T>(value);
			// TODO: add assertions to method EqualityTestingExtensionTest.RequireIsNullTest(Nullable`1<!!0>)
		}
	}
}
