using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="TypeTestingExtensionTest.IsNotNullableTypeTest.g.cs">Copyright © N3XeS LLC 2016</copyright>
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
	public partial class TypeTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TypeTestingExtensionTest))]
public void IsNotNullableTypeTest162()
{
	bool b;
	b = this.IsNotNullableTypeTest((object)null);
	Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(TypeTestingExtensionTest))]
public void IsNotNullableTypeTest406()
{
	bool b;
	object s0 = new object();
	b = this.IsNotNullableTypeTest(s0);
	Assert.AreEqual<bool>(true, b);
}
	}
}
