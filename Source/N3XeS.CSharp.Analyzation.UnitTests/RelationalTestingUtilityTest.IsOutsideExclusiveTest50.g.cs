using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideExclusiveTest50.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest50868()
{
	bool b;
	b = this.IsOutsideExclusiveTest50(0L, new long?(1L), 0L);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest50442()
{
	bool b;
	b = this.IsOutsideExclusiveTest50(0L, new long?(-9223372036854775807L), 0L);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest50551()
{
	bool b;
	b = this.IsOutsideExclusiveTest50(0L, default(long?), 0L);
	Assert.AreEqual<bool>(false, b);
}
	}
}
