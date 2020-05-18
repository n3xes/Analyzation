#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="TypeTestingUtility.cs">
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
	using System.Diagnostics.CodeAnalysis;

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

	using System.Reflection;

#endif

	using JetBrains.Annotations;

	using Common.Extensions;

	using Extensions;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A type testing related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>04:54:07 PM</CreationTime>
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
	public static class TypeTestingUtility
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
		///		Checks if the <paramref name="valueBoxed"/> is of the provided type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="valueBoxed">
		///		The boxed <see cref="T:System.Object"/> to check if is of the provided type <typeparamref name="T"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="valueBoxed"/> is not <see langword="null"/> and of the
		///		provided type <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter",
		 Justification = "Reviewed.  Suppression is OK here.  This is required.")]
		public static Boolean IsBoxedTypeOf<T>([CanBeNull] Object valueBoxed)
		{
			return valueBoxed.IsNotNull() && (valueBoxed.GetActualType() == typeof(T));
		}

		/// <summary>
		///		Checks if the <paramref name="valueBoxed"/> is not of the provided type <typeparamref name="T"/>.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="valueBoxed">
		///		The boxed <see cref="T:System.Object"/> to check if is not of the provided type
		///		<typeparamref name="T"/>.
		/// </param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="valueBoxed"/> is <see langword="null"/> or is not of the
		///		provided type <typeparamref name="T"/>; otherwise, <see langword="false"/>.
		/// </returns>
		[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter",
		 Justification = "Reviewed.  Suppression is OK here.  This is required.")]
		public static Boolean IsNotBoxedTypeOf<T>([CanBeNull] Object valueBoxed)
		{
			return valueBoxed.IsNull() || (valueBoxed.GetActualType() != typeof(T));
		}

		/// <summary>
		///		Checks if the <paramref name="value"/> is not a <see cref="T:System.Nullable`1"/> type.
		/// </summary>
		/// <typeparam name="T">
		///		The type to check if it is not a <see cref="T:System.Nullable`1"/> type.
		/// </typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is not a <see cref="T:System.Nullable`1"/> type; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => false"),
		 SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
						 Justification = "Reviewed.  Suppression is OK here.  This is required.")]
		public static Boolean IsNotNullableType<T>([CanBeNull] T value)
		{
			if (value.IsNull())
			{
				return false;
			}

			Type type = typeof(T);

			if (type.IsValueType && 
				Nullable.GetUnderlyingType(type).IsNotNull())
			{
				return false;
			}

			return true;
		}

		/// <summary>
		///		Checks if the <paramref name="value"/> type is not equal to the <paramref name="typeComparison"/>.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check.</param>
		/// <param name="typeComparison">The type to compare <paramref name="value"/> to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> type is not equal to the <paramref name="typeComparison"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotTypeOf<T>(T value, [CanBeNull] Type typeComparison)
		{
			return value.GetActualType() != typeComparison;
		}

		/// <summary>
		///		Checks if the <paramref name="value"/> type is not a value type.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is not a value type; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNotValueTypeOf<T>(T value)
		{
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

			TypeInfo valueTypeInfo = value.GetActualType().GetTypeInfo();

			Debug.Assert(valueTypeInfo != null, nameof(valueTypeInfo) + " != null");

			return !valueTypeInfo.IsValueType;

#else

			// ReSharper disable once PossibleNullReferenceException
			Type type = value.GetType();

			return !type.IsValueType;

#endif
		}

		/// <summary>
		///		Checks if the <paramref name="value"/> is a <see cref="T:System.Nullable`1"/> type.
		/// </summary>
		/// <typeparam name="T">
		///		The type to check if it is a <see cref="T:System.Nullable`1"/> type.
		/// </typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is a <see cref="T:System.Nullable`1"/> type; otherwise, <see langword="false"/>.
		/// </returns>
		[ContractAnnotation("value:null => true"),
		 SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods",
						 Justification = "Reviewed.  Suppression is OK here.  This is required.")]
		public static Boolean IsNullableType<T>([CanBeNull] T value)
		{
			if (value.IsNull())
			{
				return true;
			}

			Type type = typeof(T);

			if (!type.IsValueType)
			{
				return true;
			}

			if (Nullable.GetUnderlyingType(type).IsNotNull())
			{
				return true;
			}

			return false;
		}

		/// <summary>
		///		Checks if the <paramref name="value"/> type is equal to the <paramref name="typeComparison"/>.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check.</param>
		/// <param name="typeComparison">The type to compare <paramref name="value"/> to.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> type is equal to the <paramref name="typeComparison"/>; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsTypeOf<T>(T value, [CanBeNull] Type typeComparison)
		{
			return value.GetActualType() == typeComparison;
		}

		/// <summary>
		///		Checks if the <paramref name="value"/> type is a value type.
		/// </summary>
		/// <typeparam name="T">The type to test.</typeparam>
		/// <param name="value">The <typeparamref name="T"/> to check.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is a value type; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsValueTypeOf<T>(T value)
		{
#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

			TypeInfo valueTypeInfo = value.GetActualType().GetTypeInfo();
			
			Debug.Assert(valueTypeInfo != null, nameof(valueTypeInfo) + " != null");

			return valueTypeInfo.IsValueType;

#else

			// ReSharper disable once PossibleNullReferenceException
			Type type = value.GetType();

			return type.IsValueType;

#endif
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
