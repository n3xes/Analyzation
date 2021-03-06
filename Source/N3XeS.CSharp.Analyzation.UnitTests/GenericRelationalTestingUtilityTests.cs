// <copyright file="GenericRelationalTestingUtilityTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for GenericRelationalTestingUtility</summary>
    [TestClass]
    [PexClass(typeof(GenericRelationalTestingUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GenericRelationalTestingUtilityTests
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest(!!0, !!0, !!0)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest01(!!0, !!0, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest02(!!0, Nullable`1<!!0>, !!0)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest04(Nullable`1<!!0>, !!0, !!0)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
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
			bool result = GenericRelationalTestingUtility.IsBetween<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest(!!0, !!0, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest01(!!0, !!0, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest02(!!0, Nullable`1<!!0>, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest04(Nullable`1<!!0>, !!0, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsBetweenExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsBetweenExclusiveTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThan(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest<T>(T value, T valueBoundLower)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanTest(!!0, !!0)
		}

		/// <summary>Test stub for IsGreaterThan(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest01<T>(T value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest02<T>(T? value, T valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanTest03<T>(T? value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest<T>(T value, T valueBoundLower)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanOrEqualTest(!!0, !!0)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest01<T>(T value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanOrEqualTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest02<T>(T? value, T valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanOrEqualTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsGreaterThanOrEqualTest03<T>(T? value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsGreaterThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsGreaterThanOrEqualTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThan(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest<T>(T value, T valueBoundLower)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanTest(!!0, !!0)
		}

		/// <summary>Test stub for IsLessThan(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest01<T>(T value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest02<T>(T? value, T valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanTest03<T>(T? value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThan<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanTest03(Nullable`1<!!0>, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(!!0, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest<T>(T value, T valueBoundLower)
			where T : IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanOrEqualTest(!!0, !!0)
		}

		/// <summary>Test stub for IsLessThanOrEqual(!!0, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest01<T>(T value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanOrEqualTest01(!!0, Nullable`1<!!0>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;!!0&gt;, !!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest02<T>(T? value, T valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanOrEqualTest02(Nullable`1<!!0>, !!0)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;!!0&gt;, Nullable`1&lt;!!0&gt;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public bool IsLessThanOrEqualTest03<T>(T? value, T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			bool result = GenericRelationalTestingUtility.IsLessThanOrEqual<T>(value, valueBoundLower);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsLessThanOrEqualTest03(Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest(!!0, !!0, !!0)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest01(!!0, !!0, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest02(!!0, Nullable`1<!!0>, !!0)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest04(Nullable`1<!!0>, !!0, !!0)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
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
			bool result = GenericRelationalTestingUtility.IsOutside<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest(!!0, !!0, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest01(!!0, !!0, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest02(!!0, Nullable`1<!!0>, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest03(!!0, Nullable`1<!!0>, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest04(Nullable`1<!!0>, !!0, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest05(Nullable`1<!!0>, !!0, Nullable`1<!!0>)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest06(Nullable`1<!!0>, Nullable`1<!!0>, !!0)
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
			bool result
			   = GenericRelationalTestingUtility.IsOutsideExclusive<T>(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method GenericRelationalTestingUtilityTest.IsOutsideExclusiveTest07(Nullable`1<!!0>, Nullable`1<!!0>, Nullable`1<!!0>)
		}
	}
}
