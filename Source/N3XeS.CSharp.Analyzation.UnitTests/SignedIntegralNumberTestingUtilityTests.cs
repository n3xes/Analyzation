// <copyright file="SignedIntegralNumberTestingUtilityTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for SignedIntegralNumberTestingUtility</summary>
    [TestClass]
    [PexClass(typeof(SignedIntegralNumberTestingUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SignedIntegralNumberTestingUtilityTests
    {

		/// <summary>Test stub for IsNegative(Decimal)</summary>
		[PexMethod]
		public bool IsNegativeTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest(Decimal)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsNegative(Int32)</summary>
		[PexMethod]
		public bool IsNegativeTest02(int value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest02(Int32)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsNegative(Int64)</summary>
		[PexMethod]
		public bool IsNegativeTest04(long value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest04(Int64)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsNegative(SByte)</summary>
		[PexMethod]
		public bool IsNegativeTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest06(SByte)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsNegative(Int16)</summary>
		[PexMethod]
		public bool IsNegativeTest08(short value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest08(Int16)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsNegativeTest09(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsPositive(Decimal)</summary>
		[PexMethod]
		public bool IsPositiveTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest(Decimal)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsPositive(Int32)</summary>
		[PexMethod]
		public bool IsPositiveTest02(int value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest02(Int32)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsPositive(Int64)</summary>
		[PexMethod]
		public bool IsPositiveTest04(long value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest04(Int64)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsPositive(SByte)</summary>
		[PexMethod]
		public bool IsPositiveTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest06(SByte)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsPositive(Int16)</summary>
		[PexMethod]
		public bool IsPositiveTest08(short value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest08(Int16)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTests.IsPositiveTest09(Nullable`1<Int16>)
		}
	}
}
