#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="SignedFloatingPointNumberTestingUtility.cs">
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

	using Extensions;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A signed floating point number testing related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Tuesday, September 24, 2013  (09/24/2013)</CreationDate>
	///  <CreationTime>07:51:56 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	public static class SignedFloatingPointNumberTestingUtility
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
		///		Determines whether the provided <see cref="T:System.Double"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Double"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(Double value)
		{
			return value.IsLessThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(Double? value)
		{
			return value.IsLessThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Single"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Single"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(Single value)
		{
			return value.IsLessThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value is negative.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value is negative; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsNegative(Single? value)
		{
			return value.IsLessThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Double"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Double"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(Double value)
		{
			return value.IsGreaterThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(Double? value)
		{
			return value.IsGreaterThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Single"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Single"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(Single value)
		{
			return value.IsGreaterThan(0);
		}

		/// <summary>
		///		Determines whether the provided <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value is positive.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> value is positive; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsPositive(Single? value)
		{
			return value.IsGreaterThan(0);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
