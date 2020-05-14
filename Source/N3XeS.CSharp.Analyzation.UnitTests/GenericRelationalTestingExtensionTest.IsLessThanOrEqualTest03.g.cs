using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="GenericRelationalTestingExtensionTest.IsLessThanOrEqualTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest03407()
{
    bool b;
    b = this.IsLessThanOrEqualTest03<int>(default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest03744()
{
    bool b;
    b = this.IsLessThanOrEqualTest03<int>(new int?(0), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsLessThanOrEqualTest03890()
{
    bool b;
    b = this.IsLessThanOrEqualTest03<int>(new int?(0), new int?(0));
    Assert.AreEqual<bool>(true, b);
}
	}
}
