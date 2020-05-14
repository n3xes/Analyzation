using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsBetweenExclusiveTest50.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest50868()
{
	bool b;
	b = this.IsBetweenExclusiveTest50(0L, new long?(1L), 0L);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest50710()
{
	bool b;
	b = this.IsBetweenExclusiveTest50(0L, new long?(1L), 1L);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest50551()
{
	bool b;
	b = this.IsBetweenExclusiveTest50(0L, default(long?), 0L);
	Assert.AreEqual<bool>(false, b);
}
	}
}
