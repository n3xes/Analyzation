using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenTest02419()
{
	bool b;
	b = this.IsBetweenTest02(default(DateTime), new DateTime?
													(new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
												default(DateTime));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest0241901()
{
	bool b;
	b = this.IsBetweenTest02
			(new DateTime(4611686018427387903L & 3L, (DateTimeKind)(3uL >> 62)), 
			 new DateTime?
				 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
			 new DateTime(4611686018427387903L & 2L, (DateTimeKind)(2uL >> 62)));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenTest02441()
{
	bool b;
	b =
	  this.IsBetweenTest02(default(DateTime), default(DateTime?), default(DateTime));
	Assert.AreEqual<bool>(false, b);
}
	}
}
