using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsLessThanOrEqualTest27.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsLessThanOrEqualTest27378()
{
	bool b;
	b = this.IsLessThanOrEqualTest27(new long?(1L), new long?(1L));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsLessThanOrEqualTest27421()
{
	bool b;
	b = this.IsLessThanOrEqualTest27(new long?(1L), default(long?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsLessThanOrEqualTest27104()
{
	bool b;
	b = this.IsLessThanOrEqualTest27(default(long?), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}
	}
}
