using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="IntegralParityTestingExtensionTest.IsOddTest01.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsOddTest01402()
{
	bool b;
	b = this.IsOddTest01(new byte?((byte)1));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTest))]
public void IsOddTest01162()
{
	bool b;
	b = this.IsOddTest01(default(byte?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
