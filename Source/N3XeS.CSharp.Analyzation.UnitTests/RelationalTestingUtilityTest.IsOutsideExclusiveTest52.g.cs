using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsOutsideExclusiveTest52.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest52393()
{
	bool b;
	b = this.IsOutsideExclusiveTest52(new long?(1L), 0L, 0L);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest5225()
{
	bool b;
	b = this.IsOutsideExclusiveTest52(new long?(2L), 3L, 0L);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest52811()
{
	bool b;
	b = this.IsOutsideExclusiveTest52(default(long?), 0L, 0L);
	Assert.AreEqual<bool>(false, b);
}
	}
}
