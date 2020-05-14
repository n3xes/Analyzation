using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsOutsideExclusiveTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest05512()
{
	bool b;
	b = this.IsOutsideExclusiveTest05(default(DateTime?), 
									  new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
									  default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest05405()
{
	bool b;
	b = this.IsOutsideExclusiveTest05(new DateTime?(default(DateTime)), 
									  new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
									  default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest05419()
{
	bool b;
	b = this.IsOutsideExclusiveTest05(new DateTime?(default(DateTime)), 
									  new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
									  new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsOutsideExclusiveTest0541901()
{
	bool b;
	b = this.IsOutsideExclusiveTest05(new DateTime?(default(DateTime)), 
									  new DateTime(4611686018427387903L & 4611686018427387904L, 
												   (DateTimeKind)(4611686018427387904uL >> 62)), 
									  new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(false, b);
}
	}
}
