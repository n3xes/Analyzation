using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="TypeTestingUtilityTest.IsNullableTypeTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	public partial class TypeTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TypeTestingUtilityTest))]
public void IsNullableTypeTest72()
{
	bool b;
	b = this.IsNullableTypeTest((object)null);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeTestingUtilityTest))]
public void IsNullableTypeTest406()
{
	bool b;
	object s0 = new object();
	b = this.IsNullableTypeTest(s0);
	Assert.AreEqual<bool>(true, b);
}
	}
}
