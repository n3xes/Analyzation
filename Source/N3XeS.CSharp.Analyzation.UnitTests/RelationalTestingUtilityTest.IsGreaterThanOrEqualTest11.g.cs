using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsGreaterThanOrEqualTest11.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class RelationalTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsGreaterThanOrEqualTest11382()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest11(new decimal?(0e-4M), new decimal?(0e-4M));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsGreaterThanOrEqualTest11944()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest11(new decimal?(0e-4M), default(decimal?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsGreaterThanOrEqualTest11359()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest11(default(decimal?), new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}
	}
}
