// <copyright company="John Caruthers" file="SignedIntegralNumberTestingUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for SignedIntegralNumberTestingUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(SignedIntegralNumberTestingUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class SignedIntegralNumberTestingUtilityTest
	{

		/// <summary>Test stub for IsNegative(Decimal)</summary>
		[PexMethod]
		public bool IsNegativeTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest(Decimal)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsNegative(Int32)</summary>
		[PexMethod]
		public bool IsNegativeTest02(int value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest02(Int32)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsNegative(Int64)</summary>
		[PexMethod]
		public bool IsNegativeTest04(long value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest04(Int64)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsNegative(SByte)</summary>
		[PexMethod]
		public bool IsNegativeTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest06(SByte)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsNegative(Int16)</summary>
		[PexMethod]
		public bool IsNegativeTest08(short value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest08(Int16)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsNegativeTest09(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsPositive(Decimal)</summary>
		[PexMethod]
		public bool IsPositiveTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest(Decimal)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsPositive(Int32)</summary>
		[PexMethod]
		public bool IsPositiveTest02(int value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest02(Int32)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsPositive(Int64)</summary>
		[PexMethod]
		public bool IsPositiveTest04(long value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest04(Int64)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsPositive(SByte)</summary>
		[PexMethod]
		public bool IsPositiveTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest06(SByte)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsPositive(Int16)</summary>
		[PexMethod]
		public bool IsPositiveTest08(short value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest08(Int16)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingUtilityTest.IsPositiveTest09(Nullable`1<Int16>)
		}
	}
}
