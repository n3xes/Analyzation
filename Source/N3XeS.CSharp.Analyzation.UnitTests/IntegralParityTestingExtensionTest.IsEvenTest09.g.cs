using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="IntegralParityTestingExtensionTest.IsEvenTest09.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsEvenTest09244()
{
	bool b;
	b = this.IsEvenTest09(new sbyte?((sbyte)1));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTest))]
public void IsEvenTest09162()
{
	bool b;
	b = this.IsEvenTest09(default(sbyte?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
