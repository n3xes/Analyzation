using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingExtensionTest.IsGreaterThanOrEqualTest43.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsGreaterThanOrEqualTest43826()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest43(new ulong?(1uL), new ulong?(1uL));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanOrEqualTest43729()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest43(new ulong?(1uL), default(ulong?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTest))]
public void IsGreaterThanOrEqualTest43888()
{
	bool b;
	b = this.IsGreaterThanOrEqualTest43(default(ulong?), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}
	}
}
