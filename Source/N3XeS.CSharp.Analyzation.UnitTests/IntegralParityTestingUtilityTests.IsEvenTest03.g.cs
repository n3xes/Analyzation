using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="IntegralParityTestingUtilityTests.IsEvenTest03.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class IntegralParityTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingUtilityTests))]
public void IsEvenTest03569()
{
    bool b;
    b = this.IsEvenTest03(new decimal?(0e-4M));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingUtilityTests))]
public void IsEvenTest03162()
{
    bool b;
    b = this.IsEvenTest03(default(decimal?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
