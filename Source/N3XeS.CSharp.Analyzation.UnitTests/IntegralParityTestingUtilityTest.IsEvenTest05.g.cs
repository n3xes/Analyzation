using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="IntegralParityTestingUtilityTest.IsEvenTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsEvenTest05162()
{
	bool b;
	b = this.IsEvenTest05(default(int?));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingUtilityTest))]
public void IsEvenTest05613()
{
	bool b;
	b = this.IsEvenTest05(new int?(0));
	Assert.AreEqual<bool>(true, b);
}
	}
}
