using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideExclusiveTest82.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest82868()
{
    bool b;
    b = this.IsOutsideExclusiveTest82(0uL, new ulong?(1uL), 0uL);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest82531()
{
    bool b;
    b = this.IsOutsideExclusiveTest82(9223372036854775808uL, new ulong?(1uL), 0uL);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest82551()
{
    bool b;
    b = this.IsOutsideExclusiveTest82(0uL, default(ulong?), 0uL);
    Assert.AreEqual<bool>(false, b);
}
	}
}
