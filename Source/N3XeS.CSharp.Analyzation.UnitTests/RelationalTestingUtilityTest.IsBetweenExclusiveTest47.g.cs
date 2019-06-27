using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsBetweenExclusiveTest47.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest47904()
{
	bool b;
	b = this.IsBetweenExclusiveTest47(default(int?), default(int?), default(int?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest47538()
{
	bool b;
	b = this.IsBetweenExclusiveTest47(new int?(0), default(int?), default(int?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest47579()
{
	bool b;
	b = this.IsBetweenExclusiveTest47(new int?(0), new int?(0), default(int?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest47766()
{
	bool b;
	b = this.IsBetweenExclusiveTest47(new int?(0), new int?(0), new int?(0));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest47340()
{
	bool b;
	b = this.IsBetweenExclusiveTest47(new int?(1), new int?(0), new int?(2));
	Assert.AreEqual<bool>(true, b);
}
	}
}
