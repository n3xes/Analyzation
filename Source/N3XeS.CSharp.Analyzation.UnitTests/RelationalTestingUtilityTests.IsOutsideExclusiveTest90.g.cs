using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideExclusiveTest90.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideExclusiveTest90761()
{
    bool b;
    b =
      this.IsOutsideExclusiveTest90((ushort)64, new ushort?((ushort)65), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest90376()
{
    bool b;
    b =
      this.IsOutsideExclusiveTest90((ushort)96, new ushort?((ushort)65), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideExclusiveTest90722()
{
    bool b;
    b = this.IsOutsideExclusiveTest90((ushort)64, default(ushort?), (ushort)64);
    Assert.AreEqual<bool>(false, b);
}
	}
}
