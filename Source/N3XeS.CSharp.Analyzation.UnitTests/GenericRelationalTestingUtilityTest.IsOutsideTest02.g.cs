using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTest.IsOutsideTest02.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsOutsideTest02758()
{
    bool b;
    b = this.IsOutsideTest02<int>(0, new int?(1), 0);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsOutsideTest02393()
{
    bool b;
    b = this.IsOutsideTest02<int>(1, new int?(0), 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsOutsideTest02551()
{
    bool b;
    b = this.IsOutsideTest02<int>(0, default(int?), 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
