using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsOutsideTest09.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest09175()
{
    bool b;
    b = this.IsOutsideTest09((byte)0, (byte)0, new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest09336()
{
    bool b;
    b = this.IsOutsideTest09((byte)1, (byte)0, new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsOutsideTest09204()
{
    bool b;
    b = this.IsOutsideTest09((byte)0, (byte)0, default(byte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
