using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="IntegralParityTestingExtensionTests.IsEvenTest15.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class IntegralParityTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTests))]
public void IsEvenTest15704()
{
    bool b;
    b = this.IsEvenTest15(new ulong?(1uL));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTests))]
public void IsEvenTest15162()
{
    bool b;
    b = this.IsEvenTest15(default(ulong?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
