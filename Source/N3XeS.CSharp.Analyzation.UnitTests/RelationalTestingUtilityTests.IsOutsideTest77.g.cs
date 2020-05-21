using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideTest77.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest7725()
{
    bool b;
    b = this.IsOutsideTest77(new uint?(1u), 1u, default(uint?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest77801()
{
    bool b;
    b = this.IsOutsideTest77(default(uint?), 1u, default(uint?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest77990()
{
    bool b;
    b = this.IsOutsideTest77(new uint?(1u), 1u, new uint?(0u));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest77393()
{
    bool b;
    b = this.IsOutsideTest77(new uint?(1u), 0u, new uint?(0u));
    Assert.AreEqual<bool>(false, b);
}
	}
}
