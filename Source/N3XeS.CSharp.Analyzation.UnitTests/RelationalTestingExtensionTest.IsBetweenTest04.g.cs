using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenTest04.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest04419()
{
	bool b;
	b = this.IsBetweenTest04(new DateTime?
								 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
							 default(DateTime), default(DateTime));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest04206()
{
	bool b;
	b = this.IsBetweenTest04(new DateTime?
								 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
							 default(DateTime), 
							 new DateTime(4611686018427387903L & 2305843009213693952L, 
										  (DateTimeKind)(2305843009213693952uL >> 62)));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest04951()
{
	bool b;
	b =
	  this.IsBetweenTest04(default(DateTime?), default(DateTime), default(DateTime));
	Assert.AreEqual<bool>(false, b);
}
	}
}
