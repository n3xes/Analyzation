using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="SignedIntegralNumberTestingExtensionTests.IsNegativeTest05.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.UnitTests
{
	public partial class SignedIntegralNumberTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingExtensionTests))]
public void IsNegativeTest05704()
{
    bool b;
    b = this.IsNegativeTest05(new long?(1L));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingExtensionTests))]
public void IsNegativeTest05162()
{
    bool b;
    b = this.IsNegativeTest05(default(long?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
