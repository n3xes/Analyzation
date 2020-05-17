using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingUtilityTests.IsOutsideTest05.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsOutsideTest0525()
{
    bool b;
    b = this.IsOutsideTest05<int>(new int?(1), 1, default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsOutsideTest05801()
{
    bool b;
    b = this.IsOutsideTest05<int>(default(int?), 1, default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsOutsideTest05990()
{
    bool b;
    b = this.IsOutsideTest05<int>(new int?(1), 1, new int?(0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingUtilityTests))]
public void IsOutsideTest05328()
{
    bool b;
    b = this.IsOutsideTest05<int>(new int?(2), 1, new int?(0));
    Assert.AreEqual<bool>(false, b);
}
	}
}
