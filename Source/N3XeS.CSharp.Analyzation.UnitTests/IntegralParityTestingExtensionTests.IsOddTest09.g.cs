using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="IntegralParityTestingExtensionTests.IsOddTest09.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class IntegralParityTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTests))]
public void IsOddTest09402()
{
    bool b;
    b = this.IsOddTest09(new sbyte?((sbyte)1));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTests))]
public void IsOddTest09162()
{
    bool b;
    b = this.IsOddTest09(default(sbyte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
