using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsOutsideTest39.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	public partial class RelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest39809()
{
    bool b;
    b = this.IsOutsideTest39
            (new float?((float)0), new float?((float)1), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest39338()
{
    bool b;
    b = this.IsOutsideTest39
            (new float?((float)(-1)), new float?((float)(-2)), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest39316()
{
    bool b;
    b = this.IsOutsideTest39
            (default(float?), new float?((float)1), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest39859()
{
    bool b;
    b = this.IsOutsideTest39
            (new float?((float)0), new float?((float)1), default(float?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsOutsideTest39745()
{
    bool b;
    b = this.IsOutsideTest39
            (new float?((float)0), default(float?), new float?((float)2));
    Assert.AreEqual<bool>(false, b);
}
	}
}
