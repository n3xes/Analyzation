using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingExtensionTests.IsGreaterThanOrEqualTest01.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest01729()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest01<int>(1, default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest01267()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest01<int>(1, new int?(0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsGreaterThanOrEqualTest567()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest<int>(0, 0);
    Assert.AreEqual<bool>(true, b);
}
	}
}
