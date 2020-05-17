using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideExclusiveTest.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest419()
{
    bool b;
    b = this.IsOutsideExclusiveTest
            (default(DateTime), default(DateTime), default(DateTime));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest41901()
{
    bool b;
    b = this.IsOutsideExclusiveTest(default(DateTime), 
                                    new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62)), 
                                    default(DateTime));
    Assert.AreEqual<bool>(false, b);
}
	}
}
