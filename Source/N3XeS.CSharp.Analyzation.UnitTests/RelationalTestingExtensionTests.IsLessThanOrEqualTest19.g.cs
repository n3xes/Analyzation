using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsLessThanOrEqualTest19.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsLessThanOrEqualTest19382()
{
    bool b;
    b = this.IsLessThanOrEqualTest19(new float?((float)0), new float?((float)1));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsLessThanOrEqualTest19104()
{
    bool b;
    b = this.IsLessThanOrEqualTest19(default(float?), new float?((float)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsLessThanOrEqualTest19744()
{
    bool b;
    b = this.IsLessThanOrEqualTest19(new float?((float)0), default(float?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
