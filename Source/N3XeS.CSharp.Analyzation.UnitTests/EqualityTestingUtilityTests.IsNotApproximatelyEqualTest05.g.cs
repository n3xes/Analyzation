using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingUtilityTests.IsNotApproximatelyEqualTest05.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsNotApproximatelyEqualTest05118()
{
    bool b;
    b = this.IsNotApproximatelyEqualTest05(new float?((float)0), (float)0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTests))]
public void IsNotApproximatelyEqualTest05841()
{
    bool b;
    b = this.IsNotApproximatelyEqualTest05(default(float?), (float)0);
    Assert.AreEqual<bool>(true, b);
}
	}
}
