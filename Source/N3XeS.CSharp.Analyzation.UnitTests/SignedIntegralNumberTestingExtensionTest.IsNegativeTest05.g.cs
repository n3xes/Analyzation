using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="SignedIntegralNumberTestingExtensionTest.IsNegativeTest05.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class SignedIntegralNumberTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingExtensionTest))]
public void IsNegativeTest05704()
{
	bool b;
	b = this.IsNegativeTest05(new long?(1L));
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(SignedIntegralNumberTestingExtensionTest))]
public void IsNegativeTest05162()
{
	bool b;
	b = this.IsNegativeTest05(default(long?));
	Assert.AreEqual<bool>(false, b);
}
	}
}
