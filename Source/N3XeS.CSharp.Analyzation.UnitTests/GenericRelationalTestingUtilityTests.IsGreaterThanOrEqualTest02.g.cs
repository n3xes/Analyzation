using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTests.IsGreaterThanOrEqualTest02.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsGreaterThanOrEqualTest02267()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest02<int>(new int?(1), 0);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsGreaterThanOrEqualTest02110()
{
    bool b;
    b = this.IsGreaterThanOrEqualTest02<int>(default(int?), 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
