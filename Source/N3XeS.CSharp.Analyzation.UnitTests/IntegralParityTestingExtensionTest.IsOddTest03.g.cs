using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="IntegralParityTestingExtensionTest.IsOddTest03.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class IntegralParityTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTest))]
public void IsOddTest03297()
{
	bool b;
	b = this.IsOddTest03(new decimal?(0e-4M));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTest))]
public void IsOddTest03162()
{
	bool b;
	b = this.IsOddTest03(default(decimal?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
