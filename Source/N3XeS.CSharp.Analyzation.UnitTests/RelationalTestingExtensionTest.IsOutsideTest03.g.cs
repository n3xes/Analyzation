using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsOutsideTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	public partial class RelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest03353()
{
	bool b;
	b = this.IsOutsideTest03
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 default(DateTime?), default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest03405()
{
	bool b;
	b = this.IsOutsideTest03
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime?(default(DateTime)), default(DateTime?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest03419()
{
	bool b;
	b = this.IsOutsideTest03
			(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
			 new DateTime?(default(DateTime)), new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideTest03675()
{
	bool b;
	b = this.IsOutsideTest03
			(new DateTime(4611686018427387903L & 4611686018427387904L, 
						  (DateTimeKind)(4611686018427387904uL >> 62)), 
			 new DateTime?(default(DateTime)), new DateTime?(default(DateTime)));
	Assert.AreEqual<bool>(true, b);
}
	}
}
