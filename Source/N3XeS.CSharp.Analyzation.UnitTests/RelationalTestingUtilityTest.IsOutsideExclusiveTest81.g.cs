using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideExclusiveTest81.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest81241()
{
	bool b;
	b = this.IsOutsideExclusiveTest81(0uL, 0uL, new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest81710()
{
	bool b;
	b = this.IsOutsideExclusiveTest81(0uL, 1uL, new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest81579()
{
	bool b;
	b = this.IsOutsideExclusiveTest81(0uL, 0uL, default(ulong?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
