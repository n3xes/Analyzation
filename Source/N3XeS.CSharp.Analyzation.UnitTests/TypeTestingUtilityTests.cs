using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for TypeTestingUtility</summary>
    [TestClass]
    [PexClass(typeof(TypeTestingUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TypeTestingUtilityTests
    {

		/// <summary>Test stub for IsBoxedTypeOf(Object)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBoxedTypeOfTest<T>(object valueBoxed)
		{
			bool result = TypeTestingUtility.IsBoxedTypeOf<T>(valueBoxed);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsBoxedTypeOfTest(Object)
		}

		/// <summary>Test stub for IsNotBoxedTypeOf(Object)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotBoxedTypeOfTest<T>(object valueBoxed)
		{
			bool result = TypeTestingUtility.IsNotBoxedTypeOf<T>(valueBoxed);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsNotBoxedTypeOfTest(Object)
		}

		/// <summary>Test stub for IsNotNullableType(!!0)</summary>
		[PexGenericArguments(typeof(int?))]
		[PexMethod]
		public bool IsNotNullableTypeTest<T>(T value)
		{
			bool result = TypeTestingUtility.IsNotNullableType<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsNotNullableTypeTest(!!0)
		}

		/// <summary>Test stub for IsNotTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingUtility.IsNotTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsNotTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsNotValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingUtility.IsNotValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsNotValueTypeOfTest(!!0)
		}

		/// <summary>Test stub for IsNullableType(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexGenericArguments(typeof(int?))]
		[PexGenericArguments(typeof(string))]
		[PexMethod]
		public bool IsNullableTypeTest<T>(T value)
		{
			bool result = TypeTestingUtility.IsNullableType<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsNullableTypeTest(!!0)
		}

		/// <summary>Test stub for IsTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingUtility.IsTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingUtility.IsValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTests.IsValueTypeOfTest(!!0)
		}
	}
}
