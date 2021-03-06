using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="SignedFloatingPointNumberTestingExtensionTests.IsNegativeTest03.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class SignedFloatingPointNumberTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(SignedFloatingPointNumberTestingExtensionTests))]
public void IsNegativeTest03771()
{
    bool b;
    b = this.IsNegativeTest03(new float?((float)0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(SignedFloatingPointNumberTestingExtensionTests))]
public void IsNegativeTest03162()
{
    bool b;
    b = this.IsNegativeTest03(default(float?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
