using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsOutsideExclusiveTest51.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOutsideExclusiveTest51710()
{
	bool b;
	b = this.IsOutsideExclusiveTest51(0L, new long?(1L), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest51550()
{
	bool b;
	b = this.IsOutsideExclusiveTest51
			(0L, new long?(-9223372036854775807L), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsOutsideExclusiveTest5157()
{
	bool b;
	b = this.IsOutsideExclusiveTest51(0L, default(long?), new long?(1L));
	Assert.AreEqual<bool>(false, b);
}
	}
}
