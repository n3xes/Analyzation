using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="RelationalTestingUtilityTest.IsBetweenExclusiveTest83.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest83710()
{
	bool b;
	b = this.IsBetweenExclusiveTest83(0uL, new ulong?(1uL), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest83103()
{
	bool b;
	b = this.IsBetweenExclusiveTest83
			(9223372036854775808uL, new ulong?(1uL), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest8357()
{
	bool b;
	b = this.IsBetweenExclusiveTest83(0uL, default(ulong?), new ulong?(1uL));
	Assert.AreEqual<bool>(false, b);
}
	}
}
