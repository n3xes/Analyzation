using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingUtilityTest.IsDefaultValueTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsDefaultValueTest05244()
{
    bool b;
    b = this.IsDefaultValueTest05(new byte?((byte)1));
    Assert.AreEqual<bool>(false, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingUtilityTest))]
public void IsDefaultValueTest0572()
{
    bool b;
    b = this.IsDefaultValueTest05(default(byte?));
    Assert.AreEqual<bool>(true, b);
}
	}
}
