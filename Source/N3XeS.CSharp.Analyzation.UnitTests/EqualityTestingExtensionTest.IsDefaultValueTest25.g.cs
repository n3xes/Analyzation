using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <copyright company="John Caruthers" file="EqualityTestingExtensionTest.IsDefaultValueTest25.g.cs">Copyright (c) 2013, John Caruthers</copyright>
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
public void IsDefaultValueTest2572()
{
    bool b;
    b = this.IsDefaultValueTest25(default(ushort?));
    Assert.AreEqual<bool>(true, b);
}

[TestMethod]
[PexGeneratedBy(typeof(EqualityTestingExtensionTest))]
public void IsDefaultValueTest25771()
{
    bool b;
    b = this.IsDefaultValueTest25(new ushort?((ushort)0));
    Assert.AreEqual<bool>(false, b);
}
	}
}
