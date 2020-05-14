using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="GenericRelationalTestingExtensionTest.IsOutsideTest03.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsOutsideTest03857()
{
    bool b;
    b = this.IsOutsideTest03<int>(1, default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsOutsideTest03724()
{
    bool b;
    b = this.IsOutsideTest03<int>(1, new int?(0), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsOutsideTest03393()
{
    bool b;
    b = this.IsOutsideTest03<int>(1, new int?(0), new int?(0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsOutsideTest03758()
{
    bool b;
    b = this.IsOutsideTest03<int>(0, new int?(1), new int?(0));
    Assert.AreEqual<bool>(true, b);
}
	}
}
