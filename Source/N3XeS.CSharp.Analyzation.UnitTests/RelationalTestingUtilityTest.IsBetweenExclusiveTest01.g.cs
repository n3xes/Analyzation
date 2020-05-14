using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsBetweenExclusiveTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest01405()
{
	bool b;
	b = this.IsBetweenExclusiveTest01
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest01419()
{
	bool b;
	b = this.IsBetweenExclusiveTest01
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest0141901()
{
	bool b;
	b = this.IsBetweenExclusiveTest01(default(DateTime), 
									  new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
									  new DateTime?(new DateTime
														(4611686018427387903L & 4096L, (DateTimeKind)(4096uL >> 62))));
	Assert.AreEqual<bool>(false, b);
}
	}
}
