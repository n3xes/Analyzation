using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingUtilityTest.IsDefaultValueTest09.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsDefaultValueTest09297()
{
    bool b;
    b = this.IsDefaultValueTest09(new decimal?(0e-4M));
    Assert.AreEqual<bool>(false, b);
}
	}
}
