// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for RelationalTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(RelationalTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class RelationalTestingExtensionTest
	{

		/// <summary>Test stub for IsBetween(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetween(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetween(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetween(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsBetween(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetween(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetween(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetween(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetween(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetween(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsBetween(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetween(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetween(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsBetween(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetween(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetween(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsBetween(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetween(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetween(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsBetween(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetween(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetween(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsBetween(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetween(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetween(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsBetween(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetween(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetween(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetween(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetween(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetween(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetween(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetween(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetween(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetween(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetween(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetween(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetween(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetween(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsBetweenExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsBetweenExclusiveTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsBetweenExclusiveTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThan(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanTest(DateTime value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsGreaterThan(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest01(DateTime value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanTest02(DateTime? value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest03(DateTime? value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThan(Byte, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest04(byte value, byte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsGreaterThan(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest05(byte value, byte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest06(byte? value, byte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest07(byte? value, byte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThan(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanTest08(decimal value, decimal valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsGreaterThan(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest09(decimal value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanTest10(decimal? value, decimal valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest11(decimal? value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThan(Double, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanTest12(double value, double valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest12(Double, Double)
		}

		/// <summary>Test stub for IsGreaterThan(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest13(double value, double? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanTest14(double? value, double valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest15(double? value, double? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThan(Single, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanTest16(float value, float valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest16(Single, Single)
		}

		/// <summary>Test stub for IsGreaterThan(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest17(float value, float? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanTest18(float? value, float valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest19(float? value, float? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThan(Int32, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest20(int value, int valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsGreaterThan(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest21(int value, int? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest22(int? value, int valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest23(int? value, int? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThan(Int64, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest24(long value, long valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsGreaterThan(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest25(long value, long? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest26(long? value, long valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest27(long? value, long? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThan(SByte, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest28(sbyte value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsGreaterThan(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest29(sbyte value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanTest30(sbyte? value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest31(sbyte? value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThan(Int16, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest32(short value, short valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsGreaterThan(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest33(short value, short? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest34(short? value, short valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest35(short? value, short? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest36(uint value, uint valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsGreaterThan(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest37(uint value, uint? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanTest38(uint? value, uint valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest39(uint? value, uint? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest40(ulong value, ulong valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsGreaterThan(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest41(ulong value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanTest42(ulong? value, ulong valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest43(ulong? value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThan(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest44(ushort value, ushort valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsGreaterThan(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest45(ushort value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanTest46(ushort? value, ushort valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsGreaterThan(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanTest47(ushort? value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThan(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest(DateTime value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest01(DateTime value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest02(DateTime? value, DateTime valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest03(DateTime? value, DateTime? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Byte, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest04(byte value, byte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest05(byte value, byte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest06(byte? value, byte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest07(byte? value, byte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest08(decimal value, decimal valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest09(decimal value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest10(decimal? value, decimal valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest11(decimal? value, decimal? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest12(double value, double valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest12(Double, Double)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest13(double value, double? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest14(double? value, double valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest15(double? value, double? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest16(float value, float valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest16(Single, Single)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest17(float value, float? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest18(float? value, float valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest19(float? value, float? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int32, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest20(int value, int valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest21(int value, int? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest22(int? value, int valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest23(int? value, int? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int64, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest24(long value, long valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest25(long value, long? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest26(long? value, long valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest27(long? value, long? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(SByte, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest28(sbyte value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest29(sbyte value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest30(sbyte? value, sbyte valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest31(sbyte? value, sbyte? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int16, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest32(short value, short valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest33(short value, short? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest34(short? value, short valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest35(short? value, short? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest36(uint value, uint valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest37(uint value, uint? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest38(uint? value, uint valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest39(uint? value, uint? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest40(ulong value, ulong valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest41(ulong value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest42(ulong? value, ulong valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest43(ulong? value, ulong? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest44(ushort value, ushort valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest45(ushort value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest46(ushort? value, ushort valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsGreaterThanOrEqual(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsGreaterThanOrEqualTest47(ushort? value, ushort? valueBoundLower)
		{
			bool result = RelationalTestingExtension.IsGreaterThanOrEqual(value, valueBoundLower);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsGreaterThanOrEqualTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThan(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanTest(DateTime value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsLessThan(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest01(DateTime value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanTest02(DateTime? value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest03(DateTime? value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThan(Byte, Byte)</summary>
		[PexMethod]
		public bool IsLessThanTest04(byte value, byte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsLessThan(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest05(byte value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsLessThanTest06(byte? value, byte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest07(byte? value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThan(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanTest08(decimal value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsLessThan(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest09(decimal value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanTest10(decimal? value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest11(decimal? value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThan(Double, Double)</summary>
		[PexMethod]
		public bool IsLessThanTest12(double value, double valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest12(Double, Double)
		}

		/// <summary>Test stub for IsLessThan(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest13(double value, double? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsLessThanTest14(double? value, double valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest15(double? value, double? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThan(Single, Single)</summary>
		[PexMethod]
		public bool IsLessThanTest16(float value, float valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest16(Single, Single)
		}

		/// <summary>Test stub for IsLessThan(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest17(float value, float? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsLessThanTest18(float? value, float valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest19(float? value, float? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThan(Int32, Int32)</summary>
		[PexMethod]
		public bool IsLessThanTest20(int value, int valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsLessThan(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest21(int value, int? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsLessThanTest22(int? value, int valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest23(int? value, int? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThan(Int64, Int64)</summary>
		[PexMethod]
		public bool IsLessThanTest24(long value, long valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsLessThan(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest25(long value, long? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsLessThanTest26(long? value, long valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest27(long? value, long? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThan(SByte, SByte)</summary>
		[PexMethod]
		public bool IsLessThanTest28(sbyte value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsLessThan(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest29(sbyte value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsLessThanTest30(sbyte? value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest31(sbyte? value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThan(Int16, Int16)</summary>
		[PexMethod]
		public bool IsLessThanTest32(short value, short valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsLessThan(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest33(short value, short? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsLessThanTest34(short? value, short valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest35(short? value, short? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThan(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanTest36(uint value, uint valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsLessThan(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest37(uint value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanTest38(uint? value, uint valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest39(uint? value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThan(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanTest40(ulong value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsLessThan(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest41(ulong value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanTest42(ulong? value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest43(ulong? value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThan(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanTest44(ushort value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsLessThan(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest45(ushort value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanTest46(ushort? value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsLessThan(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanTest47(ushort? value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThan(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest(DateTime value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest(DateTime, DateTime)
		}

		/// <summary>Test stub for IsLessThanOrEqual(DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest01(DateTime value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest01(DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest02(DateTime? value, DateTime valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest02(Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest03(DateTime? value, DateTime? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest03(Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Byte, Byte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest04(byte value, byte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest04(Byte, Byte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest05(byte value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest05(Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest06(byte? value, byte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest06(Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest07(byte? value, byte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest07(Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest08(decimal value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest08(Decimal, Decimal)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest09(decimal value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest09(Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest10(decimal? value, decimal valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest10(Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest11(decimal? value, decimal? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest11(Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Double, Double)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest12(double value, double valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest12(Double, Double)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest13(double value, double? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest13(Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest14(double? value, double valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest14(Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest15(double? value, double? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest15(Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Single, Single)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest16(float value, float valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest16(Single, Single)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest17(float value, float? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest17(Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest18(float? value, float valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest18(Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest19(float? value, float? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest19(Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int32, Int32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest20(int value, int valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest20(Int32, Int32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest21(int value, int? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest21(Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest22(int? value, int valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest22(Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest23(int? value, int? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest23(Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int64, Int64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest24(long value, long valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest24(Int64, Int64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest25(long value, long? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest25(Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest26(long? value, long valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest26(Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest27(long? value, long? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest27(Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(SByte, SByte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest28(sbyte value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest28(SByte, SByte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest29(sbyte value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest29(SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest30(sbyte? value, sbyte valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest30(Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest31(sbyte? value, sbyte? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest31(Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int16, Int16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest32(short value, short valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest32(Int16, Int16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest33(short value, short? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest33(Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest34(short? value, short valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest34(Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest35(short? value, short? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest35(Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest36(uint value, uint valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest36(UInt32, UInt32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest37(uint value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest37(UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest38(uint? value, uint valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest38(Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest39(uint? value, uint? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest39(Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest40(ulong value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest40(UInt64, UInt64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest41(ulong value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest41(UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest42(ulong? value, ulong valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest42(Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest43(ulong? value, ulong? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest43(Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest44(ushort value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest44(UInt16, UInt16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest45(ushort value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest45(UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest46(ushort? value, ushort valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest46(Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsLessThanOrEqual(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsLessThanOrEqualTest47(ushort? value, ushort? valueBoundUpper)
		{
			bool result = RelationalTestingExtension.IsLessThanOrEqual(value, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsLessThanOrEqualTest47(Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutside(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutside(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutside(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsOutside(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutside(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutside(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutside(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutside(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutside(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsOutside(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutside(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutside(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsOutside(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutside(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutside(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsOutside(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutside(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutside(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsOutside(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutside(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutside(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsOutside(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutside(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutside(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsOutside(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutside(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutside(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutside(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutside(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutside(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutside(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutside(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutside(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutside(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutside(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutside(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutside(value, valueBoundLower, valueBoundUpper);
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest(
			DateTime value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest(DateTime, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest01(
			DateTime value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest01(DateTime, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest02(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest02(DateTime, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(DateTime, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest03(
			DateTime value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest03(DateTime, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, DateTime, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest04(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest04(Nullable`1<DateTime>, DateTime, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, DateTime, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest05(
			DateTime? value,
			DateTime valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest05(Nullable`1<DateTime>, DateTime, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, DateTime)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest06(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest06(Nullable`1<DateTime>, Nullable`1<DateTime>, DateTime)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;, Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest07(
			DateTime? value,
			DateTime? valueBoundLower,
			DateTime? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest07(Nullable`1<DateTime>, Nullable`1<DateTime>, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest08(
			byte value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest08(Byte, Byte, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest09(
			byte value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest09(Byte, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest10(
			byte value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest10(Byte, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Byte, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest11(
			byte value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest11(Byte, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Byte, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest12(
			byte? value,
			byte valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest12(Nullable`1<Byte>, Byte, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Byte, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest13(
			byte? value,
			byte valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest13(Nullable`1<Byte>, Byte, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Byte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest14(
			byte? value,
			byte? valueBoundLower,
			byte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest14(Nullable`1<Byte>, Nullable`1<Byte>, Byte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;, Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest15(
			byte? value,
			byte? valueBoundLower,
			byte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest15(Nullable`1<Byte>, Nullable`1<Byte>, Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest16(
			decimal value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest16(Decimal, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest17(
			decimal value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest17(Decimal, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest18(
			decimal value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest18(Decimal, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Decimal, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest19(
			decimal value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest19(Decimal, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest20(
			decimal? value,
			decimal valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest20(Nullable`1<Decimal>, Decimal, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Decimal, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest21(
			decimal? value,
			decimal valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest21(Nullable`1<Decimal>, Decimal, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Decimal)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest22(
			decimal? value,
			decimal? valueBoundLower,
			decimal valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest22(Nullable`1<Decimal>, Nullable`1<Decimal>, Decimal)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;, Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest23(
			decimal? value,
			decimal? valueBoundLower,
			decimal? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest23(Nullable`1<Decimal>, Nullable`1<Decimal>, Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest24(
			double value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest24(Double, Double, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest25(
			double value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest25(Double, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest26(
			double value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest26(Double, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Double, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest27(
			double value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest27(Double, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Double, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest28(
			double? value,
			double valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest28(Nullable`1<Double>, Double, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Double, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest29(
			double? value,
			double valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest29(Nullable`1<Double>, Double, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Double)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest30(
			double? value,
			double? valueBoundLower,
			double valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest30(Nullable`1<Double>, Nullable`1<Double>, Double)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;, Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest31(
			double? value,
			double? valueBoundLower,
			double? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest31(Nullable`1<Double>, Nullable`1<Double>, Nullable`1<Double>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest32(
			float value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest32(Single, Single, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest33(
			float value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest33(Single, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest34(
			float value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest34(Single, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Single, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest35(
			float value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest35(Single, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Single, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest36(
			float? value,
			float valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest36(Nullable`1<Single>, Single, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Single, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest37(
			float? value,
			float valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest37(Nullable`1<Single>, Single, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Single)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest38(
			float? value,
			float? valueBoundLower,
			float valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest38(Nullable`1<Single>, Nullable`1<Single>, Single)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;, Nullable`1&lt;Single&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest39(
			float? value,
			float? valueBoundLower,
			float? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest39(Nullable`1<Single>, Nullable`1<Single>, Nullable`1<Single>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest40(
			int value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest40(Int32, Int32, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest41(
			int value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest41(Int32, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest42(
			int value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest42(Int32, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int32, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest43(
			int value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest43(Int32, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Int32, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest44(
			int? value,
			int valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest44(Nullable`1<Int32>, Int32, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Int32, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest45(
			int? value,
			int valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest45(Nullable`1<Int32>, Int32, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Int32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest46(
			int? value,
			int? valueBoundLower,
			int valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest46(Nullable`1<Int32>, Nullable`1<Int32>, Int32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;, Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest47(
			int? value,
			int? valueBoundLower,
			int? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest47(Nullable`1<Int32>, Nullable`1<Int32>, Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest48(
			long value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest48(Int64, Int64, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest49(
			long value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest49(Int64, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest50(
			long value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest50(Int64, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int64, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest51(
			long value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest51(Int64, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Int64, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest52(
			long? value,
			long valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest52(Nullable`1<Int64>, Int64, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Int64, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest53(
			long? value,
			long valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest53(Nullable`1<Int64>, Int64, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Int64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest54(
			long? value,
			long? valueBoundLower,
			long valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest54(Nullable`1<Int64>, Nullable`1<Int64>, Int64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;, Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest55(
			long? value,
			long? valueBoundLower,
			long? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest55(Nullable`1<Int64>, Nullable`1<Int64>, Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest56(
			sbyte value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest56(SByte, SByte, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest57(
			sbyte value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest57(SByte, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest58(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest58(SByte, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(SByte, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest59(
			sbyte value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest59(SByte, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, SByte, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest60(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest60(Nullable`1<SByte>, SByte, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, SByte, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest61(
			sbyte? value,
			sbyte valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest61(Nullable`1<SByte>, SByte, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, SByte)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest62(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest62(Nullable`1<SByte>, Nullable`1<SByte>, SByte)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;, Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest63(
			sbyte? value,
			sbyte? valueBoundLower,
			sbyte? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest63(Nullable`1<SByte>, Nullable`1<SByte>, Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest64(
			short value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest64(Int16, Int16, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest65(
			short value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest65(Int16, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest66(
			short value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest66(Int16, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Int16, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest67(
			short value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest67(Int16, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Int16, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest68(
			short? value,
			short valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest68(Nullable`1<Int16>, Int16, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Int16, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest69(
			short? value,
			short valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest69(Nullable`1<Int16>, Int16, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Int16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest70(
			short? value,
			short? valueBoundLower,
			short valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest70(Nullable`1<Int16>, Nullable`1<Int16>, Int16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;, Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest71(
			short? value,
			short? valueBoundLower,
			short? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest71(Nullable`1<Int16>, Nullable`1<Int16>, Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest72(
			uint value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest72(UInt32, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest73(
			uint value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest73(UInt32, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest74(
			uint value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest74(UInt32, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt32, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest75(
			uint value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest75(UInt32, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, UInt32, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest76(
			uint? value,
			uint valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest76(Nullable`1<UInt32>, UInt32, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, UInt32, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest77(
			uint? value,
			uint valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest77(Nullable`1<UInt32>, UInt32, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, UInt32)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest78(
			uint? value,
			uint? valueBoundLower,
			uint valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest78(Nullable`1<UInt32>, Nullable`1<UInt32>, UInt32)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;, Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest79(
			uint? value,
			uint? valueBoundLower,
			uint? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest79(Nullable`1<UInt32>, Nullable`1<UInt32>, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest80(
			ulong value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest80(UInt64, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest81(
			ulong value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest81(UInt64, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest82(
			ulong value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest82(UInt64, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt64, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest83(
			ulong value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest83(UInt64, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, UInt64, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest84(
			ulong? value,
			ulong valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest84(Nullable`1<UInt64>, UInt64, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, UInt64, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest85(
			ulong? value,
			ulong valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest85(Nullable`1<UInt64>, UInt64, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, UInt64)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest86(
			ulong? value,
			ulong? valueBoundLower,
			ulong valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest86(Nullable`1<UInt64>, Nullable`1<UInt64>, UInt64)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;, Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest87(
			ulong? value,
			ulong? valueBoundLower,
			ulong? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest87(Nullable`1<UInt64>, Nullable`1<UInt64>, Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest88(
			ushort value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest88(UInt16, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest89(
			ushort value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest89(UInt16, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest90(
			ushort value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest90(UInt16, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(UInt16, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest91(
			ushort value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest91(UInt16, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, UInt16, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest92(
			ushort? value,
			ushort valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest92(Nullable`1<UInt16>, UInt16, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, UInt16, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest93(
			ushort? value,
			ushort valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest93(Nullable`1<UInt16>, UInt16, Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, UInt16)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest94(
			ushort? value,
			ushort? valueBoundLower,
			ushort valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest94(Nullable`1<UInt16>, Nullable`1<UInt16>, UInt16)
		}

		/// <summary>Test stub for IsOutsideExclusive(Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;, Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOutsideExclusiveTest95(
			ushort? value,
			ushort? valueBoundLower,
			ushort? valueBoundUpper
		)
		{
			bool result = RelationalTestingExtension.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper)
			  ;
			return result;
			// TODO: add assertions to method RelationalTestingExtensionTest.IsOutsideExclusiveTest95(Nullable`1<UInt16>, Nullable`1<UInt16>, Nullable`1<UInt16>)
		}
	}
}
