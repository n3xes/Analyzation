using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsLessThanOrEqualTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsLessThanOrEqualTest15382()
{
	bool b;
	b = this.IsLessThanOrEqualTest15(new double?(0), new double?(1));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest15744()
{
	bool b;
	b = this.IsLessThanOrEqualTest15(new double?(0), default(double?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest15104()
{
	bool b;
	b = this.IsLessThanOrEqualTest15(default(double?), new double?(1));
	Assert.AreEqual<bool>(false, b);
}
	}
}
