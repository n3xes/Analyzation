using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenExclusiveTest73.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.Tests
{
	public partial class RelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest7325()
{
    bool b;
    b = this.IsBetweenExclusiveTest73(1u, 1u, default(uint?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest73872()
{
    bool b;
    b = this.IsBetweenExclusiveTest73(1u, 1u, new uint?(0u));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenExclusiveTest73710()
{
    bool b;
    b = this.IsBetweenExclusiveTest73(0u, 1u, new uint?(1u));
    Assert.AreEqual<bool>(false, b);
}
	}
}
