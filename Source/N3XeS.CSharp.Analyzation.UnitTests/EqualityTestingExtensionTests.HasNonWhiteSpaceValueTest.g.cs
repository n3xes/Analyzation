using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright file="EqualityTestingExtensionTests.HasNonWhiteSpaceValueTest.g.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingExtensionTests
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest162()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest((string)null);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest551()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest("");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest262()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest("\0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest994()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest("\t");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest121()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest("Ā");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest75()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest("\t\0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTests))]
public void HasNonWhiteSpaceValueTest133()
{
    bool b;
    b = this.HasNonWhiteSpaceValueTest("\t\t");
    Assert.AreEqual<bool>(false, b);
}
	}
}
