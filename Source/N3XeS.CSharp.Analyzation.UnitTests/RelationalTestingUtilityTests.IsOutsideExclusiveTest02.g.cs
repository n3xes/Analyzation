using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideExclusiveTest02.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest02419()
{
    bool b;
    b = this.IsOutsideExclusiveTest02(default(DateTime), new DateTime?
                                                             (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                                                         default(DateTime));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest02764()
{
    bool b;
    b = this.IsOutsideExclusiveTest02
            (new DateTime(4611686018427387903L & 2305843009213693952L, 
                          (DateTimeKind)(2305843009213693952uL >> 62)), new DateTime?
                                                                              (new DateTime(4611686018427387903L & 1L, (DateTimeKind)(1uL >> 62))), 
                                                                          default(DateTime));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest02441()
{
    bool b;
    b = this.IsOutsideExclusiveTest02
            (default(DateTime), default(DateTime?), default(DateTime));
    Assert.AreEqual<bool>(false, b);
}
	}
}
