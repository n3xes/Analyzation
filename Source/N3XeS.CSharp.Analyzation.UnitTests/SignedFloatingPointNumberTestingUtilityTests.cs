// <copyright file="SignedFloatingPointNumberTestingUtilityTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for SignedFloatingPointNumberTestingUtility</summary>
    [TestClass]
    [PexClass(typeof(SignedFloatingPointNumberTestingUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SignedFloatingPointNumberTestingUtilityTests
    {

		/// <summary>Test stub for IsNegative(Double)</summary>
		[PexMethod]
		public bool IsNegativeTest(double value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsNegativeTest(Double)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest01(double? value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsNegativeTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsNegative(Single)</summary>
		[PexMethod]
		public bool IsNegativeTest02(float value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsNegativeTest02(Single)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest03(float? value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsNegativeTest03(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsPositive(Double)</summary>
		[PexMethod]
		public bool IsPositiveTest(double value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsPositiveTest(Double)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest01(double? value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsPositiveTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsPositive(Single)</summary>
		[PexMethod]
		public bool IsPositiveTest02(float value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsPositiveTest02(Single)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest03(float? value)
		{
			bool result = SignedFloatingPointNumberTestingUtility.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingUtilityTests.IsPositiveTest03(Nullable`1<Single>)
		}
	}
}
