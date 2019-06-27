// <copyright file="FloatingPointNumberParityTestingUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for FloatingPointNumberParityTestingUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(FloatingPointNumberParityTestingUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class FloatingPointNumberParityTestingUtilityTest
	{

		/// <summary>Test stub for IsEven(Double)</summary>
		[PexMethod]
		public bool IsEvenTest(double value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsEvenTest(Double)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest01(double? value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsEvenTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsEven(Single)</summary>
		[PexMethod]
		public bool IsEvenTest02(float value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsEvenTest02(Single)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest03(float? value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsEvenTest03(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOdd(Double)</summary>
		[PexMethod]
		public bool IsOddTest(double value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsOddTest(Double)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOddTest01(double? value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsOddTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOdd(Single)</summary>
		[PexMethod]
		public bool IsOddTest02(float value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsOddTest02(Single)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOddTest03(float? value)
		{
			bool result = FloatingPointNumberParityTestingUtility.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingUtilityTest.IsOddTest03(Nullable`1<Single>)
		}
	}
}
