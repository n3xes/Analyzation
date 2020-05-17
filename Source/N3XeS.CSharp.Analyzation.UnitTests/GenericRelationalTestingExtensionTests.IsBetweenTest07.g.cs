using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingExtensionTests.IsBetweenTest07.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Extensions.Tests
{
	public partial class GenericRelationalTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest07904()
{
    bool b;
    b = this.IsBetweenTest07<int>(default(int?), default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest07538()
{
    bool b;
    b = this.IsBetweenTest07<int>(new int?(0), default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest07579()
{
    bool b;
    b = this.IsBetweenTest07<int>(new int?(0), new int?(0), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest07128()
{
    bool b;
    b = this.IsBetweenTest07<int>(new int?(0), new int?(0), new int?(0));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest07393()
{
    bool b;
    b = this.IsBetweenTest07<int>(new int?(1), new int?(0), new int?(0));
    Assert.AreEqual<bool>(false, b);
}
	}
}
