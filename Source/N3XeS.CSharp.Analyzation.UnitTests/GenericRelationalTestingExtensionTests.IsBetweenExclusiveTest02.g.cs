using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingExtensionTests.IsBetweenExclusiveTest02.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenExclusiveTest02868()
{
    bool b;
    b = this.IsBetweenExclusiveTest02<int>(0, new int?(1), 0);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest02761()
{
    bool b;
    b = this.IsBetweenExclusiveTest02<int>(5, new int?(1), 514);
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenExclusiveTest02551()
{
    bool b;
    b = this.IsBetweenExclusiveTest02<int>(0, default(int?), 0);
    Assert.AreEqual<bool>(false, b);
}
	}
}
