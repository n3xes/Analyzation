#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="EqualityTestingExtension.cs">
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

// These were put in to fix problems with 3rd party software misdiagnosing code problems.
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedTypeParameter
namespace N3XeS.CSharp.Analyzation.Extensions
{
	#region Directives

	using System;
	using System.Diagnostics.CodeAnalysis;

#if (NETFX_V4 && !NETFX_V3 && !NETFX_V35)

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
	///		An equality testing related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>05:31:15 PM</CreationTime>
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
	public static class EqualityTestingExtension
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
		///		Checks if the provided <paramref name="value"/> value is <see langword="null"/>, empty, or white space.
		/// </summary>
		/// <param name="value">The <see cref="T:System.String"/> to check if is <see langword="null"/>, empty, or white space.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is <see langword="null"/>, empty, or white space; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false"),
		 SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", MessageId = "WhiteSpace")]
		// ReSharper disable once InconsistentNaming
		public static Boolean HasNonWhiteSpaceValue([CanBeNull] this String value)
		{
			return EqualityTestingUtility.HasNonWhiteSpaceValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is <see langword="null"/> or empty.
		/// </summary>
		/// <param name="value">The <see cref="T:System.String"/> to check if is <see langword="null"/> or empty.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is <see langword="null"/> or empty; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		// ReSharper disable once InconsistentNaming
		public static Boolean HasNoValue([CanBeNull] this String value)
		{
			return EqualityTestingUtility.HasNoValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is not <see langword="null"/>, empty, or white space.
		/// </summary>
		/// <param name="value">The <see cref="T:System.String"/> to check if is not <see langword="null"/>, empty, or white space.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is not <see langword="null"/>, empty, or white space; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true"),
		 SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", MessageId = "WhiteSpace")]
		// ReSharper disable once InconsistentNaming
		public static Boolean HasNullOrWhiteSpaceValue([CanBeNull] this String value)
		{
			return EqualityTestingUtility.HasNullOrWhiteSpaceValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is not <see langword="null"/> or empty.
		/// </summary>
		/// <param name="value">The <see cref="T:System.String"/> to check if is not <see langword="null"/> or empty.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is not <see langword="null"/> or empty; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		// ReSharper disable once InconsistentNaming
		public static Boolean HasValue([CanBeNull] this String value)
		{
			return EqualityTestingUtility.HasValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Double"/> to check if is approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyDefaultValue(this Double value)
		{
			return EqualityTestingUtility.IsApproximatelyDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Single"/> to check if is approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyDefaultValue(this Single value)
		{
			return EqualityTestingUtility.IsApproximatelyDefaultValue(value);
		}
		
		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual(this Double valueA, Double valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual([CanBeNull] this Double? valueA, Double valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual(this Double valueA, [CanBeNull] Double? valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual([CanBeNull] this Double? valueA, [CanBeNull] Double? valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual(this Single valueA, Single valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual([CanBeNull] this Single? valueA, Single valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual(this Single valueA, [CanBeNull] Single? valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsApproximatelyEqual([CanBeNull] this Single? valueA, [CanBeNull] Single? valueB)
		{
			return EqualityTestingUtility.IsApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of <typeparamref name="T"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefault<T>([CanBeNull] this T value)
			where T : class
		{
			return EqualityTestingUtility.IsDefault(value);
		}

#if (NETFX_V4 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Numerics.BigInteger"/> to check if is equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this BigInteger value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this BigInteger? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

#endif

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to check if is equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this DateTime value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this DateTime? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Guid"/> to check if is equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Guid value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Guid? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Byte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to check if is equal to the default value of a <see cref="T:System.Byte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Byte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Byte value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Byte? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Char"/>, '\0'.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Char"/> to check if is equal to the default value of a <see cref="T:System.Char"/>, '\0'.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Char"/>, '\0'; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Char value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Char? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to check if is equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Decimal value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Decimal? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Double? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Single? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to check if is equal to the default value of a <see cref="T:System.Int32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Int32 value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Int32? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to check if is equal to the default value of a <see cref="T:System.Int64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Int64 value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Int64? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.SByte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to check if is equal to the default value of a <see cref="T:System.SByte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.SByte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(this SByte value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this SByte? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to check if is equal to the default value of a <see cref="T:System.Int16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(this Int16 value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this Int16? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to check if is equal to the default value of a <see cref="T:System.UInt32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(this UInt32 value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this UInt32? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to check if is equal to the default value of a <see cref="T:System.UInt64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(this UInt64 value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this UInt64? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to check if is equal to the default value of a <see cref="T:System.UInt16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(this UInt16 value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] this UInt16? value)
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is equal to the default value of <typeparamref name="T"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue<T>(this T value)
			where T : struct
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>, <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue<T>([CanBeNull] this T? value)
			where T : struct
		{
			return EqualityTestingUtility.IsDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is not approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Double"/> to check if is not approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is not approximately equal to the default value of a <see cref="T:System.Double"/>, 0.0D; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyDefaultValue(this Double value)
		{
			return EqualityTestingUtility.IsNotApproximatelyDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is not approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Single"/> to check if is not approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is not approximately equal to the default value of a <see cref="T:System.Single"/>, 0.0F; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyDefaultValue(this Single value)
		{
			return EqualityTestingUtility.IsNotApproximatelyDefaultValue(value);
		}
		
		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual(this Double valueA, Double valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual([CanBeNull] this Double? valueA, Double valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual(this Double valueA, [CanBeNull] Double? valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual([CanBeNull] this Double? valueA, [CanBeNull] Double? valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual(this Single valueA, Single valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual([CanBeNull] this Single? valueA, Single valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual(this Single valueA, [CanBeNull] Single? valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value.
		/// </summary>
		/// <param name="valueA">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueB"/> value.
		/// </param>
		/// <param name="valueB">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is not approximately equal to the <paramref name="valueA"/> value.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="valueA"/> value is not approximately equal to the <paramref name="valueB"/> value; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotApproximatelyEqual([CanBeNull] this Single? valueA, [CanBeNull] Single? valueB)
		{
			return EqualityTestingUtility.IsNotApproximatelyEqual(valueA, valueB);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is not equal to the default value of <typeparamref name="T"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of <typeparamref name="T"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefault<T>([CanBeNull] this T value)
			where T : class
		{
			return EqualityTestingUtility.IsNotDefault(value);
		}

#if (NETFX_V4 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Numerics.BigInteger"/> to check if is not equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this BigInteger value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Numerics.BigInteger"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this BigInteger? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}


#endif

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to check if is not equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this DateTime value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.DateTime"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this DateTime? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Guid"/> to check if is not equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Guid value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Guid"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Guid? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Byte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to check if is not equal to the default value of a <see cref="T:System.Byte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Byte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Byte value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Byte"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Byte? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Char"/>, '\0'.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Char"/> to check if is not equal to the default value of a <see cref="T:System.Char"/>, '\0'.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Char"/>, '\0'; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Char value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Char"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Char? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to check if is not equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Decimal value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Decimal"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Decimal? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Double? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Single? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to check if is not equal to the default value of a <see cref="T:System.Int32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Int32 value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int32"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Int32? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to check if is not equal to the default value of a <see cref="T:System.Int64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Int64 value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int64"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Int64? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.SByte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to check if is not equal to the default value of a <see cref="T:System.SByte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.SByte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(this SByte value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.SByte"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this SByte? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to check if is not equal to the default value of a <see cref="T:System.Int16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(this Int16 value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Int16"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this Int16? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to check if is not equal to the default value of a <see cref="T:System.UInt32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(this UInt32 value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt32"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this UInt32? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to check if is not equal to the default value of a <see cref="T:System.UInt64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(this UInt64 value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt64"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this UInt64? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to check if is not equal to the default value of a <see cref="T:System.UInt16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(this UInt16 value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.UInt16"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false), ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] this UInt16? value)
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is not equal to the default value of <typeparamref name="T"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue<T>(this T value)
			where T : struct
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>, <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is not equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue<T>([CanBeNull] this T? value)
			where T : struct
		{
			return EqualityTestingUtility.IsNotDefaultValue(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to check if not <see langword="null"/>.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is not equal to <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotNull<T>([CanBeNull] this T value)
		{
			return EqualityTestingUtility.IsNotNull(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.Nullable`1"/> of type to check if not <see langword="null"/>.</typeparam>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to check if is not equal to <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotNull<T>([CanBeNull] this T? value)
			where T : struct
		{
			return EqualityTestingUtility.IsNotNull(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to check if <see langword="null"/>.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is equal to <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsNull<T>([CanBeNull] this T value)
		{
			return EqualityTestingUtility.IsNull(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.Nullable`1"/> of type to check if <see langword="null"/>.</typeparam>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to check if is equal to <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsNull<T>([CanBeNull] this T? value)
			where T : struct
		{
			return EqualityTestingUtility.IsNull(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The type to check if not <see langword="null"/>.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is not equal to <see langword="null"/>.</param>
		/// <exception cref="InvalidOperationException">The provided <paramref name="value"/> must not be <see langword="null"/>.</exception>
		[ContractAnnotation("value:null => halt"),
		 SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes",
						 Justification = "Reviewed.  Suppression is OK here. This is intended functionality.")]
		// ReSharper disable once InconsistentNaming
		public static void RequireIsNotNull<T>([CanBeNull] this T value)
		{
			EqualityTestingUtility.RequireIsNotNull(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to <see langword="null"/>.
		/// </summary>
		/// <typeparam name="T">The <see cref="T:System.Nullable`1"/> of type to check if <see langword="null"/>.</typeparam>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <typeparamref name="T"/> to check if is equal to <see langword="null"/>.</param>
		/// <exception cref="InvalidOperationException">The provided <paramref name="value"/> must be <see langword="null"/>.</exception>
		[ContractAnnotation("value:null => halt"),
		 SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes",
						 Justification = "Reviewed.  Suppression is OK here. This is intended functionality.")]
		// ReSharper disable once InconsistentNaming
		public static void RequireIsNull<T>([CanBeNull] this T? value)
			where T : struct
		{
			EqualityTestingUtility.RequireIsNull(value);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
