using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="SignedIntegralNumberTestingExtensionTests.IsNegativeTest03.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.Tests
{
	public partial class SignedIntegralNumberTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingExtensionTests))]
public void IsNegativeTest03162()
{
    bool b;
    b = this.IsNegativeTest03(default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingExtensionTests))]
public void IsNegativeTest03771()
{
    bool b;
    b = this.IsNegativeTest03(new int?(0));
    Assert.AreEqual<bool>(false, b);
}
	}
}
