// <copyright company="John Caruthers" file="SignedIntegralNumberTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for SignedIntegralNumberTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(SignedIntegralNumberTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class SignedIntegralNumberTestingExtensionTest
	{

		/// <summary>Test stub for IsNegative(Decimal)</summary>
		[PexMethod]
		public bool IsNegativeTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest(Decimal)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsNegative(Int32)</summary>
		[PexMethod]
		public bool IsNegativeTest02(int value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest02(Int32)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsNegative(Int64)</summary>
		[PexMethod]
		public bool IsNegativeTest04(long value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest04(Int64)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsNegative(SByte)</summary>
		[PexMethod]
		public bool IsNegativeTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest06(SByte)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsNegative(Int16)</summary>
		[PexMethod]
		public bool IsNegativeTest08(short value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest08(Int16)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsNegativeTest09(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsPositive(Decimal)</summary>
		[PexMethod]
		public bool IsPositiveTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest(Decimal)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsPositive(Int32)</summary>
		[PexMethod]
		public bool IsPositiveTest02(int value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest02(Int32)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsPositive(Int64)</summary>
		[PexMethod]
		public bool IsPositiveTest04(long value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest04(Int64)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsPositive(SByte)</summary>
		[PexMethod]
		public bool IsPositiveTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest06(SByte)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsPositive(Int16)</summary>
		[PexMethod]
		public bool IsPositiveTest08(short value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest08(Int16)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTest.IsPositiveTest09(Nullable`1<Int16>)
		}
	}
}
