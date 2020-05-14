// <copyright company="John Caruthers" file="SignedFloatingPointNumberTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for SignedFloatingPointNumberTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(SignedFloatingPointNumberTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class SignedFloatingPointNumberTestingExtensionTest
	{

		/// <summary>Test stub for IsNegative(Double)</summary>
		[PexMethod]
		public bool IsNegativeTest(double value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsNegativeTest(Double)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest01(double? value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsNegativeTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsNegative(Single)</summary>
		[PexMethod]
		public bool IsNegativeTest02(float value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsNegativeTest02(Single)
		}

		/// <summary>Test stub for IsNegative(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsNegativeTest03(float? value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsNegative(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsNegativeTest03(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsPositive(Double)</summary>
		[PexMethod]
		public bool IsPositiveTest(double value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsPositiveTest(Double)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest01(double? value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsPositiveTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsPositive(Single)</summary>
		[PexMethod]
		public bool IsPositiveTest02(float value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsPositiveTest02(Single)
		}

		/// <summary>Test stub for IsPositive(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsPositiveTest03(float? value)
		{
			bool result = SignedFloatingPointNumberTestingExtension.IsPositive(value);
			return result;
			// TODO: add assertions to method SignedFloatingPointNumberTestingExtensionTest.IsPositiveTest03(Nullable`1<Single>)
		}
	}
}
