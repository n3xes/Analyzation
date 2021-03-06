// <copyright file="FloatingPointNumberParityTestingExtensionTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for FloatingPointNumberParityTestingExtension</summary>
    [TestClass]
    [PexClass(typeof(FloatingPointNumberParityTestingExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FloatingPointNumberParityTestingExtensionTests
    {

		/// <summary>Test stub for IsEven(Double)</summary>
		[PexMethod]
		public bool IsEvenTest(double value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsEvenTest(Double)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest01(double? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsEvenTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsEven(Single)</summary>
		[PexMethod]
		public bool IsEvenTest02(float value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsEvenTest02(Single)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest03(float? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsEvenTest03(Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOdd(Double)</summary>
		[PexMethod]
		public bool IsOddTest(double value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsOddTest(Double)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOddTest01(double? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsOddTest01(Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOdd(Single)</summary>
		[PexMethod]
		public bool IsOddTest02(float value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsOddTest02(Single)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOddTest03(float? value)
		{
			bool result = FloatingPointNumberParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method FloatingPointNumberParityTestingExtensionTests.IsOddTest03(Nullable`1<Single>)
		}
	}
}
