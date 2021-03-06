// <copyright file="GenericRelationalTestingExtensionTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for GenericRelationalTestingExtension</summary>
    [TestClass]
    [PexClass(typeof(GenericRelationalTestingExtension))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GenericRelationalTestingExtensionTests
    {

		/// <summary>Test stub for IsBetween(!!0, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest<T>(
			T value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest(!!0, !!0, !!0)
		}

		/// <summary>Test stub for IsBetween(!!0, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest01<T>(
			T value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest01(!!0, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetween(!!0, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest02<T>(
			T value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest02(!!0, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsBetween(!!0, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest03<T>(
			T value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;!!0&gt;, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest04<T>(
			T? value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest04(Nullable`1<!!0>, !!0, !!0)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;!!0&gt;, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest05<T>(
			T? value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest06<T>(
			T? value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenTest07<T>(
			T? value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetweenExclusive(!!0, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest<T>(
			T value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest(!!0, !!0, !!0)
		}

		/// <summary>Test stub for IsBetweenExclusive(!!0, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest01<T>(
			T value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest01(!!0, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetweenExclusive(!!0, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest02<T>(
			T value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest02(!!0, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsBetweenExclusive(!!0, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest03<T>(
			T value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;!!0&gt;, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest04<T>(
			T? value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest04(Nullable`1<!!0>, !!0, !!0)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;!!0&gt;, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest05<T>(
			T? value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest06<T>(
			T? value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsBetweenExclusiveTest07<T>(
			T? value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsBetweenExclusiveTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThan(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest<T>(T value, T valueBoundLower)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanTest(!!0, !!0)
		}

		/// <summary>Test stub for IsGreaterThan(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest01<T>(T value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest02<T>(T? value, T valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest03<T>(T? value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest<T>(T value, T valueBoundLower)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanOrEqualTest(!!0, !!0)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest01<T>(T value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanOrEqualTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest02<T>(T? value, T valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanOrEqualTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest03<T>(T? value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsGreaterThanOrEqualTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThan(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest<T>(T value, T valueBoundUpper)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThan<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanTest(!!0, !!0)
		}

		/// <summary>Test stub for IsLessThan(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest01<T>(T value, T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThan<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest02<T>(T? value, T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThan<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest03<T>(T? value, T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThan<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest<T>(T value, T valueBoundUpper)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThanOrEqual<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanOrEqualTest(!!0, !!0)
		}

		/// <summary>Test stub for IsLessThanOrEqual(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest01<T>(T value, T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThanOrEqual<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanOrEqualTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest02<T>(T? value, T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThanOrEqual<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanOrEqualTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest03<T>(T? value, T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingExtension.IsLessThanOrEqual<T>(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsLessThanOrEqualTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutside(!!0, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest<T>(
			T value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest(!!0, !!0, !!0)
		}

		/// <summary>Test stub for IsOutside(!!0, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest01<T>(
			T value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest01(!!0, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutside(!!0, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest02<T>(
			T value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest02(!!0, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsOutside(!!0, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest03<T>(
			T value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;!!0&gt;, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest04<T>(
			T? value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest04(Nullable`1<!!0>, !!0, !!0)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;!!0&gt;, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest05<T>(
			T? value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest06<T>(
			T? value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideTest07<T>(
			T? value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result
			   = GenericRelationalTestingExtension.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutsideExclusive(!!0, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest<T>(
			T value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest(!!0, !!0, !!0)
		}

		/// <summary>Test stub for IsOutsideExclusive(!!0, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest01<T>(
			T value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest01(!!0, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutsideExclusive(!!0, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest02<T>(
			T value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest02(!!0, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsOutsideExclusive(!!0, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest03<T>(
			T value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;!!0&gt;, !!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest04<T>(
			T? value,
			T valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest04(Nullable`1<!!0>, !!0, !!0)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;!!0&gt;, !!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest05<T>(
			T? value,
			T valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest06<T>(
			T? value,
			T? valueBoundLower,
			T valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsOutsideExclusiveTest07<T>(
			T? value,
			T? valueBoundLower,
			T? valueBoundUpper
		)
			where T : struct, IComparable<T>
		{
			bool result =
						 GenericRelationalTestingExtension.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingExtensionTest.IsOutsideExclusiveTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
		}
	}
}
