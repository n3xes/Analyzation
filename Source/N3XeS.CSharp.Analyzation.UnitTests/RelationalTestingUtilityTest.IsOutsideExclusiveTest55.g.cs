using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsOutsideExclusiveTest55.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest55239()
{
	bool b;
	b = this.IsOutsideExclusiveTest55
			(new long?(1073741824L), new long?(2L), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest55658()
{
	bool b;
	b = this.IsOutsideExclusiveTest55
			(new long?(1073741824L), new long?(2L), default(long?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest5598()
{
	bool b;
	b = this.IsOutsideExclusiveTest55(new long?(2L), new long?(3L), new long?(1L));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest55184()
{
	bool b;
	b = this.IsOutsideExclusiveTest55(default(long?), new long?(2L), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest55337()
{
	bool b;
	b = this.IsOutsideExclusiveTest55
			(new long?(1073741824L), default(long?), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}
	}
}
