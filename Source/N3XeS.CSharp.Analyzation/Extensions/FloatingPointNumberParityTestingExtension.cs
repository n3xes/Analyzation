#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
// <copyright company="John Caruthers" file="FloatingPointNumberParityTestingExtension.cs">
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

	using JetBrains.Annotations;

	using Utilities;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A floating point number parity testing related extension.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Friday, October 18, 2013  (10/18/2013)</CreationDate>
	///  <CreationTime>03:01:16 PM</CreationTime>
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
	public static class FloatingPointNumberParityTestingExtension
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
		///		Determines whether the <paramref name="value"/> is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(this Double value)
		{
			return FloatingPointNumberParityTestingUtility.IsEven(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(this Double? value)
		{
			return FloatingPointNumberParityTestingUtility.IsEven(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(this Single value)
		{
			return FloatingPointNumberParityTestingUtility.IsEven(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is even.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is even; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsEven(this Single? value)
		{
			return FloatingPointNumberParityTestingUtility.IsEven(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Double"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(this Double value)
		{
			return FloatingPointNumberParityTestingUtility.IsOdd(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Double"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(this Double? value)
		{
			return FloatingPointNumberParityTestingUtility.IsOdd(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Single"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(this Single value)
		{
			return FloatingPointNumberParityTestingUtility.IsOdd(value);
		}

		/// <summary>
		///		Determines whether the <paramref name="value"/> is odd.
		/// </summary>
		/// <param name="value">The <see cref="T:System.Nullable`1"/> of <see cref="T:System.Single"/> to test.</param>
		/// <returns>
		///		<see langword="true"/> if the <paramref name="value"/> is odd; otherwise, <see langword="false"/>.
		/// </returns>
		public static Boolean IsOdd(this Single? value)
		{
			return FloatingPointNumberParityTestingUtility.IsOdd(value);
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
