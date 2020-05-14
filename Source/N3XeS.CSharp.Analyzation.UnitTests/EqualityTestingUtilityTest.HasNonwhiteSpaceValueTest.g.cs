using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingUtilityTest.HasNonwhiteSpaceValueTest.g.cs">Copyright (c) 2013, John Caruthers</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace N3XeS.CSharp.Analyzation.Utilities.UnitTests
{
	public partial class EqualityTestingUtilityTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest162()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest((string)null);
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest551()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest("");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest262()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest("\0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest994()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest("\t");
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest121()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest("Ā");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest75()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest("\t\0");
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void HasNonwhiteSpaceValueTest133()
{
    bool b;
    b = this.HasNonwhiteSpaceValueTest("\t\t");
    Assert.AreEqual<bool>(false, b);
}
	}
}
