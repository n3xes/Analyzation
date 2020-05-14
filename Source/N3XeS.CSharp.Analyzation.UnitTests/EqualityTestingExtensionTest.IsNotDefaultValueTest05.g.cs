using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingExtensionTest.IsNotDefaultValueTest05.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
	public partial class EqualityTestingExtensionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsNotDefaultValueTest05402()
{
    bool b;
    b = this.IsNotDefaultValueTest05(new byte?((byte)1));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsNotDefaultValueTest05162()
{
    bool b;
    b = this.IsNotDefaultValueTest05(default(byte?));
    Assert.AreEqual<bool>(false, b);
}
	}
}
