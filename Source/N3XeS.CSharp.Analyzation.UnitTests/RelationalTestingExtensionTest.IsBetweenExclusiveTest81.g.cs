using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTest.IsBetweenExclusiveTest81.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest81241()
{
	bool b;
	b = this.IsBetweenExclusiveTest81(0uL, 0uL, new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest81938()
{
	bool b;
	b = this.IsBetweenExclusiveTest81(9223372036854775808uL, 0uL, new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsBetweenExclusiveTest81579()
{
	bool b;
	b = this.IsBetweenExclusiveTest81(0uL, 0uL, default(ulong?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
