// <copyright file="FloatingPointNumberParityTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for FloatingPointNumberParityTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(FloatingPointNumberParityTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class FloatingPointNumberParityTestingExtensionTest
	{

		/// <summary>Test stub for IsEven(Double)</summary>
		[PexMethod]
		public bool IsEvenTest(double value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsEvenTest(Double)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest01(double? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsEvenTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsEven(Single)</summary>
		[PexMethod]
		public bool IsEvenTest02(float value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsEvenTest02(Single)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest03(float? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsEvenTest03(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOdd(Double)</summary>
		[PexMethod]
		public bool IsOddTest(double value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsOddTest(Double)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOddTest01(double? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsOddTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOdd(Single)</summary>
		[PexMethod]
		public bool IsOddTest02(float value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsOddTest02(Single)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOddTest03(float? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTest.IsOddTest03(Nullable`1<Single>)
		}
	}
}
