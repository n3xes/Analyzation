using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsLessThanOrEqualTest30.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	public partial class RelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest30275()
{
	bool b;
	b = this.IsLessThanOrEqualTest30(new sbyte?((sbyte)1), (sbyte)0);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest3071()
{
	bool b;
	b = this.IsLessThanOrEqualTest30(default(sbyte?), (sbyte)0);
	Assert.AreEqual<bool>(false, b);
}
	}
}
