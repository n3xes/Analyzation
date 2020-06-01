#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="EqualityTestingUtility.cs">
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
#pragma warning disable 168
namespace N3XeS.CSharp.Analyzation.Utilities
{
	#region Directives

	using System;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Globalization;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

	using System.Numerics;

#endif

	using JetBrains.Annotations;

	using Extensions;
	using Properties;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		An equality testing related utility.
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
	public static class EqualityTestingUtility
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
		 SuppressMessage("Microsoft.Design", 
						 "CA1062:Validate arguments of public methods", 
						 Justification = "Reviewed.  Suppression is OK here.  Value can be null.", 
						 MessageId = "0"),
		 SuppressMessage("Microsoft.Naming", 
						 "CA1702:CompoundWordsShouldBeCasedCorrectly",
						 Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.",
						 MessageId = "WhiteSpace")]
		// ReSharper disable once InconsistentNaming
		public static Boolean HasNonWhiteSpaceValue([CanBeNull] String value)
		{
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)
			return !String.IsNullOrWhiteSpace(value);
#else
			if (value.IsNull())
			{
				return false;
			}

			for (Int32 indexValue = 0; indexValue < value.Length; indexValue++)
			{
				if (!Char.IsWhiteSpace(value[indexValue]))
				{
					return true;
				}
			}

			return false;
#endif
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
		public static Boolean HasNoValue([CanBeNull] String value)
		{
			return String.IsNullOrEmpty(value);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> value is not <see langword="null"/>, empty, or white space.
		/// </summary>
		/// <param name="value">The <see cref="T:System.String"/> to check if is not <see langword="null"/>, empty, or white space.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> value is not <see langword="null"/>, empty, or white space; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true"),
		 SuppressMessage("Microsoft.Design", 
						 "CA1062:Validate arguments of public methods", 
						 Justification = "Reviewed.  Suppression is OK here.  Value can be null.", 
						 MessageId = "0"),
		 SuppressMessage("Microsoft.Naming", 
						 "CA1702:CompoundWordsShouldBeCasedCorrectly", 
						 Justification = "Reviewed.  Suppression is OK here.  WhiteSpace is a word.", 
						 MessageId = "WhiteSpace")]
		// ReSharper disable once InconsistentNaming
		public static Boolean HasNullOrWhiteSpaceValue([CanBeNull] String value)
		{
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)
			return String.IsNullOrWhiteSpace(value);
#else
			if (value.IsNull())
			{
				return true;
			}

			for (Int32 indexValue = 0; indexValue < value.Length; indexValue++)
			{
				if (!Char.IsWhiteSpace(value[indexValue]))
				{
					return false;
				}
			}

			return true;
