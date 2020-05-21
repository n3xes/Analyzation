using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTests.IsGreaterThanTest01.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsGreaterThanTest01729()
{
    bool b;
    b = this.IsGreaterThanTest01<int>(1, default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsGreaterThanTest01267()
{
    bool b;
    b = this.IsGreaterThanTest01<int>(1, new int?(0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsGreaterThanTest953()
{
    bool b;
    b = this.IsGreaterThanTest<int>(0, 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
