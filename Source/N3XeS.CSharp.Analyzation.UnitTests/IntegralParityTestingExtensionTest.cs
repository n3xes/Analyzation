// <copyright company="John Caruthers" file="IntegralParityTestingExtensionTest.cs">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Analyzation.Extensions;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for IntegralParityTestingExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(IntegralParityTestingExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class IntegralParityTestingExtensionTest
	{

		/// <summary>Test stub for IsEven(Byte)</summary>
		[PexMethod]
		public bool IsEvenTest(byte value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest(Byte)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest01(byte? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest01(Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsEven(Decimal)</summary>
		[PexMethod]
		public bool IsEvenTest02(decimal value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest02(Decimal)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest03(decimal? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest03(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsEven(Int32)</summary>
		[PexMethod]
		public bool IsEvenTest04(int value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest04(Int32)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest05(int? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest05(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsEven(Int64)</summary>
		[PexMethod]
		public bool IsEvenTest06(long value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest06(Int64)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest07(long? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest07(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsEven(SByte)</summary>
		[PexMethod]
		public bool IsEvenTest08(sbyte value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest08(SByte)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest09(sbyte? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest09(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsEven(Int16)</summary>
		[PexMethod]
		public bool IsEvenTest10(short value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest10(Int16)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest11(short? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest11(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsEven(UInt32)</summary>
		[PexMethod]
		public bool IsEvenTest12(uint value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest12(UInt32)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest13(uint? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest13(Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsEven(UInt64)</summary>
		[PexMethod]
		public bool IsEvenTest14(ulong value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest14(UInt64)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest15(ulong? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest15(Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsEven(UInt16)</summary>
		[PexMethod]
		public bool IsEvenTest16(ushort value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest16(UInt16)
		}

		/// <summary>Test stub for IsEven(Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsEvenTest17(ushort? value)
		{
			bool result = IntegralParityTestingExtension.IsEven(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsEvenTest17(Nullable`1<UInt16>)
		}

		/// <summary>Test stub for IsOdd(Byte)</summary>
		[PexMethod]
		public bool IsOddTest(byte value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest(Byte)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Byte&gt;)</summary>
		[PexMethod]
		public bool IsOddTest01(byte? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest01(Nullable`1<Byte>)
		}

		/// <summary>Test stub for IsOdd(Decimal)</summary>
		[PexMethod]
		public bool IsOddTest02(decimal value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest02(Decimal)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Decimal&gt;)</summary>
		[PexMethod]
		public bool IsOddTest03(decimal? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest03(Nullable`1<Decimal>)
		}

		/// <summary>Test stub for IsOdd(Int32)</summary>
		[PexMethod]
		public bool IsOddTest04(int value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest04(Int32)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Int32&gt;)</summary>
		[PexMethod]
		public bool IsOddTest05(int? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest05(Nullable`1<Int32>)
		}

		/// <summary>Test stub for IsOdd(Int64)</summary>
		[PexMethod]
		public bool IsOddTest06(long value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest06(Int64)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Int64&gt;)</summary>
		[PexMethod]
		public bool IsOddTest07(long? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest07(Nullable`1<Int64>)
		}

		/// <summary>Test stub for IsOdd(SByte)</summary>
		[PexMethod]
		public bool IsOddTest08(sbyte value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest08(SByte)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;SByte&gt;)</summary>
		[PexMethod]
		public bool IsOddTest09(sbyte? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest09(Nullable`1<SByte>)
		}

		/// <summary>Test stub for IsOdd(Int16)</summary>
		[PexMethod]
		public bool IsOddTest10(short value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest10(Int16)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;Int16&gt;)</summary>
		[PexMethod]
		public bool IsOddTest11(short? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest11(Nullable`1<Int16>)
		}

		/// <summary>Test stub for IsOdd(UInt32)</summary>
		[PexMethod]
		public bool IsOddTest12(uint value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest12(UInt32)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public bool IsOddTest13(uint? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest13(Nullable`1<UInt32>)
		}

		/// <summary>Test stub for IsOdd(UInt64)</summary>
		[PexMethod]
		public bool IsOddTest14(ulong value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest14(UInt64)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;UInt64&gt;)</summary>
		[PexMethod]
		public bool IsOddTest15(ulong? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest15(Nullable`1<UInt64>)
		}

		/// <summary>Test stub for IsOdd(UInt16)</summary>
		[PexMethod]
		public bool IsOddTest16(ushort value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest16(UInt16)
		}

		/// <summary>Test stub for IsOdd(Nullable`1&lt;UInt16&gt;)</summary>
		[PexMethod]
		public bool IsOddTest17(ushort? value)
		{
			bool result = IntegralParityTestingExtension.IsOdd(value);
			return result;
			// TODO: add assertions to method IntegralParityTestingExtensionTest.IsOddTest17(Nullable`1<UInt16>)
		}
	}
}