#endif
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
		public static Boolean HasValue([CanBeNull] String value)
		{
			return !String.IsNullOrEmpty(value);
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
		public static Boolean IsApproximatelyDefaultValue(Double value)
		{
			return Math.Abs(value - default(Double)).IsLessThan(Double.Epsilon);
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
		public static Boolean IsApproximatelyDefaultValue(Single value)
		{
			return Math.Abs(value - default(Single)).IsLessThan(Single.Epsilon);
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
		public static Boolean IsApproximatelyEqual(Double valueA, Double valueB)
		{
			return Math.Abs(valueA - valueB).IsLessThan(Double.Epsilon);
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
		public static Boolean IsApproximatelyEqual([CanBeNull] Double? valueA, Double valueB)
		{
			return valueA.IsNotNull() && Math.Abs(valueA.GetValueOrDefault() - valueB).IsLessThan(Double.Epsilon);
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
		public static Boolean IsApproximatelyEqual(Double valueA, [CanBeNull] Double? valueB)
		{
			return valueB.IsNotNull() && Math.Abs(valueA - valueB.GetValueOrDefault()).IsLessThan(Double.Epsilon);
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
		public static Boolean IsApproximatelyEqual([CanBeNull] Double? valueA, [CanBeNull] Double? valueB)
		{
			if (valueA.IsNull() && valueB.IsNull())
			{
				return true;
			}
			
			if (valueA.IsNull() || valueB.IsNull())
			{
				return false;
			}

			return Math.Abs(valueA.GetValueOrDefault() - valueB.GetValueOrDefault()).IsLessThan(Double.Epsilon);
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
		public static Boolean IsApproximatelyEqual(Single valueA, Single valueB)
		{
			return Math.Abs(valueA - valueB).IsLessThan(Single.Epsilon);
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
		public static Boolean IsApproximatelyEqual([CanBeNull] Single? valueA, Single valueB)
		{
			return valueA.IsNotNull() && Math.Abs(valueA.GetValueOrDefault() - valueB).IsLessThan(Single.Epsilon);
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
		public static Boolean IsApproximatelyEqual(Single valueA, [CanBeNull] Single? valueB)
		{
			return valueB.IsNotNull() && Math.Abs(valueA - valueB.GetValueOrDefault()).IsLessThan(Single.Epsilon);
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
		public static Boolean IsApproximatelyEqual([CanBeNull] Single? valueA, [CanBeNull] Single? valueB)
		{
			if (valueA.IsNull() && valueB.IsNull())
			{
				return true;
			}
			
			if (valueA.IsNull() || valueB.IsNull())
			{
				return false;
			}

			return Math.Abs(valueA.GetValueOrDefault() - valueB.GetValueOrDefault()).IsLessThan(Single.Epsilon);
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
		public static Boolean IsDefault<T>([CanBeNull] T value)
			where T : class
		{
			return Equals(value, default(T));
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Numerics.BigInteger"/> to check if is equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(BigInteger value)
		{
			return value == default(BigInteger);
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
		public static Boolean IsDefaultValue([CanBeNull] BigInteger? value)
		{
			return value == default(BigInteger?);
		}

#endif

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to check if is equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(DateTime value)
		{
			return value == default(DateTime);
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
		public static Boolean IsDefaultValue([CanBeNull] DateTime? value)
		{
			return value == default(DateTime?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Guid"/> to check if is equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Guid value)
		{
			return value == default(Guid);
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
		public static Boolean IsDefaultValue([CanBeNull] Guid? value)
		{
			return value == default(Guid?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Byte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to check if is equal to the default value of a <see cref="T:System.Byte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Byte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Byte value)
		{
			return value == default(Byte);
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
		public static Boolean IsDefaultValue([CanBeNull] Byte? value)
		{
			return value == default(Byte?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Char"/>, '\0'.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Char"/> to check if is equal to the default value of a <see cref="T:System.Char"/>, '\0'.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Char"/>, '\0'; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Char value)
		{
			return value == default(Char);
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
		public static Boolean IsDefaultValue([CanBeNull] Char? value)
		{
			return value == default(Char?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to check if is equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Decimal value)
		{
			return value == default(Decimal);
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
		public static Boolean IsDefaultValue([CanBeNull] Decimal? value)
		{
			return value == default(Decimal?);
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
		public static Boolean IsDefaultValue([CanBeNull] Double? value)
		{
			return value.IsApproximatelyEqual(default(Double?));
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] Single? value)
		{
			return value.IsApproximatelyEqual(default(Single?));
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to check if is equal to the default value of a <see cref="T:System.Int32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Int32 value)
		{
			return value == default(Int32);
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
		public static Boolean IsDefaultValue([CanBeNull] Int32? value)
		{
			return value == default(Int32?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to check if is equal to the default value of a <see cref="T:System.Int64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Int64 value)
		{
			return value == default(Int64);
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
		public static Boolean IsDefaultValue([CanBeNull] Int64? value)
		{
			return value == default(Int64?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.SByte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to check if is equal to the default value of a <see cref="T:System.SByte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.SByte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(SByte value)
		{
			return value == default(SByte);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] SByte? value)
		{
			return value == default(SByte?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to check if is equal to the default value of a <see cref="T:System.Int16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.Int16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue(Int16 value)
		{
			return value == default(Int16);
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
		public static Boolean IsDefaultValue([CanBeNull] Int16? value)
		{
			return value == default(Int16?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to check if is equal to the default value of a <see cref="T:System.UInt32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(UInt32 value)
		{
			return value == default(UInt32);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] UInt32? value)
		{
			return value == default(UInt32?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to check if is equal to the default value of a <see cref="T:System.UInt64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(UInt64 value)
		{
			return value == default(UInt64);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] UInt64? value)
		{
			return value == default(UInt64?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to check if is equal to the default value of a <see cref="T:System.UInt16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of a <see cref="T:System.UInt16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsDefaultValue(UInt16 value)
		{
			return value == default(UInt16);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => true")]
		public static Boolean IsDefaultValue([CanBeNull] UInt16? value)
		{
			return value == default(UInt16?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is equal to the default value of <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to derive the default value of.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check if is equal to the default value of <typeparamref name="T"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is equal to the default value of <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsDefaultValue<T>(T value)
			where T : struct
		{
			return Equals(value, default(T));
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
		public static Boolean IsDefaultValue<T>([CanBeNull] T? value)
			where T : struct
		{
			return Equals(value, default(T?));
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
		public static Boolean IsNotApproximatelyDefaultValue(Double value)
		{
			return Math.Abs(value - default(Double)).IsGreaterThan(Double.Epsilon);
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
		public static Boolean IsNotApproximatelyDefaultValue(Single value)
		{
			return Math.Abs(value - default(Single)).IsGreaterThan(Single.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual(Double valueA, Double valueB)
		{
			return Math.Abs(valueA - valueB).IsGreaterThan(Double.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual([CanBeNull] Double? valueA, Double valueB)
		{
			return valueA.IsNull() || Math.Abs(valueA.GetValueOrDefault() - valueB).IsGreaterThan(Double.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual(Double valueA, [CanBeNull] Double? valueB)
		{
			return valueB.IsNull() || Math.Abs(valueA - valueB.GetValueOrDefault()).IsGreaterThan(Double.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual([CanBeNull] Double? valueA, [CanBeNull] Double? valueB)
		{
			if (valueA.IsNull() && valueB.IsNull())
			{
				return false;
			}

			if (valueA.IsNull())
			{
				return true;
			}
			
			return valueB.IsNull() || Math.Abs(valueA.GetValueOrDefault() - valueB.GetValueOrDefault()).IsGreaterThan(Double.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual(Single valueA, Single valueB)
		{
			return Math.Abs(valueA - valueB).IsGreaterThan(Single.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual([CanBeNull] Single? valueA, Single valueB)
		{
			return valueA.IsNull() || Math.Abs(valueA.GetValueOrDefault() - valueB).IsGreaterThan(Single.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual(Single valueA, [CanBeNull] Single? valueB)
		{
			return valueB.IsNull() || Math.Abs(valueA - valueB.GetValueOrDefault()).IsGreaterThan(Single.Epsilon);
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
		public static Boolean IsNotApproximatelyEqual([CanBeNull] Single? valueA, [CanBeNull] Single? valueB)
		{
			if (valueA.IsNull() && valueB.IsNull())
			{
				return false;
			}

			if (valueA.IsNull())
			{
				return true;
			}

			return valueB.IsNull() || Math.Abs(valueA.GetValueOrDefault() - valueB.GetValueOrDefault()).IsGreaterThan(Single.Epsilon);
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
		public static Boolean IsNotDefault<T>([CanBeNull] T value)
			where T : class
		{
			return !Equals(value, default(T));
		}

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35)

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </summary>
		/// <param name="value">
		///		The <see cref="T:System.Numerics.BigInteger"/> to check if is not equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Numerics.BigInteger"/>, <see cref="P:System.Numerics.BigInteger.Zero"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(BigInteger value)
		{
			return value != default(BigInteger);
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
		public static Boolean IsNotDefaultValue([CanBeNull] BigInteger? value)
		{
			return value != default(BigInteger?);
		}

#endif

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.DateTime"/> to check if is not equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.DateTime"/>, <see cref="F:System.DateTime.MinValue"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(DateTime value)
		{
			return value != default(DateTime);
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
		public static Boolean IsNotDefaultValue([CanBeNull] DateTime? value)
		{
			return value != default(DateTime?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Guid"/> to check if is not equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Guid"/>, <see cref="F:System.Guid.Empty"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Guid value)
		{
			return value != default(Guid);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Guid? value)
		{
			return value != default(Guid?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Byte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Byte"/> to check if is not equal to the default value of a <see cref="T:System.Byte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Byte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Byte value)
		{
			return value != default(Byte);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Byte? value)
		{
			return value != default(Byte?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Char"/>, '\0'.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Char"/> to check if is not equal to the default value of a <see cref="T:System.Char"/>, '\0'.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Char"/>, '\0'; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Char value)
		{
			return value != default(Char);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Char? value)
		{
			return value != default(Char?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Decimal"/> to check if is not equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Decimal"/>, 0.0M; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Decimal value)
		{
			return value != default(Decimal);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Decimal? value)
		{
			return value != default(Decimal?);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Double? value)
		{
			return value.IsNotApproximatelyEqual(default(Double?));
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to check if is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/>, <see langword="null"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] Single? value)
		{
			return value.IsNotApproximatelyEqual(default(Single?));
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int32"/> to check if is not equal to the default value of a <see cref="T:System.Int32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Int32 value)
		{
			return value != default(Int32);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Int32? value)
		{
			return value != default(Int32?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int64"/> to check if is not equal to the default value of a <see cref="T:System.Int64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Int64 value)
		{
			return value != default(Int64);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Int64? value)
		{
			return value != default(Int64?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.SByte"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.SByte"/> to check if is not equal to the default value of a <see cref="T:System.SByte"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.SByte"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(SByte value)
		{
			return value != default(SByte);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] SByte? value)
		{
			return value != default(SByte?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Int16"/> to check if is not equal to the default value of a <see cref="T:System.Int16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.Int16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotDefaultValue(Int16 value)
		{
			return value != default(Int16);
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
		public static Boolean IsNotDefaultValue([CanBeNull] Int16? value)
		{
			return value != default(Int16?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt32"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt32"/> to check if is not equal to the default value of a <see cref="T:System.UInt32"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt32"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(UInt32 value)
		{
			return value != default(UInt32);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] UInt32? value)
		{
			return value != default(UInt32?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt64"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt64"/> to check if is not equal to the default value of a <see cref="T:System.UInt64"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt64"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(UInt64 value)
		{
			return value != default(UInt64);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] UInt64? value)
		{
			return value != default(UInt64?);
		}

		/// <summary>
		///		Checks if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt16"/>, zero.
		/// </summary>
		/// <param name="value">The <see cref="T:System.UInt16"/> to check if is not equal to the default value of a <see cref="T:System.UInt16"/>, zero.</param>
		/// <returns>
		///		<see langword="true"/> if the provided <paramref name="value"/> is not equal to the default value of a <see cref="T:System.UInt16"/>, zero; otherwise, <see langword="false"/>.
		/// </returns>
		[CLSCompliant(false)]
		public static Boolean IsNotDefaultValue(UInt16 value)
		{
			return value != default(UInt16);
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
		[CLSCompliant(false), 
		 ContractAnnotation("value:null => false")]
		public static Boolean IsNotDefaultValue([CanBeNull] UInt16? value)
		{
			return value != default(UInt16?);
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
		public static Boolean IsNotDefaultValue<T>(T value)
			where T : struct
		{
			return !Equals(value, default(T));
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
		public static Boolean IsNotDefaultValue<T>([CanBeNull] T? value)
			where T : struct
		{
			return !Equals(value, default(T?));
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
		public static Boolean IsNotNull<T>([CanBeNull] T value)
		{
			return !IsNull(value);
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
		public static Boolean IsNotNull<T>([CanBeNull] T? value)
			where T : struct
		{
			return !IsNull(value);
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
		public static Boolean IsNull<T>([CanBeNull] T value)
		{
			return EqualityComparer<T>.Default.Equals(value, default(T));
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
		public static Boolean IsNull<T>([CanBeNull] T? value)
			where T : struct
		{
			return EqualityComparer<T?>.Default.Equals(value, default(T?));
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
		public static void RequireIsNotNull<T>([CanBeNull] T value)
		{
			if (value.IsNull())
			{
				throw new InvalidOperationException(String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustNotBeNull));
			}
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
		public static void RequireIsNull<T>([CanBeNull] T? value)
			where T : struct
		{
			if (value.IsNotNull())
			{
				throw new InvalidOperationException(String.Format(CultureInfo.InvariantCulture, "{0}.", Resources.ValueMustBeNull));
			}
		}
	 
		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
