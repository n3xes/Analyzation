using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsGreaterThanOrEqualTest10.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.Tests
{
	public partial class RelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest10316()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest10(new decimal?(0e-4M), default(decimal));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest10110()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest10(default(decimal?), default(decimal));
    Assert.AreEqual<bool>(false, b);
}
	}
}
