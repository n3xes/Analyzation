using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="GenericRelationalTestingExtensionTest.IsBetweenTest04.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest04393()
{
    bool b;
    b = this.IsBetweenTest04<int>(new int?(1), 0, 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsBetweenTest04809()
{
    bool b;
    b = this.IsBetweenTest04<int>(new int?(4), 0, 514);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTest))]
public void IsBetweenTest04811()
{
    bool b;
    b = this.IsBetweenTest04<int>(default(int?), 0, 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
