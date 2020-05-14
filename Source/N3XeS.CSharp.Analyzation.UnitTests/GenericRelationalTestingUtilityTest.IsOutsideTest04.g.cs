using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="GenericRelationalTestingUtilityTest.IsOutsideTest04.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest04393()
{
    bool b;
    b = this.IsOutsideTest04<int>(new int?(1), 0, 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsOutsideTest04974()
{
    bool b;
    b = this.IsOutsideTest04<int>(new int?(4), 514, 0);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTest))]
public void IsOutsideTest04811()
{
    bool b;
    b = this.IsOutsideTest04<int>(default(int?), 0, 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
