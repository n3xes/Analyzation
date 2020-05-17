using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="GenericRelationalTestingExtensionTests.IsBetweenTest03.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsBetweenTest03857()
{
    bool b;
    b = this.IsBetweenTest03<int>(1, default(int?), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest03724()
{
    bool b;
    b = this.IsBetweenTest03<int>(1, new int?(0), default(int?));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest03393()
{
    bool b;
    b = this.IsBetweenTest03<int>(1, new int?(0), new int?(0));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(GenericRelationalTestingExtensionTests))]
public void IsBetweenTest03841()
{
    bool b;
    b = this.IsBetweenTest03<int>(0, new int?(0), new int?(1));
    Assert.AreEqual<bool>(true, b);
}
	}
}
