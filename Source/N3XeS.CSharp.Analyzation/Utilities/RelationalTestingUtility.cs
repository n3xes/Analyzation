#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="RelationalTestingUtility.cs">
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

	using Extensions;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A relational testing related utility.
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
	[PublicAPI]
	// ReSharper disable once ClassTooBig
	public static class RelationalTestingUtility
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
		public static Boolean IsBetween(BigInteger value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(BigInteger value,
										BigInteger valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(BigInteger value,
										[CanBeNull] BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(BigInteger value,
										[CanBeNull] BigInteger? valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] BigInteger? value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] BigInteger? value,
										BigInteger valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] BigInteger? value,
										[CanBeNull] BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] BigInteger? value,
										[CanBeNull] BigInteger? valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(DateTime value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(DateTime value,
										DateTime valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(DateTime value,
										[CanBeNull] DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(DateTime value,
										[CanBeNull] DateTime? valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] DateTime? value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] DateTime? value,
										DateTime valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] DateTime? value,
										[CanBeNull] DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] DateTime? value,
										[CanBeNull] DateTime? valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Byte value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Byte value,
										Byte valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Byte value,
										[CanBeNull] Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Byte value,
										[CanBeNull] Byte? valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Byte? value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Byte? value,
										Byte valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Byte? value,
										[CanBeNull] Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Byte? value,
										[CanBeNull] Byte? valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Decimal value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Decimal value,
										Decimal valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Decimal value,
										[CanBeNull] Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Decimal value,
										[CanBeNull] Decimal? valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Decimal? value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Decimal? value,
										Decimal valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Decimal? value,
										[CanBeNull] Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Decimal? value,
										[CanBeNull] Decimal? valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Double value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Double value,
										Double valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Double value,
										[CanBeNull] Double? valueBoundLower,
										Double valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Double value,
										[CanBeNull] Double? valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Double? value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Double? value,
										Double valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Double? value,
										[CanBeNull] Double? valueBoundLower,
										Double valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Double? value,
										[CanBeNull] Double? valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Single value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Single value,
										Single valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Single value,
										[CanBeNull] Single? valueBoundLower,
										Single valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Single value,
										[CanBeNull] Single? valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Single? value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Single? value,
										Single valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Single? value,
										[CanBeNull] Single? valueBoundLower,
										Single valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Single? value,
										[CanBeNull] Single? valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int32 value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int32 value,
										Int32 valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int32 value,
										[CanBeNull] Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int32 value,
										[CanBeNull] Int32? valueBoundLower,
										Int32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int32? value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int32? value,
										Int32 valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int32? value,
										[CanBeNull] Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int32? value,
										[CanBeNull] Int32? valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int64 value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int64 value,
										Int64 valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int64 value,
										[CanBeNull] Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int64 value,
										[CanBeNull] Int64? valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int64? value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int64? value,
										Int64 valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int64? value,
										[CanBeNull] Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsBetween([CanBeNull] Int64? value,
										[CanBeNull] Int64? valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(SByte value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(SByte value,
										SByte valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(SByte value,
										[CanBeNull] SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(SByte value,
										[CanBeNull] SByte? valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] SByte? value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] SByte? value,
										SByte valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] SByte? value,
										[CanBeNull] SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] SByte? value,
										[CanBeNull] SByte? valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int16 value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) && 
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int16 value,
										Int16 valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int16 value,
										[CanBeNull] Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(Int16 value,
										[CanBeNull] Int16? valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] Int16? value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] Int16? value,
										Int16 valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] Int16? value,
										[CanBeNull] Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] Int16? value,
										[CanBeNull] Int16? valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt32 value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) && 
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt32 value,
										UInt32 valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt32 value,
										[CanBeNull] UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt32 value,
										[CanBeNull] UInt32? valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt32? value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt32? value,
										UInt32 valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt32? value,
										[CanBeNull] UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt32? value,
										[CanBeNull] UInt32? valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt64 value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) && 
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt64 value,
										UInt64 valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt64 value,
										[CanBeNull] UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt64 value,
										[CanBeNull] UInt64? valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt64? value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt64? value,
										UInt64 valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt64? value,
										[CanBeNull] UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt64? value,
										[CanBeNull] UInt64? valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt16 value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt16 value,
										UInt16 valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt16 value,
										[CanBeNull] UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetween(UInt16 value,
										[CanBeNull] UInt16? valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt16? value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt16? value,
										UInt16 valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt16? value,
										[CanBeNull] UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween([CanBeNull] UInt16? value,
										[CanBeNull] UInt16? valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundUpper) &&
				   value.IsGreaterThanOrEqual(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(BigInteger value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(BigInteger value,
												 BigInteger valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(BigInteger value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(BigInteger value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] BigInteger? value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] BigInteger? value,
												 BigInteger valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] BigInteger? value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] BigInteger? value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(DateTime value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(DateTime value,
												 DateTime valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(DateTime value,
												 [CanBeNull] DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(DateTime value,
												 [CanBeNull] DateTime? valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] DateTime? value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] DateTime? value,
												 DateTime valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] DateTime? value,
												 [CanBeNull] DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] DateTime? value,
												 [CanBeNull] DateTime? valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Byte value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Byte value,
												 Byte valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Byte value,
												 [CanBeNull] Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Byte value,
												 [CanBeNull] Byte? valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Byte? value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Byte? value,
												 Byte valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Byte? value,
												 [CanBeNull] Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Byte? value,
												 [CanBeNull] Byte? valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Decimal value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Decimal value,
												 Decimal valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Decimal value,
												 [CanBeNull] Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Decimal value,
												 [CanBeNull] Decimal? valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Decimal? value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Decimal? value,
												 Decimal valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Decimal? value,
												 [CanBeNull] Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Decimal? value,
												 [CanBeNull] Decimal? valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Double value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Double value,
												 Double valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Double value,
												 [CanBeNull] Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Double value,
												 [CanBeNull] Double? valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Double? value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Double? value,
												 Double valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Double? value,
												 [CanBeNull] Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Double? value,
												 [CanBeNull] Double? valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Single value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Single value,
												 Single valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Single value,
												 [CanBeNull] Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Single value,
												 [CanBeNull] Single? valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Single? value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Single? value,
												 Single valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Single? value,
												 [CanBeNull] Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Single? value,
												 [CanBeNull] Single? valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int32 value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int32 value,
												 Int32 valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int32 value,
												 [CanBeNull] Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int32 value,
												 Int32? valueBoundLower,
												 Int32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int32? value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int32? value,
												 Int32 valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int32? value,
												 [CanBeNull] Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int32? value,
												 [CanBeNull] Int32? valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int64 value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int64 value,
												 Int64 valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int64 value,
												 [CanBeNull] Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int64 value,
												 [CanBeNull] Int64? valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int64? value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int64? value,
												 Int64 valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int64? value,
												 [CanBeNull] Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int64? value,
												 [CanBeNull] Int64? valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(SByte value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(SByte value,
												 SByte valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(SByte value,
												 [CanBeNull] SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(SByte value,
												 [CanBeNull] SByte? valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] SByte? value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] SByte? value,
												 SByte valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] SByte? value,
												 [CanBeNull] SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] SByte? value,
												 [CanBeNull] SByte? valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int16 value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int16 value,
												 Int16 valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int16 value,
												 [CanBeNull] Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(Int16 value,
												 [CanBeNull] Int16? valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int16? value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int16? value,
												 Int16 valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int16? value,
												 [CanBeNull] Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] Int16? value,
												 [CanBeNull] Int16? valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt32 value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt32 value,
												 UInt32 valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt32 value,
												 [CanBeNull] UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt32 value,
												 [CanBeNull] UInt32? valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt32? value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt32? value,
												 UInt32 valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt32? value,
												 [CanBeNull] UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt32? value,
												 [CanBeNull] UInt32? valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt64 value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt64 value,
												 UInt64 valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt64 value,
												 [CanBeNull] UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt64 value,
												 [CanBeNull] UInt64? valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt64? value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt64? value,
												 UInt64 valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt64? value,
												 [CanBeNull] UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt64? value,
												 [CanBeNull] UInt64? valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt16 value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt16 value,
												 UInt16 valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt16 value,
												 [CanBeNull] UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsBetweenExclusive(UInt16 value,
												 [CanBeNull] UInt16? valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt16? value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt16? value,
												 UInt16 valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt16? value,
												 [CanBeNull] UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive([CanBeNull] UInt16? value,
												 [CanBeNull] UInt16? valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundUpper) &&
				   value.IsGreaterThan(valueBoundLower);
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
		public static Boolean IsGreaterThan(BigInteger value, 
											BigInteger valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(BigInteger value,
											[CanBeNull] BigInteger? valueBoundLower)
		{
			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] BigInteger? value,
											BigInteger valueBoundLower)
		{
			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] BigInteger? value,
											[CanBeNull] BigInteger? valueBoundLower)
		{
			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(DateTime value,
											DateTime valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(DateTime value,
											[CanBeNull] DateTime? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] DateTime? value,
											DateTime valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] DateTime? value,
											[CanBeNull] DateTime? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Byte value, 
											Byte valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Byte value,
											[CanBeNull] Byte? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Byte? value,
											Byte valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Byte? value,
											[CanBeNull] Byte? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Decimal value,
											Decimal valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Decimal value,
											[CanBeNull] Decimal? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Decimal? value,
											Decimal valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Decimal? value,
											[CanBeNull] Decimal? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Double value, 
											Double valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Double value,
											[CanBeNull] Double? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Double? value,
											Double valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Double? value,
											[CanBeNull] Double? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Single value, 
											Single valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Single value,
											[CanBeNull] Single? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Single? value,
											Single valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Single? value,
											[CanBeNull] Single? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Int32 value,
											Int32 valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Int32 value,
											[CanBeNull] Int32? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Int32? value,
											Int32 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan(Int32? value,
											Int32? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Int64 value,
											Int64 valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Int64 value,
											[CanBeNull] Int64? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Int64? value,
											Int64 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Int64? value,
											[CanBeNull] Int64? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(SByte value,
											SByte valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(SByte value,
											[CanBeNull] SByte? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] SByte? value,
											SByte valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] SByte? value,
											[CanBeNull] SByte? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(Int16 value,
											Int16 valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(Int16 value,
											[CanBeNull] Int16? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Int16? value,
											Int16 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] Int16? value,
											[CanBeNull] Int16? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(UInt32 value,
											UInt32 valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(UInt32 value,
											[CanBeNull] UInt32? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] UInt32? value,
											UInt32 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] UInt32? value,
											[CanBeNull] UInt32? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(UInt64 value,
											UInt64 valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(UInt64 value,
											[CanBeNull] UInt64? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] UInt64? value,
											UInt64 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] UInt64? value,
											[CanBeNull] UInt64? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThan(UInt16 value,
											UInt16 valueBoundLower)
		{
			return value > valueBoundLower;
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
		public static Boolean IsGreaterThan(UInt16 value,
											[CanBeNull] UInt16? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value > valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] UInt16? value,
											UInt16 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan([CanBeNull] UInt16? value,
											[CanBeNull] UInt16? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() > valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(BigInteger value,
												   BigInteger valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(BigInteger value,
												   [CanBeNull] BigInteger? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] BigInteger? value,
												   BigInteger valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] BigInteger? value,
												   [CanBeNull] BigInteger? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(DateTime value,
												   DateTime valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(DateTime value,
												   [CanBeNull] DateTime? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] DateTime? value,
												   DateTime valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] DateTime? value,
												   [CanBeNull] DateTime? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Byte value,
												   Byte valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Byte value,
												   [CanBeNull] Byte? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Byte? value,
												   Byte valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Byte? value,
												   [CanBeNull] Byte? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Decimal value,
												   Decimal valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Decimal value,
												   [CanBeNull] Decimal? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Decimal? value,
												   Decimal valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Decimal? value,
												   [CanBeNull] Decimal? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Double value,
												   Double valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Double value,
												   [CanBeNull] Double? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Double? value,
												   Double valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Double? value,
												   [CanBeNull] Double? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Single value,
												   Single valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Single value,
												   [CanBeNull] Single? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Single? value,
												   Single valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Single? value,
												   [CanBeNull] Single? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Int32 value,
												   Int32 valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Int32 value,
												   [CanBeNull] Int32? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Int32? value,
												   Int32 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Int32? value,
												   [CanBeNull] Int32? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Int64 value,
												   Int64 valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Int64 value,
												   [CanBeNull] Int64? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Int64? value,
												   Int64 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Int64? value,
												   [CanBeNull] Int64? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(SByte value,
												   SByte valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(SByte value,
												   [CanBeNull] SByte? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] SByte? value,
												   SByte valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] SByte? value,
												   [CanBeNull] SByte? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(Int16 value,
												   Int16 valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(Int16 value,
												   [CanBeNull] Int16? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Int16? value,
												   Int16 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] Int16? value,
												   [CanBeNull] Int16? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(UInt32 value,
												   UInt32 valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(UInt32 value,
												   [CanBeNull] UInt32? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] UInt32? value,
												   UInt32 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] UInt32? value,
												   [CanBeNull] UInt32? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(UInt64 value,
												   UInt64 valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(UInt64 value,
												   [CanBeNull] UInt64? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] UInt64? value,
												   UInt64 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] UInt64? value,
												   [CanBeNull] UInt64? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsGreaterThanOrEqual(UInt16 value,
												   UInt16 valueBoundLower)
		{
			return value >= valueBoundLower;
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
		public static Boolean IsGreaterThanOrEqual(UInt16 value,
												   [CanBeNull] UInt16? valueBoundLower)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value >= valueBoundLower.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] UInt16? value,
												   UInt16 valueBoundLower)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual([CanBeNull] UInt16? value,
												   [CanBeNull] UInt16? valueBoundLower)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() >= valueBoundLower.GetValueOrDefault();
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
		public static Boolean IsLessThan(BigInteger value,
										 BigInteger valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(BigInteger value,
										 [CanBeNull] BigInteger? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] BigInteger? value,
										 BigInteger valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] BigInteger? value,
										 [CanBeNull] BigInteger? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(DateTime value,
										 DateTime valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(DateTime value,
										 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] DateTime? value,
										 DateTime valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] DateTime? value,
										 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Byte value,
										 Byte valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Byte value,
										 [CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Byte? value,
										 Byte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Byte? value,
										 [CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Decimal value,
										 Decimal valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Decimal value,
										 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Decimal? value,
										 Decimal valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Decimal? value,
										 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Double value,
										 Double valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Double value,
										 [CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Double? value,
										 Double valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Double? value,
										 [CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Single value,
										 Single valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Single value,
										 [CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Single? value,
										 Single valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Single? value,
										 [CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Int32 value,
										 Int32 valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Int32 value,
										 [CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Int32? value,
										 Int32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Int32? value,
										 [CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Int64 value,
										 Int64 valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Int64 value,
										 [CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Int64? value,
										 Int64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Int64? value,
										 [CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(SByte value,
										 SByte valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(SByte value,
										 [CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] SByte? value,
										 SByte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] SByte? value,
										 [CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(Int16 value,
										 Int16 valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(Int16 value,
										 [CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Int16? value,
										 Int16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] Int16? value,
										 [CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(UInt32 value,
										 UInt32 valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(UInt32 value,
										 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] UInt32? value,
										 UInt32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] UInt32? value,
										 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(UInt64 value,
										 UInt64 valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(UInt64 value,
										 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] UInt64? value,
										 UInt64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] UInt64? value,
										 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThan(UInt16 value,
										 UInt16 valueBoundUpper)
		{
			return value < valueBoundUpper;
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
		public static Boolean IsLessThan(UInt16 value,
										 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value < valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] UInt16? value,
										 UInt16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan([CanBeNull] UInt16? value,
										 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() < valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(BigInteger value,
												BigInteger valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(BigInteger value,
												[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] BigInteger? value,
												BigInteger valueBoundUpper)
		{
			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] BigInteger? value,
												[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(DateTime value,
												DateTime valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(DateTime value,
												[CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] DateTime? value,
												DateTime valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] DateTime? value,
												[CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Byte value,
												Byte valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Byte value,
												[CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Byte? value,
												Byte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Byte? value,
												[CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Decimal value,
												Decimal valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Decimal value,
												[CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Decimal? value,
												Decimal valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Decimal? value,
												[CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Double value,
												Double valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Double value,
												[CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Double? value,
												Double valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Double? value,
												[CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Single value,
												Single valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Single value,
												[CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Single? value,
												Single valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Single? value,
												[CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Int32 value,
												Int32 valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Int32 value,
												[CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Int32? value,
												Int32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Int32? value,
												[CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Int64 value,
												Int64 valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Int64 value,
												[CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Int64? value,
												Int64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Int64? value,
												[CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(SByte value,
												SByte valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(SByte value,
												[CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] SByte? value,
												SByte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] SByte? value,
												[CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(Int16 value,
												Int16 valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(Int16 value,
												[CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Int16? value,
												Int16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] Int16? value,
												[CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(UInt32 value,
												UInt32 valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(UInt32 value,
												[CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] UInt32? value,
												UInt32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] UInt32? value,
												[CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(UInt64 value,
												UInt64 valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(UInt64 value,
												[CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] UInt64? value,
												UInt64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] UInt64? value,
												[CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsLessThanOrEqual(UInt16 value,
												UInt16 valueBoundUpper)
		{
			return value <= valueBoundUpper;
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
		public static Boolean IsLessThanOrEqual(UInt16 value,
												[CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value <= valueBoundUpper.GetValueOrDefault();
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] UInt16? value,
												UInt16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper;
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual([CanBeNull] UInt16? value,
												[CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.GetValueOrDefault() <= valueBoundUpper.GetValueOrDefault();
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
		public static Boolean IsOutside(BigInteger value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsGreaterThanOrEqual(valueBoundUpper) &&
				   value.IsLessThanOrEqual(valueBoundLower);
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
		public static Boolean IsOutside(BigInteger value,
										BigInteger valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(BigInteger value,
										[CanBeNull] BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(BigInteger value,
										[CanBeNull] BigInteger? valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] BigInteger? value,
										BigInteger valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] BigInteger? value,
										BigInteger valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] BigInteger? value,
										[CanBeNull] BigInteger? valueBoundLower,
										BigInteger valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] BigInteger? value,
										[CanBeNull] BigInteger? valueBoundLower,
										[CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(DateTime value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(DateTime value,
										DateTime valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(DateTime value,
										[CanBeNull] DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(DateTime value,
										[CanBeNull] DateTime? valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] DateTime? value,
										DateTime valueBoundLower,
										DateTime valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] DateTime? value,
										DateTime valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] DateTime? value,
										[CanBeNull] DateTime? valueBoundLower,
										DateTime valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] DateTime? value,
										[CanBeNull] DateTime? valueBoundLower,
										[CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Byte value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Byte value,
										Byte valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Byte value,
										[CanBeNull] Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Byte value,
										[CanBeNull] Byte? valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Byte? value,
										Byte valueBoundLower,
										Byte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Byte? value,
										Byte valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Byte? value,
										[CanBeNull] Byte? valueBoundLower,
										Byte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Byte? value,
										[CanBeNull] Byte? valueBoundLower,
										[CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Decimal value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Decimal value,
										Decimal valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Decimal value,
										[CanBeNull] Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Decimal value,
										[CanBeNull] Decimal? valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Decimal? value,
										Decimal valueBoundLower,
										Decimal valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Decimal? value,
										Decimal valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Decimal? value,
										[CanBeNull] Decimal? valueBoundLower,
										Decimal valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Decimal? value,
										[CanBeNull] Decimal? valueBoundLower,
										[CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Double value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Double value,
										Double valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Double value,
										[CanBeNull] Double? valueBoundLower,
										Double valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Double value,
										[CanBeNull] Double? valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Double? value,
										Double valueBoundLower,
										Double valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Double? value,
										Double valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Double? value,
										[CanBeNull] Double? valueBoundLower,
										Double valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Double? value,
										[CanBeNull] Double? valueBoundLower,
										[CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Single value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Single value,
										Single valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Single value,
										[CanBeNull] Single? valueBoundLower,
										Single valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Single value,
										[CanBeNull] Single? valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Single? value,
										Single valueBoundLower,
										Single valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Single? value,
										Single valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Single? value,
										[CanBeNull] Single? valueBoundLower,
										Single valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Single? value,
										[CanBeNull] Single? valueBoundLower,
										[CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int32 value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int32 value,
										Int32 valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int32 value,
										[CanBeNull] Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int32 value,
										[CanBeNull] Int32? valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int32? value,
										Int32 valueBoundLower,
										Int32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int32? value,
										Int32 valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int32? value,
										[CanBeNull] Int32? valueBoundLower,
										Int32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int32? value,
										[CanBeNull] Int32? valueBoundLower,
										[CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int64 value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int64 value,
										Int64 valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int64 value,
										[CanBeNull] Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int64 value,
										[CanBeNull] Int64? valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int64? value,
										Int64 valueBoundLower,
										Int64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int64? value,
										Int64 valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int64? value,
										[CanBeNull] Int64? valueBoundLower,
										Int64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int64? value,
										[CanBeNull] Int64? valueBoundLower,
										[CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(SByte value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(SByte value,
										SByte valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(SByte value,
										[CanBeNull] SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(SByte value,
										[CanBeNull] SByte? valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] SByte? value,
										SByte valueBoundLower,
										SByte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] SByte? value,
										SByte valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] SByte? value,
										[CanBeNull] SByte? valueBoundLower,
										SByte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] SByte? value,
										[CanBeNull] SByte? valueBoundLower,
										[CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int16 value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int16 value,
										Int16 valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int16 value,
										[CanBeNull] Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(Int16 value,
										[CanBeNull] Int16? valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int16? value,
										Int16 valueBoundLower,
										Int16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int16? value,
										Int16 valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int16? value,
										[CanBeNull] Int16? valueBoundLower,
										Int16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] Int16? value,
										[CanBeNull] Int16? valueBoundLower,
										[CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt32 value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt32 value,
										UInt32 valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt32 value,
										[CanBeNull] UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt32 value,
										[CanBeNull] UInt32? valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt32? value,
										UInt32 valueBoundLower,
										UInt32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt32? value,
										UInt32 valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt32? value,
										[CanBeNull] UInt32? valueBoundLower,
										UInt32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt32? value,
										[CanBeNull] UInt32? valueBoundLower,
										[CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt64 value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt64 value,
										UInt64 valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt64 value,
										[CanBeNull] UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt64 value,
										[CanBeNull] UInt64? valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt64? value,
										UInt64 valueBoundLower,
										UInt64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt64? value,
										UInt64 valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt64? value,
										[CanBeNull] UInt64? valueBoundLower,
										UInt64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt64? value,
										[CanBeNull] UInt64? valueBoundLower,
										[CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt16 value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt16 value,
										UInt16 valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt16 value,
										[CanBeNull] UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutside(UInt16 value,
										[CanBeNull] UInt16? valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt16? value,
										UInt16 valueBoundLower,
										UInt16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt16? value,
										UInt16 valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt16? value,
										[CanBeNull] UInt16? valueBoundLower,
										UInt16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside([CanBeNull] UInt16? value,
										[CanBeNull] UInt16? valueBoundLower,
										[CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThanOrEqual(valueBoundLower) &&
				   value.IsGreaterThanOrEqual(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(BigInteger value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(BigInteger value,
												 BigInteger valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(BigInteger value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(BigInteger value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] BigInteger? value,
												 BigInteger valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] BigInteger? value,
												 BigInteger valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] BigInteger? value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 BigInteger valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] BigInteger? value,
												 [CanBeNull] BigInteger? valueBoundLower,
												 [CanBeNull] BigInteger? valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(DateTime value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(DateTime value,
												 DateTime valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(DateTime value,
												 [CanBeNull] DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(DateTime value,
												 [CanBeNull] DateTime? valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] DateTime? value,
												 DateTime valueBoundLower,
												 DateTime valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] DateTime? value,
												 DateTime valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] DateTime? value,
												 [CanBeNull] DateTime? valueBoundLower,
												 DateTime valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] DateTime? value,
												 [CanBeNull] DateTime? valueBoundLower,
												 [CanBeNull] DateTime? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Byte value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Byte value,
												 Byte valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Byte value,
												 [CanBeNull] Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Byte value,
												 [CanBeNull] Byte? valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Byte? value,
												 Byte valueBoundLower,
												 Byte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Byte? value,
												 Byte valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Byte? value,
												 [CanBeNull] Byte? valueBoundLower,
												 Byte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Byte? value,
												 [CanBeNull] Byte? valueBoundLower,
												 [CanBeNull] Byte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Decimal value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Decimal value,
												 Decimal valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Decimal value,
												 [CanBeNull] Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Decimal value,
												 [CanBeNull] Decimal? valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Decimal? value,
												 Decimal valueBoundLower,
												 Decimal valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Decimal? value,
												 Decimal valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Decimal? value,
												 [CanBeNull] Decimal? valueBoundLower,
												 Decimal valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Decimal? value,
												 [CanBeNull] Decimal? valueBoundLower,
												 [CanBeNull] Decimal? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Double value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Double value,
												 Double valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Double value,
												 [CanBeNull] Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Double value,
												 [CanBeNull] Double? valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Double? value,
												 Double valueBoundLower,
												 Double valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Double? value,
												 Double valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Double? value,
												 [CanBeNull] Double? valueBoundLower,
												 Double valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Double? value,
												 [CanBeNull] Double? valueBoundLower,
												 [CanBeNull] Double? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Single value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Single value,
												 Single valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Single value,
												 [CanBeNull] Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Single value,
												 [CanBeNull] Single? valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Single? value,
												 Single valueBoundLower,
												 Single valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Single? value,
												 Single valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Single? value,
												 [CanBeNull] Single? valueBoundLower,
												 Single valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Single? value,
												 [CanBeNull] Single? valueBoundLower,
												 [CanBeNull] Single? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int32 value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int32 value,
												 Int32 valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int32 value,
												 [CanBeNull] Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int32 value,
												 [CanBeNull] Int32? valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int32? value,
												 Int32 valueBoundLower,
												 Int32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int32? value,
												 Int32 valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int32? value,
												 [CanBeNull] Int32? valueBoundLower,
												 Int32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int32? value,
												 [CanBeNull] Int32? valueBoundLower,
												 [CanBeNull] Int32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int64 value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int64 value,
												 Int64 valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int64 value,
												 [CanBeNull] Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int64 value,
												 [CanBeNull] Int64? valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int64? value,
												 Int64 valueBoundLower,
												 Int64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int64? value,
												 Int64 valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int64? value,
												 [CanBeNull] Int64? valueBoundLower,
												 Int64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int64? value,
												 [CanBeNull] Int64? valueBoundLower,
												 [CanBeNull] Int64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(SByte value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(SByte value,
												 SByte valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(SByte value,
												 [CanBeNull] SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(SByte value,
												 [CanBeNull] SByte? valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] SByte? value,
												 SByte valueBoundLower,
												 SByte valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] SByte? value,
												 SByte valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] SByte? value,
												 [CanBeNull] SByte? valueBoundLower,
												 SByte valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] SByte? value,
												 [CanBeNull] SByte? valueBoundLower,
												 [CanBeNull] SByte? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int16 value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int16 value,
												 Int16 valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int16 value,
												 [CanBeNull] Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(Int16 value,
												 [CanBeNull] Int16? valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int16? value,
												 Int16 valueBoundLower,
												 Int16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int16? value,
												 Int16 valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int16? value,
												 [CanBeNull] Int16? valueBoundLower,
												 Int16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] Int16? value,
												 [CanBeNull] Int16? valueBoundLower,
												 [CanBeNull] Int16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt32 value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt32 value,
												 UInt32 valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt32 value,
												 [CanBeNull] UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt32 value,
												 [CanBeNull] UInt32? valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt32? value,
												 UInt32 valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt32? value,
												 UInt32 valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt32? value,
												 [CanBeNull] UInt32? valueBoundLower,
												 UInt32 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt32? value,
												 [CanBeNull] UInt32? valueBoundLower,
												 [CanBeNull] UInt32? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt64 value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt64 value,
												 UInt64 valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt64 value,
												 [CanBeNull] UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt64 value,
												 [CanBeNull] UInt64? valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt64? value,
												 UInt64 valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt64? value,
												 UInt64 valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt64? value,
												 [CanBeNull] UInt64? valueBoundLower,
												 UInt64 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt64? value,
												 [CanBeNull] UInt64? valueBoundLower,
												 [CanBeNull] UInt64? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt16 value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt16 value,
												 UInt16 valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt16 value,
												 [CanBeNull] UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			if (valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
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
		public static Boolean IsOutsideExclusive(UInt16 value,
												 [CanBeNull] UInt16? valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt16? value,
												 UInt16 valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			if (value.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt16? value,
												 UInt16 valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt16? value,
												 [CanBeNull] UInt16? valueBoundLower,
												 UInt16 valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive([CanBeNull] UInt16? value,
												 [CanBeNull] UInt16? valueBoundLower,
												 [CanBeNull] UInt16? valueBoundUpper)
		{
			if (value.IsNull() || valueBoundLower.IsNull() || valueBoundUpper.IsNull())
			{
				return false;
			}

			return value.IsLessThan(valueBoundLower) &&
				   value.IsGreaterThan(valueBoundUpper);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
