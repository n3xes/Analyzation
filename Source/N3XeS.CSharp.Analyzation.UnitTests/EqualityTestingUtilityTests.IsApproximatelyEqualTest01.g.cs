using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingUtilityTests.IsApproximatelyEqualTest01.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTests))]
public void IsApproximatelyEqualTest0168()
{
    bool b;
    b = this.IsApproximatelyEqualTest01(new double?(0), 0);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTests))]
public void IsApproximatelyEqualTest01953()
{
    bool b;
    b = this.IsApproximatelyEqualTest01(default(double?), 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
