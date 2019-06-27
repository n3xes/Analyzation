using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideExclusiveTest79.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest79904()
{
	bool b;
	b =
	  this.IsOutsideExclusiveTest79(default(uint?), default(uint?), default(uint?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest79538()
{
	bool b;
	b = this.IsOutsideExclusiveTest79(new uint?(0u), default(uint?), default(uint?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest79579()
{
	bool b;
	b = this.IsOutsideExclusiveTest79(new uint?(0u), new uint?(0u), default(uint?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest79766()
{
	bool b;
	b = this.IsOutsideExclusiveTest79(new uint?(0u), new uint?(0u), new uint?(0u));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest79868()
{
	bool b;
	b = this.IsOutsideExclusiveTest79(new uint?(0u), new uint?(1u), new uint?(0u));
	Assert.AreEqual<bool>(false, b);
}
	}
}
