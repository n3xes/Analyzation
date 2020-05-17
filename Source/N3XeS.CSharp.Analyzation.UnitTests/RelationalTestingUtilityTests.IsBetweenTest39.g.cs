using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingUtilityTests.IsBetweenTest39.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest39809()
{
    bool b;
    b = this.IsBetweenTest39
            (new float?((float)0), new float?((float)1), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest39466()
{
    bool b;
    b = this.IsBetweenTest39
            (new float?((float)(-1)), new float?((float)1), new float?((float)(-2)));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest39316()
{
    bool b;
    b = this.IsBetweenTest39
            (default(float?), new float?((float)1), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest39859()
{
    bool b;
    b = this.IsBetweenTest39
            (new float?((float)0), new float?((float)1), default(float?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingUtilityTests))]
public void IsBetweenTest39745()
{
    bool b;
    b = this.IsBetweenTest39
            (new float?((float)0), default(float?), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}
	}
}
