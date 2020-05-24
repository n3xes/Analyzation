#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="SignedIntegralNumberTestingExtension.cs">
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

namespace N3XeS.CSharp.Analyzation.Extensions
{
	#region Directives

	using System;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	using Utilities;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A signed integral number testing related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>07:49:04 PM</CreationTime>
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
	public static class SignedIntegralNumberTestingExtension
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
		///		Determines whether the provided <see cref="T:System.Numerics.BigInteger"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Numerics.BigInteger"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(this BigInteger value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Numerics.BigInteger"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative([CanBeNull] this BigInteger? value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

#endif

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Decimal"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Decimal"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(this Decimal value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Decimal"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative([CanBeNull] this Decimal? value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int32"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int32"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(this Int32 value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int32"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative([CanBeNull] this Int32? value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int64"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int64"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(this Int64 value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int64"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative([CanBeNull] this Int64? value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.SByte"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.SByte"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNegative(this SByte value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.SByte"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNegative([CanBeNull] this SByte? value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int16"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int16"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(this Int16 value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int16"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative([CanBeNull] this Int16? value)
		{
			return SignedIntegralNumberTestingUtility.IsNegative(value);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Numerics.BigInteger"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Numerics.BigInteger"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(this BigInteger value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Numerics.BigInteger"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive([CanBeNull] this BigInteger? value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

#endif

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Decimal"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Decimal"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(this Decimal value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Decimal"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive([CanBeNull] this Decimal? value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int32"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int32"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(this Int32 value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int32"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive([CanBeNull] this Int32? value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int64"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int64"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(this Int64 value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int64"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive([CanBeNull] this Int64? value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.SByte"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.SByte"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsPositive(this SByte value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.SByte"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsPositive([CanBeNull] this SByte? value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Int16"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int16"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(this Int16 value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Int16"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive([CanBeNull] this Int16? value)
		{
			return SignedIntegralNumberTestingUtility.IsPositive(value);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
