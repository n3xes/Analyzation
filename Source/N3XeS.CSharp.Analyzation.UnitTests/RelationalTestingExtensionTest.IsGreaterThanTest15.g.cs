using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsGreaterThanTest15.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsGreaterThanTest15484()
{
	bool b;
	b = this.IsGreaterThanTest15(new double?(0), new double?(1));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanTest15775()
{
	bool b;
	b = this.IsGreaterThanTest15(new double?(0), default(double?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanTest15888()
{
	bool b;
	b = this.IsGreaterThanTest15(default(double?), new double?(1));
	Assert.AreEqual<bool>(false, b);
}
	}
}
