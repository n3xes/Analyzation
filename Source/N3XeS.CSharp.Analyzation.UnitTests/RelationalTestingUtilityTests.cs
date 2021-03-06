// <copyright file="RelationalTestingUtilityTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
    /// <summary>This class contains parameterized unit tests for RelationalTestingUtility</summary>
    [TestClass]
    [PexClass(typeof(RelationalTestingUtility))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RelationalTestingUtilityTests
    {

		/// <summary>Test stub for IsBetween(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetween(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetween(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsBetween(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetween(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetween(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetween(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsBetween(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetween(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsBetween(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetween(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsBetween(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetween(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsBetween(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetween(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsBetween(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetween(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsBetween(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetween(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetween(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetween(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetween(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetween(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetween(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetween(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetween(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsBetweenExclusiveTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThan(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanTest(DateTime value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsGreaterThan(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest01(DateTime value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanTest02(DateTime? value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest03(DateTime? value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThan(Byte, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest04(byte value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsGreaterThan(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest05(byte value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest06(byte? value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest07(byte? value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThan(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanTest08(decimal value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsGreaterThan(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest09(decimal value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanTest10(decimal? value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest11(decimal? value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThan(Double, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanTest12(double value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest12(Double, Double)
		}

		/// <summary>Test stub for IsGreaterThan(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest13(double value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanTest14(double? value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest15(double? value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThan(Single, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanTest16(float value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest16(Single, Single)
		}

		/// <summary>Test stub for IsGreaterThan(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest17(float value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanTest18(float? value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest19(float? value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThan(Int32, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest20(int value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsGreaterThan(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest21(int value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest22(int? value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest23(int? value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThan(Int64, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest24(long value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsGreaterThan(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest25(long value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest26(long? value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest27(long? value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThan(SByte, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest28(sbyte value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsGreaterThan(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest29(sbyte value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest30(sbyte? value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest31(sbyte? value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThan(Int16, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest32(short value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsGreaterThan(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest33(short value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest34(short? value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest35(short? value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest36(uint value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsGreaterThan(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest37(uint value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest38(uint? value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest39(uint? value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest40(ulong value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsGreaterThan(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest41(ulong value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest42(ulong? value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest43(ulong? value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest44(ushort value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsGreaterThan(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest45(ushort value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest46(ushort? value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest47(ushort? value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest(DateTime value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest01(DateTime value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest02(DateTime? value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest03(DateTime? value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Byte, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest04(byte value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest05(byte value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest06(byte? value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest07(byte? value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest08(decimal value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest09(decimal value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest10(decimal? value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest11(decimal? value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest12(double value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest12(Double, Double)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest13(double value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest14(double? value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest15(double? value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest16(float value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest16(Single, Single)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest17(float value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest18(float? value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest19(float? value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int32, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest20(int value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest21(int value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest22(int? value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest23(int? value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int64, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest24(long value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest25(long value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest26(long? value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest27(long? value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(SByte, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest28(sbyte value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest29(sbyte value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest30(sbyte? value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest31(sbyte? value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int16, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest32(short value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest33(short value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest34(short? value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest35(short? value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest36(uint value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest37(uint value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest38(uint? value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest39(uint? value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest40(ulong value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest41(ulong value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest42(ulong? value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest43(ulong? value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest44(ushort value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest45(ushort value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest46(ushort? value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest47(ushort? value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsGreaterThanOrEqualTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThan(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanTest(DateTime value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsLessThan(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest01(DateTime value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanTest02(DateTime? value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest03(DateTime? value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThan(Byte, Byte)</summary>
		[PexMethod]
		public bool IsLessThanTest04(byte value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsLessThan(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest05(byte value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsLessThanTest06(byte? value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest07(byte? value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThan(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanTest08(decimal value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsLessThan(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest09(decimal value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanTest10(decimal? value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest11(decimal? value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThan(Double, Double)</summary>
		[PexMethod]
		public bool IsLessThanTest12(double value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest12(Double, Double)
		}

		/// <summary>Test stub for IsLessThan(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest13(double value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsLessThanTest14(double? value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest15(double? value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThan(Single, Single)</summary>
		[PexMethod]
		public bool IsLessThanTest16(float value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest16(Single, Single)
		}

		/// <summary>Test stub for IsLessThan(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest17(float value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsLessThanTest18(float? value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest19(float? value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThan(Int32, Int32)</summary>
		[PexMethod]
		public bool IsLessThanTest20(int value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsLessThan(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest21(int value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsLessThanTest22(int? value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest23(int? value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThan(Int64, Int64)</summary>
		[PexMethod]
		public bool IsLessThanTest24(long value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsLessThan(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest25(long value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsLessThanTest26(long? value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest27(long? value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThan(SByte, SByte)</summary>
		[PexMethod]
		public bool IsLessThanTest28(sbyte value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsLessThan(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest29(sbyte value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsLessThanTest30(sbyte? value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest31(sbyte? value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThan(Int16, Int16)</summary>
		[PexMethod]
		public bool IsLessThanTest32(short value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsLessThan(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest33(short value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsLessThanTest34(short? value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest35(short? value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThan(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanTest36(uint value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsLessThan(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest37(uint value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanTest38(uint? value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest39(uint? value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThan(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanTest40(ulong value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsLessThan(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest41(ulong value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanTest42(ulong? value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest43(ulong? value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThan(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanTest44(ushort value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsLessThan(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest45(ushort value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanTest46(ushort? value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest47(ushort? value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest(DateTime value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsLessThanOrEqual(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest01(DateTime value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest02(DateTime? value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest03(DateTime? value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Byte, Byte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest04(byte value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest05(byte value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest06(byte? value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest07(byte? value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest08(decimal value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest09(decimal value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest10(decimal? value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest11(decimal? value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest12(double value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest12(Double, Double)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest13(double value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest14(double? value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest15(double? value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest16(float value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest16(Single, Single)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest17(float value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest18(float? value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest19(float? value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int32, Int32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest20(int value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest21(int value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest22(int? value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest23(int? value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int64, Int64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest24(long value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest25(long value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest26(long? value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest27(long? value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(SByte, SByte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest28(sbyte value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest29(sbyte value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest30(sbyte? value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest31(sbyte? value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int16, Int16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest32(short value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest33(short value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest34(short? value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest35(short? value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest36(uint value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest37(uint value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest38(uint? value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest39(uint? value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest40(ulong value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest41(ulong value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest42(ulong? value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest43(ulong? value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest44(ushort value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest45(ushort value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest46(ushort? value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest47(ushort? value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsLessThanOrEqualTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutside(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutside(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsOutside(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutside(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutside(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutside(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsOutside(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutside(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsOutside(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutside(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsOutside(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutside(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsOutside(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutside(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsOutside(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutside(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsOutside(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutside(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutside(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutside(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutside(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutside(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutside(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutside(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTests.IsOutsideExclusiveTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}
	}
}
