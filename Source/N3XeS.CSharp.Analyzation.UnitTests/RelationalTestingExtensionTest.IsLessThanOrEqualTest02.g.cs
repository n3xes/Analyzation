using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsLessThanOrEqualTest02.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsLessThanOrEqualTest02522()
{
	bool b;
	b = this.IsLessThanOrEqualTest02(new DateTime?
										 (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
									 default(DateTime));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest02361()
{
	bool b;
	b = this.IsLessThanOrEqualTest02(default(DateTime?), default(DateTime));
	Assert.AreEqual<bool>(false, b);
}
	}
}
