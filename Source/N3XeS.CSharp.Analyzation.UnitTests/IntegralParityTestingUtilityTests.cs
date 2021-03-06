// <copyright file="IntegralParityTestingUtilityTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for IntegralParityTestingUtility</summary>
    [TestClass]
    [PexClass(typeof(IntegralParityTestingUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IntegralParityTestingUtilityTests
    {

		/// <summary>Test stub for IsEven(Byte)</summary>
		[PexMethod]
		public bool IsEvenTest(byte value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest(Byte)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest01(byte? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest01(Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsEven(Decimal)</summary>
		[PexMethod]
		public bool IsEvenTest02(decimal value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest02(Decimal)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest03(decimal? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest03(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsEven(Int32)</summary>
		[PexMethod]
		public bool IsEvenTest04(int value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest04(Int32)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest05(int? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest05(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsEven(Int64)</summary>
		[PexMethod]
		public bool IsEvenTest06(long value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest06(Int64)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest07(long? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest07(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsEven(SByte)</summary>
		[PexMethod]
		public bool IsEvenTest08(sbyte value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest08(SByte)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest09(sbyte? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest09(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsEven(Int16)</summary>
		[PexMethod]
		public bool IsEvenTest10(short value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest10(Int16)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest11(short? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest11(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsEven(UInt32)</summary>
		[PexMethod]
		public bool IsEvenTest12(uint value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest12(UInt32)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest13(uint? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest13(Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsEven(UInt64)</summary>
		[PexMethod]
		public bool IsEvenTest14(ulong value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest14(UInt64)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest15(ulong? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest15(Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsEven(UInt16)</summary>
		[PexMethod]
		public bool IsEvenTest16(ushort value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest16(UInt16)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest17(ushort? value)
		{
			bool result = IntegralParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsEvenTest17(Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOdd(Byte)</summary>
		[PexMethod]
		public bool IsOddTest(byte value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest(Byte)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOddTest01(byte? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest01(Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOdd(Decimal)</summary>
		[PexMethod]
		public bool IsOddTest02(decimal value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest02(Decimal)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOddTest03(decimal? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest03(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOdd(Int32)</summary>
		[PexMethod]
		public bool IsOddTest04(int value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest04(Int32)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOddTest05(int? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest05(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOdd(Int64)</summary>
		[PexMethod]
		public bool IsOddTest06(long value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest06(Int64)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOddTest07(long? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest07(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOdd(SByte)</summary>
		[PexMethod]
		public bool IsOddTest08(sbyte value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest08(SByte)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOddTest09(sbyte? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest09(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOdd(Int16)</summary>
		[PexMethod]
		public bool IsOddTest10(short value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest10(Int16)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOddTest11(short? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest11(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOdd(UInt32)</summary>
		[PexMethod]
		public bool IsOddTest12(uint value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest12(UInt32)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOddTest13(uint? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest13(Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOdd(UInt64)</summary>
		[PexMethod]
		public bool IsOddTest14(ulong value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest14(UInt64)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOddTest15(ulong? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest15(Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOdd(UInt16)</summary>
		[PexMethod]
		public bool IsOddTest16(ushort value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest16(UInt16)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOddTest17(ushort? value)
		{
			bool result = IntegralParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingUtilityTests.IsOddTest17(Nullable`1<UInt16>)
		}
	}
}
