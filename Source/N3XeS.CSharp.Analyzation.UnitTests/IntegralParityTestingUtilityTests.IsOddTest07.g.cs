using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="IntegralParityTestingUtilityTests.IsOddTest07.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOddTest07162()
{
    bool b;
    b = this.IsOddTest07(new long?(1L));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingUtilityTests))]
public void IsOddTest0716201()
{
    bool b;
    b = this.IsOddTest07(default(long?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
