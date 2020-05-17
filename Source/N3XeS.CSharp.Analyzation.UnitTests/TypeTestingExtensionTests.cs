using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.Tests
{
    /// <summary>This class contains parameterized unit tests for TypeTestingExtension</summary>
    [TestClass]
    [PexClass(typeof(TypeTestingExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TypeTestingExtensionTests
    {

		/// <summary>Test stub for IsNotNullableType(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotNullableTypeTest<T>(T value)
		{
			bool result = TypeTestingExtension.IsNotNullableType<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTests.IsNotNullableTypeTest(!!0)
		}

		/// <summary>Test stub for IsNotTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingExtension.IsNotTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTests.IsNotTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsNotValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingExtension.IsNotValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTests.IsNotValueTypeOfTest(!!0)
		}

		/// <summary>Test stub for IsNullableType(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNullableTypeTest<T>(T value)
		{
			bool result = TypeTestingExtension.IsNullableType<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTests.IsNullableTypeTest(!!0)
		}

		/// <summary>Test stub for IsTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingExtension.IsTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTests.IsTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingExtension.IsValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTests.IsValueTypeOfTest(!!0)
		}
	}
}
