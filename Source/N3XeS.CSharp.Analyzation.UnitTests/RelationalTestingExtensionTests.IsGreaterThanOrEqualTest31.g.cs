using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="RelationalTestingExtensionTests.IsGreaterThanOrEqualTest31.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsGreaterThanOrEqualTest31382()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest31(new sbyte?((sbyte)1), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest31999()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest31(default(sbyte?), new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(RelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest31118()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest31(new sbyte?((sbyte)1), default(sbyte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
