using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="IntegralParityTestingExtensionTest.IsEvenTest07.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
public void IsEvenTest07704()
{
	bool b;
	b = this.IsEvenTest07(new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(IntegralParityTestingExtensionTest))]
public void IsEvenTest07162()
{
	bool b;
	b = this.IsEvenTest07(default(long?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
