using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideExclusiveTest86.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class RelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest86872()
{
    bool b;
    b = this.IsOutsideExclusiveTest86(new ulong?(1uL), new ulong?(1uL), 0uL);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest8625()
{
    bool b;
    b = this.IsOutsideExclusiveTest86(new ulong?(2uL), new ulong?(3uL), 0uL);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest8681()
{
    bool b;
    b = this.IsOutsideExclusiveTest86(default(ulong?), new ulong?(1uL), 0uL);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest86680()
{
    bool b;
    b = this.IsOutsideExclusiveTest86(new ulong?(1uL), default(ulong?), 0uL);
    Assert.AreEqual<bool>(false, b);
}
	}
}
