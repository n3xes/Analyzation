using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTest.IsBetweenExclusiveTest86.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsBetweenExclusiveTest86872()
{
	bool b;
	b = this.IsBetweenExclusiveTest86(new ulong?(1uL), new ulong?(1uL), 0uL);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest86436()
{
	bool b;
	b = this.IsBetweenExclusiveTest86(new ulong?(2uL), new ulong?(1uL), 3uL);
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTest))]
public void IsBetweenExclusiveTest8681()
{
	bool b;
	b = this.IsBetweenExclusiveTest86(default(ulong?), new ulong?(1uL), 0uL);
	Assert.AreEqual<bool>(false, b);
}
	}
}
