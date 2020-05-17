using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="SignedIntegralNumberTestingUtilityTests.IsNegativeTest07.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class SignedIntegralNumberTestingUtilityTests
	{

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingUtilityTests))]
public void IsNegativeTest07244()
{
    bool b;
    b = this.IsNegativeTest07(new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingUtilityTests))]
public void IsNegativeTest07162()
{
    bool b;
    b = this.IsNegativeTest07(default(sbyte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
