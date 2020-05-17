#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="IntegralParityTestingUtility.cs">
//		Copyright © 2013, John Caruthers
//		All rights reserved.
//
//		THIS PROGRAM ND ALL OF THE INFORMATION CONTAINED HEREIN IS FREE SOFTWARE:
//		YOU CAN REDISTRIBUTE IT AND/OR MODIFY IT UNDER THE TERMS OF THE GNU GENERAL
//		PUBLIC LICENSE AS PUBLISHED BY THE FREE SOFTWARE FOUNDATION, EITHER VERSION
//		3 OF THE LICENSE, OR (AT YOUR OPTION) ANY LATER VERSION.
//
//		THIS PROGRAM IS DISTRIBUTED IN THE HOPE THAT IT WILL BE USEFUL, BUT WITHOUT
//		ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR FITNESS
//		FOR A PARTICULAR PURPOSE.SEE THE GNU GENERAL PUBLIC LICENSE FOR MORE DETAILS.
//
//		YOU SHOULD HAVE RECEIVED A COPY OF THE GNU GENERAL PUBLIC LICENSE ALONG
//		WITH THIS PROGRAM.  IF NOT, SEE https://www.gnu.org/licenses/.
//
// </copyright>
////====================================================================================================================

#endregion

namespace N3XeS.CSharp.Analyzation.Utilities
{
	#region Directives

	using System;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A integral parity testing related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Friday, October 18, 2013  (10/18/2013)</CreationDate>
	///  <CreationTime>03:00:28 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	[PublicAPI]
	// ReSharper disable once ClassTooBig
	public static class IntegralParityTestingUtility
	{
		#region Constants

		#endregion

		#region Instance/Member/Field Variables

		#endregion

		#region Constructors

		#endregion

		#region Destructor

		#endregion

		#region Events

		#endregion

		#region Properties/Accessors/Mutators

		#endregion

		#region Indexers

		#endregion

		#region Event Handlers

		#endregion

		#region Methods/Functions

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Numerics.BigInteger"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Numerics.BigInteger"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(BigInteger value)
		{
			return value.IsEven;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(BigInteger? value)
		{
			return value.HasValue && value.GetValueOrDefault().IsEven;
		}

#endif

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Byte"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Byte"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Byte value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Byte? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Decimal"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Decimal"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Decimal value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Decimal? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int32"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int32"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Int32 value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Int32? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int64"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int64"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Int64 value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Int64? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.SByte"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.SByte"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(SByte value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(SByte? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int16"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int16"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Int16 value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(Int16? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.UInt32"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.UInt32"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(UInt32 value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(UInt32? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.UInt64"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.UInt64"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(UInt64 value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(UInt64? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.UInt16"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.UInt16"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(UInt16 value)
		{
			return (value % 2) == 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value is even; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsEven(UInt16? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) == 0);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Numerics.BigInteger"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Numerics.BigInteger"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(BigInteger value)
		{
			return !value.IsEven;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(BigInteger? value)
		{
			return value.HasValue && !value.GetValueOrDefault().IsEven;
		}

#endif

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Byte"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Byte"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Byte value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Byte? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Decimal"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Decimal"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Decimal value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Decimal? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int32"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int32"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Int32 value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Int32? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int64"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int64"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Int64 value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Int64? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.SByte"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.SByte"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(SByte value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(SByte? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int16"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int16"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Int16 value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(Int16? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.UInt32"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.UInt32"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(UInt32 value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(UInt32? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.UInt64"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.UInt64"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(UInt64 value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(UInt64? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.UInt16"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.UInt16"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(UInt16 value)
		{
			return (value % 2) != 0;
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> value is odd; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOdd(UInt16? value)
		{
			return value.HasValue && ((value.GetValueOrDefault() % 2) != 0);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
