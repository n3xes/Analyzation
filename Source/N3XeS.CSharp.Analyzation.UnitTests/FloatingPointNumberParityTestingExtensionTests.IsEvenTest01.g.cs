using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="FloatingPointNumberParityTestingExtensionTests.IsEvenTest01.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class FloatingPointNumberParityTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(FloatingPointNumberParityTestingExtensionTests))]
public void IsEvenTest01613()
{
    bool b;
    b = this.IsEvenTest01(new double?(0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(FloatingPointNumberParityTestingExtensionTests))]
public void IsEvenTest01162()
{
    bool b;
    b = this.IsEvenTest01(default(double?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
