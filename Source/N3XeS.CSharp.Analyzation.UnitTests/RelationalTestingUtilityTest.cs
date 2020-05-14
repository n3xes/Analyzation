// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Utilities;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for RelationalTestingUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(RelationalTestingUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class RelationalTestingUtilityTest
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest(DateTime, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest01(DateTime, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest02(DateTime, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest04(Nullable`1<DateTime>, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest08(Byte, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest09(Byte, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest10(Byte, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest12(Nullable`1<Byte>, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest16(Decimal, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest17(Decimal, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest18(Decimal, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest20(Nullable`1<Decimal>, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest24(Double, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest25(Double, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest26(Double, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest28(Nullable`1<Double>, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest32(Single, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest33(Single, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest34(Single, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest36(Nullable`1<Single>, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest40(Int32, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest41(Int32, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest42(Int32, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest44(Nullable`1<Int32>, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest48(Int64, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest49(Int64, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest50(Int64, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest52(Nullable`1<Int64>, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest56(SByte, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest57(SByte, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest58(SByte, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest60(Nullable`1<SByte>, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest64(Int16, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest65(Int16, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest66(Int16, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest68(Nullable`1<Int16>, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest72(UInt32, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest73(UInt32, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest74(UInt32, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest76(Nullable`1<UInt32>, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest80(UInt64, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest81(UInt64, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest82(UInt64, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest84(Nullable`1<UInt64>, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest88(UInt16, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest89(UInt16, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest90(UInt16, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest92(Nullable`1<UInt16>, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest(DateTime, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest01(DateTime, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest02(DateTime, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest04(Nullable`1<DateTime>, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest08(Byte, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest09(Byte, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest10(Byte, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest12(Nullable`1<Byte>, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest16(Decimal, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest17(Decimal, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest18(Decimal, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest20(Nullable`1<Decimal>, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest24(Double, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest25(Double, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest26(Double, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest28(Nullable`1<Double>, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest32(Single, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest33(Single, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest34(Single, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest36(Nullable`1<Single>, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest40(Int32, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest41(Int32, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest42(Int32, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest44(Nullable`1<Int32>, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest48(Int64, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest49(Int64, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest50(Int64, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest52(Nullable`1<Int64>, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest56(SByte, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest57(SByte, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest58(SByte, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest60(Nullable`1<SByte>, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest64(Int16, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest65(Int16, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest66(Int16, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest68(Nullable`1<Int16>, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest72(UInt32, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest73(UInt32, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest74(UInt32, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest76(Nullable`1<UInt32>, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest80(UInt64, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest81(UInt64, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest82(UInt64, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest84(Nullable`1<UInt64>, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest88(UInt16, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest89(UInt16, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest90(UInt16, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest92(Nullable`1<UInt16>, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsBetweenExclusiveTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThan(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanTest(DateTime value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsGreaterThan(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest01(DateTime value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanTest02(DateTime? value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest03(DateTime? value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThan(Byte, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest04(byte value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsGreaterThan(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest05(byte value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest06(byte? value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest07(byte? value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThan(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanTest08(decimal value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsGreaterThan(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest09(decimal value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanTest10(decimal? value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest11(decimal? value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThan(Double, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanTest12(double value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest12(Double, Double)
		}

		/// <summary>Test stub for IsGreaterThan(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest13(double value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanTest14(double? value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest15(double? value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThan(Single, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanTest16(float value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest16(Single, Single)
		}

		/// <summary>Test stub for IsGreaterThan(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest17(float value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanTest18(float? value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest19(float? value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThan(Int32, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest20(int value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsGreaterThan(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest21(int value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest22(int? value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest23(int? value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThan(Int64, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest24(long value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsGreaterThan(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest25(long value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest26(long? value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest27(long? value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThan(SByte, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest28(sbyte value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsGreaterThan(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest29(sbyte value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest30(sbyte? value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest31(sbyte? value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThan(Int16, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest32(short value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsGreaterThan(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest33(short value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest34(short? value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest35(short? value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest36(uint value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsGreaterThan(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest37(uint value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest38(uint? value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest39(uint? value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest40(ulong value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsGreaterThan(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest41(ulong value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest42(ulong? value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest43(ulong? value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest44(ushort value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsGreaterThan(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest45(ushort value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest46(ushort? value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest47(ushort? value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest(DateTime value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest01(DateTime value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest02(DateTime? value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest03(DateTime? value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Byte, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest04(byte value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest05(byte value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest06(byte? value, byte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest07(byte? value, byte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest08(decimal value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest09(decimal value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest10(decimal? value, decimal valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest11(decimal? value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest12(double value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest12(Double, Double)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest13(double value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest14(double? value, double valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest15(double? value, double? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest16(float value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest16(Single, Single)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest17(float value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest18(float? value, float valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest19(float? value, float? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int32, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest20(int value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest21(int value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest22(int? value, int valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest23(int? value, int? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int64, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest24(long value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest25(long value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest26(long? value, long valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest27(long? value, long? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(SByte, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest28(sbyte value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest29(sbyte value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest30(sbyte? value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest31(sbyte? value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int16, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest32(short value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest33(short value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest34(short? value, short valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest35(short? value, short? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest36(uint value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest37(uint value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest38(uint? value, uint valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest39(uint? value, uint? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest40(ulong value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest41(ulong value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest42(ulong? value, ulong valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest43(ulong? value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest44(ushort value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest45(ushort value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest46(ushort? value, ushort valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest47(ushort? value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsGreaterThanOrEqualTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThan(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanTest(DateTime value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsLessThan(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest01(DateTime value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanTest02(DateTime? value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest03(DateTime? value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThan(Byte, Byte)</summary>
		[PexMethod]
		public bool IsLessThanTest04(byte value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsLessThan(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest05(byte value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsLessThanTest06(byte? value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest07(byte? value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThan(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanTest08(decimal value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsLessThan(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest09(decimal value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanTest10(decimal? value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest11(decimal? value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThan(Double, Double)</summary>
		[PexMethod]
		public bool IsLessThanTest12(double value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest12(Double, Double)
		}

		/// <summary>Test stub for IsLessThan(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest13(double value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsLessThanTest14(double? value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest15(double? value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThan(Single, Single)</summary>
		[PexMethod]
		public bool IsLessThanTest16(float value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest16(Single, Single)
		}

		/// <summary>Test stub for IsLessThan(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest17(float value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsLessThanTest18(float? value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest19(float? value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThan(Int32, Int32)</summary>
		[PexMethod]
		public bool IsLessThanTest20(int value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsLessThan(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest21(int value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsLessThanTest22(int? value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest23(int? value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThan(Int64, Int64)</summary>
		[PexMethod]
		public bool IsLessThanTest24(long value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsLessThan(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest25(long value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsLessThanTest26(long? value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest27(long? value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThan(SByte, SByte)</summary>
		[PexMethod]
		public bool IsLessThanTest28(sbyte value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsLessThan(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest29(sbyte value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsLessThanTest30(sbyte? value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest31(sbyte? value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThan(Int16, Int16)</summary>
		[PexMethod]
		public bool IsLessThanTest32(short value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsLessThan(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest33(short value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsLessThanTest34(short? value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest35(short? value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThan(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanTest36(uint value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsLessThan(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest37(uint value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanTest38(uint? value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest39(uint? value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThan(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanTest40(ulong value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsLessThan(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest41(ulong value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanTest42(ulong? value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest43(ulong? value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThan(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanTest44(ushort value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsLessThan(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest45(ushort value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanTest46(ushort? value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest47(ushort? value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest(DateTime value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsLessThanOrEqual(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest01(DateTime value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest02(DateTime? value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest03(DateTime? value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Byte, Byte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest04(byte value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest05(byte value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest06(byte? value, byte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest07(byte? value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest08(decimal value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest09(decimal value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest10(decimal? value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest11(decimal? value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest12(double value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest12(Double, Double)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest13(double value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest14(double? value, double valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest15(double? value, double? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest16(float value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest16(Single, Single)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest17(float value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest18(float? value, float valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest19(float? value, float? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int32, Int32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest20(int value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest21(int value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest22(int? value, int valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest23(int? value, int? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int64, Int64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest24(long value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest25(long value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest26(long? value, long valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest27(long? value, long? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(SByte, SByte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest28(sbyte value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest29(sbyte value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest30(sbyte? value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest31(sbyte? value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int16, Int16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest32(short value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest33(short value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest34(short? value, short valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest35(short? value, short? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest36(uint value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest37(uint value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest38(uint? value, uint valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest39(uint? value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest40(ulong value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest41(ulong value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest42(ulong? value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest43(ulong? value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest44(ushort value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest45(ushort value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest46(ushort? value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest47(ushort? value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingUtilityTest.IsLessThanOrEqualTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest(DateTime, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest01(DateTime, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest02(DateTime, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest04(Nullable`1<DateTime>, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest08(Byte, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest09(Byte, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest10(Byte, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest12(Nullable`1<Byte>, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest16(Decimal, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest17(Decimal, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest18(Decimal, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest20(Nullable`1<Decimal>, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest24(Double, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest25(Double, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest26(Double, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest28(Nullable`1<Double>, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest32(Single, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest33(Single, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest34(Single, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest36(Nullable`1<Single>, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest40(Int32, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest41(Int32, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest42(Int32, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest44(Nullable`1<Int32>, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest48(Int64, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest49(Int64, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest50(Int64, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest52(Nullable`1<Int64>, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest56(SByte, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest57(SByte, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest58(SByte, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest60(Nullable`1<SByte>, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest64(Int16, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest65(Int16, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest66(Int16, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest68(Nullable`1<Int16>, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest72(UInt32, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest73(UInt32, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest74(UInt32, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest76(Nullable`1<UInt32>, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest80(UInt64, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest81(UInt64, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest82(UInt64, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest84(Nullable`1<UInt64>, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest88(UInt16, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest89(UInt16, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest90(UInt16, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest92(Nullable`1<UInt16>, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest(DateTime, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest01(DateTime, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest02(DateTime, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest04(Nullable`1<DateTime>, DateTime, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest08(Byte, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest09(Byte, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest10(Byte, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest12(Nullable`1<Byte>, Byte, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest16(Decimal, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest17(Decimal, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest18(Decimal, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest20(Nullable`1<Decimal>, Decimal, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest24(Double, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest25(Double, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest26(Double, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest28(Nullable`1<Double>, Double, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest32(Single, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest33(Single, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest34(Single, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest36(Nullable`1<Single>, Single, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest40(Int32, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest41(Int32, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest42(Int32, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest44(Nullable`1<Int32>, Int32, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest48(Int64, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest49(Int64, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest50(Int64, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest52(Nullable`1<Int64>, Int64, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest56(SByte, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest57(SByte, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest58(SByte, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest60(Nullable`1<SByte>, SByte, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest64(Int16, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest65(Int16, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest66(Int16, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest68(Nullable`1<Int16>, Int16, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest72(UInt32, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest73(UInt32, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest74(UInt32, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest76(Nullable`1<UInt32>, UInt32, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest80(UInt64, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest81(UInt64, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest82(UInt64, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest84(Nullable`1<UInt64>, UInt64, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest88(UInt16, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest89(UInt16, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest90(UInt16, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest92(Nullable`1<UInt16>, UInt16, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
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
			// TODO: add assertions to method RelationalTestingUtilityTest.IsOutsideExclusiveTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}
	}
}
