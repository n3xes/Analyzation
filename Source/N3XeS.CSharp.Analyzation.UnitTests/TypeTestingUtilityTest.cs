// <copyright file="TypeTestingUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeTestingUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeTestingUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeTestingUtilityTest
	{

		/// <summary>Test stub for IsNotNullableType(Object)</summary>
		[PexMethod]
		[PexGenericArguments(typeof(ValueType))]
		public bool IsNotNullableTypeTest(object value)
		{
			bool result = TypeTestingUtility.IsNotNullableType(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsNotNullableTypeTest(Object)
		}

		/// <summary>Test stub for IsNotTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingUtility.IsNotTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsNotTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsNotValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsNotValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingUtility.IsNotValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsNotValueTypeOfTest(!!0)
		}

		/// <summary>Test stub for IsNullableType(Object)</summary>
		[PexMethod]
		public bool IsNullableTypeTest(object value)
		{
			bool result = TypeTestingUtility.IsNullableType(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsNullableTypeTest(Object)
		}

		/// <summary>Test stub for IsTypeOf(!!0, Type)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsTypeOfTest<T>(T value, Type typeComparison)
		{
			bool result = TypeTestingUtility.IsTypeOf<T>(value, typeComparison);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsTypeOfTest(!!0, Type)
		}

		/// <summary>Test stub for IsValueTypeOf(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsValueTypeOfTest<T>(T value)
		{
			bool result = TypeTestingUtility.IsValueTypeOf<T>(value);
			return result;
			// TODO: add assertions to method TypeTestingUtilityTest.IsValueTypeOfTest(!!0)
		}
	}
}
