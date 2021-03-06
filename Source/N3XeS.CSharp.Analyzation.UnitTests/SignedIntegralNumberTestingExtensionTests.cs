// <copyright file="SignedIntegralNumberTestingExtensionTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for SignedIntegralNumberTestingExtension</summary>
    [TestClass]
    [PexClass(typeof(SignedIntegralNumberTestingExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SignedIntegralNumberTestingExtensionTests
    {

		/// <summary>Test stub for IsNegative(Decimal)</summary>
		[PexMethod]
		public bool IsNegativeTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest(Decimal)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsNegative(Int32)</summary>
		[PexMethod]
		public bool IsNegativeTest02(int value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest02(Int32)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsNegative(Int64)</summary>
		[PexMethod]
		public bool IsNegativeTest04(long value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest04(Int64)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsNegative(SByte)</summary>
		[PexMethod]
		public bool IsNegativeTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest06(SByte)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsNegative(Int16)</summary>
		[PexMethod]
		public bool IsNegativeTest08(short value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest08(Int16)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsNegativeTest09(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsPositive(Decimal)</summary>
		[PexMethod]
		public bool IsPositiveTest(decimal value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest(Decimal)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest01(decimal? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest01(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsPositive(Int32)</summary>
		[PexMethod]
		public bool IsPositiveTest02(int value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest02(Int32)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest03(int? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest03(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsPositive(Int64)</summary>
		[PexMethod]
		public bool IsPositiveTest04(long value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest04(Int64)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest05(long? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest05(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsPositive(SByte)</summary>
		[PexMethod]
		public bool IsPositiveTest06(sbyte value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest06(SByte)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest07(sbyte? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest07(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsPositive(Int16)</summary>
		[PexMethod]
		public bool IsPositiveTest08(short value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest08(Int16)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest09(short? value)
		{
			bool result = SignedIntegralNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedIntegralNumberTestingExtensionTests.IsPositiveTest09(Nullable`1<Int16>)
		}
	}
}
