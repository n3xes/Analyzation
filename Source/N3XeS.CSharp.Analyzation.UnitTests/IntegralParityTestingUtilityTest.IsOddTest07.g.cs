using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="IntegralParityTestingUtilityTest.IsOddTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	public partial class IntegralParityTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingUtilityTest))]
public void IsOddTest07162()
{
	bool b;
	b = this.IsOddTest07(new long?(1L));
	Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingUtilityTest))]
public void IsOddTest0716201()
{
	bool b;
	b = this.IsOddTest07(default(long?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
