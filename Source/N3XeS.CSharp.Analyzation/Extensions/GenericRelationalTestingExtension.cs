#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="GenericRelationalTestingExtension.cs">
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
	///		A generic relational testing related extension.
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
	public static class GenericRelationalTestingExtension
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

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>([CanBeNull] this T value,
										   [CanBeNull] T valueBoundLower,
										   [CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>(this T value,
										   T valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>(this T value,
										   [CanBeNull] T? valueBoundLower,
										   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>(this T value,
										   [CanBeNull] T? valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>([CanBeNull] this T? value,
										   T valueBoundLower,
										   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>([CanBeNull] this T? value,
										   T valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>([CanBeNull] this T? value,
										   [CanBeNull] T? valueBoundLower,
										   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/> and less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetween<T>([CanBeNull] this T? value,
										   [CanBeNull] T? valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetween(value, valueBoundLower, valueBoundUpper);
		}		

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>([CanBeNull] this T value,
													[CanBeNull] T valueBoundLower,
													[CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>(this T value,
													T valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>(this T value,
													[CanBeNull] T? valueBoundLower,
													T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>(this T value,
													[CanBeNull] T? valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>([CanBeNull] this T? value,
													T valueBoundLower,
													T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>([CanBeNull] this T? value,
													T valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>([CanBeNull] this T? value,
													[CanBeNull] T? valueBoundLower,
													T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/> and less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsBetweenExclusive<T>([CanBeNull] this T? value,
													[CanBeNull] T? valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsBetweenExclusive(value, valueBoundLower, valueBoundUpper);
		}		

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan<T>([CanBeNull] this T value,
											   [CanBeNull] T valueBoundLower)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan<T>(this T value,
											   [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan<T>([CanBeNull] this T? value,
											   T valueBoundLower)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThan<T>([CanBeNull] this T? value,
											   [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThan(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual<T>([CanBeNull] this T value,
													  [CanBeNull] T valueBoundLower)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual<T>(this T value,
													  [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual<T>([CanBeNull] this T? value,
													  T valueBoundLower)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsGreaterThanOrEqual<T>([CanBeNull] this T? value,
													  [CanBeNull] T? valueBoundLower)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsGreaterThanOrEqual(value, valueBoundLower);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan<T>([CanBeNull] this T value,
											[CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan<T>(this T value,
											[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan<T>([CanBeNull] this T? value,
											T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is less than the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThan<T>([CanBeNull] this T? value,
											[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThan(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual<T>([CanBeNull] this T value,
												   [CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual<T>(this T value,
												   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual<T>([CanBeNull] this T? value,
												   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is less than or equal to the <paramref name="valueBoundUpper"/>.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is less than or equal to the <paramref name="valueBoundUpper"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsLessThanOrEqual<T>([CanBeNull] this T? value,
												   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsLessThanOrEqual(value, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>([CanBeNull] this T value,
										   [CanBeNull] T valueBoundLower,
										   [CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>(this T value,
										   T valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>(this T value,
										   [CanBeNull] T? valueBoundLower,
										   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>(this T value,
										   [CanBeNull] T? valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>([CanBeNull] this T? value,
										   T valueBoundLower,
										   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>([CanBeNull] this T? value,
										   T valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>([CanBeNull] this T? value,
										   [CanBeNull] T? valueBoundLower,
										   T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than or equal to.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than or equal to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than or equal to the <paramref name="valueBoundUpper"/> and less than or equal to the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutside<T>([CanBeNull] this T? value,
										   [CanBeNull] T? valueBoundLower,
										   [CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutside(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>([CanBeNull] this T value,
													[CanBeNull] T valueBoundLower,
													[CanBeNull] T valueBoundUpper)
			where T : IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>(this T value,
													T valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>(this T value,
													[CanBeNull] T? valueBoundLower,
													T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>(this T value,
													[CanBeNull] T? valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>([CanBeNull] this T? value,
													T valueBoundLower,
													T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>([CanBeNull] this T? value,
													T valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>([CanBeNull] this T? value,
													[CanBeNull] T? valueBoundLower,
													T valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}

		/// <summary>
		///		Determines whether the provided <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.IComparable{T}"/> type to compare.</typeparam>
		/// <param name="value">The  <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>.</param>
		/// <param name="valueBoundLower">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is greater than.</param>
		/// <param name="valueBoundUpper">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to test if the <paramref name="value"/> is less than.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is greater than the <paramref name="valueBoundUpper"/> and less than the <paramref name="valueBoundLower"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsOutsideExclusive<T>([CanBeNull] this T? value,
													[CanBeNull] T? valueBoundLower,
													[CanBeNull] T? valueBoundUpper)
			where T : struct, IComparable<T>
		{
			return GenericRelationalTestingUtility.IsOutsideExclusive(value, valueBoundLower, valueBoundUpper);
		}
		
		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
