#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="RelationalTestingExtension.cs">
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

	using Utilities;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A relational testing related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Friday, June 28, 2013  (06/28/2013)</CreationDate>
	///  <CreationTime>07:11:31 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	public static class RelationalTestingExtension
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
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger value,
										BigInteger valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger value,
										BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger value,
										BigInteger? valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger? value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger? value,
										BigInteger valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger? value,
										BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this BigInteger? value,
										BigInteger? valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime value,
										DateTime valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime value,
										DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime value,
										DateTime? valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime? value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime? value,
										DateTime valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime? value,
										DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this DateTime? value,
										DateTime? valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte value,
										Byte valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte value,
										Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte value,
										Byte? valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte? value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte? value,
										Byte valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte? value,
										Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Byte? value,
										Byte? valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal value,
										Decimal valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal value,
										Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal value,
										Decimal? valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal? value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal? value,
										Decimal valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal? value,
										Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Decimal? value,
										Decimal? valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double value,
										Double valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double value,
										Double? valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double value,
										Double? valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double? value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double? value,
										Double valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double? value,
										Double? valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Double? value,
										Double? valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single value,
										Single valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single value,
										Single? valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single value,
										Single? valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single? value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single? value,
										Single valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single? value,
										Single? valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Single? value,
										Single? valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32 value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32 value,
										Int32 valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32 value,
										Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32 value,
										Int32? valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32? value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32? value,
										Int32 valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32? value,
										Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int32? value,
										Int32? valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64 value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64 value,
										Int64 valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64 value,
										Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64 value,
										Int64? valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64? value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64? value,
										Int64 valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64? value,
										Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween(this Int64? value,
										Int64? valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte value,
										SByte valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte value,
										SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte value,
										SByte? valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte? value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte? value,
										SByte valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte? value,
										SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this SByte? value,
										SByte? valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16 value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16 value,
										Int16 valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16 value,
										Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16 value,
										Int16? valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16? value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16? value,
										Int16 valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16? value,
										Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this Int16? value,
										Int16? valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32 value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32 value,
										UInt32 valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32 value,
										UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32 value,
										UInt32? valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32? value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32? value,
										UInt32 valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32? value,
										UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt32? value,
										UInt32? valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64 value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64 value,
										UInt64 valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64 value,
										UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64 value,
										UInt64? valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64? value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64? value,
										UInt64 valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64? value,
										UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt64? value,
										UInt64? valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16 value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16 value,
										UInt16 valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16 value,
										UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16 value,
										UInt16? valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16? value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16? value,
										UInt16 valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16? value,
										UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween(this UInt16? value,
										UInt16? valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger value,
												 BigInteger valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger value,
												 BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger value,
												 BigInteger? valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger? value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger? value,
												 BigInteger valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger? value,
												 BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this BigInteger? value,
												 BigInteger? valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime value,
												 DateTime valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime value,
												 DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime value,
												 DateTime? valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime? value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime? value,
												 DateTime valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime? value,
												 DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this DateTime? value,
												 DateTime? valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte value,
												 Byte valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte value,
												 Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte value,
												 Byte? valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte? value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte? value,
												 Byte valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte? value,
												 Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Byte? value,
												 Byte? valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal value,
												 Decimal valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal value,
												 Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal value,
												 Decimal? valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal? value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal? value,
												 Decimal valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal? value,
												 Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Decimal? value,
												 Decimal? valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double value,
												 Double valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double value,
												 Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double value,
												 Double? valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double? value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double? value,
												 Double valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double? value,
												 Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Double? value,
												 Double? valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single value,
												 Single valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single value,
												 Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single value,
												 Single? valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single? value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single? value,
												 Single valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single? value,
												 Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Single? value,
												 Single? valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32 value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32 value,
												 Int32 valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32 value,
												 Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32 value,
												 Int32? valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32? value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32? value,
												 Int32 valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32? value,
												 Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int32? value,
												 Int32? valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64 value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64 value,
												 Int64 valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64 value,
												 Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64 value,
												 Int64? valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64? value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64? value,
												 Int64 valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64? value,
												 Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int64? value,
												 Int64? valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte value,
												 SByte valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte value,
												 SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte value,
												 SByte? valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte? value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte? value,
												 SByte valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte? value,
												 SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this SByte? value,
												 SByte? valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16 value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16 value,
												 Int16 valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16 value,
												 Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16 value,
												 Int16? valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16? value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16? value,
												 Int16 valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16? value,
												 Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this Int16? value,
												 Int16? valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32 value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32 value,
												 UInt32 valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32 value,
												 UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32 value,
												 UInt32? valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32? value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32? value,
												 UInt32 valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32? value,
												 UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt32? value,
												 UInt32? valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64 value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64 value,
												 UInt64 valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64 value,
												 UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64 value,
												 UInt64? valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64? value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64? value,
												 UInt64 valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64? value,
												 UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt64? value,
												 UInt64? valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16 value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16 value,
												 UInt16 valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16 value,
												 UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16 value,
												 UInt16? valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16? value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16? value,
												 UInt16 valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16? value,
												 UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive(this UInt16? value,
												 UInt16? valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this BigInteger value, 
											BigInteger valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this BigInteger value,
											BigInteger? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this BigInteger? value,
											BigInteger valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this BigInteger? value,
											BigInteger? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this DateTime value,
											DateTime valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this DateTime value,
											DateTime? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this DateTime? value,
											DateTime valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this DateTime? value,
											DateTime? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Byte value, 
											Byte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Byte value,
											Byte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Byte? value,
											Byte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Byte? value,
											Byte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Decimal value,
											Decimal valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Decimal value,
											Decimal? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Decimal? value,
											Decimal valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Decimal? value,
											Decimal? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Double value, 
											Double valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Double value,
											Double? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Double? value,
											Double valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Double? value,
											Double? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Single value, 
											Single valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Single value,
											Single? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Single? value,
											Single valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Single? value,
											Single? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int32 value,
											Int32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int32 value,
											Int32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int32? value,
											Int32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int32? value,
											Int32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int64 value,
											Int64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int64 value,
											Int64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int64? value,
											Int64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int64? value,
											Int64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this SByte value,
											SByte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this SByte value,
											SByte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this SByte? value,
											SByte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this SByte? value,
											SByte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int16 value,
											Int16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int16 value,
											Int16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int16? value,
											Int16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this Int16? value,
											Int16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt32 value,
											UInt32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt32 value,
											UInt32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt32? value,
											UInt32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt32? value,
											UInt32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt64 value,
											UInt64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt64 value,
											UInt64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt64? value,
											UInt64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt64? value,
											UInt64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt16 value,
											UInt16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt16 value,
											UInt16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt16? value,
											UInt16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(this UInt16? value,
											UInt16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this BigInteger value,
												   BigInteger valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this BigInteger value,
												   BigInteger? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this BigInteger? value,
												   BigInteger valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this BigInteger? value,
												   BigInteger? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this DateTime value,
												   DateTime valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this DateTime value,
												   DateTime? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this DateTime? value,
												   DateTime valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this DateTime? value,
												   DateTime? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Byte value,
												   Byte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Byte value,
												   Byte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Byte? value,
												   Byte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Byte? value,
												   Byte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Decimal value,
												   Decimal valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Decimal value,
												   Decimal? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Decimal? value,
												   Decimal valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Decimal? value,
												   Decimal? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Double value,
												   Double valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Double value,
												   Double? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Double? value,
												   Double valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Double? value,
												   Double? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Single value,
												   Single valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Single value,
												   Single? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Single? value,
												   Single valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Single? value,
												   Single? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int32 value,
												   Int32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int32 value,
												   Int32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int32? value,
												   Int32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int32? value,
												   Int32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int64 value,
												   Int64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int64 value,
												   Int64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int64? value,
												   Int64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int64? value,
												   Int64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this SByte value,
												   SByte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this SByte value,
												   SByte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this SByte? value,
												   SByte valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this SByte? value,
												   SByte? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int16 value,
												   Int16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int16 value,
												   Int16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int16? value,
												   Int16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this Int16? value,
												   Int16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt32 value,
												   UInt32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt32 value,
												   UInt32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt32? value,
												   UInt32 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt32? value,
												   UInt32? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt64 value,
												   UInt64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt64 value,
												   UInt64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt64? value,
												   UInt64 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt64? value,
												   UInt64? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt16 value,
												   UInt16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt16 value,
												   UInt16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt16? value,
												   UInt16 valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual(this UInt16? value,
												   UInt16? valueBoundLower)
		{
			return RelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this BigInteger value,
										 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this BigInteger value,
										 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this BigInteger? value,
										 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this BigInteger? value,
										 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this DateTime value,
										 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this DateTime value,
										 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this DateTime? value,
										 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this DateTime? value,
										 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Byte value,
										 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Byte value,
										 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Byte? value,
										 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Byte? value,
										 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Decimal value,
										 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Decimal value,
										 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Decimal? value,
										 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Decimal? value,
										 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Double value,
										 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Double value,
										 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Double? value,
										 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Double? value,
										 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Single value,
										 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Single value,
										 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Single? value,
										 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Single? value,
										 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int32 value,
										 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int32 value,
										 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int32? value,
										 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int32? value,
										 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int64 value,
										 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int64 value,
										 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int64? value,
										 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int64? value,
										 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this SByte value,
										 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this SByte value,
										 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this SByte? value,
										 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this SByte? value,
										 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int16 value,
										 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int16 value,
										 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int16? value,
										 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this Int16? value,
										 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt32 value,
										 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt32 value,
										 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt32? value,
										 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt32? value,
										 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt64 value,
										 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt64 value,
										 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt64? value,
										 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt64? value,
										 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

				/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt16 value,
										 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt16 value,
										 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt16? value,
										 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan(this UInt16? value,
										 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}
		
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this BigInteger value,
												BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this BigInteger value,
												BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this BigInteger? value,
												BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this BigInteger? value,
												BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this DateTime value,
												DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this DateTime value,
												DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this DateTime? value,
												DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this DateTime? value,
												DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Byte value,
												Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Byte value,
												Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Byte? value,
												Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Byte? value,
												Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Decimal value,
												Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Decimal value,
												Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Decimal? value,
												Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Decimal? value,
												Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Double value,
												Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Double value,
												Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Double? value,
												Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Double? value,
												Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Single value,
												Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Single value,
												Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Single? value,
												Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Single? value,
												Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int32 value,
												Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int32 value,
												Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int32? value,
												Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int32? value,
												Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int64 value,
												Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int64 value,
												Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int64? value,
												Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int64? value,
												Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this SByte value,
												SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this SByte value,
												SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this SByte? value,
												SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this SByte? value,
												SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int16 value,
												Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int16 value,
												Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int16? value,
												Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this Int16? value,
												Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt32 value,
												UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt32 value,
												UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt32? value,
												UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt32? value,
												UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt64 value,
												UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt64 value,
												UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt64? value,
												UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt64? value,
												UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt16 value,
												UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt16 value,
												UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt16? value,
												UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual(this UInt16? value,
												UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger value,
										BigInteger valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger value,
										BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger value,
										BigInteger? valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger? value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger? value,
										BigInteger valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger? value,
										BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this BigInteger? value,
										BigInteger? valueBoundLower,
										BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime value,
										DateTime valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime value,
										DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime value,
										DateTime? valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime? value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime? value,
										DateTime valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime? value,
										DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this DateTime? value,
										DateTime? valueBoundLower,
										DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte value,
										Byte valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte value,
										Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte value,
										Byte? valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte? value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte? value,
										Byte valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte? value,
										Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Byte? value,
										Byte? valueBoundLower,
										Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal value,
										Decimal valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal value,
										Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal value,
										Decimal? valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal? value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal? value,
										Decimal valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal? value,
										Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Decimal? value,
										Decimal? valueBoundLower,
										Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double value,
										Double valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double value,
										Double? valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double value,
										Double? valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double? value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double? value,
										Double valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double? value,
										Double? valueBoundLower,
										Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Double? value,
										Double? valueBoundLower,
										Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single value,
										Single valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single value,
										Single? valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single value,
										Single? valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single? value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single? value,
										Single valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single? value,
										Single? valueBoundLower,
										Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Single? value,
										Single? valueBoundLower,
										Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32 value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32 value,
										Int32 valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32 value,
										Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32 value,
										Int32? valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32? value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32? value,
										Int32 valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32? value,
										Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int32? value,
										Int32? valueBoundLower,
										Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64 value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64 value,
										Int64 valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64 value,
										Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64 value,
										Int64? valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64? value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64? value,
										Int64 valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64? value,
										Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int64? value,
										Int64? valueBoundLower,
										Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte value,
										SByte valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte value,
										SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte value,
										SByte? valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte? value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte? value,
										SByte valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte? value,
										SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this SByte? value,
										SByte? valueBoundLower,
										SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16 value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16 value,
										Int16 valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16 value,
										Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16 value,
										Int16? valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16? value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16? value,
										Int16 valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16? value,
										Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this Int16? value,
										Int16? valueBoundLower,
										Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32 value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32 value,
										UInt32 valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32 value,
										UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32 value,
										UInt32? valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32? value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32? value,
										UInt32 valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32? value,
										UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt32? value,
										UInt32? valueBoundLower,
										UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64 value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64 value,
										UInt64 valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64 value,
										UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64 value,
										UInt64? valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64? value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64? value,
										UInt64 valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64? value,
										UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt64? value,
										UInt64? valueBoundLower,
										UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16 value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16 value,
										UInt16 valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16 value,
										UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16 value,
										UInt16? valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16? value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16? value,
										UInt16 valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16? value,
										UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside(this UInt16? value,
										UInt16? valueBoundLower,
										UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger value,
												 BigInteger valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger value,
												 BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger value,
												 BigInteger? valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger? value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger? value,
												 BigInteger valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger? value,
												 BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this BigInteger? value,
												 BigInteger? valueBoundLower,
												 BigInteger? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

#endif

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime value,
												 DateTime valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime value,
												 DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime value,
												 DateTime? valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime? value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime? value,
												 DateTime valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime? value,
												 DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this DateTime? value,
												 DateTime? valueBoundLower,
												 DateTime? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte value,
												 Byte valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte value,
												 Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte value,
												 Byte? valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte? value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte? value,
												 Byte valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte? value,
												 Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Byte? value,
												 Byte? valueBoundLower,
												 Byte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal value,
												 Decimal valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal value,
												 Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal value,
												 Decimal? valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal? value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal? value,
												 Decimal valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal? value,
												 Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Decimal? value,
												 Decimal? valueBoundLower,
												 Decimal? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double value,
												 Double valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double value,
												 Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double value,
												 Double? valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double? value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double? value,
												 Double valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double? value,
												 Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Double? value,
												 Double? valueBoundLower,
												 Double? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single value,
												 Single valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single value,
												 Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single value,
												 Single? valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single? value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single? value,
												 Single valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single? value,
												 Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Single? value,
												 Single? valueBoundLower,
												 Single? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32 value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32 value,
												 Int32 valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32 value,
												 Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32 value,
												 Int32? valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32? value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32? value,
												 Int32 valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32? value,
												 Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int32? value,
												 Int32? valueBoundLower,
												 Int32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64 value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64 value,
												 Int64 valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64 value,
												 Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64 value,
												 Int64? valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64? value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64? value,
												 Int64 valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64? value,
												 Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int64? value,
												 Int64? valueBoundLower,
												 Int64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte value,
												 SByte valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte value,
												 SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte value,
												 SByte? valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte? value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte? value,
												 SByte valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte? value,
												 SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this SByte? value,
												 SByte? valueBoundLower,
												 SByte? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16 value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16 value,
												 Int16 valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16 value,
												 Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16 value,
												 Int16? valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16? value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16? value,
												 Int16 valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16? value,
												 Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this Int16? value,
												 Int16? valueBoundLower,
												 Int16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32 value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32 value,
												 UInt32 valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32 value,
												 UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32 value,
												 UInt32? valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32? value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32? value,
												 UInt32 valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32? value,
												 UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt32? value,
												 UInt32? valueBoundLower,
												 UInt32? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64 value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64 value,
												 UInt64 valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64 value,
												 UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64 value,
												 UInt64? valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64? value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64? value,
												 UInt64 valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64? value,
												 UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt64? value,
												 UInt64? valueBoundLower,
												 UInt64? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16 value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16 value,
												 UInt16 valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16 value,
												 UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16 value,
												 UInt16? valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16? value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16? value,
												 UInt16 valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16? value,
												 UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive(this UInt16? value,
												 UInt16? valueBoundLower,
												 UInt16? valueBoundUpper)
		{
			return RelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
