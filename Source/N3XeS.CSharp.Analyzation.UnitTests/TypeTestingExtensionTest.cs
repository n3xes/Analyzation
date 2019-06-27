// <copyright file="TypeTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeTestingExtensionTest
	{

		/// <summary>Test stub for IsNotNullableType(Object)</summary>
		[PexMethod]
		public bool IsNotNullableTypeTest(object value)
		{
			bool result = TypeTestingExtension.IsNotNullableType(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsNotNullableTypeTest(Object)
		}

		/// <summary>Test stub for IsNotTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingExtension.IsNotTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsNotTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsNotValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingExtension.IsNotValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsNotValueTypeOfTest(!!0)
		}

		/// <summary>Test stub for IsNullableTypeOf(Object)</summary>
		[PexMethod]
		public bool IsNullableTypeOfTest(object value)
		{
			bool result = TypeTestingExtension.IsNullableTypeOf(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsNullableTypeOfTest(Object)
		}

		/// <summary>Test stub for IsTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingExtension.IsTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingExtension.IsValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingExtensionTest.IsValueTypeOfTest(!!0)
		}
	}
}
