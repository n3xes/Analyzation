using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsOutsideTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideTest01405()
{
	bool b;
	b = this.IsOutsideTest01
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest01675()
{
	bool b;
	b = this.IsOutsideTest01
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideTest01419()
{
	bool b;
	b = this.IsOutsideTest01
			(new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)), 
			 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)), 
			 new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(false, b);
}
	}
}
