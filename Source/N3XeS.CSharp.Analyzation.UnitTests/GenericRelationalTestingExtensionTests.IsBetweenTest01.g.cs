using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingExtensionTests.IsBetweenTest01.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class GenericRelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest0125()
{
    bool b;
    b = this.IsBetweenTest01<int>(1, 1, default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest01872()
{
    bool b;
    b = this.IsBetweenTest01<int>(1, 1, new int?(0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest01710()
{
    bool b;
    b = this.IsBetweenTest01<int>(0, 1, new int?(1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest128()
{
    bool b;
    b = this.IsBetweenTest<int>(0, 0, 0);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest393()
{
    bool b;
    b = this.IsBetweenTest<int>(1, 0, 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
